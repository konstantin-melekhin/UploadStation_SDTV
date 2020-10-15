Imports System
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.DateTime
Imports System.Text


Public Class WorkForm
    Dim SNLabelCount, IDLabelCount As Integer, LabelScenarioID As Integer = 1
    Dim PrintSN, PrintID As Boolean
    Dim LOTID, IDApp, LenSN As Integer
    Dim PCInfo As New ArrayList() 'PCInfo = (App_ID, App_Caption, lineID, LineName, StationName,CT_ScanStep)
    Dim LOTInfo As New ArrayList() 'LOTInfo = (Model,LOT,SMTRangeChecked,SMTStartRange,SMTEndRange,ParseLog)
    Dim ShiftCounterInfo As New ArrayList() 'ShiftCounterInfo = (ShiftCounterID,ShiftCounter,LOTCounter)

    Public Sub New(LOTIDWF As Integer, IDApp As Integer)
        InitializeComponent()
        Me.LOTID = LOTIDWF
        Me.IDApp = IDApp
    End Sub
    Private Sub WorkForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Устанавливаем дефолты при загоузке формы 
        Controllabel.Text = ""
        'получение данных о станции
        PCInfo = GetPCInfo(IDApp)
        LabelAppName.Text = PCInfo(1)
        Label_StationName.Text = PCInfo(5)
        Lebel_StationLine.Text = PCInfo(3)
        TextBox1.Text = "App_ID = " & PCInfo(0) & vbCrLf &
                        "App_Caption = " & PCInfo(1) & vbCrLf &
                        "lineID = " & PCInfo(2) & vbCrLf &
                        "LineName = " & PCInfo(3) & vbCrLf &
                        "StationID = " & PCInfo(4) & vbCrLf &
                        "StationName = " & PCInfo(5) & vbCrLf &
                        "CT_ScanStepID = " & PCInfo(6) & vbCrLf &
                        "CT_ScanStep = " & PCInfo(7) & vbCrLf 'PCInfo
        'получение данных о текущем лоте
        LOTInfo = GetCurrent_SDTV(LOTID)
        LenSN = 23
        TextBox2.Text = "Full_LOT_Name = " & LOTInfo(0) & vbCrLf &
                        "LOT = " & LOTInfo(1) & vbCrLf &
                        "Specification = " & LOTInfo(2) & vbCrLf &
                        "Model = " & LOTInfo(3) & vbCrLf &
                        "LOTID = " & LOTInfo(4) & vbCrLf &
                        "ModelID = " & LOTInfo(5) & vbCrLf &
                        "IsActive = " & LOTInfo(6) & vbCrLf &
                        "IsHDCPUpload = " & LOTInfo(7) & vbCrLf &
                        "IsCertUpload = " & LOTInfo(8) & vbCrLf &
                        "IsMACUpload = " & LOTInfo(9) & vbCrLf &
                        "ModelCheck = " & LOTInfo(10) & vbCrLf &
                        "SWRead = " & LOTInfo(11) & vbCrLf &
                        "SWGS1Read = " & LOTInfo(12) & vbCrLf &
                        "Manufacture = " & LOTInfo(13) & vbCrLf &
                        "Operator = " & LOTInfo(14) & vbCrLf &
                        "MarketID = " & LOTInfo(15) & vbCrLf &
                        "PTID = " & LOTInfo(16)
        L_FullLot.Text = LOTInfo(0)
        L_LOT.Text = LOTInfo(1)
        L_Model.Text = LOTInfo(3)

        'Настройки COM портов
        UploadSerialPort.Close()
        UploadSerialPort.PortName = "com9" 'сделатьсписок выбираемых портов
        UploadSerialPort.BaudRate = 115200
        UploadSerialPort.DataBits = 8
        UploadSerialPort.Parity = Parity.None
        UploadSerialPort.StopBits = StopBits.One
        UploadSerialPort.Handshake = Handshake.None
        UploadSerialPort.Encoding = System.Text.Encoding.Default 'very important!
        PrintSerialPort.PortName = "com3"
        PrintSerialPort.BaudRate = 115200
        'проверкака ком порта прошивки
        Try
            UploadSerialPort.Open()
            UploadSerialPort.Close()
        Catch ex As Exception
            PrintLabel(Controllabel, "Проверьте подключение COM 9", 12, 193, Color.Red) ' если не настроен ком порт для печати
            BT_StartUpload.Enabled = False
        End Try

        'задаем условие проверки уникальности и печати этикеток
        SNLabelCount = SettingsForm.TB_LabelSNCount.Text
        PrintSN = SettingsForm.CheckBoxSN.Checked
        IDLabelCount = SettingsForm.TB_LabelIDCount.Text
        PrintID = SettingsForm.CheckBoxID.Checked
        'Требуется печать или нет
        'If PrintSN = True Or PrintID = True Then
        '    Try
        '        PrintSerialPort.Open()
        '        PrintSerialPort.Close()
        '    Catch ex As Exception
        '        PrintLabel(Controllabel, Controllabel.Text & vbCrLf & "Проверьте подключение COM 3", 12, 193, Color.Red) ' если не настроен ком порт для печати
        '        SerialTextBox.Enabled = False
        '    End Try
        'End If
        'Параметры для печати этикеток
        GetPrinterSettings(LabelScenarioID, TB_IDCode_X, TB_IDCode_Y, TB_IDText_X, TB_IDText_Y, TB_IDNum_X)
        If PrSet = False Then
            CreatePrinterSettings(LabelScenarioID)
            GetPrinterSettings(LabelScenarioID, TB_IDCode_X, TB_IDCode_Y, TB_IDText_X, TB_IDText_Y, TB_IDNum_X)
        End If
        'запуск счетчика продукции за день
        CurrentTimeTimer.Start()
        ShiftCounterInfo = ShiftCounterStart(PCInfo(4), IDApp, LOTID)
        Label_ShiftCounter.Text = ShiftCounterInfo(1)
        'LB_LOTCounter.Text = ShiftCounterInfo(2)
    End Sub
    ' условия для возврата в окно настроек
    Dim OpenSettings As Boolean
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles BT_OpenSettings.Click
        OpenSettings = True
        Me.Close()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Question As String
        Question = If(OpenSettings = True, "Вы подтверждаете возврат в окно настроек?", "Вы подтверждаете выход из программы?")
        Select Case MsgBox(Question, MsgBoxStyle.YesNo, "")
            Case MsgBoxResult.Yes
                e.Cancel = False
                If OpenSettings = True Then
                    SettingsForm.Show()
                End If
            Case MsgBoxResult.No
                e.Cancel = True
        End Select
        OpenSettings = False
    End Sub ' условия для возврата в окно настроек
    'Часы в программе
    Dim Upd As Boolean
    Private Sub CurrentTimeTimer_Tick(sender As Object, e As EventArgs) Handles CurrentTimeTimer.Tick
        CurrrentTimeLabel.Text = TimeString
        BT_StartUpload.Focus()
        If Upd = True Then
            UpdateResult()
        End If

    End Sub 'Часы в программе
    ''запись в базу при успешных проверках номера
    Dim cycle As Integer
    Dim CASID As String ' переменные для записи в базу 
    Private Sub WriteToDB(ShortSN As String)
        Dim Sql As String = "USE FAS
            update [FAS].[dbo].[SDTV_Upload] set [CASID] = '" & CASID & "',[SWversion] ='" & SW_v & "', [SWGS1version] = '" & SWGS1_v & "',[LDS] = 1, PrintDate = CURRENT_TIMESTAMP
            where SN = " & ShortSN
        RunCommand(Sql)
        'обновление таблицы счетчика дневного выпуска на линии

        Upd = True
    End Sub

    Private Sub UpdateResult()
        ShiftCounterInfo(1) += 1
        Label_ShiftCounter.Text = ShiftCounterInfo(1)
        ShiftCounterUpdateCT(PCInfo(4), PCInfo(0), ShiftCounterInfo(0), ShiftCounterInfo(1), ShiftCounterInfo(2))
        ScanDateLabel.Text = Now
        Dim GridCounter As Integer = ShiftCounterInfo(1)
        Me.DG_UpLog.Rows.Add(GridCounter, SearchedSN(1), Readed_SCID, CASID, "OK", "OK", "OK", "OK", SW_v, SWGS1_v, StartTime, ScanDateLabel.Text)
        'сортировка griв по выбранному столбцу
        DG_UpLog.Sort(DG_UpLog.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        PrintLabel(Controllabel, "Upload complete!", 26, 155, Color.Green, New Font("Microsoft Sans Serif", 40, FontStyle.Bold))
        StopTime = Mid(ScanDateLabel.Text, 11, 9)
        sw1.[Stop]()
        cycle = LSet(Mid(sw1.Elapsed.ToString(), 7), 2)
        BT_StartUpload.Enabled = True
        Upd = False
    End Sub


    '_________________________________________________________________________________________________________________
    'начало работы приложения FAS Upload Station
    '________________________________________________________________________________________________________________
    'окно ввода серийного номера платы
    Dim sw1 'переменная для определения длительности операции
    Dim StartTime, StopTime, Readed_SCID As String

    Private Sub StartUpload(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Then
            'PrintLabel(Controllabel, "Upload in progress!", 26, 155, Color.Yellow, New Font("Microsoft Sans Serif", 40, FontStyle.Bold))
            BT_StartUpload_Click(sender, e)
        End If
    End Sub

    Dim SearchedSN As ArrayList = New ArrayList
    Private Sub BT_StartUpload_Click(sender As Object, e As EventArgs) Handles BT_StartUpload.Click
        StartTime = Mid(ScanDateLabel.Text, 11, 9)
        sw1 = New Stopwatch()
        sw1.Start()
        PrintLabel(Controllabel, "Upload in progress!", 26, 155, Color.Green, New Font("Microsoft Sans Serif", 40, FontStyle.Bold))
        BT_StartUpload.Enabled = False
        AsyncMethod()
    End Sub



    Dim UpRes As Boolean
    Private Sub Upload()
        'ScanDateLabel.Text = Now

        'Обрабатываем нажатие  Enter и  ввода серийного номера в поле сериного номера со всеми условиями согласно настрое лота
        'StartTime = Mid(ScanDateLabel.Text, 11, 9)
        'sw1 = New Stopwatch()
        'sw1.Start()
        '---- Запрос SCID ----
        Readed_SCID = GetDatafromSTB(UploadSerialPort, "AB", "2B000E", Controllabel, "Ошибка при попытке проверки SCID")
        If Readed_SCID <> "" Then
            '---- Поиск в базе Upload считанного SCID ----
            SearchedSN = SelectListString("use FAS
                        SELECT [SN],[FullSN],[MAC],[UploadStationID],[LOTID],[IsLocked],[SmartCardID],
                        [CASID],[SWversion],[SWGS1version],[LDS],[UploadDate],[PrintDate]
                        FROM [FAS].[dbo].[SDTV_Upload]
                        where lotid = " & LOTInfo(4) & " and [SmartCardID] = " & Readed_SCID)
            If SearchedSN.Count <> 0 Then
                'Запускаем процесс прошивки
                UpRes = StartSubUpload()
            ElseIf SearchedSN.Count = 0 Then
                For i = 0 To 3
                    SearchedSN = SelectListString("use fas
                        declare @SN as int
                        select @SN = (select top 1 SN FROM [FAS].[dbo].[SDTV_Upload] where  lotid = " & LOTInfo(4) & " and IsLocked = 0)
                        update [FAS].[dbo].[SDTV_Upload] set IsLocked = 1, UploadStationID = " & PCInfo(4) & ", [SmartCardID] = " & Readed_SCID & " , [PrintDate] = CURRENT_TIMESTAMP where  SN = @SN
                        SELECT [SN],[FullSN],[MAC],[UploadStationID],[LOTID],[IsLocked],[SmartCardID],
                        [CASID],[SWversion],[SWGS1version],[LDS],[UploadDate],[PrintDate]
                        FROM [FAS].[dbo].[SDTV_Upload]
                        where lotid = " & LOTInfo(4) & " and [UploadStationID] = " & PCInfo(4) & " and sn = @SN")
                    If SearchedSN.Count <> 0 Then
                        'Запускаем процесс прошивки
                        UpRes = StartSubUpload()
                        Exit For
                    End If
                Next
            End If
            If UpRes = True Then
                WriteToDB(SearchedSN(0))
            End If
        End If
        'BT_StartUpload.Enabled = True
    End Sub
    Async Function AsyncMethod() As Task
        Await Task.Run(Sub() Upload())
    End Function
    '''_________________________________________________________________________________________________________________
    '' модуль прошивки серийного номера
    'Dim UploadResult As Boolean
    Dim Model, DUID, SW_v, SWGS1_v, ReadedSN As String
    Private Function StartSubUpload() As Boolean
        Dim res As Boolean
        For i = 1 To 8
            Invoke(Function() StartUpload(i))
            Invoke(Sub() Check(i))
            If StartUpload(i) = True Then
                res = True
            Else
                Exit Function
            End If
        Next
        'If UpRes = True Then
        WriteToDB(SearchedSN(0))

        'End If
        Return res
    End Function

    Sub Check(index As Integer)
        ProgressBar1.Value = index
    End Sub

    Private Function StartUpload(t As Integer) As Boolean
        '------------------------------------------------------------------------------------------------------------
        Dim UploadResult As Boolean
        Select Case t
            Case 1
                'ProgressBar1.Value = 0
                'CurrrentTimeLabel.Text = TimeString
                '------------------------------------------------------------------------------------------------------------
                'Запрос Модели приемника
                If LOTInfo(10) = True Then
                    Model = GetDatafromSTB(UploadSerialPort, "AE", "2E00", Controllabel, "Ошибка при чтении модели")
                    If Model = LOTInfo(3) Then
                        UploadResult = True
                        'ProgressBar1.Value = t
                    ElseIf Model <> LOTInfo(3) And Model <> Nothing Then
                        Controllabel.Text = "Модель не соответствует"
                        Controllabel.ForeColor = Color.Red
                        Exit Function
                    ElseIf Model = Nothing Then
                        Exit Function
                    End If
                End If
            Case 2
                '------------------------------------------------------------------------------------------------------------
                'Запрос DUID
                DUID = GetDatafromSTB(UploadSerialPort, "A7", "270008", Controllabel, "Ошибка при чтении DUID")
                If DUID <> Nothing Then
                    CASID = LOTInfo(16) + DUID
                    UploadResult = True
                    'ProgressBar1.Value = t
                Else
                    Exit Function
                End If
            Case 3
                '------------------------------------------------------------------------------------------------------------
                'Запрос SW Version
                If LOTInfo(11) = True Then
                    SW_v = GetDatafromSTB(UploadSerialPort, "AC", "2C00", Controllabel, "Ошибка при чтении версии ПО")
                    If SW_v <> Nothing Then
                        UploadResult = True
                        'ProgressBar1.Value = t
                    Else
                        Exit Function
                    End If
                End If
            Case 4
                '------------------------------------------------------------------------------------------------------------
                'Запрос SW GS1 Version
                If LOTInfo(12) = True Then
                    SWGS1_v = GetDatafromSTB(UploadSerialPort, "AD", "2D00", Controllabel, "Ошибка при чтении версии ПО GS1")
                    If SWGS1_v <> Nothing Then
                        UploadResult = True
                        'ProgressBar1.Value = t
                    Else
                        Exit Function
                    End If
                End If
            Case 5
                '------------------------------------------------------------------------------------------------------------
                'Прошивка HDCP
                If LOTInfo(7) = True Then
                    If WriteHDCP(UploadSerialPort, SearchedSN(0), Controllabel, "Ошибка при прошивке HDCP") = True Then
                        UploadResult = True
                        'ProgressBar1.Value = t
                    Else
                        Exit Function
                    End If
                End If
            Case 6
                '------------------------------------------------------------------------------------------------------------
                'Прошивка CERT
                If LOTInfo(8) = True Then
                    If WriteCERT(UploadSerialPort, SearchedSN(0), Controllabel, "Ошибка при прошивке сертификата") = True Then
                        UploadResult = True
                        'ProgressBar1.Value = t
                    Else
                        Exit Function
                    End If
                End If
            Case 7
                '------------------------------------------------------------------------------------------------------------
                'Прошивка MAC
                If LOTInfo(9) = True Then
                    If WriteMAC(UploadSerialPort, SearchedSN(2), Controllabel, "Ошибка при прошивке MAC адреса") = True Then
                        UploadResult = True
                        'ProgressBar1.Value = t
                    Else
                        Exit Function
                    End If
                End If
            Case 8
                '------------------------------------------------------------------------------------------------------------
                'прошивка SN
                EraseSN(UploadSerialPort)
                If SearchedSN(1) = "" Then
                    MsgBox("нет номера")
                End If
                ReadedSN = SetSN(UploadSerialPort, SearchedSN(1), Controllabel, "Ошибка при прошивке серийного номера")
                If ReadedSN = SearchedSN(1) Then
                    UploadResult = True
                    'ProgressBar1.Value = t
                ElseIf ReadedSN <> SearchedSN(1) And ReadedSN <> Nothing Then
                    Controllabel.Text = "Считанный номер " & ReadedSN & " не соответствует прошитому " & SearchedSN(1)
                    Controllabel.ForeColor = Color.Red
                    Exit Function
                ElseIf ReadedSN = Nothing Then
                    Exit Function
                End If
        End Select
        Return UploadResult
    End Function





    '__________________________________________________________________________________________________________________________________________
    'печать серийного номера
    Private Sub PrintSNLabel(SN As Integer)
        Dim PrintData As ArrayList = New ArrayList(SelectListString("select format (printdate, 'dd:MM:yyyy'),format (printdate, 'HH:mm:ss'), [FullSN]  
                                                                            FROM [FAS].[dbo].[SDTV_Upload]  where sn = " & SN))
        Dim SNText As String = Mid(PrintData(2), 0, 2) & Mid(PrintData(2), 3, 2) & Mid(PrintData(2), 5, 2) &
            Mid(PrintData(2), 7, 4) & Mid(PrintData(2), 11, 2) & Mid(PrintData(2), 13, 3) & Mid(PrintData(2), 16)
        '90 01 01 2020 01 979 40004109
        If PrintSN = True Then
            PrintSerialPort.Open()
            PrintSerialPort.Write(LabelSN(LOTInfo(3), PrintData(0), PrintData(1), SNText, PrintData(2), SNLabelCount, "A")) 'ответ в COM порт
            PrintSerialPort.Close()
        End If
    End Sub

    'Печать номера ID 
    Private Sub PrintIDLabel()
        If PrintID = True Then
            PrintSerialPort.Open()
            PrintSerialPort.Write(LabelID(Readed_SCID, IDLabelCount, "A")) 'ответ в COM порт
            PrintSerialPort.Close()
        End If
    End Sub

    ''Настройка положения ID номера
    Private Sub BT_PrinterSettings_Click(sender As Object, e As EventArgs) Handles BT_PrinterSettings.Click
        GB_PrinterSettings.Visible = True
    End Sub

    Private Sub BT_ClosePrintSet_Click(sender As Object, e As EventArgs) Handles BT_ClosePrintSet.Click
        GB_PrinterSettings.Visible = False
    End Sub

    Private Sub BT_SevePrintSettings_Click(sender As Object, e As EventArgs) Handles BT_SevePrintSettings.Click
        fs = File.Create(PrintSetpath)
        info = New UTF8Encoding(True).GetBytes(TB_IDCode_X.Text & "," & TB_IDCode_Y.Text & "," & TB_IDText_X.Text & "," & TB_IDText_Y.Text & "," & TB_IDNum_X.Text)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
End Class

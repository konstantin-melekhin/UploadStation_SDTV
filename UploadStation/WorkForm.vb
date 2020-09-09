Imports System
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.DateTime
Imports System.Text
Imports Library_2

Public Class WorkForm
    Dim LOTID, LineID, IDApp, StationID, SNLabelCount, IDLabelCount, LabelScenarioID As Integer
    Dim ModelName, LineNumber, PTID, PCBID As String
    Dim CheckDublicateSCID, PrintSN, PrintID, HDCPUpload, CertUpload,
        MACUpload, CheckModel, SWVersion, SWGS1Version, ExitToSet, RePrint As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Устанавливаем дефолты при загоузке формы 
        'Переносим константы из формы настроек в рабочую форму. Данные получаем из таблицы M_Lots
        Controllabel.Text = ""
        IDApp = SettingsForm.IDApp
        L_AppName.Text = SettingsForm.LabelAppName.Text
        StationID = SettingsForm.StationID
        L_StationName.Text = SettingsForm.Label_StationName.Text
        L_Line.Text = SettingsForm.Lebel_StationLine.Text
        LineID = SettingsForm.LineID
        LineNumber = L_Line.Text
        L_LOT.Text = SettingsForm.GetUploadParametr(SettingsForm.SelectedRow, 0)
        L_FullLot.Text = SettingsForm.GetUploadParametr(SettingsForm.SelectedRow, 1)
        L_Model.Text = SettingsForm.GetUploadParametr(SettingsForm.SelectedRow, 2)
        ModelName = L_Model.Text
        LOTID = SettingsForm.GetUploadParametr(SettingsForm.SelectedRow, 6)
        CheckDublicateSCID = SettingsForm.CheckBoxDublicateSCID.Checked
        HDCPUpload = SettingsForm.GetUploadParametr(SettingsForm.SelectedRow, 7)
        CertUpload = SettingsForm.GetUploadParametr(SettingsForm.SelectedRow, 8)
        MACUpload = SettingsForm.GetUploadParametr(SettingsForm.SelectedRow, 9)
        CheckModel = SettingsForm.GetUploadParametr(SettingsForm.SelectedRow, 10)
        SWVersion = SettingsForm.GetUploadParametr(SettingsForm.SelectedRow, 11)
        SWGS1Version = SettingsForm.GetUploadParametr(SettingsForm.SelectedRow, 12)
        '_____________________________________________________________________________
        LabelScenarioID = SettingsForm.DG_LotList.Rows(SettingsForm.SelectedRow).Cells(13).Value
        GetPrinterSettings(LabelScenarioID, TB_IDCode_X, TB_IDCode_Y, TB_IDText_X, TB_IDText_Y, TB_IDNum_X)
        If PrSet = False Then
            CreatePrinterSettings(LabelScenarioID)
            GetPrinterSettings(LabelScenarioID, TB_IDCode_X, TB_IDCode_Y, TB_IDText_X, TB_IDText_Y, TB_IDNum_X)
        End If
        '_____________________________________________________________________________
        PTID = SettingsForm.DG_LotList.Rows(SettingsForm.SelectedRow).Cells(14).Value

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
            SerialTextBox.Enabled = False
            ExitToSet = True ' если не настроен ком порт для печати
        End Try

        'задаем условие проверки уникальности и печати этикеток
        SNLabelCount = SettingsForm.TB_LabelSNCount.Text
        PrintSN = SettingsForm.CheckBoxSN.Checked
        IDLabelCount = SettingsForm.TB_LabelIDCount.Text
        PrintID = SettingsForm.CheckBoxID.Checked
        'Требуется печать или нет
        If PrintSN = True Or PrintID = True Then
            Try
                PrintSerialPort.Open()
                PrintSerialPort.Close()
            Catch ex As Exception
                SerialTextBox.Enabled = False
                ExitToSet = True ' если не настроен ком порт для печати
            End Try
        End If
        'Запуск программы
        '___________________________________________________________
        GB_UserData.Location = New Point(10, 12)
        TB_RFIDIn.Focus()
        'запуск счетчика продукции за день
        GetTimeSec()
        ShiftCounterStart(CurentTimeSec, StationID, IDApp)
        ShiftCounterID = ShiftPapameters(0)
        ShiftCounter = ShiftPapameters(1)
        Label_ShiftCounter.Text = ShiftCounter
        If ExitToSet = True Then
            Controllabel.Text = "Проверьте подключение COM порта. " & vbCrLf & "Требуется вернуться в окно настроек."
            Controllabel.ForeColor = Color.Red
        End If
    End Sub

    'регистрация пользователя
    Dim RFID As String
    Private Sub TB_RFIDIn_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_RFIDIn.KeyDown
        TB_RFIDIn.MaxLength = 10
        If e.KeyCode = Keys.Enter And TB_RFIDIn.TextLength = 10 Then ' если длина номера равна 10, то запускаем процесс
            GetUserData(TB_RFIDIn.Text, GB_UserData, GB_WorkAria, L_UserName, TB_RFIDIn)
            UserID = UserData(0)
            UserGroup = UserData(1)
            SerialTextBox.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            TB_RFIDIn.Clear()
        End If
    End Sub
    ' условия для возврата в окно настроек
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BT_OpenSettings.Click, BT_LOGInClose.Click
        If MsgBox("Вы уверены в том, что собираетесь вернуться" & vbCrLf & "в окно настроек ЛОТа?", vbYesNo) = vbYes Then
            SettingsForm.Show()
            Me.Close()
        End If
    End Sub
    '' условия для выхода из приложения
    Private Sub BT_CloseApp_Click(sender As Object, e As EventArgs) Handles BT_CloseApp.Click
        If MsgBox("Вы уверены в том, что собираетесь выйти из прриложения?", vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub
    'запуск таймера
    Private Sub CurrentTimeTimer_Tick(sender As Object, e As EventArgs) Handles CurrentTimeTimer.Tick
        CurrentTimeTimer.Start()
        CurrrentTimeLabel.Text = TimeString
    End Sub
    Dim CurentTimeSec As Integer
    Private Sub GetTimeSec()
        CurrentTimeTimer.Start()
        CurrrentTimeLabel.Text = TimeString
        CurentTimeSec = CurrrentTimeLabel.Text.Substring(0, 2) * 3600 + CurrrentTimeLabel.Text.Substring(3, 2) * 60 + CurrrentTimeLabel.Text.Substring(6, 2)
    End Sub
    '_________________________________________________________________________________________________________________
    'начало работы приложения FAS Upload Station
    '________________________________________________________________________________________________________________
    'окно ввода серийного номера платы
    'окно ввода серийного номера
    Dim sw1 'переменная для определения длительности операции
    Dim StartTime, StopTime As String
    Dim UPD As Array 'Upload Data Array
    Private Sub SerialTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SerialTextBox.KeyDown
        ScanDateLabel.Text = Now
        StartTime = Mid(ScanDateLabel.Text, 11, 9)
        IsUsed = False And IsActiv = False And IsUploaded = False And IsPacked = False
        'Обрабатываем нажатие  Enter и  ввода серийного номера в поле сериного номера со всеми условиями согласно настрое лота
        If e.KeyCode = Keys.Enter And SerialTextBox.TextLength = 23 Then
            sw1 = New Stopwatch()
            sw1.Start()
            CheckSN(Mid(SerialTextBox.Text, 16))
            If CheckSNResult = True Then
                UPD = LoadSNData(Mid(SerialTextBox.Text, 16), DG_SNTable)
                'функция LoadSNData возвращает:
                ' UploadData = {1, MACTable, HDCPName, CertName, FullSTBSN, LabelDate, LabelTime, PrintCodeSN, PrintTextSN}
                If UPD(0) = 1 Then
                    StartSubUpload()
                    If UploadResult = True Then
                        Controllabel.Text = SerialTextBox.Text & " проверен." & vbCrLf & ReadedSN & " номер успешно прошит!"
                        Controllabel.ForeColor = Color.Green
                        PrintSNLabel(LabelScenarioID)
                        PrintIDLabel(LabelScenarioID)
                        WriteToDB(Mid(SerialTextBox.Text, 16), UseReapload, Replace)
                        SerialTextBox.Clear() ' чистим сн текст бокс
                        Exit Sub
                    Else
                        SerialTextBox.Clear()
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            Else
                SerialTextBox.Clear()
            End If
            ' условие если длина номера не соответствует заданной длине.
        ElseIf e.KeyCode = Keys.Enter Then
            Controllabel.Text = SerialTextBox.Text & " не верный номер"
            Controllabel.ForeColor = Color.Red
            SerialTextBox.Clear()
        End If
    End Sub
    ' Проверка введенного полного серийного номера по короткому номеру (последние 8 знаков)!!!!
    Dim IsUsed, IsActiv, IsUploaded, IsPacked, CheckSNResult, InRapair, UseReapload, Replace As Boolean
    Dim Readed_SCID, IsUploadText, IsPackText As String
    Private Sub CheckSN(ShortSN As String)
        SQL = "Use FAS 
            SELECT ST.[PCBID],[IsUsed],[IsActive],[IsUploaded],[IsWeighted],[IsPacked],[InRepair]
            FROM [FAS].[dbo].[FAS_SerialNumbers]  as SN
            left join dbo.FAS_Start as ST On St.SerialNumber = SN.SerialNumber
            where LOTID = " & LOTID & " and sn.SerialNumber =  " & ShortSN
        LoadGridFromDB(DG_CheckSN, SQL)
        If DG_CheckSN.Rows.Count <> 0 Then
            PCBID = DG_CheckSN.Rows(0).Cells(0).Value
            IsUsed = DG_CheckSN.Rows(0).Cells(1).Value
            IsActiv = DG_CheckSN.Rows(0).Cells(2).Value
            IsUploaded = DG_CheckSN.Rows(0).Cells(3).Value
            IsPacked = DG_CheckSN.Rows(0).Cells(5).Value
            InRapair = DG_CheckSN.Rows(0).Cells(6).Value
            UseReapload = False
            Replace = False
            Readed_SCID = GetDatafromSTB(UploadSerialPort, "AB", "2B000E", Controllabel, "Ошибка при попытке проверки SCID")
            If Readed_SCID <> "" Then
                CheckSCID(Readed_SCID)
                CheckSNResult = False
                'проверка статусов чекпоинтов
                If IsUsed = True And IsActiv = True And IsUploaded = False And IsPacked = False Then
                    If CkSC(0) = "0" Then
                        CheckSNResult = True
                        UseReapload = False
                    ElseIf CkSC(0) <> "0" And CkSC(6) = Nothing And CheckDublicateSCID = True Then
                        Controllabel.Text = IsUploadText
                        Controllabel.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
                        Controllabel.ForeColor = Color.Red
                        SerialTextBox.Clear()
                    ElseIf CkSC(0) <> "0" And CkSC(6) = Nothing And CheckDublicateSCID = False Then
                        If CkSC(6) = Nothing Then
                            SQL = "use fas delete [FAS].[dbo].[FAS_Upload] where SmartCardID = " & CkSC(2)
                            RunCommand(SQL)
                            Replace = True
                            CheckSNResult = True
                        Else
                            Controllabel.Text = IsPackText
                            Controllabel.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
                            Controllabel.ForeColor = Color.Red
                            CheckSNResult = False
                        End If
                    ElseIf CkSC(0) <> "0" And CkSC(6) = True Then
                        Controllabel.Text = IsPackText
                        Controllabel.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
                        Controllabel.ForeColor = Color.Red
                    End If
                ElseIf IsUsed = True And IsActiv = False And InRapair = True Then
                    CheckSNResult = False
                    Controllabel.Text = SerialTextBox.Text & "  номер находится в ремонте"
                    Controllabel.ForeColor = Color.Red
                    SerialTextBox.Clear()
                ElseIf IsActiv = False And InRapair = False Then
                    CheckSNResult = False
                    Controllabel.Text = SerialTextBox.Text & " удален из базы"
                    Controllabel.ForeColor = Color.Red
                    SerialTextBox.Clear()
                ElseIf IsUsed = True And IsActiv = True And IsUploaded = True And CheckDublicateSCID = True Then
                    If CkSC(1) = SerialTextBox.Text And CkSC(2) = Readed_SCID Then
                        UseReapload = True
                        CheckSNResult = True
                    Else
                        Controllabel.Text = IsUploadText
                        Controllabel.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
                        Controllabel.ForeColor = Color.Red
                        SerialTextBox.Clear()
                        CheckSNResult = False
                    End If
                ElseIf IsUsed = True And IsActiv = True And IsUploaded = True And CheckDublicateSCID = False Then
                    If CkSC(6) = Nothing Then
                        SQL = "use fas delete [FAS].[dbo].[FAS_Upload] where SmartCardID = " & CkSC(2)
                        RunCommand(SQL)
                        Replace = True
                        CheckSNResult = True
                    Else
                        Controllabel.Text = IsPackText
                        Controllabel.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
                        Controllabel.ForeColor = Color.Red
                        CheckSNResult = False
                    End If
                Else
                    CheckSNResult = False
                    Controllabel.Text = "Что-то пошло не так! " & vbCrLf & "Попробуйте еще раз, если со второй попытки операция не выполнена, " & vbCrLf & "то отложите приемник!"
                    Controllabel.ForeColor = Color.Red
                    SerialTextBox.Clear()
                End If
            End If
        Else
            Controllabel.Text = "Серийный номер " & SerialTextBox.Text & vbCrLf & "Не найден в этом ЛОТе!"
            Controllabel.ForeColor = Color.Red
            SerialTextBox.Clear()
        End If
    End Sub
    Public CkSC() As String
    Private Function CheckSCID(SCID_for_Check As String)
        'Barcode, FullSTBSN,	SmartCardID, LineName,	Upload, Date,	UserName, IsPacked,	LiterName,	LiterIndex,	PalletNum,	BoxNum,	UnitNum,	Packing Date,	UserName
        Dim Bcd, FLSN, SC, LN, UPDt, UPUsN, IsP, Lit, LX, P, B, U, PkDt, PkUsN As String
        IsUploadText = ""
        IsPackText = ""
        SQL = "Use FAS 
            SELECT Un.Barcode, Fst.FullSTBSN,[SmartCardID], L.LineName,FORMAT([UploadDate],'dd.MM.yyyy HH:mm:ss', 'de-de') as 'Upload Date',u.UserName,
            sn.IsPacked, lit.LiterName,[LiterIndex],[PalletNum],[BoxNum],[UnitNum],FORMAT([PackingDate],'dd.MM.yyyy HH:mm:ss', 'de-de') as 'Packing Date', Us.UserName
            FROM [FAS].[dbo].[FAS_Upload] As UpSt
            left join FAS_SerialNumbers as SN On sn.SerialNumber = UpSt.SerialNumber
            left join FAS_Lines as L on L.LineID = UpSt.LineID
            left join FAS_Start As FSt on Fst.SerialNumber = UpSt.SerialNumber
            left join [PSIGMA.FLAT].[dbo].[TRC_Unit]as Un on Un.ID = Fst.PCBID
            left join FAS_PackingGS As Pack On Pack.SerialNumber = UpSt.SerialNumber
            left join FAS_Users as U on U.UserID = UpSt.UploadByID
            left join FAS_Users as Us on Us.UserID = Pack.PackingByID
            left join FAS_Liter as Lit On lit.ID = pack.LiterID
            where UpSt.SmartCardID =" & SCID_for_Check
        LoadGridFromDB(DG_IsPacked, SQL)
        If DG_IsPacked.Rows.Count <> 0 Then
            Bcd = DG_IsPacked.Rows(0).Cells(0).Value
            FLSN = DG_IsPacked.Rows(0).Cells(1).Value
            SC = DG_IsPacked.Rows(0).Cells(2).Value
            LN = DG_IsPacked.Rows(0).Cells(3).Value
            UPDt = DG_IsPacked.Rows(0).Cells(4).Value
            UPUsN = DG_IsPacked.Rows(0).Cells(5).Value
            If DG_IsPacked.Rows(0).Cells(6).Value <> Nothing Then
                IsP = DG_IsPacked.Rows(0).Cells(6).Value
                Lit = DG_IsPacked.Rows(0).Cells(7).Value
                LX = DG_IsPacked.Rows(0).Cells(8).Value
                P = DG_IsPacked.Rows(0).Cells(9).Value
                B = DG_IsPacked.Rows(0).Cells(10).Value
                U = DG_IsPacked.Rows(0).Cells(11).Value
                PkDt = DG_IsPacked.Rows(0).Cells(12).Value
                PkUsN = DG_IsPacked.Rows(0).Cells(13).Value
            End If
            CkSC = {Bcd, FLSN, SC, LN, UPDt, UPUsN, IsP, Lit, LX, P, B, U, PkDt, PkUsN}
            'Переменные приемник прошит/упакован
            IsUploadText = "Приемник имеет ID номер " & CkSC(2) & "," & vbCrLf & "который пренодлежит СН " & CkSC(1) & vbCrLf &
                "PCB " & CkSC(0) & " Линия " & CkSC(3) & vbCrLf & "Дата " & CkSC(4) & " Пользователь: " & CkSC(5)
            IsPackText = "ID номер " & CkSC(2) & " уже упакован с СН" & CkSC(1) & vbCrLf &
            "Литер " & CkSC(7) + CkSC(8) & ", Паллет " & CkSC(9) & ", Группоавая " & CkSC(10) & ", Приемник № " & CkSC(11) & vbCrLf &
            "Дата упаковки " & CkSC(12) & " Пользователем " & CkSC(13)
        Else
            CkSC = {"0"}
        End If
        Return CkSC
    End Function
    'запись в базу при успешных проверках номера
    Dim cycle As Integer
    Dim CASID As String ' переменные для записи в базу 
    Private Sub WriteToDB(ShortSN As String, UseReapload As Boolean, Replase As Boolean)
        If UseReapload = True And Replace = False Then
            SQL = "Use FAS 
            update [FAS].[dbo].[FAS_Upload] set SmartCardID = '" & Readed_SCID & "' , CASID = '" & CASID & "' where SerialNumber = " & ShortSN
            RunCommand(SQL)
        ElseIf UseReapload = False Or Replace = True Then
            SQL = "USE FAS
            insert into  [FAS].[dbo].[FAS_Upload] ([SerialNumber],[MAC],[LineID],[SmartCardID],[CASID],[SWversion],[SWGS1version],[LDS],[UploadDate],[UploadByID]) values
            (" & ShortSN & ", '" & UPD(1) & "', " & LineID & ", " & Readed_SCID & ",'" & CASID & "','" & SW_v & "','" & SWGS1_v & "',1,CURRENT_TIMESTAMP," & UserID & ")
            Update [FAS].[dbo].[FAS_SerialNumbers] set IsUploaded = 1 where  SerialNumber = " & ShortSN
            RunCommand(SQL)
            'обновление таблицы счетчика дневного выпуска на линии
            ShiftCounter = ShiftCounter + 1
            Label_ShiftCounter.Text = ShiftCounter
            ShiftCounterUpdate(ShiftCounter, ShiftCounterID)
        End If
        ScanDateLabel.Text = Now
        StopTime = Mid(ScanDateLabel.Text, 11, 9)
        sw1.[Stop]()
        cycle = LSet(Mid(sw1.Elapsed.ToString(), 7), 2)
        Dim GridCounter As Integer = ShiftCounter
        Me.DG_UpLog.Rows.Add(GridCounter, SerialTextBox.Text, Readed_SCID, CASID, UPD(2), UPD(3), UPD(1), "OK", SW_v, SWGS1_v, StartTime, ScanDateLabel.Text)
        'сортировка griв по выбранному столбцу
        DG_UpLog.Sort(DG_UpLog.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        AddToOperLogFasUpload(PCBID, LineID, StationID, IDApp, UserID, ShortSN, RePrint, Replase, "Null", Readed_SCID)
    End Sub
    ''_________________________________________________________________________________________________________________
    '' модуль прошивки серийного номера
    Dim UploadResult As Boolean
    Dim Model, DUID, SW_v, SWGS1_v, ReadedSN As String
    Private Sub StartSubUpload()
        UploadResult = True
        For i = 1 To 10
            If UploadResult = True Then
                StartUpload(i)
            Else
                Exit Sub
            End If
        Next
    End Sub
    Private Sub StartUpload(t As Integer)
        '------------------------------------------------------------------------------------------------------------
        Select Case t
            Case 1
                ProgressBar1.Value = 0
                CurrrentTimeLabel.Text = TimeString
                '------------------------------------------------------------------------------------------------------------
                'Запрос Модели приемника
                If CheckModel = True Then
                    Model = GetDatafromSTB(UploadSerialPort, "AE", "2E00", Controllabel, "Ошибка при чтении модели")
                    If Model = ModelName Then
                        UploadResult = True
                        ProgressBar1.Value = t
                    ElseIf Model <> ModelName  And Model <> Nothing Then
                        Controllabel.Text = "Модель не соответствует"
                        Controllabel.ForeColor = Color.Red
                        UploadResult = False
                        Exit Sub
                    ElseIf Model = Nothing Then
                        UploadResult = False
                        Exit Sub
                    End If
                End If
            Case 2
                '------------------------------------------------------------------------------------------------------------
                'Запрос DUID
                DUID = GetDatafromSTB(UploadSerialPort, "A7", "270008", Controllabel, "Ошибка при чтении DUID")
                If DUID <> Nothing Then
                    CASID = PTID + DUID
                    UploadResult = True
                    ProgressBar1.Value = t
                Else
                    UploadResult = False
                    Exit Sub
                End If
            Case 3
                '------------------------------------------------------------------------------------------------------------
                'Запрос SW Version
                If SWVersion = True Then
                    SW_v = GetDatafromSTB(UploadSerialPort, "AC", "2C00", Controllabel, "Ошибка при чтении версии ПО")
                    If SW_v <> Nothing Then
                        UploadResult = True
                        ProgressBar1.Value = t
                    Else
                        UploadResult = False
                        Exit Sub
                    End If
                End If
            Case 4
                '------------------------------------------------------------------------------------------------------------
                'Запрос SW GS1 Version
                If SWGS1Version = True Then
                    SWGS1_v = GetDatafromSTB(UploadSerialPort, "AD", "2D00", Controllabel, "Ошибка при чтении версии ПО GS1")
                    If SWGS1_v <> Nothing Then
                        UploadResult = True
                        ProgressBar1.Value = t
                    Else
                        UploadResult = False
                        Exit Sub
                    End If
                End If
            Case 5
                '------------------------------------------------------------------------------------------------------------
                'Прошивка HDCP
                If HDCPUpload = True Then
                    If WriteHDCP(UploadSerialPort, Mid(SerialTextBox.Text, 16), Controllabel, "Ошибка при прошивке HDCP") = True Then
                        UploadResult = True
                        ProgressBar1.Value = t
                    Else
                        UploadResult = False
                        Exit Sub
                    End If
                End If
            Case 6
                '------------------------------------------------------------------------------------------------------------
                'Прошивка cert
                If CertUpload = True Then
                    If WriteCERT(UploadSerialPort, Mid(SerialTextBox.Text, 16), Controllabel, "Ошибка при прошивке сертификата") = True Then
                        UploadResult = True
                        ProgressBar1.Value = t
                    Else
                        UploadResult = False
                        Exit Sub
                    End If
                End If
            Case 7
                '------------------------------------------------------------------------------------------------------------
                'Прошивка MAC
                If MACUpload = True Then
                    If WriteMAC(UploadSerialPort, UPD(1), Controllabel, "Ошибка при прошивке MAC адреса") = True Then
                        UploadResult = True
                        ProgressBar1.Value = t
                    Else
                        UploadResult = False
                        Exit Sub
                    End If
                End If

            Case 8
                '------------------------------------------------------------------------------------------------------------
                'прошивка SN
                ReadedSN = SetSN(UploadSerialPort, UPD(4), Controllabel, "Ошибка при прошивке серийного номера")
                If ReadedSN = SerialTextBox.Text Then
                    ProgressBar1.Value = t
                    ProgressBar1.Value = t
                ElseIf ReadedSN <> SerialTextBox.Text And ReadedSN <> Nothing Then
                    Controllabel.Text = "Считанный номер " & ReadedSN & " не соответствует прошитому " & SerialTextBox.Text
                    Controllabel.ForeColor = Color.Red
                    UploadResult = False
                    Exit Sub
                ElseIf ReadedSN = Nothing Then
                    UploadResult = False
                    Exit Sub
                End If
        End Select
    End Sub
    '__________________________________________________________________________________________________________________________________________
    'печать серийного номера
    Private Sub PrintSNLabel(Scenario As Integer)
        If PrintSN = True Then
            PrintSerialPort.Open()
            Select Case Scenario
                Case 1
                    PrintSerialPort.Write(LabelSN(ModelName, UPD(5), UPD(6), UPD(8), UPD(7), SNLabelCount, "A")) 'ответ в COM порт
                Case 2
                    PrintSerialPort.Write(LabelSN(ModelName, UPD(5), UPD(6), UPD(8), UPD(7), SNLabelCount, "B")) 'ответ в COM порт
            End Select
            PrintSerialPort.Close()
        End If
    End Sub
    'Печать номера ID 
    Private Sub PrintIDLabel(Scenario As Integer)
        If PrintID = True Then
            PrintSerialPort.Open()
            Select Case Scenario
                Case 1
                    PrintSerialPort.Write(LabelID(Readed_SCID, IDLabelCount, "A")) 'ответ в COM порт
                Case 2
                    PrintSerialPort.Write(LabelID(Readed_SCID, IDLabelCount, "B")) 'ответ в COM пор
            End Select
            PrintSerialPort.Close()
        End If
    End Sub
    'Настройка положения ID номера
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

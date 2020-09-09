
Imports System.Threading
Imports System.DateTime
Imports Library_2

Public Class SettingsForm_old

    'загрузка формы
    Public LineID As Integer
    Public IDApp, StationID As String
    Private Sub LOT_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'считываем название станции (имя ПК)
        Label_StationName.Text = GetPCName()
        'запрашиваем в базе ID станции по имени ПК
        StationID = GetStationID(Label_StationName.Text)
        'если не найдена, то регистрируем новую станцию и повторно запрашиваем в базе ID станции по имени ПК
        If StationID = "" Then
            StationRegister(Label_StationName.Text)
            StationID = GetStationID(Label_StationName.Text)
        End If
        LabelStationID.Text = StationID
        'при создании приложения прописываем созданный заранее ID приложения из базы (FAS_Aplications)
        IDApp = Label_IDApp.Text
        'определяем имя приложения из базы (FAS_Aplications)
        LabelAppName.Text = GetAppName(IDApp)
        'записываем название Линии 
        Lebel_StationLine.Text = GetLine(StationID, IDApp)
        LineID = GetLineID(StationID, IDApp)

        'условие если номер линии не определен на сервере
        If Lebel_StationLine.Text = "" Then
            DG_LOTListPresent.Visible = False
            'записываем информацию о дальнейшей невозможности использования
            L_Result.Text = "Дальнейшая работа невозможна, " & vbCrLf & "укажите рабочую линию!"
            L_Result.Location = New Point(24, 33)
            L_Result.Font = New Font("Microsoft Sans Serif", 20, FontStyle.Bold)
            L_Result.ForeColor = Color.Red
            L_Result.Visible = True
        End If
        'загружаем список лотов в грид, SQL запрос "LotList" расположен в SQLConnectionMod
        GetLotList_UpStation_GS(DG_LotList)
        'определяем настройки для программы
        CheckBoxDublicateSCID.Checked = True
        CheckBoxID.Checked = True
        GetLotList()
    End Sub

    Private Sub BT_RefreshLOT_Click(sender As Object, e As EventArgs) Handles BT_RefreshLOT.Click
        DG_LOTListPresent.Rows.Clear()
        'DG_LotList.Rows.Clear()
        GetLotList_UpStation_GS(DG_LotList)
        GetLotList()
    End Sub
    'обновляем название линии после настройки или перенастройки
    Public Sub LineUpdate()
        Lebel_StationLine.Text = GetLine(StationID, IDApp)
        LineID = GetLineID(StationID, IDApp)
        If Lebel_StationLine.Text = "" Then
            L_Result.Text = "Дальнейшая работа невозможна, 
укажите рабочую линию!"
        Else
            L_Result.Text = ""
            DG_LOTListPresent.Visible = True
        End If
    End Sub
    'Опредеяем номер выбранной строки в таблице лотов
    Public selRowNum, LOTID, LOTCode As Integer
    Private Sub DG_LOTListPresent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_LOTListPresent.CellClick
        selRowNum = DG_LOTListPresent.CurrentCell.RowIndex
    End Sub

    Private Sub BT_LineSettings_Click(sender As Object, e As EventArgs) Handles BT_LineSettings.Click
        LineSettings.Show()
    End Sub

    Public Model, FullLot, CreateDate As String
    Public InLotQty, ReadyQty, UsedQty As Integer
    Private Sub GetLotList()
        For i = 0 To DG_LotList.RowCount - 1
            LOTCode = DG_LotList.Rows(i).Cells(0).Value
            FullLot = DG_LotList.Rows(i).Cells(1).Value
            Model = DG_LotList.Rows(i).Cells(2).Value
            InLotQty = DG_LotList.Rows(i).Cells(3).Value
            ReadyQty = DG_LotList.Rows(i).Cells(4).Value
            UsedQty = DG_LotList.Rows(i).Cells(5).Value
            LOTID = DG_LotList.Rows(i).Cells(6).Value
            If ReadyQty > 0 Then
                DG_LOTListPresent.Rows.Add(LOTCode, FullLot, Model, InLotQty, ReadyQty, UsedQty, LOTID)
            End If
        Next
        DG_LOTListPresent.Sort(DG_LOTListPresent.Columns(6), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    'Обработка кнопки запуск
    Public LabelScenarioID, SelectedRow As Integer
    Private Sub BT_SelectLot_Click(sender As Object, e As EventArgs) Handles BT_SelectLot.Click
        'определяем LOTCode и LOTID
        LOTID = DG_LOTListPresent.Rows(selRowNum).Cells(6).Value
        If DG_LOTListPresent.Rows.Count <> 0 Then
            For i = 1 To DG_LotList.RowCount - 1
                If DG_LotList.Rows(i).Cells(6).Value = LOTID Then
                    SelectedRow = i
                    Exit For
                End If
            Next
            WorkForm.Show()
            Me.Close()
        Else
            MsgBox("Список ЛОТов отсутствует. Добавьте ЛОТ, либо Запустите FAS Start!")
            Exit Sub
        End If
    End Sub

    Public Function GetUploadParametr(SelectedRow As Integer, selectedCells As Integer)
        Return DG_LotList.Rows(SelectedRow).Cells(selectedCells).Value
    End Function



End Class



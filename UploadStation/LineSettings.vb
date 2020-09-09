Imports Library_2
Public Class LineSettings
    Dim IDApp, StationID As String
    Private Sub LineSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'определяем IDApp для этого приложения
        IDApp = SettingsForm_old.IDApp
        StationID = SettingsForm_old.StationID
        'загружаем список линий
        LoadGridFromDB(DG_LineList, LineList)
        'Выводим названия линий FAS в combobox
        If DG_LineList.Rows.Count <> 0 Then
            For J = 0 To DG_LineList.Rows.Count - 1
                CB_Line.Items.Add(DG_LineList.Rows(J).Cells(1).Value)
            Next
        Else
            MsgBox("Список линий не сформирован, возможно проблемы с сетью!" & vbCr & "Попробуйте перезапустить приложение")
        End If
        'получаем список приложений для данного ПК
        AppRefresh()
        'перетаскиваем название приложения в настройки
        LabAppName.Text = SettingsForm_old.LabelAppName.Text
    End Sub

    Dim LineID As Integer
    Dim AppInList As Boolean
    ' SUB для получения списока приложений для данного ПК
    Private Sub AppRefresh()
        'список приложений для данного ПК
        Sql = "use FAS
        SELECT * FROM [FAS].[dbo].[FAS_App_ListForPC]where StationID = " & StationID
        LoadGridFromDB(DG_AppList, Sql)
    End Sub
    'кнопка обновить список линий
    Private Sub BT_AppRefresh_Click(sender As Object, e As EventArgs) Handles BT_AppRefresh.Click
        AppRefresh()
    End Sub

    Private Sub BT_SaveLine_Click_1(sender As Object, e As EventArgs) Handles BT_SaveLine.Click
        'определяем id выбранной линии
        For J = 0 To DG_LineList.Rows.Count - 1
            If CB_Line.Text = DG_LineList.Rows(J).Cells(1).Value Then
                LineID = DG_LineList.Rows(J).Cells(0).Value
                Exit For
            End If
        Next
        'ищем в списке приложений данное приложение
        For J = 0 To DG_AppList.Rows.Count - 1
            If IDApp = DG_AppList.Rows(J).Cells(1).Value Then
                AppInList = True
                Exit For
            Else
                AppInList = False
            End If
        Next
        'если приложение найдено, то обновляем только номер линии
        If AppInList = True Then
            Sql = "use FAS
            update [FAS].[dbo].[FAS_App_ListForPC]  set LineID = " & LineID & ", CreateDate = CURRENT_TIMESTAMP where StationID = " & StationID & " and App_ID = " & IDApp
            RunCommand(Sql)
            'обновляем список приложений для данного ПК
            AppRefresh()
        Else
            'если не найдено, то создаем новую запись с названием этого ПК и приложения
            Sql = "use FAS
            insert into [FAS].[dbo].[FAS_App_ListForPC] (App_ID,LineID,StationID,CreateDate) 
            values (" & IDApp & "," & LineID & "," & StationID & ",CURRENT_TIMESTAMP)"
            RunCommand(Sql)
            'список приложений для данного ПК
            'обновляем список приложений для данного ПК
            AppRefresh()
        End If
    End Sub
    'возврат в форму настроек лота
    Private Sub BT_Return_Click(sender As Object, e As EventArgs) Handles BT_Return.Click
        Me.Close()
        SettingsForm_old.Show()
        SettingsForm_old.LineUpdate()
    End Sub
End Class




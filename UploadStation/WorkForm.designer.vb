<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WorkForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SerialTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ScanDateLabel = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BT_PrinterSettings = New System.Windows.Forms.Button()
        Me.L_AppName = New System.Windows.Forms.Label()
        Me.L_UserName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.L_StationName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.L_Model = New System.Windows.Forms.Label()
        Me.BT_OpenSettings = New System.Windows.Forms.Button()
        Me.BT_CloseApp = New System.Windows.Forms.Button()
        Me.L_FullLot = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.L_LOT = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.L_Line = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CurrrentTimeLabel = New System.Windows.Forms.Label()
        Me.Controllabel = New System.Windows.Forms.Label()
        Me.GB_WorkAria = New System.Windows.Forms.GroupBox()
        Me.GB_PrinterSettings = New System.Windows.Forms.GroupBox()
        Me.BT_ClosePrintSet = New System.Windows.Forms.Button()
        Me.TB_IDNum_X = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BT_SevePrintSettings = New System.Windows.Forms.Button()
        Me.TB_IDText_Y = New System.Windows.Forms.TextBox()
        Me.TB_IDCode_Y = New System.Windows.Forms.TextBox()
        Me.TB_IDText_X = New System.Windows.Forms.TextBox()
        Me.TB_IDCode_X = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.DG_UpLog = New System.Windows.Forms.DataGridView()
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCIDTab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CASIDTab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HDCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CERT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SWGS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScanDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label_ShiftCounter = New System.Windows.Forms.Label()
        Me.Controllabel2 = New System.Windows.Forms.Label()
        Me.DG_SNTable = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DG_CheckSN = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GB_NotVisible = New System.Windows.Forms.GroupBox()
        Me.DG_Reapload = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DG_IsPacked = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CurrentTimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.UploadSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.PrintSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.TB_RFIDIn = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GB_UserData = New System.Windows.Forms.GroupBox()
        Me.BT_LOGInClose = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GB_WorkAria.SuspendLayout()
        Me.GB_PrinterSettings.SuspendLayout()
        CType(Me.DG_UpLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DG_SNTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_CheckSN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_NotVisible.SuspendLayout()
        CType(Me.DG_Reapload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_IsPacked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_UserData.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialTextBox
        '
        Me.SerialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SerialTextBox.Location = New System.Drawing.Point(17, 325)
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(508, 31)
        Me.SerialTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Serial Number"
        '
        'ScanDateLabel
        '
        Me.ScanDateLabel.AutoSize = True
        Me.ScanDateLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ScanDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ScanDateLabel.Location = New System.Drawing.Point(6, 16)
        Me.ScanDateLabel.Name = "ScanDateLabel"
        Me.ScanDateLabel.Size = New System.Drawing.Size(126, 25)
        Me.ScanDateLabel.TabIndex = 6
        Me.ScanDateLabel.Text = "SCAN TIME"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.ScanDateLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(559, 305)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(221, 51)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ScanDate"
        Me.GroupBox3.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BT_PrinterSettings)
        Me.GroupBox4.Controls.Add(Me.L_AppName)
        Me.GroupBox4.Controls.Add(Me.L_UserName)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.L_StationName)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.L_Model)
        Me.GroupBox4.Controls.Add(Me.BT_OpenSettings)
        Me.GroupBox4.Controls.Add(Me.BT_CloseApp)
        Me.GroupBox4.Controls.Add(Me.L_FullLot)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.L_LOT)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.L_Line)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(840, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(519, 264)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Информация о ЛОТе и станции"
        '
        'BT_PrinterSettings
        '
        Me.BT_PrinterSettings.BackColor = System.Drawing.Color.Transparent
        Me.BT_PrinterSettings.FlatAppearance.BorderSize = 0
        Me.BT_PrinterSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PrinterSettings.ForeColor = System.Drawing.Color.Transparent
        Me.BT_PrinterSettings.Image = Global.UploadStation.My.Resources.Resources.gtkprintreport
        Me.BT_PrinterSettings.Location = New System.Drawing.Point(6, 207)
        Me.BT_PrinterSettings.Name = "BT_PrinterSettings"
        Me.BT_PrinterSettings.Size = New System.Drawing.Size(51, 49)
        Me.BT_PrinterSettings.TabIndex = 28
        Me.BT_PrinterSettings.UseVisualStyleBackColor = False
        '
        'L_AppName
        '
        Me.L_AppName.AutoSize = True
        Me.L_AppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_AppName.Location = New System.Drawing.Point(228, 19)
        Me.L_AppName.Name = "L_AppName"
        Me.L_AppName.Size = New System.Drawing.Size(64, 20)
        Me.L_AppName.TabIndex = 20
        Me.L_AppName.Text = "fasend"
        '
        'L_UserName
        '
        Me.L_UserName.AutoSize = True
        Me.L_UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_UserName.Location = New System.Drawing.Point(228, 147)
        Me.L_UserName.Name = "L_UserName"
        Me.L_UserName.Size = New System.Drawing.Size(174, 20)
        Me.L_UserName.TabIndex = 19
        Me.L_UserName.Text = "Имя пользователя:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Имя пользователя:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Название приложения:"
        '
        'L_StationName
        '
        Me.L_StationName.AutoSize = True
        Me.L_StationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_StationName.Location = New System.Drawing.Point(228, 41)
        Me.L_StationName.Name = "L_StationName"
        Me.L_StationName.Size = New System.Drawing.Size(33, 20)
        Me.L_StationName.TabIndex = 16
        Me.L_StationName.Text = "ПК"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(100, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Название ПК:"
        '
        'L_Model
        '
        Me.L_Model.AutoSize = True
        Me.L_Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_Model.Location = New System.Drawing.Point(228, 127)
        Me.L_Model.Name = "L_Model"
        Me.L_Model.Size = New System.Drawing.Size(57, 20)
        Me.L_Model.TabIndex = 16
        Me.L_Model.Text = "Model"
        '
        'BT_OpenSettings
        '
        Me.BT_OpenSettings.FlatAppearance.BorderSize = 0
        Me.BT_OpenSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_OpenSettings.Image = Global.UploadStation.My.Resources.Resources.settings__1_
        Me.BT_OpenSettings.Location = New System.Drawing.Point(385, 200)
        Me.BT_OpenSettings.Name = "BT_OpenSettings"
        Me.BT_OpenSettings.Size = New System.Drawing.Size(61, 56)
        Me.BT_OpenSettings.TabIndex = 22
        Me.BT_OpenSettings.UseVisualStyleBackColor = True
        '
        'BT_CloseApp
        '
        Me.BT_CloseApp.BackColor = System.Drawing.Color.Transparent
        Me.BT_CloseApp.FlatAppearance.BorderSize = 0
        Me.BT_CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CloseApp.Image = Global.UploadStation.My.Resources.Resources.close
        Me.BT_CloseApp.Location = New System.Drawing.Point(452, 203)
        Me.BT_CloseApp.Name = "BT_CloseApp"
        Me.BT_CloseApp.Size = New System.Drawing.Size(61, 51)
        Me.BT_CloseApp.TabIndex = 23
        Me.BT_CloseApp.UseVisualStyleBackColor = False
        '
        'L_FullLot
        '
        Me.L_FullLot.AutoSize = True
        Me.L_FullLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_FullLot.Location = New System.Drawing.Point(228, 105)
        Me.L_FullLot.Name = "L_FullLot"
        Me.L_FullLot.Size = New System.Drawing.Size(71, 20)
        Me.L_FullLot.TabIndex = 16
        Me.L_FullLot.Text = "FullLOT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(144, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 20)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Модель:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(213, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Полное название ЛОТа:"
        '
        'L_LOT
        '
        Me.L_LOT.AutoSize = True
        Me.L_LOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_LOT.Location = New System.Drawing.Point(228, 83)
        Me.L_LOT.Name = "L_LOT"
        Me.L_LOT.Size = New System.Drawing.Size(42, 20)
        Me.L_LOT.TabIndex = 16
        Me.L_LOT.Text = "LOT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(105, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Номер ЛОТа:"
        '
        'L_Line
        '
        Me.L_Line.AutoSize = True
        Me.L_Line.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_Line.Location = New System.Drawing.Point(228, 63)
        Me.L_Line.Name = "L_Line"
        Me.L_Line.Size = New System.Drawing.Size(43, 20)
        Me.L_Line.TabIndex = 16
        Me.L_Line.Text = "Line"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Линия:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.CurrrentTimeLabel)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox5.Location = New System.Drawing.Point(610, 301)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(219, 55)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Время"
        '
        'CurrrentTimeLabel
        '
        Me.CurrrentTimeLabel.AutoSize = True
        Me.CurrrentTimeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.CurrrentTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CurrrentTimeLabel.Location = New System.Drawing.Point(6, 18)
        Me.CurrrentTimeLabel.Name = "CurrrentTimeLabel"
        Me.CurrrentTimeLabel.Size = New System.Drawing.Size(156, 29)
        Me.CurrrentTimeLabel.TabIndex = 6
        Me.CurrrentTimeLabel.Text = "Current TIME"
        '
        'Controllabel
        '
        Me.Controllabel.AutoSize = True
        Me.Controllabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Controllabel.Location = New System.Drawing.Point(26, 155)
        Me.Controllabel.Name = "Controllabel"
        Me.Controllabel.Size = New System.Drawing.Size(217, 29)
        Me.Controllabel.TabIndex = 21
        Me.Controllabel.Text = "CONTROLLABEL"
        '
        'GB_WorkAria
        '
        Me.GB_WorkAria.Controls.Add(Me.GB_PrinterSettings)
        Me.GB_WorkAria.Controls.Add(Me.ProgressBar1)
        Me.GB_WorkAria.Controls.Add(Me.DG_UpLog)
        Me.GB_WorkAria.Controls.Add(Me.GroupBox5)
        Me.GB_WorkAria.Controls.Add(Me.GroupBox6)
        Me.GB_WorkAria.Controls.Add(Me.Controllabel2)
        Me.GB_WorkAria.Controls.Add(Me.Controllabel)
        Me.GB_WorkAria.Controls.Add(Me.GroupBox4)
        Me.GB_WorkAria.Controls.Add(Me.GroupBox3)
        Me.GB_WorkAria.Controls.Add(Me.Label2)
        Me.GB_WorkAria.Controls.Add(Me.SerialTextBox)
        Me.GB_WorkAria.Location = New System.Drawing.Point(10, 4)
        Me.GB_WorkAria.Name = "GB_WorkAria"
        Me.GB_WorkAria.Size = New System.Drawing.Size(1365, 801)
        Me.GB_WorkAria.TabIndex = 23
        Me.GB_WorkAria.TabStop = False
        Me.GB_WorkAria.Visible = False
        '
        'GB_PrinterSettings
        '
        Me.GB_PrinterSettings.Controls.Add(Me.BT_ClosePrintSet)
        Me.GB_PrinterSettings.Controls.Add(Me.TB_IDNum_X)
        Me.GB_PrinterSettings.Controls.Add(Me.Label21)
        Me.GB_PrinterSettings.Controls.Add(Me.BT_SevePrintSettings)
        Me.GB_PrinterSettings.Controls.Add(Me.TB_IDText_Y)
        Me.GB_PrinterSettings.Controls.Add(Me.TB_IDCode_Y)
        Me.GB_PrinterSettings.Controls.Add(Me.TB_IDText_X)
        Me.GB_PrinterSettings.Controls.Add(Me.TB_IDCode_X)
        Me.GB_PrinterSettings.Controls.Add(Me.Label8)
        Me.GB_PrinterSettings.Controls.Add(Me.Label20)
        Me.GB_PrinterSettings.Controls.Add(Me.Label19)
        Me.GB_PrinterSettings.Controls.Add(Me.Label4)
        Me.GB_PrinterSettings.Location = New System.Drawing.Point(549, 27)
        Me.GB_PrinterSettings.Name = "GB_PrinterSettings"
        Me.GB_PrinterSettings.Size = New System.Drawing.Size(250, 180)
        Me.GB_PrinterSettings.TabIndex = 129
        Me.GB_PrinterSettings.TabStop = False
        Me.GB_PrinterSettings.Text = "Printer Settings"
        Me.GB_PrinterSettings.Visible = False
        '
        'BT_ClosePrintSet
        '
        Me.BT_ClosePrintSet.FlatAppearance.BorderSize = 0
        Me.BT_ClosePrintSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ClosePrintSet.Image = Global.UploadStation.My.Resources.Resources.delete
        Me.BT_ClosePrintSet.Location = New System.Drawing.Point(193, 118)
        Me.BT_ClosePrintSet.Name = "BT_ClosePrintSet"
        Me.BT_ClosePrintSet.Size = New System.Drawing.Size(50, 55)
        Me.BT_ClosePrintSet.TabIndex = 5
        Me.BT_ClosePrintSet.UseVisualStyleBackColor = True
        '
        'TB_IDNum_X
        '
        Me.TB_IDNum_X.Location = New System.Drawing.Point(139, 86)
        Me.TB_IDNum_X.Name = "TB_IDNum_X"
        Me.TB_IDNum_X.Size = New System.Drawing.Size(49, 20)
        Me.TB_IDNum_X.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 90)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 13)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Координаты ID Номер"
        '
        'BT_SevePrintSettings
        '
        Me.BT_SevePrintSettings.FlatAppearance.BorderSize = 0
        Me.BT_SevePrintSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SevePrintSettings.Image = Global.UploadStation.My.Resources.Resources._04
        Me.BT_SevePrintSettings.Location = New System.Drawing.Point(15, 117)
        Me.BT_SevePrintSettings.Name = "BT_SevePrintSettings"
        Me.BT_SevePrintSettings.Size = New System.Drawing.Size(49, 57)
        Me.BT_SevePrintSettings.TabIndex = 2
        Me.BT_SevePrintSettings.UseVisualStyleBackColor = True
        '
        'TB_IDText_Y
        '
        Me.TB_IDText_Y.Location = New System.Drawing.Point(194, 58)
        Me.TB_IDText_Y.Name = "TB_IDText_Y"
        Me.TB_IDText_Y.Size = New System.Drawing.Size(49, 20)
        Me.TB_IDText_Y.TabIndex = 1
        '
        'TB_IDCode_Y
        '
        Me.TB_IDCode_Y.Location = New System.Drawing.Point(194, 31)
        Me.TB_IDCode_Y.Name = "TB_IDCode_Y"
        Me.TB_IDCode_Y.Size = New System.Drawing.Size(49, 20)
        Me.TB_IDCode_Y.TabIndex = 1
        '
        'TB_IDText_X
        '
        Me.TB_IDText_X.Location = New System.Drawing.Point(139, 58)
        Me.TB_IDText_X.Name = "TB_IDText_X"
        Me.TB_IDText_X.Size = New System.Drawing.Size(49, 20)
        Me.TB_IDText_X.TabIndex = 1
        '
        'TB_IDCode_X
        '
        Me.TB_IDCode_X.Location = New System.Drawing.Point(139, 31)
        Me.TB_IDCode_X.Name = "TB_IDCode_X"
        Me.TB_IDCode_X.Size = New System.Drawing.Size(49, 20)
        Me.TB_IDCode_X.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Координаты ""ID"""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(211, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Y"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(156, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "X"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Координаты ID Barcode"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(17, 759)
        Me.ProgressBar1.Maximum = 8
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1340, 24)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 26
        '
        'DG_UpLog
        '
        Me.DG_UpLog.AllowUserToAddRows = False
        Me.DG_UpLog.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_UpLog.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_UpLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_UpLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_UpLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num, Me.SNumber, Me.SCIDTab, Me.CASIDTab, Me.HDCP, Me.CERT, Me.MAC, Me.LDS, Me.SW, Me.SWGS1, Me.StartT, Me.ScanDate})
        Me.DG_UpLog.Location = New System.Drawing.Point(17, 372)
        Me.DG_UpLog.Name = "DG_UpLog"
        Me.DG_UpLog.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_UpLog.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_UpLog.Size = New System.Drawing.Size(1342, 381)
        Me.DG_UpLog.TabIndex = 25
        '
        'Num
        '
        Me.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Num.HeaderText = "№"
        Me.Num.Name = "Num"
        Me.Num.ReadOnly = True
        Me.Num.Width = 43
        '
        'SNumber
        '
        Me.SNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SNumber.HeaderText = "SN"
        Me.SNumber.Name = "SNumber"
        Me.SNumber.ReadOnly = True
        Me.SNumber.Width = 47
        '
        'SCIDTab
        '
        Me.SCIDTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SCIDTab.HeaderText = "SC ID"
        Me.SCIDTab.Name = "SCIDTab"
        Me.SCIDTab.ReadOnly = True
        Me.SCIDTab.Width = 60
        '
        'CASIDTab
        '
        Me.CASIDTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CASIDTab.HeaderText = "CAS ID"
        Me.CASIDTab.Name = "CASIDTab"
        Me.CASIDTab.ReadOnly = True
        Me.CASIDTab.Width = 67
        '
        'HDCP
        '
        Me.HDCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HDCP.HeaderText = "HDCP"
        Me.HDCP.Name = "HDCP"
        Me.HDCP.ReadOnly = True
        Me.HDCP.Width = 62
        '
        'CERT
        '
        Me.CERT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CERT.HeaderText = "CERT"
        Me.CERT.Name = "CERT"
        Me.CERT.ReadOnly = True
        Me.CERT.Width = 61
        '
        'MAC
        '
        Me.MAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MAC.HeaderText = "MAC"
        Me.MAC.Name = "MAC"
        Me.MAC.ReadOnly = True
        Me.MAC.Width = 55
        '
        'LDS
        '
        Me.LDS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LDS.HeaderText = "LDS"
        Me.LDS.Name = "LDS"
        Me.LDS.ReadOnly = True
        Me.LDS.Width = 53
        '
        'SW
        '
        Me.SW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SW.HeaderText = "SW"
        Me.SW.Name = "SW"
        Me.SW.ReadOnly = True
        Me.SW.Width = 50
        '
        'SWGS1
        '
        Me.SWGS1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SWGS1.HeaderText = "SW GS1"
        Me.SWGS1.Name = "SWGS1"
        Me.SWGS1.ReadOnly = True
        Me.SWGS1.Width = 74
        '
        'StartT
        '
        Me.StartT.HeaderText = "StartTime"
        Me.StartT.Name = "StartT"
        Me.StartT.ReadOnly = True
        '
        'ScanDate
        '
        Me.ScanDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ScanDate.HeaderText = "Scan Date"
        Me.ScanDate.Name = "ScanDate"
        Me.ScanDate.ReadOnly = True
        Me.ScanDate.Width = 83
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.RosyBrown
        Me.GroupBox6.Controls.Add(Me.Label_ShiftCounter)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(31, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(333, 117)
        Me.GroupBox6.TabIndex = 24
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Выпуск за смену"
        '
        'Label_ShiftCounter
        '
        Me.Label_ShiftCounter.AutoSize = True
        Me.Label_ShiftCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_ShiftCounter.Location = New System.Drawing.Point(6, 25)
        Me.Label_ShiftCounter.Name = "Label_ShiftCounter"
        Me.Label_ShiftCounter.Size = New System.Drawing.Size(71, 76)
        Me.Label_ShiftCounter.TabIndex = 0
        Me.Label_ShiftCounter.Text = "0"
        '
        'Controllabel2
        '
        Me.Controllabel2.AutoSize = True
        Me.Controllabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Controllabel2.Location = New System.Drawing.Point(26, 242)
        Me.Controllabel2.Name = "Controllabel2"
        Me.Controllabel2.Size = New System.Drawing.Size(342, 29)
        Me.Controllabel2.TabIndex = 21
        Me.Controllabel2.Text = "CONTROLLABEL_test Read"
        Me.Controllabel2.Visible = False
        '
        'DG_SNTable
        '
        Me.DG_SNTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_SNTable.Location = New System.Drawing.Point(173, 31)
        Me.DG_SNTable.Name = "DG_SNTable"
        Me.DG_SNTable.Size = New System.Drawing.Size(106, 80)
        Me.DG_SNTable.TabIndex = 128
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "DG SN Table"
        '
        'DG_CheckSN
        '
        Me.DG_CheckSN.AllowUserToAddRows = False
        Me.DG_CheckSN.AllowUserToDeleteRows = False
        Me.DG_CheckSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_CheckSN.Location = New System.Drawing.Point(6, 31)
        Me.DG_CheckSN.Name = "DG_CheckSN"
        Me.DG_CheckSN.ReadOnly = True
        Me.DG_CheckSN.Size = New System.Drawing.Size(135, 100)
        Me.DG_CheckSN.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Проверка СН"
        '
        'GB_NotVisible
        '
        Me.GB_NotVisible.Controls.Add(Me.DG_Reapload)
        Me.GB_NotVisible.Controls.Add(Me.TextBox1)
        Me.GB_NotVisible.Controls.Add(Me.DG_SNTable)
        Me.GB_NotVisible.Controls.Add(Me.DG_IsPacked)
        Me.GB_NotVisible.Controls.Add(Me.Label15)
        Me.GB_NotVisible.Controls.Add(Me.DG_CheckSN)
        Me.GB_NotVisible.Controls.Add(Me.Label3)
        Me.GB_NotVisible.Controls.Add(Me.Label12)
        Me.GB_NotVisible.Controls.Add(Me.Label14)
        Me.GB_NotVisible.Location = New System.Drawing.Point(1381, 215)
        Me.GB_NotVisible.Name = "GB_NotVisible"
        Me.GB_NotVisible.Size = New System.Drawing.Size(565, 668)
        Me.GB_NotVisible.TabIndex = 32
        Me.GB_NotVisible.TabStop = False
        Me.GB_NotVisible.Text = "NotVisible"
        Me.GB_NotVisible.Visible = False
        '
        'DG_Reapload
        '
        Me.DG_Reapload.AllowUserToAddRows = False
        Me.DG_Reapload.AllowUserToDeleteRows = False
        Me.DG_Reapload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Reapload.Location = New System.Drawing.Point(10, 177)
        Me.DG_Reapload.Name = "DG_Reapload"
        Me.DG_Reapload.ReadOnly = True
        Me.DG_Reapload.Size = New System.Drawing.Size(137, 92)
        Me.DG_Reapload.TabIndex = 129
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(22, 357)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(512, 76)
        Me.TextBox1.TabIndex = 34
        '
        'DG_IsPacked
        '
        Me.DG_IsPacked.AllowUserToAddRows = False
        Me.DG_IsPacked.AllowUserToDeleteRows = False
        Me.DG_IsPacked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_IsPacked.Location = New System.Drawing.Point(317, 32)
        Me.DG_IsPacked.Name = "DG_IsPacked"
        Me.DG_IsPacked.ReadOnly = True
        Me.DG_IsPacked.Size = New System.Drawing.Size(111, 69)
        Me.DG_IsPacked.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(314, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Номер был упакован"
        Me.Label15.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Перепрошивка серийника"
        '
        'CurrentTimeTimer
        '
        Me.CurrentTimeTimer.Interval = 1000
        '
        'TB_RFIDIn
        '
        Me.TB_RFIDIn.Location = New System.Drawing.Point(11, 88)
        Me.TB_RFIDIn.Name = "TB_RFIDIn"
        Me.TB_RFIDIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_RFIDIn.Size = New System.Drawing.Size(345, 31)
        Me.TB_RFIDIn.TabIndex = 0
        Me.TB_RFIDIn.Text = "0000181218"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(321, 25)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Отсканируйте свой бэйджик"
        '
        'GB_UserData
        '
        Me.GB_UserData.BackColor = System.Drawing.Color.NavajoWhite
        Me.GB_UserData.Controls.Add(Me.BT_LOGInClose)
        Me.GB_UserData.Controls.Add(Me.Label13)
        Me.GB_UserData.Controls.Add(Me.TB_RFIDIn)
        Me.GB_UserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_UserData.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GB_UserData.Location = New System.Drawing.Point(1394, 12)
        Me.GB_UserData.Name = "GB_UserData"
        Me.GB_UserData.Size = New System.Drawing.Size(449, 197)
        Me.GB_UserData.TabIndex = 29
        Me.GB_UserData.TabStop = False
        Me.GB_UserData.Text = "Регистрация пользователя"
        '
        'BT_LOGInClose
        '
        Me.BT_LOGInClose.BackColor = System.Drawing.Color.Transparent
        Me.BT_LOGInClose.FlatAppearance.BorderSize = 0
        Me.BT_LOGInClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LOGInClose.ForeColor = System.Drawing.Color.Transparent
        Me.BT_LOGInClose.Image = Global.UploadStation.My.Resources.Resources.close
        Me.BT_LOGInClose.Location = New System.Drawing.Point(362, 74)
        Me.BT_LOGInClose.Name = "BT_LOGInClose"
        Me.BT_LOGInClose.Size = New System.Drawing.Size(53, 59)
        Me.BT_LOGInClose.TabIndex = 2
        Me.BT_LOGInClose.UseVisualStyleBackColor = False
        '
        'WorkForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1855, 799)
        Me.ControlBox = False
        Me.Controls.Add(Me.GB_NotVisible)
        Me.Controls.Add(Me.GB_WorkAria)
        Me.Controls.Add(Me.GB_UserData)
        Me.Name = "WorkForm"
        Me.Text = "Upload Station"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GB_WorkAria.ResumeLayout(False)
        Me.GB_WorkAria.PerformLayout()
        Me.GB_PrinterSettings.ResumeLayout(False)
        Me.GB_PrinterSettings.PerformLayout()
        CType(Me.DG_UpLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DG_SNTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_CheckSN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_NotVisible.ResumeLayout(False)
        Me.GB_NotVisible.PerformLayout()
        CType(Me.DG_Reapload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_IsPacked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_UserData.ResumeLayout(False)
        Me.GB_UserData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SerialTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ScanDateLabel As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Controllabel As Label
    Friend WithEvents BT_OpenSettings As Button
    Friend WithEvents L_AppName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents L_StationName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents L_Model As Label
    Friend WithEvents L_FullLot As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents L_LOT As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents L_Line As Label
    Friend WithEvents GB_WorkAria As GroupBox
    Friend WithEvents L_UserName As Label
    Friend WithEvents GB_NotVisible As GroupBox
    Friend WithEvents DG_CheckSN As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BT_CloseApp As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CurrrentTimeLabel As Label
    Friend WithEvents CurrentTimeTimer As Timer
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label_ShiftCounter As Label
    Friend WithEvents UploadSerialPort As IO.Ports.SerialPort
    Friend WithEvents PrintSerialPort As IO.Ports.SerialPort
    Friend WithEvents Label3 As Label
    Friend WithEvents DG_IsPacked As DataGridView
    Friend WithEvents DG_SNTable As DataGridView
    Friend WithEvents DG_UpLog As DataGridView
    Friend WithEvents Num As DataGridViewTextBoxColumn
    Friend WithEvents SNumber As DataGridViewTextBoxColumn
    Friend WithEvents SCIDTab As DataGridViewTextBoxColumn
    Friend WithEvents CASIDTab As DataGridViewTextBoxColumn
    Friend WithEvents HDCP As DataGridViewTextBoxColumn
    Friend WithEvents CERT As DataGridViewTextBoxColumn
    Friend WithEvents MAC As DataGridViewTextBoxColumn
    Friend WithEvents LDS As DataGridViewTextBoxColumn
    Friend WithEvents SW As DataGridViewTextBoxColumn
    Friend WithEvents SWGS1 As DataGridViewTextBoxColumn
    Friend WithEvents StartT As DataGridViewTextBoxColumn
    Friend WithEvents ScanDate As DataGridViewTextBoxColumn
    Friend WithEvents Controllabel2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TB_RFIDIn As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GB_UserData As GroupBox
    Friend WithEvents BT_LOGInClose As Button
    Friend WithEvents GB_PrinterSettings As GroupBox
    Friend WithEvents BT_ClosePrintSet As Button
    Friend WithEvents TB_IDNum_X As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents BT_SevePrintSettings As Button
    Friend WithEvents TB_IDText_Y As TextBox
    Friend WithEvents TB_IDCode_Y As TextBox
    Friend WithEvents TB_IDText_X As TextBox
    Friend WithEvents TB_IDCode_X As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BT_PrinterSettings As Button
    Friend WithEvents DG_Reapload As DataGridView
    Friend WithEvents Label12 As Label
End Class

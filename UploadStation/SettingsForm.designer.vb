<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DG_LineList = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lebel_StationLine = New System.Windows.Forms.Label()
        Me.BT_LineSettings = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelAppName = New System.Windows.Forms.Label()
        Me.Label_StationName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_IDApp = New System.Windows.Forms.Label()
        Me.TB_LabelIDCount = New System.Windows.Forms.TextBox()
        Me.TB_LabelSNCount = New System.Windows.Forms.TextBox()
        Me.DG_LotList = New System.Windows.Forms.DataGridView()
        Me.BT_LOT_Info = New System.Windows.Forms.Button()
        Me.L_Result = New System.Windows.Forms.Label()
        Me.GB_NotVisibleElements = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_HDCPUpload = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_MACUpload = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelStationID = New System.Windows.Forms.Label()
        Me.CB_CertUpload = New System.Windows.Forms.CheckBox()
        Me.CB_CheckModel = New System.Windows.Forms.CheckBox()
        Me.CB_SWGS1Version = New System.Windows.Forms.CheckBox()
        Me.CB_SWVersion = New System.Windows.Forms.CheckBox()
        Me.DG_LOTListPresent = New System.Windows.Forms.DataGridView()
        Me.LOT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullLOTCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InLOT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ready = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Used = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxID = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSN = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDublicateSCID = New System.Windows.Forms.CheckBox()
        Me.BT_RefreshLOT = New System.Windows.Forms.Button()
        Me.BT_SelectLot = New System.Windows.Forms.Button()
        CType(Me.DG_LineList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_LotList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_NotVisibleElements.SuspendLayout()
        CType(Me.DG_LOTListPresent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_LineList
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_LineList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_LineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_LineList.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG_LineList.Location = New System.Drawing.Point(26, 36)
        Me.DG_LineList.Name = "DG_LineList"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_LineList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_LineList.Size = New System.Drawing.Size(117, 45)
        Me.DG_LineList.TabIndex = 27
        Me.DG_LineList.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Линия:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Название станции:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.LabelAppName)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label_StationName)
        Me.GroupBox3.Location = New System.Drawing.Point(1059, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(260, 227)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Информация о рабочей станции"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lebel_StationLine)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BT_LineSettings)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 85)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'Lebel_StationLine
        '
        Me.Lebel_StationLine.AutoSize = True
        Me.Lebel_StationLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lebel_StationLine.Location = New System.Drawing.Point(6, 36)
        Me.Lebel_StationLine.Name = "Lebel_StationLine"
        Me.Lebel_StationLine.Size = New System.Drawing.Size(43, 20)
        Me.Lebel_StationLine.TabIndex = 30
        Me.Lebel_StationLine.Text = "Line"
        '
        'BT_LineSettings
        '
        Me.BT_LineSettings.FlatAppearance.BorderSize = 0
        Me.BT_LineSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LineSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BT_LineSettings.Image = Global.UploadStation.My.Resources.Resources.settings__1_
        Me.BT_LineSettings.Location = New System.Drawing.Point(175, 13)
        Me.BT_LineSettings.Name = "BT_LineSettings"
        Me.BT_LineSettings.Size = New System.Drawing.Size(73, 66)
        Me.BT_LineSettings.TabIndex = 30
        Me.BT_LineSettings.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Название приложения"
        '
        'LabelAppName
        '
        Me.LabelAppName.AutoSize = True
        Me.LabelAppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelAppName.Location = New System.Drawing.Point(2, 43)
        Me.LabelAppName.Name = "LabelAppName"
        Me.LabelAppName.Size = New System.Drawing.Size(116, 20)
        Me.LabelAppName.TabIndex = 29
        Me.LabelAppName.Text = "FAS END555"
        '
        'Label_StationName
        '
        Me.Label_StationName.AutoSize = True
        Me.Label_StationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_StationName.Location = New System.Drawing.Point(3, 103)
        Me.Label_StationName.Name = "Label_StationName"
        Me.Label_StationName.Size = New System.Drawing.Size(165, 20)
        Me.Label_StationName.TabIndex = 0
        Me.Label_StationName.Text = "Название станции"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(147, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "ID_App"
        '
        'Label_IDApp
        '
        Me.Label_IDApp.AutoSize = True
        Me.Label_IDApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_IDApp.Location = New System.Drawing.Point(219, 92)
        Me.Label_IDApp.Name = "Label_IDApp"
        Me.Label_IDApp.Size = New System.Drawing.Size(19, 20)
        Me.Label_IDApp.TabIndex = 32
        Me.Label_IDApp.Text = "3"
        '
        'TB_LabelIDCount
        '
        Me.TB_LabelIDCount.Location = New System.Drawing.Point(165, 52)
        Me.TB_LabelIDCount.Name = "TB_LabelIDCount"
        Me.TB_LabelIDCount.Size = New System.Drawing.Size(33, 20)
        Me.TB_LabelIDCount.TabIndex = 8
        Me.TB_LabelIDCount.Text = "2"
        '
        'TB_LabelSNCount
        '
        Me.TB_LabelSNCount.Location = New System.Drawing.Point(165, 28)
        Me.TB_LabelSNCount.Name = "TB_LabelSNCount"
        Me.TB_LabelSNCount.Size = New System.Drawing.Size(33, 20)
        Me.TB_LabelSNCount.TabIndex = 8
        Me.TB_LabelSNCount.Text = "2"
        '
        'DG_LotList
        '
        Me.DG_LotList.AllowUserToAddRows = False
        Me.DG_LotList.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_LotList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_LotList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_LotList.DefaultCellStyle = DataGridViewCellStyle5
        Me.DG_LotList.Location = New System.Drawing.Point(12, 587)
        Me.DG_LotList.Name = "DG_LotList"
        Me.DG_LotList.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_LotList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DG_LotList.Size = New System.Drawing.Size(858, 90)
        Me.DG_LotList.TabIndex = 22
        '
        'BT_LOT_Info
        '
        Me.BT_LOT_Info.Location = New System.Drawing.Point(14, 302)
        Me.BT_LOT_Info.Name = "BT_LOT_Info"
        Me.BT_LOT_Info.Size = New System.Drawing.Size(175, 26)
        Me.BT_LOT_Info.TabIndex = 24
        Me.BT_LOT_Info.Text = "Информация о ЛОТЕ"
        Me.BT_LOT_Info.UseVisualStyleBackColor = True
        '
        'L_Result
        '
        Me.L_Result.AutoSize = True
        Me.L_Result.Location = New System.Drawing.Point(1884, 12)
        Me.L_Result.Name = "L_Result"
        Me.L_Result.Size = New System.Drawing.Size(49, 13)
        Me.L_Result.TabIndex = 29
        Me.L_Result.Text = "L_Result"
        Me.L_Result.Visible = False
        '
        'GB_NotVisibleElements
        '
        Me.GB_NotVisibleElements.Controls.Add(Me.Label7)
        Me.GB_NotVisibleElements.Controls.Add(Me.CB_HDCPUpload)
        Me.GB_NotVisibleElements.Controls.Add(Me.Button2)
        Me.GB_NotVisibleElements.Controls.Add(Me.Label4)
        Me.GB_NotVisibleElements.Controls.Add(Me.Label_IDApp)
        Me.GB_NotVisibleElements.Controls.Add(Me.CB_MACUpload)
        Me.GB_NotVisibleElements.Controls.Add(Me.Label5)
        Me.GB_NotVisibleElements.Controls.Add(Me.LabelStationID)
        Me.GB_NotVisibleElements.Controls.Add(Me.CB_CertUpload)
        Me.GB_NotVisibleElements.Controls.Add(Me.BT_LOT_Info)
        Me.GB_NotVisibleElements.Controls.Add(Me.DG_LineList)
        Me.GB_NotVisibleElements.Controls.Add(Me.CB_CheckModel)
        Me.GB_NotVisibleElements.Controls.Add(Me.CB_SWGS1Version)
        Me.GB_NotVisibleElements.Controls.Add(Me.CB_SWVersion)
        Me.GB_NotVisibleElements.Location = New System.Drawing.Point(1517, 60)
        Me.GB_NotVisibleElements.Name = "GB_NotVisibleElements"
        Me.GB_NotVisibleElements.Size = New System.Drawing.Size(275, 572)
        Me.GB_NotVisibleElements.TabIndex = 31
        Me.GB_NotVisibleElements.TabStop = False
        Me.GB_NotVisibleElements.Text = "Неотображаемые элементы"
        Me.GB_NotVisibleElements.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(26, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "LineList"
        '
        'CB_HDCPUpload
        '
        Me.CB_HDCPUpload.AutoSize = True
        Me.CB_HDCPUpload.Location = New System.Drawing.Point(14, 411)
        Me.CB_HDCPUpload.Name = "CB_HDCPUpload"
        Me.CB_HDCPUpload.Size = New System.Drawing.Size(111, 17)
        Me.CB_HDCPUpload.TabIndex = 22
        Me.CB_HDCPUpload.Text = "Прошивка HDCP"
        Me.CB_HDCPUpload.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 349)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Настройки  этикетки"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 571)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "LotList"
        '
        'CB_MACUpload
        '
        Me.CB_MACUpload.AutoSize = True
        Me.CB_MACUpload.Location = New System.Drawing.Point(14, 453)
        Me.CB_MACUpload.Name = "CB_MACUpload"
        Me.CB_MACUpload.Size = New System.Drawing.Size(104, 17)
        Me.CB_MACUpload.TabIndex = 22
        Me.CB_MACUpload.Text = "Прошивка MAC"
        Me.CB_MACUpload.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "StationID"
        '
        'LabelStationID
        '
        Me.LabelStationID.AutoSize = True
        Me.LabelStationID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelStationID.Location = New System.Drawing.Point(114, 92)
        Me.LabelStationID.Name = "LabelStationID"
        Me.LabelStationID.Size = New System.Drawing.Size(21, 20)
        Me.LabelStationID.TabIndex = 34
        Me.LabelStationID.Text = "X"
        '
        'CB_CertUpload
        '
        Me.CB_CertUpload.AutoSize = True
        Me.CB_CertUpload.Location = New System.Drawing.Point(14, 430)
        Me.CB_CertUpload.Name = "CB_CertUpload"
        Me.CB_CertUpload.Size = New System.Drawing.Size(147, 17)
        Me.CB_CertUpload.TabIndex = 22
        Me.CB_CertUpload.Text = "Прошивка сертификата"
        Me.CB_CertUpload.UseVisualStyleBackColor = True
        '
        'CB_CheckModel
        '
        Me.CB_CheckModel.AutoSize = True
        Me.CB_CheckModel.Location = New System.Drawing.Point(14, 388)
        Me.CB_CheckModel.Name = "CB_CheckModel"
        Me.CB_CheckModel.Size = New System.Drawing.Size(168, 17)
        Me.CB_CheckModel.TabIndex = 22
        Me.CB_CheckModel.Text = "Проверка названия модели"
        Me.CB_CheckModel.UseVisualStyleBackColor = True
        '
        'CB_SWGS1Version
        '
        Me.CB_SWGS1Version.AutoSize = True
        Me.CB_SWGS1Version.Location = New System.Drawing.Point(14, 517)
        Me.CB_SWGS1Version.Name = "CB_SWGS1Version"
        Me.CB_SWGS1Version.Size = New System.Drawing.Size(158, 17)
        Me.CB_SWGS1Version.TabIndex = 21
        Me.CB_SWGS1Version.Text = "Проверка версии ПО GS1"
        Me.CB_SWGS1Version.UseVisualStyleBackColor = True
        '
        'CB_SWVersion
        '
        Me.CB_SWVersion.AutoSize = True
        Me.CB_SWVersion.Location = New System.Drawing.Point(14, 498)
        Me.CB_SWVersion.Name = "CB_SWVersion"
        Me.CB_SWVersion.Size = New System.Drawing.Size(134, 17)
        Me.CB_SWVersion.TabIndex = 21
        Me.CB_SWVersion.Text = "Проверка версии ПО"
        Me.CB_SWVersion.UseVisualStyleBackColor = True
        '
        'DG_LOTListPresent
        '
        Me.DG_LOTListPresent.AllowUserToAddRows = False
        Me.DG_LOTListPresent.AllowUserToOrderColumns = True
        Me.DG_LOTListPresent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_LOTListPresent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DG_LOTListPresent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_LOTListPresent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LOT, Me.FullLOTCode, Me.ModelName, Me.InLOT, Me.Ready, Me.Used, Me.LOT_ID})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_LOTListPresent.DefaultCellStyle = DataGridViewCellStyle8
        Me.DG_LOTListPresent.Location = New System.Drawing.Point(12, 12)
        Me.DG_LOTListPresent.Name = "DG_LOTListPresent"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_LOTListPresent.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_LOTListPresent.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DG_LOTListPresent.Size = New System.Drawing.Size(858, 543)
        Me.DG_LOTListPresent.TabIndex = 32
        '
        'LOT
        '
        Me.LOT.HeaderText = "LOT"
        Me.LOT.Name = "LOT"
        Me.LOT.Width = 62
        '
        'FullLOTCode
        '
        Me.FullLOTCode.HeaderText = "FullLOTCode"
        Me.FullLOTCode.Name = "FullLOTCode"
        Me.FullLOTCode.Width = 124
        '
        'ModelName
        '
        Me.ModelName.HeaderText = "ModelName"
        Me.ModelName.Name = "ModelName"
        Me.ModelName.Width = 117
        '
        'InLOT
        '
        Me.InLOT.HeaderText = "InLOT"
        Me.InLOT.Name = "InLOT"
        Me.InLOT.Width = 74
        '
        'Ready
        '
        Me.Ready.HeaderText = "Ready"
        Me.Ready.Name = "Ready"
        Me.Ready.Width = 79
        '
        'Used
        '
        Me.Used.HeaderText = "Used"
        Me.Used.Name = "Used"
        Me.Used.Width = 70
        '
        'LOT_ID
        '
        Me.LOT_ID.HeaderText = "LOT_ID"
        Me.LOT_ID.Name = "LOT_ID"
        Me.LOT_ID.Width = 85
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxID)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSN)
        Me.GroupBox2.Controls.Add(Me.CheckBoxDublicateSCID)
        Me.GroupBox2.Controls.Add(Me.TB_LabelIDCount)
        Me.GroupBox2.Controls.Add(Me.TB_LabelSNCount)
        Me.GroupBox2.Location = New System.Drawing.Point(1059, 245)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 266)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Печать этикеток SN и ID "
        '
        'CheckBoxID
        '
        Me.CheckBoxID.AutoSize = True
        Me.CheckBoxID.Location = New System.Drawing.Point(11, 55)
        Me.CheckBoxID.Name = "CheckBoxID"
        Me.CheckBoxID.Size = New System.Drawing.Size(148, 17)
        Me.CheckBoxID.TabIndex = 16
        Me.CheckBoxID.Text = "Количество этикеток ID"
        Me.CheckBoxID.UseVisualStyleBackColor = True
        '
        'CheckBoxSN
        '
        Me.CheckBoxSN.AutoSize = True
        Me.CheckBoxSN.Location = New System.Drawing.Point(11, 31)
        Me.CheckBoxSN.Name = "CheckBoxSN"
        Me.CheckBoxSN.Size = New System.Drawing.Size(152, 17)
        Me.CheckBoxSN.TabIndex = 16
        Me.CheckBoxSN.Text = "Количество этикеток SN"
        Me.CheckBoxSN.UseVisualStyleBackColor = True
        '
        'CheckBoxDublicateSCID
        '
        Me.CheckBoxDublicateSCID.AutoSize = True
        Me.CheckBoxDublicateSCID.Location = New System.Drawing.Point(11, 79)
        Me.CheckBoxDublicateSCID.Name = "CheckBoxDublicateSCID"
        Me.CheckBoxDublicateSCID.Size = New System.Drawing.Size(180, 17)
        Me.CheckBoxDublicateSCID.TabIndex = 21
        Me.CheckBoxDublicateSCID.Text = "Проверка уникальности SC ID"
        Me.CheckBoxDublicateSCID.UseVisualStyleBackColor = True
        '
        'BT_RefreshLOT
        '
        Me.BT_RefreshLOT.BackColor = System.Drawing.Color.Transparent
        Me.BT_RefreshLOT.FlatAppearance.BorderSize = 0
        Me.BT_RefreshLOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_RefreshLOT.ForeColor = System.Drawing.Color.Transparent
        Me.BT_RefreshLOT.Image = Global.UploadStation.My.Resources.Resources.refresh__1_
        Me.BT_RefreshLOT.Location = New System.Drawing.Point(886, 507)
        Me.BT_RefreshLOT.Name = "BT_RefreshLOT"
        Me.BT_RefreshLOT.Size = New System.Drawing.Size(43, 48)
        Me.BT_RefreshLOT.TabIndex = 39
        Me.BT_RefreshLOT.UseVisualStyleBackColor = False
        '
        'BT_SelectLot
        '
        Me.BT_SelectLot.BackColor = System.Drawing.Color.Transparent
        Me.BT_SelectLot.FlatAppearance.BorderSize = 0
        Me.BT_SelectLot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SelectLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BT_SelectLot.Image = Global.UploadStation.My.Resources.Resources.play
        Me.BT_SelectLot.Location = New System.Drawing.Point(1132, 513)
        Me.BT_SelectLot.Name = "BT_SelectLot"
        Me.BT_SelectLot.Size = New System.Drawing.Size(106, 115)
        Me.BT_SelectLot.TabIndex = 23
        Me.BT_SelectLot.Text = "Запуск"
        Me.BT_SelectLot.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_SelectLot.UseVisualStyleBackColor = False
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 703)
        Me.Controls.Add(Me.BT_RefreshLOT)
        Me.Controls.Add(Me.DG_LotList)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DG_LOTListPresent)
        Me.Controls.Add(Me.GB_NotVisibleElements)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BT_SelectLot)
        Me.Controls.Add(Me.L_Result)
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Настройки"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DG_LineList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_LotList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_NotVisibleElements.ResumeLayout(False)
        Me.GB_NotVisibleElements.PerformLayout()
        CType(Me.DG_LOTListPresent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DG_LineList As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label_StationName As Label
    Friend WithEvents TB_LabelIDCount As TextBox
    Friend WithEvents TB_LabelSNCount As TextBox
    Friend WithEvents BT_SelectLot As Button
    Friend WithEvents DG_LotList As DataGridView
    Friend WithEvents BT_LOT_Info As Button
    Friend WithEvents Lebel_StationLine As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelAppName As Label
    Friend WithEvents L_Result As Label
    Friend WithEvents BT_LineSettings As Button
    Friend WithEvents GB_NotVisibleElements As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_IDApp As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelStationID As Label
    Friend WithEvents DG_LOTListPresent As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBoxID As CheckBox
    Friend WithEvents CheckBoxSN As CheckBox
    Friend WithEvents CheckBoxDublicateSCID As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents CB_CheckModel As CheckBox
    Friend WithEvents CB_SWVersion As CheckBox
    Friend WithEvents CB_SWGS1Version As CheckBox
    Friend WithEvents CB_CertUpload As CheckBox
    Friend WithEvents CB_HDCPUpload As CheckBox
    Friend WithEvents CB_MACUpload As CheckBox
    Friend WithEvents LOT As DataGridViewTextBoxColumn
    Friend WithEvents FullLOTCode As DataGridViewTextBoxColumn
    Friend WithEvents ModelName As DataGridViewTextBoxColumn
    Friend WithEvents InLOT As DataGridViewTextBoxColumn
    Friend WithEvents Ready As DataGridViewTextBoxColumn
    Friend WithEvents Used As DataGridViewTextBoxColumn
    Friend WithEvents LOT_ID As DataGridViewTextBoxColumn
    Friend WithEvents BT_RefreshLOT As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class

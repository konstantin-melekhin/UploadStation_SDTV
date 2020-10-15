<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DG_AppList = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BT_SaveLine = New System.Windows.Forms.Button()
        Me.CB_Line = New System.Windows.Forms.ComboBox()
        Me.GB_LineSettings = New System.Windows.Forms.GroupBox()
        Me.BT_CloseLineSet = New System.Windows.Forms.Button()
        Me.GB_SelectLine = New System.Windows.Forms.GroupBox()
        Me.BT_SelectLot = New System.Windows.Forms.Button()
        Me.GB_NotVisibleElements = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DG_LineList = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DG_LotList = New System.Windows.Forms.DataGridView()
        Me.DG_LOTListPresent = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullLOTCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lebel_StationLine = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LB_SelectLine = New System.Windows.Forms.Label()
        Me.LabelAppName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_StationName = New System.Windows.Forms.Label()
        Me.L_Result = New System.Windows.Forms.Label()
        Me.BT_RefreshLOT = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxID = New System.Windows.Forms.CheckBox()
        Me.TB_LabelIDCount = New System.Windows.Forms.TextBox()
        Me.TB_LabelSNCount = New System.Windows.Forms.TextBox()
        Me.CheckBoxSN = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDublicateSCID = New System.Windows.Forms.CheckBox()
        CType(Me.DG_AppList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_LineSettings.SuspendLayout()
        Me.GB_SelectLine.SuspendLayout()
        Me.GB_NotVisibleElements.SuspendLayout()
        CType(Me.DG_LineList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_LotList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_LOTListPresent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_AppList
        '
        Me.DG_AppList.AllowUserToAddRows = False
        Me.DG_AppList.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_AppList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DG_AppList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_AppList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_AppList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_AppList.Location = New System.Drawing.Point(6, 283)
        Me.DG_AppList.Name = "DG_AppList"
        Me.DG_AppList.ReadOnly = True
        Me.DG_AppList.Size = New System.Drawing.Size(846, 175)
        Me.DG_AppList.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 37)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "AppList"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 31)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Выберите Линию"
        '
        'BT_SaveLine
        '
        Me.BT_SaveLine.FlatAppearance.BorderSize = 0
        Me.BT_SaveLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SaveLine.Image = Global.UploadStation.My.Resources.Resources._04
        Me.BT_SaveLine.Location = New System.Drawing.Point(246, 109)
        Me.BT_SaveLine.Name = "BT_SaveLine"
        Me.BT_SaveLine.Size = New System.Drawing.Size(54, 55)
        Me.BT_SaveLine.TabIndex = 17
        Me.BT_SaveLine.UseVisualStyleBackColor = True
        '
        'CB_Line
        '
        Me.CB_Line.FormattingEnabled = True
        Me.CB_Line.Location = New System.Drawing.Point(12, 55)
        Me.CB_Line.Name = "CB_Line"
        Me.CB_Line.Size = New System.Drawing.Size(288, 39)
        Me.CB_Line.TabIndex = 16
        '
        'GB_LineSettings
        '
        Me.GB_LineSettings.Controls.Add(Me.BT_CloseLineSet)
        Me.GB_LineSettings.Controls.Add(Me.Label7)
        Me.GB_LineSettings.Controls.Add(Me.BT_SaveLine)
        Me.GB_LineSettings.Controls.Add(Me.CB_Line)
        Me.GB_LineSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GB_LineSettings.Location = New System.Drawing.Point(6, 43)
        Me.GB_LineSettings.Name = "GB_LineSettings"
        Me.GB_LineSettings.Size = New System.Drawing.Size(333, 185)
        Me.GB_LineSettings.TabIndex = 35
        Me.GB_LineSettings.TabStop = False
        '
        'BT_CloseLineSet
        '
        Me.BT_CloseLineSet.FlatAppearance.BorderSize = 0
        Me.BT_CloseLineSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CloseLineSet.Image = Global.UploadStation.My.Resources.Resources.icons8_стрелка_влево_в_круге_2_64
        Me.BT_CloseLineSet.Location = New System.Drawing.Point(12, 104)
        Me.BT_CloseLineSet.Name = "BT_CloseLineSet"
        Me.BT_CloseLineSet.Size = New System.Drawing.Size(75, 64)
        Me.BT_CloseLineSet.TabIndex = 20
        Me.BT_CloseLineSet.UseVisualStyleBackColor = True
        '
        'GB_SelectLine
        '
        Me.GB_SelectLine.Controls.Add(Me.GB_LineSettings)
        Me.GB_SelectLine.Controls.Add(Me.DG_AppList)
        Me.GB_SelectLine.Controls.Add(Me.Label9)
        Me.GB_SelectLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GB_SelectLine.Location = New System.Drawing.Point(1, 299)
        Me.GB_SelectLine.Name = "GB_SelectLine"
        Me.GB_SelectLine.Size = New System.Drawing.Size(881, 464)
        Me.GB_SelectLine.TabIndex = 55
        Me.GB_SelectLine.TabStop = False
        Me.GB_SelectLine.Text = "Выбор номера линии"
        Me.GB_SelectLine.Visible = False
        '
        'BT_SelectLot
        '
        Me.BT_SelectLot.FlatAppearance.BorderSize = 0
        Me.BT_SelectLot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SelectLot.Image = Global.UploadStation.My.Resources.Resources.play
        Me.BT_SelectLot.Location = New System.Drawing.Point(1001, 431)
        Me.BT_SelectLot.Name = "BT_SelectLot"
        Me.BT_SelectLot.Size = New System.Drawing.Size(94, 79)
        Me.BT_SelectLot.TabIndex = 54
        Me.BT_SelectLot.UseVisualStyleBackColor = True
        '
        'GB_NotVisibleElements
        '
        Me.GB_NotVisibleElements.Controls.Add(Me.Label8)
        Me.GB_NotVisibleElements.Controls.Add(Me.DG_LineList)
        Me.GB_NotVisibleElements.Controls.Add(Me.TextBox1)
        Me.GB_NotVisibleElements.Controls.Add(Me.Label4)
        Me.GB_NotVisibleElements.Controls.Add(Me.Label6)
        Me.GB_NotVisibleElements.Location = New System.Drawing.Point(1337, 35)
        Me.GB_NotVisibleElements.Margin = New System.Windows.Forms.Padding(4)
        Me.GB_NotVisibleElements.Name = "GB_NotVisibleElements"
        Me.GB_NotVisibleElements.Padding = New System.Windows.Forms.Padding(4)
        Me.GB_NotVisibleElements.Size = New System.Drawing.Size(379, 255)
        Me.GB_NotVisibleElements.TabIndex = 51
        Me.GB_NotVisibleElements.TabStop = False
        Me.GB_NotVisibleElements.Text = "Неотображаемые элементы"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Линия"
        '
        'DG_LineList
        '
        Me.DG_LineList.AllowUserToAddRows = False
        Me.DG_LineList.AllowUserToDeleteRows = False
        Me.DG_LineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_LineList.Location = New System.Drawing.Point(7, 132)
        Me.DG_LineList.Name = "DG_LineList"
        Me.DG_LineList.ReadOnly = True
        Me.DG_LineList.Size = New System.Drawing.Size(144, 116)
        Me.DG_LineList.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 35)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(257, 69)
        Me.TextBox1.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Station Info"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "LotList"
        '
        'DG_LotList
        '
        Me.DG_LotList.AllowUserToAddRows = False
        Me.DG_LotList.AllowUserToDeleteRows = False
        Me.DG_LotList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_LotList.Location = New System.Drawing.Point(889, 532)
        Me.DG_LotList.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_LotList.Name = "DG_LotList"
        Me.DG_LotList.ReadOnly = True
        Me.DG_LotList.Size = New System.Drawing.Size(708, 275)
        Me.DG_LotList.TabIndex = 22
        '
        'DG_LOTListPresent
        '
        Me.DG_LOTListPresent.AllowUserToAddRows = False
        Me.DG_LOTListPresent.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_LOTListPresent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DG_LOTListPresent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_LOTListPresent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.MediumSpringGreen
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_LOTListPresent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DG_LOTListPresent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_LOTListPresent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.LOT, Me.FullLOTCode, Me.ModelName, Me.LOT_ID})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_LOTListPresent.DefaultCellStyle = DataGridViewCellStyle10
        Me.DG_LOTListPresent.Location = New System.Drawing.Point(13, 13)
        Me.DG_LOTListPresent.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_LOTListPresent.Name = "DG_LOTListPresent"
        Me.DG_LOTListPresent.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_LOTListPresent.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_LOTListPresent.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DG_LOTListPresent.Size = New System.Drawing.Size(812, 218)
        Me.DG_LOTListPresent.TabIndex = 52
        '
        'Column1
        '
        Me.Column1.HeaderText = "Full LOT Neme"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 127
        '
        'LOT
        '
        Me.LOT.HeaderText = "LOT"
        Me.LOT.Name = "LOT"
        Me.LOT.ReadOnly = True
        Me.LOT.Width = 66
        '
        'FullLOTCode
        '
        Me.FullLOTCode.HeaderText = "Specification"
        Me.FullLOTCode.Name = "FullLOTCode"
        Me.FullLOTCode.ReadOnly = True
        Me.FullLOTCode.Width = 119
        '
        'ModelName
        '
        Me.ModelName.HeaderText = "Model"
        Me.ModelName.Name = "ModelName"
        Me.ModelName.ReadOnly = True
        Me.ModelName.Width = 78
        '
        'LOT_ID
        '
        Me.LOT_ID.HeaderText = "LOT_ID"
        Me.LOT_ID.Name = "LOT_ID"
        Me.LOT_ID.ReadOnly = True
        Me.LOT_ID.Visible = False
        Me.LOT_ID.Width = 70
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lebel_StationLine)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.LB_SelectLine)
        Me.GroupBox3.Controls.Add(Me.LabelAppName)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label_StationName)
        Me.GroupBox3.Location = New System.Drawing.Point(905, 13)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(297, 184)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Информация о рабочей станции"
        '
        'Lebel_StationLine
        '
        Me.Lebel_StationLine.AutoSize = True
        Me.Lebel_StationLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lebel_StationLine.Location = New System.Drawing.Point(92, 157)
        Me.Lebel_StationLine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lebel_StationLine.Name = "Lebel_StationLine"
        Me.Lebel_StationLine.Size = New System.Drawing.Size(43, 20)
        Me.Lebel_StationLine.TabIndex = 30
        Me.Lebel_StationLine.Text = "Line"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Название приложения"
        '
        'LB_SelectLine
        '
        Me.LB_SelectLine.AutoSize = True
        Me.LB_SelectLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LB_SelectLine.Location = New System.Drawing.Point(8, 159)
        Me.LB_SelectLine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_SelectLine.Name = "LB_SelectLine"
        Me.LB_SelectLine.Size = New System.Drawing.Size(57, 16)
        Me.LB_SelectLine.TabIndex = 0
        Me.LB_SelectLine.Text = "Линия:"
        '
        'LabelAppName
        '
        Me.LabelAppName.AutoSize = True
        Me.LabelAppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelAppName.Location = New System.Drawing.Point(4, 33)
        Me.LabelAppName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAppName.Name = "LabelAppName"
        Me.LabelAppName.Size = New System.Drawing.Size(116, 20)
        Me.LabelAppName.TabIndex = 29
        Me.LabelAppName.Text = "FAS END555"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Название станции:"
        '
        'Label_StationName
        '
        Me.Label_StationName.AutoSize = True
        Me.Label_StationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_StationName.Location = New System.Drawing.Point(4, 116)
        Me.Label_StationName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_StationName.Name = "Label_StationName"
        Me.Label_StationName.Size = New System.Drawing.Size(165, 20)
        Me.Label_StationName.TabIndex = 0
        Me.Label_StationName.Text = "Название станции"
        '
        'L_Result
        '
        Me.L_Result.AutoSize = True
        Me.L_Result.Location = New System.Drawing.Point(1352, 9)
        Me.L_Result.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Result.Name = "L_Result"
        Me.L_Result.Size = New System.Drawing.Size(49, 13)
        Me.L_Result.TabIndex = 50
        Me.L_Result.Text = "L_Result"
        Me.L_Result.Visible = False
        '
        'BT_RefreshLOT
        '
        Me.BT_RefreshLOT.FlatAppearance.BorderSize = 0
        Me.BT_RefreshLOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_RefreshLOT.Image = Global.UploadStation.My.Resources.Resources.refresh__1_
        Me.BT_RefreshLOT.Location = New System.Drawing.Point(832, 172)
        Me.BT_RefreshLOT.Name = "BT_RefreshLOT"
        Me.BT_RefreshLOT.Size = New System.Drawing.Size(61, 59)
        Me.BT_RefreshLOT.TabIndex = 53
        Me.BT_RefreshLOT.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxID)
        Me.GroupBox2.Controls.Add(Me.TB_LabelIDCount)
        Me.GroupBox2.Controls.Add(Me.TB_LabelSNCount)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSN)
        Me.GroupBox2.Controls.Add(Me.CheckBoxDublicateSCID)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(905, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 122)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Печать этикеток SN и ID "
        '
        'CheckBoxID
        '
        Me.CheckBoxID.AutoSize = True
        Me.CheckBoxID.Location = New System.Drawing.Point(6, 66)
        Me.CheckBoxID.Name = "CheckBoxID"
        Me.CheckBoxID.Size = New System.Drawing.Size(236, 24)
        Me.CheckBoxID.TabIndex = 16
        Me.CheckBoxID.Text = "Количество этикеток ID"
        Me.CheckBoxID.UseVisualStyleBackColor = True
        '
        'TB_LabelIDCount
        '
        Me.TB_LabelIDCount.Location = New System.Drawing.Point(251, 65)
        Me.TB_LabelIDCount.Name = "TB_LabelIDCount"
        Me.TB_LabelIDCount.Size = New System.Drawing.Size(33, 26)
        Me.TB_LabelIDCount.TabIndex = 8
        Me.TB_LabelIDCount.Text = "2"
        '
        'TB_LabelSNCount
        '
        Me.TB_LabelSNCount.Location = New System.Drawing.Point(251, 41)
        Me.TB_LabelSNCount.Name = "TB_LabelSNCount"
        Me.TB_LabelSNCount.Size = New System.Drawing.Size(33, 26)
        Me.TB_LabelSNCount.TabIndex = 8
        Me.TB_LabelSNCount.Text = "2"
        '
        'CheckBoxSN
        '
        Me.CheckBoxSN.AutoSize = True
        Me.CheckBoxSN.Location = New System.Drawing.Point(6, 42)
        Me.CheckBoxSN.Name = "CheckBoxSN"
        Me.CheckBoxSN.Size = New System.Drawing.Size(241, 24)
        Me.CheckBoxSN.TabIndex = 16
        Me.CheckBoxSN.Text = "Количество этикеток SN"
        Me.CheckBoxSN.UseVisualStyleBackColor = True
        '
        'CheckBoxDublicateSCID
        '
        Me.CheckBoxDublicateSCID.AutoSize = True
        Me.CheckBoxDublicateSCID.Location = New System.Drawing.Point(6, 90)
        Me.CheckBoxDublicateSCID.Name = "CheckBoxDublicateSCID"
        Me.CheckBoxDublicateSCID.Size = New System.Drawing.Size(285, 24)
        Me.CheckBoxDublicateSCID.TabIndex = 21
        Me.CheckBoxDublicateSCID.Text = "Проверка уникальности SC ID"
        Me.CheckBoxDublicateSCID.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1711, 820)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BT_RefreshLOT)
        Me.Controls.Add(Me.GB_SelectLine)
        Me.Controls.Add(Me.BT_SelectLot)
        Me.Controls.Add(Me.GB_NotVisibleElements)
        Me.Controls.Add(Me.DG_LotList)
        Me.Controls.Add(Me.DG_LOTListPresent)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.L_Result)
        Me.Name = "SettingsForm"
        Me.Text = "SettingsForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DG_AppList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_LineSettings.ResumeLayout(False)
        Me.GB_LineSettings.PerformLayout()
        Me.GB_SelectLine.ResumeLayout(False)
        Me.GB_SelectLine.PerformLayout()
        Me.GB_NotVisibleElements.ResumeLayout(False)
        Me.GB_NotVisibleElements.PerformLayout()
        CType(Me.DG_LineList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_LotList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_LOTListPresent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_RefreshLOT As Button
    Friend WithEvents DG_AppList As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents BT_CloseLineSet As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents BT_SaveLine As Button
    Friend WithEvents CB_Line As ComboBox
    Friend WithEvents GB_LineSettings As GroupBox
    Friend WithEvents GB_SelectLine As GroupBox
    Friend WithEvents BT_SelectLot As Button
    Friend WithEvents GB_NotVisibleElements As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DG_LineList As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DG_LotList As DataGridView
    Friend WithEvents DG_LOTListPresent As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Lebel_StationLine As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LB_SelectLine As Label
    Friend WithEvents LabelAppName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_StationName As Label
    Friend WithEvents L_Result As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents LOT As DataGridViewTextBoxColumn
    Friend WithEvents FullLOTCode As DataGridViewTextBoxColumn
    Friend WithEvents ModelName As DataGridViewTextBoxColumn
    Friend WithEvents LOT_ID As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBoxID As CheckBox
    Friend WithEvents CheckBoxSN As CheckBox
    Friend WithEvents CheckBoxDublicateSCID As CheckBox
    Friend WithEvents TB_LabelIDCount As TextBox
    Friend WithEvents TB_LabelSNCount As TextBox
End Class

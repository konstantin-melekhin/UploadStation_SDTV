<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LineSettings
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabAppName = New System.Windows.Forms.Label()
        Me.GB_LineSettings = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BT_SaveLine = New System.Windows.Forms.Button()
        Me.CB_Line = New System.Windows.Forms.ComboBox()
        Me.DG_AppList = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BT_Return = New System.Windows.Forms.Button()
        Me.BT_AppRefresh = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DG_LineList = New System.Windows.Forms.DataGridView()
        Me.GB_LineSettings.SuspendLayout()
        CType(Me.DG_AppList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_LineList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabAppName
        '
        Me.LabAppName.AutoSize = True
        Me.LabAppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabAppName.Location = New System.Drawing.Point(12, 9)
        Me.LabAppName.Name = "LabAppName"
        Me.LabAppName.Size = New System.Drawing.Size(141, 31)
        Me.LabAppName.TabIndex = 34
        Me.LabAppName.Text = "AppName"
        '
        'GB_LineSettings
        '
        Me.GB_LineSettings.Controls.Add(Me.Label7)
        Me.GB_LineSettings.Controls.Add(Me.BT_SaveLine)
        Me.GB_LineSettings.Controls.Add(Me.CB_Line)
        Me.GB_LineSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GB_LineSettings.Location = New System.Drawing.Point(39, 94)
        Me.GB_LineSettings.Name = "GB_LineSettings"
        Me.GB_LineSettings.Size = New System.Drawing.Size(231, 198)
        Me.GB_LineSettings.TabIndex = 33
        Me.GB_LineSettings.TabStop = False
        Me.GB_LineSettings.Text = "Line Settings"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 31)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Линия"
        '
        'BT_SaveLine
        '
        Me.BT_SaveLine.Location = New System.Drawing.Point(12, 134)
        Me.BT_SaveLine.Name = "BT_SaveLine"
        Me.BT_SaveLine.Size = New System.Drawing.Size(196, 44)
        Me.BT_SaveLine.TabIndex = 17
        Me.BT_SaveLine.Text = "Сохранить линию"
        Me.BT_SaveLine.UseVisualStyleBackColor = True
        '
        'CB_Line
        '
        Me.CB_Line.FormattingEnabled = True
        Me.CB_Line.Location = New System.Drawing.Point(12, 80)
        Me.CB_Line.Name = "CB_Line"
        Me.CB_Line.Size = New System.Drawing.Size(196, 39)
        Me.CB_Line.TabIndex = 16
        '
        'DG_AppList
        '
        Me.DG_AppList.AllowUserToAddRows = False
        Me.DG_AppList.AllowUserToDeleteRows = False
        Me.DG_AppList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_AppList.Location = New System.Drawing.Point(396, 68)
        Me.DG_AppList.Name = "DG_AppList"
        Me.DG_AppList.ReadOnly = True
        Me.DG_AppList.Size = New System.Drawing.Size(523, 466)
        Me.DG_AppList.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(393, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "AppList"
        '
        'BT_Return
        '
        Me.BT_Return.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BT_Return.Location = New System.Drawing.Point(18, 338)
        Me.BT_Return.Name = "BT_Return"
        Me.BT_Return.Size = New System.Drawing.Size(287, 81)
        Me.BT_Return.TabIndex = 38
        Me.BT_Return.Text = "Возврат в рабочую программу"
        Me.BT_Return.UseVisualStyleBackColor = True
        '
        'BT_AppRefresh
        '
        Me.BT_AppRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BT_AppRefresh.Location = New System.Drawing.Point(396, 12)
        Me.BT_AppRefresh.Name = "BT_AppRefresh"
        Me.BT_AppRefresh.Size = New System.Drawing.Size(435, 37)
        Me.BT_AppRefresh.TabIndex = 37
        Me.BT_AppRefresh.Text = "Обновить список приложений"
        Me.BT_AppRefresh.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(946, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Линия"
        '
        'DG_LineList
        '
        Me.DG_LineList.AllowUserToAddRows = False
        Me.DG_LineList.AllowUserToDeleteRows = False
        Me.DG_LineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_LineList.Location = New System.Drawing.Point(949, 68)
        Me.DG_LineList.Name = "DG_LineList"
        Me.DG_LineList.ReadOnly = True
        Me.DG_LineList.Size = New System.Drawing.Size(372, 175)
        Me.DG_LineList.TabIndex = 36
        '
        'LineSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 600)
        Me.Controls.Add(Me.LabAppName)
        Me.Controls.Add(Me.GB_LineSettings)
        Me.Controls.Add(Me.DG_AppList)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BT_Return)
        Me.Controls.Add(Me.BT_AppRefresh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DG_LineList)
        Me.Name = "LineSettings"
        Me.Text = "LineSettings"
        Me.GB_LineSettings.ResumeLayout(False)
        Me.GB_LineSettings.PerformLayout()
        CType(Me.DG_AppList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_LineList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabAppName As Label
    Friend WithEvents GB_LineSettings As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BT_SaveLine As Button
    Friend WithEvents CB_Line As ComboBox
    Friend WithEvents DG_AppList As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents BT_Return As Button
    Friend WithEvents BT_AppRefresh As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DG_LineList As DataGridView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModeKeySet
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbModeKey2 = New System.Windows.Forms.ComboBox()
        Me.cmbModeKey1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(637, 74)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "前後台模式轉換只影響滑鼠 鍵盤按鍵永久後台" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "後台需要把開火鍵(左鍵)和特殊功能鍵(右鍵)更改" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmbModeKey2
        '
        Me.cmbModeKey2.DropDownHeight = 250
        Me.cmbModeKey2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModeKey2.DropDownWidth = 100
        Me.cmbModeKey2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmbModeKey2.FormattingEnabled = True
        Me.cmbModeKey2.IntegralHeight = False
        Me.cmbModeKey2.ItemHeight = 20
        Me.cmbModeKey2.Items.AddRange(New Object() {"蓋亞", "刀戰蓋亞"})
        Me.cmbModeKey2.Location = New System.Drawing.Point(193, 207)
        Me.cmbModeKey2.MaxDropDownItems = 5
        Me.cmbModeKey2.Name = "cmbModeKey2"
        Me.cmbModeKey2.Size = New System.Drawing.Size(129, 28)
        Me.cmbModeKey2.TabIndex = 17
        '
        'cmbModeKey1
        '
        Me.cmbModeKey1.DropDownHeight = 250
        Me.cmbModeKey1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModeKey1.DropDownWidth = 100
        Me.cmbModeKey1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmbModeKey1.FormattingEnabled = True
        Me.cmbModeKey1.IntegralHeight = False
        Me.cmbModeKey1.ItemHeight = 20
        Me.cmbModeKey1.Items.AddRange(New Object() {"蓋亞", "刀戰蓋亞"})
        Me.cmbModeKey1.Location = New System.Drawing.Point(193, 154)
        Me.cmbModeKey1.MaxDropDownItems = 5
        Me.cmbModeKey1.Name = "cmbModeKey1"
        Me.cmbModeKey1.Size = New System.Drawing.Size(129, 28)
        Me.cmbModeKey1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 26)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "特殊功能鍵(右鍵)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 26)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "開火鍵(左鍵)"
        '
        'ModeKeySet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 272)
        Me.Controls.Add(Me.cmbModeKey2)
        Me.Controls.Add(Me.cmbModeKey1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModeKeySet"
        Me.Text = "ModeKeySet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbModeKey2 As ComboBox
    Friend WithEvents cmbModeKey1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

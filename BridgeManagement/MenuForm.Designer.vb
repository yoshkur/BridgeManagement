<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuForm
	Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.inspectionDataImportButtom = New System.Windows.Forms.Button()
        Me.bridgeManagementButton = New System.Windows.Forms.Button()
        Me.bridgeAddButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(657, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Location = New System.Drawing.Point(657, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 22)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(657, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 19)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Visible = False
        '
        'inspectionDataImportButtom
        '
        Me.inspectionDataImportButtom.Location = New System.Drawing.Point(12, 28)
        Me.inspectionDataImportButtom.Name = "inspectionDataImportButtom"
        Me.inspectionDataImportButtom.Size = New System.Drawing.Size(234, 35)
        Me.inspectionDataImportButtom.TabIndex = 4
        Me.inspectionDataImportButtom.Text = "点検データ取り込み"
        Me.inspectionDataImportButtom.UseVisualStyleBackColor = True
        '
        'bridgeManagementButton
        '
        Me.bridgeManagementButton.Location = New System.Drawing.Point(12, 85)
        Me.bridgeManagementButton.Name = "bridgeManagementButton"
        Me.bridgeManagementButton.Size = New System.Drawing.Size(234, 34)
        Me.bridgeManagementButton.TabIndex = 5
        Me.bridgeManagementButton.Text = "橋梁管理台帳"
        Me.bridgeManagementButton.UseVisualStyleBackColor = True
        '
        'bridgeAddButton
        '
        Me.bridgeAddButton.Location = New System.Drawing.Point(12, 178)
        Me.bridgeAddButton.Name = "bridgeAddButton"
        Me.bridgeAddButton.Size = New System.Drawing.Size(234, 35)
        Me.bridgeAddButton.TabIndex = 6
        Me.bridgeAddButton.Text = "橋梁追加"
        Me.bridgeAddButton.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 242)
        Me.Controls.Add(Me.bridgeAddButton)
        Me.Controls.Add(Me.bridgeManagementButton)
        Me.Controls.Add(Me.inspectionDataImportButtom)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "MenuForm"
        Me.Text = "橋梁管理システム"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents inspectionDataImportButtom As Button
	Friend WithEvents bridgeManagementButton As Button
	Friend WithEvents bridgeAddButton As Button
End Class

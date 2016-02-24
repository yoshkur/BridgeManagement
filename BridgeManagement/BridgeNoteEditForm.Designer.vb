<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BridgeNoteEditForm
	Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.memo = New System.Windows.Forms.TextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.inspectionway = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.nextinspection = New System.Windows.Forms.TextBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.repair = New System.Windows.Forms.TextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.editBridgeNoteButton = New System.Windows.Forms.Button()
		Me.id = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.BridgeNoteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		CType(Me.BridgeNoteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'memo
		'
		Me.memo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeNoteBindingSource, "memo", True))
		Me.memo.Location = New System.Drawing.Point(142, 215)
		Me.memo.Name = "memo"
		Me.memo.Size = New System.Drawing.Size(220, 19)
		Me.memo.TabIndex = 47
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(12, 215)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(29, 12)
		Me.Label14.TabIndex = 46
		Me.Label14.Text = "備考"
		'
		'inspectionway
		'
		Me.inspectionway.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeNoteBindingSource, "inspectionway", True))
		Me.inspectionway.Location = New System.Drawing.Point(142, 167)
		Me.inspectionway.Name = "inspectionway"
		Me.inspectionway.Size = New System.Drawing.Size(220, 19)
		Me.inspectionway.TabIndex = 45
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(12, 167)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(53, 12)
		Me.Label15.TabIndex = 44
		Me.Label15.Text = "点検方法"
		'
		'nextinspection
		'
		Me.nextinspection.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeNoteBindingSource, "nextinspection", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"))
		Me.nextinspection.Location = New System.Drawing.Point(142, 115)
		Me.nextinspection.Name = "nextinspection"
		Me.nextinspection.Size = New System.Drawing.Size(220, 19)
		Me.nextinspection.TabIndex = 43
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(12, 115)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(77, 12)
		Me.Label16.TabIndex = 42
		Me.Label16.Text = "次回点検年度"
		'
		'repair
		'
		Me.repair.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeNoteBindingSource, "repair", True))
		Me.repair.Location = New System.Drawing.Point(142, 69)
		Me.repair.Name = "repair"
		Me.repair.Size = New System.Drawing.Size(220, 19)
		Me.repair.TabIndex = 41
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Location = New System.Drawing.Point(12, 69)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(53, 12)
		Me.Label17.TabIndex = 40
		Me.Label17.Text = "修繕履歴"
		'
		'editBridgeNoteButton
		'
		Me.editBridgeNoteButton.Location = New System.Drawing.Point(26, 252)
		Me.editBridgeNoteButton.Name = "editBridgeNoteButton"
		Me.editBridgeNoteButton.Size = New System.Drawing.Size(75, 23)
		Me.editBridgeNoteButton.TabIndex = 48
		Me.editBridgeNoteButton.Text = "編集"
		Me.editBridgeNoteButton.UseVisualStyleBackColor = True
		'
		'id
		'
		Me.id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeNoteBindingSource, "id", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
		Me.id.Enabled = False
		Me.id.Location = New System.Drawing.Point(142, 19)
		Me.id.Name = "id"
		Me.id.Size = New System.Drawing.Size(220, 19)
		Me.id.TabIndex = 50
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 19)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(89, 12)
		Me.Label1.TabIndex = 49
		Me.Label1.Text = "国交省作業番号"
		'
		'BridgeNoteBindingSource
		'
		Me.BridgeNoteBindingSource.DataSource = GetType(BridgeManagement.bridgenote)
		'
		'BridgeNoteEditForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(396, 352)
		Me.Controls.Add(Me.id)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.editBridgeNoteButton)
		Me.Controls.Add(Me.memo)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.inspectionway)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.nextinspection)
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.repair)
		Me.Controls.Add(Me.Label17)
		Me.Name = "BridgeNoteEditForm"
		Me.Text = "橋梁メモ編集"
		CType(Me.BridgeNoteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents BridgeNoteBindingSource As BindingSource
	Friend WithEvents memo As TextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents inspectionway As TextBox
	Friend WithEvents Label15 As Label
	Friend WithEvents nextinspection As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents repair As TextBox
	Friend WithEvents Label17 As Label
	Friend WithEvents editBridgeNoteButton As Button
	Friend WithEvents id As TextBox
	Friend WithEvents Label1 As Label
End Class

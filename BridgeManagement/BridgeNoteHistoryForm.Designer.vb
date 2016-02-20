<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BridgeNoteHistoryForm
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
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RecorddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RecordprogramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RecorduseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RecordvalidDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.RepairDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NextinspectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.InspectionwayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MemoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgenotehistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BridgenotehistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.RecorddateDataGridViewTextBoxColumn, Me.RecordprogramDataGridViewTextBoxColumn, Me.RecorduseridDataGridViewTextBoxColumn, Me.RecordvalidDataGridViewCheckBoxColumn, Me.RepairDataGridViewTextBoxColumn, Me.NextinspectionDataGridViewTextBoxColumn, Me.InspectionwayDataGridViewTextBoxColumn, Me.MemoDataGridViewTextBoxColumn})
		Me.DataGridView1.DataSource = Me.BridgenotehistoryBindingSource
		Me.DataGridView1.Location = New System.Drawing.Point(22, 22)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowTemplate.Height = 21
		Me.DataGridView1.Size = New System.Drawing.Size(950, 453)
		Me.DataGridView1.TabIndex = 0
		'
		'IdDataGridViewTextBoxColumn
		'
		Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
		Me.IdDataGridViewTextBoxColumn.HeaderText = "国交省作業番号"
		Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
		Me.IdDataGridViewTextBoxColumn.ReadOnly = True
		'
		'RecorddateDataGridViewTextBoxColumn
		'
		Me.RecorddateDataGridViewTextBoxColumn.DataPropertyName = "recorddate"
		Me.RecorddateDataGridViewTextBoxColumn.HeaderText = "登録日"
		Me.RecorddateDataGridViewTextBoxColumn.Name = "RecorddateDataGridViewTextBoxColumn"
		Me.RecorddateDataGridViewTextBoxColumn.ReadOnly = True
		'
		'RecordprogramDataGridViewTextBoxColumn
		'
		Me.RecordprogramDataGridViewTextBoxColumn.DataPropertyName = "recordprogram"
		Me.RecordprogramDataGridViewTextBoxColumn.HeaderText = "recordprogram"
		Me.RecordprogramDataGridViewTextBoxColumn.Name = "RecordprogramDataGridViewTextBoxColumn"
		Me.RecordprogramDataGridViewTextBoxColumn.ReadOnly = True
		'
		'RecorduseridDataGridViewTextBoxColumn
		'
		Me.RecorduseridDataGridViewTextBoxColumn.DataPropertyName = "recorduserid"
		Me.RecorduseridDataGridViewTextBoxColumn.HeaderText = "recorduserid"
		Me.RecorduseridDataGridViewTextBoxColumn.Name = "RecorduseridDataGridViewTextBoxColumn"
		Me.RecorduseridDataGridViewTextBoxColumn.ReadOnly = True
		'
		'RecordvalidDataGridViewCheckBoxColumn
		'
		Me.RecordvalidDataGridViewCheckBoxColumn.DataPropertyName = "recordvalid"
		Me.RecordvalidDataGridViewCheckBoxColumn.HeaderText = "recordvalid"
		Me.RecordvalidDataGridViewCheckBoxColumn.Name = "RecordvalidDataGridViewCheckBoxColumn"
		Me.RecordvalidDataGridViewCheckBoxColumn.ReadOnly = True
		'
		'RepairDataGridViewTextBoxColumn
		'
		Me.RepairDataGridViewTextBoxColumn.DataPropertyName = "repair"
		Me.RepairDataGridViewTextBoxColumn.HeaderText = "修繕履歴"
		Me.RepairDataGridViewTextBoxColumn.Name = "RepairDataGridViewTextBoxColumn"
		Me.RepairDataGridViewTextBoxColumn.ReadOnly = True
		'
		'NextinspectionDataGridViewTextBoxColumn
		'
		Me.NextinspectionDataGridViewTextBoxColumn.DataPropertyName = "nextinspection"
		Me.NextinspectionDataGridViewTextBoxColumn.HeaderText = "次回点検年度"
		Me.NextinspectionDataGridViewTextBoxColumn.Name = "NextinspectionDataGridViewTextBoxColumn"
		Me.NextinspectionDataGridViewTextBoxColumn.ReadOnly = True
		'
		'InspectionwayDataGridViewTextBoxColumn
		'
		Me.InspectionwayDataGridViewTextBoxColumn.DataPropertyName = "inspectionway"
		Me.InspectionwayDataGridViewTextBoxColumn.HeaderText = "点検方法"
		Me.InspectionwayDataGridViewTextBoxColumn.Name = "InspectionwayDataGridViewTextBoxColumn"
		Me.InspectionwayDataGridViewTextBoxColumn.ReadOnly = True
		'
		'MemoDataGridViewTextBoxColumn
		'
		Me.MemoDataGridViewTextBoxColumn.DataPropertyName = "memo"
		Me.MemoDataGridViewTextBoxColumn.HeaderText = "備考"
		Me.MemoDataGridViewTextBoxColumn.Name = "MemoDataGridViewTextBoxColumn"
		Me.MemoDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BridgenotehistoryBindingSource
		'
		Me.BridgenotehistoryBindingSource.DataSource = GetType(BridgeManagement.bridgenotehistory)
		'
		'BridgeNoteHistoryForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(989, 487)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "BridgeNoteHistoryForm"
		Me.Text = "橋梁メモ履歴"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BridgenotehistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents RecorddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents RecordprogramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents RecorduseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents RecordvalidDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
	Friend WithEvents RepairDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents NextinspectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents InspectionwayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MemoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents BridgenotehistoryBindingSource As BindingSource
End Class

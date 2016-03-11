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
        Me.recorddate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NextinspectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InspectionwayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BridgenotehistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BridgenotehistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.recorddate, Me.RepairDataGridViewTextBoxColumn, Me.NextinspectionDataGridViewTextBoxColumn, Me.InspectionwayDataGridViewTextBoxColumn, Me.MemoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BridgenotehistoryBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(989, 452)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "国交省作業番号"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'recorddate
        '
        Me.recorddate.DataPropertyName = "recorddate"
        Me.recorddate.HeaderText = "データ保存日時"
        Me.recorddate.Name = "recorddate"
        Me.recorddate.ReadOnly = True
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(989, 487)
        Me.SplitContainer1.SplitterDistance = 31
        Me.SplitContainer1.TabIndex = 1
        '
        'BridgeNoteHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 487)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "BridgeNoteHistoryForm"
        Me.Text = "橋梁メモ履歴"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BridgenotehistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents BridgenotehistoryBindingSource As BindingSource
	Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents recorddate As DataGridViewTextBoxColumn
	Friend WithEvents RepairDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents NextinspectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents InspectionwayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MemoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As SplitContainer
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BridgeHistoryForm
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
		Me.BridgehistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.recorddate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgenamerubyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RouteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.LatitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.LongitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgelengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgewidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SpanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgestructureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.UppermaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.LowermaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.UnderconditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.EmergencyroadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BridgehistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.recorddate, Me.BridgenameDataGridViewTextBoxColumn, Me.BridgenamerubyDataGridViewTextBoxColumn, Me.RouteDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.LatitudeDataGridViewTextBoxColumn, Me.LongitudeDataGridViewTextBoxColumn, Me.MadeDataGridViewTextBoxColumn, Me.BridgelengthDataGridViewTextBoxColumn, Me.BridgewidthDataGridViewTextBoxColumn, Me.SpanDataGridViewTextBoxColumn, Me.BridgestructureDataGridViewTextBoxColumn, Me.UppermaterialDataGridViewTextBoxColumn, Me.LowermaterialDataGridViewTextBoxColumn, Me.UnderconditionDataGridViewTextBoxColumn, Me.EmergencyroadDataGridViewTextBoxColumn})
		Me.DataGridView1.DataSource = Me.BridgehistoryBindingSource
		Me.DataGridView1.Location = New System.Drawing.Point(13, 23)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowTemplate.Height = 21
		Me.DataGridView1.Size = New System.Drawing.Size(1183, 428)
		Me.DataGridView1.TabIndex = 0
		'
		'BridgehistoryBindingSource
		'
		Me.BridgehistoryBindingSource.DataSource = GetType(BridgeManagement.bridgehistory)
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
		'BridgenameDataGridViewTextBoxColumn
		'
		Me.BridgenameDataGridViewTextBoxColumn.DataPropertyName = "bridgename"
		Me.BridgenameDataGridViewTextBoxColumn.HeaderText = "道路橋名"
		Me.BridgenameDataGridViewTextBoxColumn.Name = "BridgenameDataGridViewTextBoxColumn"
		Me.BridgenameDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BridgenamerubyDataGridViewTextBoxColumn
		'
		Me.BridgenamerubyDataGridViewTextBoxColumn.DataPropertyName = "bridgenameruby"
		Me.BridgenamerubyDataGridViewTextBoxColumn.HeaderText = "道路橋名(カナ)"
		Me.BridgenamerubyDataGridViewTextBoxColumn.Name = "BridgenamerubyDataGridViewTextBoxColumn"
		Me.BridgenamerubyDataGridViewTextBoxColumn.ReadOnly = True
		'
		'RouteDataGridViewTextBoxColumn
		'
		Me.RouteDataGridViewTextBoxColumn.DataPropertyName = "route"
		Me.RouteDataGridViewTextBoxColumn.HeaderText = "路線名"
		Me.RouteDataGridViewTextBoxColumn.Name = "RouteDataGridViewTextBoxColumn"
		Me.RouteDataGridViewTextBoxColumn.ReadOnly = True
		'
		'AddressDataGridViewTextBoxColumn
		'
		Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
		Me.AddressDataGridViewTextBoxColumn.HeaderText = "所在地"
		Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
		Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
		'
		'LatitudeDataGridViewTextBoxColumn
		'
		Me.LatitudeDataGridViewTextBoxColumn.DataPropertyName = "latitude"
		Me.LatitudeDataGridViewTextBoxColumn.HeaderText = "緯度"
		Me.LatitudeDataGridViewTextBoxColumn.Name = "LatitudeDataGridViewTextBoxColumn"
		Me.LatitudeDataGridViewTextBoxColumn.ReadOnly = True
		'
		'LongitudeDataGridViewTextBoxColumn
		'
		Me.LongitudeDataGridViewTextBoxColumn.DataPropertyName = "longitude"
		Me.LongitudeDataGridViewTextBoxColumn.HeaderText = "経度"
		Me.LongitudeDataGridViewTextBoxColumn.Name = "LongitudeDataGridViewTextBoxColumn"
		Me.LongitudeDataGridViewTextBoxColumn.ReadOnly = True
		'
		'MadeDataGridViewTextBoxColumn
		'
		Me.MadeDataGridViewTextBoxColumn.DataPropertyName = "made"
		Me.MadeDataGridViewTextBoxColumn.HeaderText = "架設年次"
		Me.MadeDataGridViewTextBoxColumn.Name = "MadeDataGridViewTextBoxColumn"
		Me.MadeDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BridgelengthDataGridViewTextBoxColumn
		'
		Me.BridgelengthDataGridViewTextBoxColumn.DataPropertyName = "bridgelength"
		Me.BridgelengthDataGridViewTextBoxColumn.HeaderText = "橋長"
		Me.BridgelengthDataGridViewTextBoxColumn.Name = "BridgelengthDataGridViewTextBoxColumn"
		Me.BridgelengthDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BridgewidthDataGridViewTextBoxColumn
		'
		Me.BridgewidthDataGridViewTextBoxColumn.DataPropertyName = "bridgewidth"
		Me.BridgewidthDataGridViewTextBoxColumn.HeaderText = "幅員"
		Me.BridgewidthDataGridViewTextBoxColumn.Name = "BridgewidthDataGridViewTextBoxColumn"
		Me.BridgewidthDataGridViewTextBoxColumn.ReadOnly = True
		'
		'SpanDataGridViewTextBoxColumn
		'
		Me.SpanDataGridViewTextBoxColumn.DataPropertyName = "span"
		Me.SpanDataGridViewTextBoxColumn.HeaderText = "径間数"
		Me.SpanDataGridViewTextBoxColumn.Name = "SpanDataGridViewTextBoxColumn"
		Me.SpanDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BridgestructureDataGridViewTextBoxColumn
		'
		Me.BridgestructureDataGridViewTextBoxColumn.DataPropertyName = "bridgestructure"
		Me.BridgestructureDataGridViewTextBoxColumn.HeaderText = "構造形式"
		Me.BridgestructureDataGridViewTextBoxColumn.Name = "BridgestructureDataGridViewTextBoxColumn"
		Me.BridgestructureDataGridViewTextBoxColumn.ReadOnly = True
		'
		'UppermaterialDataGridViewTextBoxColumn
		'
		Me.UppermaterialDataGridViewTextBoxColumn.DataPropertyName = "uppermaterial"
		Me.UppermaterialDataGridViewTextBoxColumn.HeaderText = "上部工使用材料"
		Me.UppermaterialDataGridViewTextBoxColumn.Name = "UppermaterialDataGridViewTextBoxColumn"
		Me.UppermaterialDataGridViewTextBoxColumn.ReadOnly = True
		'
		'LowermaterialDataGridViewTextBoxColumn
		'
		Me.LowermaterialDataGridViewTextBoxColumn.DataPropertyName = "lowermaterial"
		Me.LowermaterialDataGridViewTextBoxColumn.HeaderText = "床板材料"
		Me.LowermaterialDataGridViewTextBoxColumn.Name = "LowermaterialDataGridViewTextBoxColumn"
		Me.LowermaterialDataGridViewTextBoxColumn.ReadOnly = True
		'
		'UnderconditionDataGridViewTextBoxColumn
		'
		Me.UnderconditionDataGridViewTextBoxColumn.DataPropertyName = "undercondition"
		Me.UnderconditionDataGridViewTextBoxColumn.HeaderText = "路下条件"
		Me.UnderconditionDataGridViewTextBoxColumn.Name = "UnderconditionDataGridViewTextBoxColumn"
		Me.UnderconditionDataGridViewTextBoxColumn.ReadOnly = True
		'
		'EmergencyroadDataGridViewTextBoxColumn
		'
		Me.EmergencyroadDataGridViewTextBoxColumn.DataPropertyName = "emergencyroad"
		Me.EmergencyroadDataGridViewTextBoxColumn.HeaderText = "緊急輸送道路"
		Me.EmergencyroadDataGridViewTextBoxColumn.Name = "EmergencyroadDataGridViewTextBoxColumn"
		Me.EmergencyroadDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BridgeHistoryForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1208, 463)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "BridgeHistoryForm"
		Me.Text = "橋梁履歴"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BridgehistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents BridgehistoryBindingSource As BindingSource
	Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents recorddate As DataGridViewTextBoxColumn
	Friend WithEvents BridgenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents BridgenamerubyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents RouteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents LatitudeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents LongitudeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents BridgelengthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents BridgewidthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SpanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents BridgestructureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents UppermaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents LowermaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents UnderconditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmergencyroadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

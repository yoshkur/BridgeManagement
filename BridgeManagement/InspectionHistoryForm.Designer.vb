<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InspectionHistoryForm
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
		Me.InspectionhistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.recorddate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.inspectionyear = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.inspectioner = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.undercondition = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.alternatepath = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.generalroad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.emergencyroad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.occupancy = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.soundness = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.uppermaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.undermaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.bearing = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.face = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.datasavedir = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.InspectionhistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.recorddate, Me.inspectionyear, Me.inspectioner, Me.undercondition, Me.alternatepath, Me.generalroad, Me.emergencyroad, Me.occupancy, Me.soundness, Me.uppermaterial, Me.undermaterial, Me.bearing, Me.face, Me.datasavedir})
		Me.DataGridView1.DataSource = Me.InspectionhistoryBindingSource
		Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowTemplate.Height = 21
		Me.DataGridView1.Size = New System.Drawing.Size(838, 403)
		Me.DataGridView1.TabIndex = 0
		'
		'InspectionhistoryBindingSource
		'
		Me.InspectionhistoryBindingSource.DataSource = GetType(BridgeManagement.inspectionhistory)
		'
		'id
		'
		Me.id.DataPropertyName = "id"
		Me.id.HeaderText = "国交省作業番号"
		Me.id.Name = "id"
		Me.id.ReadOnly = True
		'
		'recorddate
		'
		Me.recorddate.DataPropertyName = "recorddate"
		Me.recorddate.HeaderText = "登録日"
		Me.recorddate.Name = "recorddate"
		Me.recorddate.ReadOnly = True
		'
		'inspectionyear
		'
		Me.inspectionyear.DataPropertyName = "inspectionyear"
		Me.inspectionyear.HeaderText = "最新点検年度"
		Me.inspectionyear.Name = "inspectionyear"
		Me.inspectionyear.ReadOnly = True
		'
		'inspectioner
		'
		Me.inspectioner.DataPropertyName = "inspectioner"
		Me.inspectioner.HeaderText = "点検者"
		Me.inspectioner.Name = "inspectioner"
		Me.inspectioner.ReadOnly = True
		'
		'undercondition
		'
		Me.undercondition.DataPropertyName = "undercondition"
		Me.undercondition.HeaderText = "路下条件"
		Me.undercondition.Name = "undercondition"
		Me.undercondition.ReadOnly = True
		'
		'alternatepath
		'
		Me.alternatepath.DataPropertyName = "alternatepath"
		Me.alternatepath.HeaderText = "代替路有無"
		Me.alternatepath.Name = "alternatepath"
		Me.alternatepath.ReadOnly = True
		'
		'generalroad
		'
		Me.generalroad.DataPropertyName = "generalroad"
		Me.generalroad.HeaderText = "自専道or一般道"
		Me.generalroad.Name = "generalroad"
		Me.generalroad.ReadOnly = True
		'
		'emergencyroad
		'
		Me.emergencyroad.DataPropertyName = "emergencyroad"
		Me.emergencyroad.HeaderText = "緊急輸送道路"
		Me.emergencyroad.Name = "emergencyroad"
		Me.emergencyroad.ReadOnly = True
		'
		'occupancy
		'
		Me.occupancy.DataPropertyName = "occupancy"
		Me.occupancy.HeaderText = "占用物件（名称）"
		Me.occupancy.Name = "occupancy"
		Me.occupancy.ReadOnly = True
		'
		'soundness
		'
		Me.soundness.DataPropertyName = "soundness"
		Me.soundness.HeaderText = "健全度"
		Me.soundness.Name = "soundness"
		Me.soundness.ReadOnly = True
		'
		'uppermaterial
		'
		Me.uppermaterial.DataPropertyName = "uppermaterial"
		Me.uppermaterial.HeaderText = "上部工"
		Me.uppermaterial.Name = "uppermaterial"
		Me.uppermaterial.ReadOnly = True
		'
		'undermaterial
		'
		Me.undermaterial.DataPropertyName = "undermaterial"
		Me.undermaterial.HeaderText = "下部工"
		Me.undermaterial.Name = "undermaterial"
		Me.undermaterial.ReadOnly = True
		'
		'bearing
		'
		Me.bearing.DataPropertyName = "bearing"
		Me.bearing.HeaderText = "支承"
		Me.bearing.Name = "bearing"
		Me.bearing.ReadOnly = True
		'
		'face
		'
		Me.face.DataPropertyName = "face"
		Me.face.HeaderText = "橋面"
		Me.face.Name = "face"
		Me.face.ReadOnly = True
		'
		'datasavedir
		'
		Me.datasavedir.DataPropertyName = "datasavedir"
		Me.datasavedir.HeaderText = "データディレクトリ"
		Me.datasavedir.Name = "datasavedir"
		Me.datasavedir.ReadOnly = True
		'
		'InspectionHistoryForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(863, 428)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "InspectionHistoryForm"
		Me.Text = "InspectionHistoryForm"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.InspectionhistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents id As DataGridViewTextBoxColumn
	Friend WithEvents recorddate As DataGridViewTextBoxColumn
	Friend WithEvents inspectionyear As DataGridViewTextBoxColumn
	Friend WithEvents inspectioner As DataGridViewTextBoxColumn
	Friend WithEvents undercondition As DataGridViewTextBoxColumn
	Friend WithEvents alternatepath As DataGridViewTextBoxColumn
	Friend WithEvents generalroad As DataGridViewTextBoxColumn
	Friend WithEvents emergencyroad As DataGridViewTextBoxColumn
	Friend WithEvents occupancy As DataGridViewTextBoxColumn
	Friend WithEvents soundness As DataGridViewTextBoxColumn
	Friend WithEvents uppermaterial As DataGridViewTextBoxColumn
	Friend WithEvents undermaterial As DataGridViewTextBoxColumn
	Friend WithEvents bearing As DataGridViewTextBoxColumn
	Friend WithEvents face As DataGridViewTextBoxColumn
	Friend WithEvents datasavedir As DataGridViewTextBoxColumn
	Friend WithEvents InspectionhistoryBindingSource As BindingSource
End Class

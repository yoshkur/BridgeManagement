<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BridgeManagementViewForm
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
		Me.inspectionHistoryButton = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.bridgename = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.bridgenameruby = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.route = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.latitude = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.longitude = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.made = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.bridgeage = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.bridgelength = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.bridgewidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.span = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.bridgestructure = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.uppermaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.lowermaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.undercondition = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.emergencyroad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.repair = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.nextinspection = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.inspectionway = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.memo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.inspectionyear = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.inspectioner = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.inspectionundercondition = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.alternatepath = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.generalroad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.inspectionemergencyroad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.occupancy = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.soundness = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.inspectionuppermaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.undermaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.bearing = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.face = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.datasavedir = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'inspectionHistoryButton
		'
		Me.inspectionHistoryButton.Location = New System.Drawing.Point(369, 13)
		Me.inspectionHistoryButton.Name = "inspectionHistoryButton"
		Me.inspectionHistoryButton.Size = New System.Drawing.Size(75, 23)
		Me.inspectionHistoryButton.TabIndex = 1
		Me.inspectionHistoryButton.Text = "点検履歴"
		Me.inspectionHistoryButton.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.bridgename, Me.bridgenameruby, Me.route, Me.address, Me.latitude, Me.longitude, Me.made, Me.bridgeage, Me.bridgelength, Me.bridgewidth, Me.span, Me.bridgestructure, Me.uppermaterial, Me.lowermaterial, Me.undercondition, Me.emergencyroad, Me.repair, Me.nextinspection, Me.inspectionway, Me.memo, Me.inspectionyear, Me.inspectioner, Me.inspectionundercondition, Me.alternatepath, Me.generalroad, Me.inspectionemergencyroad, Me.occupancy, Me.soundness, Me.inspectionuppermaterial, Me.undermaterial, Me.bearing, Me.face, Me.datasavedir})
		Me.DataGridView1.Location = New System.Drawing.Point(12, 53)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowTemplate.Height = 21
		Me.DataGridView1.Size = New System.Drawing.Size(1436, 541)
		Me.DataGridView1.TabIndex = 2
		'
		'id
		'
		Me.id.HeaderText = "国交省作業番号"
		Me.id.Name = "id"
		Me.id.ReadOnly = True
		'
		'bridgename
		'
		Me.bridgename.HeaderText = "道路橋名"
		Me.bridgename.Name = "bridgename"
		Me.bridgename.ReadOnly = True
		'
		'bridgenameruby
		'
		Me.bridgenameruby.HeaderText = "道路橋名(カナ)"
		Me.bridgenameruby.Name = "bridgenameruby"
		Me.bridgenameruby.ReadOnly = True
		'
		'route
		'
		Me.route.HeaderText = "路線名"
		Me.route.Name = "route"
		Me.route.ReadOnly = True
		'
		'address
		'
		Me.address.HeaderText = "所在地"
		Me.address.Name = "address"
		Me.address.ReadOnly = True
		'
		'latitude
		'
		Me.latitude.HeaderText = "緯度"
		Me.latitude.Name = "latitude"
		Me.latitude.ReadOnly = True
		'
		'longitude
		'
		Me.longitude.HeaderText = "経度"
		Me.longitude.Name = "longitude"
		Me.longitude.ReadOnly = True
		'
		'made
		'
		Me.made.HeaderText = "架設年次"
		Me.made.Name = "made"
		Me.made.ReadOnly = True
		'
		'bridgeage
		'
		Me.bridgeage.HeaderText = "橋令"
		Me.bridgeage.Name = "bridgeage"
		Me.bridgeage.ReadOnly = True
		'
		'bridgelength
		'
		Me.bridgelength.HeaderText = "橋長"
		Me.bridgelength.Name = "bridgelength"
		Me.bridgelength.ReadOnly = True
		'
		'bridgewidth
		'
		Me.bridgewidth.HeaderText = "幅員"
		Me.bridgewidth.Name = "bridgewidth"
		Me.bridgewidth.ReadOnly = True
		'
		'span
		'
		Me.span.HeaderText = "径間数"
		Me.span.Name = "span"
		Me.span.ReadOnly = True
		'
		'bridgestructure
		'
		Me.bridgestructure.HeaderText = "構造形式"
		Me.bridgestructure.Name = "bridgestructure"
		Me.bridgestructure.ReadOnly = True
		'
		'uppermaterial
		'
		Me.uppermaterial.HeaderText = "上部工使用材料"
		Me.uppermaterial.Name = "uppermaterial"
		Me.uppermaterial.ReadOnly = True
		'
		'lowermaterial
		'
		Me.lowermaterial.HeaderText = "床板材料"
		Me.lowermaterial.Name = "lowermaterial"
		Me.lowermaterial.ReadOnly = True
		'
		'undercondition
		'
		Me.undercondition.HeaderText = "路下条件"
		Me.undercondition.Name = "undercondition"
		Me.undercondition.ReadOnly = True
		'
		'emergencyroad
		'
		Me.emergencyroad.HeaderText = "緊急輸送道路"
		Me.emergencyroad.Name = "emergencyroad"
		Me.emergencyroad.ReadOnly = True
		'
		'repair
		'
		Me.repair.HeaderText = "修繕履歴"
		Me.repair.Name = "repair"
		Me.repair.ReadOnly = True
		'
		'nextinspection
		'
		Me.nextinspection.HeaderText = "次回点検年度"
		Me.nextinspection.Name = "nextinspection"
		Me.nextinspection.ReadOnly = True
		'
		'inspectionway
		'
		Me.inspectionway.HeaderText = "点検方法"
		Me.inspectionway.Name = "inspectionway"
		Me.inspectionway.ReadOnly = True
		'
		'memo
		'
		Me.memo.HeaderText = "備考"
		Me.memo.Name = "memo"
		Me.memo.ReadOnly = True
		'
		'inspectionyear
		'
		Me.inspectionyear.HeaderText = "最新点検年度"
		Me.inspectionyear.Name = "inspectionyear"
		Me.inspectionyear.ReadOnly = True
		'
		'inspectioner
		'
		Me.inspectioner.HeaderText = "点検者"
		Me.inspectioner.Name = "inspectioner"
		Me.inspectioner.ReadOnly = True
		'
		'inspectionundercondition
		'
		Me.inspectionundercondition.HeaderText = "路下条件(点検)"
		Me.inspectionundercondition.Name = "inspectionundercondition"
		Me.inspectionundercondition.ReadOnly = True
		'
		'alternatepath
		'
		Me.alternatepath.HeaderText = "代替路有無"
		Me.alternatepath.Name = "alternatepath"
		Me.alternatepath.ReadOnly = True
		'
		'generalroad
		'
		Me.generalroad.HeaderText = "自専道or一般道"
		Me.generalroad.Name = "generalroad"
		Me.generalroad.ReadOnly = True
		'
		'inspectionemergencyroad
		'
		Me.inspectionemergencyroad.HeaderText = "緊急輸送道路(点検)"
		Me.inspectionemergencyroad.Name = "inspectionemergencyroad"
		Me.inspectionemergencyroad.ReadOnly = True
		'
		'occupancy
		'
		Me.occupancy.HeaderText = "占用物件（名称）"
		Me.occupancy.Name = "occupancy"
		Me.occupancy.ReadOnly = True
		'
		'soundness
		'
		Me.soundness.HeaderText = "健全度"
		Me.soundness.Name = "soundness"
		Me.soundness.ReadOnly = True
		'
		'inspectionuppermaterial
		'
		Me.inspectionuppermaterial.HeaderText = "上部工(点検)"
		Me.inspectionuppermaterial.Name = "inspectionuppermaterial"
		Me.inspectionuppermaterial.ReadOnly = True
		'
		'undermaterial
		'
		Me.undermaterial.HeaderText = "下部工"
		Me.undermaterial.Name = "undermaterial"
		Me.undermaterial.ReadOnly = True
		'
		'bearing
		'
		Me.bearing.HeaderText = "支承"
		Me.bearing.Name = "bearing"
		Me.bearing.ReadOnly = True
		'
		'face
		'
		Me.face.HeaderText = "橋面"
		Me.face.Name = "face"
		Me.face.ReadOnly = True
		'
		'datasavedir
		'
		Me.datasavedir.HeaderText = "データディレクトリ"
		Me.datasavedir.Name = "datasavedir"
		Me.datasavedir.ReadOnly = True
		'
		'BridgeManagementViewForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1460, 606)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.inspectionHistoryButton)
		Me.Name = "BridgeManagementViewForm"
		Me.Text = "BridgeManagementViewForm"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents inspectionHistoryButton As Button
	Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
	Friend WithEvents RepairDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents NextinspectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents InspectionwayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MemoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents InspectionyearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents InspectionerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AlternatepathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents GeneralroadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents Expr2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents OccupancyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SoundnessDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents Expr3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents UndermaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents BearingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents FaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DatasavedirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents id As DataGridViewTextBoxColumn
	Friend WithEvents bridgename As DataGridViewTextBoxColumn
	Friend WithEvents bridgenameruby As DataGridViewTextBoxColumn
	Friend WithEvents route As DataGridViewTextBoxColumn
	Friend WithEvents address As DataGridViewTextBoxColumn
	Friend WithEvents latitude As DataGridViewTextBoxColumn
	Friend WithEvents longitude As DataGridViewTextBoxColumn
	Friend WithEvents made As DataGridViewTextBoxColumn
	Friend WithEvents bridgeage As DataGridViewTextBoxColumn
	Friend WithEvents bridgelength As DataGridViewTextBoxColumn
	Friend WithEvents bridgewidth As DataGridViewTextBoxColumn
	Friend WithEvents span As DataGridViewTextBoxColumn
	Friend WithEvents bridgestructure As DataGridViewTextBoxColumn
	Friend WithEvents uppermaterial As DataGridViewTextBoxColumn
	Friend WithEvents lowermaterial As DataGridViewTextBoxColumn
	Friend WithEvents undercondition As DataGridViewTextBoxColumn
	Friend WithEvents emergencyroad As DataGridViewTextBoxColumn
	Friend WithEvents repair As DataGridViewTextBoxColumn
	Friend WithEvents nextinspection As DataGridViewTextBoxColumn
	Friend WithEvents inspectionway As DataGridViewTextBoxColumn
	Friend WithEvents memo As DataGridViewTextBoxColumn
	Friend WithEvents inspectionyear As DataGridViewTextBoxColumn
	Friend WithEvents inspectioner As DataGridViewTextBoxColumn
	Friend WithEvents inspectionundercondition As DataGridViewTextBoxColumn
	Friend WithEvents alternatepath As DataGridViewTextBoxColumn
	Friend WithEvents generalroad As DataGridViewTextBoxColumn
	Friend WithEvents inspectionemergencyroad As DataGridViewTextBoxColumn
	Friend WithEvents occupancy As DataGridViewTextBoxColumn
	Friend WithEvents soundness As DataGridViewTextBoxColumn
	Friend WithEvents inspectionuppermaterial As DataGridViewTextBoxColumn
	Friend WithEvents undermaterial As DataGridViewTextBoxColumn
	Friend WithEvents bearing As DataGridViewTextBoxColumn
	Friend WithEvents face As DataGridViewTextBoxColumn
	Friend WithEvents datasavedir As DataGridViewTextBoxColumn
End Class

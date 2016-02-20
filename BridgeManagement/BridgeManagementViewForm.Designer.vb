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
		Me.components = New System.ComponentModel.Container()
		Me.inspectionHistoryButton = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.bridgeHistoryButton = New System.Windows.Forms.Button()
		Me.BridgemanagementviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgeageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.InspectionunderconditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.InspectionemergencyroadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.InspectionuppermaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BridgemanagementviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'inspectionHistoryButton
		'
		Me.inspectionHistoryButton.Location = New System.Drawing.Point(12, 13)
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
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.bridgename, Me.bridgenameruby, Me.route, Me.address, Me.latitude, Me.longitude, Me.made, Me.bridgeage, Me.bridgelength, Me.bridgewidth, Me.span, Me.bridgestructure, Me.uppermaterial, Me.lowermaterial, Me.undercondition, Me.emergencyroad, Me.repair, Me.nextinspection, Me.inspectionway, Me.memo, Me.inspectionyear, Me.inspectioner, Me.inspectionundercondition, Me.alternatepath, Me.generalroad, Me.inspectionemergencyroad, Me.occupancy, Me.soundness, Me.inspectionuppermaterial, Me.undermaterial, Me.bearing, Me.face, Me.datasavedir, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.BridgeageDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.InspectionunderconditionDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.InspectionemergencyroadDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.InspectionuppermaterialDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30})
		Me.DataGridView1.DataSource = Me.BridgemanagementviewBindingSource
		Me.DataGridView1.Location = New System.Drawing.Point(12, 53)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowTemplate.Height = 21
		Me.DataGridView1.Size = New System.Drawing.Size(1436, 541)
		Me.DataGridView1.TabIndex = 2
		'
		'bridgeHistoryButton
		'
		Me.bridgeHistoryButton.Location = New System.Drawing.Point(262, 12)
		Me.bridgeHistoryButton.Name = "bridgeHistoryButton"
		Me.bridgeHistoryButton.Size = New System.Drawing.Size(75, 23)
		Me.bridgeHistoryButton.TabIndex = 3
		Me.bridgeHistoryButton.Text = "橋梁履歴"
		Me.bridgeHistoryButton.UseVisualStyleBackColor = True
		'
		'BridgemanagementviewBindingSource
		'
		Me.BridgemanagementviewBindingSource.DataSource = GetType(BridgeManagement.bridgemanagementview)
		'
		'id
		'
		Me.id.DataPropertyName = "id"
		Me.id.HeaderText = "国交省作業番号"
		Me.id.Name = "id"
		Me.id.ReadOnly = True
		'
		'bridgename
		'
		Me.bridgename.DataPropertyName = "bridgename"
		Me.bridgename.HeaderText = "道路橋名"
		Me.bridgename.Name = "bridgename"
		Me.bridgename.ReadOnly = True
		'
		'bridgenameruby
		'
		Me.bridgenameruby.DataPropertyName = "bridgenameruby"
		Me.bridgenameruby.HeaderText = "道路橋名(カナ)"
		Me.bridgenameruby.Name = "bridgenameruby"
		Me.bridgenameruby.ReadOnly = True
		'
		'route
		'
		Me.route.DataPropertyName = "route"
		Me.route.HeaderText = "路線名"
		Me.route.Name = "route"
		Me.route.ReadOnly = True
		'
		'address
		'
		Me.address.DataPropertyName = "address"
		Me.address.HeaderText = "所在地"
		Me.address.Name = "address"
		Me.address.ReadOnly = True
		'
		'latitude
		'
		Me.latitude.DataPropertyName = "latitude"
		Me.latitude.HeaderText = "緯度"
		Me.latitude.Name = "latitude"
		Me.latitude.ReadOnly = True
		'
		'longitude
		'
		Me.longitude.DataPropertyName = "longitude"
		Me.longitude.HeaderText = "経度"
		Me.longitude.Name = "longitude"
		Me.longitude.ReadOnly = True
		'
		'made
		'
		Me.made.DataPropertyName = "made"
		Me.made.HeaderText = "架設年次"
		Me.made.Name = "made"
		Me.made.ReadOnly = True
		'
		'bridgeage
		'
		Me.bridgeage.DataPropertyName = "bridgeage"
		Me.bridgeage.HeaderText = "橋令"
		Me.bridgeage.Name = "bridgeage"
		Me.bridgeage.ReadOnly = True
		'
		'bridgelength
		'
		Me.bridgelength.DataPropertyName = "bridgelength"
		Me.bridgelength.HeaderText = "橋長"
		Me.bridgelength.Name = "bridgelength"
		Me.bridgelength.ReadOnly = True
		'
		'bridgewidth
		'
		Me.bridgewidth.DataPropertyName = "bridgewidth"
		Me.bridgewidth.HeaderText = "幅員"
		Me.bridgewidth.Name = "bridgewidth"
		Me.bridgewidth.ReadOnly = True
		'
		'span
		'
		Me.span.DataPropertyName = "span"
		Me.span.HeaderText = "径間数"
		Me.span.Name = "span"
		Me.span.ReadOnly = True
		'
		'bridgestructure
		'
		Me.bridgestructure.DataPropertyName = "bridgestructure"
		Me.bridgestructure.HeaderText = "構造形式"
		Me.bridgestructure.Name = "bridgestructure"
		Me.bridgestructure.ReadOnly = True
		'
		'uppermaterial
		'
		Me.uppermaterial.DataPropertyName = "uppermaterial"
		Me.uppermaterial.HeaderText = "上部工使用材料"
		Me.uppermaterial.Name = "uppermaterial"
		Me.uppermaterial.ReadOnly = True
		'
		'lowermaterial
		'
		Me.lowermaterial.DataPropertyName = "lowermaterial"
		Me.lowermaterial.HeaderText = "床板材料"
		Me.lowermaterial.Name = "lowermaterial"
		Me.lowermaterial.ReadOnly = True
		'
		'undercondition
		'
		Me.undercondition.DataPropertyName = "undercondition"
		Me.undercondition.HeaderText = "路下条件"
		Me.undercondition.Name = "undercondition"
		Me.undercondition.ReadOnly = True
		'
		'emergencyroad
		'
		Me.emergencyroad.DataPropertyName = "emergencyroad"
		Me.emergencyroad.HeaderText = "緊急輸送道路"
		Me.emergencyroad.Name = "emergencyroad"
		Me.emergencyroad.ReadOnly = True
		'
		'repair
		'
		Me.repair.DataPropertyName = "repair"
		Me.repair.HeaderText = "修繕履歴"
		Me.repair.Name = "repair"
		Me.repair.ReadOnly = True
		'
		'nextinspection
		'
		Me.nextinspection.DataPropertyName = "nextinspection"
		Me.nextinspection.HeaderText = "次回点検年度"
		Me.nextinspection.Name = "nextinspection"
		Me.nextinspection.ReadOnly = True
		'
		'inspectionway
		'
		Me.inspectionway.DataPropertyName = "inspectionway"
		Me.inspectionway.HeaderText = "点検方法"
		Me.inspectionway.Name = "inspectionway"
		Me.inspectionway.ReadOnly = True
		'
		'memo
		'
		Me.memo.DataPropertyName = "memo"
		Me.memo.HeaderText = "備考"
		Me.memo.Name = "memo"
		Me.memo.ReadOnly = True
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
		'inspectionundercondition
		'
		Me.inspectionundercondition.DataPropertyName = "inspectionundercondition"
		Me.inspectionundercondition.HeaderText = "路下条件(点検)"
		Me.inspectionundercondition.Name = "inspectionundercondition"
		Me.inspectionundercondition.ReadOnly = True
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
		'inspectionemergencyroad
		'
		Me.inspectionemergencyroad.DataPropertyName = "inspectionemergencyroad"
		Me.inspectionemergencyroad.HeaderText = "緊急輸送道路(点検)"
		Me.inspectionemergencyroad.Name = "inspectionemergencyroad"
		Me.inspectionemergencyroad.ReadOnly = True
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
		'inspectionuppermaterial
		'
		Me.inspectionuppermaterial.DataPropertyName = "inspectionuppermaterial"
		Me.inspectionuppermaterial.HeaderText = "上部工(点検)"
		Me.inspectionuppermaterial.Name = "inspectionuppermaterial"
		Me.inspectionuppermaterial.ReadOnly = True
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
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
		Me.DataGridViewTextBoxColumn1.HeaderText = "id"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.ReadOnly = True
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "bridgename"
		Me.DataGridViewTextBoxColumn2.HeaderText = "bridgename"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		Me.DataGridViewTextBoxColumn2.ReadOnly = True
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.DataPropertyName = "bridgenameruby"
		Me.DataGridViewTextBoxColumn3.HeaderText = "bridgenameruby"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		Me.DataGridViewTextBoxColumn3.ReadOnly = True
		'
		'DataGridViewTextBoxColumn4
		'
		Me.DataGridViewTextBoxColumn4.DataPropertyName = "route"
		Me.DataGridViewTextBoxColumn4.HeaderText = "route"
		Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
		Me.DataGridViewTextBoxColumn4.ReadOnly = True
		'
		'DataGridViewTextBoxColumn5
		'
		Me.DataGridViewTextBoxColumn5.DataPropertyName = "address"
		Me.DataGridViewTextBoxColumn5.HeaderText = "address"
		Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
		Me.DataGridViewTextBoxColumn5.ReadOnly = True
		'
		'DataGridViewTextBoxColumn6
		'
		Me.DataGridViewTextBoxColumn6.DataPropertyName = "latitude"
		Me.DataGridViewTextBoxColumn6.HeaderText = "latitude"
		Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
		Me.DataGridViewTextBoxColumn6.ReadOnly = True
		'
		'DataGridViewTextBoxColumn7
		'
		Me.DataGridViewTextBoxColumn7.DataPropertyName = "longitude"
		Me.DataGridViewTextBoxColumn7.HeaderText = "longitude"
		Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
		Me.DataGridViewTextBoxColumn7.ReadOnly = True
		'
		'DataGridViewTextBoxColumn8
		'
		Me.DataGridViewTextBoxColumn8.DataPropertyName = "made"
		Me.DataGridViewTextBoxColumn8.HeaderText = "made"
		Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
		Me.DataGridViewTextBoxColumn8.ReadOnly = True
		'
		'BridgeageDataGridViewTextBoxColumn
		'
		Me.BridgeageDataGridViewTextBoxColumn.DataPropertyName = "bridgeage"
		Me.BridgeageDataGridViewTextBoxColumn.HeaderText = "bridgeage"
		Me.BridgeageDataGridViewTextBoxColumn.Name = "BridgeageDataGridViewTextBoxColumn"
		Me.BridgeageDataGridViewTextBoxColumn.ReadOnly = True
		'
		'DataGridViewTextBoxColumn9
		'
		Me.DataGridViewTextBoxColumn9.DataPropertyName = "bridgelength"
		Me.DataGridViewTextBoxColumn9.HeaderText = "bridgelength"
		Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
		Me.DataGridViewTextBoxColumn9.ReadOnly = True
		'
		'DataGridViewTextBoxColumn10
		'
		Me.DataGridViewTextBoxColumn10.DataPropertyName = "bridgewidth"
		Me.DataGridViewTextBoxColumn10.HeaderText = "bridgewidth"
		Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
		Me.DataGridViewTextBoxColumn10.ReadOnly = True
		'
		'DataGridViewTextBoxColumn11
		'
		Me.DataGridViewTextBoxColumn11.DataPropertyName = "span"
		Me.DataGridViewTextBoxColumn11.HeaderText = "span"
		Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
		Me.DataGridViewTextBoxColumn11.ReadOnly = True
		'
		'DataGridViewTextBoxColumn12
		'
		Me.DataGridViewTextBoxColumn12.DataPropertyName = "bridgestructure"
		Me.DataGridViewTextBoxColumn12.HeaderText = "bridgestructure"
		Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
		Me.DataGridViewTextBoxColumn12.ReadOnly = True
		'
		'DataGridViewTextBoxColumn13
		'
		Me.DataGridViewTextBoxColumn13.DataPropertyName = "uppermaterial"
		Me.DataGridViewTextBoxColumn13.HeaderText = "uppermaterial"
		Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
		Me.DataGridViewTextBoxColumn13.ReadOnly = True
		'
		'DataGridViewTextBoxColumn14
		'
		Me.DataGridViewTextBoxColumn14.DataPropertyName = "lowermaterial"
		Me.DataGridViewTextBoxColumn14.HeaderText = "lowermaterial"
		Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
		Me.DataGridViewTextBoxColumn14.ReadOnly = True
		'
		'DataGridViewTextBoxColumn15
		'
		Me.DataGridViewTextBoxColumn15.DataPropertyName = "undercondition"
		Me.DataGridViewTextBoxColumn15.HeaderText = "undercondition"
		Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
		Me.DataGridViewTextBoxColumn15.ReadOnly = True
		'
		'DataGridViewTextBoxColumn16
		'
		Me.DataGridViewTextBoxColumn16.DataPropertyName = "emergencyroad"
		Me.DataGridViewTextBoxColumn16.HeaderText = "emergencyroad"
		Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
		Me.DataGridViewTextBoxColumn16.ReadOnly = True
		'
		'DataGridViewTextBoxColumn17
		'
		Me.DataGridViewTextBoxColumn17.DataPropertyName = "repair"
		Me.DataGridViewTextBoxColumn17.HeaderText = "repair"
		Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
		Me.DataGridViewTextBoxColumn17.ReadOnly = True
		'
		'DataGridViewTextBoxColumn18
		'
		Me.DataGridViewTextBoxColumn18.DataPropertyName = "nextinspection"
		Me.DataGridViewTextBoxColumn18.HeaderText = "nextinspection"
		Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
		Me.DataGridViewTextBoxColumn18.ReadOnly = True
		'
		'DataGridViewTextBoxColumn19
		'
		Me.DataGridViewTextBoxColumn19.DataPropertyName = "inspectionway"
		Me.DataGridViewTextBoxColumn19.HeaderText = "inspectionway"
		Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
		Me.DataGridViewTextBoxColumn19.ReadOnly = True
		'
		'DataGridViewTextBoxColumn20
		'
		Me.DataGridViewTextBoxColumn20.DataPropertyName = "memo"
		Me.DataGridViewTextBoxColumn20.HeaderText = "memo"
		Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
		Me.DataGridViewTextBoxColumn20.ReadOnly = True
		'
		'DataGridViewTextBoxColumn21
		'
		Me.DataGridViewTextBoxColumn21.DataPropertyName = "inspectionyear"
		Me.DataGridViewTextBoxColumn21.HeaderText = "inspectionyear"
		Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
		Me.DataGridViewTextBoxColumn21.ReadOnly = True
		'
		'DataGridViewTextBoxColumn22
		'
		Me.DataGridViewTextBoxColumn22.DataPropertyName = "inspectioner"
		Me.DataGridViewTextBoxColumn22.HeaderText = "inspectioner"
		Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
		Me.DataGridViewTextBoxColumn22.ReadOnly = True
		'
		'InspectionunderconditionDataGridViewTextBoxColumn
		'
		Me.InspectionunderconditionDataGridViewTextBoxColumn.DataPropertyName = "inspectionundercondition"
		Me.InspectionunderconditionDataGridViewTextBoxColumn.HeaderText = "inspectionundercondition"
		Me.InspectionunderconditionDataGridViewTextBoxColumn.Name = "InspectionunderconditionDataGridViewTextBoxColumn"
		Me.InspectionunderconditionDataGridViewTextBoxColumn.ReadOnly = True
		'
		'DataGridViewTextBoxColumn23
		'
		Me.DataGridViewTextBoxColumn23.DataPropertyName = "alternatepath"
		Me.DataGridViewTextBoxColumn23.HeaderText = "alternatepath"
		Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
		Me.DataGridViewTextBoxColumn23.ReadOnly = True
		'
		'DataGridViewTextBoxColumn24
		'
		Me.DataGridViewTextBoxColumn24.DataPropertyName = "generalroad"
		Me.DataGridViewTextBoxColumn24.HeaderText = "generalroad"
		Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
		Me.DataGridViewTextBoxColumn24.ReadOnly = True
		'
		'InspectionemergencyroadDataGridViewTextBoxColumn
		'
		Me.InspectionemergencyroadDataGridViewTextBoxColumn.DataPropertyName = "inspectionemergencyroad"
		Me.InspectionemergencyroadDataGridViewTextBoxColumn.HeaderText = "inspectionemergencyroad"
		Me.InspectionemergencyroadDataGridViewTextBoxColumn.Name = "InspectionemergencyroadDataGridViewTextBoxColumn"
		Me.InspectionemergencyroadDataGridViewTextBoxColumn.ReadOnly = True
		'
		'DataGridViewTextBoxColumn25
		'
		Me.DataGridViewTextBoxColumn25.DataPropertyName = "occupancy"
		Me.DataGridViewTextBoxColumn25.HeaderText = "occupancy"
		Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
		Me.DataGridViewTextBoxColumn25.ReadOnly = True
		'
		'DataGridViewTextBoxColumn26
		'
		Me.DataGridViewTextBoxColumn26.DataPropertyName = "soundness"
		Me.DataGridViewTextBoxColumn26.HeaderText = "soundness"
		Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
		Me.DataGridViewTextBoxColumn26.ReadOnly = True
		'
		'InspectionuppermaterialDataGridViewTextBoxColumn
		'
		Me.InspectionuppermaterialDataGridViewTextBoxColumn.DataPropertyName = "inspectionuppermaterial"
		Me.InspectionuppermaterialDataGridViewTextBoxColumn.HeaderText = "inspectionuppermaterial"
		Me.InspectionuppermaterialDataGridViewTextBoxColumn.Name = "InspectionuppermaterialDataGridViewTextBoxColumn"
		Me.InspectionuppermaterialDataGridViewTextBoxColumn.ReadOnly = True
		'
		'DataGridViewTextBoxColumn27
		'
		Me.DataGridViewTextBoxColumn27.DataPropertyName = "undermaterial"
		Me.DataGridViewTextBoxColumn27.HeaderText = "undermaterial"
		Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
		Me.DataGridViewTextBoxColumn27.ReadOnly = True
		'
		'DataGridViewTextBoxColumn28
		'
		Me.DataGridViewTextBoxColumn28.DataPropertyName = "bearing"
		Me.DataGridViewTextBoxColumn28.HeaderText = "bearing"
		Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
		Me.DataGridViewTextBoxColumn28.ReadOnly = True
		'
		'DataGridViewTextBoxColumn29
		'
		Me.DataGridViewTextBoxColumn29.DataPropertyName = "face"
		Me.DataGridViewTextBoxColumn29.HeaderText = "face"
		Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
		Me.DataGridViewTextBoxColumn29.ReadOnly = True
		'
		'DataGridViewTextBoxColumn30
		'
		Me.DataGridViewTextBoxColumn30.DataPropertyName = "datasavedir"
		Me.DataGridViewTextBoxColumn30.HeaderText = "datasavedir"
		Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
		Me.DataGridViewTextBoxColumn30.ReadOnly = True
		'
		'BridgeManagementViewForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1460, 606)
		Me.Controls.Add(Me.bridgeHistoryButton)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.inspectionHistoryButton)
		Me.Name = "BridgeManagementViewForm"
		Me.Text = "BridgeManagementViewForm"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BridgemanagementviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents bridgeHistoryButton As Button
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
	Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
	Friend WithEvents BridgeageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
	Friend WithEvents InspectionunderconditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
	Friend WithEvents InspectionemergencyroadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
	Friend WithEvents InspectionuppermaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
	Friend WithEvents BridgemanagementviewBindingSource As BindingSource
End Class

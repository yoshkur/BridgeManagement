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
		Me.bridgeHistoryButton = New System.Windows.Forms.Button()
		Me.bridgeNoteButton = New System.Windows.Forms.Button()
		Me.editBridgeButton = New System.Windows.Forms.Button()
		Me.editBridgeNoteButton = New System.Windows.Forms.Button()
		Me.openDirectoryButton = New System.Windows.Forms.Button()
		Me.searchButton = New System.Windows.Forms.Button()
		Me.inspectionYearComboBox = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.exportButton = New System.Windows.Forms.Button()
		Me.archiveButton = New System.Windows.Forms.Button()
		Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgenamerubyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RouteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.LatitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.LongitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgeageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgelengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgewidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SpanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgestructureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.UppermaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.LowermaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.UnderconditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.EmergencyroadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RepairDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NextinspectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.InspectionwayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MemoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.InspectionyearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.InspectionerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.InspectionunderconditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AlternatepathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.GeneralroadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.InspectionemergencyroadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.OccupancyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SoundnessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.InspectionuppermaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.UndermaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BearingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DatasavedirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BridgemanagementviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BridgemanagementviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'inspectionHistoryButton
		'
		Me.inspectionHistoryButton.Location = New System.Drawing.Point(106, 13)
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
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.bridgename, Me.bridgenameruby, Me.route, Me.address, Me.latitude, Me.longitude, Me.made, Me.bridgeage, Me.bridgelength, Me.bridgewidth, Me.span, Me.bridgestructure, Me.uppermaterial, Me.lowermaterial, Me.undercondition, Me.emergencyroad, Me.repair, Me.nextinspection, Me.inspectionway, Me.memo, Me.inspectionyear, Me.inspectioner, Me.inspectionundercondition, Me.alternatepath, Me.generalroad, Me.inspectionemergencyroad, Me.occupancy, Me.soundness, Me.inspectionuppermaterial, Me.undermaterial, Me.bearing, Me.face, Me.datasavedir, Me.IdDataGridViewTextBoxColumn, Me.BridgenameDataGridViewTextBoxColumn, Me.BridgenamerubyDataGridViewTextBoxColumn, Me.RouteDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.LatitudeDataGridViewTextBoxColumn, Me.LongitudeDataGridViewTextBoxColumn, Me.MadeDataGridViewTextBoxColumn, Me.BridgeageDataGridViewTextBoxColumn, Me.BridgelengthDataGridViewTextBoxColumn, Me.BridgewidthDataGridViewTextBoxColumn, Me.SpanDataGridViewTextBoxColumn, Me.BridgestructureDataGridViewTextBoxColumn, Me.UppermaterialDataGridViewTextBoxColumn, Me.LowermaterialDataGridViewTextBoxColumn, Me.UnderconditionDataGridViewTextBoxColumn, Me.EmergencyroadDataGridViewTextBoxColumn, Me.RepairDataGridViewTextBoxColumn, Me.NextinspectionDataGridViewTextBoxColumn, Me.InspectionwayDataGridViewTextBoxColumn, Me.MemoDataGridViewTextBoxColumn, Me.InspectionyearDataGridViewTextBoxColumn, Me.InspectionerDataGridViewTextBoxColumn, Me.InspectionunderconditionDataGridViewTextBoxColumn, Me.AlternatepathDataGridViewTextBoxColumn, Me.GeneralroadDataGridViewTextBoxColumn, Me.InspectionemergencyroadDataGridViewTextBoxColumn, Me.OccupancyDataGridViewTextBoxColumn, Me.SoundnessDataGridViewTextBoxColumn, Me.InspectionuppermaterialDataGridViewTextBoxColumn, Me.UndermaterialDataGridViewTextBoxColumn, Me.BearingDataGridViewTextBoxColumn, Me.FaceDataGridViewTextBoxColumn, Me.DatasavedirDataGridViewTextBoxColumn})
		Me.DataGridView1.DataSource = Me.BridgemanagementviewBindingSource
		Me.DataGridView1.Location = New System.Drawing.Point(12, 53)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowTemplate.Height = 21
		Me.DataGridView1.Size = New System.Drawing.Size(1436, 541)
		Me.DataGridView1.TabIndex = 2
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
		'bridgeHistoryButton
		'
		Me.bridgeHistoryButton.Location = New System.Drawing.Point(856, 12)
		Me.bridgeHistoryButton.Name = "bridgeHistoryButton"
		Me.bridgeHistoryButton.Size = New System.Drawing.Size(75, 23)
		Me.bridgeHistoryButton.TabIndex = 3
		Me.bridgeHistoryButton.Text = "橋梁履歴"
		Me.bridgeHistoryButton.UseVisualStyleBackColor = True
		'
		'bridgeNoteButton
		'
		Me.bridgeNoteButton.Location = New System.Drawing.Point(555, 13)
		Me.bridgeNoteButton.Name = "bridgeNoteButton"
		Me.bridgeNoteButton.Size = New System.Drawing.Size(93, 23)
		Me.bridgeNoteButton.TabIndex = 4
		Me.bridgeNoteButton.Text = "橋梁メモ履歴"
		Me.bridgeNoteButton.UseVisualStyleBackColor = True
		'
		'editBridgeButton
		'
		Me.editBridgeButton.Location = New System.Drawing.Point(775, 13)
		Me.editBridgeButton.Name = "editBridgeButton"
		Me.editBridgeButton.Size = New System.Drawing.Size(75, 23)
		Me.editBridgeButton.TabIndex = 5
		Me.editBridgeButton.Text = "橋梁編集"
		Me.editBridgeButton.UseVisualStyleBackColor = True
		'
		'editBridgeNoteButton
		'
		Me.editBridgeNoteButton.Location = New System.Drawing.Point(446, 13)
		Me.editBridgeNoteButton.Name = "editBridgeNoteButton"
		Me.editBridgeNoteButton.Size = New System.Drawing.Size(103, 23)
		Me.editBridgeNoteButton.TabIndex = 6
		Me.editBridgeNoteButton.Text = "橋梁メモ編集"
		Me.editBridgeNoteButton.UseVisualStyleBackColor = True
		'
		'openDirectoryButton
		'
		Me.openDirectoryButton.Location = New System.Drawing.Point(187, 13)
		Me.openDirectoryButton.Name = "openDirectoryButton"
		Me.openDirectoryButton.Size = New System.Drawing.Size(116, 23)
		Me.openDirectoryButton.TabIndex = 7
		Me.openDirectoryButton.Text = "点検データフォルダ"
		Me.openDirectoryButton.UseVisualStyleBackColor = True
		'
		'searchButton
		'
		Me.searchButton.Location = New System.Drawing.Point(1160, 12)
		Me.searchButton.Name = "searchButton"
		Me.searchButton.Size = New System.Drawing.Size(58, 23)
		Me.searchButton.TabIndex = 8
		Me.searchButton.Text = "絞込"
		Me.searchButton.UseVisualStyleBackColor = True
		'
		'inspectionYearComboBox
		'
		Me.inspectionYearComboBox.FormattingEnabled = True
		Me.inspectionYearComboBox.Location = New System.Drawing.Point(1033, 13)
		Me.inspectionYearComboBox.Name = "inspectionYearComboBox"
		Me.inspectionYearComboBox.Size = New System.Drawing.Size(121, 20)
		Me.inspectionYearComboBox.TabIndex = 9
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(974, 17)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(53, 12)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "次回調査"
		'
		'exportButton
		'
		Me.exportButton.Location = New System.Drawing.Point(1224, 12)
		Me.exportButton.Name = "exportButton"
		Me.exportButton.Size = New System.Drawing.Size(105, 23)
		Me.exportButton.TabIndex = 11
		Me.exportButton.Text = "データエクスポート"
		Me.exportButton.UseVisualStyleBackColor = True
		'
		'archiveButton
		'
		Me.archiveButton.Location = New System.Drawing.Point(1335, 13)
		Me.archiveButton.Name = "archiveButton"
		Me.archiveButton.Size = New System.Drawing.Size(102, 23)
		Me.archiveButton.TabIndex = 12
		Me.archiveButton.Text = "点検データまとめ"
		Me.archiveButton.UseVisualStyleBackColor = True
		'
		'IdDataGridViewTextBoxColumn
		'
		Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
		Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
		Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
		Me.IdDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BridgenameDataGridViewTextBoxColumn
		'
		Me.BridgenameDataGridViewTextBoxColumn.DataPropertyName = "bridgename"
		Me.BridgenameDataGridViewTextBoxColumn.HeaderText = "bridgename"
		Me.BridgenameDataGridViewTextBoxColumn.Name = "BridgenameDataGridViewTextBoxColumn"
		Me.BridgenameDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BridgenamerubyDataGridViewTextBoxColumn
		'
		Me.BridgenamerubyDataGridViewTextBoxColumn.DataPropertyName = "bridgenameruby"
		Me.BridgenamerubyDataGridViewTextBoxColumn.HeaderText = "bridgenameruby"
		Me.BridgenamerubyDataGridViewTextBoxColumn.Name = "BridgenamerubyDataGridViewTextBoxColumn"
		Me.BridgenamerubyDataGridViewTextBoxColumn.ReadOnly = True
		'
		'RouteDataGridViewTextBoxColumn
		'
		Me.RouteDataGridViewTextBoxColumn.DataPropertyName = "route"
		Me.RouteDataGridViewTextBoxColumn.HeaderText = "route"
		Me.RouteDataGridViewTextBoxColumn.Name = "RouteDataGridViewTextBoxColumn"
		Me.RouteDataGridViewTextBoxColumn.ReadOnly = True
		'
		'AddressDataGridViewTextBoxColumn
		'
		Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
		Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
		Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
		Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
		'
		'LatitudeDataGridViewTextBoxColumn
		'
		Me.LatitudeDataGridViewTextBoxColumn.DataPropertyName = "latitude"
		Me.LatitudeDataGridViewTextBoxColumn.HeaderText = "latitude"
		Me.LatitudeDataGridViewTextBoxColumn.Name = "LatitudeDataGridViewTextBoxColumn"
		Me.LatitudeDataGridViewTextBoxColumn.ReadOnly = True
		'
		'LongitudeDataGridViewTextBoxColumn
		'
		Me.LongitudeDataGridViewTextBoxColumn.DataPropertyName = "longitude"
		Me.LongitudeDataGridViewTextBoxColumn.HeaderText = "longitude"
		Me.LongitudeDataGridViewTextBoxColumn.Name = "LongitudeDataGridViewTextBoxColumn"
		Me.LongitudeDataGridViewTextBoxColumn.ReadOnly = True
		'
		'MadeDataGridViewTextBoxColumn
		'
		Me.MadeDataGridViewTextBoxColumn.DataPropertyName = "made"
		Me.MadeDataGridViewTextBoxColumn.HeaderText = "made"
		Me.MadeDataGridViewTextBoxColumn.Name = "MadeDataGridViewTextBoxColumn"
		Me.MadeDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BridgeageDataGridViewTextBoxColumn
		'
		Me.BridgeageDataGridViewTextBoxColumn.DataPropertyName = "bridgeage"
		Me.BridgeageDataGridViewTextBoxColumn.HeaderText = "bridgeage"
		Me.BridgeageDataGridViewTextBoxColumn.Name = "BridgeageDataGridViewTextBoxColumn"
		Me.BridgeageDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BridgelengthDataGridViewTextBoxColumn
		'
		Me.BridgelengthDataGridViewTextBoxColumn.DataPropertyName = "bridgelength"
		Me.BridgelengthDataGridViewTextBoxColumn.HeaderText = "bridgelength"
		Me.BridgelengthDataGridViewTextBoxColumn.Name = "BridgelengthDataGridViewTextBoxColumn"
		Me.BridgelengthDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BridgewidthDataGridViewTextBoxColumn
		'
		Me.BridgewidthDataGridViewTextBoxColumn.DataPropertyName = "bridgewidth"
		Me.BridgewidthDataGridViewTextBoxColumn.HeaderText = "bridgewidth"
		Me.BridgewidthDataGridViewTextBoxColumn.Name = "BridgewidthDataGridViewTextBoxColumn"
		Me.BridgewidthDataGridViewTextBoxColumn.ReadOnly = True
		'
		'SpanDataGridViewTextBoxColumn
		'
		Me.SpanDataGridViewTextBoxColumn.DataPropertyName = "span"
		Me.SpanDataGridViewTextBoxColumn.HeaderText = "span"
		Me.SpanDataGridViewTextBoxColumn.Name = "SpanDataGridViewTextBoxColumn"
		Me.SpanDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BridgestructureDataGridViewTextBoxColumn
		'
		Me.BridgestructureDataGridViewTextBoxColumn.DataPropertyName = "bridgestructure"
		Me.BridgestructureDataGridViewTextBoxColumn.HeaderText = "bridgestructure"
		Me.BridgestructureDataGridViewTextBoxColumn.Name = "BridgestructureDataGridViewTextBoxColumn"
		Me.BridgestructureDataGridViewTextBoxColumn.ReadOnly = True
		'
		'UppermaterialDataGridViewTextBoxColumn
		'
		Me.UppermaterialDataGridViewTextBoxColumn.DataPropertyName = "uppermaterial"
		Me.UppermaterialDataGridViewTextBoxColumn.HeaderText = "uppermaterial"
		Me.UppermaterialDataGridViewTextBoxColumn.Name = "UppermaterialDataGridViewTextBoxColumn"
		Me.UppermaterialDataGridViewTextBoxColumn.ReadOnly = True
		'
		'LowermaterialDataGridViewTextBoxColumn
		'
		Me.LowermaterialDataGridViewTextBoxColumn.DataPropertyName = "lowermaterial"
		Me.LowermaterialDataGridViewTextBoxColumn.HeaderText = "lowermaterial"
		Me.LowermaterialDataGridViewTextBoxColumn.Name = "LowermaterialDataGridViewTextBoxColumn"
		Me.LowermaterialDataGridViewTextBoxColumn.ReadOnly = True
		'
		'UnderconditionDataGridViewTextBoxColumn
		'
		Me.UnderconditionDataGridViewTextBoxColumn.DataPropertyName = "undercondition"
		Me.UnderconditionDataGridViewTextBoxColumn.HeaderText = "undercondition"
		Me.UnderconditionDataGridViewTextBoxColumn.Name = "UnderconditionDataGridViewTextBoxColumn"
		Me.UnderconditionDataGridViewTextBoxColumn.ReadOnly = True
		'
		'EmergencyroadDataGridViewTextBoxColumn
		'
		Me.EmergencyroadDataGridViewTextBoxColumn.DataPropertyName = "emergencyroad"
		Me.EmergencyroadDataGridViewTextBoxColumn.HeaderText = "emergencyroad"
		Me.EmergencyroadDataGridViewTextBoxColumn.Name = "EmergencyroadDataGridViewTextBoxColumn"
		Me.EmergencyroadDataGridViewTextBoxColumn.ReadOnly = True
		'
		'RepairDataGridViewTextBoxColumn
		'
		Me.RepairDataGridViewTextBoxColumn.DataPropertyName = "repair"
		Me.RepairDataGridViewTextBoxColumn.HeaderText = "repair"
		Me.RepairDataGridViewTextBoxColumn.Name = "RepairDataGridViewTextBoxColumn"
		Me.RepairDataGridViewTextBoxColumn.ReadOnly = True
		'
		'NextinspectionDataGridViewTextBoxColumn
		'
		Me.NextinspectionDataGridViewTextBoxColumn.DataPropertyName = "nextinspection"
		Me.NextinspectionDataGridViewTextBoxColumn.HeaderText = "nextinspection"
		Me.NextinspectionDataGridViewTextBoxColumn.Name = "NextinspectionDataGridViewTextBoxColumn"
		Me.NextinspectionDataGridViewTextBoxColumn.ReadOnly = True
		'
		'InspectionwayDataGridViewTextBoxColumn
		'
		Me.InspectionwayDataGridViewTextBoxColumn.DataPropertyName = "inspectionway"
		Me.InspectionwayDataGridViewTextBoxColumn.HeaderText = "inspectionway"
		Me.InspectionwayDataGridViewTextBoxColumn.Name = "InspectionwayDataGridViewTextBoxColumn"
		Me.InspectionwayDataGridViewTextBoxColumn.ReadOnly = True
		'
		'MemoDataGridViewTextBoxColumn
		'
		Me.MemoDataGridViewTextBoxColumn.DataPropertyName = "memo"
		Me.MemoDataGridViewTextBoxColumn.HeaderText = "memo"
		Me.MemoDataGridViewTextBoxColumn.Name = "MemoDataGridViewTextBoxColumn"
		Me.MemoDataGridViewTextBoxColumn.ReadOnly = True
		'
		'InspectionyearDataGridViewTextBoxColumn
		'
		Me.InspectionyearDataGridViewTextBoxColumn.DataPropertyName = "inspectionyear"
		Me.InspectionyearDataGridViewTextBoxColumn.HeaderText = "inspectionyear"
		Me.InspectionyearDataGridViewTextBoxColumn.Name = "InspectionyearDataGridViewTextBoxColumn"
		Me.InspectionyearDataGridViewTextBoxColumn.ReadOnly = True
		'
		'InspectionerDataGridViewTextBoxColumn
		'
		Me.InspectionerDataGridViewTextBoxColumn.DataPropertyName = "inspectioner"
		Me.InspectionerDataGridViewTextBoxColumn.HeaderText = "inspectioner"
		Me.InspectionerDataGridViewTextBoxColumn.Name = "InspectionerDataGridViewTextBoxColumn"
		Me.InspectionerDataGridViewTextBoxColumn.ReadOnly = True
		'
		'InspectionunderconditionDataGridViewTextBoxColumn
		'
		Me.InspectionunderconditionDataGridViewTextBoxColumn.DataPropertyName = "inspectionundercondition"
		Me.InspectionunderconditionDataGridViewTextBoxColumn.HeaderText = "inspectionundercondition"
		Me.InspectionunderconditionDataGridViewTextBoxColumn.Name = "InspectionunderconditionDataGridViewTextBoxColumn"
		Me.InspectionunderconditionDataGridViewTextBoxColumn.ReadOnly = True
		'
		'AlternatepathDataGridViewTextBoxColumn
		'
		Me.AlternatepathDataGridViewTextBoxColumn.DataPropertyName = "alternatepath"
		Me.AlternatepathDataGridViewTextBoxColumn.HeaderText = "alternatepath"
		Me.AlternatepathDataGridViewTextBoxColumn.Name = "AlternatepathDataGridViewTextBoxColumn"
		Me.AlternatepathDataGridViewTextBoxColumn.ReadOnly = True
		'
		'GeneralroadDataGridViewTextBoxColumn
		'
		Me.GeneralroadDataGridViewTextBoxColumn.DataPropertyName = "generalroad"
		Me.GeneralroadDataGridViewTextBoxColumn.HeaderText = "generalroad"
		Me.GeneralroadDataGridViewTextBoxColumn.Name = "GeneralroadDataGridViewTextBoxColumn"
		Me.GeneralroadDataGridViewTextBoxColumn.ReadOnly = True
		'
		'InspectionemergencyroadDataGridViewTextBoxColumn
		'
		Me.InspectionemergencyroadDataGridViewTextBoxColumn.DataPropertyName = "inspectionemergencyroad"
		Me.InspectionemergencyroadDataGridViewTextBoxColumn.HeaderText = "inspectionemergencyroad"
		Me.InspectionemergencyroadDataGridViewTextBoxColumn.Name = "InspectionemergencyroadDataGridViewTextBoxColumn"
		Me.InspectionemergencyroadDataGridViewTextBoxColumn.ReadOnly = True
		'
		'OccupancyDataGridViewTextBoxColumn
		'
		Me.OccupancyDataGridViewTextBoxColumn.DataPropertyName = "occupancy"
		Me.OccupancyDataGridViewTextBoxColumn.HeaderText = "occupancy"
		Me.OccupancyDataGridViewTextBoxColumn.Name = "OccupancyDataGridViewTextBoxColumn"
		Me.OccupancyDataGridViewTextBoxColumn.ReadOnly = True
		'
		'SoundnessDataGridViewTextBoxColumn
		'
		Me.SoundnessDataGridViewTextBoxColumn.DataPropertyName = "soundness"
		Me.SoundnessDataGridViewTextBoxColumn.HeaderText = "soundness"
		Me.SoundnessDataGridViewTextBoxColumn.Name = "SoundnessDataGridViewTextBoxColumn"
		Me.SoundnessDataGridViewTextBoxColumn.ReadOnly = True
		'
		'InspectionuppermaterialDataGridViewTextBoxColumn
		'
		Me.InspectionuppermaterialDataGridViewTextBoxColumn.DataPropertyName = "inspectionuppermaterial"
		Me.InspectionuppermaterialDataGridViewTextBoxColumn.HeaderText = "inspectionuppermaterial"
		Me.InspectionuppermaterialDataGridViewTextBoxColumn.Name = "InspectionuppermaterialDataGridViewTextBoxColumn"
		Me.InspectionuppermaterialDataGridViewTextBoxColumn.ReadOnly = True
		'
		'UndermaterialDataGridViewTextBoxColumn
		'
		Me.UndermaterialDataGridViewTextBoxColumn.DataPropertyName = "undermaterial"
		Me.UndermaterialDataGridViewTextBoxColumn.HeaderText = "undermaterial"
		Me.UndermaterialDataGridViewTextBoxColumn.Name = "UndermaterialDataGridViewTextBoxColumn"
		Me.UndermaterialDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BearingDataGridViewTextBoxColumn
		'
		Me.BearingDataGridViewTextBoxColumn.DataPropertyName = "bearing"
		Me.BearingDataGridViewTextBoxColumn.HeaderText = "bearing"
		Me.BearingDataGridViewTextBoxColumn.Name = "BearingDataGridViewTextBoxColumn"
		Me.BearingDataGridViewTextBoxColumn.ReadOnly = True
		'
		'FaceDataGridViewTextBoxColumn
		'
		Me.FaceDataGridViewTextBoxColumn.DataPropertyName = "face"
		Me.FaceDataGridViewTextBoxColumn.HeaderText = "face"
		Me.FaceDataGridViewTextBoxColumn.Name = "FaceDataGridViewTextBoxColumn"
		Me.FaceDataGridViewTextBoxColumn.ReadOnly = True
		'
		'DatasavedirDataGridViewTextBoxColumn
		'
		Me.DatasavedirDataGridViewTextBoxColumn.DataPropertyName = "datasavedir"
		Me.DatasavedirDataGridViewTextBoxColumn.HeaderText = "datasavedir"
		Me.DatasavedirDataGridViewTextBoxColumn.Name = "DatasavedirDataGridViewTextBoxColumn"
		Me.DatasavedirDataGridViewTextBoxColumn.ReadOnly = True
		'
		'BridgemanagementviewBindingSource
		'
		Me.BridgemanagementviewBindingSource.DataSource = GetType(BridgeManagement.bridgemanagementview)
		'
		'BridgeManagementViewForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1460, 606)
		Me.Controls.Add(Me.archiveButton)
		Me.Controls.Add(Me.exportButton)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.inspectionYearComboBox)
		Me.Controls.Add(Me.searchButton)
		Me.Controls.Add(Me.openDirectoryButton)
		Me.Controls.Add(Me.editBridgeNoteButton)
		Me.Controls.Add(Me.editBridgeButton)
		Me.Controls.Add(Me.bridgeNoteButton)
		Me.Controls.Add(Me.bridgeHistoryButton)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.inspectionHistoryButton)
		Me.Name = "BridgeManagementViewForm"
		Me.Text = "橋梁管理台帳"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BridgemanagementviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents inspectionHistoryButton As Button
	Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents Expr2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents Expr3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents bridgeHistoryButton As Button
	Friend WithEvents BridgemanagementviewBindingSource As BindingSource
	Friend WithEvents bridgeNoteButton As Button
	Friend WithEvents editBridgeButton As Button
	Friend WithEvents editBridgeNoteButton As Button
	Friend WithEvents openDirectoryButton As Button
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
	Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents BridgenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents BridgenamerubyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents RouteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents LatitudeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents LongitudeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents BridgeageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
	Friend WithEvents InspectionunderconditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AlternatepathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents GeneralroadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents InspectionemergencyroadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents OccupancyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SoundnessDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents InspectionuppermaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents UndermaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents BearingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents FaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DatasavedirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents searchButton As Button
	Friend WithEvents inspectionYearComboBox As ComboBox
	Friend WithEvents Label1 As Label
	Friend WithEvents exportButton As Button
	Friend WithEvents archiveButton As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BridgeManagementViewForm
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
        Me.components = New System.ComponentModel.Container()
        Me.inspectionHistoryButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.searchCancelButton = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.inspectionuppermaterialmain = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uppermaterialside = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uppermaterialfloor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.undermaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bearing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.face = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datasavedir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
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
        Me.UndermaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BearingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatasavedirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BridgemanagementviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BridgemanagementviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inspectionHistoryButton
        '
        Me.inspectionHistoryButton.Location = New System.Drawing.Point(12, 8)
        Me.inspectionHistoryButton.Name = "inspectionHistoryButton"
        Me.inspectionHistoryButton.Size = New System.Drawing.Size(66, 23)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.bridgename, Me.bridgenameruby, Me.route, Me.address, Me.latitude, Me.longitude, Me.made, Me.bridgeage, Me.bridgelength, Me.bridgewidth, Me.span, Me.bridgestructure, Me.uppermaterial, Me.lowermaterial, Me.undercondition, Me.emergencyroad, Me.repair, Me.nextinspection, Me.inspectionway, Me.memo, Me.inspectionyear, Me.inspectioner, Me.inspectionundercondition, Me.alternatepath, Me.generalroad, Me.inspectionemergencyroad, Me.occupancy, Me.soundness, Me.inspectionuppermaterialmain, Me.uppermaterialside, Me.uppermaterialfloor, Me.undermaterial, Me.bearing, Me.face, Me.datasavedir, Me.IdDataGridViewTextBoxColumn, Me.BridgenameDataGridViewTextBoxColumn, Me.BridgenamerubyDataGridViewTextBoxColumn, Me.RouteDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.LatitudeDataGridViewTextBoxColumn, Me.LongitudeDataGridViewTextBoxColumn, Me.MadeDataGridViewTextBoxColumn, Me.BridgeageDataGridViewTextBoxColumn, Me.BridgelengthDataGridViewTextBoxColumn, Me.BridgewidthDataGridViewTextBoxColumn, Me.SpanDataGridViewTextBoxColumn, Me.BridgestructureDataGridViewTextBoxColumn, Me.UppermaterialDataGridViewTextBoxColumn, Me.LowermaterialDataGridViewTextBoxColumn, Me.UnderconditionDataGridViewTextBoxColumn, Me.EmergencyroadDataGridViewTextBoxColumn, Me.RepairDataGridViewTextBoxColumn, Me.NextinspectionDataGridViewTextBoxColumn, Me.InspectionwayDataGridViewTextBoxColumn, Me.MemoDataGridViewTextBoxColumn, Me.InspectionyearDataGridViewTextBoxColumn, Me.InspectionerDataGridViewTextBoxColumn, Me.InspectionunderconditionDataGridViewTextBoxColumn, Me.AlternatepathDataGridViewTextBoxColumn, Me.GeneralroadDataGridViewTextBoxColumn, Me.InspectionemergencyroadDataGridViewTextBoxColumn, Me.OccupancyDataGridViewTextBoxColumn, Me.SoundnessDataGridViewTextBoxColumn, Me.UndermaterialDataGridViewTextBoxColumn, Me.BearingDataGridViewTextBoxColumn, Me.FaceDataGridViewTextBoxColumn, Me.DatasavedirDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BridgemanagementviewBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(1290, 634)
        Me.DataGridView1.TabIndex = 2
        '
        'bridgeHistoryButton
        '
        Me.bridgeHistoryButton.Location = New System.Drawing.Point(448, 8)
        Me.bridgeHistoryButton.Name = "bridgeHistoryButton"
        Me.bridgeHistoryButton.Size = New System.Drawing.Size(75, 23)
        Me.bridgeHistoryButton.TabIndex = 3
        Me.bridgeHistoryButton.Text = "橋梁履歴"
        Me.bridgeHistoryButton.UseVisualStyleBackColor = True
        '
        'bridgeNoteButton
        '
        Me.bridgeNoteButton.Location = New System.Drawing.Point(280, 8)
        Me.bridgeNoteButton.Name = "bridgeNoteButton"
        Me.bridgeNoteButton.Size = New System.Drawing.Size(81, 23)
        Me.bridgeNoteButton.TabIndex = 4
        Me.bridgeNoteButton.Text = "橋梁メモ履歴"
        Me.bridgeNoteButton.UseVisualStyleBackColor = True
        '
        'editBridgeButton
        '
        Me.editBridgeButton.Location = New System.Drawing.Point(367, 8)
        Me.editBridgeButton.Name = "editBridgeButton"
        Me.editBridgeButton.Size = New System.Drawing.Size(75, 23)
        Me.editBridgeButton.TabIndex = 5
        Me.editBridgeButton.Text = "橋梁編集"
        Me.editBridgeButton.UseVisualStyleBackColor = True
        '
        'editBridgeNoteButton
        '
        Me.editBridgeNoteButton.Location = New System.Drawing.Point(191, 8)
        Me.editBridgeNoteButton.Name = "editBridgeNoteButton"
        Me.editBridgeNoteButton.Size = New System.Drawing.Size(83, 23)
        Me.editBridgeNoteButton.TabIndex = 6
        Me.editBridgeNoteButton.Text = "橋梁メモ編集"
        Me.editBridgeNoteButton.UseVisualStyleBackColor = True
        '
        'openDirectoryButton
        '
        Me.openDirectoryButton.Location = New System.Drawing.Point(84, 8)
        Me.openDirectoryButton.Name = "openDirectoryButton"
        Me.openDirectoryButton.Size = New System.Drawing.Size(101, 23)
        Me.openDirectoryButton.TabIndex = 7
        Me.openDirectoryButton.Text = "点検データフォルダ"
        Me.openDirectoryButton.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(913, 8)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(58, 23)
        Me.searchButton.TabIndex = 8
        Me.searchButton.Text = "絞込"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'inspectionYearComboBox
        '
        Me.inspectionYearComboBox.FormattingEnabled = True
        Me.inspectionYearComboBox.Location = New System.Drawing.Point(786, 8)
        Me.inspectionYearComboBox.Name = "inspectionYearComboBox"
        Me.inspectionYearComboBox.Size = New System.Drawing.Size(121, 20)
        Me.inspectionYearComboBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(727, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "次回調査"
        '
        'exportButton
        '
        Me.exportButton.Location = New System.Drawing.Point(1060, 9)
        Me.exportButton.Name = "exportButton"
        Me.exportButton.Size = New System.Drawing.Size(105, 23)
        Me.exportButton.TabIndex = 11
        Me.exportButton.Text = "データエクスポート"
        Me.exportButton.UseVisualStyleBackColor = True
        '
        'archiveButton
        '
        Me.archiveButton.Location = New System.Drawing.Point(1171, 8)
        Me.archiveButton.Name = "archiveButton"
        Me.archiveButton.Size = New System.Drawing.Size(102, 23)
        Me.archiveButton.TabIndex = 12
        Me.archiveButton.Text = "点検データまとめ"
        Me.archiveButton.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label25)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.searchCancelButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.inspectionHistoryButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.archiveButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.openDirectoryButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.exportButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.editBridgeNoteButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.searchButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.inspectionYearComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bridgeNoteButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.editBridgeButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bridgeHistoryButton)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1290, 676)
        Me.SplitContainer1.SplitterDistance = 38
        Me.SplitContainer1.TabIndex = 13
        '
        'searchCancelButton
        '
        Me.searchCancelButton.Location = New System.Drawing.Point(977, 9)
        Me.searchCancelButton.Name = "searchCancelButton"
        Me.searchCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.searchCancelButton.TabIndex = 13
        Me.searchCancelButton.Text = "絞込解除"
        Me.searchCancelButton.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1477, 676)
        Me.SplitContainer2.SplitterDistance = 183
        Me.SplitContainer2.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 12)
        Me.Label2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 676)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "検索条件設定"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "道路橋名"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 19)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "検　　索"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(7, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(141, 19)
        Me.TextBox2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "路線名"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(7, 102)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(141, 19)
        Me.TextBox3.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "所在地"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(66, 142)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(80, 19)
        Me.TextBox4.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "架設年次"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 12)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "FROM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 12)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "TO"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(66, 167)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(80, 19)
        Me.TextBox5.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 12)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "TO"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(66, 208)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(80, 19)
        Me.TextBox6.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 12)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "FROM"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(66, 233)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(80, 19)
        Me.TextBox7.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "橋令"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 302)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 12)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "TO"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(66, 277)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(80, 19)
        Me.TextBox8.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 12)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "FROM"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(66, 302)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(80, 19)
        Me.TextBox9.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 262)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 12)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "橋長"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(40, 370)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 12)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "TO"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(66, 338)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(80, 19)
        Me.TextBox10.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 345)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 12)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "FROM"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(66, 363)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(80, 19)
        Me.TextBox11.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 327)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 12)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "幅員"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 64)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(177, 609)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.TextBox15)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.TextBox16)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.TextBox17)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.TextBox12)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.TextBox13)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TextBox10)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TextBox11)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.TextBox8)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.TextBox4)
        Me.TabPage1.Controls.Add(Me.TextBox9)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.TextBox5)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TextBox6)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.TextBox7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(169, 583)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "橋梁"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(169, 583)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "メモ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(169, 583)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "点検"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(42, 435)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 12)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "TO"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(66, 407)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(80, 19)
        Me.TextBox12.TabIndex = 30
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(25, 410)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 12)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "FROM"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(66, 432)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(80, 19)
        Me.TextBox13.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 392)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 12)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "径間数"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Controls.Add(Me.TextBox14)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(169, 583)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "並順"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(9, 30)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(147, 534)
        Me.TextBox14.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 12)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "国土交通省番号"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 460)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 12)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "構造形式"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(7, 475)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(141, 19)
        Me.TextBox15.TabIndex = 33
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(9, 496)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(89, 12)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "上部工使用材料"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(7, 511)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(141, 19)
        Me.TextBox16.TabIndex = 35
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 533)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 12)
        Me.Label24.TabIndex = 36
        Me.Label24.Text = "床板材料"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(7, 548)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(141, 19)
        Me.TextBox17.TabIndex = 37
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(658, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "←確定"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.bridgename.FillWeight = 50.0!
        Me.bridgename.HeaderText = "道路橋名"
        Me.bridgename.MinimumWidth = 100
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
        'inspectionuppermaterialmain
        '
        Me.inspectionuppermaterialmain.DataPropertyName = "inspectionuppermaterialmain"
        Me.inspectionuppermaterialmain.HeaderText = "上部工主桁"
        Me.inspectionuppermaterialmain.Name = "inspectionuppermaterialmain"
        Me.inspectionuppermaterialmain.ReadOnly = True
        '
        'uppermaterialside
        '
        Me.uppermaterialside.DataPropertyName = "uppermaterialside"
        Me.uppermaterialside.HeaderText = "上部工横桁"
        Me.uppermaterialside.Name = "uppermaterialside"
        '
        'uppermaterialfloor
        '
        Me.uppermaterialfloor.DataPropertyName = "uppermaterialfloor"
        Me.uppermaterialfloor.HeaderText = "上部工床桁"
        Me.uppermaterialfloor.Name = "uppermaterialfloor"
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
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(594, 10)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(58, 19)
        Me.NumericUpDown1.TabIndex = 29
        Me.NumericUpDown1.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(539, 13)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 12)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "FontSize"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'BridgenameDataGridViewTextBoxColumn
        '
        Me.BridgenameDataGridViewTextBoxColumn.DataPropertyName = "bridgename"
        Me.BridgenameDataGridViewTextBoxColumn.HeaderText = "bridgename"
        Me.BridgenameDataGridViewTextBoxColumn.Name = "BridgenameDataGridViewTextBoxColumn"
        Me.BridgenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.BridgenameDataGridViewTextBoxColumn.Visible = False
        '
        'BridgenamerubyDataGridViewTextBoxColumn
        '
        Me.BridgenamerubyDataGridViewTextBoxColumn.DataPropertyName = "bridgenameruby"
        Me.BridgenamerubyDataGridViewTextBoxColumn.HeaderText = "bridgenameruby"
        Me.BridgenamerubyDataGridViewTextBoxColumn.Name = "BridgenamerubyDataGridViewTextBoxColumn"
        Me.BridgenamerubyDataGridViewTextBoxColumn.ReadOnly = True
        Me.BridgenamerubyDataGridViewTextBoxColumn.Visible = False
        '
        'RouteDataGridViewTextBoxColumn
        '
        Me.RouteDataGridViewTextBoxColumn.DataPropertyName = "route"
        Me.RouteDataGridViewTextBoxColumn.HeaderText = "route"
        Me.RouteDataGridViewTextBoxColumn.Name = "RouteDataGridViewTextBoxColumn"
        Me.RouteDataGridViewTextBoxColumn.ReadOnly = True
        Me.RouteDataGridViewTextBoxColumn.Visible = False
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Visible = False
        '
        'LatitudeDataGridViewTextBoxColumn
        '
        Me.LatitudeDataGridViewTextBoxColumn.DataPropertyName = "latitude"
        Me.LatitudeDataGridViewTextBoxColumn.HeaderText = "latitude"
        Me.LatitudeDataGridViewTextBoxColumn.Name = "LatitudeDataGridViewTextBoxColumn"
        Me.LatitudeDataGridViewTextBoxColumn.ReadOnly = True
        Me.LatitudeDataGridViewTextBoxColumn.Visible = False
        '
        'LongitudeDataGridViewTextBoxColumn
        '
        Me.LongitudeDataGridViewTextBoxColumn.DataPropertyName = "longitude"
        Me.LongitudeDataGridViewTextBoxColumn.HeaderText = "longitude"
        Me.LongitudeDataGridViewTextBoxColumn.Name = "LongitudeDataGridViewTextBoxColumn"
        Me.LongitudeDataGridViewTextBoxColumn.ReadOnly = True
        Me.LongitudeDataGridViewTextBoxColumn.Visible = False
        '
        'MadeDataGridViewTextBoxColumn
        '
        Me.MadeDataGridViewTextBoxColumn.DataPropertyName = "made"
        Me.MadeDataGridViewTextBoxColumn.HeaderText = "made"
        Me.MadeDataGridViewTextBoxColumn.Name = "MadeDataGridViewTextBoxColumn"
        Me.MadeDataGridViewTextBoxColumn.ReadOnly = True
        Me.MadeDataGridViewTextBoxColumn.Visible = False
        '
        'BridgeageDataGridViewTextBoxColumn
        '
        Me.BridgeageDataGridViewTextBoxColumn.DataPropertyName = "bridgeage"
        Me.BridgeageDataGridViewTextBoxColumn.HeaderText = "bridgeage"
        Me.BridgeageDataGridViewTextBoxColumn.Name = "BridgeageDataGridViewTextBoxColumn"
        Me.BridgeageDataGridViewTextBoxColumn.ReadOnly = True
        Me.BridgeageDataGridViewTextBoxColumn.Visible = False
        '
        'BridgelengthDataGridViewTextBoxColumn
        '
        Me.BridgelengthDataGridViewTextBoxColumn.DataPropertyName = "bridgelength"
        Me.BridgelengthDataGridViewTextBoxColumn.HeaderText = "bridgelength"
        Me.BridgelengthDataGridViewTextBoxColumn.Name = "BridgelengthDataGridViewTextBoxColumn"
        Me.BridgelengthDataGridViewTextBoxColumn.ReadOnly = True
        Me.BridgelengthDataGridViewTextBoxColumn.Visible = False
        '
        'BridgewidthDataGridViewTextBoxColumn
        '
        Me.BridgewidthDataGridViewTextBoxColumn.DataPropertyName = "bridgewidth"
        Me.BridgewidthDataGridViewTextBoxColumn.HeaderText = "bridgewidth"
        Me.BridgewidthDataGridViewTextBoxColumn.Name = "BridgewidthDataGridViewTextBoxColumn"
        Me.BridgewidthDataGridViewTextBoxColumn.ReadOnly = True
        Me.BridgewidthDataGridViewTextBoxColumn.Visible = False
        '
        'SpanDataGridViewTextBoxColumn
        '
        Me.SpanDataGridViewTextBoxColumn.DataPropertyName = "span"
        Me.SpanDataGridViewTextBoxColumn.HeaderText = "span"
        Me.SpanDataGridViewTextBoxColumn.Name = "SpanDataGridViewTextBoxColumn"
        Me.SpanDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpanDataGridViewTextBoxColumn.Visible = False
        '
        'BridgestructureDataGridViewTextBoxColumn
        '
        Me.BridgestructureDataGridViewTextBoxColumn.DataPropertyName = "bridgestructure"
        Me.BridgestructureDataGridViewTextBoxColumn.HeaderText = "bridgestructure"
        Me.BridgestructureDataGridViewTextBoxColumn.Name = "BridgestructureDataGridViewTextBoxColumn"
        Me.BridgestructureDataGridViewTextBoxColumn.ReadOnly = True
        Me.BridgestructureDataGridViewTextBoxColumn.Visible = False
        '
        'UppermaterialDataGridViewTextBoxColumn
        '
        Me.UppermaterialDataGridViewTextBoxColumn.DataPropertyName = "uppermaterial"
        Me.UppermaterialDataGridViewTextBoxColumn.HeaderText = "uppermaterial"
        Me.UppermaterialDataGridViewTextBoxColumn.Name = "UppermaterialDataGridViewTextBoxColumn"
        Me.UppermaterialDataGridViewTextBoxColumn.ReadOnly = True
        Me.UppermaterialDataGridViewTextBoxColumn.Visible = False
        '
        'LowermaterialDataGridViewTextBoxColumn
        '
        Me.LowermaterialDataGridViewTextBoxColumn.DataPropertyName = "lowermaterial"
        Me.LowermaterialDataGridViewTextBoxColumn.HeaderText = "lowermaterial"
        Me.LowermaterialDataGridViewTextBoxColumn.Name = "LowermaterialDataGridViewTextBoxColumn"
        Me.LowermaterialDataGridViewTextBoxColumn.ReadOnly = True
        Me.LowermaterialDataGridViewTextBoxColumn.Visible = False
        '
        'UnderconditionDataGridViewTextBoxColumn
        '
        Me.UnderconditionDataGridViewTextBoxColumn.DataPropertyName = "undercondition"
        Me.UnderconditionDataGridViewTextBoxColumn.HeaderText = "undercondition"
        Me.UnderconditionDataGridViewTextBoxColumn.Name = "UnderconditionDataGridViewTextBoxColumn"
        Me.UnderconditionDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnderconditionDataGridViewTextBoxColumn.Visible = False
        '
        'EmergencyroadDataGridViewTextBoxColumn
        '
        Me.EmergencyroadDataGridViewTextBoxColumn.DataPropertyName = "emergencyroad"
        Me.EmergencyroadDataGridViewTextBoxColumn.HeaderText = "emergencyroad"
        Me.EmergencyroadDataGridViewTextBoxColumn.Name = "EmergencyroadDataGridViewTextBoxColumn"
        Me.EmergencyroadDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmergencyroadDataGridViewTextBoxColumn.Visible = False
        '
        'RepairDataGridViewTextBoxColumn
        '
        Me.RepairDataGridViewTextBoxColumn.DataPropertyName = "repair"
        Me.RepairDataGridViewTextBoxColumn.HeaderText = "repair"
        Me.RepairDataGridViewTextBoxColumn.Name = "RepairDataGridViewTextBoxColumn"
        Me.RepairDataGridViewTextBoxColumn.ReadOnly = True
        Me.RepairDataGridViewTextBoxColumn.Visible = False
        '
        'NextinspectionDataGridViewTextBoxColumn
        '
        Me.NextinspectionDataGridViewTextBoxColumn.DataPropertyName = "nextinspection"
        Me.NextinspectionDataGridViewTextBoxColumn.HeaderText = "nextinspection"
        Me.NextinspectionDataGridViewTextBoxColumn.Name = "NextinspectionDataGridViewTextBoxColumn"
        Me.NextinspectionDataGridViewTextBoxColumn.ReadOnly = True
        Me.NextinspectionDataGridViewTextBoxColumn.Visible = False
        '
        'InspectionwayDataGridViewTextBoxColumn
        '
        Me.InspectionwayDataGridViewTextBoxColumn.DataPropertyName = "inspectionway"
        Me.InspectionwayDataGridViewTextBoxColumn.HeaderText = "inspectionway"
        Me.InspectionwayDataGridViewTextBoxColumn.Name = "InspectionwayDataGridViewTextBoxColumn"
        Me.InspectionwayDataGridViewTextBoxColumn.ReadOnly = True
        Me.InspectionwayDataGridViewTextBoxColumn.Visible = False
        '
        'MemoDataGridViewTextBoxColumn
        '
        Me.MemoDataGridViewTextBoxColumn.DataPropertyName = "memo"
        Me.MemoDataGridViewTextBoxColumn.HeaderText = "memo"
        Me.MemoDataGridViewTextBoxColumn.Name = "MemoDataGridViewTextBoxColumn"
        Me.MemoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemoDataGridViewTextBoxColumn.Visible = False
        '
        'InspectionyearDataGridViewTextBoxColumn
        '
        Me.InspectionyearDataGridViewTextBoxColumn.DataPropertyName = "inspectionyear"
        Me.InspectionyearDataGridViewTextBoxColumn.HeaderText = "inspectionyear"
        Me.InspectionyearDataGridViewTextBoxColumn.Name = "InspectionyearDataGridViewTextBoxColumn"
        Me.InspectionyearDataGridViewTextBoxColumn.ReadOnly = True
        Me.InspectionyearDataGridViewTextBoxColumn.Visible = False
        '
        'InspectionerDataGridViewTextBoxColumn
        '
        Me.InspectionerDataGridViewTextBoxColumn.DataPropertyName = "inspectioner"
        Me.InspectionerDataGridViewTextBoxColumn.HeaderText = "inspectioner"
        Me.InspectionerDataGridViewTextBoxColumn.Name = "InspectionerDataGridViewTextBoxColumn"
        Me.InspectionerDataGridViewTextBoxColumn.ReadOnly = True
        Me.InspectionerDataGridViewTextBoxColumn.Visible = False
        '
        'InspectionunderconditionDataGridViewTextBoxColumn
        '
        Me.InspectionunderconditionDataGridViewTextBoxColumn.DataPropertyName = "inspectionundercondition"
        Me.InspectionunderconditionDataGridViewTextBoxColumn.HeaderText = "inspectionundercondition"
        Me.InspectionunderconditionDataGridViewTextBoxColumn.Name = "InspectionunderconditionDataGridViewTextBoxColumn"
        Me.InspectionunderconditionDataGridViewTextBoxColumn.ReadOnly = True
        Me.InspectionunderconditionDataGridViewTextBoxColumn.Visible = False
        '
        'AlternatepathDataGridViewTextBoxColumn
        '
        Me.AlternatepathDataGridViewTextBoxColumn.DataPropertyName = "alternatepath"
        Me.AlternatepathDataGridViewTextBoxColumn.HeaderText = "alternatepath"
        Me.AlternatepathDataGridViewTextBoxColumn.Name = "AlternatepathDataGridViewTextBoxColumn"
        Me.AlternatepathDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlternatepathDataGridViewTextBoxColumn.Visible = False
        '
        'GeneralroadDataGridViewTextBoxColumn
        '
        Me.GeneralroadDataGridViewTextBoxColumn.DataPropertyName = "generalroad"
        Me.GeneralroadDataGridViewTextBoxColumn.HeaderText = "generalroad"
        Me.GeneralroadDataGridViewTextBoxColumn.Name = "GeneralroadDataGridViewTextBoxColumn"
        Me.GeneralroadDataGridViewTextBoxColumn.ReadOnly = True
        Me.GeneralroadDataGridViewTextBoxColumn.Visible = False
        '
        'InspectionemergencyroadDataGridViewTextBoxColumn
        '
        Me.InspectionemergencyroadDataGridViewTextBoxColumn.DataPropertyName = "inspectionemergencyroad"
        Me.InspectionemergencyroadDataGridViewTextBoxColumn.HeaderText = "inspectionemergencyroad"
        Me.InspectionemergencyroadDataGridViewTextBoxColumn.Name = "InspectionemergencyroadDataGridViewTextBoxColumn"
        Me.InspectionemergencyroadDataGridViewTextBoxColumn.ReadOnly = True
        Me.InspectionemergencyroadDataGridViewTextBoxColumn.Visible = False
        '
        'OccupancyDataGridViewTextBoxColumn
        '
        Me.OccupancyDataGridViewTextBoxColumn.DataPropertyName = "occupancy"
        Me.OccupancyDataGridViewTextBoxColumn.HeaderText = "occupancy"
        Me.OccupancyDataGridViewTextBoxColumn.Name = "OccupancyDataGridViewTextBoxColumn"
        Me.OccupancyDataGridViewTextBoxColumn.ReadOnly = True
        Me.OccupancyDataGridViewTextBoxColumn.Visible = False
        '
        'SoundnessDataGridViewTextBoxColumn
        '
        Me.SoundnessDataGridViewTextBoxColumn.DataPropertyName = "soundness"
        Me.SoundnessDataGridViewTextBoxColumn.HeaderText = "soundness"
        Me.SoundnessDataGridViewTextBoxColumn.Name = "SoundnessDataGridViewTextBoxColumn"
        Me.SoundnessDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoundnessDataGridViewTextBoxColumn.Visible = False
        '
        'UndermaterialDataGridViewTextBoxColumn
        '
        Me.UndermaterialDataGridViewTextBoxColumn.DataPropertyName = "undermaterial"
        Me.UndermaterialDataGridViewTextBoxColumn.HeaderText = "undermaterial"
        Me.UndermaterialDataGridViewTextBoxColumn.Name = "UndermaterialDataGridViewTextBoxColumn"
        Me.UndermaterialDataGridViewTextBoxColumn.ReadOnly = True
        Me.UndermaterialDataGridViewTextBoxColumn.Visible = False
        '
        'BearingDataGridViewTextBoxColumn
        '
        Me.BearingDataGridViewTextBoxColumn.DataPropertyName = "bearing"
        Me.BearingDataGridViewTextBoxColumn.HeaderText = "bearing"
        Me.BearingDataGridViewTextBoxColumn.Name = "BearingDataGridViewTextBoxColumn"
        Me.BearingDataGridViewTextBoxColumn.ReadOnly = True
        Me.BearingDataGridViewTextBoxColumn.Visible = False
        '
        'FaceDataGridViewTextBoxColumn
        '
        Me.FaceDataGridViewTextBoxColumn.DataPropertyName = "face"
        Me.FaceDataGridViewTextBoxColumn.HeaderText = "face"
        Me.FaceDataGridViewTextBoxColumn.Name = "FaceDataGridViewTextBoxColumn"
        Me.FaceDataGridViewTextBoxColumn.ReadOnly = True
        Me.FaceDataGridViewTextBoxColumn.Visible = False
        '
        'DatasavedirDataGridViewTextBoxColumn
        '
        Me.DatasavedirDataGridViewTextBoxColumn.DataPropertyName = "datasavedir"
        Me.DatasavedirDataGridViewTextBoxColumn.HeaderText = "datasavedir"
        Me.DatasavedirDataGridViewTextBoxColumn.Name = "DatasavedirDataGridViewTextBoxColumn"
        Me.DatasavedirDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatasavedirDataGridViewTextBoxColumn.Visible = False
        '
        'BridgemanagementviewBindingSource
        '
        Me.BridgemanagementviewBindingSource.DataSource = GetType(BridgeManagement.bridgemanagementview)
        '
        'BridgeManagementViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 676)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "BridgeManagementViewForm"
        Me.Text = "橋梁管理台帳"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BridgemanagementviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents searchButton As Button
    Friend WithEvents inspectionYearComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents exportButton As Button
    Friend WithEvents archiveButton As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents InspectionuppermaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents searchCancelButton As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents Button2 As Button
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
    Friend WithEvents inspectionuppermaterialmain As DataGridViewTextBoxColumn
    Friend WithEvents uppermaterialside As DataGridViewTextBoxColumn
    Friend WithEvents uppermaterialfloor As DataGridViewTextBoxColumn
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
    Friend WithEvents UndermaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BearingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatasavedirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label25 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class

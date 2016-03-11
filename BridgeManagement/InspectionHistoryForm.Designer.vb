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
        Me.InspectionhistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.openDirectoryButton = New System.Windows.Forms.Button()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecorddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordprogramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecorduseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordvalidDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InspectionyearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InspectionerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnderconditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlternatepathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralroadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmergencyroadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OccupancyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoundnessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UppermaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UndermaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BearingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatasavedirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InspectionhistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.recorddate, Me.inspectionyear, Me.inspectioner, Me.undercondition, Me.alternatepath, Me.generalroad, Me.emergencyroad, Me.occupancy, Me.soundness, Me.uppermaterial, Me.undermaterial, Me.bearing, Me.face, Me.datasavedir, Me.IdDataGridViewTextBoxColumn, Me.RecorddateDataGridViewTextBoxColumn, Me.RecordprogramDataGridViewTextBoxColumn, Me.RecorduseridDataGridViewTextBoxColumn, Me.RecordvalidDataGridViewCheckBoxColumn, Me.InspectionyearDataGridViewTextBoxColumn, Me.InspectionerDataGridViewTextBoxColumn, Me.UnderconditionDataGridViewTextBoxColumn, Me.AlternatepathDataGridViewTextBoxColumn, Me.GeneralroadDataGridViewTextBoxColumn, Me.EmergencyroadDataGridViewTextBoxColumn, Me.OccupancyDataGridViewTextBoxColumn, Me.SoundnessDataGridViewTextBoxColumn, Me.UppermaterialDataGridViewTextBoxColumn, Me.UndermaterialDataGridViewTextBoxColumn, Me.BearingDataGridViewTextBoxColumn, Me.FaceDataGridViewTextBoxColumn, Me.DatasavedirDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InspectionhistoryBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(962, 517)
        Me.DataGridView1.TabIndex = 0
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
        Me.recorddate.HeaderText = "データ保存日時"
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
        'InspectionhistoryBindingSource
        '
        Me.InspectionhistoryBindingSource.DataSource = GetType(BridgeManagement.inspectionhistory)
        '
        'openDirectoryButton
        '
        Me.openDirectoryButton.Location = New System.Drawing.Point(12, 6)
        Me.openDirectoryButton.Name = "openDirectoryButton"
        Me.openDirectoryButton.Size = New System.Drawing.Size(116, 23)
        Me.openDirectoryButton.TabIndex = 1
        Me.openDirectoryButton.Text = "点検データフォルダ"
        Me.openDirectoryButton.UseVisualStyleBackColor = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecorddateDataGridViewTextBoxColumn
        '
        Me.RecorddateDataGridViewTextBoxColumn.DataPropertyName = "recorddate"
        Me.RecorddateDataGridViewTextBoxColumn.HeaderText = "recorddate"
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
        'UnderconditionDataGridViewTextBoxColumn
        '
        Me.UnderconditionDataGridViewTextBoxColumn.DataPropertyName = "undercondition"
        Me.UnderconditionDataGridViewTextBoxColumn.HeaderText = "undercondition"
        Me.UnderconditionDataGridViewTextBoxColumn.Name = "UnderconditionDataGridViewTextBoxColumn"
        Me.UnderconditionDataGridViewTextBoxColumn.ReadOnly = True
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
        'EmergencyroadDataGridViewTextBoxColumn
        '
        Me.EmergencyroadDataGridViewTextBoxColumn.DataPropertyName = "emergencyroad"
        Me.EmergencyroadDataGridViewTextBoxColumn.HeaderText = "emergencyroad"
        Me.EmergencyroadDataGridViewTextBoxColumn.Name = "EmergencyroadDataGridViewTextBoxColumn"
        Me.EmergencyroadDataGridViewTextBoxColumn.ReadOnly = True
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
        'UppermaterialDataGridViewTextBoxColumn
        '
        Me.UppermaterialDataGridViewTextBoxColumn.DataPropertyName = "uppermaterial"
        Me.UppermaterialDataGridViewTextBoxColumn.HeaderText = "uppermaterial"
        Me.UppermaterialDataGridViewTextBoxColumn.Name = "UppermaterialDataGridViewTextBoxColumn"
        Me.UppermaterialDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.openDirectoryButton)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(962, 556)
        Me.SplitContainer1.SplitterDistance = 35
        Me.SplitContainer1.TabIndex = 2
        '
        'InspectionHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 556)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "InspectionHistoryForm"
        Me.Text = "点検履歴"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InspectionhistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents InspectionhistoryBindingSource As BindingSource
	Friend WithEvents openDirectoryButton As Button
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
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecorddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecordprogramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecorduseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecordvalidDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents InspectionyearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InspectionerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnderconditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlternatepathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeneralroadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmergencyroadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OccupancyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoundnessDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UppermaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UndermaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BearingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatasavedirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As SplitContainer
End Class

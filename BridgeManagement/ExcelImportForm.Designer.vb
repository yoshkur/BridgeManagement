<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExcelImportForm
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
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.InspectionexcelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErrorDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatadirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InspectionyearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InspectionerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnderconditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlternatepathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralroadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmergencyroadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OccupancyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoundnessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uppermaterialmain = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uppermaterialside = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uppermaterialfloor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UndermaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BearingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.InspectionexcelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ErrorDataGridViewCheckBoxColumn, Me.MessageDataGridViewTextBoxColumn, Me.IdentDataGridViewTextBoxColumn, Me.DatadirDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.InspectionyearDataGridViewTextBoxColumn, Me.InspectionerDataGridViewTextBoxColumn, Me.UnderconditionDataGridViewTextBoxColumn, Me.AlternatepathDataGridViewTextBoxColumn, Me.GeneralroadDataGridViewTextBoxColumn, Me.EmergencyroadDataGridViewTextBoxColumn, Me.OccupancyDataGridViewTextBoxColumn, Me.SoundnessDataGridViewTextBoxColumn, Me.uppermaterialmain, Me.uppermaterialside, Me.uppermaterialfloor, Me.UndermaterialDataGridViewTextBoxColumn, Me.BearingDataGridViewTextBoxColumn, Me.FaceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InspectionexcelBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(1096, 392)
        Me.DataGridView1.TabIndex = 0
        '
        'ImportButton
        '
        Me.ImportButton.Location = New System.Drawing.Point(12, 12)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(125, 23)
        Me.ImportButton.TabIndex = 1
        Me.ImportButton.Text = "データ取り込み"
        Me.ImportButton.UseVisualStyleBackColor = True
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ImportButton)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1096, 442)
        Me.SplitContainer1.SplitterDistance = 46
        Me.SplitContainer1.TabIndex = 2
        '
        'InspectionexcelBindingSource
        '
        Me.InspectionexcelBindingSource.DataSource = GetType(BridgeManagement.inspectionexcel)
        '
        'ErrorDataGridViewCheckBoxColumn
        '
        Me.ErrorDataGridViewCheckBoxColumn.DataPropertyName = "error"
        Me.ErrorDataGridViewCheckBoxColumn.HeaderText = "エラー有無"
        Me.ErrorDataGridViewCheckBoxColumn.Name = "ErrorDataGridViewCheckBoxColumn"
        Me.ErrorDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'MessageDataGridViewTextBoxColumn
        '
        Me.MessageDataGridViewTextBoxColumn.DataPropertyName = "message"
        Me.MessageDataGridViewTextBoxColumn.HeaderText = "メッセージ"
        Me.MessageDataGridViewTextBoxColumn.Name = "MessageDataGridViewTextBoxColumn"
        Me.MessageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdentDataGridViewTextBoxColumn
        '
        Me.IdentDataGridViewTextBoxColumn.DataPropertyName = "ident"
        Me.IdentDataGridViewTextBoxColumn.HeaderText = "ident"
        Me.IdentDataGridViewTextBoxColumn.Name = "IdentDataGridViewTextBoxColumn"
        Me.IdentDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdentDataGridViewTextBoxColumn.Visible = False
        '
        'DatadirDataGridViewTextBoxColumn
        '
        Me.DatadirDataGridViewTextBoxColumn.DataPropertyName = "datadir"
        Me.DatadirDataGridViewTextBoxColumn.HeaderText = "データディレクトリ"
        Me.DatadirDataGridViewTextBoxColumn.Name = "DatadirDataGridViewTextBoxColumn"
        Me.DatadirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "国交省作業番号"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InspectionyearDataGridViewTextBoxColumn
        '
        Me.InspectionyearDataGridViewTextBoxColumn.DataPropertyName = "inspectionyear"
        Me.InspectionyearDataGridViewTextBoxColumn.HeaderText = "最新点検年度"
        Me.InspectionyearDataGridViewTextBoxColumn.Name = "InspectionyearDataGridViewTextBoxColumn"
        Me.InspectionyearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InspectionerDataGridViewTextBoxColumn
        '
        Me.InspectionerDataGridViewTextBoxColumn.DataPropertyName = "inspectioner"
        Me.InspectionerDataGridViewTextBoxColumn.HeaderText = "点検者"
        Me.InspectionerDataGridViewTextBoxColumn.Name = "InspectionerDataGridViewTextBoxColumn"
        Me.InspectionerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnderconditionDataGridViewTextBoxColumn
        '
        Me.UnderconditionDataGridViewTextBoxColumn.DataPropertyName = "undercondition"
        Me.UnderconditionDataGridViewTextBoxColumn.HeaderText = "路下条件"
        Me.UnderconditionDataGridViewTextBoxColumn.Name = "UnderconditionDataGridViewTextBoxColumn"
        Me.UnderconditionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlternatepathDataGridViewTextBoxColumn
        '
        Me.AlternatepathDataGridViewTextBoxColumn.DataPropertyName = "alternatepath"
        Me.AlternatepathDataGridViewTextBoxColumn.HeaderText = "代替路有無"
        Me.AlternatepathDataGridViewTextBoxColumn.Name = "AlternatepathDataGridViewTextBoxColumn"
        Me.AlternatepathDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GeneralroadDataGridViewTextBoxColumn
        '
        Me.GeneralroadDataGridViewTextBoxColumn.DataPropertyName = "generalroad"
        Me.GeneralroadDataGridViewTextBoxColumn.HeaderText = "自専道or一般道"
        Me.GeneralroadDataGridViewTextBoxColumn.Name = "GeneralroadDataGridViewTextBoxColumn"
        Me.GeneralroadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmergencyroadDataGridViewTextBoxColumn
        '
        Me.EmergencyroadDataGridViewTextBoxColumn.DataPropertyName = "emergencyroad"
        Me.EmergencyroadDataGridViewTextBoxColumn.HeaderText = "緊急輸送道路"
        Me.EmergencyroadDataGridViewTextBoxColumn.Name = "EmergencyroadDataGridViewTextBoxColumn"
        Me.EmergencyroadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OccupancyDataGridViewTextBoxColumn
        '
        Me.OccupancyDataGridViewTextBoxColumn.DataPropertyName = "occupancy"
        Me.OccupancyDataGridViewTextBoxColumn.HeaderText = "占用物件（名称）"
        Me.OccupancyDataGridViewTextBoxColumn.Name = "OccupancyDataGridViewTextBoxColumn"
        Me.OccupancyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SoundnessDataGridViewTextBoxColumn
        '
        Me.SoundnessDataGridViewTextBoxColumn.DataPropertyName = "soundness"
        Me.SoundnessDataGridViewTextBoxColumn.HeaderText = "健全度"
        Me.SoundnessDataGridViewTextBoxColumn.Name = "SoundnessDataGridViewTextBoxColumn"
        Me.SoundnessDataGridViewTextBoxColumn.ReadOnly = True
        '
        'uppermaterialmain
        '
        Me.uppermaterialmain.DataPropertyName = "uppermaterialmain"
        Me.uppermaterialmain.HeaderText = "上部工主桁"
        Me.uppermaterialmain.Name = "uppermaterialmain"
        Me.uppermaterialmain.ReadOnly = True
        '
        'uppermaterialside
        '
        Me.uppermaterialside.DataPropertyName = "uppermaterialside"
        Me.uppermaterialside.HeaderText = "上部工横桁"
        Me.uppermaterialside.Name = "uppermaterialside"
        Me.uppermaterialside.ReadOnly = True
        '
        'uppermaterialfloor
        '
        Me.uppermaterialfloor.DataPropertyName = "uppermaterialfloor"
        Me.uppermaterialfloor.HeaderText = "上部工床桁"
        Me.uppermaterialfloor.Name = "uppermaterialfloor"
        Me.uppermaterialfloor.ReadOnly = True
        '
        'UndermaterialDataGridViewTextBoxColumn
        '
        Me.UndermaterialDataGridViewTextBoxColumn.DataPropertyName = "undermaterial"
        Me.UndermaterialDataGridViewTextBoxColumn.HeaderText = "下部工"
        Me.UndermaterialDataGridViewTextBoxColumn.Name = "UndermaterialDataGridViewTextBoxColumn"
        Me.UndermaterialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BearingDataGridViewTextBoxColumn
        '
        Me.BearingDataGridViewTextBoxColumn.DataPropertyName = "bearing"
        Me.BearingDataGridViewTextBoxColumn.HeaderText = "支承"
        Me.BearingDataGridViewTextBoxColumn.Name = "BearingDataGridViewTextBoxColumn"
        Me.BearingDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FaceDataGridViewTextBoxColumn
        '
        Me.FaceDataGridViewTextBoxColumn.DataPropertyName = "face"
        Me.FaceDataGridViewTextBoxColumn.HeaderText = "橋面"
        Me.FaceDataGridViewTextBoxColumn.Name = "FaceDataGridViewTextBoxColumn"
        Me.FaceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExcelImportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 442)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ExcelImportForm"
        Me.Text = "点検データ確認"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.InspectionexcelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UppermaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImportButton As Button
    Friend WithEvents InspectionexcelBindingSource As BindingSource
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ErrorDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MessageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatadirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InspectionyearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InspectionerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnderconditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlternatepathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeneralroadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmergencyroadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OccupancyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoundnessDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents uppermaterialmain As DataGridViewTextBoxColumn
    Friend WithEvents uppermaterialside As DataGridViewTextBoxColumn
    Friend WithEvents uppermaterialfloor As DataGridViewTextBoxColumn
    Friend WithEvents UndermaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BearingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

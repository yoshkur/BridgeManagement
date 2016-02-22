<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BridgeAddForm
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.id = New System.Windows.Forms.TextBox()
		Me.bridgename = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.bridgenameruby = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.route = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.address = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.latitude = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.longitude = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.made = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.bridgelength = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.bridgewidth = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.span = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.bridgestructure = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.uppermaterial = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.memo = New System.Windows.Forms.TextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.inspectionway = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.nextinspection = New System.Windows.Forms.TextBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.repair = New System.Windows.Forms.TextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.emergencyroad = New System.Windows.Forms.TextBox()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.undercondition = New System.Windows.Forms.TextBox()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.lowermaterial = New System.Windows.Forms.TextBox()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.createBridgeButton = New System.Windows.Forms.Button()
		Me.BridgeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.BridgeNoteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		CType(Me.BridgeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BridgeNoteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(42, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(89, 12)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "国交省作業番号"
		'
		'id
		'
		Me.id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "id", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
		Me.id.Location = New System.Drawing.Point(172, 22)
		Me.id.Name = "id"
		Me.id.Size = New System.Drawing.Size(220, 19)
		Me.id.TabIndex = 1
		'
		'bridgename
		'
		Me.bridgename.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "bridgename", True))
		Me.bridgename.Location = New System.Drawing.Point(172, 63)
		Me.bridgename.Name = "bridgename"
		Me.bridgename.Size = New System.Drawing.Size(220, 19)
		Me.bridgename.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(42, 63)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(53, 12)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "道路橋名"
		'
		'bridgenameruby
		'
		Me.bridgenameruby.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "bridgenameruby", True))
		Me.bridgenameruby.Location = New System.Drawing.Point(172, 106)
		Me.bridgenameruby.Name = "bridgenameruby"
		Me.bridgenameruby.Size = New System.Drawing.Size(220, 19)
		Me.bridgenameruby.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(42, 106)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(80, 12)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "道路橋名(カナ)"
		'
		'route
		'
		Me.route.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "route", True))
		Me.route.Location = New System.Drawing.Point(172, 154)
		Me.route.Name = "route"
		Me.route.Size = New System.Drawing.Size(220, 19)
		Me.route.TabIndex = 7
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(42, 154)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(41, 12)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "路線名"
		'
		'address
		'
		Me.address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "address", True))
		Me.address.Location = New System.Drawing.Point(172, 200)
		Me.address.Name = "address"
		Me.address.Size = New System.Drawing.Size(220, 19)
		Me.address.TabIndex = 9
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(42, 200)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(41, 12)
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "所在地"
		'
		'latitude
		'
		Me.latitude.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "latitude", True))
		Me.latitude.Location = New System.Drawing.Point(172, 252)
		Me.latitude.Name = "latitude"
		Me.latitude.Size = New System.Drawing.Size(220, 19)
		Me.latitude.TabIndex = 11
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(42, 252)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(29, 12)
		Me.Label6.TabIndex = 10
		Me.Label6.Text = "緯度"
		'
		'longitude
		'
		Me.longitude.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "longitude", True))
		Me.longitude.Location = New System.Drawing.Point(172, 300)
		Me.longitude.Name = "longitude"
		Me.longitude.Size = New System.Drawing.Size(220, 19)
		Me.longitude.TabIndex = 13
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(42, 300)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(29, 12)
		Me.Label7.TabIndex = 12
		Me.Label7.Text = "経度"
		'
		'made
		'
		Me.made.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "made", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"))
		Me.made.Location = New System.Drawing.Point(172, 343)
		Me.made.Name = "made"
		Me.made.Size = New System.Drawing.Size(220, 19)
		Me.made.TabIndex = 15
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(42, 343)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(53, 12)
		Me.Label8.TabIndex = 14
		Me.Label8.Text = "架設年次"
		'
		'bridgelength
		'
		Me.bridgelength.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "bridgelength", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N1"))
		Me.bridgelength.Location = New System.Drawing.Point(172, 390)
		Me.bridgelength.Name = "bridgelength"
		Me.bridgelength.Size = New System.Drawing.Size(220, 19)
		Me.bridgelength.TabIndex = 17
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(42, 390)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(29, 12)
		Me.Label9.TabIndex = 16
		Me.Label9.Text = "橋長"
		'
		'bridgewidth
		'
		Me.bridgewidth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "bridgewidth", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N1"))
		Me.bridgewidth.Location = New System.Drawing.Point(172, 432)
		Me.bridgewidth.Name = "bridgewidth"
		Me.bridgewidth.Size = New System.Drawing.Size(220, 19)
		Me.bridgewidth.TabIndex = 19
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(42, 432)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(29, 12)
		Me.Label10.TabIndex = 18
		Me.Label10.Text = "幅員"
		'
		'span
		'
		Me.span.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "span", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
		Me.span.Location = New System.Drawing.Point(172, 478)
		Me.span.Name = "span"
		Me.span.Size = New System.Drawing.Size(220, 19)
		Me.span.TabIndex = 21
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(42, 478)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(41, 12)
		Me.Label11.TabIndex = 20
		Me.Label11.Text = "径間数"
		'
		'bridgestructure
		'
		Me.bridgestructure.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "bridgestructure", True))
		Me.bridgestructure.Location = New System.Drawing.Point(172, 524)
		Me.bridgestructure.Name = "bridgestructure"
		Me.bridgestructure.Size = New System.Drawing.Size(220, 19)
		Me.bridgestructure.TabIndex = 23
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(42, 524)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(53, 12)
		Me.Label12.TabIndex = 22
		Me.Label12.Text = "構造形式"
		'
		'uppermaterial
		'
		Me.uppermaterial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "uppermaterial", True))
		Me.uppermaterial.Location = New System.Drawing.Point(172, 569)
		Me.uppermaterial.Name = "uppermaterial"
		Me.uppermaterial.Size = New System.Drawing.Size(220, 19)
		Me.uppermaterial.TabIndex = 25
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(42, 569)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(89, 12)
		Me.Label13.TabIndex = 24
		Me.Label13.Text = "上部工使用材料"
		'
		'memo
		'
		Me.memo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeNoteBindingSource, "memo", True))
		Me.memo.Location = New System.Drawing.Point(172, 898)
		Me.memo.Name = "memo"
		Me.memo.Size = New System.Drawing.Size(220, 19)
		Me.memo.TabIndex = 39
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(42, 898)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(29, 12)
		Me.Label14.TabIndex = 38
		Me.Label14.Text = "備考"
		'
		'inspectionway
		'
		Me.inspectionway.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeNoteBindingSource, "inspectionway", True))
		Me.inspectionway.Location = New System.Drawing.Point(172, 850)
		Me.inspectionway.Name = "inspectionway"
		Me.inspectionway.Size = New System.Drawing.Size(220, 19)
		Me.inspectionway.TabIndex = 37
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(42, 850)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(53, 12)
		Me.Label15.TabIndex = 36
		Me.Label15.Text = "点検方法"
		'
		'nextinspection
		'
		Me.nextinspection.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeNoteBindingSource, "nextinspection", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"))
		Me.nextinspection.Location = New System.Drawing.Point(172, 798)
		Me.nextinspection.Name = "nextinspection"
		Me.nextinspection.Size = New System.Drawing.Size(220, 19)
		Me.nextinspection.TabIndex = 35
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(42, 798)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(77, 12)
		Me.Label16.TabIndex = 34
		Me.Label16.Text = "次回点検年度"
		'
		'repair
		'
		Me.repair.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeNoteBindingSource, "repair", True))
		Me.repair.Location = New System.Drawing.Point(172, 752)
		Me.repair.Name = "repair"
		Me.repair.Size = New System.Drawing.Size(220, 19)
		Me.repair.TabIndex = 33
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Location = New System.Drawing.Point(42, 752)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(53, 12)
		Me.Label17.TabIndex = 32
		Me.Label17.Text = "修繕履歴"
		'
		'emergencyroad
		'
		Me.emergencyroad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "emergencyroad", True))
		Me.emergencyroad.Location = New System.Drawing.Point(172, 704)
		Me.emergencyroad.Name = "emergencyroad"
		Me.emergencyroad.Size = New System.Drawing.Size(220, 19)
		Me.emergencyroad.TabIndex = 31
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Location = New System.Drawing.Point(42, 704)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(77, 12)
		Me.Label18.TabIndex = 30
		Me.Label18.Text = "緊急輸送道路"
		'
		'undercondition
		'
		Me.undercondition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "undercondition", True))
		Me.undercondition.Location = New System.Drawing.Point(172, 661)
		Me.undercondition.Name = "undercondition"
		Me.undercondition.Size = New System.Drawing.Size(220, 19)
		Me.undercondition.TabIndex = 29
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Location = New System.Drawing.Point(42, 661)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(53, 12)
		Me.Label19.TabIndex = 28
		Me.Label19.Text = "路下条件"
		'
		'lowermaterial
		'
		Me.lowermaterial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BridgeBindingSource, "lowermaterial", True))
		Me.lowermaterial.Location = New System.Drawing.Point(172, 620)
		Me.lowermaterial.Name = "lowermaterial"
		Me.lowermaterial.Size = New System.Drawing.Size(220, 19)
		Me.lowermaterial.TabIndex = 27
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Location = New System.Drawing.Point(42, 620)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(53, 12)
		Me.Label20.TabIndex = 26
		Me.Label20.Text = "床板材料"
		'
		'createBridgeButton
		'
		Me.createBridgeButton.Location = New System.Drawing.Point(44, 940)
		Me.createBridgeButton.Name = "createBridgeButton"
		Me.createBridgeButton.Size = New System.Drawing.Size(75, 23)
		Me.createBridgeButton.TabIndex = 40
		Me.createBridgeButton.Text = "登録"
		Me.createBridgeButton.UseVisualStyleBackColor = True
		'
		'BridgeBindingSource
		'
		Me.BridgeBindingSource.DataSource = GetType(BridgeManagement.bridge)
		'
		'BridgeNoteBindingSource
		'
		Me.BridgeNoteBindingSource.DataSource = GetType(BridgeManagement.bridgenote)
		'
		'BridgeAddForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(457, 982)
		Me.Controls.Add(Me.createBridgeButton)
		Me.Controls.Add(Me.memo)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.inspectionway)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.nextinspection)
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.repair)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.emergencyroad)
		Me.Controls.Add(Me.Label18)
		Me.Controls.Add(Me.undercondition)
		Me.Controls.Add(Me.Label19)
		Me.Controls.Add(Me.lowermaterial)
		Me.Controls.Add(Me.Label20)
		Me.Controls.Add(Me.uppermaterial)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.bridgestructure)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.span)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.bridgewidth)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.bridgelength)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.made)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.longitude)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.latitude)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.address)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.route)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.bridgenameruby)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.bridgename)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.id)
		Me.Controls.Add(Me.Label1)
		Me.Name = "BridgeAddForm"
		Me.Text = "BridgeAddForm"
		CType(Me.BridgeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BridgeNoteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents id As TextBox
	Friend WithEvents bridgename As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents bridgenameruby As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents route As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents address As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents latitude As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents longitude As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents made As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents bridgelength As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents bridgewidth As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents span As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents bridgestructure As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents uppermaterial As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents memo As TextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents inspectionway As TextBox
	Friend WithEvents Label15 As Label
	Friend WithEvents nextinspection As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents repair As TextBox
	Friend WithEvents Label17 As Label
	Friend WithEvents emergencyroad As TextBox
	Friend WithEvents Label18 As Label
	Friend WithEvents undercondition As TextBox
	Friend WithEvents Label19 As Label
	Friend WithEvents lowermaterial As TextBox
	Friend WithEvents Label20 As Label
	Friend WithEvents createBridgeButton As Button
	Friend WithEvents BridgeBindingSource As BindingSource
	Friend WithEvents BridgeNoteBindingSource As BindingSource
End Class

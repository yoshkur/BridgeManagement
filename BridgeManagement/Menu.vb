Public Class Menu
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		'Me.BridgeTableAdapter.Insert(id:=4, recorddate:=Now, recordprogram:=Me.Name, recorduserid:="test", recordvalid:=True, bridgename:="aaa", route:="bbb", address:="ccc", latitude:="143", longitude:="38", made:=1972, bridgelength:=59.7, bridgewidth:=7.8, span:=9, bridgestructure:="ddd", uppermaterial:="eee", lowermaterial:="fff", undercondition:="ggg", emergencyroad:="hhh", memo:="iii")

		Dim db As New bridgemanagementEntities
		Dim newEntity As New bridge
		'newEntity.id = (From br In db.bridge Select br.id).Max + 1
		newEntity.id = db.bridge.Select(Function(br) br.id).Max + 1
		newEntity.recorddate = Now
		newEntity.recordprogram = Me.Name
		newEntity.recorduserid = "yosh"
		newEntity.recordvalid = True
		newEntity.bridgename = "相川"
		db.bridge.Add(newEntity)
		db.SaveChanges()

		Me.TextBox1.Text = newEntity.id

	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.TextBox1.Text = System.Environment.UserName
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


		'Dim db As New bridgemanagementEntities
		'Dim entities = From en In db.bridge.Where(Function(n) n.id.ToString.Equals(Me.DataGridView1.CurrentCell.Value.ToString))

		'For Each entityb In entities
		'	Me.TextBox1.Text = entityb.id
		'	entityb.recorddate = Now
		'Next

		REM Dim bridgeEntity = db.bridge.Find(Me.DataGridView1.CurrentCell.Value)
		REM bridgeEntity.recorddate = Now

		'db.SaveChanges()

		'TODO: このコード行はデータを 'BridgemanagementDataSet.bridge' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
		REM Me.BridgeTableAdapter.Fill(Me.BridgemanagementDataSet.bridge)
	End Sub

	Private Sub inspectionDataImportButtom_Click(sender As Object, e As EventArgs) Handles inspectionDataImportButtom.Click
		Dim form As New ExcelImportForm
		form.ShowDialog(Me)
		form.Dispose()
	End Sub

	Private Sub BridgeManagementButton_Click(sender As Object, e As EventArgs) Handles bridgeManagementButton.Click
		Dim form As New BridgeManagementViewForm
		form.ShowDialog(Me)
		form.Dispose()
	End Sub
End Class

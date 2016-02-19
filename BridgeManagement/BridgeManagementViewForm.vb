Public Class BridgeManagementViewForm
	Private Sub BridgeManagementViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim db As New bridgemanagementEntities
		Dim entities = From ent In db.bridgemanagementview
		For Each ent In entities
			Me.DataGridView1.Rows.Add(ent.id.ToString, ent.bridgename, ent.bridgenameruby, ent.route, ent.address, ent.latitude, ent.longitude, ent.made, ent.bridgeage, ent.bridgelength, ent.bridgewidth, ent.span, ent.bridgestructure, ent.uppermaterial, ent.lowermaterial, ent.undercondition, ent.emergencyroad, ent.repair, ent.nextinspection, ent.inspectionway, ent.memo, ent.inspectionyear, ent.inspectioner, ent.undercondition, ent.alternatepath, ent.generalroad, ent.emergencyroad, ent.occupancy, ent.soundness, ent.uppermaterial, ent.undermaterial, ent.bearing, ent.face, ent.datasavedir)
		Next
	End Sub

	Private Sub inspectionHistoryButton_Click(sender As Object, e As EventArgs) Handles inspectionHistoryButton.Click
		Dim form As New InspectionHistoryForm

		If Me.DataGridView1.SelectedCells.Count > 1 Then
			MsgBox("選択は1つだけにしてください。")
		ElseIf Me.DataGridView1.SelectedCells.Count < 1 Then
			MsgBox("履歴を見たい行のセルを選択してください。")
		Else
			For Each cell As DataGridViewCell In Me.DataGridView1.SelectedCells
				form.setDataKey(Me.DataGridView1.Item(0, cell.RowIndex).Value)
				form.ShowDialog(Me)
				form.Dispose()
			Next
		End If

	End Sub
End Class
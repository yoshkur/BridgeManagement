Public Class BridgeManagementViewForm
	Private Sub updateDatasource()
		Dim db As New bridgemanagementEntities
		Dim bs As New BindingSource
		For Each ent In db.bridgemanagementview
			bs.Add(ent)
		Next
		Me.DataGridView1.DataSource = bs
	End Sub

	Private Sub BridgeManagementViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.updateDatasource()
	End Sub

	Private Sub inspectionHistoryButton_Click(sender As Object, e As EventArgs) Handles inspectionHistoryButton.Click
		Dim form As New InspectionHistoryForm
		form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
		form.ShowDialog(Me)
		form.Dispose()
		Me.updateDatasource()
	End Sub

	Private Sub bridgeHistoryButton_Click(sender As Object, e As EventArgs) Handles bridgeHistoryButton.Click
		Dim form As New BridgeHistoryForm
		form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
		form.ShowDialog(Me)
		form.Dispose()
		Me.updateDatasource()
	End Sub

	Private Sub bridgeNoteButton_Click(sender As Object, e As EventArgs) Handles bridgeNoteButton.Click
		Dim form As New BridgeNoteHistoryForm
		form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
		form.ShowDialog(Me)
		form.Dispose()
		Me.updateDatasource()
	End Sub

	Private Sub editBridgeButton_Click(sender As Object, e As EventArgs) Handles editBridgeButton.Click
		Dim form As New BridgeEditForm
		form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
		form.ShowDialog(Me)
		form.Dispose()
		Me.updateDatasource()
	End Sub

	Private Sub editBridgeNoteButton_Click(sender As Object, e As EventArgs) Handles editBridgeNoteButton.Click
		Dim form As New BridgeNoteEditForm
		form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
		form.ShowDialog(Me)
		form.Dispose()
		Me.updateDatasource()
	End Sub
End Class
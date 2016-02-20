Public Class BridgeNoteHistoryForm
	Public Sub setDataSource(key As Integer)
		Dim db As New bridgemanagementEntities
		Dim bs As New BindingSource
		For Each ent In db.bridgenotehistory.Where(Function(n) n.id = key)
			bs.Add(ent)
		Next
		Me.DataGridView1.DataSource = bs
	End Sub
End Class
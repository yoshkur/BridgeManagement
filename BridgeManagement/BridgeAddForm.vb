Public Class BridgeAddForm
	Public Sub onLoadForm() Handles MyBase.Load
		Dim db As New bridgemanagementEntities
		Me.BridgeBindingSource.Add(New bridge)
		Me.BridgeNoteBindingSource.Add(New bridgenote)
		Me.id.Text = db.bridge.Select(Function(br) br.id).Max + 1
	End Sub

	Private Sub createBridgeButton_Click(sender As Object, e As EventArgs) Handles createBridgeButton.Click
		Try
			Dim db As New bridgemanagementEntities

			Dim ent1 = Me.BridgeBindingSource.Current
			ent1.recorddate = Now
			ent1.recordprogram = Me.Name
			ent1.recorduserid = System.Environment.UserName
			ent1.recordvalid = True
			db.bridge.Add(ent1)

			Dim ent2 = Me.BridgeNoteBindingSource.Current
			ent2.id = ent1.id
			ent2.recorddate = Now
			ent2.recordprogram = Me.Name
			ent2.recorduserid = System.Environment.UserName
			ent2.recordvalid = True
			db.bridgenote.Add(ent2)

			db.SaveChanges()

			Me.Close()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try

	End Sub
End Class
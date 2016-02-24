Public Class BridgeEditForm
	Private db As New bridgemanagementEntities

	Public Sub setDataSource(key As Integer)
		Me.BridgeBindingSource.Add(Me.db.bridge.Find(key))
	End Sub

	Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editBridgeButton.Click
		Try
			Dim ent As bridge = Me.BridgeBindingSource.Current
			ent.recorddate = Now
			ent.recordprogram = Me.Name
			ent.recorduserid = System.Environment.UserName
			ent.recordvalid = True

			Me.BridgeBindingSource.EndEdit()
			Me.db.SaveChanges()
			Me.Close()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
End Class
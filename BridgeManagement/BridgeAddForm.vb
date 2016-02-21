Public Class BridgeAddForm
	Public Sub onLoadForm() Handles MyBase.Load
		Dim db As New bridgemanagementEntities
		Me.id.Text = db.bridge.Select(Function(br) br.id).Max + 1
	End Sub

	Private Sub createBridgeButton_Click(sender As Object, e As EventArgs) Handles createBridgeButton.Click
		Try
			Dim db As New bridgemanagementEntities

			Dim bridgeEntity As New bridge
			bridgeEntity.id = Me.id.Text
			bridgeEntity.recorddate = Now
			bridgeEntity.recordprogram = Me.Name
			bridgeEntity.recorduserid = System.Environment.UserName
			bridgeEntity.recordvalid = True
			bridgeEntity.bridgename = Me.bridgename.Text
			bridgeEntity.bridgenameruby = Me.bridgenameruby.Text
			bridgeEntity.route = Me.route.Text
			bridgeEntity.address = Me.address.Text
			bridgeEntity.latitude = Me.latitude.Text
			bridgeEntity.longitude = Me.longitude.Text
			Dim temp As String = Me.made.Text
			If temp.Length > 0 Then
				bridgeEntity.made = Integer.Parse(temp)
			Else
				bridgeEntity.made = 0
			End If
			bridgeEntity.bridgelength = Me.bridgelength.Text
			bridgeEntity.bridgewidth = Me.bridgewidth.Text
			bridgeEntity.span = Me.span.Text
			bridgeEntity.bridgestructure = Me.bridgestructure.Text
			bridgeEntity.uppermaterial = Me.uppermaterial.Text
			bridgeEntity.lowermaterial = Me.lowermaterial.Text
			bridgeEntity.undercondition = Me.undercondition.Text
			bridgeEntity.emergencyroad = Me.emergencyroad.Text
			db.bridge.Add(bridgeEntity)

			Dim bridgeNoteEntity As New bridgenote
			bridgeNoteEntity.id = Me.id.Text
			bridgeNoteEntity.recorddate = Now
			bridgeNoteEntity.recordprogram = Me.Name
			bridgeNoteEntity.recorduserid = System.Environment.UserName
			bridgeNoteEntity.recordvalid = True
			bridgeNoteEntity.repair = Me.repair.Text
			temp = Me.nextinspection.Text
			If temp.Length > 0 Then
				bridgeNoteEntity.nextinspection = Integer.Parse(temp)
			Else
				bridgeNoteEntity.nextinspection = 0
			End If
			bridgeNoteEntity.inspectionway = Me.inspectionway.Text
			bridgeNoteEntity.memo = Me.memo.Text
			db.bridgenote.Add(bridgeNoteEntity)

			db.SaveChanges()

			Me.Close()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try

	End Sub
End Class
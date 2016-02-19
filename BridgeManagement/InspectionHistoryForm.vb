Public Class InspectionHistoryForm
	Public Sub setDataKey(key As Integer)
		Dim db As New bridgemanagementEntities
		'Dim entities = From ent In db.inspectionhistory Where ent.id = key
		Dim entities = From ent In db.inspectionhistory.Where(Function(n) n.id = key)
		For Each e In entities
			Me.DataGridView1.Rows.Add(e.id, e.recorddate, e.inspectionyear, e.inspectioner, e.undercondition, e.alternatepath, e.generalroad, e.emergencyroad, e.occupancy, e.soundness, e.uppermaterial, e.undermaterial, e.bearing, e.face, e.datasavedir)
		Next
	End Sub
End Class
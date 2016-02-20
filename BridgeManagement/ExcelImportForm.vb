Imports System.IO

Public Class ExcelImportForm
	Private Sub ExcelImportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.getInspectionData()
		Dim db As New bridgemanagementEntities
		Dim bs As New BindingSource
		For Each ent In db.inspectionexcel
			bs.Add(ent)
		Next
		Me.DataGridView1.DataSource = bs
	End Sub

	Private Sub getInspectionData()
		Try
			Dim db As New bridgemanagementEntities
			db.inspectionexcel.RemoveRange(db.inspectionexcel)
			Dim setting As Setting = Setting.getInstance
			Dim directorys = Directory.GetDirectories(setting.WorkDirectoryPath)
			Dim _error As Boolean = False
			For Each datadir In directorys
				Dim i As Integer = 0
				Dim inspectionExcel As inspectionexcel = New InspectionExcelBuilder(i, datadir).getInstance
				db.inspectionexcel.Add(inspectionExcel)
				_error = _error OrElse inspectionExcel.error
			Next
			db.SaveChanges()
			Me.ImportButton.Enabled = Not _error
		Catch ex As Exception

		End Try
	End Sub

	Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
		Dim db As New bridgemanagementEntities
		Me.addInspection(db)
		db.inspectionexcel.RemoveRange(db.inspectionexcel)
		db.SaveChanges()
		Me.Close()
	End Sub

	Private Sub addInspection(db As bridgemanagementEntities)
		Dim inspectionExcels = db.inspectionexcel

		For Each inspectionExcel In inspectionExcels
			Dim newEntity As New inspection
			Dim findEntity = db.inspection.Find(inspectionExcel.id)
			If findEntity Is Nothing Then
				newEntity.id = inspectionExcel.id
				newEntity.recorddate = Now
				newEntity.recordprogram = Me.Name
				newEntity.recorduserid = System.Environment.UserName
				newEntity.recordvalid = True
				newEntity.inspectionyear = inspectionExcel.inspectionyear
				newEntity.inspectioner = inspectionExcel.inspectioner
				newEntity.undercondition = inspectionExcel.undercondition
				newEntity.alternatepath = inspectionExcel.alternatepath
				newEntity.generalroad = inspectionExcel.generalroad
				newEntity.emergencyroad = inspectionExcel.emergencyroad
				newEntity.occupancy = inspectionExcel.occupancy
				newEntity.soundness = inspectionExcel.soundness
				newEntity.uppermaterial = inspectionExcel.uppermaterial
				newEntity.undermaterial = inspectionExcel.undermaterial
				newEntity.bearing = inspectionExcel.bearing
				newEntity.face = inspectionExcel.face
				newEntity.datasavedir = Me.moveDirectory(inspectionExcel, newEntity)
				db.inspection.Add(newEntity)
				Me.addInspectionHistory(db, newEntity)
			Else
				findEntity.recorddate = Now
				findEntity.recordprogram = Me.Name
				findEntity.recorduserid = System.Environment.UserName
				findEntity.recordvalid = True
				findEntity.inspectionyear = inspectionExcel.inspectionyear
				findEntity.inspectioner = inspectionExcel.inspectioner
				findEntity.undercondition = inspectionExcel.undercondition
				findEntity.alternatepath = inspectionExcel.alternatepath
				findEntity.generalroad = inspectionExcel.generalroad
				findEntity.emergencyroad = inspectionExcel.emergencyroad
				findEntity.occupancy = inspectionExcel.occupancy
				findEntity.soundness = inspectionExcel.soundness
				findEntity.uppermaterial = inspectionExcel.uppermaterial
				findEntity.undermaterial = inspectionExcel.undermaterial
				findEntity.bearing = inspectionExcel.bearing
				findEntity.face = inspectionExcel.face
				findEntity.datasavedir = Me.moveDirectory(inspectionExcel, findEntity)
				Me.addInspectionHistory(db, findEntity)
			End If
		Next
	End Sub

	Private Sub addInspectionHistory(db As bridgemanagementEntities, inspection As inspection)
		Dim inspectionHistory As New inspectionhistory
		inspectionHistory.id = inspection.id
		inspectionHistory.recorddate = inspection.recorddate
		inspectionHistory.recordprogram = inspection.recordprogram
		inspectionHistory.recorduserid = inspection.recorduserid
		inspectionHistory.recordvalid = inspection.recordvalid
		inspectionHistory.inspectionyear = inspection.inspectionyear
		inspectionHistory.inspectioner = inspection.inspectioner
		inspectionHistory.undercondition = inspection.undercondition
		inspectionHistory.alternatepath = inspection.alternatepath
		inspectionHistory.generalroad = inspection.generalroad
		inspectionHistory.emergencyroad = inspection.emergencyroad
		inspectionHistory.occupancy = inspection.occupancy
		inspectionHistory.soundness = inspection.soundness
		inspectionHistory.uppermaterial = inspection.uppermaterial
		inspectionHistory.undermaterial = inspection.undermaterial
		inspectionHistory.bearing = inspection.bearing
		inspectionHistory.face = inspection.face
		inspectionHistory.datasavedir = inspection.datasavedir
		db.inspectionhistory.Add(inspectionHistory)
	End Sub

	Private Function moveDirectory(inspectionExcel As inspectionexcel, inspection As inspection) As String
		Dim setting As Setting = Setting.getInstance
		Dim saveDirectory = Path.Combine(setting.SaveDirectoryPath, Format(inspection.recorddate, "yyyyMMddHHmmss"))
		Directory.CreateDirectory(saveDirectory)
		Dim dir As New DirectoryInfo(inspectionExcel.datadir)
		Dim moveDirectoryTo = Path.Combine(saveDirectory, dir.Name)
		dir.MoveTo(moveDirectoryTo)
		Return moveDirectoryTo
	End Function
End Class
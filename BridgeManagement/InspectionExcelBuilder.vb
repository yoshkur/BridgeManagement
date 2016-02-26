Imports System.IO
Imports BridgeManagement
Imports Microsoft.Office.Interop

Public Class InspectionExcelBuilder
	Private _inspectionExcel As New inspectionexcel
	Private setting As Setting

	Public Property InspectionExcel As inspectionexcel
		Get
			Return _inspectionExcel
		End Get
		Set(value As inspectionexcel)
			_inspectionExcel = value
		End Set
	End Property

	Public Function getInstance() As inspectionexcel
		Return Me._inspectionExcel
	End Function

	Public Sub New(ident As Integer, datadir As String)
		Me.setting = Setting.getInstance
		Me._inspectionExcel.ident = ident
		Me._inspectionExcel.datadir = datadir
		Me.create()
	End Sub

	Private Sub create()
		Me._inspectionExcel.id = Me.getId
		Me.getExcelFileData()
		Me.checkData()
	End Sub

	Private Function getId() As Integer
		Dim id As Integer
		Try
			Dim sr As New StreamReader(Path.Combine(Me._inspectionExcel.datadir, Me.setting.IdFile.ToString))
			Dim str = sr.ReadLine
			id = Integer.Parse(str)
		Catch ex As System.IO.FileNotFoundException
			Me._inspectionExcel.error = True
			Me._inspectionExcel.message = Me._inspectionExcel.message & Me.setting.IdFile & "が見つかりません。"
		Catch ex As Exception
			Me._inspectionExcel.error = True
			Me._inspectionExcel.message = Me._inspectionExcel.message & ex.Message & "。"
		End Try
		Return id
	End Function

	Private Sub getExcelFileData()

		Try
			Dim excelController As New ExcelControllClass

			excelController.openFile(Me.getExcelFileName, True)
			excelController.setWorkSheet(Me.setting.SheetName)
			Dim inspectionYear = excelController.Cells(Me.setting.InspectionyearRow, Me.setting.InspectionyearColumn).Text
			Dim dtInspectionYear As DateTime
			If DateTime.TryParse(inspectionYear, dtInspectionYear) Then
				Me._inspectionExcel.inspectionyear = dtInspectionYear.Year
			Else
				Me._inspectionExcel.error = True
				Me._inspectionExcel.message = Me._inspectionExcel.message & "点検年度が取得できません。"
			End If
			Me._inspectionExcel.inspectioner = excelController.Cells(Me.setting.InspectionerRow, Me.setting.InspectionerColumn).Text
			Me._inspectionExcel.undercondition = excelController.Cells(Me.setting.UnderconditionRow, Me.setting.UnderconditionColumn).Text
			Me._inspectionExcel.alternatepath = excelController.Cells(Me.setting.AlternatepathRow, Me.setting.AlternatepathColumn).Text
			Me._inspectionExcel.generalroad = excelController.Cells(Me.setting.GeneralroadRow, Me.setting.GeneralroadColumn).Text
			Me._inspectionExcel.emergencyroad = excelController.Cells(Me.setting.EmergencyroadRow, Me.setting.EmergencyroadColumn).Text
			Me._inspectionExcel.occupancy = excelController.Cells(Me.setting.OccupancyRow, Me.setting.OccupancyColumn).Text
			Me._inspectionExcel.soundness = excelController.Cells(Me.setting.SoundnessRow, Me.setting.SoundnessColumn).Text
			Me._inspectionExcel.uppermaterial = excelController.Cells(Me.setting.UppermaterialRow, Me.setting.UppermaterialColumn).Text
			Me._inspectionExcel.undermaterial = excelController.Cells(Me.setting.UndermaterialRow, Me.setting.UndermaterialColumn).Text
			Me._inspectionExcel.bearing = excelController.Cells(Me.setting.BearingRow, Me.setting.BearingColumn).Text
			Me._inspectionExcel.face = excelController.Cells(Me.setting.FaceRow, Me.setting.FaceColumn).Text
			excelController.close(False)

		Catch ex As Exception
			Me._inspectionExcel.error = True
			Me._inspectionExcel.message = Me._inspectionExcel.message & ex.Message

		End Try

	End Sub

	Private Function getExcelFileName() As String
		Dim files = Directory.GetFiles(Me._inspectionExcel.datadir)
		Dim query = From file In files Where Path.GetFileName(file).StartsWith(Me.setting.FilePrefix)
		If query.Count > 1 Then
			Me._inspectionExcel.error = True
			Me._inspectionExcel.message = Me._inspectionExcel.message & "Excelのデータファイルが複数あります。"
			Return ""
		ElseIf query.Count < 1 Then
			Me._inspectionExcel.error = True
			Me._inspectionExcel.message = Me._inspectionExcel.message & "Excelのデータファイルが見つかりません。"
			Return ""
		Else
			Return query.First
		End If
	End Function

	Private Sub checkData()
		Me.checkExists()
	End Sub

	Private Sub checkExists()
		Dim db As New bridgemanagementEntities
		Dim entity = db.bridge.Find(Me._inspectionExcel.id)
		If entity Is Nothing Then
			Me._inspectionExcel.error = True
			Me._inspectionExcel.message = Me._inspectionExcel.message & "管理テーブルにデータが見つかりません。"
		End If
	End Sub
End Class

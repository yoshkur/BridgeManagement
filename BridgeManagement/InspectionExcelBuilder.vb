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
		Dim oXls As New Excel.Application
		oXls.Visible = True
		Dim oWBook As Excel.Workbook
		Try
			oXls = New Excel.Application()
			'動作しているのを確認するためExcelのウィンドウを表示する。
			oXls.Visible = True

			oWBook = DirectCast((oXls.Workbooks.Open(
				Me.getExcelFilenNme,
				Type.Missing,
				Type.Missing,
				Type.Missing,
				Type.Missing,
				Type.Missing,
				Type.Missing,
				Type.Missing,
				Type.Missing,
				Type.Missing,
				Type.Missing,
				Type.Missing,
				Type.Missing,
				Type.Missing,
				Type.Missing)),
				Excel.Workbook)

			Dim sheetName As String = Me.setting.SheetName
			Dim oSheet As Excel.Worksheet
			oSheet = DirectCast(oWBook.Sheets(sheetName), Excel.Worksheet)

			'Dim year = DirectCast(oSheet.Cells(Me.setting.InspectionyearRow, Me.setting.InspectionyearColumn), Excel.Range).Text
			'Me._inspectionExcel.inspectionyear = Integer.Parse(year.ToString.Substring(0, year.ToString.IndexOf(".")))
			Dim inspectionYear = DirectCast(oSheet.Cells(Me.setting.InspectionyearRow, Me.setting.InspectionyearColumn), Excel.Range).Text
			Dim dtInspectionYear As DateTime
			If DateTime.TryParse(inspectionYear, dtInspectionYear) Then
				Me._inspectionExcel.inspectionyear = dtInspectionYear.Year
			Else
				Me._inspectionExcel.error = True
				Me._inspectionExcel.message = Me._inspectionExcel.message & "点検年度が取得できません。"
			End If
			Me._inspectionExcel.inspectioner = DirectCast(oSheet.Cells(Me.setting.InspectionerRow, Me.setting.InspectionerColumn), Excel.Range).Text
			Me._inspectionExcel.undercondition = DirectCast(oSheet.Cells(Me.setting.UnderconditionRow, Me.setting.UnderconditionColumn), Excel.Range).Text
			Me._inspectionExcel.alternatepath = DirectCast(oSheet.Cells(Me.setting.AlternatepathRow, Me.setting.AlternatepathColumn), Excel.Range).Text
			Me._inspectionExcel.generalroad = DirectCast(oSheet.Cells(Me.setting.GeneralroadRow, Me.setting.GeneralroadColumn), Excel.Range).Text
			Me._inspectionExcel.emergencyroad = DirectCast(oSheet.Cells(Me.setting.EmergencyroadRow, Me.setting.EmergencyroadColumn), Excel.Range).Text
			Me._inspectionExcel.occupancy = DirectCast(oSheet.Cells(Me.setting.OccupancyRow, Me.setting.OccupancyColumn), Excel.Range).Text
			Me._inspectionExcel.soundness = DirectCast(oSheet.Cells(Me.setting.SoundnessRow, Me.setting.SoundnessColumn), Excel.Range).Text
			Me._inspectionExcel.uppermaterial = DirectCast(oSheet.Cells(Me.setting.UppermaterialRow, Me.setting.UppermaterialColumn), Excel.Range).Text
			Me._inspectionExcel.undermaterial = DirectCast(oSheet.Cells(Me.setting.UndermaterialRow, Me.setting.UndermaterialColumn), Excel.Range).Text
			Me._inspectionExcel.bearing = DirectCast(oSheet.Cells(Me.setting.BearingRow, Me.setting.BearingColumn), Excel.Range).Text
			Me._inspectionExcel.face = DirectCast(oSheet.Cells(Me.setting.FaceRow, Me.setting.FaceColumn), Excel.Range).Text

		Catch ex As Exception
			Me._inspectionExcel.error = True
			Me._inspectionExcel.message = Me._inspectionExcel.message & ex.Message
		Finally
			If oWBook IsNot Nothing Then
				oWBook.Close(False, Type.Missing, Type.Missing)
			End If
			oXls.Quit()
			MRComObject(oXls)
		End Try

	End Sub

	Private Shared Sub MRComObject(Of T As Class)(ByRef objCom As T,
												 Optional ByVal force As Boolean = False)
		If objCom Is Nothing Then
			Return
		End If
		Try
			If System.Runtime.InteropServices.Marshal.IsComObject(objCom) Then
				If force Then
					System.Runtime.InteropServices.Marshal.FinalReleaseComObject(objCom)
				Else
					System.Runtime.InteropServices.Marshal.ReleaseComObject(objCom)
				End If
			End If
		Finally
			objCom = Nothing
		End Try
	End Sub

	Private Function getExcelFilenNme() As String
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

Imports System.IO

Public Class ExcelImportForm
	Private Sub ExcelImportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.getInspectionData()
		'TODO: このコード行はデータを 'BridgemanagementExcelImportDataSet.inspectionexcel' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
		Me.InspectionexcelTableAdapter.Fill(Me.BridgemanagementExcelImportDataSet.inspectionexcel)

	End Sub

	Private Sub getInspectionData()
		Try
			Dim db As New bridgemanagementEntities
			Dim setting As Setting = Setting.getInstance
			Dim directorys = Directory.GetDirectories(setting.WorkDirectoryPath)
			db.inspectionexcel.RemoveRange(db.inspectionexcel)
			For Each datadir In directorys
				Dim i As Integer = 0
				Dim inspectionExcel As inspectionexcel = New InspectionExcelBuilder(i, datadir).getInstance
				db.inspectionexcel.Add(inspectionExcel)
			Next
			db.SaveChanges()
		Catch ex As Exception

		End Try
	End Sub

End Class
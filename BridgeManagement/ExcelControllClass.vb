Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class ExcelControllClass
	Private _oXls As New Excel.Application
	Private _oWBook As Excel.Workbook
	Private _oSheet As Excel.Worksheet

	Public Property OXls As Application
		Get
			Return _oXls
		End Get
		Set(value As Application)
			_oXls = value
		End Set
	End Property

	Public Property OWBook As Workbook
		Get
			Return _oWBook
		End Get
		Set(value As Workbook)
			_oWBook = value
		End Set
	End Property

	Public Property OSheet As Worksheet
		Get
			Return _oSheet
		End Get
		Set(value As Worksheet)
			_oSheet = value
		End Set
	End Property

	Public Sub openFile(file As String, visible As Boolean)
		Me.OWBook = DirectCast((Me.OXls.Workbooks.Open(
				file,
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
		Me.OXls.Visible = visible
	End Sub

	Public Sub setWorkSheet(workSheetName As String)
		Me.OSheet = DirectCast(OWBook.Sheets(workSheetName), Excel.Worksheet)
	End Sub

	Public Function Cells(row As Integer, column As Integer) As Excel.Range
		Return DirectCast(Me.OSheet.Cells(row, column), Excel.Range)
	End Function

	Public Sub close(save As Boolean)
		If Me.OWBook IsNot Nothing Then
			Me.OWBook.Close(save, Type.Missing, Type.Missing)
		End If
		Me.OXls.Quit()
		MRComObject(Me.OXls)
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
End Class

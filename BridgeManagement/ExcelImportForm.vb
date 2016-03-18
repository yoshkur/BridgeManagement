Imports System.IO

Public Class ExcelImportForm
    Private _error As Boolean

    Public Function getError() As Boolean
        Return Me._error
    End Function

    Public Sub setError(_error As Boolean)
        Me._error = _error
    End Sub

    Private Sub ExcelImportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.getInspectionData()
        Me.updateDataSource()
    End Sub

    Private Sub updateDataSource()
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
            Me.setError(False)
            For Each datadir In directorys
                Dim i As Integer = 0
                Dim inspectionExcel As inspectionexcel = New InspectionExcelBuilder(i, datadir).getInstance
                db.inspectionexcel.Add(inspectionExcel)
                _error = Me.getError OrElse inspectionExcel.error
            Next
            db.SaveChanges()
            Me.ImportButton.Enabled = Not Me.getError
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Dim db As New bridgemanagementEntities
        Me.addInspection(db)
        'db.inspectionexcel.RemoveRange(db.inspectionexcel)
        db.SaveChanges()
        If Me.getError Then
            Me.updateDataSource()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub addInspection(db As bridgemanagementEntities)
        Dim inspectionExcels = db.inspectionexcel
        Me.setError(False)

        For Each inspectionExcel In inspectionExcels
            Dim ent = db.inspection.Find(inspectionExcel.id)
            Dim _new As Boolean = ent Is Nothing

            If _new Then
                ent = New inspection
            End If
            ent.id = inspectionExcel.id
            ent.recorddate = Now
            ent.recordprogram = Me.Name
            ent.recorduserid = System.Environment.UserName
            ent.recordvalid = True
            ent.inspectionyear = inspectionExcel.inspectionyear
            ent.inspectioner = inspectionExcel.inspectioner
            ent.undercondition = inspectionExcel.undercondition
            ent.alternatepath = inspectionExcel.alternatepath
            ent.generalroad = inspectionExcel.generalroad
            ent.emergencyroad = inspectionExcel.emergencyroad
            ent.occupancy = inspectionExcel.occupancy
            ent.soundness = inspectionExcel.soundness
            ent.uppermaterialmain = inspectionExcel.uppermaterialmain
            ent.uppermaterialside = inspectionExcel.uppermaterialside
            ent.uppermaterialfloor = inspectionExcel.uppermaterialfloor
            ent.undermaterial = inspectionExcel.undermaterial
            ent.bearing = inspectionExcel.bearing
            ent.face = inspectionExcel.face
            Try
                ent.datasavedir = Me.moveDirectory(inspectionExcel, ent)
                If _new Then
                    db.inspection.Add(ent)
                End If
                db.inspectionexcel.Remove(inspectionExcel)
            Catch ex As Exception
                Me.setError(True)
                inspectionExcel.error = True
                inspectionExcel.message = ex.Message
            End Try
        Next
    End Sub

    Private Function moveDirectory(inspectionExcel As inspectionexcel, inspection As inspection) As String
        Try
            Dim setting As Setting = Setting.getInstance
            Dim saveDirectory = Path.Combine(setting.SaveDirectoryPath, Format(inspection.recorddate, "yyyyMMddHHmmss"))
            Directory.CreateDirectory(saveDirectory)
            Dim dir As New DirectoryInfo(inspectionExcel.datadir)
            Dim moveDirectoryTo = Path.Combine(saveDirectory, dir.Name)
            dir.MoveTo(moveDirectoryTo)
            Return moveDirectoryTo.Substring(setting.SaveDirectoryPath.Length + 1, moveDirectoryTo.Length - setting.SaveDirectoryPath.Length - 1)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
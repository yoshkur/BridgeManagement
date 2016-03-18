Public Class BridgeNoteEditForm
    Private db As New bridgemanagementEntities
    Private bridgeManagementViewForm As BridgeManagementViewForm

    Public Sub setDataSource(key As Integer)
        Me.BridgeNoteBindingSource.Add(Me.db.bridgenote.Find(key))
    End Sub

    Public Sub setParentForm(parent As BridgeManagementViewForm)
        Me.bridgeManagementViewForm = parent
    End Sub

    Private Sub editBridgeNoteButton_Click(sender As Object, e As EventArgs) Handles editBridgeNoteButton.Click
        Try
            Dim ent As bridgenote = Me.BridgeNoteBindingSource.Current
            ent.recorddate = Now
            ent.recordprogram = Me.Name
            ent.recorduserid = System.Environment.UserName
            ent.recordvalid = True

            Me.BridgeNoteBindingSource.EndEdit()
            Me.db.SaveChanges()
            Me.Close()
            Me.bridgeManagementViewForm.updateDatasource()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
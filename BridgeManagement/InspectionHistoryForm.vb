Imports System.IO

Public Class InspectionHistoryForm
    Public Sub setDataSource(key As Integer)
        Dim db As New bridgemanagementEntities
        Dim bs As New BindingSource
        For Each ent In db.inspectionhistory.Where(Function(n) n.id = key)
            bs.Add(ent)
        Next
        Me.DataGridView1.DataSource = bs
    End Sub

    Private Sub openDirectoryButton_Click(sender As Object, e As EventArgs) Handles openDirectoryButton.Click
        Dim setting As Setting = Setting.getInstance
        Dim db As New bridgemanagementEntities
        Dim ent As inspectionhistory = db.inspectionhistory.Find(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value, Me.DataGridView1.Item(1, Me.DataGridView1.CurrentRow.Index).Value)
        If ent IsNot Nothing AndAlso ent.datasavedir.Length > 0 Then
            System.Diagnostics.Process.Start(Path.Combine(setting.SaveDirectoryPath, ent.datasavedir))
        Else
            MsgBox("点検データの登録がありません。")
        End If
    End Sub
End Class
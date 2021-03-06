﻿Imports System.IO

Public Class BridgeManagementViewForm
    Private setting As Setting = Setting.getInstance
    Private designationYear As Integer = 0

    Public Sub updateDatasource()
        Dim db As New bridgemanagementEntities
        Dim bs As New BindingSource
        Dim strsql As String = ""　'条件
        Dim allstrsql As String = "select * from bridgemanagementview "

        '絞込用条件を作る
        If Me.designationYear <> 0 Then
            strsql = strsql + "AND ( nextinspection = " & Me.designationYear & " or inspectionyear + " & Me.setting.Inspectionspan & " = " & Me.designationYear & ") "
        End If

        '道路橋名
        If Me.TextBox1.Text <> "" Then
            strsql = strsql + "AND bridgename LIKE '%" & SSQL(TextBox1.Text) & "%' "
        End If
        '路線名
        If Me.TextBox2.Text <> "" Then
            strsql = strsql + "AND route LIKE '%" & SSQL(TextBox2.Text) & "%' "
        End If
        '所在地
        If Me.TextBox3.Text <> "" Then
            strsql = strsql + "AND address LIKE '%" & SSQL(TextBox3.Text) & "%' "
        End If

        '架設年次
        If Me.TextBox4.Text <> "" AndAlso Me.TextBox5.Text <> "" Then
            strsql = strsql + "AND (made >=" & Val(TextBox4.Text) & " AND made <=" & Val(TextBox5.Text) & ") "
        End If
        '橋令
        If Me.TextBox6.Text <> "" AndAlso Me.TextBox7.Text <> "" Then
            strsql = strsql + "AND (bridgeage >=" & Val(TextBox6.Text) & " AND bridgeage <=" & Val(TextBox7.Text) & ") "
        End If
        '橋長
        If Me.TextBox8.Text <> "" AndAlso Me.TextBox9.Text <> "" Then
            strsql = strsql + "AND (bridgelength >=" & Val(TextBox8.Text) & " AND bridgelength <=" & Val(TextBox9.Text) & ") "
        End If
        '幅員
        If Me.TextBox10.Text <> "" AndAlso Me.TextBox11.Text <> "" Then
            strsql = strsql + "AND (bridgewidth >=" & Val(TextBox10.Text) & " AND bridgewidth <=" & Val(TextBox11.Text) & ") "
        End If
        '径間数
        If Me.TextBox12.Text <> "" AndAlso Me.TextBox13.Text <> "" Then
            strsql = strsql + "AND (span >=" & Val(TextBox12.Text) & " AND span <=" & Val(TextBox13.Text) & ") "
        End If

        '構造形式
        If Me.TextBox15.Text <> "" Then
            strsql = strsql + "AND bridgestructure LIKE '%" & SSQL(TextBox15.Text) & "%' "
        End If
        '上部工使用材料
        If Me.TextBox16.Text <> "" Then
            strsql = strsql + "AND uppermaterial LIKE '%" & SSQL(TextBox16.Text) & "%' "
        End If
        '床板材料
        If Me.TextBox17.Text <> "" Then
            strsql = strsql + "AND lowermaterial LIKE '%" & SSQL(TextBox17.Text) & "%' "
        End If




        If Len(strsql) <> 0 Then
            '条件の先頭文字を取る処理（AND　やら　_ORやら）
            strsql = Mid(strsql, 4, Len(strsql) - 4)
            allstrsql = allstrsql + " WHERE " + strsql
        End If




        Dim query = db.bridgemanagementview.SqlQuery(allstrsql)

        For Each ent In query
            bs.Add(ent)
        Next
        Me.DataGridView1.DataSource = bs
        'グリッドのサイズを自動調整
        Me.DataGridView1.AutoResizeRows()
        Me.DataGridView1.AutoResizeColumns()

    End Sub

    Private Sub BridgeManagementViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.setNextInspectionYear()
        Me.updateDatasource()
    End Sub

    Private Sub inspectionHistoryButton_Click(sender As Object, e As EventArgs) Handles inspectionHistoryButton.Click
        Dim form As New InspectionHistoryForm
        form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
        form.ShowDialog(Me)
        form.Dispose()
    End Sub

    Private Sub bridgeHistoryButton_Click(sender As Object, e As EventArgs) Handles bridgeHistoryButton.Click
        Dim form As New BridgeHistoryForm
        form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
        form.ShowDialog(Me)
        form.Dispose()
    End Sub

    Private Sub bridgeNoteButton_Click(sender As Object, e As EventArgs) Handles bridgeNoteButton.Click
        Dim form As New BridgeNoteHistoryForm
        form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
        form.ShowDialog(Me)
        form.Dispose()
    End Sub

    Private Sub editBridgeButton_Click(sender As Object, e As EventArgs) Handles editBridgeButton.Click
        Dim form As New BridgeEditForm
        form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
        form.setParentForm(Me)
        form.ShowDialog(Me)
        form.Dispose()
    End Sub

    Private Sub editBridgeNoteButton_Click(sender As Object, e As EventArgs) Handles editBridgeNoteButton.Click
        Dim form As New BridgeNoteEditForm
        form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
        form.setParentForm(Me)
        form.ShowDialog(Me)
        form.Dispose()
        Me.setNextInspectionYear()
    End Sub

    Private Sub openDirectoryButton_Click(sender As Object, e As EventArgs) Handles openDirectoryButton.Click
        Dim setting As Setting = Setting.getInstance
        Dim db As New bridgemanagementEntities
        Dim ent As inspection = db.inspection.Find(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
        If ent IsNot Nothing AndAlso ent.datasavedir.Length > 0 Then
            System.Diagnostics.Process.Start(Path.Combine(setting.SaveDirectoryPath, ent.datasavedir))
        Else
            MsgBox("点検データの登録がありません。")
        End If
    End Sub

    Private Sub setNextInspectionYear()
        Me.inspectionYearComboBox.Items.Clear()
        Dim db As New bridgemanagementEntities
        Dim yearCandidate As ArrayList = New ArrayList
        For Each ent In db.bridgenote.Where(Function(n) n.nextinspection > 0)
            If Not yearCandidate.Contains(ent.nextinspection) Then
                yearCandidate.Add(ent.nextinspection)
            End If
        Next
        For Each ent In db.inspection
            If Not yearCandidate.Contains(ent.inspectionyear + Me.setting.Inspectionspan) Then
                yearCandidate.Add(ent.inspectionyear + Me.setting.Inspectionspan)
            End If
        Next
        yearCandidate.Sort()
        Me.inspectionYearComboBox.Items.AddRange(yearCandidate.ToArray)
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Me.designationYear = Me.inspectionYearComboBox.SelectedItem
        Me.updateDatasource()
    End Sub

    Private Sub exportButton_Click(sender As Object, e As EventArgs) Handles exportButton.Click
        Dim colCount = Me.DataGridView1.ColumnCount
        If colCount > 0 Then
            For i = 0 To colCount - 1
                MsgBox(Me.DataGridView1.Columns(i).HeaderText, vbOKOnly, "実験中")
            Next
            For Each row As DataGridViewRow In Me.DataGridView1.SelectedRows
                For i = 0 To colCount - 1
                    MsgBox(Me.DataGridView1(i, row.Index).Value, vbOKOnly, "実験中")
                Next
            Next
        Else
            MsgBox("行を選択してください。", vbOKOnly, "実験中")
        End If
    End Sub

    Private Sub archiveButton_Click(sender As Object, e As EventArgs) Handles archiveButton.Click
        MsgBox("この機能は未実装です。")
        Return
    End Sub

    Private Sub searchCancelButton_Click(sender As Object, e As EventArgs) Handles searchCancelButton.Click
        Me.designationYear = 0
        Me.inspectionYearComboBox.Text = Nothing
        Me.updateDatasource()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.updateDatasource()
    End Sub

    ''' SQLをサニタイジングする。
    Public Function SSQL(ByVal value As String) As String

        If IsNothing(value) = True Then
            value = ""
        End If

        Dim ret As String = value.Replace("'", "''")


        ret = ret.Replace(";", "")

        Return ret
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Me.DataGridView1.DefaultCellStyle.Font = New Font("MS UI Gothic", NumericUpDown1.Value)
        'グリッドのサイズを自動調整
        Me.DataGridView1.AutoResizeRows()
        Me.DataGridView1.AutoResizeColumns()


    End Sub
End Class
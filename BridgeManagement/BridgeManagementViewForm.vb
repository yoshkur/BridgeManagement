Public Class BridgeManagementViewForm
	Private setting As Setting = Setting.getInstance

	Private Sub updateDatasource()
		Dim db As New bridgemanagementEntities
		Dim bs As New BindingSource
		For Each ent In db.bridgemanagementview
			bs.Add(ent)
		Next
		Me.DataGridView1.DataSource = bs
	End Sub

	Private Sub BridgeManagementViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.updateDatasource()
		Me.setNextInspectionYear()
	End Sub

	Private Sub inspectionHistoryButton_Click(sender As Object, e As EventArgs) Handles inspectionHistoryButton.Click
		Dim form As New InspectionHistoryForm
		form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
		form.ShowDialog(Me)
		form.Dispose()
		Me.updateDatasource()
	End Sub

	Private Sub bridgeHistoryButton_Click(sender As Object, e As EventArgs) Handles bridgeHistoryButton.Click
		Dim form As New BridgeHistoryForm
		form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
		form.ShowDialog(Me)
		form.Dispose()
		Me.updateDatasource()
	End Sub

	Private Sub bridgeNoteButton_Click(sender As Object, e As EventArgs) Handles bridgeNoteButton.Click
		Dim form As New BridgeNoteHistoryForm
		form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
		form.ShowDialog(Me)
		form.Dispose()
		Me.updateDatasource()
	End Sub

	Private Sub editBridgeButton_Click(sender As Object, e As EventArgs) Handles editBridgeButton.Click
		Dim form As New BridgeEditForm
		form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
		form.ShowDialog(Me)
		form.Dispose()
		Me.updateDatasource()
	End Sub

	Private Sub editBridgeNoteButton_Click(sender As Object, e As EventArgs) Handles editBridgeNoteButton.Click
		Dim form As New BridgeNoteEditForm
		form.setDataSource(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
		form.ShowDialog(Me)
		form.Dispose()
		Me.updateDatasource()
		Me.setNextInspectionYear()
	End Sub

	Private Sub openDirectoryButton_Click(sender As Object, e As EventArgs) Handles openDirectoryButton.Click
		Dim db As New bridgemanagementEntities
		Dim ent As inspection = db.inspection.Find(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
		If ent IsNot Nothing AndAlso ent.datasavedir.Length > 0 Then
			System.Diagnostics.Process.Start(ent.datasavedir)
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
		Try
			If Me.inspectionYearComboBox.SelectedItem Is Nothing Then
				MsgBox("調査年度を指定してください。")
				Return
			End If

			Dim db As New bridgemanagementEntities
			Dim bs As New BindingSource
			'Dim query = from ent In db.bridgemanagementview Where ent.nextinspection.Equals(Me.inspectionYearComboBox.SelectedItem) Or Me.inspectionYearComboBox.SelectedItem.Equals(ent.inspectionyear + Me.setting.Inspectionspan)
			'のように、LINQを利用すると動かなかったための措置。
			For Each ent In db.bridgemanagementview
				If ent.nextinspection.Equals(Me.inspectionYearComboBox.SelectedItem) Or Me.inspectionYearComboBox.SelectedItem.Equals(ent.inspectionyear + Me.setting.Inspectionspan) Then
					bs.Add(ent)
				End If
			Next
			Me.DataGridView1.DataSource = bs

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
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
End Class
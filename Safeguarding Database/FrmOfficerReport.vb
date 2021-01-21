Public Class FrmOfficerReport

    Private Sub FrmOfficerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Officer_dataset.Caseload' table. You can move, or remove it, as needed.
        Me.CaseloadTableAdapter.Fill(Me.Officer_dataset.Caseload)
        btnFilter.Height = 28
        btnFilter.Width = 70
        btnFilter.Location = New Point(365, 10)
        btnReset.Height = 28
        btnReset.Width = 70
        btnReset.Location = New Point(445, 10)
        txtFilterSearch.Height = 300
        txtFilterSearch.Width = 350
        txtFilterSearch.Location = New Point(10, 10)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            If Not String.IsNullOrEmpty(txtFilterSearch.Text) Then
                Dim keyword As String = Me.txtFilterSearch.Text.Trim
                Me.CaseloadBindingSource.Filter =
                    "(Safeguardingofficer LIKE '%" & keyword & "%')"
                Me.ReportViewer1.RefreshReport()
            Else
                Dim Err As DialogResult
                Err = MessageBox.Show("Your filter did not match the criteria!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.CaseloadBindingSource.RemoveFilter()
                FrmOfficerReport_Load(sender, e)
            End If
        Catch ex As Exception
            Dim Err As DialogResult
            Err = MessageBox.Show("Your filter did not match the criteria!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.txtFilterSearch.Focus()
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.CaseloadBindingSource.RemoveFilter()
        Me.CaseloadBindingSource.Filter = Nothing
        FrmOfficerReport_Load(sender, e)
        txtFilterSearch.Clear()
    End Sub

    Private Sub txtFilterSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilterSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnFilter.PerformClick()
        End If
    End Sub
End Class
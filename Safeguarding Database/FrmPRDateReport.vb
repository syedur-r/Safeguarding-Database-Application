Public Class FrmPRDateReport

    Private Sub FrmPRDateReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pastreviewdate_dataset.Caseload' table. You can move, or remove it, as needed.
        Me.CaseloadTableAdapter.Fill(Me.Pastreviewdate_dataset.Caseload)
        btnFilter.Height = 28
        btnFilter.Width = 70
        btnFilter.Location = New Point(290, 7)
        btnReset.Height = 28
        btnReset.Width = 70
        btnReset.Location = New Point(370, 7)
        lblSelectDate.Location = New Point(10, 10)
        DTPPastDate.Location = New Point(120, 7)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            If Not String.IsNullOrEmpty(DTPPastDate.Value) Then
                Dim keyword As String = Me.DTPPastDate.Value
                Me.CaseloadBindingSource.Filter =
                  "[Dateofreferral] >= '" & keyword & "' and [Dateofreferral] <= '" & keyword & "'"
                Me.ReportViewer1.RefreshReport()
            Else
                Dim Err As DialogResult
                Err = MessageBox.Show("Your filter did not match the criteria!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.CaseloadBindingSource.RemoveFilter()
                FrmPRDateReport_Load(sender, e)
            End If
        Catch ex As Exception
            Dim Err As DialogResult
            Err = MessageBox.Show("Your filter did not match the criteria!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.DTPPastDate.Focus()
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.CaseloadBindingSource.RemoveFilter()
        Me.CaseloadBindingSource.Filter = Nothing
        FrmPRDateReport_Load(sender, e)
    End Sub

    Private Sub txtFilterSearch_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnFilter.PerformClick()
        End If
    End Sub
End Class
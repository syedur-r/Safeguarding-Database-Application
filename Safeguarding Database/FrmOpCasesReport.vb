Public Class FrmOpCasesReport

    Private Sub FrmOpCasesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Opencases_dataset.Caseload' table. You can move, or remove it, as needed.
        Me.CaseloadTableAdapter.Fill(Me.Opencases_dataset.Caseload)
        btnReset.Height = 28
        btnReset.Width = 70
        btnReset.Location = New Point(270, 10)
        cmbFilter.Text = "      --- Select Filter Criteria ---"
        cmbFilter.Location = New Point(10, 10)
        DTPOpenDate.Location = New Point(110, 7)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnFilterDate_Click(sender As Object, e As EventArgs) Handles btnFilterDate.Click
        Try

            If Not String.IsNullOrEmpty(DTPOpenDate.Value) Then
                Dim keyword As String = Me.DTPOpenDate.Value
                Me.CaseloadBindingSource.Filter =
                    "[Dateofdisclosure] >= '" & keyword & "' and [Dateofdisclosure] <= '" & keyword & "'"
                Me.ReportViewer1.RefreshReport()
            ElseIf Not String.IsNullOrEmpty(DTPOpenDate.Value) Then
                Dim keyword As String = Me.DTPOpenDate.Value
                Me.CaseloadBindingSource.Filter =
                    "[Dateofdisclosure] >= '" & keyword & "' and [Dateofdisclosure] <= '" & keyword & "'"
                Me.ReportViewer1.RefreshReport()
            Else
                Dim Err As DialogResult
                Err = MessageBox.Show("Your filter did not match the criteria!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.CaseloadBindingSource.RemoveFilter()
                FrmOpCasesReport_Load(sender, e)
            End If
        Catch ex As Exception
            Dim Err As DialogResult
            Err = MessageBox.Show("Your filter did not match the criteria!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.DTPOpenDate.Focus()
        End Try
    End Sub

    Private Sub btnFilterText_Click(sender As Object, e As EventArgs) Handles btnFilterText.Click
        Try
            If cmbFilter.Text = "First Name" Then
                Dim keyword As String = Me.txtFilterSearch.Text.Trim
                Me.CaseloadBindingSource.Filter =
                    "(Firstname LIKE '%" & keyword & "%')"
                Me.ReportViewer1.RefreshReport()
            ElseIf cmbFilter.Text = "Type of Abuse" Then
                Dim keyword As String = Me.txtFilterSearch.Text.Trim
                Me.CaseloadBindingSource.Filter =
                    "(Typeofabuse LIKE '%" & keyword & "%')"
                Me.ReportViewer1.RefreshReport()
            Else
                Dim Err As DialogResult
                Err = MessageBox.Show("Your filter did not match the criteria!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.CaseloadBindingSource.RemoveFilter()
                FrmOpCasesReport_Load(sender, e)
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
        FrmOpCasesReport_Load(sender, e)
        txtFilterSearch.Clear()
        cmbFilter.Text = "      --- Select Filter Criteria ---"
        txtFilterSearch.Hide()
        btnFilterText.Hide()
        lblSelectDate.Hide()
        DTPOpenDate.Hide()
        btnFilterDate.Hide()
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        If cmbFilter.Text = "First Name" Then
            txtFilterSearch.Show()
            txtFilterSearch.Clear()
            txtFilterSearch.AutoCompleteMode = AutoCompleteMode.None
            btnFilterText.Show()
            txtFilterSearch.Location = New Point(10, 50)
            btnFilterText.Height = 28
            btnFilterText.Width = 70
            btnFilterText.Location = New Point(270, 50)
            lblSelectDate.Hide()
            DTPOpenDate.Hide()
            btnFilterDate.Hide()
        ElseIf cmbFilter.Text = "Type of Abuse" Then
            txtFilterSearch.Show()
            txtFilterSearch.Clear()
            txtFilterSearch.AutoCompleteMode = AutoCompleteMode.Suggest
            btnFilterText.Show()
            txtFilterSearch.Location = New Point(10, 50)
            btnFilterText.Height = 28
            btnFilterText.Width = 70
            btnFilterText.Location = New Point(270, 50)
            lblSelectDate.Hide()
            DTPOpenDate.Hide()
            btnFilterDate.Hide()
        ElseIf cmbFilter.Text = "Date of Disclosure" Then
            lblSelectDate.Show()
            DTPOpenDate.Show()
            btnFilterDate.Show()
            lblSelectDate.Location = New Point(10, 50)
            DTPOpenDate.Location = New Point(110, 47)
            btnFilterDate.Height = 28
            btnFilterDate.Width = 70
            btnFilterDate.Location = New Point(280, 47)
            txtFilterSearch.Hide()
            btnFilterText.Hide()
        End If
    End Sub

    Private Sub DTPOpenDate_KeyDown(sender As Object, e As KeyEventArgs) Handles DTPOpenDate.KeyDown
        If cmbFilter.Text = "Date of Disclosure" Then
            If e.KeyCode = Keys.Enter Then
                btnFilterDate.PerformClick()
            End If
        End If
    End Sub

    Private Sub txtFilterSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilterSearch.KeyDown
        If cmbFilter.Text = "First Name" Then
            If e.KeyCode = Keys.Enter Then
                btnFilterText.PerformClick()
            End If
        End If
        If cmbFilter.Text = "Type of Abuse" Then
            If e.KeyCode = Keys.Enter Then
                btnFilterText.PerformClick()
            End If
        End If
    End Sub
End Class
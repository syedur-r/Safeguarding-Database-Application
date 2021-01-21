Imports System.ComponentModel
Imports System.Data.OleDb

Public Class FrmCaseload

    'Safeguarding Application | New City College
    'Developed by Syedur Rahman | CityTec
    '13/12/17
    '@ Copyright 2017-18 Syedur Rahman
    '**********************************************************

    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim FilterDialog As DialogResult
    Dim FilterDialog1 As DialogResult

    Dim ExtendedDetails As String
    Dim ExtendedAction As String  'Assigns Details, Ongoing Action, Update textbox data to their multiline textboxes
    Dim ExtendedUpdate As String

    Dim intid As Integer 'Generates Auto Number

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Safeguarding_17_18_DatabaseDataSet.Caseload' table. You can move, or remove it, as needed.
        Me.CaseloadTableAdapter.Fill(Me._Safeguarding_17_18_DatabaseDataSet.Caseload)
        With CaseloadDataGridView
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
            .DataSource = CaseloadBindingSource
        End With
        AnimationTimer.Start()
        Me.Height = 730
        Me.Width = 1020
        Me.MinimumSize = New Size(1020, 730)
        Me.MaximumSize = New Size(1020, 730)
        Me.StartPosition = FormStartPosition.CenterScreen
        lblRealDate.Text = Format(Now, "dd/MM/yyyy")
        btnCaseload.BackColor = Color.FromArgb(0, 0, 102)
        GroupBox6.BringToFront()
        txtDataSearch.Visible = True
        btnDataSearch.Visible = True
        txtDataSearch.BringToFront()
        txtDataSearch.Show()
        btnDataSearch.BringToFront()
        btnDataSearch.Show()
        btnAddCase.Height = 28
        btnAddCase.Width = 122
        btnEdit.Height = 28
        btnEdit.Width = 72
        btnSave.Height = 28
        btnSave.Width = 85
        btnSave.Location = New Point(770, 50)
        btnClearPage.Height = 28
        btnClearPage.Width = 98
        btnClearPage.Location = New Point(860, 50)
        btnSave.Hide()
        btnClearPage.Hide()
        btnResetEdit.Hide()
        btnDataSearch.Height = 28
        btnDataSearch.Width = 82
        btnAttachFile.Height = 26
        btnAttachFile.Width = 30
        btnAttachFile.Hide()
        txtDataSearch.Location = New Point(690, 150)
        cmbFilter.Text = "     --- Select Search Criteria ---"
        txtAgeofDiscl.Clear()
        cmbFilter.Visible = True
        cmbFilter.BringToFront()
        btnReset.Visible = True
        btnReset.BringToFront()
        btnReset.Show()
        btnReset.Height = 28
        btnReset.Width = 82
        btnReset.Location = New Point(330, 150)
        cmbFilter.Show()
        GroupBox6.Show()
        GroupBox1.Show()
        GroupBox7.Hide()
        Me.CaseloadBindingSource.Filter = Nothing
        Me.CaseloadTableAdapter.Fill(Me._Safeguarding_17_18_DatabaseDataSet.Caseload)

        btnInputDetails.Enabled = False
        txtFirstName.ReadOnly = True
        txtMiddleName.ReadOnly = True
        txtLastName.ReadOnly = True
        DTPDOB.Enabled = False
        txtStudentID.ReadOnly = True
        DTPDOD.Enabled = False
        txtNameofStaff.ReadOnly = True
        cmbTypeofAbuse.Enabled = False
        CbxCurrentStu.AutoCheck = False
        cmbSafeOfficer.Enabled = False
        cbxWasReferred.AutoCheck = False
        DTPDOF.Enabled = False
        txtReferredTo.ReadOnly = True
        txtDetails.ReadOnly = True
        txtOngoingAction.ReadOnly = True
        txtUpdate.ReadOnly = True
        txtExpandDetails.ReadOnly = True
        txtExpandOnAction.ReadOnly = True
        txtExpandUpdate.ReadOnly = True
        DTPReviewDate.Enabled = False
        cbxPaperworkComp.AutoCheck = False
        cbxCaseClosed.AutoCheck = False
        cmbRAG.Enabled = False
        AttachmentPanel.Visible = False

        ExtendedDetails = txtDetails.Text
        txtExpandDetails.Text = ExtendedDetails

        ExtendedAction = txtOngoingAction.Text
        txtExpandOnAction.Text = ExtendedAction

        ExtendedUpdate = txtUpdate.Text
        txtExpandUpdate.Text = ExtendedUpdate
    End Sub

#Region "Save Data"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="

        Try
            datafile = "F:\Programming projects (vb)\Safeguarding Database\Safeguarding Database\Safeguarding Database\Safeguarding 17-18 Database.accdb"
        Finally
            datafile = "F:\Programming projects (vb)\Safeguarding Database\Safeguarding Database\Safeguarding Database\Safeguarding 17-18 Database.accdb"
        End Try

        connString = provider & datafile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into Caseload([ID], [First Name], [Middle Name], [Last Name], [Date of Birth], [Student ID], [Current Student], [Date of Disclosure], [Name of Staff Taking Disclosure], [Type of Abuse], [Age at Disclosure], [Safeguarding Officer], [Was Referred], [Referred To], [Date of Referral], [Details], [Ongoing Action], [Update], [Review Date], [Paperwork Completed], [Case Closed], [RAG]) Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("ID", CType(txtID.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("First Name", CType(txtFirstName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Middle Name", CType(txtMiddleName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Last Name", CType(txtLastName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date of Birth", CType(DTPDOB.Value, Date)))
        cmd.Parameters.Add(New OleDbParameter("Student ID", CType(txtStudentID.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Current Student", CType(CbxCurrentStu.CheckState, String)))
        cmd.Parameters.Add(New OleDbParameter("Date of Disclosure", CType(DTPDOD.Value, Date)))
        cmd.Parameters.Add(New OleDbParameter("Name of Staff Taking Disclosure", CType(txtNameofStaff.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Type of Abuse", CType(cmbTypeofAbuse.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Age at Disclosure", CType(txtAgeofDiscl.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Safeguarding Officer", CType(cmbSafeOfficer.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Was Referred", CType(cbxWasReferred.CheckState, String)))
        cmd.Parameters.Add(New OleDbParameter("Referred To", CType(txtReferredTo.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date of Referral", CType(DTPDOF.Value, Date)))
        cmd.Parameters.Add(New OleDbParameter("Details", CType(txtDetails.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Ongoing Action", CType(txtOngoingAction.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Update", CType(txtUpdate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Review Date", CType(DTPReviewDate.Value, Date)))
        cmd.Parameters.Add(New OleDbParameter("Paperwork Completed", CType(cbxPaperworkComp.CheckState, String)))
        cmd.Parameters.Add(New OleDbParameter("Case Closed", CType(cbxCaseClosed.CheckState, String)))
        cmd.Parameters.Add(New OleDbParameter("RAG", CType(cmbRAG.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            txtID.Clear()
            txtFirstName.Clear()
            txtMiddleName.Clear()
            txtLastName.Clear()
            DTPDOB.Value = "01/01/2018"
            txtStudentID.Clear()
            DTPDOD.Value = "01/01/2018"
            txtAgeofDiscl.Clear()
            txtNameofStaff.Clear()
            cmbTypeofAbuse.ResetText()
            CbxCurrentStu.CheckState = CheckState.Unchecked
            cmbSafeOfficer.ResetText()
            cbxWasReferred.CheckState = CheckState.Unchecked
            DTPDOF.Value = "01/01/2018"
            txtReferredTo.Clear()
            txtDetails.Clear()
            txtOngoingAction.Clear()
            txtUpdate.Clear()
            DTPReviewDate.Value = "01/01/2018"
            cbxPaperworkComp.CheckState = CheckState.Unchecked
            cbxCaseClosed.CheckState = CheckState.Unchecked
            cmbRAG.ResetText()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Validate()
        Me.CaseloadBindingSource.EndEdit()
        Me.CaseloadTableAdapter.Update(_Safeguarding_17_18_DatabaseDataSet)

        Me.CaseloadDataGridView.EndEdit()
        Me.CaseloadDataGridView.Refresh()
        Me.CaseloadDataGridView.Update()
        Beep()
        Dim Success As DialogResult
        Success = MessageBox.Show("Your details have successfully been added! Please re-open the application to view the updated data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.ExitThread()
    End Sub
#End Region

#Region "Edit Data"
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnCaseload.BackColor = Color.FromArgb(80, 110, 148)
        btnAbuseType.BackColor = Color.FromArgb(80, 110, 148)
        btnOfficer.BackColor = Color.FromArgb(80, 110, 148)
        btnOpenCases.BackColor = Color.FromArgb(80, 110, 148)
        btnPRDate.BackColor = Color.FromArgb(80, 110, 148)
        btnFormView.BackColor = Color.FromArgb(0, 0, 102)
        GroupBox6.SendToBack()
        GroupBox6.Hide()
        GroupBox1.Hide()
        GroupBox7.Show()
        GroupBox7.Location = New Point(2, 135)
        txtDataSearch.Visible = False
        btnDataSearch.Visible = False
        txtDataSearch.SendToBack()
        txtDataSearch.Hide()
        btnDataSearch.SendToBack()
        btnDataSearch.Hide()
        cmbFilter.Visible = False
        cmbFilter.SendToBack()
        cmbFilter.Hide()
        btnReset.Visible = False
        btnReset.SendToBack()
        btnReset.Hide()
        btnUpdate.Show()
        btnUpdate.Height = 28
        btnUpdate.Width = 85
        btnUpdate.Location = New Point(770, 50)
        btnResetEdit.Show()
        btnResetEdit.Height = 28
        btnResetEdit.Width = 98
        btnResetEdit.Location = New Point(860, 50)
        btnSave.Hide()
        btnClearPage.Hide()
        btnAttachFile.Hide()

        btnInputDetails.Enabled = True
        txtFirstName.ReadOnly = False
        txtMiddleName.ReadOnly = False
        txtLastName.ReadOnly = False
        DTPDOB.Enabled = True
        txtStudentID.ReadOnly = False
        DTPDOD.Enabled = True
        txtNameofStaff.ReadOnly = False
        cmbTypeofAbuse.Enabled = True
        CbxCurrentStu.AutoCheck = True
        cmbSafeOfficer.Enabled = True
        cbxWasReferred.AutoCheck = True
        DTPDOF.Enabled = True
        txtReferredTo.ReadOnly = False
        txtDetails.ReadOnly = False
        txtOngoingAction.ReadOnly = False
        txtUpdate.ReadOnly = False
        txtExpandDetails.ReadOnly = False
        txtExpandOnAction.ReadOnly = False
        txtExpandUpdate.ReadOnly = False
        DTPReviewDate.Enabled = True
        cbxPaperworkComp.AutoCheck = True
        cbxCaseClosed.AutoCheck = True
        cmbRAG.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ExtendedDetails = String.Empty Then
            txtDetails.Text = txtDetails.Text
        End If
        If ExtendedAction = String.Empty Then
            txtOngoingAction.Text = txtOngoingAction.Text
        End If
        If ExtendedUpdate = String.Empty Then
            txtUpdate.Text = txtUpdate.Text
        End If

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="

        Try
            datafile = "E:\Programming projects (vb)\Safeguarding Database\Safeguarding Database\Safeguarding Database\Safeguarding 17-18 Database.accdb"
        Finally
            datafile = "E:\Programming projects (vb)\Safeguarding Database\Safeguarding Database\Safeguarding Database\Safeguarding 17-18 Database.accdb"
        End Try

        connString = provider & datafile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str3 As String
        str3 = "Update [Caseload] set [First Name] = '" & txtFirstName.Text & "', [Middle Name] = '" & txtMiddleName.Text & "', [Last Name] = '" & txtLastName.Text & "', [Date of Birth] = '" & DTPDOB.Value & "', [Student ID] = '" & txtStudentID.Text & "', [Current Student] = '" & CbxCurrentStu.CheckState & "', [Date of Disclosure] = '" & DTPDOD.Value & "', [Name of Staff Taking Disclosure] = '" & txtNameofStaff.Text & "', [Type of Abuse] = '" & cmbTypeofAbuse.Text & "', [Age at Disclosure] = '" & txtAgeofDiscl.Text & "', [Safeguarding Officer] = '" & cmbSafeOfficer.Text & "', [Was Referred] = '" & cbxWasReferred.CheckState & "', [Referred To] = '" & txtReferredTo.Text & "', [Date of Referral] = '" & DTPDOF.Value & "', [Details] = '" & txtDetails.Text & "', [Ongoing Action] = '" & txtOngoingAction.Text & "', [Update] = '" & txtUpdate.Text & "', [Review Date] = '" & DTPReviewDate.Value & "', [Paperwork Completed] = '" & cbxPaperworkComp.CheckState & "', [Case Closed] = '" & cbxCaseClosed.CheckState & "', [RAG] = '" & cmbRAG.Text & "' WHERE [ID] = " & txtID.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str3, myConnection)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            txtID.Clear()
            txtFirstName.Clear()
            txtMiddleName.Clear()
            txtLastName.Clear()
            DTPDOB.ResetText()
            txtStudentID.Clear()
            DTPDOD.ResetText()
            txtAgeofDiscl.Clear()
            txtNameofStaff.Clear()
            cmbTypeofAbuse.ResetText()
            CbxCurrentStu.CheckState = CheckState.Unchecked
            cmbSafeOfficer.ResetText()
            cbxWasReferred.CheckState = CheckState.Unchecked
            DTPDOF.ResetText()
            txtReferredTo.Clear()
            txtDetails.Clear()
            txtOngoingAction.Clear()
            txtUpdate.Clear()
            DTPReviewDate.ResetText()
            cbxPaperworkComp.CheckState = CheckState.Unchecked
            cbxCaseClosed.CheckState = CheckState.Unchecked
            cmbRAG.ResetText()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Validate()
        Me.CaseloadBindingSource.EndEdit()
        Me.CaseloadTableAdapter.Update(_Safeguarding_17_18_DatabaseDataSet)

        Me.CaseloadDataGridView.EndEdit()
        Me.CaseloadDataGridView.Refresh()
        Me.CaseloadDataGridView.Update()
        Beep()
        Dim Success As DialogResult
        Success = MessageBox.Show("Your details have successfully been updated! Please re-open the application to view the updated data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.ExitThread()
    End Sub
#End Region

#Region "Clear Form Page"
    Private Sub ClearPage_Click(sender As Object, e As EventArgs) Handles btnClearPage.Click
        txtID.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        DTPDOB.Value = "01/01/2018"
        txtStudentID.Clear()
        DTPDOD.Value = "01/01/2018"
        txtAgeofDiscl.Clear()
        txtNameofStaff.Clear()
        cmbTypeofAbuse.ResetText()
        CbxCurrentStu.CheckState = CheckState.Unchecked
        cmbSafeOfficer.ResetText()
        cbxWasReferred.CheckState = CheckState.Unchecked
        DTPDOF.Value = "01/01/2018"
        txtReferredTo.Clear()
        txtDetails.Clear()
        txtOngoingAction.Clear()
        txtUpdate.Clear()
        DTPReviewDate.Value = "01/01/2018"
        cbxPaperworkComp.CheckState = CheckState.Unchecked
        cbxCaseClosed.CheckState = CheckState.Unchecked
        cmbRAG.ResetText()
        ErrorProvider1.Clear()
        ErrorProvider2.Clear()
        ErrorProvider3.Clear()
        ErrorProvider4.Clear()
        ErrorProvider5.Clear()
        ErrorProvider6.Clear()
        Me.CaseloadBindingSource.RemoveCurrent()
        Me.CaseloadTableAdapter.Fill(Me._Safeguarding_17_18_DatabaseDataSet.Caseload)
        btnSave.Hide()
        AttachmentPanel.Visible = False
        btnAttachFile.Hide()
        btnClearPage.Hide()
        btnFormView.Select()

        btnInputDetails.Enabled = False
        txtFirstName.ReadOnly = True
        txtMiddleName.ReadOnly = True
        txtLastName.ReadOnly = True
        DTPDOB.Enabled = False
        txtStudentID.ReadOnly = True
        DTPDOD.Enabled = False
        txtNameofStaff.ReadOnly = True
        cmbTypeofAbuse.Enabled = False
        CbxCurrentStu.AutoCheck = False
        cmbSafeOfficer.Enabled = False
        cbxWasReferred.AutoCheck = False
        DTPDOF.Enabled = False
        txtReferredTo.ReadOnly = True
        txtDetails.ReadOnly = True
        txtOngoingAction.ReadOnly = True
        txtUpdate.ReadOnly = True
        txtExpandDetails.ReadOnly = True
        txtExpandOnAction.ReadOnly = True
        txtExpandUpdate.ReadOnly = True
        DTPReviewDate.Enabled = False
        cbxPaperworkComp.AutoCheck = False
        cbxCaseClosed.AutoCheck = False
        cmbRAG.Enabled = False

        ExtendedDetails = txtDetails.Text
        txtExpandDetails.Text = ExtendedDetails

        ExtendedAction = txtOngoingAction.Text
        txtExpandOnAction.Text = ExtendedAction

        ExtendedUpdate = txtUpdate.Text
        txtExpandUpdate.Text = ExtendedUpdate
    End Sub

    Private Sub btnResetEdit_Click(sender As Object, e As EventArgs) Handles btnResetEdit.Click
        txtID.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        DTPDOB.Value = "01/01/2018"
        txtStudentID.Clear()
        DTPDOD.Value = "01/01/2018"
        txtAgeofDiscl.Clear()
        txtNameofStaff.Clear()
        cmbTypeofAbuse.ResetText()
        CbxCurrentStu.CheckState = CheckState.Unchecked
        cmbSafeOfficer.ResetText()
        cbxWasReferred.CheckState = CheckState.Unchecked
        DTPDOF.Value = "01/01/2018"
        txtReferredTo.Clear()
        txtDetails.Clear()
        txtOngoingAction.Clear()
        txtUpdate.Clear()
        DTPReviewDate.Value = "01/01/2018"
        cbxPaperworkComp.CheckState = CheckState.Unchecked
        cbxCaseClosed.CheckState = CheckState.Unchecked
        cmbRAG.ResetText()
        ErrorProvider1.Clear()
        ErrorProvider2.Clear()
        ErrorProvider3.Clear()
        ErrorProvider4.Clear()
        ErrorProvider5.Clear()
        ErrorProvider6.Clear()
        Me.CaseloadTableAdapter.Fill(Me._Safeguarding_17_18_DatabaseDataSet.Caseload)
        btnUpdate.Hide()
        btnResetEdit.Hide()
        btnFormView.Select()

        btnInputDetails.Enabled = False
        txtFirstName.ReadOnly = True
        txtMiddleName.ReadOnly = True
        txtLastName.ReadOnly = True
        DTPDOB.Enabled = False
        txtStudentID.ReadOnly = True
        DTPDOD.Enabled = False
        txtNameofStaff.ReadOnly = True
        cmbTypeofAbuse.Enabled = False
        CbxCurrentStu.AutoCheck = False
        cmbSafeOfficer.Enabled = False
        cbxWasReferred.AutoCheck = False
        DTPDOF.Enabled = False
        txtReferredTo.ReadOnly = True
        txtDetails.ReadOnly = True
        txtOngoingAction.ReadOnly = True
        txtUpdate.ReadOnly = True
        txtExpandDetails.ReadOnly = True
        txtExpandOnAction.ReadOnly = True
        txtExpandUpdate.ReadOnly = True
        DTPReviewDate.Enabled = False
        cbxPaperworkComp.AutoCheck = False
        cbxCaseClosed.AutoCheck = False
        cmbRAG.Enabled = False

        ExtendedDetails = txtDetails.Text
        txtExpandDetails.Text = ExtendedDetails

        ExtendedAction = txtOngoingAction.Text
        txtExpandOnAction.Text = ExtendedAction

        ExtendedUpdate = txtUpdate.Text
        txtExpandUpdate.Text = ExtendedUpdate
    End Sub
#End Region

#Region "CityTec Logo"
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles CityTecLogo.Click
        Process.Start("http://www.citytec.uk/")
    End Sub
#End Region

#Region "FormView"
    Private Sub btnFormView_Click(sender As Object, e As EventArgs) Handles btnFormView.Click
        btnCaseload.BackColor = Color.FromArgb(80, 110, 148)
        btnAbuseType.BackColor = Color.FromArgb(80, 110, 148)
        btnOfficer.BackColor = Color.FromArgb(80, 110, 148)
        btnOpenCases.BackColor = Color.FromArgb(80, 110, 148)
        btnPRDate.BackColor = Color.FromArgb(80, 110, 148)
        btnFormView.BackColor = Color.FromArgb(0, 0, 102)
        GroupBox6.SendToBack()
        GroupBox6.Hide()
        GroupBox1.Hide()
        GroupBox7.Show()
        GroupBox7.Location = New Point(2, 135)
        txtDataSearch.Visible = False
        btnDataSearch.Visible = False
        txtDataSearch.SendToBack()
        txtDataSearch.Hide()
        btnDataSearch.SendToBack()
        btnDataSearch.Hide()
        cmbFilter.Visible = False
        cmbFilter.SendToBack()
        cmbFilter.Hide()
        btnReset.Visible = False
        btnReset.SendToBack()
        btnReset.Hide()
    End Sub
#End Region

#Region "Grid View Buttons"
    Private Sub btnAddCase_Click(sender As Object, e As EventArgs) Handles btnAddCase.Click
        Me.CaseloadBindingSource.AddNew()

        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        DTPDOB.Value = "01/01/2018"
        txtStudentID.Clear()
        DTPDOD.Value = "01/01/2018"
        txtAgeofDiscl.Clear()
        txtNameofStaff.Clear()
        cmbTypeofAbuse.ResetText()
        CbxCurrentStu.CheckState = CheckState.Unchecked
        cmbSafeOfficer.ResetText()
        cbxWasReferred.CheckState = CheckState.Unchecked
        DTPDOF.Value = "01/01/2018"
        txtReferredTo.Clear()
        txtDetails.Clear()
        txtOngoingAction.Clear()
        txtUpdate.Clear()
        DTPReviewDate.Value = "01/01/2018"
        cbxPaperworkComp.CheckState = CheckState.Unchecked
        cbxCaseClosed.CheckState = CheckState.Unchecked
        cmbRAG.ResetText()

        btnCaseload.BackColor = Color.FromArgb(80, 110, 148)
        btnAbuseType.BackColor = Color.FromArgb(80, 110, 148)
        btnOfficer.BackColor = Color.FromArgb(80, 110, 148)
        btnOpenCases.BackColor = Color.FromArgb(80, 110, 148)
        btnPRDate.BackColor = Color.FromArgb(80, 110, 148)
        btnFormView.BackColor = Color.FromArgb(0, 0, 102)
        GroupBox6.SendToBack()
        GroupBox6.Hide()
        GroupBox1.Hide()
        GroupBox7.Show()
        GroupBox7.Location = New Point(2, 135)
        txtDataSearch.Visible = False
        btnDataSearch.Visible = False
        txtDataSearch.SendToBack()
        txtDataSearch.Hide()
        btnDataSearch.SendToBack()
        btnDataSearch.Hide()
        cmbFilter.Visible = False
        cmbFilter.SendToBack()
        cmbFilter.Hide()
        btnReset.Visible = False
        btnReset.SendToBack()
        btnReset.Hide()
        AttachmentPanel.Visible = True
        btnAttachFile.Show()
        btnSave.Show()
        btnSave.Height = 28
        btnSave.Width = 85
        btnSave.Location = New Point(770, 50)
        btnClearPage.Show()
        btnClearPage.Height = 28
        btnClearPage.Width = 98
        btnClearPage.Location = New Point(860, 50)
        btnUpdate.Hide()
        btnResetEdit.Hide()

        btnInputDetails.Enabled = True
        txtFirstName.ReadOnly = False
        txtMiddleName.ReadOnly = False
        txtLastName.ReadOnly = False
        DTPDOB.Enabled = True
        txtStudentID.ReadOnly = False
        DTPDOD.Enabled = True
        txtNameofStaff.ReadOnly = False
        cmbTypeofAbuse.Enabled = True
        CbxCurrentStu.AutoCheck = True
        cmbSafeOfficer.Enabled = True
        cbxWasReferred.AutoCheck = True
        DTPDOF.Enabled = True
        txtReferredTo.ReadOnly = False
        txtDetails.ReadOnly = False
        txtOngoingAction.ReadOnly = False
        txtUpdate.ReadOnly = False
        txtExpandDetails.ReadOnly = False
        txtExpandOnAction.ReadOnly = False
        txtExpandUpdate.ReadOnly = False
        DTPReviewDate.Enabled = True
        cbxPaperworkComp.AutoCheck = True
        cbxCaseClosed.AutoCheck = True
        cmbRAG.Enabled = True

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        Try
            datafile = "F:\Programming projects (vb)\Safeguarding Database\Safeguarding Database\Safeguarding Database\Safeguarding 17-18 Database.accdb"
        Finally
            datafile = "F:\Programming projects (vb)\Safeguarding Database\Safeguarding Database\Safeguarding Database\Safeguarding 17-18 Database.accdb"
        End Try
        connString = provider & datafile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str2 As String
        str2 = "Select from [Caseload] "
        Dim cmd As OleDbCommand = New OleDbCommand(str2, myConnection)
        Dim maxid As Object
        Dim strid As String

        cmd.CommandText = "Select Max (ID) from [Caseload] "

        maxid = cmd.ExecuteScalar
        If maxid Is DBNull.Value Then
            intid = 1
        Else
            strid = CType(maxid, String)
            intid = CType(strid, String)
            intid = intid + 1
            txtID.Enabled = False
        End If

        txtID.Text = intid
        txtID.Focus()

        myConnection.Close()
    End Sub
#End Region

#Region "Exit Application Dialogue Box"
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim ex As DialogResult
        Beep()
        ex = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If ex = DialogResult.Yes Then
            Application.ExitThread()
        End If
        If ex = DialogResult.No Then
            e.Cancel = True
        End If
        If ex = DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub
#End Region

#Region "Top Buttons (Form/Report View)"
    Private Sub btnCaseload_Click(sender As Object, e As EventArgs) Handles btnCaseload.Click
        btnCaseload.BackColor = Color.FromArgb(0, 0, 102)
        btnAbuseType.BackColor = Color.FromArgb(80, 110, 148)
        btnOfficer.BackColor = Color.FromArgb(80, 110, 148)
        btnOpenCases.BackColor = Color.FromArgb(80, 110, 148)
        btnPRDate.BackColor = Color.FromArgb(80, 110, 148)
        btnFormView.BackColor = Color.FromArgb(80, 110, 148)
        GroupBox6.BringToFront()
        GroupBox6.Show()
        GroupBox1.Show()
        GroupBox7.Hide()
        txtDataSearch.Visible = True
        btnDataSearch.Visible = True
        txtDataSearch.BringToFront()
        txtDataSearch.Show()
        btnDataSearch.BringToFront()
        btnDataSearch.Show()
        btnDataSearch.Height = 28
        btnDataSearch.Width = 82
        txtDataSearch.Location = New Point(690, 150)
        cmbFilter.Visible = True
        cmbFilter.BringToFront()
        cmbFilter.Show()
        btnReset.Visible = True
        btnReset.BringToFront()
        btnReset.Show()
        btnReset.Height = 28
        btnReset.Width = 82
        btnReset.Location = New Point(330, 150)
        GpxDetails.SendToBack()
        GpxDetails.Hide()
        GpxOnAction.SendToBack()
        GpxOnAction.Hide()
        GpxUpdate.SendToBack()
        GpxUpdate.Hide()
    End Sub

    Private Sub btnAbuseType_Click(sender As Object, e As EventArgs) Handles btnAbuseType.Click
        Dim display As New FrmAbuseReport
        display.TopMost = True
        display.Show()
    End Sub

    Private Sub btnOfficer_Click(sender As Object, e As EventArgs) Handles btnOfficer.Click
        Dim display As New FrmOfficerReport
        display.TopMost = True
        display.Show()
    End Sub

    Private Sub btnOpenCases_Click(sender As Object, e As EventArgs) Handles btnOpenCases.Click
        Dim display As New FrmOpCasesReport
        display.TopMost = True
        display.Show()
    End Sub

    Private Sub btnPRDate_Click(sender As Object, e As EventArgs) Handles btnPRDate.Click
        Dim display As New FrmPRDateReport
        display.TopMost = True
        display.Show()
    End Sub
#End Region

#Region "Form Animation"
    Private Sub AnimationTimer_Tick(sender As Object, e As EventArgs) Handles AnimationTimer.Tick
        Me.Opacity += 0.18
        If Me.Opacity = 1 Then
            AnimationTimer.Stop()
            AnimationTimer.Dispose()
        End If
    End Sub
#End Region

#Region "Input Boxes"
    Private Sub txtInputDetails_Click(sender As Object, e As EventArgs) Handles btnInputDetails.Click
        Dim FName As String
        Dim MName As String
        Dim LName As String
        Dim DOB As Date
        Dim StudentID As Integer
        Dim DOD As Date
        Dim StaffName As String

        FName = InputBox("Please Enter Student's First Name")
        MName = InputBox("Please Enter Student's Middle Name")
        LName = InputBox("Please Enter Student's Last Name")
        DOB = InputBox("Please Enter Student's Date of Birth")
        StudentID = InputBox("Please Enter Student's ID")
        DOD = InputBox("Please Enter Date of Disclosure")
        StaffName = InputBox("Please Enter The Name of Staff Taking Disclosure")

        txtFirstName.Text = FName
        txtMiddleName.Text = MName
        txtLastName.Text = LName
        DTPDOB.Value = DOB
        txtStudentID.Text = StudentID
        DTPDOD.Value = DOD
        txtNameofStaff.Text = StaffName
    End Sub
#End Region

#Region "Automatic Age Value"
    Private Sub DTPDOB_ValueChanged(sender As Object, e As EventArgs) Handles DTPDOB.ValueChanged
        Dim MyDOB As Date
        Dim CurrentDate As Date
        Dim DaysTime As TimeSpan
        Dim Difference As Double
        Dim MyAge As String

        MyDOB = DTPDOB.Value.ToShortDateString
        CurrentDate = Date.Today.ToShortDateString
        DaysTime = (CurrentDate - MyDOB)
        Difference = DaysTime.Days
        MyAge = Str(Int(Difference / 365))
        txtAgeofDiscl.Text = MyAge
    End Sub

    Private Sub DTPDOD_ValueChanged(sender As Object, e As EventArgs) Handles DTPDOD.ValueChanged
        Dim MyDOB As Date
        Dim DisclosureDate As Date
        Dim DaysTime As TimeSpan
        Dim Difference As Double
        Dim MyAge As String

        MyDOB = DTPDOB.Value.ToShortDateString
        DisclosureDate = DTPDOD.Value.ToShortDateString
        DaysTime = (DisclosureDate - MyDOB)
        Difference = DaysTime.Days
        MyAge = Str(Int(Difference / 365))
        txtAgeofDiscl.Text = MyAge
    End Sub
#End Region

#Region "Expand Textboxes"
    Private Sub btnExpandDetails_Click(sender As Object, e As EventArgs) Handles btnExpandDetails.Click
        GpxDetails.Visible = True
        GpxDetails.BringToFront()
        GpxDetails.Show()
        GpxDetails.Location = New Point(2, 145)
        GpxDetails.Width = 1000
        GpxDetails.Height = 540
        ExtendedDetails = txtDetails.Text
        txtExpandDetails.Text = ExtendedDetails
    End Sub

    Private Sub btnExpandDetailsBack_Click(sender As Object, e As EventArgs) Handles btnExpandDetailsBack.Click
        GpxDetails.SendToBack()
        GpxDetails.Visible = False
    End Sub

    Private Sub btnExDetailsOk_Click(sender As Object, e As EventArgs) Handles btnExDetailsOk.Click
        txtDetails.Text = txtExpandDetails.Text
        GpxDetails.SendToBack()
        GpxDetails.Visible = False
    End Sub

    Private Sub btnExpandOnAction_Click(sender As Object, e As EventArgs) Handles btnExpandOnAction.Click
        GpxOnAction.Visible = True
        GpxOnAction.BringToFront()
        GpxOnAction.Show()
        GpxOnAction.Location = New Point(2, 145)
        GpxOnAction.Width = 1000
        GpxOnAction.Height = 540
        ExtendedAction = txtOngoingAction.Text
        txtExpandOnAction.Text = ExtendedAction
    End Sub

    Private Sub btnExpandOnActionBack_Click(sender As Object, e As EventArgs) Handles btnExpandOnActionBack.Click
        GpxOnAction.SendToBack()
        GpxOnAction.Visible = False
    End Sub

    Private Sub btnOnActionOk_Click(sender As Object, e As EventArgs) Handles btnOnActionOk.Click
        txtOngoingAction.Text = txtExpandOnAction.Text
        GpxOnAction.SendToBack()
        GpxOnAction.Visible = False
    End Sub

    Private Sub btnExpandUpdate_Click(sender As Object, e As EventArgs) Handles btnExpandUpdate.Click
        GpxUpdate.Visible = True
        GpxUpdate.BringToFront()
        GpxUpdate.Show()
        GpxUpdate.Location = New Point(2, 145)
        GpxUpdate.Width = 1000
        GpxUpdate.Height = 540
        ExtendedUpdate = txtUpdate.Text
        txtExpandUpdate.Text = ExtendedUpdate
    End Sub

    Private Sub btnExpandUpdateBack_Click(sender As Object, e As EventArgs) Handles btnExpandUpdateBack.Click
        GpxUpdate.SendToBack()
        GpxUpdate.Visible = False
    End Sub

    Private Sub txtExpandUpdateOk_Click(sender As Object, e As EventArgs) Handles txtExpandUpdateOk.Click
        txtUpdate.Text = txtExpandUpdate.Text
        GpxUpdate.SendToBack()
        GpxUpdate.Visible = False
    End Sub
#End Region

#Region "Search Queries"
    Private Sub btnDataSearch_Click(sender As Object, e As EventArgs) Handles btnDataSearch.Click
        On Error GoTo SearchErr
        datagridfill()

        If txtDataSearch.Text = "" Then
            Call notFound()
            FilterDialog = False
            FilterDialog1 = MessageBox.Show("Please type a query into the search box", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbFilter.Text = "     --- Select Search Criteria ---"
            Exit Sub
        End If

        If cmbFilter.Text = "ID" Then
            Me.CaseloadBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & txtDataSearch.Text & "')"
        ElseIf cmbFilter.Text = "First Name" Then
            Me.CaseloadBindingSource.Filter = "[First Name] like '%" & txtDataSearch.Text & "%'"
        ElseIf cmbFilter.Text = "Middle Name" Then
            Me.CaseloadBindingSource.Filter = "[Middle Name] like '%" & txtDataSearch.Text & "%'"
        ElseIf cmbFilter.Text = "Last Name" Then
            Me.CaseloadBindingSource.Filter = "[Last Name] like '%" & txtDataSearch.Text & "%'"
        ElseIf cmbFilter.Text = "Date of Birth" Then
            Me.CaseloadBindingSource.Filter = "[Date of Birth] >= '" & txtDataSearch.Text & "' and [Date of Birth] <= '" & txtDataSearch.Text & "'"
        ElseIf cmbFilter.Text = "Name of Staff Taking Disclosure" Then
            Me.CaseloadBindingSource.Filter = "[Name of Staff Taking Disclosure] like '%" & txtDataSearch.Text & "%'"
        ElseIf cmbFilter.Text = "Type of Abuse" Then
            Me.CaseloadBindingSource.Filter = "[Type of Abuse] like '%" & txtDataSearch.Text & "%'"
        ElseIf cmbFilter.Text = "Safeguarding Officer" Then
            Me.CaseloadBindingSource.Filter = "[Safeguarding Officer] like '%" & txtDataSearch.Text & "%'"
        ElseIf cmbFilter.Text = "RAG" Then
            Me.CaseloadBindingSource.Filter = "[RAG] like '%" & txtDataSearch.Text & "%'"
        ElseIf cmbFilter.Text = "" OrElse cmbFilter.Text = "     --- Select Search Criteria ---" Then
            FilterDialog1 = False
            Me.notFound()
            Beep()
            FilterDialog = MessageBox.Show("Please select a filter from the list provided", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDataSearch.Clear()
        End If

        If CaseloadBindingSource.Count <> 0 Then
            With CaseloadDataGridView
                .DataSource = CaseloadBindingSource
            End With
        Else
            Me.notFound()
            Dim myDataGridViewReset As DataGridView = CaseloadDataGridView
            With myDataGridViewReset
                .RowsDefaultCellStyle.BackColor = Color.White
                .RowsDefaultCellStyle.ForeColor = Color.Black
            End With
            Dim ex As DialogResult
            ex = MessageBox.Show("Your search did not match the criteria!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim ex1 As DialogResult
            ex1 = MessageBox.Show("• Make sure that all the words are spelled correctly" & vbNewLine &
            "• Select a filter from the list provided" & vbNewLine & "• Try to use more general words",
            "Suggestions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDataSearch.Clear()
            txtDataSearch.Select()

            With CaseloadDataGridView
                .ClearSelection()
                .ReadOnly = True
                .MultiSelect = False
                .DataSource = CaseloadBindingSource
            End With

        End If

ErrExit:
        Exit Sub
SearchErr:
        Dim ex2 As DialogResult
        ex2 = MessageBox.Show("Error Number " & Err.Number & vbNewLine &
               "Error Description " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Resume ErrExit
    End Sub

    Private Sub datagridfill()
        If CaseloadDataGridView.DataSource Is Nothing Then
            Exit Sub
        End If

        Dim myDataGridView1 As DataGridView = CaseloadDataGridView
        With myDataGridView1
            .RowsDefaultCellStyle.BackColor = Color.Black
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 239, 253)
            .RowsDefaultCellStyle.ForeColor = Color.White
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        End With
    End Sub

    Private Sub notFound()

        Dim txtSearch As TextBox = txtDataSearch
        With txtSearch
            .BackColor = Color.White
            .Select()
            .SelectAll()
        End With

        If CaseloadDataGridView.DataSource Is Nothing Then
            Exit Sub
        End If

        Dim dgv As DataGridView = CaseloadDataGridView
        With dgv
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.ForeColor = Color.Black
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        End With
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        On Error GoTo ErrRe
        cmbFilter.ResetText()
        txtDataSearch.Clear()
        Me.CaseloadDataGridView.ResumeLayout()
        Me.CaseloadBindingSource.Filter = Nothing
        Me.CaseloadTableAdapter.Fill(Me._Safeguarding_17_18_DatabaseDataSet.Caseload)
        cmbFilter.Text = "     --- Select Search Criteria ---"

        With CaseloadDataGridView
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
            .DataSource = CaseloadBindingSource
        End With

        Dim myDataGridViewReset As DataGridView = CaseloadDataGridView
        With myDataGridViewReset
            .RowsDefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.ForeColor = Color.Black
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
        End With

ErrEx:
        Exit Sub
ErrRe:
        Dim ex As DialogResult
        ex = MessageBox.Show("Error Number " & Err.Number & vbNewLine &
               "Error Description " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Resume ErrEx
    End Sub
#End Region

#Region "Input Validation"
    Private Sub txtFirstName_KeyPress(sender As Object, e As CancelEventArgs) Handles txtFirstName.Validating
        If IsNumeric(txtFirstName.Text) And txtFirstName.Text <> "" Then
            txtFirstName.Text = Nothing
            ErrorProvider1.SetError(txtFirstName, "You are only required to enter letters A-Z")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtMiddleName_KeyPress(sender As Object, e As CancelEventArgs) Handles txtMiddleName.Validating
        If IsNumeric(txtMiddleName.Text) And txtMiddleName.Text <> "" Then
            txtMiddleName.Text = Nothing
            ErrorProvider2.SetError(txtMiddleName, "You are only required to enter letters A-Z")
        Else
            ErrorProvider2.Clear()
        End If
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As CancelEventArgs) Handles txtLastName.Validating
        If IsNumeric(txtLastName.Text) And txtLastName.Text <> "" Then
            txtLastName.Text = Nothing
            ErrorProvider3.SetError(txtLastName, "You are only required to enter letters A-Z")
        Else
            ErrorProvider3.Clear()
        End If
    End Sub

    Private Sub txtStudentID_Validating(sender As Object, e As CancelEventArgs) Handles txtStudentID.Validating
        If Not IsNumeric(txtStudentID.Text) And txtStudentID.Text <> "" Then
            txtStudentID.Text = Nothing
            ErrorProvider4.SetError(txtStudentID, "You are only required to enter numbers")
        Else
            ErrorProvider4.Clear()
        End If
    End Sub

    Private Sub txtNameofStaff_KeyPress(sender As Object, e As CancelEventArgs) Handles txtNameofStaff.Validating
        If IsNumeric(txtNameofStaff.Text) And txtNameofStaff.Text <> "" Then
            txtNameofStaff.Text = Nothing
            ErrorProvider5.SetError(txtNameofStaff, "You are only required to enter letters A-Z")
        Else
            ErrorProvider5.Clear()
        End If
    End Sub

    Private Sub txtReferredTo_KeyPress(sender As Object, e As CancelEventArgs) Handles txtReferredTo.Validating
        If IsNumeric(txtReferredTo.Text) Then
            txtReferredTo.Text = Nothing
            ErrorProvider6.SetError(txtReferredTo, "You are only required to enter letters A-Z")
        Else
            ErrorProvider6.Clear()
        End If
    End Sub
#End Region

#Region "Tool Tips and Disabling Input"
    Private Sub txtDetails_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDetails.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtOngoingAction_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOngoingAction.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUpdate.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtAgeofDiscl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAgeofDiscl.KeyPress
        e.Handled = True
    End Sub
#End Region

#Region "File Attachments Button"
    Private Sub btnAttachFile_Click(sender As Object, e As EventArgs) Handles btnAttachFile.Click
        FrmAttachments.TopMost = True
        FrmAttachments.Show()
    End Sub
#End Region

End Class

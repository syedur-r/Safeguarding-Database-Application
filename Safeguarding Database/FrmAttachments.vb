Imports System.Data.OleDb

Public Class FrmAttachments

    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub FrmAttachments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStudentName.Text = FrmCaseload.txtFirstName.Text & " " & FrmCaseload.txtLastName.Text
        txtStudentID.Text = FrmCaseload.txtStudentID.Text
        txtID.Text = FrmCaseload.txtID.Text
        txtFilePath.Select()
        txtID.Focus()
        btnBrowse.Height = 28
        btnBrowse.Width = 82
        btnSave.Height = 28
        btnSave.Width = 82
        btnBrowse.Location = New Point(126, 175)
        btnSave.Location = New Point(215, 175)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="

        Try
            datafile = "E:\Programming projects (vb)\Safeguarding Database\Safeguarding Database\Safeguarding Database\Safeguarding 17-18 Database.accdb"
        Finally
            datafile = "E:\Programming projects (vb)\Safeguarding Database\Safeguarding Database\Safeguarding Database\Safeguarding 17-18 Database.accdb"
        End Try

        connString = provider & datafile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into Attachments([Attachment_ID], [Student_name], [Student_id], [File_path]) Values (?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("ID", CType(txtID.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Student_name", CType(txtStudentName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Student_id", CType(txtStudentID.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("File_path", CType(txtFilePath.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            txtID.Clear()
            txtStudentName.Clear()
            txtStudentID.Clear()
            txtFilePath.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim Success As DialogResult
        Success = MessageBox.Show("File path has been saved!" & vbNewLine & "Please attach your files on the MS Access Attachment field", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FrmCaseload.WindowState = FormWindowState.Normal
        FrmCaseload.Show()
        FrmCaseload.TopMost = True
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtFilePath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub FrmAttachments_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmCaseload.WindowState = FormWindowState.Normal
        FrmCaseload.Show()
        FrmCaseload.TopMost = True
        Me.Hide()
        Me.Dispose()
    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCaseload
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label18 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim Label32 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim lblID As System.Windows.Forms.Label
        Dim Label33 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label34 As System.Windows.Forms.Label
        Dim Label35 As System.Windows.Forms.Label
        Dim lblAttachments As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCaseload))
        Me.btnFormView = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPRDate = New System.Windows.Forms.Button()
        Me.btnOpenCases = New System.Windows.Forms.Button()
        Me.btnAbuseType = New System.Windows.Forms.Button()
        Me.btnOfficer = New System.Windows.Forms.Button()
        Me.btnCaseload = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAddCase = New System.Windows.Forms.Button()
        Me.btnClearPage = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnInputDetails = New System.Windows.Forms.Button()
        Me.txtNameofStaff = New System.Windows.Forms.TextBox()
        Me.CaseloadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Safeguarding_17_18_DatabaseDataSet = New Safeguarding_Database._Safeguarding_17_18_DatabaseDataSet()
        Me.txtAgeofDiscl = New System.Windows.Forms.TextBox()
        Me.DTPDOD = New System.Windows.Forms.DateTimePicker()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.DTPDOB = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbSafeOfficer = New System.Windows.Forms.ComboBox()
        Me.txtReferredTo = New System.Windows.Forms.TextBox()
        Me.cbxWasReferred = New System.Windows.Forms.CheckBox()
        Me.DTPDOF = New System.Windows.Forms.DateTimePicker()
        Me.cmbTypeofAbuse = New System.Windows.Forms.ComboBox()
        Me.CbxCurrentStu = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnExpandUpdate = New System.Windows.Forms.Button()
        Me.btnExpandDetails = New System.Windows.Forms.Button()
        Me.btnExpandOnAction = New System.Windows.Forms.Button()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.txtUpdate = New System.Windows.Forms.TextBox()
        Me.txtOngoingAction = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.AttachmentPanel = New System.Windows.Forms.Panel()
        Me.btnResetEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAttachFile = New System.Windows.Forms.Button()
        Me.cmbRAG = New System.Windows.Forms.ComboBox()
        Me.DTPReviewDate = New System.Windows.Forms.DateTimePicker()
        Me.cbxPaperworkComp = New System.Windows.Forms.CheckBox()
        Me.cbxCaseClosed = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CaseloadDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentStudentDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DateOfDisclosureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameOfStaffTakingDisclosureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeOfAbuseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeAtDisclosureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SafeguardingOfficerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WasReferredDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ReferredToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfReferralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OngoingActionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReviewDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaperworkCompletedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CaseClosedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RAGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblRealDate = New System.Windows.Forms.Label()
        Me.AnimationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GpxDetails = New System.Windows.Forms.GroupBox()
        Me.btnExpandDetailsBack = New System.Windows.Forms.Button()
        Me.btnExDetailsOk = New System.Windows.Forms.Button()
        Me.txtExpandDetails = New System.Windows.Forms.TextBox()
        Me.GpxOnAction = New System.Windows.Forms.GroupBox()
        Me.btnExpandOnActionBack = New System.Windows.Forms.Button()
        Me.btnOnActionOk = New System.Windows.Forms.Button()
        Me.txtExpandOnAction = New System.Windows.Forms.TextBox()
        Me.GpxUpdate = New System.Windows.Forms.GroupBox()
        Me.btnExpandUpdateBack = New System.Windows.Forms.Button()
        Me.txtExpandUpdateOk = New System.Windows.Forms.Button()
        Me.txtExpandUpdate = New System.Windows.Forms.TextBox()
        Me.txtDataSearch = New System.Windows.Forms.TextBox()
        Me.DetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDataSearch = New System.Windows.Forms.Button()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider6 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label36 = New System.Windows.Forms.Label()
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CityTecLogo = New System.Windows.Forms.PictureBox()
        Me.NCCLogo = New System.Windows.Forms.PictureBox()
        Me.CaseloadTableAdapter = New Safeguarding_Database._Safeguarding_17_18_DatabaseDataSetTableAdapters.CaseloadTableAdapter()
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip6 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip7 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip8 = New System.Windows.Forms.ToolTip(Me.components)
        Label18 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        Label32 = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        lblID = New System.Windows.Forms.Label()
        Label33 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label34 = New System.Windows.Forms.Label()
        Label35 = New System.Windows.Forms.Label()
        lblAttachments = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CaseloadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Safeguarding_17_18_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.AttachmentPanel.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.CaseloadDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpxDetails.SuspendLayout()
        Me.GpxOnAction.SuspendLayout()
        Me.GpxUpdate.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityTecLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NCCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label18.Location = New System.Drawing.Point(419, 137)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(297, 25)
        Label18.TabIndex = 219
        Label18.Text = "Name of Staff Taking Disclosure:"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label20.Location = New System.Drawing.Point(8, 137)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(171, 25)
        Label20.TabIndex = 222
        Label20.Text = "Age at Disclosure:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label17.Location = New System.Drawing.Point(864, 81)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(176, 25)
        Label17.TabIndex = 217
        Label17.Text = "Date of Disclosure:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(8, 23)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(112, 25)
        Label11.TabIndex = 205
        Label11.Text = "First Name:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(419, 23)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(133, 25)
        Label12.TabIndex = 207
        Label12.Text = "Middle Name:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.Location = New System.Drawing.Point(419, 81)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(110, 25)
        Label15.TabIndex = 213
        Label15.Text = "Student ID:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(1473, -313)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(112, 25)
        Label13.TabIndex = 209
        Label13.Text = "Last Name:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.Location = New System.Drawing.Point(8, 81)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(124, 25)
        Label14.TabIndex = 211
        Label14.Text = "Date of Birth:"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label19.Location = New System.Drawing.Point(8, 18)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(146, 25)
        Label19.TabIndex = 221
        Label19.Text = "Type of Abuse:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label23.Location = New System.Drawing.Point(751, 81)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(121, 25)
        Label23.TabIndex = 228
        Label23.Text = "Referred To:"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label22.Location = New System.Drawing.Point(11, 82)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(138, 25)
        Label22.TabIndex = 226
        Label22.Text = "Was Referred:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label24.Location = New System.Drawing.Point(291, 82)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(152, 25)
        Label24.TabIndex = 230
        Label24.Text = "Date of Referral:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.Location = New System.Drawing.Point(419, 20)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(156, 25)
        Label16.TabIndex = 215
        Label16.Text = "Current Student:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label21.Location = New System.Drawing.Point(803, 20)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(197, 25)
        Label21.TabIndex = 224
        Label21.Text = "Safeguarding Officer:"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label25.Location = New System.Drawing.Point(8, 18)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(77, 25)
        Label25.TabIndex = 232
        Label25.Text = "Details:"
        '
        'Label27
        '
        Label27.AutoSize = True
        Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label27.Location = New System.Drawing.Point(8, 138)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(81, 25)
        Label27.TabIndex = 236
        Label27.Text = "Update:"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label26.Location = New System.Drawing.Point(8, 80)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(153, 25)
        Label26.TabIndex = 234
        Label26.Text = "Ongoing Action:"
        '
        'Label28
        '
        Label28.AutoSize = True
        Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label28.Location = New System.Drawing.Point(8, 18)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(127, 25)
        Label28.TabIndex = 238
        Label28.Text = "Review Date:"
        '
        'Label32
        '
        Label32.AutoSize = True
        Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label32.Location = New System.Drawing.Point(79, 70)
        Label32.Name = "Label32"
        Label32.Size = New System.Drawing.Size(60, 25)
        Label32.TabIndex = 246
        Label32.Text = "RAG:"
        '
        'Label29
        '
        Label29.AutoSize = True
        Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label29.Location = New System.Drawing.Point(432, 18)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(211, 25)
        Label29.TabIndex = 240
        Label29.Text = "Paperwork Completed:"
        '
        'Label30
        '
        Label30.AutoSize = True
        Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label30.Location = New System.Drawing.Point(787, 18)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(132, 25)
        Label30.TabIndex = 242
        Label30.Text = "Case Closed:"
        '
        'lblID
        '
        lblID.AutoSize = True
        lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblID.Location = New System.Drawing.Point(5, 20)
        lblID.Name = "lblID"
        lblID.Size = New System.Drawing.Size(37, 25)
        lblID.TabIndex = 203
        lblID.Text = "ID:"
        '
        'Label33
        '
        Label33.AutoSize = True
        Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label33.Location = New System.Drawing.Point(16, 18)
        Label33.Name = "Label33"
        Label33.Size = New System.Drawing.Size(77, 25)
        Label33.TabIndex = 233
        Label33.Text = "Details:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(16, 18)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(153, 25)
        Label10.TabIndex = 233
        Label10.Text = "Ongoing Action:"
        '
        'Label34
        '
        Label34.AutoSize = True
        Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label34.Location = New System.Drawing.Point(16, 18)
        Label34.Name = "Label34"
        Label34.Size = New System.Drawing.Size(81, 25)
        Label34.TabIndex = 233
        Label34.Text = "Update:"
        '
        'Label35
        '
        Label35.AutoSize = True
        Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label35.Location = New System.Drawing.Point(864, 23)
        Label35.Name = "Label35"
        Label35.Size = New System.Drawing.Size(112, 25)
        Label35.TabIndex = 286
        Label35.Text = "Last Name:"
        '
        'lblAttachments
        '
        lblAttachments.AutoSize = True
        lblAttachments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAttachments.Location = New System.Drawing.Point(13, 5)
        lblAttachments.Name = "lblAttachments"
        lblAttachments.Size = New System.Drawing.Size(127, 25)
        lblAttachments.TabIndex = 250
        lblAttachments.Text = "Attachments:"
        '
        'btnFormView
        '
        Me.btnFormView.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnFormView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormView.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnFormView.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnFormView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnFormView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnFormView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormView.Font = New System.Drawing.Font("Franklin Gothic Heavy", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormView.ForeColor = System.Drawing.Color.White
        Me.btnFormView.Location = New System.Drawing.Point(1076, 94)
        Me.btnFormView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFormView.Name = "btnFormView"
        Me.btnFormView.Size = New System.Drawing.Size(156, 32)
        Me.btnFormView.TabIndex = 275
        Me.btnFormView.Text = "Form View"
        Me.btnFormView.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFormView.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(453, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(512, 38)
        Me.Label9.TabIndex = 273
        Me.Label9.Text = "Safeguarding Caseload 2017-2018"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(240, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1605, 44)
        Me.Label8.TabIndex = 272
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(-5, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 44)
        Me.Label7.TabIndex = 271
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(91, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 44)
        Me.Label5.TabIndex = 269
        '
        'btnPRDate
        '
        Me.btnPRDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnPRDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPRDate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPRDate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnPRDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnPRDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnPRDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPRDate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPRDate.ForeColor = System.Drawing.Color.White
        Me.btnPRDate.Location = New System.Drawing.Point(885, 94)
        Me.btnPRDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPRDate.Name = "btnPRDate"
        Me.btnPRDate.Size = New System.Drawing.Size(184, 32)
        Me.btnPRDate.TabIndex = 268
        Me.btnPRDate.Text = "Past Review Date"
        Me.btnPRDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPRDate.UseVisualStyleBackColor = False
        '
        'btnOpenCases
        '
        Me.btnOpenCases.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnOpenCases.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenCases.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOpenCases.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnOpenCases.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnOpenCases.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnOpenCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenCases.Font = New System.Drawing.Font("Franklin Gothic Heavy", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenCases.ForeColor = System.Drawing.Color.White
        Me.btnOpenCases.Location = New System.Drawing.Point(728, 94)
        Me.btnOpenCases.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOpenCases.Name = "btnOpenCases"
        Me.btnOpenCases.Size = New System.Drawing.Size(152, 32)
        Me.btnOpenCases.TabIndex = 267
        Me.btnOpenCases.Text = "Open Cases"
        Me.btnOpenCases.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOpenCases.UseVisualStyleBackColor = False
        '
        'btnAbuseType
        '
        Me.btnAbuseType.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnAbuseType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbuseType.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAbuseType.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnAbuseType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnAbuseType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnAbuseType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbuseType.Font = New System.Drawing.Font("Franklin Gothic Heavy", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbuseType.ForeColor = System.Drawing.Color.White
        Me.btnAbuseType.Location = New System.Drawing.Point(304, 94)
        Me.btnAbuseType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbuseType.Name = "btnAbuseType"
        Me.btnAbuseType.Size = New System.Drawing.Size(176, 32)
        Me.btnAbuseType.TabIndex = 266
        Me.btnAbuseType.Text = "By Type of Abuse"
        Me.btnAbuseType.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAbuseType.UseVisualStyleBackColor = False
        '
        'btnOfficer
        '
        Me.btnOfficer.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnOfficer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOfficer.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOfficer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnOfficer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnOfficer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnOfficer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOfficer.Font = New System.Drawing.Font("Franklin Gothic Heavy", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOfficer.ForeColor = System.Drawing.Color.White
        Me.btnOfficer.Location = New System.Drawing.Point(485, 94)
        Me.btnOfficer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOfficer.Name = "btnOfficer"
        Me.btnOfficer.Size = New System.Drawing.Size(236, 32)
        Me.btnOfficer.TabIndex = 265
        Me.btnOfficer.Text = "By Safeguarding Officer"
        Me.btnOfficer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOfficer.UseVisualStyleBackColor = False
        '
        'btnCaseload
        '
        Me.btnCaseload.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnCaseload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCaseload.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCaseload.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnCaseload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnCaseload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnCaseload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaseload.Font = New System.Drawing.Font("Franklin Gothic Heavy", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaseload.ForeColor = System.Drawing.Color.White
        Me.btnCaseload.Location = New System.Drawing.Point(104, 94)
        Me.btnCaseload.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCaseload.Name = "btnCaseload"
        Me.btnCaseload.Size = New System.Drawing.Size(195, 32)
        Me.btnCaseload.TabIndex = 264
        Me.btnCaseload.Text = "16-17 Caseload"
        Me.btnCaseload.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCaseload.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(557, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(398, 38)
        Me.Label4.TabIndex = 263
        Me.Label4.Text = "Safeguarding Homepage"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(315, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(900, 16)
        Me.Label3.TabIndex = 262
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(315, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(900, 43)
        Me.Label2.TabIndex = 261
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(-1, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1848, 48)
        Me.Label6.TabIndex = 270
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(315, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(900, 16)
        Me.Label1.TabIndex = 260
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnAddCase)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 162)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(285, 60)
        Me.GroupBox1.TabIndex = 276
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(179, 20)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(93, 32)
        Me.btnEdit.TabIndex = 137
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAddCase
        '
        Me.btnAddCase.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnAddCase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCase.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddCase.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnAddCase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnAddCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnAddCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCase.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCase.ForeColor = System.Drawing.Color.White
        Me.btnAddCase.Location = New System.Drawing.Point(11, 20)
        Me.btnAddCase.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddCase.Name = "btnAddCase"
        Me.btnAddCase.Size = New System.Drawing.Size(159, 32)
        Me.btnAddCase.TabIndex = 136
        Me.btnAddCase.Text = "Add New Record"
        Me.btnAddCase.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddCase.UseVisualStyleBackColor = False
        '
        'btnClearPage
        '
        Me.btnClearPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnClearPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearPage.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClearPage.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnClearPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnClearPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnClearPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearPage.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearPage.ForeColor = System.Drawing.Color.White
        Me.btnClearPage.Location = New System.Drawing.Point(1147, 63)
        Me.btnClearPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearPage.Name = "btnClearPage"
        Me.btnClearPage.Size = New System.Drawing.Size(133, 32)
        Me.btnClearPage.TabIndex = 138
        Me.btnClearPage.Text = "Clear Page"
        Me.btnClearPage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClearPage.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(1033, 63)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 32)
        Me.btnSave.TabIndex = 135
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label35)
        Me.GroupBox2.Controls.Add(Me.btnInputDetails)
        Me.GroupBox2.Controls.Add(Label18)
        Me.GroupBox2.Controls.Add(Me.txtNameofStaff)
        Me.GroupBox2.Controls.Add(Label20)
        Me.GroupBox2.Controls.Add(Label17)
        Me.GroupBox2.Controls.Add(Me.txtAgeofDiscl)
        Me.GroupBox2.Controls.Add(Me.DTPDOD)
        Me.GroupBox2.Controls.Add(Me.txtFirstName)
        Me.GroupBox2.Controls.Add(Label11)
        Me.GroupBox2.Controls.Add(Label12)
        Me.GroupBox2.Controls.Add(Label15)
        Me.GroupBox2.Controls.Add(Me.txtMiddleName)
        Me.GroupBox2.Controls.Add(Me.txtStudentID)
        Me.GroupBox2.Controls.Add(Me.txtLastName)
        Me.GroupBox2.Controls.Add(Label14)
        Me.GroupBox2.Controls.Add(Me.DTPDOB)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 222)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1329, 176)
        Me.GroupBox2.TabIndex = 277
        Me.GroupBox2.TabStop = False
        '
        'btnInputDetails
        '
        Me.btnInputDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnInputDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInputDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnInputDetails.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnInputDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnInputDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnInputDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInputDetails.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInputDetails.ForeColor = System.Drawing.Color.White
        Me.btnInputDetails.Location = New System.Drawing.Point(1144, 132)
        Me.btnInputDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInputDetails.Name = "btnInputDetails"
        Me.btnInputDetails.Size = New System.Drawing.Size(137, 32)
        Me.btnInputDetails.TabIndex = 285
        Me.btnInputDetails.Text = "Input Details"
        Me.btnInputDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip8.SetToolTip(Me.btnInputDetails, "Click here to open the Input Box")
        Me.btnInputDetails.UseVisualStyleBackColor = False
        '
        'txtNameofStaff
        '
        Me.txtNameofStaff.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "Name of Staff Taking Disclosure", True))
        Me.txtNameofStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameofStaff.Location = New System.Drawing.Point(745, 134)
        Me.txtNameofStaff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNameofStaff.Name = "txtNameofStaff"
        Me.txtNameofStaff.Size = New System.Drawing.Size(292, 30)
        Me.txtNameofStaff.TabIndex = 7
        '
        'CaseloadBindingSource
        '
        Me.CaseloadBindingSource.DataMember = "Caseload"
        Me.CaseloadBindingSource.DataSource = Me._Safeguarding_17_18_DatabaseDataSet
        '
        '_Safeguarding_17_18_DatabaseDataSet
        '
        Me._Safeguarding_17_18_DatabaseDataSet.DataSetName = "_Safeguarding_17_18_DatabaseDataSet"
        Me._Safeguarding_17_18_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtAgeofDiscl
        '
        Me.txtAgeofDiscl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "Age at Disclosure", True))
        Me.txtAgeofDiscl.Enabled = False
        Me.txtAgeofDiscl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgeofDiscl.Location = New System.Drawing.Point(211, 134)
        Me.txtAgeofDiscl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAgeofDiscl.Name = "txtAgeofDiscl"
        Me.txtAgeofDiscl.Size = New System.Drawing.Size(85, 30)
        Me.txtAgeofDiscl.TabIndex = 300
        Me.txtAgeofDiscl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DTPDOD
        '
        Me.DTPDOD.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CaseloadBindingSource, "Date of Disclosure", True))
        Me.DTPDOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPDOD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDOD.Location = New System.Drawing.Point(1064, 76)
        Me.DTPDOD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTPDOD.Name = "DTPDOD"
        Me.DTPDOD.Size = New System.Drawing.Size(217, 30)
        Me.DTPDOD.TabIndex = 6
        Me.DTPDOD.Value = New Date(2018, 1, 1, 0, 0, 0, 0)
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "First Name", True))
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(132, 20)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(236, 30)
        Me.txtFirstName.TabIndex = 1
        '
        'txtMiddleName
        '
        Me.txtMiddleName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "Middle Name", True))
        Me.txtMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(565, 20)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(217, 30)
        Me.txtMiddleName.TabIndex = 2
        '
        'txtStudentID
        '
        Me.txtStudentID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "Student ID", True))
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(565, 76)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(217, 30)
        Me.txtStudentID.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "Last Name", True))
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(989, 20)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(217, 30)
        Me.txtLastName.TabIndex = 3
        '
        'DTPDOB
        '
        Me.DTPDOB.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CaseloadBindingSource, "Date of Birth", True))
        Me.DTPDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDOB.Location = New System.Drawing.Point(149, 76)
        Me.DTPDOB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTPDOB.Name = "DTPDOB"
        Me.DTPDOB.Size = New System.Drawing.Size(217, 30)
        Me.DTPDOB.TabIndex = 4
        Me.DTPDOB.Value = New Date(2018, 1, 1, 0, 0, 0, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label19)
        Me.GroupBox3.Controls.Add(Me.cmbSafeOfficer)
        Me.GroupBox3.Controls.Add(Label23)
        Me.GroupBox3.Controls.Add(Label22)
        Me.GroupBox3.Controls.Add(Me.txtReferredTo)
        Me.GroupBox3.Controls.Add(Me.cbxWasReferred)
        Me.GroupBox3.Controls.Add(Label24)
        Me.GroupBox3.Controls.Add(Me.DTPDOF)
        Me.GroupBox3.Controls.Add(Me.cmbTypeofAbuse)
        Me.GroupBox3.Controls.Add(Label16)
        Me.GroupBox3.Controls.Add(Label21)
        Me.GroupBox3.Controls.Add(Me.CbxCurrentStu)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 399)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(1329, 124)
        Me.GroupBox3.TabIndex = 278
        Me.GroupBox3.TabStop = False
        '
        'cmbSafeOfficer
        '
        Me.cmbSafeOfficer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSafeOfficer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "Safeguarding Officer", True))
        Me.cmbSafeOfficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSafeOfficer.FormattingEnabled = True
        Me.cmbSafeOfficer.Items.AddRange(New Object() {"Nick Steward", "Philip Martinez", "Christina Ajagbe", "Bobbi Ehsan", "Narzny Khan", "Oliver Dixon", "Georgina Creighton"})
        Me.cmbSafeOfficer.Location = New System.Drawing.Point(1019, 17)
        Me.cmbSafeOfficer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSafeOfficer.Name = "cmbSafeOfficer"
        Me.cmbSafeOfficer.Size = New System.Drawing.Size(223, 30)
        Me.cmbSafeOfficer.TabIndex = 9
        '
        'txtReferredTo
        '
        Me.txtReferredTo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "Referred To", True))
        Me.txtReferredTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferredTo.Location = New System.Drawing.Point(885, 78)
        Me.txtReferredTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReferredTo.Name = "txtReferredTo"
        Me.txtReferredTo.Size = New System.Drawing.Size(223, 30)
        Me.txtReferredTo.TabIndex = 11
        '
        'cbxWasReferred
        '
        Me.cbxWasReferred.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxWasReferred.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CaseloadBindingSource, "Was Referred", True))
        Me.cbxWasReferred.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxWasReferred.Location = New System.Drawing.Point(171, 82)
        Me.cbxWasReferred.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxWasReferred.Name = "cbxWasReferred"
        Me.cbxWasReferred.Size = New System.Drawing.Size(69, 25)
        Me.cbxWasReferred.TabIndex = 12
        Me.cbxWasReferred.UseVisualStyleBackColor = True
        '
        'DTPDOF
        '
        Me.DTPDOF.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CaseloadBindingSource, "Date of Referral", True))
        Me.DTPDOF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPDOF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDOF.Location = New System.Drawing.Point(465, 76)
        Me.DTPDOF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTPDOF.Name = "DTPDOF"
        Me.DTPDOF.Size = New System.Drawing.Size(223, 30)
        Me.DTPDOF.TabIndex = 10
        Me.DTPDOF.Value = New Date(2018, 1, 1, 0, 0, 0, 0)
        '
        'cmbTypeofAbuse
        '
        Me.cmbTypeofAbuse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "Type of Abuse", True))
        Me.cmbTypeofAbuse.DropDownWidth = 225
        Me.cmbTypeofAbuse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypeofAbuse.FormattingEnabled = True
        Me.cmbTypeofAbuse.ItemHeight = 22
        Me.cmbTypeofAbuse.Items.AddRange(New Object() {"Bullying", "Child missing from education", "Child missing from home or care", "Child Sexual Exploitation", "Domestic violence", "Drugs", "Emotional", "Fabricated or induced illness", "Faith abuse", "Female Genital Mutilation ", "Financial", "Forced marriage", "Gangs and youth violence", "Gender-based violence/ (VAWG)", "Homelessness", "Mental health", "Neglect", "Other", "Physical", "Private fostering", "Radicalisation", "Self-Harm", "Sexual"})
        Me.cmbTypeofAbuse.Location = New System.Drawing.Point(168, 17)
        Me.cmbTypeofAbuse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTypeofAbuse.Name = "cmbTypeofAbuse"
        Me.cmbTypeofAbuse.Size = New System.Drawing.Size(217, 30)
        Me.cmbTypeofAbuse.TabIndex = 8
        '
        'CbxCurrentStu
        '
        Me.CbxCurrentStu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbxCurrentStu.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CaseloadBindingSource, "Current Student", True))
        Me.CbxCurrentStu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCurrentStu.Location = New System.Drawing.Point(632, 20)
        Me.CbxCurrentStu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CbxCurrentStu.Name = "CbxCurrentStu"
        Me.CbxCurrentStu.Size = New System.Drawing.Size(36, 25)
        Me.CbxCurrentStu.TabIndex = 10
        Me.CbxCurrentStu.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnExpandUpdate)
        Me.GroupBox4.Controls.Add(Me.btnExpandDetails)
        Me.GroupBox4.Controls.Add(Me.btnExpandOnAction)
        Me.GroupBox4.Controls.Add(Label25)
        Me.GroupBox4.Controls.Add(Me.txtDetails)
        Me.GroupBox4.Controls.Add(Label27)
        Me.GroupBox4.Controls.Add(Me.txtUpdate)
        Me.GroupBox4.Controls.Add(Me.txtOngoingAction)
        Me.GroupBox4.Controls.Add(Label26)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 524)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(1329, 199)
        Me.GroupBox4.TabIndex = 279
        Me.GroupBox4.TabStop = False
        '
        'btnExpandUpdate
        '
        Me.btnExpandUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnExpandUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpandUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExpandUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnExpandUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnExpandUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnExpandUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpandUpdate.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandUpdate.ForeColor = System.Drawing.Color.White
        Me.btnExpandUpdate.Location = New System.Drawing.Point(1144, 144)
        Me.btnExpandUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExpandUpdate.Name = "btnExpandUpdate"
        Me.btnExpandUpdate.Size = New System.Drawing.Size(137, 32)
        Me.btnExpandUpdate.TabIndex = 17
        Me.btnExpandUpdate.Text = "Expand Box"
        Me.btnExpandUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip7.SetToolTip(Me.btnExpandUpdate, "Click here to input the Update")
        Me.btnExpandUpdate.UseVisualStyleBackColor = False
        '
        'btnExpandDetails
        '
        Me.btnExpandDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnExpandDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpandDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExpandDetails.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnExpandDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnExpandDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnExpandDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpandDetails.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandDetails.ForeColor = System.Drawing.Color.White
        Me.btnExpandDetails.Location = New System.Drawing.Point(1144, 26)
        Me.btnExpandDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExpandDetails.Name = "btnExpandDetails"
        Me.btnExpandDetails.Size = New System.Drawing.Size(137, 32)
        Me.btnExpandDetails.TabIndex = 13
        Me.btnExpandDetails.Text = "Expand Box"
        Me.btnExpandDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip5.SetToolTip(Me.btnExpandDetails, "Click here to input the Details")
        Me.btnExpandDetails.UseVisualStyleBackColor = False
        '
        'btnExpandOnAction
        '
        Me.btnExpandOnAction.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnExpandOnAction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpandOnAction.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExpandOnAction.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnExpandOnAction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnExpandOnAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnExpandOnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpandOnAction.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandOnAction.ForeColor = System.Drawing.Color.White
        Me.btnExpandOnAction.Location = New System.Drawing.Point(1144, 82)
        Me.btnExpandOnAction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExpandOnAction.Name = "btnExpandOnAction"
        Me.btnExpandOnAction.Size = New System.Drawing.Size(137, 32)
        Me.btnExpandOnAction.TabIndex = 15
        Me.btnExpandOnAction.Text = "Expand Box"
        Me.btnExpandOnAction.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip6.SetToolTip(Me.btnExpandOnAction, "Click here to input the Ongoing Action")
        Me.btnExpandOnAction.UseVisualStyleBackColor = False
        '
        'txtDetails
        '
        Me.txtDetails.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "Details", True))
        Me.txtDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetails.Location = New System.Drawing.Point(211, 15)
        Me.txtDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDetails.Size = New System.Drawing.Size(917, 53)
        Me.txtDetails.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtDetails, "Click on 'Expand Box' to input the Details")
        '
        'txtUpdate
        '
        Me.txtUpdate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "Update", True))
        Me.txtUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdate.Location = New System.Drawing.Point(211, 135)
        Me.txtUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUpdate.Multiline = True
        Me.txtUpdate.Name = "txtUpdate"
        Me.txtUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtUpdate.Size = New System.Drawing.Size(917, 58)
        Me.txtUpdate.TabIndex = 16
        Me.ToolTip3.SetToolTip(Me.txtUpdate, "Click on 'Expand Box' to input the Update")
        '
        'txtOngoingAction
        '
        Me.txtOngoingAction.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "Ongoing Action", True))
        Me.txtOngoingAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOngoingAction.Location = New System.Drawing.Point(211, 74)
        Me.txtOngoingAction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOngoingAction.Multiline = True
        Me.txtOngoingAction.Name = "txtOngoingAction"
        Me.txtOngoingAction.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOngoingAction.Size = New System.Drawing.Size(917, 52)
        Me.txtOngoingAction.TabIndex = 14
        Me.ToolTip2.SetToolTip(Me.txtOngoingAction, "Click on 'Expand Box' to input the Ongoing Action")
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.AttachmentPanel)
        Me.GroupBox5.Controls.Add(Me.btnResetEdit)
        Me.GroupBox5.Controls.Add(Me.btnUpdate)
        Me.GroupBox5.Controls.Add(Me.btnAttachFile)
        Me.GroupBox5.Controls.Add(Me.btnClearPage)
        Me.GroupBox5.Controls.Add(Label28)
        Me.GroupBox5.Controls.Add(Me.cmbRAG)
        Me.GroupBox5.Controls.Add(Me.btnSave)
        Me.GroupBox5.Controls.Add(Label32)
        Me.GroupBox5.Controls.Add(Me.DTPReviewDate)
        Me.GroupBox5.Controls.Add(Label29)
        Me.GroupBox5.Controls.Add(Me.cbxPaperworkComp)
        Me.GroupBox5.Controls.Add(Me.cbxCaseClosed)
        Me.GroupBox5.Controls.Add(Label30)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 722)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(1329, 110)
        Me.GroupBox5.TabIndex = 280
        Me.GroupBox5.TabStop = False
        '
        'AttachmentPanel
        '
        Me.AttachmentPanel.Controls.Add(lblAttachments)
        Me.AttachmentPanel.Location = New System.Drawing.Point(418, 65)
        Me.AttachmentPanel.Name = "AttachmentPanel"
        Me.AttachmentPanel.Size = New System.Drawing.Size(150, 33)
        Me.AttachmentPanel.TabIndex = 253
        Me.AttachmentPanel.Visible = False
        '
        'btnResetEdit
        '
        Me.btnResetEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnResetEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnResetEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnResetEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnResetEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnResetEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetEdit.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetEdit.ForeColor = System.Drawing.Color.White
        Me.btnResetEdit.Location = New System.Drawing.Point(893, 63)
        Me.btnResetEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnResetEdit.Name = "btnResetEdit"
        Me.btnResetEdit.Size = New System.Drawing.Size(133, 32)
        Me.btnResetEdit.TabIndex = 252
        Me.btnResetEdit.Text = "Reset"
        Me.btnResetEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnResetEdit.UseVisualStyleBackColor = False
        Me.btnResetEdit.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(780, 63)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(108, 32)
        Me.btnUpdate.TabIndex = 251
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUpdate.UseVisualStyleBackColor = False
        Me.btnUpdate.Visible = False
        '
        'btnAttachFile
        '
        Me.btnAttachFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnAttachFile.BackgroundImage = Global.Safeguarding_Database.My.Resources.Resources.Attachment
        Me.btnAttachFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAttachFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttachFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnAttachFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnAttachFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttachFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttachFile.Location = New System.Drawing.Point(573, 66)
        Me.btnAttachFile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAttachFile.Name = "btnAttachFile"
        Me.btnAttachFile.Size = New System.Drawing.Size(36, 32)
        Me.btnAttachFile.TabIndex = 20
        Me.btnAttachFile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip4.SetToolTip(Me.btnAttachFile, "Click here only when you have filled in the above fields")
        Me.btnAttachFile.UseVisualStyleBackColor = False
        '
        'cmbRAG
        '
        Me.cmbRAG.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRAG.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "RAG", True))
        Me.cmbRAG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRAG.FormattingEnabled = True
        Me.cmbRAG.Items.AddRange(New Object() {"Red", "Amber", "Green"})
        Me.cmbRAG.Location = New System.Drawing.Point(153, 69)
        Me.cmbRAG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbRAG.Name = "cmbRAG"
        Me.cmbRAG.Size = New System.Drawing.Size(223, 30)
        Me.cmbRAG.TabIndex = 19
        '
        'DTPReviewDate
        '
        Me.DTPReviewDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CaseloadBindingSource, "Review Date", True))
        Me.DTPReviewDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPReviewDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPReviewDate.Location = New System.Drawing.Point(153, 16)
        Me.DTPReviewDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTPReviewDate.Name = "DTPReviewDate"
        Me.DTPReviewDate.Size = New System.Drawing.Size(223, 30)
        Me.DTPReviewDate.TabIndex = 18
        Me.DTPReviewDate.Value = New Date(2018, 1, 1, 0, 0, 0, 0)
        '
        'cbxPaperworkComp
        '
        Me.cbxPaperworkComp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxPaperworkComp.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CaseloadBindingSource, "Paperwork Completed", True))
        Me.cbxPaperworkComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPaperworkComp.Location = New System.Drawing.Point(675, 18)
        Me.cbxPaperworkComp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxPaperworkComp.Name = "cbxPaperworkComp"
        Me.cbxPaperworkComp.Size = New System.Drawing.Size(45, 25)
        Me.cbxPaperworkComp.TabIndex = 19
        Me.cbxPaperworkComp.UseVisualStyleBackColor = True
        '
        'cbxCaseClosed
        '
        Me.cbxCaseClosed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxCaseClosed.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CaseloadBindingSource, "Case Closed", True))
        Me.cbxCaseClosed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCaseClosed.Location = New System.Drawing.Point(951, 18)
        Me.cbxCaseClosed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxCaseClosed.Name = "cbxCaseClosed"
        Me.cbxCaseClosed.Size = New System.Drawing.Size(39, 25)
        Me.cbxCaseClosed.TabIndex = 20
        Me.cbxCaseClosed.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtID)
        Me.GroupBox7.Controls.Add(lblID)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 166)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox7.Size = New System.Drawing.Size(135, 57)
        Me.GroupBox7.TabIndex = 281
        Me.GroupBox7.TabStop = False
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaseloadBindingSource, "ID", True))
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(52, 17)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(73, 30)
        Me.txtID.TabIndex = 204
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CaseloadDataGridView)
        Me.GroupBox6.Location = New System.Drawing.Point(-1, 226)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Size = New System.Drawing.Size(1333, 615)
        Me.GroupBox6.TabIndex = 282
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Visible = False
        '
        'CaseloadDataGridView
        '
        Me.CaseloadDataGridView.AllowUserToOrderColumns = True
        Me.CaseloadDataGridView.AutoGenerateColumns = False
        Me.CaseloadDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.CaseloadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CaseloadDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.CurrentStudentDataGridViewCheckBoxColumn, Me.DateOfDisclosureDataGridViewTextBoxColumn, Me.NameOfStaffTakingDisclosureDataGridViewTextBoxColumn, Me.TypeOfAbuseDataGridViewTextBoxColumn, Me.AgeAtDisclosureDataGridViewTextBoxColumn, Me.SafeguardingOfficerDataGridViewTextBoxColumn, Me.WasReferredDataGridViewCheckBoxColumn, Me.ReferredToDataGridViewTextBoxColumn, Me.DateOfReferralDataGridViewTextBoxColumn, Me.DetailsDataGridViewTextBoxColumn1, Me.OngoingActionDataGridViewTextBoxColumn, Me.UpdateDataGridViewTextBoxColumn, Me.ReviewDateDataGridViewTextBoxColumn, Me.PaperworkCompletedDataGridViewCheckBoxColumn, Me.CaseClosedDataGridViewCheckBoxColumn, Me.RAGDataGridViewTextBoxColumn})
        Me.CaseloadDataGridView.DataSource = Me.CaseloadBindingSource
        Me.CaseloadDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.CaseloadDataGridView.Location = New System.Drawing.Point(5, 14)
        Me.CaseloadDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CaseloadDataGridView.Name = "CaseloadDataGridView"
        Me.CaseloadDataGridView.RowTemplate.Height = 24
        Me.CaseloadDataGridView.Size = New System.Drawing.Size(1321, 601)
        Me.CaseloadDataGridView.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle Name"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'CurrentStudentDataGridViewCheckBoxColumn
        '
        Me.CurrentStudentDataGridViewCheckBoxColumn.DataPropertyName = "Current Student"
        Me.CurrentStudentDataGridViewCheckBoxColumn.HeaderText = "Current Student"
        Me.CurrentStudentDataGridViewCheckBoxColumn.Name = "CurrentStudentDataGridViewCheckBoxColumn"
        '
        'DateOfDisclosureDataGridViewTextBoxColumn
        '
        Me.DateOfDisclosureDataGridViewTextBoxColumn.DataPropertyName = "Date of Disclosure"
        Me.DateOfDisclosureDataGridViewTextBoxColumn.HeaderText = "Date of Disclosure"
        Me.DateOfDisclosureDataGridViewTextBoxColumn.Name = "DateOfDisclosureDataGridViewTextBoxColumn"
        '
        'NameOfStaffTakingDisclosureDataGridViewTextBoxColumn
        '
        Me.NameOfStaffTakingDisclosureDataGridViewTextBoxColumn.DataPropertyName = "Name of Staff Taking Disclosure"
        Me.NameOfStaffTakingDisclosureDataGridViewTextBoxColumn.HeaderText = "Name of Staff Taking Disclosure"
        Me.NameOfStaffTakingDisclosureDataGridViewTextBoxColumn.Name = "NameOfStaffTakingDisclosureDataGridViewTextBoxColumn"
        '
        'TypeOfAbuseDataGridViewTextBoxColumn
        '
        Me.TypeOfAbuseDataGridViewTextBoxColumn.DataPropertyName = "Type of Abuse"
        Me.TypeOfAbuseDataGridViewTextBoxColumn.HeaderText = "Type of Abuse"
        Me.TypeOfAbuseDataGridViewTextBoxColumn.Name = "TypeOfAbuseDataGridViewTextBoxColumn"
        '
        'AgeAtDisclosureDataGridViewTextBoxColumn
        '
        Me.AgeAtDisclosureDataGridViewTextBoxColumn.DataPropertyName = "Age at Disclosure"
        Me.AgeAtDisclosureDataGridViewTextBoxColumn.HeaderText = "Age at Disclosure"
        Me.AgeAtDisclosureDataGridViewTextBoxColumn.Name = "AgeAtDisclosureDataGridViewTextBoxColumn"
        '
        'SafeguardingOfficerDataGridViewTextBoxColumn
        '
        Me.SafeguardingOfficerDataGridViewTextBoxColumn.DataPropertyName = "Safeguarding Officer"
        Me.SafeguardingOfficerDataGridViewTextBoxColumn.HeaderText = "Safeguarding Officer"
        Me.SafeguardingOfficerDataGridViewTextBoxColumn.Name = "SafeguardingOfficerDataGridViewTextBoxColumn"
        '
        'WasReferredDataGridViewCheckBoxColumn
        '
        Me.WasReferredDataGridViewCheckBoxColumn.DataPropertyName = "Was Referred"
        Me.WasReferredDataGridViewCheckBoxColumn.HeaderText = "Was Referred"
        Me.WasReferredDataGridViewCheckBoxColumn.Name = "WasReferredDataGridViewCheckBoxColumn"
        '
        'ReferredToDataGridViewTextBoxColumn
        '
        Me.ReferredToDataGridViewTextBoxColumn.DataPropertyName = "Referred To"
        Me.ReferredToDataGridViewTextBoxColumn.HeaderText = "Referred To"
        Me.ReferredToDataGridViewTextBoxColumn.Name = "ReferredToDataGridViewTextBoxColumn"
        '
        'DateOfReferralDataGridViewTextBoxColumn
        '
        Me.DateOfReferralDataGridViewTextBoxColumn.DataPropertyName = "Date of Referral"
        Me.DateOfReferralDataGridViewTextBoxColumn.HeaderText = "Date of Referral"
        Me.DateOfReferralDataGridViewTextBoxColumn.Name = "DateOfReferralDataGridViewTextBoxColumn"
        '
        'DetailsDataGridViewTextBoxColumn1
        '
        Me.DetailsDataGridViewTextBoxColumn1.DataPropertyName = "Details"
        Me.DetailsDataGridViewTextBoxColumn1.HeaderText = "Details"
        Me.DetailsDataGridViewTextBoxColumn1.Name = "DetailsDataGridViewTextBoxColumn1"
        '
        'OngoingActionDataGridViewTextBoxColumn
        '
        Me.OngoingActionDataGridViewTextBoxColumn.DataPropertyName = "Ongoing Action"
        Me.OngoingActionDataGridViewTextBoxColumn.HeaderText = "Ongoing Action"
        Me.OngoingActionDataGridViewTextBoxColumn.Name = "OngoingActionDataGridViewTextBoxColumn"
        '
        'UpdateDataGridViewTextBoxColumn
        '
        Me.UpdateDataGridViewTextBoxColumn.DataPropertyName = "Update"
        Me.UpdateDataGridViewTextBoxColumn.HeaderText = "Update"
        Me.UpdateDataGridViewTextBoxColumn.Name = "UpdateDataGridViewTextBoxColumn"
        '
        'ReviewDateDataGridViewTextBoxColumn
        '
        Me.ReviewDateDataGridViewTextBoxColumn.DataPropertyName = "Review Date"
        Me.ReviewDateDataGridViewTextBoxColumn.HeaderText = "Review Date"
        Me.ReviewDateDataGridViewTextBoxColumn.Name = "ReviewDateDataGridViewTextBoxColumn"
        '
        'PaperworkCompletedDataGridViewCheckBoxColumn
        '
        Me.PaperworkCompletedDataGridViewCheckBoxColumn.DataPropertyName = "Paperwork Completed"
        Me.PaperworkCompletedDataGridViewCheckBoxColumn.HeaderText = "Paperwork Completed"
        Me.PaperworkCompletedDataGridViewCheckBoxColumn.Name = "PaperworkCompletedDataGridViewCheckBoxColumn"
        '
        'CaseClosedDataGridViewCheckBoxColumn
        '
        Me.CaseClosedDataGridViewCheckBoxColumn.DataPropertyName = "Case Closed"
        Me.CaseClosedDataGridViewCheckBoxColumn.HeaderText = "Case Closed"
        Me.CaseClosedDataGridViewCheckBoxColumn.Name = "CaseClosedDataGridViewCheckBoxColumn"
        '
        'RAGDataGridViewTextBoxColumn
        '
        Me.RAGDataGridViewTextBoxColumn.DataPropertyName = "RAG"
        Me.RAGDataGridViewTextBoxColumn.HeaderText = "RAG"
        Me.RAGDataGridViewTextBoxColumn.Name = "RAGDataGridViewTextBoxColumn"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.SupportMultiDottedExtensions = True
        '
        'lblRealDate
        '
        Me.lblRealDate.AutoSize = True
        Me.lblRealDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblRealDate.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealDate.Location = New System.Drawing.Point(1075, 22)
        Me.lblRealDate.Name = "lblRealDate"
        Me.lblRealDate.Size = New System.Drawing.Size(128, 25)
        Me.lblRealDate.TabIndex = 284
        Me.lblRealDate.Text = "06/01/2018"
        '
        'AnimationTimer
        '
        Me.AnimationTimer.Enabled = True
        '
        'GpxDetails
        '
        Me.GpxDetails.Controls.Add(Me.btnExpandDetailsBack)
        Me.GpxDetails.Controls.Add(Me.btnExDetailsOk)
        Me.GpxDetails.Controls.Add(Label33)
        Me.GpxDetails.Controls.Add(Me.txtExpandDetails)
        Me.GpxDetails.Location = New System.Drawing.Point(3, 180)
        Me.GpxDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GpxDetails.Name = "GpxDetails"
        Me.GpxDetails.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GpxDetails.Size = New System.Drawing.Size(1329, 689)
        Me.GpxDetails.TabIndex = 285
        Me.GpxDetails.TabStop = False
        Me.GpxDetails.Visible = False
        '
        'btnExpandDetailsBack
        '
        Me.btnExpandDetailsBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnExpandDetailsBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpandDetailsBack.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExpandDetailsBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnExpandDetailsBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnExpandDetailsBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnExpandDetailsBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpandDetailsBack.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandDetailsBack.ForeColor = System.Drawing.Color.White
        Me.btnExpandDetailsBack.Location = New System.Drawing.Point(21, 542)
        Me.btnExpandDetailsBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExpandDetailsBack.Name = "btnExpandDetailsBack"
        Me.btnExpandDetailsBack.Size = New System.Drawing.Size(85, 32)
        Me.btnExpandDetailsBack.TabIndex = 289
        Me.btnExpandDetailsBack.Text = "Back"
        Me.btnExpandDetailsBack.UseVisualStyleBackColor = False
        '
        'btnExDetailsOk
        '
        Me.btnExDetailsOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnExDetailsOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExDetailsOk.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExDetailsOk.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnExDetailsOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnExDetailsOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnExDetailsOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExDetailsOk.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExDetailsOk.ForeColor = System.Drawing.Color.White
        Me.btnExDetailsOk.Location = New System.Drawing.Point(1236, 543)
        Me.btnExDetailsOk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExDetailsOk.Name = "btnExDetailsOk"
        Me.btnExDetailsOk.Size = New System.Drawing.Size(75, 32)
        Me.btnExDetailsOk.TabIndex = 288
        Me.btnExDetailsOk.Text = "Ok"
        Me.btnExDetailsOk.UseVisualStyleBackColor = False
        '
        'txtExpandDetails
        '
        Me.txtExpandDetails.AcceptsReturn = True
        Me.txtExpandDetails.AcceptsTab = True
        Me.txtExpandDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtExpandDetails.Location = New System.Drawing.Point(21, 46)
        Me.txtExpandDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtExpandDetails.Multiline = True
        Me.txtExpandDetails.Name = "txtExpandDetails"
        Me.txtExpandDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtExpandDetails.Size = New System.Drawing.Size(1289, 488)
        Me.txtExpandDetails.TabIndex = 0
        '
        'GpxOnAction
        '
        Me.GpxOnAction.Controls.Add(Me.btnExpandOnActionBack)
        Me.GpxOnAction.Controls.Add(Me.btnOnActionOk)
        Me.GpxOnAction.Controls.Add(Label10)
        Me.GpxOnAction.Controls.Add(Me.txtExpandOnAction)
        Me.GpxOnAction.Location = New System.Drawing.Point(3, 180)
        Me.GpxOnAction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GpxOnAction.Name = "GpxOnAction"
        Me.GpxOnAction.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GpxOnAction.Size = New System.Drawing.Size(1329, 689)
        Me.GpxOnAction.TabIndex = 289
        Me.GpxOnAction.TabStop = False
        Me.GpxOnAction.Visible = False
        '
        'btnExpandOnActionBack
        '
        Me.btnExpandOnActionBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnExpandOnActionBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpandOnActionBack.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExpandOnActionBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnExpandOnActionBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnExpandOnActionBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnExpandOnActionBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpandOnActionBack.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandOnActionBack.ForeColor = System.Drawing.Color.White
        Me.btnExpandOnActionBack.Location = New System.Drawing.Point(21, 542)
        Me.btnExpandOnActionBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExpandOnActionBack.Name = "btnExpandOnActionBack"
        Me.btnExpandOnActionBack.Size = New System.Drawing.Size(85, 32)
        Me.btnExpandOnActionBack.TabIndex = 290
        Me.btnExpandOnActionBack.Text = "Back"
        Me.btnExpandOnActionBack.UseVisualStyleBackColor = False
        '
        'btnOnActionOk
        '
        Me.btnOnActionOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnOnActionOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOnActionOk.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOnActionOk.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnOnActionOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnOnActionOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnOnActionOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOnActionOk.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnActionOk.ForeColor = System.Drawing.Color.White
        Me.btnOnActionOk.Location = New System.Drawing.Point(1236, 543)
        Me.btnOnActionOk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOnActionOk.Name = "btnOnActionOk"
        Me.btnOnActionOk.Size = New System.Drawing.Size(75, 32)
        Me.btnOnActionOk.TabIndex = 288
        Me.btnOnActionOk.Text = "Ok"
        Me.btnOnActionOk.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOnActionOk.UseVisualStyleBackColor = False
        '
        'txtExpandOnAction
        '
        Me.txtExpandOnAction.AcceptsReturn = True
        Me.txtExpandOnAction.AcceptsTab = True
        Me.txtExpandOnAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtExpandOnAction.Location = New System.Drawing.Point(21, 46)
        Me.txtExpandOnAction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtExpandOnAction.Multiline = True
        Me.txtExpandOnAction.Name = "txtExpandOnAction"
        Me.txtExpandOnAction.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtExpandOnAction.Size = New System.Drawing.Size(1289, 488)
        Me.txtExpandOnAction.TabIndex = 0
        '
        'GpxUpdate
        '
        Me.GpxUpdate.Controls.Add(Me.btnExpandUpdateBack)
        Me.GpxUpdate.Controls.Add(Me.txtExpandUpdateOk)
        Me.GpxUpdate.Controls.Add(Label34)
        Me.GpxUpdate.Controls.Add(Me.txtExpandUpdate)
        Me.GpxUpdate.Location = New System.Drawing.Point(3, 180)
        Me.GpxUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GpxUpdate.Name = "GpxUpdate"
        Me.GpxUpdate.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GpxUpdate.Size = New System.Drawing.Size(1329, 689)
        Me.GpxUpdate.TabIndex = 290
        Me.GpxUpdate.TabStop = False
        Me.GpxUpdate.Visible = False
        '
        'btnExpandUpdateBack
        '
        Me.btnExpandUpdateBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnExpandUpdateBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpandUpdateBack.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExpandUpdateBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnExpandUpdateBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnExpandUpdateBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnExpandUpdateBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpandUpdateBack.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandUpdateBack.ForeColor = System.Drawing.Color.White
        Me.btnExpandUpdateBack.Location = New System.Drawing.Point(21, 542)
        Me.btnExpandUpdateBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExpandUpdateBack.Name = "btnExpandUpdateBack"
        Me.btnExpandUpdateBack.Size = New System.Drawing.Size(85, 32)
        Me.btnExpandUpdateBack.TabIndex = 291
        Me.btnExpandUpdateBack.Text = "Back"
        Me.btnExpandUpdateBack.UseVisualStyleBackColor = False
        '
        'txtExpandUpdateOk
        '
        Me.txtExpandUpdateOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.txtExpandUpdateOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtExpandUpdateOk.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txtExpandUpdateOk.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.txtExpandUpdateOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtExpandUpdateOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.txtExpandUpdateOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtExpandUpdateOk.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpandUpdateOk.ForeColor = System.Drawing.Color.White
        Me.txtExpandUpdateOk.Location = New System.Drawing.Point(1236, 543)
        Me.txtExpandUpdateOk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtExpandUpdateOk.Name = "txtExpandUpdateOk"
        Me.txtExpandUpdateOk.Size = New System.Drawing.Size(75, 32)
        Me.txtExpandUpdateOk.TabIndex = 288
        Me.txtExpandUpdateOk.Text = "Ok"
        Me.txtExpandUpdateOk.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtExpandUpdateOk.UseVisualStyleBackColor = False
        '
        'txtExpandUpdate
        '
        Me.txtExpandUpdate.AcceptsReturn = True
        Me.txtExpandUpdate.AcceptsTab = True
        Me.txtExpandUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtExpandUpdate.Location = New System.Drawing.Point(21, 46)
        Me.txtExpandUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtExpandUpdate.Multiline = True
        Me.txtExpandUpdate.Name = "txtExpandUpdate"
        Me.txtExpandUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtExpandUpdate.Size = New System.Drawing.Size(1289, 488)
        Me.txtExpandUpdate.TabIndex = 0
        '
        'txtDataSearch
        '
        Me.txtDataSearch.AutoCompleteCustomSource.AddRange(New String() {"Bullying", "Child missing from education", "Child missing from home or care", "Child Sexual Exploitation", "Domestic violence", "Drugs", "Emotional", "Fabricated or induced illness", "Faith abuse", "Female Genital Mutilation ", "Financial", "Forced marriage", "Gangs and youth violence", "Gender-based violence/ (VAWG)", "Homelessness", "Mental health", "Neglect", "Other", "Physical", "Private fostering", "Radicalisation", "Self-Harm", "Sexual", "Nick Steward", "Philip Martinez", "Christina Ajagbe", "Bobbi Ehsan", "Narzny Khan", "Oliver Dixon", "Georgina Creighton"})
        Me.txtDataSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDataSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDataSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDataSearch.Location = New System.Drawing.Point(923, 185)
        Me.txtDataSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDataSearch.Name = "txtDataSearch"
        Me.txtDataSearch.Size = New System.Drawing.Size(276, 30)
        Me.txtDataSearch.TabIndex = 291
        Me.txtDataSearch.Visible = False
        '
        'DetailsDataGridViewTextBoxColumn
        '
        Me.DetailsDataGridViewTextBoxColumn.DataPropertyName = "Details"
        Me.DetailsDataGridViewTextBoxColumn.HeaderText = "Details"
        Me.DetailsDataGridViewTextBoxColumn.Name = "DetailsDataGridViewTextBoxColumn"
        '
        'btnDataSearch
        '
        Me.btnDataSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnDataSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDataSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDataSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDataSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnDataSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnDataSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnDataSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDataSearch.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataSearch.ForeColor = System.Drawing.Color.White
        Me.btnDataSearch.Location = New System.Drawing.Point(1205, 185)
        Me.btnDataSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDataSearch.Name = "btnDataSearch"
        Me.btnDataSearch.Size = New System.Drawing.Size(87, 30)
        Me.btnDataSearch.TabIndex = 287
        Me.btnDataSearch.Text = "Search"
        Me.btnDataSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDataSearch.UseVisualStyleBackColor = False
        Me.btnDataSearch.Visible = False
        '
        'cmbFilter
        '
        Me.cmbFilter.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbFilter.DropDownWidth = 205
        Me.cmbFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"ID", "First Name", "Middle Name", "Last Name", "Date of Birth", "Name of Staff Taking Disclosure", "Type of Abuse", "Safeguarding Officer", "RAG"})
        Me.cmbFilter.Location = New System.Drawing.Point(564, 185)
        Me.cmbFilter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(335, 33)
        Me.cmbFilter.TabIndex = 251
        Me.cmbFilter.Visible = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(467, 185)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(87, 30)
        Me.btnReset.TabIndex = 292
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReset.UseVisualStyleBackColor = False
        Me.btnReset.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider4.ContainerControl = Me
        '
        'ErrorProvider5
        '
        Me.ErrorProvider5.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider5.ContainerControl = Me
        '
        'ErrorProvider6
        '
        Me.ErrorProvider6.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider6.ContainerControl = Me
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(89, 132)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(147, 44)
        Me.Label36.TabIndex = 293
        '
        'CityTecLogo
        '
        Me.CityTecLogo.BackColor = System.Drawing.Color.Transparent
        Me.CityTecLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CityTecLogo.Image = Global.Safeguarding_Database.My.Resources.Resources.CityTec_Logo_Developed_By_Syedur
        Me.CityTecLogo.Location = New System.Drawing.Point(1216, -2)
        Me.CityTecLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CityTecLogo.Name = "CityTecLogo"
        Me.CityTecLogo.Size = New System.Drawing.Size(123, 84)
        Me.CityTecLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CityTecLogo.TabIndex = 283
        Me.CityTecLogo.TabStop = False
        '
        'NCCLogo
        '
        Me.NCCLogo.BackColor = System.Drawing.Color.White
        Me.NCCLogo.Image = Global.Safeguarding_Database.My.Resources.Resources.NCC_Black__1_
        Me.NCCLogo.Location = New System.Drawing.Point(-1, -2)
        Me.NCCLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NCCLogo.Name = "NCCLogo"
        Me.NCCLogo.Size = New System.Drawing.Size(319, 86)
        Me.NCCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.NCCLogo.TabIndex = 259
        Me.NCCLogo.TabStop = False
        '
        'CaseloadTableAdapter
        '
        Me.CaseloadTableAdapter.ClearBeforeFill = True
        '
        'FrmCaseload
        '
        Me.AcceptButton = Me.btnDataSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1284, 871)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.btnDataSearch)
        Me.Controls.Add(Me.txtDataSearch)
        Me.Controls.Add(Me.lblRealDate)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Me.CityTecLogo)
        Me.Controls.Add(Me.btnFormView)
        Me.Controls.Add(Me.NCCLogo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnPRDate)
        Me.Controls.Add(Me.btnOpenCases)
        Me.Controls.Add(Me.btnAbuseType)
        Me.Controls.Add(Me.btnOfficer)
        Me.Controls.Add(Me.btnCaseload)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GpxOnAction)
        Me.Controls.Add(Me.GpxUpdate)
        Me.Controls.Add(Me.GpxDetails)
        Me.Controls.Add(Me.GroupBox6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FrmCaseload"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caseload"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CaseloadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Safeguarding_17_18_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.AttachmentPanel.ResumeLayout(False)
        Me.AttachmentPanel.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.CaseloadDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpxDetails.ResumeLayout(False)
        Me.GpxDetails.PerformLayout()
        Me.GpxOnAction.ResumeLayout(False)
        Me.GpxOnAction.PerformLayout()
        Me.GpxUpdate.ResumeLayout(False)
        Me.GpxUpdate.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityTecLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NCCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CityTecLogo As PictureBox
    Friend WithEvents btnFormView As Button
    Friend WithEvents NCCLogo As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPRDate As Button
    Friend WithEvents btnOpenCases As Button
    Friend WithEvents btnAbuseType As Button
    Friend WithEvents btnOfficer As Button
    Friend WithEvents btnCaseload As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAddCase As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNameofStaff As TextBox
    Friend WithEvents txtAgeofDiscl As TextBox
    Friend WithEvents DTPDOD As DateTimePicker
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents DTPDOB As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbSafeOfficer As ComboBox
    Friend WithEvents txtReferredTo As TextBox
    Friend WithEvents cbxWasReferred As CheckBox
    Friend WithEvents DTPDOF As DateTimePicker
    Friend WithEvents cmbTypeofAbuse As ComboBox
    Friend WithEvents CbxCurrentStu As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents txtUpdate As TextBox
    Friend WithEvents txtOngoingAction As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cmbRAG As ComboBox
    Friend WithEvents DTPReviewDate As DateTimePicker
    Friend WithEvents cbxPaperworkComp As CheckBox
    Friend WithEvents cbxCaseClosed As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CaseloadDataGridView As DataGridView
    Friend WithEvents btnClearPage As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblRealDate As Label
    Friend WithEvents AnimationTimer As Timer
    Friend WithEvents btnInputDetails As Button
    Friend WithEvents btnExpandUpdate As Button
    Friend WithEvents btnExpandDetails As Button
    Friend WithEvents btnExpandOnAction As Button
    Friend WithEvents GpxDetails As GroupBox
    Friend WithEvents btnExDetailsOk As Button
    Friend WithEvents txtExpandDetails As TextBox
    Friend WithEvents GpxOnAction As GroupBox
    Friend WithEvents btnOnActionOk As Button
    Friend WithEvents txtExpandOnAction As TextBox
    Friend WithEvents GpxUpdate As GroupBox
    Friend WithEvents txtExpandUpdateOk As Button
    Friend WithEvents txtExpandUpdate As TextBox
    Friend WithEvents txtDataSearch As TextBox
    Friend WithEvents btnDataSearch As Button
    Friend WithEvents DetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents btnReset As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents ErrorProvider5 As ErrorProvider
    Friend WithEvents ErrorProvider6 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents Label36 As Label
    Friend WithEvents btnAttachFile As Button
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents _Safeguarding_17_18_DatabaseDataSet As _Safeguarding_17_18_DatabaseDataSet
    Friend WithEvents CaseloadBindingSource As BindingSource
    Friend WithEvents CaseloadTableAdapter As _Safeguarding_17_18_DatabaseDataSetTableAdapters.CaseloadTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentStudentDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DateOfDisclosureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameOfStaffTakingDisclosureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeOfAbuseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeAtDisclosureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SafeguardingOfficerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WasReferredDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ReferredToDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfReferralDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetailsDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OngoingActionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UpdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReviewDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaperworkCompletedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CaseClosedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents RAGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip7 As ToolTip
    Friend WithEvents ToolTip5 As ToolTip
    Friend WithEvents ToolTip6 As ToolTip
    Friend WithEvents ToolTip8 As ToolTip
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnResetEdit As Button
    Friend WithEvents btnExpandDetailsBack As Button
    Friend WithEvents btnExpandOnActionBack As Button
    Friend WithEvents btnExpandUpdateBack As Button
    Friend WithEvents AttachmentPanel As Panel
End Class

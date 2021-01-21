<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpCasesReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpCasesReport))
        Me.CaseloadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Opencases_dataset = New Safeguarding_Database.Opencases_dataset()
        Me.btnFilterText = New System.Windows.Forms.Button()
        Me.txtFilterSearch = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.CaseloadTableAdapter = New Safeguarding_Database.Opencases_datasetTableAdapters.CaseloadTableAdapter()
        Me.DTPOpenDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSelectDate = New System.Windows.Forms.Label()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.btnFilterDate = New System.Windows.Forms.Button()
        CType(Me.CaseloadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Opencases_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CaseloadBindingSource
        '
        Me.CaseloadBindingSource.DataMember = "Caseload"
        Me.CaseloadBindingSource.DataSource = Me.Opencases_dataset
        '
        'Opencases_dataset
        '
        Me.Opencases_dataset.DataSetName = "Opencases_dataset"
        Me.Opencases_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnFilterText
        '
        Me.btnFilterText.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnFilterText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFilterText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterText.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnFilterText.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnFilterText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnFilterText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnFilterText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterText.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilterText.ForeColor = System.Drawing.Color.White
        Me.btnFilterText.Location = New System.Drawing.Point(353, 61)
        Me.btnFilterText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFilterText.Name = "btnFilterText"
        Me.btnFilterText.Size = New System.Drawing.Size(73, 30)
        Me.btnFilterText.TabIndex = 294
        Me.btnFilterText.Text = "Filter"
        Me.btnFilterText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFilterText.UseVisualStyleBackColor = False
        Me.btnFilterText.Visible = False
        '
        'txtFilterSearch
        '
        Me.txtFilterSearch.AutoCompleteCustomSource.AddRange(New String() {"Bullying", "Child missing from education", "Child missing from home or care", "Child Sexual Exploitation", "Domestic violence", "Drugs", "Emotional", "Fabricated or induced illness", "Faith abuse", "Female Genital Mutilation ", "Financial", "Forced marriage", "Gangs and youth violence", "Gender-based violence/ (VAWG)", "Homelessness", "Mental health", "Neglect", "Other", "Physical", "Private fostering", "Radicalisation", "Self-Harm", "Sexual"})
        Me.txtFilterSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtFilterSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFilterSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtFilterSearch.Location = New System.Drawing.Point(12, 61)
        Me.txtFilterSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFilterSearch.Name = "txtFilterSearch"
        Me.txtFilterSearch.Size = New System.Drawing.Size(335, 30)
        Me.txtFilterSearch.TabIndex = 295
        Me.txtFilterSearch.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Opencases_dataset"
        ReportDataSource1.Value = Me.CaseloadBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Safeguarding_Database.OpCasesReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 110)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1386, 514)
        Me.ReportViewer1.TabIndex = 296
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
        Me.btnReset.Location = New System.Drawing.Point(353, 13)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(73, 33)
        Me.btnReset.TabIndex = 297
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'CaseloadTableAdapter
        '
        Me.CaseloadTableAdapter.ClearBeforeFill = True
        '
        'DTPOpenDate
        '
        Me.DTPOpenDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPOpenDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPOpenDate.Location = New System.Drawing.Point(582, 59)
        Me.DTPOpenDate.Name = "DTPOpenDate"
        Me.DTPOpenDate.Size = New System.Drawing.Size(217, 30)
        Me.DTPOpenDate.TabIndex = 299
        Me.DTPOpenDate.Value = New Date(2018, 2, 16, 0, 0, 0, 0)
        Me.DTPOpenDate.Visible = False
        '
        'lblSelectDate
        '
        Me.lblSelectDate.AutoSize = True
        Me.lblSelectDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblSelectDate.Location = New System.Drawing.Point(457, 62)
        Me.lblSelectDate.Name = "lblSelectDate"
        Me.lblSelectDate.Size = New System.Drawing.Size(119, 25)
        Me.lblSelectDate.TabIndex = 301
        Me.lblSelectDate.Text = "Select Date:"
        Me.lblSelectDate.Visible = False
        '
        'cmbFilter
        '
        Me.cmbFilter.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbFilter.DropDownWidth = 205
        Me.cmbFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"First Name", "Date of Disclosure", "Type of Abuse"})
        Me.cmbFilter.Location = New System.Drawing.Point(12, 13)
        Me.cmbFilter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(335, 33)
        Me.cmbFilter.TabIndex = 303
        '
        'btnFilterDate
        '
        Me.btnFilterDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnFilterDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFilterDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterDate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnFilterDate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnFilterDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnFilterDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnFilterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterDate.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilterDate.ForeColor = System.Drawing.Color.White
        Me.btnFilterDate.Location = New System.Drawing.Point(805, 59)
        Me.btnFilterDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFilterDate.Name = "btnFilterDate"
        Me.btnFilterDate.Size = New System.Drawing.Size(73, 30)
        Me.btnFilterDate.TabIndex = 304
        Me.btnFilterDate.Text = "Filter"
        Me.btnFilterDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFilterDate.UseVisualStyleBackColor = False
        Me.btnFilterDate.Visible = False
        '
        'FrmOpCasesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1410, 636)
        Me.Controls.Add(Me.btnFilterDate)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.lblSelectDate)
        Me.Controls.Add(Me.DTPOpenDate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnFilterText)
        Me.Controls.Add(Me.txtFilterSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOpCasesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Open Cases"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CaseloadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Opencases_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFilterText As Button
    Friend WithEvents txtFilterSearch As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnReset As Button
    Friend WithEvents CaseloadBindingSource As BindingSource
    Friend WithEvents Opencases_dataset As Opencases_dataset
    Friend WithEvents CaseloadTableAdapter As Opencases_datasetTableAdapters.CaseloadTableAdapter
    Friend WithEvents DTPOpenDate As DateTimePicker
    Friend WithEvents lblSelectDate As Label
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents btnFilterDate As Button
End Class

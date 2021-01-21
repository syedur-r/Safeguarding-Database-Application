<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOfficerReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOfficerReport))
        Me.CaseloadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Officer_dataset = New Safeguarding_Database.Officer_dataset()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.txtFilterSearch = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.CaseloadTableAdapter = New Safeguarding_Database.Officer_datasetTableAdapters.CaseloadTableAdapter()
        CType(Me.CaseloadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Officer_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CaseloadBindingSource
        '
        Me.CaseloadBindingSource.DataMember = "Caseload"
        Me.CaseloadBindingSource.DataSource = Me.Officer_dataset
        '
        'Officer_dataset
        '
        Me.Officer_dataset.DataSetName = "Officer_dataset"
        Me.Officer_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnFilter.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(400, 11)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(73, 30)
        Me.btnFilter.TabIndex = 294
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'txtFilterSearch
        '
        Me.txtFilterSearch.AutoCompleteCustomSource.AddRange(New String() {"Nick Steward", "Philip Martinez", "Christina Ajagbe", "Bobbi Ehsan", "Narzny Khan", "Oliver Dixon", "Georgina Creighton"})
        Me.txtFilterSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtFilterSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFilterSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtFilterSearch.Location = New System.Drawing.Point(12, 11)
        Me.txtFilterSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFilterSearch.Name = "txtFilterSearch"
        Me.txtFilterSearch.Size = New System.Drawing.Size(382, 30)
        Me.txtFilterSearch.TabIndex = 295
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Officer_dataset"
        ReportDataSource1.Value = Me.CaseloadBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Safeguarding_Database.OfficerReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 64)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1386, 560)
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
        Me.btnReset.Location = New System.Drawing.Point(479, 11)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(73, 30)
        Me.btnReset.TabIndex = 297
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'CaseloadTableAdapter
        '
        Me.CaseloadTableAdapter.ClearBeforeFill = True
        '
        'FrmOfficerReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1410, 636)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.txtFilterSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOfficerReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Safeguarding Officer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CaseloadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Officer_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFilter As Button
    Friend WithEvents txtFilterSearch As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnReset As Button
    Friend WithEvents CaseloadBindingSource As BindingSource
    Friend WithEvents Officer_dataset As Officer_dataset
    Friend WithEvents CaseloadTableAdapter As Officer_datasetTableAdapters.CaseloadTableAdapter
End Class

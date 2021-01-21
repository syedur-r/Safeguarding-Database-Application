<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPRDateReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPRDateReport))
        Me.CaseloadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pastreviewdate_dataset = New Safeguarding_Database.Pastreviewdate_dataset()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.CaseloadTableAdapter = New Safeguarding_Database.Pastreviewdate_datasetTableAdapters.CaseloadTableAdapter()
        Me.DTPPastDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSelectDate = New System.Windows.Forms.Label()
        CType(Me.CaseloadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pastreviewdate_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CaseloadBindingSource
        '
        Me.CaseloadBindingSource.DataMember = "Caseload"
        Me.CaseloadBindingSource.DataSource = Me.Pastreviewdate_dataset
        '
        'Pastreviewdate_dataset
        '
        Me.Pastreviewdate_dataset.DataSetName = "Pastreviewdate_dataset"
        Me.Pastreviewdate_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.btnFilter.Location = New System.Drawing.Point(376, 11)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(73, 30)
        Me.btnFilter.TabIndex = 294
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Pastreviewdate_dataset"
        ReportDataSource1.Value = Me.CaseloadBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Safeguarding_Database.PRDateReport.rdlc"
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
        Me.btnReset.Location = New System.Drawing.Point(455, 11)
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
        'DTPPastDate
        '
        Me.DTPPastDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPPastDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPPastDate.Location = New System.Drawing.Point(153, 11)
        Me.DTPPastDate.Name = "DTPPastDate"
        Me.DTPPastDate.Size = New System.Drawing.Size(217, 30)
        Me.DTPPastDate.TabIndex = 298
        Me.DTPPastDate.Value = New Date(2018, 2, 16, 0, 0, 0, 0)
        '
        'lblSelectDate
        '
        Me.lblSelectDate.AutoSize = True
        Me.lblSelectDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblSelectDate.Location = New System.Drawing.Point(12, 13)
        Me.lblSelectDate.Name = "lblSelectDate"
        Me.lblSelectDate.Size = New System.Drawing.Size(135, 25)
        Me.lblSelectDate.TabIndex = 300
        Me.lblSelectDate.Text = "Select a Date:"
        '
        'FrmPRDateReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1410, 636)
        Me.Controls.Add(Me.lblSelectDate)
        Me.Controls.Add(Me.DTPPastDate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnFilter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPRDateReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Past Review Date"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CaseloadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pastreviewdate_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFilter As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnReset As Button
    Friend WithEvents CaseloadBindingSource As BindingSource
    Friend WithEvents Pastreviewdate_dataset As Pastreviewdate_dataset
    Friend WithEvents CaseloadTableAdapter As Pastreviewdate_datasetTableAdapters.CaseloadTableAdapter
    Friend WithEvents DTPPastDate As DateTimePicker
    Friend WithEvents lblSelectDate As Label
End Class

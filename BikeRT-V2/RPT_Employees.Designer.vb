<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPT_Employees
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me._BikeRT_V2DataSet = New BikeRT_V2._BikeRT_V2DataSet()
        Me.TBL_EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_EmployeesTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_EmployeesTableAdapter()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "RPT_Employees"
        ReportDataSource1.Value = Me.TBL_EmployeesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BikeRT_V2.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(652, 357)
        Me.ReportViewer1.TabIndex = 0
        '
        '_BikeRT_V2DataSet
        '
        Me._BikeRT_V2DataSet.DataSetName = "_BikeRT_V2DataSet"
        Me._BikeRT_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_EmployeesBindingSource
        '
        Me.TBL_EmployeesBindingSource.DataMember = "TBL_Employees"
        Me.TBL_EmployeesBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        'TBL_EmployeesTableAdapter
        '
        Me.TBL_EmployeesTableAdapter.ClearBeforeFill = True
        '
        'RPT_Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 388)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RPT_Employees"
        Me.Text = "RPT_Employees"
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TBL_EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _BikeRT_V2DataSet As BikeRT_V2._BikeRT_V2DataSet
    Friend WithEvents TBL_EmployeesTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_EmployeesTableAdapter
End Class

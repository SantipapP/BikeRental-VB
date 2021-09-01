<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPT_Customers
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
        Me.TBL_CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_CustomersTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_CustomersTableAdapter()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "RPT_Customers"
        ReportDataSource1.Value = Me.TBL_CustomersBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BikeRT_V2.Report8.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(651, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        '_BikeRT_V2DataSet
        '
        Me._BikeRT_V2DataSet.DataSetName = "_BikeRT_V2DataSet"
        Me._BikeRT_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_CustomersBindingSource
        '
        Me.TBL_CustomersBindingSource.DataMember = "TBL_Customers"
        Me.TBL_CustomersBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        'TBL_CustomersTableAdapter
        '
        Me.TBL_CustomersTableAdapter.ClearBeforeFill = True
        '
        'RPT_Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 269)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RPT_Customers"
        Me.Text = "RPT_Customers"
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TBL_CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _BikeRT_V2DataSet As BikeRT_V2._BikeRT_V2DataSet
    Friend WithEvents TBL_CustomersTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_CustomersTableAdapter
End Class

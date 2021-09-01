<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPT_CusP
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
        Me.QRY_CusPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BikeRT_V2DataSet = New BikeRT_V2._BikeRT_V2DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.QRY_CusPTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.QRY_CusPTableAdapter()
        CType(Me.QRY_CusPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QRY_CusPBindingSource
        '
        Me.QRY_CusPBindingSource.DataMember = "QRY_CusP"
        Me.QRY_CusPBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        '_BikeRT_V2DataSet
        '
        Me._BikeRT_V2DataSet.DataSetName = "_BikeRT_V2DataSet"
        Me._BikeRT_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "RPT_CusP"
        ReportDataSource1.Value = Me.QRY_CusPBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BikeRT_V2.Report5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(676, 249)
        Me.ReportViewer1.TabIndex = 0
        '
        'QRY_CusPTableAdapter
        '
        Me.QRY_CusPTableAdapter.ClearBeforeFill = True
        '
        'RPT_CusP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 273)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RPT_CusP"
        Me.Text = "RPT_CusP"
        CType(Me.QRY_CusPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents QRY_CusPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _BikeRT_V2DataSet As BikeRT_V2._BikeRT_V2DataSet
    Friend WithEvents QRY_CusPTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.QRY_CusPTableAdapter
End Class

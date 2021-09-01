<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPT_Qty
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
        Me.QRY_QtyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QRY_QtyTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.QRY_QtyTableAdapter()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRY_QtyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "RPT_Qty"
        ReportDataSource1.Value = Me.QRY_QtyBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BikeRT_V2.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(712, 382)
        Me.ReportViewer1.TabIndex = 0
        '
        '_BikeRT_V2DataSet
        '
        Me._BikeRT_V2DataSet.DataSetName = "_BikeRT_V2DataSet"
        Me._BikeRT_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QRY_QtyBindingSource
        '
        Me.QRY_QtyBindingSource.DataMember = "QRY_Qty"
        Me.QRY_QtyBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        'QRY_QtyTableAdapter
        '
        Me.QRY_QtyTableAdapter.ClearBeforeFill = True
        '
        'RPT_Qty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 406)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RPT_Qty"
        Me.Text = "RPT_Qty"
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRY_QtyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents QRY_QtyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _BikeRT_V2DataSet As BikeRT_V2._BikeRT_V2DataSet
    Friend WithEvents QRY_QtyTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.QRY_QtyTableAdapter
End Class

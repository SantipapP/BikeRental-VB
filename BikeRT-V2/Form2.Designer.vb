<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._BikeRT_V2DataSet = New BikeRT_V2._BikeRT_V2DataSet()
        Me.BikeRTV2DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLAdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_AdminTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_AdminTableAdapter()
        Me.AdIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdPassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BikeRTV2DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLAdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdIDDataGridViewTextBoxColumn, Me.AdPassDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TBLAdminBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 0
        '
        '_BikeRT_V2DataSet
        '
        Me._BikeRT_V2DataSet.DataSetName = "_BikeRT_V2DataSet"
        Me._BikeRT_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BikeRTV2DataSetBindingSource
        '
        Me.BikeRTV2DataSetBindingSource.DataSource = Me._BikeRT_V2DataSet
        Me.BikeRTV2DataSetBindingSource.Position = 0
        '
        'TBLAdminBindingSource
        '
        Me.TBLAdminBindingSource.DataMember = "TBL_Admin"
        Me.TBLAdminBindingSource.DataSource = Me.BikeRTV2DataSetBindingSource
        '
        'TBL_AdminTableAdapter
        '
        Me.TBL_AdminTableAdapter.ClearBeforeFill = True
        '
        'AdIDDataGridViewTextBoxColumn
        '
        Me.AdIDDataGridViewTextBoxColumn.DataPropertyName = "Ad_ID"
        Me.AdIDDataGridViewTextBoxColumn.HeaderText = "Ad_ID"
        Me.AdIDDataGridViewTextBoxColumn.Name = "AdIDDataGridViewTextBoxColumn"
        '
        'AdPassDataGridViewTextBoxColumn
        '
        Me.AdPassDataGridViewTextBoxColumn.DataPropertyName = "Ad_Pass"
        Me.AdPassDataGridViewTextBoxColumn.HeaderText = "Ad_Pass"
        Me.AdPassDataGridViewTextBoxColumn.Name = "AdPassDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BikeRTV2DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLAdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BikeRTV2DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _BikeRT_V2DataSet As BikeRT_V2._BikeRT_V2DataSet
    Friend WithEvents TBLAdminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_AdminTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_AdminTableAdapter
    Friend WithEvents AdIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdPassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

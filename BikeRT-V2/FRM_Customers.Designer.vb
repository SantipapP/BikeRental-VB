<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Customers
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
        Dim Cus_IDLabel As System.Windows.Forms.Label
        Dim Cus_NameLabel As System.Windows.Forms.Label
        Dim Cus_AddressLabel As System.Windows.Forms.Label
        Dim Cus_BirthLabel As System.Windows.Forms.Label
        Dim Cus_TelLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Customers))
        Me._BikeRT_V2DataSet = New BikeRT_V2._BikeRT_V2DataSet()
        Me.TBL_CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_CustomersTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_CustomersTableAdapter()
        Me.TableAdapterManager = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager()
        Me.TBL_CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TBL_CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TBL_CustomersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cus_TelTextBox = New System.Windows.Forms.TextBox()
        Me.Cus_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cus_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Cus_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Cus_IDTextBox = New System.Windows.Forms.TextBox()
        Cus_IDLabel = New System.Windows.Forms.Label()
        Cus_NameLabel = New System.Windows.Forms.Label()
        Cus_AddressLabel = New System.Windows.Forms.Label()
        Cus_BirthLabel = New System.Windows.Forms.Label()
        Cus_TelLabel = New System.Windows.Forms.Label()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TBL_CustomersBindingNavigator.SuspendLayout()
        CType(Me.TBL_CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cus_IDLabel
        '
        Cus_IDLabel.AutoSize = True
        Cus_IDLabel.Location = New System.Drawing.Point(21, 52)
        Cus_IDLabel.Name = "Cus_IDLabel"
        Cus_IDLabel.Size = New System.Drawing.Size(54, 13)
        Cus_IDLabel.TabIndex = 0
        Cus_IDLabel.Text = "รหัสลูกค้า:"
        '
        'Cus_NameLabel
        '
        Cus_NameLabel.AutoSize = True
        Cus_NameLabel.Location = New System.Drawing.Point(27, 93)
        Cus_NameLabel.Name = "Cus_NameLabel"
        Cus_NameLabel.Size = New System.Drawing.Size(48, 13)
        Cus_NameLabel.TabIndex = 2
        Cus_NameLabel.Text = "ชื่อลูกค้า:"
        '
        'Cus_AddressLabel
        '
        Cus_AddressLabel.AutoSize = True
        Cus_AddressLabel.Location = New System.Drawing.Point(45, 127)
        Cus_AddressLabel.Name = "Cus_AddressLabel"
        Cus_AddressLabel.Size = New System.Drawing.Size(30, 13)
        Cus_AddressLabel.TabIndex = 4
        Cus_AddressLabel.Text = "ที่อยู่:"
        '
        'Cus_BirthLabel
        '
        Cus_BirthLabel.AutoSize = True
        Cus_BirthLabel.Location = New System.Drawing.Point(265, 58)
        Cus_BirthLabel.Name = "Cus_BirthLabel"
        Cus_BirthLabel.Size = New System.Drawing.Size(85, 13)
        Cus_BirthLabel.TabIndex = 6
        Cus_BirthLabel.Text = "วัน เดือน ปี เกิด:"
        '
        'Cus_TelLabel
        '
        Cus_TelLabel.AutoSize = True
        Cus_TelLabel.Location = New System.Drawing.Point(275, 94)
        Cus_TelLabel.Name = "Cus_TelLabel"
        Cus_TelLabel.Size = New System.Drawing.Size(75, 13)
        Cus_TelLabel.TabIndex = 8
        Cus_TelLabel.Text = "เบอร์โทรศัพท์:"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AdminTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BikeTableAdapter = Nothing
        Me.TableAdapterManager.TBL_CustomersTableAdapter = Me.TBL_CustomersTableAdapter
        Me.TableAdapterManager.TBL_EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.TBL_InTableAdapter = Nothing
        Me.TableAdapterManager.TBL_RTableAdapter = Nothing
        Me.TableAdapterManager.TBL_SubTableAdapter = Nothing
        Me.TableAdapterManager.TBL_TTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_CustomersBindingNavigator
        '
        Me.TBL_CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TBL_CustomersBindingNavigator.BindingSource = Me.TBL_CustomersBindingSource
        Me.TBL_CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TBL_CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TBL_CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TBL_CustomersBindingNavigatorSaveItem})
        Me.TBL_CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TBL_CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TBL_CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TBL_CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TBL_CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TBL_CustomersBindingNavigator.Name = "TBL_CustomersBindingNavigator"
        Me.TBL_CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TBL_CustomersBindingNavigator.Size = New System.Drawing.Size(586, 25)
        Me.TBL_CustomersBindingNavigator.TabIndex = 0
        Me.TBL_CustomersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TBL_CustomersBindingNavigatorSaveItem
        '
        Me.TBL_CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBL_CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("TBL_CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TBL_CustomersBindingNavigatorSaveItem.Name = "TBL_CustomersBindingNavigatorSaveItem"
        Me.TBL_CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TBL_CustomersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TBL_CustomersDataGridView
        '
        Me.TBL_CustomersDataGridView.AutoGenerateColumns = False
        Me.TBL_CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TBL_CustomersDataGridView.DataSource = Me.TBL_CustomersBindingSource
        Me.TBL_CustomersDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.TBL_CustomersDataGridView.Name = "TBL_CustomersDataGridView"
        Me.TBL_CustomersDataGridView.Size = New System.Drawing.Size(555, 308)
        Me.TBL_CustomersDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cus_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "รหัสลูกค้า"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cus_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ชื่อลูกค้า"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cus_Address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ที่อยู่"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cus_Birth"
        Me.DataGridViewTextBoxColumn4.HeaderText = "วัน เดือน ปี เกิด"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cus_Tel"
        Me.DataGridViewTextBoxColumn5.HeaderText = "เบอร์โทร"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Cus_TelLabel)
        Me.GroupBox1.Controls.Add(Me.Cus_TelTextBox)
        Me.GroupBox1.Controls.Add(Cus_BirthLabel)
        Me.GroupBox1.Controls.Add(Me.Cus_BirthDateTimePicker)
        Me.GroupBox1.Controls.Add(Cus_AddressLabel)
        Me.GroupBox1.Controls.Add(Me.Cus_AddressTextBox)
        Me.GroupBox1.Controls.Add(Cus_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Cus_NameTextBox)
        Me.GroupBox1.Controls.Add(Cus_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Cus_IDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 342)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 224)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลลูกกค้า"
        '
        'Cus_TelTextBox
        '
        Me.Cus_TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_CustomersBindingSource, "Cus_Tel", True))
        Me.Cus_TelTextBox.Enabled = False
        Me.Cus_TelTextBox.Location = New System.Drawing.Point(356, 90)
        Me.Cus_TelTextBox.Name = "Cus_TelTextBox"
        Me.Cus_TelTextBox.Size = New System.Drawing.Size(148, 20)
        Me.Cus_TelTextBox.TabIndex = 9
        '
        'Cus_BirthDateTimePicker
        '
        Me.Cus_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBL_CustomersBindingSource, "Cus_Birth", True))
        Me.Cus_BirthDateTimePicker.Enabled = False
        Me.Cus_BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Cus_BirthDateTimePicker.Location = New System.Drawing.Point(356, 52)
        Me.Cus_BirthDateTimePicker.Name = "Cus_BirthDateTimePicker"
        Me.Cus_BirthDateTimePicker.Size = New System.Drawing.Size(148, 20)
        Me.Cus_BirthDateTimePicker.TabIndex = 7
        '
        'Cus_AddressTextBox
        '
        Me.Cus_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_CustomersBindingSource, "Cus_Address", True))
        Me.Cus_AddressTextBox.Enabled = False
        Me.Cus_AddressTextBox.Location = New System.Drawing.Point(81, 124)
        Me.Cus_AddressTextBox.Multiline = True
        Me.Cus_AddressTextBox.Name = "Cus_AddressTextBox"
        Me.Cus_AddressTextBox.Size = New System.Drawing.Size(259, 80)
        Me.Cus_AddressTextBox.TabIndex = 5
        '
        'Cus_NameTextBox
        '
        Me.Cus_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_CustomersBindingSource, "Cus_Name", True))
        Me.Cus_NameTextBox.Enabled = False
        Me.Cus_NameTextBox.Location = New System.Drawing.Point(81, 87)
        Me.Cus_NameTextBox.Name = "Cus_NameTextBox"
        Me.Cus_NameTextBox.Size = New System.Drawing.Size(164, 20)
        Me.Cus_NameTextBox.TabIndex = 3
        '
        'Cus_IDTextBox
        '
        Me.Cus_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_CustomersBindingSource, "Cus_ID", True))
        Me.Cus_IDTextBox.Enabled = False
        Me.Cus_IDTextBox.Location = New System.Drawing.Point(81, 49)
        Me.Cus_IDTextBox.Name = "Cus_IDTextBox"
        Me.Cus_IDTextBox.Size = New System.Drawing.Size(164, 20)
        Me.Cus_IDTextBox.TabIndex = 1
        '
        'FRM_Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 576)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TBL_CustomersDataGridView)
        Me.Controls.Add(Me.TBL_CustomersBindingNavigator)
        Me.Name = "FRM_Customers"
        Me.Text = "FRM_Customers"
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TBL_CustomersBindingNavigator.ResumeLayout(False)
        Me.TBL_CustomersBindingNavigator.PerformLayout()
        CType(Me.TBL_CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _BikeRT_V2DataSet As BikeRT_V2._BikeRT_V2DataSet
    Friend WithEvents TBL_CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_CustomersTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_CustomersTableAdapter
    Friend WithEvents TableAdapterManager As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_CustomersBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBL_CustomersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBL_CustomersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cus_TelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cus_BirthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cus_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cus_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cus_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

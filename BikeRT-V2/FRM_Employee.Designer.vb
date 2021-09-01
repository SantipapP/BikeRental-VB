<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Employee
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
        Dim Em_IDLabel As System.Windows.Forms.Label
        Dim Em_PassLabel As System.Windows.Forms.Label
        Dim Em_LNameLabel As System.Windows.Forms.Label
        Dim Em_BirthLabel As System.Windows.Forms.Label
        Dim Em_AddressLabel As System.Windows.Forms.Label
        Dim Em_TelLabel As System.Windows.Forms.Label
        Dim Em_EmailLabel As System.Windows.Forms.Label
        Dim Em_NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Employee))
        Me._BikeRT_V2DataSet = New BikeRT_V2._BikeRT_V2DataSet()
        Me.TBL_EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_EmployeesTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_EmployeesTableAdapter()
        Me.TableAdapterManager = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager()
        Me.TBL_EmployeesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TBL_EmployeesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TBL_EmployeesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Em_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Em_EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Em_TelTextBox = New System.Windows.Forms.TextBox()
        Me.Em_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Em_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Em_LNameTextBox = New System.Windows.Forms.TextBox()
        Me.Em_PassTextBox = New System.Windows.Forms.TextBox()
        Me.Em_IDTextBox = New System.Windows.Forms.TextBox()
        Em_IDLabel = New System.Windows.Forms.Label()
        Em_PassLabel = New System.Windows.Forms.Label()
        Em_LNameLabel = New System.Windows.Forms.Label()
        Em_BirthLabel = New System.Windows.Forms.Label()
        Em_AddressLabel = New System.Windows.Forms.Label()
        Em_TelLabel = New System.Windows.Forms.Label()
        Em_EmailLabel = New System.Windows.Forms.Label()
        Em_NameLabel = New System.Windows.Forms.Label()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TBL_EmployeesBindingNavigator.SuspendLayout()
        CType(Me.TBL_EmployeesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Em_IDLabel
        '
        Em_IDLabel.AutoSize = True
        Em_IDLabel.Location = New System.Drawing.Point(14, 110)
        Em_IDLabel.Name = "Em_IDLabel"
        Em_IDLabel.Size = New System.Drawing.Size(70, 13)
        Em_IDLabel.TabIndex = 0
        Em_IDLabel.Text = "รหัสพนักงาน:"
        '
        'Em_PassLabel
        '
        Em_PassLabel.AutoSize = True
        Em_PassLabel.Location = New System.Drawing.Point(35, 136)
        Em_PassLabel.Name = "Em_PassLabel"
        Em_PassLabel.Size = New System.Drawing.Size(49, 13)
        Em_PassLabel.TabIndex = 2
        Em_PassLabel.Text = "รหัสผ่าน:"
        '
        'Em_LNameLabel
        '
        Em_LNameLabel.AutoSize = True
        Em_LNameLabel.Location = New System.Drawing.Point(35, 79)
        Em_LNameLabel.Name = "Em_LNameLabel"
        Em_LNameLabel.Size = New System.Drawing.Size(49, 13)
        Em_LNameLabel.TabIndex = 4
        Em_LNameLabel.Text = "นามสกุล:"
        '
        'Em_BirthLabel
        '
        Em_BirthLabel.AutoSize = True
        Em_BirthLabel.Location = New System.Drawing.Point(567, 59)
        Em_BirthLabel.Name = "Em_BirthLabel"
        Em_BirthLabel.Size = New System.Drawing.Size(85, 13)
        Em_BirthLabel.TabIndex = 6
        Em_BirthLabel.Text = "วัน เดือน ปี เกิด:"
        '
        'Em_AddressLabel
        '
        Em_AddressLabel.AutoSize = True
        Em_AddressLabel.Location = New System.Drawing.Point(263, 53)
        Em_AddressLabel.Name = "Em_AddressLabel"
        Em_AddressLabel.Size = New System.Drawing.Size(30, 13)
        Em_AddressLabel.TabIndex = 8
        Em_AddressLabel.Text = "ที่อยู่:"
        '
        'Em_TelLabel
        '
        Em_TelLabel.AutoSize = True
        Em_TelLabel.Location = New System.Drawing.Point(224, 113)
        Em_TelLabel.Name = "Em_TelLabel"
        Em_TelLabel.Size = New System.Drawing.Size(69, 13)
        Em_TelLabel.TabIndex = 10
        Em_TelLabel.Text = "เบอโทรศัพท์:"
        '
        'Em_EmailLabel
        '
        Em_EmailLabel.AutoSize = True
        Em_EmailLabel.Location = New System.Drawing.Point(258, 139)
        Em_EmailLabel.Name = "Em_EmailLabel"
        Em_EmailLabel.Size = New System.Drawing.Size(35, 13)
        Em_EmailLabel.TabIndex = 12
        Em_EmailLabel.Text = "Email:"
        '
        'Em_NameLabel
        '
        Em_NameLabel.AutoSize = True
        Em_NameLabel.Location = New System.Drawing.Point(20, 53)
        Em_NameLabel.Name = "Em_NameLabel"
        Em_NameLabel.Size = New System.Drawing.Size(64, 13)
        Em_NameLabel.TabIndex = 14
        Em_NameLabel.Text = "ชื่อพนักงาน:"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AdminTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BikeTableAdapter = Nothing
        Me.TableAdapterManager.TBL_CustomersTableAdapter = Nothing
        Me.TableAdapterManager.TBL_EmployeesTableAdapter = Me.TBL_EmployeesTableAdapter
        Me.TableAdapterManager.TBL_InTableAdapter = Nothing
        Me.TableAdapterManager.TBL_RTableAdapter = Nothing
        Me.TableAdapterManager.TBL_SubTableAdapter = Nothing
        Me.TableAdapterManager.TBL_TTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_EmployeesBindingNavigator
        '
        Me.TBL_EmployeesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TBL_EmployeesBindingNavigator.BindingSource = Me.TBL_EmployeesBindingSource
        Me.TBL_EmployeesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TBL_EmployeesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TBL_EmployeesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TBL_EmployeesBindingNavigatorSaveItem})
        Me.TBL_EmployeesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TBL_EmployeesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TBL_EmployeesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TBL_EmployeesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TBL_EmployeesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TBL_EmployeesBindingNavigator.Name = "TBL_EmployeesBindingNavigator"
        Me.TBL_EmployeesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TBL_EmployeesBindingNavigator.Size = New System.Drawing.Size(873, 25)
        Me.TBL_EmployeesBindingNavigator.TabIndex = 0
        Me.TBL_EmployeesBindingNavigator.Text = "BindingNavigator1"
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
        'TBL_EmployeesBindingNavigatorSaveItem
        '
        Me.TBL_EmployeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBL_EmployeesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TBL_EmployeesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TBL_EmployeesBindingNavigatorSaveItem.Name = "TBL_EmployeesBindingNavigatorSaveItem"
        Me.TBL_EmployeesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TBL_EmployeesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TBL_EmployeesDataGridView
        '
        Me.TBL_EmployeesDataGridView.AutoGenerateColumns = False
        Me.TBL_EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_EmployeesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TBL_EmployeesDataGridView.DataSource = Me.TBL_EmployeesBindingSource
        Me.TBL_EmployeesDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.TBL_EmployeesDataGridView.Name = "TBL_EmployeesDataGridView"
        Me.TBL_EmployeesDataGridView.Size = New System.Drawing.Size(849, 220)
        Me.TBL_EmployeesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Em_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "รหัสพนักงาน"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Em_Pass"
        Me.DataGridViewTextBoxColumn2.HeaderText = "รหัสผ่าน"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Em_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ชื่อพนักงาน"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Em_LName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "นามสกุล"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Em_Birth"
        Me.DataGridViewTextBoxColumn5.HeaderText = "วัน เดือน ปี เกิด "
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Em_Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ที่อยู่"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Em_Tel"
        Me.DataGridViewTextBoxColumn7.HeaderText = "เบอร์โทร"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Em_Email"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Em_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Em_NameTextBox)
        Me.GroupBox1.Controls.Add(Em_EmailLabel)
        Me.GroupBox1.Controls.Add(Me.Em_EmailTextBox)
        Me.GroupBox1.Controls.Add(Em_TelLabel)
        Me.GroupBox1.Controls.Add(Me.Em_TelTextBox)
        Me.GroupBox1.Controls.Add(Em_AddressLabel)
        Me.GroupBox1.Controls.Add(Me.Em_AddressTextBox)
        Me.GroupBox1.Controls.Add(Em_BirthLabel)
        Me.GroupBox1.Controls.Add(Me.Em_BirthDateTimePicker)
        Me.GroupBox1.Controls.Add(Em_LNameLabel)
        Me.GroupBox1.Controls.Add(Me.Em_LNameTextBox)
        Me.GroupBox1.Controls.Add(Em_PassLabel)
        Me.GroupBox1.Controls.Add(Me.Em_PassTextBox)
        Me.GroupBox1.Controls.Add(Em_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Em_IDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(849, 162)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ลงทะเบียนพนักงาน"
        '
        'Em_NameTextBox
        '
        Me.Em_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_EmployeesBindingSource, "Em_Name", True))
        Me.Em_NameTextBox.Enabled = False
        Me.Em_NameTextBox.Location = New System.Drawing.Point(90, 50)
        Me.Em_NameTextBox.Name = "Em_NameTextBox"
        Me.Em_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Em_NameTextBox.TabIndex = 15
        '
        'Em_EmailTextBox
        '
        Me.Em_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_EmployeesBindingSource, "Em_Email", True))
        Me.Em_EmailTextBox.Enabled = False
        Me.Em_EmailTextBox.Location = New System.Drawing.Point(299, 136)
        Me.Em_EmailTextBox.Name = "Em_EmailTextBox"
        Me.Em_EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Em_EmailTextBox.TabIndex = 13
        '
        'Em_TelTextBox
        '
        Me.Em_TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_EmployeesBindingSource, "Em_Tel", True))
        Me.Em_TelTextBox.Enabled = False
        Me.Em_TelTextBox.Location = New System.Drawing.Point(299, 110)
        Me.Em_TelTextBox.Name = "Em_TelTextBox"
        Me.Em_TelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Em_TelTextBox.TabIndex = 11
        '
        'Em_AddressTextBox
        '
        Me.Em_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_EmployeesBindingSource, "Em_Address", True))
        Me.Em_AddressTextBox.Enabled = False
        Me.Em_AddressTextBox.Location = New System.Drawing.Point(299, 50)
        Me.Em_AddressTextBox.Multiline = True
        Me.Em_AddressTextBox.Name = "Em_AddressTextBox"
        Me.Em_AddressTextBox.Size = New System.Drawing.Size(250, 55)
        Me.Em_AddressTextBox.TabIndex = 9
        '
        'Em_BirthDateTimePicker
        '
        Me.Em_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBL_EmployeesBindingSource, "Em_Birth", True))
        Me.Em_BirthDateTimePicker.Enabled = False
        Me.Em_BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Em_BirthDateTimePicker.Location = New System.Drawing.Point(658, 53)
        Me.Em_BirthDateTimePicker.Name = "Em_BirthDateTimePicker"
        Me.Em_BirthDateTimePicker.Size = New System.Drawing.Size(125, 20)
        Me.Em_BirthDateTimePicker.TabIndex = 7
        '
        'Em_LNameTextBox
        '
        Me.Em_LNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_EmployeesBindingSource, "Em_LName", True))
        Me.Em_LNameTextBox.Enabled = False
        Me.Em_LNameTextBox.Location = New System.Drawing.Point(90, 76)
        Me.Em_LNameTextBox.Name = "Em_LNameTextBox"
        Me.Em_LNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Em_LNameTextBox.TabIndex = 5
        '
        'Em_PassTextBox
        '
        Me.Em_PassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_EmployeesBindingSource, "Em_Pass", True))
        Me.Em_PassTextBox.Enabled = False
        Me.Em_PassTextBox.Location = New System.Drawing.Point(90, 133)
        Me.Em_PassTextBox.Name = "Em_PassTextBox"
        Me.Em_PassTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Em_PassTextBox.TabIndex = 3
        '
        'Em_IDTextBox
        '
        Me.Em_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_EmployeesBindingSource, "Em_ID", True))
        Me.Em_IDTextBox.Enabled = False
        Me.Em_IDTextBox.Location = New System.Drawing.Point(90, 107)
        Me.Em_IDTextBox.Name = "Em_IDTextBox"
        Me.Em_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Em_IDTextBox.TabIndex = 1
        '
        'FRM_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 428)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TBL_EmployeesDataGridView)
        Me.Controls.Add(Me.TBL_EmployeesBindingNavigator)
        Me.Name = "FRM_Employee"
        Me.Text = "FRM_Employee"
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TBL_EmployeesBindingNavigator.ResumeLayout(False)
        Me.TBL_EmployeesBindingNavigator.PerformLayout()
        CType(Me.TBL_EmployeesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _BikeRT_V2DataSet As BikeRT_V2._BikeRT_V2DataSet
    Friend WithEvents TBL_EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_EmployeesTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_EmployeesTableAdapter
    Friend WithEvents TableAdapterManager As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_EmployeesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TBL_EmployeesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBL_EmployeesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Em_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Em_EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Em_TelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Em_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Em_BirthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Em_LNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Em_PassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Em_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

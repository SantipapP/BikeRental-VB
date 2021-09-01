<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_R
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
        Dim R_IDLabel As System.Windows.Forms.Label
        Dim R_CusLabel As System.Windows.Forms.Label
        Dim R_BikeLabel As System.Windows.Forms.Label
        Dim R_QryLabel As System.Windows.Forms.Label
        Dim R_StartLabel As System.Windows.Forms.Label
        Dim R_StopLabel As System.Windows.Forms.Label
        Dim R_TimesLabel As System.Windows.Forms.Label
        Dim R_PriceLabel As System.Windows.Forms.Label
        Dim R_pledgeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_R))
        Me._BikeRT_V2DataSet = New BikeRT_V2._BikeRT_V2DataSet()
        Me.TBL_RBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_RTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_RTableAdapter()
        Me.TableAdapterManager = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager()
        Me.TBL_BikeTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_BikeTableAdapter()
        Me.TBL_CustomersTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_CustomersTableAdapter()
        Me.TBL_RBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TBL_RBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.R_IDTextBox = New System.Windows.Forms.TextBox()
        Me.R_CusComboBox = New System.Windows.Forms.ComboBox()
        Me.TBLCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_BikeComboBox = New System.Windows.Forms.ComboBox()
        Me.TBLBikeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_QryTextBox = New System.Windows.Forms.TextBox()
        Me.R_StartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.R_StopDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.R_TimesTextBox = New System.Windows.Forms.TextBox()
        Me.R_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.QRY_ReadyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QRY_ReadyTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.QRY_ReadyTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.QRY_ReadyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R_pledgeComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        R_IDLabel = New System.Windows.Forms.Label()
        R_CusLabel = New System.Windows.Forms.Label()
        R_BikeLabel = New System.Windows.Forms.Label()
        R_QryLabel = New System.Windows.Forms.Label()
        R_StartLabel = New System.Windows.Forms.Label()
        R_StopLabel = New System.Windows.Forms.Label()
        R_TimesLabel = New System.Windows.Forms.Label()
        R_PriceLabel = New System.Windows.Forms.Label()
        R_pledgeLabel = New System.Windows.Forms.Label()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_RBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_RBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TBL_RBindingNavigator.SuspendLayout()
        CType(Me.TBLCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBikeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRY_ReadyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRY_ReadyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'R_IDLabel
        '
        R_IDLabel.AutoSize = True
        R_IDLabel.Location = New System.Drawing.Point(12, 38)
        R_IDLabel.Name = "R_IDLabel"
        R_IDLabel.Size = New System.Drawing.Size(64, 13)
        R_IDLabel.TabIndex = 1
        R_IDLabel.Text = "รหัสการเช่า:"
        '
        'R_CusLabel
        '
        R_CusLabel.AutoSize = True
        R_CusLabel.Location = New System.Drawing.Point(22, 73)
        R_CusLabel.Name = "R_CusLabel"
        R_CusLabel.Size = New System.Drawing.Size(54, 13)
        R_CusLabel.TabIndex = 3
        R_CusLabel.Text = "รหัสลูกค้า:"
        '
        'R_BikeLabel
        '
        R_BikeLabel.AutoSize = True
        R_BikeLabel.Location = New System.Drawing.Point(21, 111)
        R_BikeLabel.Name = "R_BikeLabel"
        R_BikeLabel.Size = New System.Drawing.Size(55, 13)
        R_BikeLabel.TabIndex = 5
        R_BikeLabel.Text = "รหัสสินค้า:"
        '
        'R_QryLabel
        '
        R_QryLabel.AutoSize = True
        R_QryLabel.Location = New System.Drawing.Point(33, 150)
        R_QryLabel.Name = "R_QryLabel"
        R_QryLabel.Size = New System.Drawing.Size(43, 13)
        R_QryLabel.TabIndex = 7
        R_QryLabel.Text = "จำนวน:"
        '
        'R_StartLabel
        '
        R_StartLabel.AutoSize = True
        R_StartLabel.Location = New System.Drawing.Point(9, 218)
        R_StartLabel.Name = "R_StartLabel"
        R_StartLabel.Size = New System.Drawing.Size(67, 13)
        R_StartLabel.TabIndex = 9
        R_StartLabel.Text = "เวลาเริ่มเช่า:"
        '
        'R_StopLabel
        '
        R_StopLabel.AutoSize = True
        R_StopLabel.Location = New System.Drawing.Point(29, 254)
        R_StopLabel.Name = "R_StopLabel"
        R_StopLabel.Size = New System.Drawing.Size(47, 13)
        R_StopLabel.TabIndex = 11
        R_StopLabel.Text = "เวลาคืน:"
        '
        'R_TimesLabel
        '
        R_TimesLabel.AutoSize = True
        R_TimesLabel.Location = New System.Drawing.Point(11, 287)
        R_TimesLabel.Name = "R_TimesLabel"
        R_TimesLabel.Size = New System.Drawing.Size(65, 13)
        R_TimesLabel.TabIndex = 13
        R_TimesLabel.Text = "จำนวนเวลา:"
        '
        'R_PriceLabel
        '
        R_PriceLabel.AutoSize = True
        R_PriceLabel.Location = New System.Drawing.Point(37, 324)
        R_PriceLabel.Name = "R_PriceLabel"
        R_PriceLabel.Size = New System.Drawing.Size(39, 13)
        R_PriceLabel.TabIndex = 15
        R_PriceLabel.Text = "ค่าเช่า:"
        '
        'R_pledgeLabel
        '
        R_pledgeLabel.AutoSize = True
        R_pledgeLabel.Location = New System.Drawing.Point(30, 182)
        R_pledgeLabel.Name = "R_pledgeLabel"
        R_pledgeLabel.Size = New System.Drawing.Size(46, 13)
        R_pledgeLabel.TabIndex = 20
        R_pledgeLabel.Text = "สิ่งมัดจำ:"
        '
        '_BikeRT_V2DataSet
        '
        Me._BikeRT_V2DataSet.DataSetName = "_BikeRT_V2DataSet"
        Me._BikeRT_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_RBindingSource
        '
        Me.TBL_RBindingSource.DataMember = "TBL_R"
        Me.TBL_RBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        'TBL_RTableAdapter
        '
        Me.TBL_RTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AdminTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BikeTableAdapter = Me.TBL_BikeTableAdapter
        Me.TableAdapterManager.TBL_CustomersTableAdapter = Me.TBL_CustomersTableAdapter
        Me.TableAdapterManager.TBL_EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.TBL_InTableAdapter = Nothing
        Me.TableAdapterManager.TBL_RTableAdapter = Me.TBL_RTableAdapter
        Me.TableAdapterManager.TBL_SubTableAdapter = Nothing
        Me.TableAdapterManager.TBL_TTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_BikeTableAdapter
        '
        Me.TBL_BikeTableAdapter.ClearBeforeFill = True
        '
        'TBL_CustomersTableAdapter
        '
        Me.TBL_CustomersTableAdapter.ClearBeforeFill = True
        '
        'TBL_RBindingNavigator
        '
        Me.TBL_RBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TBL_RBindingNavigator.BindingSource = Me.TBL_RBindingSource
        Me.TBL_RBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TBL_RBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TBL_RBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TBL_RBindingNavigatorSaveItem})
        Me.TBL_RBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TBL_RBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TBL_RBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TBL_RBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TBL_RBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TBL_RBindingNavigator.Name = "TBL_RBindingNavigator"
        Me.TBL_RBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TBL_RBindingNavigator.Size = New System.Drawing.Size(773, 25)
        Me.TBL_RBindingNavigator.TabIndex = 0
        Me.TBL_RBindingNavigator.Text = "BindingNavigator1"
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
        'TBL_RBindingNavigatorSaveItem
        '
        Me.TBL_RBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBL_RBindingNavigatorSaveItem.Image = CType(resources.GetObject("TBL_RBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TBL_RBindingNavigatorSaveItem.Name = "TBL_RBindingNavigatorSaveItem"
        Me.TBL_RBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TBL_RBindingNavigatorSaveItem.Text = "Save Data"
        '
        'R_IDTextBox
        '
        Me.R_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_RBindingSource, "R_ID", True))
        Me.R_IDTextBox.Enabled = False
        Me.R_IDTextBox.Location = New System.Drawing.Point(96, 35)
        Me.R_IDTextBox.Name = "R_IDTextBox"
        Me.R_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.R_IDTextBox.TabIndex = 2
        '
        'R_CusComboBox
        '
        Me.R_CusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_RBindingSource, "R_Cus", True))
        Me.R_CusComboBox.DataSource = Me.TBLCustomersBindingSource
        Me.R_CusComboBox.DisplayMember = "Cus_ID"
        Me.R_CusComboBox.Enabled = False
        Me.R_CusComboBox.FormattingEnabled = True
        Me.R_CusComboBox.Location = New System.Drawing.Point(96, 70)
        Me.R_CusComboBox.Name = "R_CusComboBox"
        Me.R_CusComboBox.Size = New System.Drawing.Size(121, 21)
        Me.R_CusComboBox.TabIndex = 4
        '
        'TBLCustomersBindingSource
        '
        Me.TBLCustomersBindingSource.DataMember = "TBL_Customers"
        Me.TBLCustomersBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        'R_BikeComboBox
        '
        Me.R_BikeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_RBindingSource, "R_Bike", True))
        Me.R_BikeComboBox.DataSource = Me.TBLBikeBindingSource
        Me.R_BikeComboBox.DisplayMember = "Bike_ID"
        Me.R_BikeComboBox.Enabled = False
        Me.R_BikeComboBox.FormattingEnabled = True
        Me.R_BikeComboBox.Location = New System.Drawing.Point(96, 108)
        Me.R_BikeComboBox.Name = "R_BikeComboBox"
        Me.R_BikeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.R_BikeComboBox.TabIndex = 6
        '
        'TBLBikeBindingSource
        '
        Me.TBLBikeBindingSource.DataMember = "TBL_Bike"
        Me.TBLBikeBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        'R_QryTextBox
        '
        Me.R_QryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_RBindingSource, "R_Qry", True))
        Me.R_QryTextBox.Enabled = False
        Me.R_QryTextBox.Location = New System.Drawing.Point(96, 147)
        Me.R_QryTextBox.Name = "R_QryTextBox"
        Me.R_QryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.R_QryTextBox.TabIndex = 8
        '
        'R_StartDateTimePicker
        '
        Me.R_StartDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBL_RBindingSource, "R_Start", True))
        Me.R_StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.R_StartDateTimePicker.Location = New System.Drawing.Point(96, 212)
        Me.R_StartDateTimePicker.Name = "R_StartDateTimePicker"
        Me.R_StartDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.R_StartDateTimePicker.TabIndex = 10
        '
        'R_StopDateTimePicker
        '
        Me.R_StopDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBL_RBindingSource, "R_Stop", True))
        Me.R_StopDateTimePicker.Enabled = False
        Me.R_StopDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.R_StopDateTimePicker.Location = New System.Drawing.Point(96, 248)
        Me.R_StopDateTimePicker.Name = "R_StopDateTimePicker"
        Me.R_StopDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.R_StopDateTimePicker.TabIndex = 12
        '
        'R_TimesTextBox
        '
        Me.R_TimesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_RBindingSource, "R_Times", True))
        Me.R_TimesTextBox.Enabled = False
        Me.R_TimesTextBox.Location = New System.Drawing.Point(96, 284)
        Me.R_TimesTextBox.Name = "R_TimesTextBox"
        Me.R_TimesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.R_TimesTextBox.TabIndex = 14
        '
        'R_PriceTextBox
        '
        Me.R_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_RBindingSource, "R_Price", True))
        Me.R_PriceTextBox.Enabled = False
        Me.R_PriceTextBox.Location = New System.Drawing.Point(96, 321)
        Me.R_PriceTextBox.Name = "R_PriceTextBox"
        Me.R_PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.R_PriceTextBox.TabIndex = 16
        '
        'QRY_ReadyBindingSource
        '
        Me.QRY_ReadyBindingSource.DataMember = "QRY_Ready"
        Me.QRY_ReadyBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        'QRY_ReadyTableAdapter
        '
        Me.QRY_ReadyTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 29)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(384, 308)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 29)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'QRY_ReadyDataGridView
        '
        Me.QRY_ReadyDataGridView.AllowUserToOrderColumns = True
        Me.QRY_ReadyDataGridView.AutoGenerateColumns = False
        Me.QRY_ReadyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QRY_ReadyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.QRY_ReadyDataGridView.DataSource = Me.QRY_ReadyBindingSource
        Me.QRY_ReadyDataGridView.Location = New System.Drawing.Point(274, 35)
        Me.QRY_ReadyDataGridView.Name = "QRY_ReadyDataGridView"
        Me.QRY_ReadyDataGridView.Size = New System.Drawing.Size(450, 246)
        Me.QRY_ReadyDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Bike_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "รหัสสินค้า"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Bike_Gen"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ชื่อสินค้า"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Qty"
        Me.DataGridViewTextBoxColumn3.HeaderText = "จำนวนที่เหลือ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn4.HeaderText = "สถานะ"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'R_pledgeComboBox
        '
        Me.R_pledgeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_RBindingSource, "R_pledge", True))
        Me.R_pledgeComboBox.FormattingEnabled = True
        Me.R_pledgeComboBox.Items.AddRange(New Object() {"บัตรประชาชน", "พาสสปอตร์"})
        Me.R_pledgeComboBox.Location = New System.Drawing.Point(96, 179)
        Me.R_pledgeComboBox.Name = "R_pledgeComboBox"
        Me.R_pledgeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.R_pledgeComboBox.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.QRY_ReadyDataGridView)
        Me.GroupBox1.Controls.Add(R_pledgeLabel)
        Me.GroupBox1.Controls.Add(Me.R_IDTextBox)
        Me.GroupBox1.Controls.Add(Me.R_pledgeComboBox)
        Me.GroupBox1.Controls.Add(R_IDLabel)
        Me.GroupBox1.Controls.Add(Me.R_CusComboBox)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(R_CusLabel)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.R_BikeComboBox)
        Me.GroupBox1.Controls.Add(R_PriceLabel)
        Me.GroupBox1.Controls.Add(R_BikeLabel)
        Me.GroupBox1.Controls.Add(Me.R_PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.R_QryTextBox)
        Me.GroupBox1.Controls.Add(R_TimesLabel)
        Me.GroupBox1.Controls.Add(R_QryLabel)
        Me.GroupBox1.Controls.Add(Me.R_TimesTextBox)
        Me.GroupBox1.Controls.Add(Me.R_StartDateTimePicker)
        Me.GroupBox1.Controls.Add(R_StopLabel)
        Me.GroupBox1.Controls.Add(R_StartLabel)
        Me.GroupBox1.Controls.Add(Me.R_StopDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(747, 358)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "งานเช่า"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(591, 308)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 29)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Print"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(483, 308)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 29)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 393)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(747, 159)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ส่วนสรุปผล"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(735, 134)
        Me.TextBox1.TabIndex = 0
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'FRM_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TBL_RBindingNavigator)
        Me.Name = "FRM_R"
        Me.Text = "FRM_R"
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_RBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_RBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TBL_RBindingNavigator.ResumeLayout(False)
        Me.TBL_RBindingNavigator.PerformLayout()
        CType(Me.TBLCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBikeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRY_ReadyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRY_ReadyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _BikeRT_V2DataSet As BikeRT_V2._BikeRT_V2DataSet
    Friend WithEvents TBL_RBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_RTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_RTableAdapter
    Friend WithEvents TableAdapterManager As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_RBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TBL_RBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents R_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_CusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents R_BikeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents R_QryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_StartDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents R_StopDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents R_TimesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QRY_ReadyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QRY_ReadyTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.QRY_ReadyTableAdapter
    Friend WithEvents TBL_CustomersTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_CustomersTableAdapter
    Friend WithEvents TBLCustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_BikeTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_BikeTableAdapter
    Friend WithEvents TBLBikeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents QRY_ReadyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents R_pledgeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class

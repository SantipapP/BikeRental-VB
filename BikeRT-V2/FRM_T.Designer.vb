<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_T
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
        Dim T_IDLabel As System.Windows.Forms.Label
        Dim T_CusLabel As System.Windows.Forms.Label
        Dim T_BikeLabel As System.Windows.Forms.Label
        Dim T_QryLabel As System.Windows.Forms.Label
        Dim T_StartLabel As System.Windows.Forms.Label
        Dim T_StopLabel As System.Windows.Forms.Label
        Dim T_TStopLabel As System.Windows.Forms.Label
        Dim T_RatePriceLabel As System.Windows.Forms.Label
        Dim T_DamageLabel As System.Windows.Forms.Label
        Dim T_DPriceLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_T))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TBL_TDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_TBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BikeRT_V2DataSet = New BikeRT_V2._BikeRT_V2DataSet()
        Me.T_DPriceTextBox = New System.Windows.Forms.TextBox()
        Me.T_DamageTextBox = New System.Windows.Forms.TextBox()
        Me.T_RatePriceTextBox = New System.Windows.Forms.TextBox()
        Me.T_TStopDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.T_StopDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.T_StartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.T_QryTextBox = New System.Windows.Forms.TextBox()
        Me.T_BikeComboBox = New System.Windows.Forms.ComboBox()
        Me.TBLBikeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_CusComboBox = New System.Windows.Forms.ComboBox()
        Me.TBLCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_IDTextBox = New System.Windows.Forms.TextBox()
        Me.TBL_TTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_TTableAdapter()
        Me.TableAdapterManager = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager()
        Me.TBL_BikeTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_BikeTableAdapter()
        Me.TBL_CustomersTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_CustomersTableAdapter()
        Me.TBL_TBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TBL_TBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        T_IDLabel = New System.Windows.Forms.Label()
        T_CusLabel = New System.Windows.Forms.Label()
        T_BikeLabel = New System.Windows.Forms.Label()
        T_QryLabel = New System.Windows.Forms.Label()
        T_StartLabel = New System.Windows.Forms.Label()
        T_StopLabel = New System.Windows.Forms.Label()
        T_TStopLabel = New System.Windows.Forms.Label()
        T_RatePriceLabel = New System.Windows.Forms.Label()
        T_DamageLabel = New System.Windows.Forms.Label()
        T_DPriceLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TBL_TDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_TBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBikeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_TBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TBL_TBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'T_IDLabel
        '
        T_IDLabel.AutoSize = True
        T_IDLabel.Location = New System.Drawing.Point(35, 27)
        T_IDLabel.Name = "T_IDLabel"
        T_IDLabel.Size = New System.Drawing.Size(49, 13)
        T_IDLabel.TabIndex = 0
        T_IDLabel.Text = "เลขที่คืน:"
        '
        'T_CusLabel
        '
        T_CusLabel.AutoSize = True
        T_CusLabel.Location = New System.Drawing.Point(30, 53)
        T_CusLabel.Name = "T_CusLabel"
        T_CusLabel.Size = New System.Drawing.Size(54, 13)
        T_CusLabel.TabIndex = 2
        T_CusLabel.Text = "รหัสลูกค้า:"
        '
        'T_BikeLabel
        '
        T_BikeLabel.AutoSize = True
        T_BikeLabel.Location = New System.Drawing.Point(229, 30)
        T_BikeLabel.Name = "T_BikeLabel"
        T_BikeLabel.Size = New System.Drawing.Size(55, 13)
        T_BikeLabel.TabIndex = 4
        T_BikeLabel.Text = "รหัสสินค้า:"
        '
        'T_QryLabel
        '
        T_QryLabel.AutoSize = True
        T_QryLabel.Location = New System.Drawing.Point(42, 80)
        T_QryLabel.Name = "T_QryLabel"
        T_QryLabel.Size = New System.Drawing.Size(43, 13)
        T_QryLabel.TabIndex = 6
        T_QryLabel.Text = "จำนวน:"
        '
        'T_StartLabel
        '
        T_StartLabel.AutoSize = True
        T_StartLabel.Location = New System.Drawing.Point(463, 31)
        T_StartLabel.Name = "T_StartLabel"
        T_StartLabel.Size = New System.Drawing.Size(50, 13)
        T_StartLabel.TabIndex = 8
        T_StartLabel.Text = "เวลาเริ่ม:"
        '
        'T_StopLabel
        '
        T_StopLabel.AutoSize = True
        T_StopLabel.Location = New System.Drawing.Point(466, 55)
        T_StopLabel.Name = "T_StopLabel"
        T_StopLabel.Size = New System.Drawing.Size(47, 13)
        T_StopLabel.TabIndex = 10
        T_StopLabel.Text = "เวลาคืน:"
        '
        'T_TStopLabel
        '
        T_TStopLabel.AutoSize = True
        T_TStopLabel.Location = New System.Drawing.Point(434, 80)
        T_TStopLabel.Name = "T_TStopLabel"
        T_TStopLabel.Size = New System.Drawing.Size(79, 13)
        T_TStopLabel.TabIndex = 12
        T_TStopLabel.Text = "เวลาที่นำมาคืน:"
        '
        'T_RatePriceLabel
        '
        T_RatePriceLabel.AutoSize = True
        T_RatePriceLabel.Location = New System.Drawing.Point(652, 53)
        T_RatePriceLabel.Name = "T_RatePriceLabel"
        T_RatePriceLabel.Size = New System.Drawing.Size(84, 13)
        T_RatePriceLabel.TabIndex = 14
        T_RatePriceLabel.Text = "ค่าปรับเกินเวลา:"
        '
        'T_DamageLabel
        '
        T_DamageLabel.AutoSize = True
        T_DamageLabel.Location = New System.Drawing.Point(664, 95)
        T_DamageLabel.Name = "T_DamageLabel"
        T_DamageLabel.Size = New System.Drawing.Size(72, 13)
        T_DamageLabel.TabIndex = 16
        T_DamageLabel.Text = "ความเสียหาย:"
        '
        'T_DPriceLabel
        '
        T_DPriceLabel.AutoSize = True
        T_DPriceLabel.Location = New System.Drawing.Point(677, 147)
        T_DPriceLabel.Name = "T_DPriceLabel"
        T_DPriceLabel.Size = New System.Drawing.Size(59, 13)
        T_DPriceLabel.TabIndex = 18
        T_DPriceLabel.Text = "ค่าเสียหาย:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(677, 28)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 13)
        Label1.TabIndex = 23
        Label1.Text = "เวลาที่เกิน:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TBL_TDataGridView)
        Me.GroupBox1.Controls.Add(T_DPriceLabel)
        Me.GroupBox1.Controls.Add(Me.T_DPriceTextBox)
        Me.GroupBox1.Controls.Add(T_DamageLabel)
        Me.GroupBox1.Controls.Add(Me.T_DamageTextBox)
        Me.GroupBox1.Controls.Add(T_RatePriceLabel)
        Me.GroupBox1.Controls.Add(Me.T_RatePriceTextBox)
        Me.GroupBox1.Controls.Add(T_TStopLabel)
        Me.GroupBox1.Controls.Add(Me.T_TStopDateTimePicker)
        Me.GroupBox1.Controls.Add(T_StopLabel)
        Me.GroupBox1.Controls.Add(Me.T_StopDateTimePicker)
        Me.GroupBox1.Controls.Add(T_StartLabel)
        Me.GroupBox1.Controls.Add(Me.T_StartDateTimePicker)
        Me.GroupBox1.Controls.Add(T_QryLabel)
        Me.GroupBox1.Controls.Add(Me.T_QryTextBox)
        Me.GroupBox1.Controls.Add(T_BikeLabel)
        Me.GroupBox1.Controls.Add(Me.T_BikeComboBox)
        Me.GroupBox1.Controls.Add(T_CusLabel)
        Me.GroupBox1.Controls.Add(Me.T_CusComboBox)
        Me.GroupBox1.Controls.Add(T_IDLabel)
        Me.GroupBox1.Controls.Add(Me.T_IDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1064, 416)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "งานคืนสินค้า"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(742, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 21
        '
        'TBL_TDataGridView
        '
        Me.TBL_TDataGridView.AutoGenerateColumns = False
        Me.TBL_TDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_TDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TBL_TDataGridView.DataSource = Me.TBL_TBindingSource
        Me.TBL_TDataGridView.Location = New System.Drawing.Point(11, 181)
        Me.TBL_TDataGridView.Name = "TBL_TDataGridView"
        Me.TBL_TDataGridView.Size = New System.Drawing.Size(1047, 220)
        Me.TBL_TDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "T_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "เลขที่คืน"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "T_Cus"
        Me.DataGridViewTextBoxColumn2.HeaderText = "รหัสลูกค้า"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "T_Bike"
        Me.DataGridViewTextBoxColumn3.HeaderText = "รหัสสินค้า"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "T_Qry"
        Me.DataGridViewTextBoxColumn4.HeaderText = "จำนวน"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "T_Start"
        Me.DataGridViewTextBoxColumn5.HeaderText = "เวลาเช่า"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "T_Stop"
        Me.DataGridViewTextBoxColumn6.HeaderText = "เวลาคืน"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "T_TStop"
        Me.DataGridViewTextBoxColumn7.HeaderText = "เวลาที่นำมาคืน"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "T_RatePrice"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ค่าปรับเกินเวลา"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "T_Damage"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ความเสียหาย"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "T_DPrice"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ค่าเสียหาย"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'TBL_TBindingSource
        '
        Me.TBL_TBindingSource.DataMember = "TBL_T"
        Me.TBL_TBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        '_BikeRT_V2DataSet
        '
        Me._BikeRT_V2DataSet.DataSetName = "_BikeRT_V2DataSet"
        Me._BikeRT_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_DPriceTextBox
        '
        Me.T_DPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_TBindingSource, "T_DPrice", True))
        Me.T_DPriceTextBox.Enabled = False
        Me.T_DPriceTextBox.Location = New System.Drawing.Point(742, 144)
        Me.T_DPriceTextBox.Name = "T_DPriceTextBox"
        Me.T_DPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.T_DPriceTextBox.TabIndex = 19
        '
        'T_DamageTextBox
        '
        Me.T_DamageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_TBindingSource, "T_Damage", True))
        Me.T_DamageTextBox.Enabled = False
        Me.T_DamageTextBox.Location = New System.Drawing.Point(742, 92)
        Me.T_DamageTextBox.Multiline = True
        Me.T_DamageTextBox.Name = "T_DamageTextBox"
        Me.T_DamageTextBox.Size = New System.Drawing.Size(200, 46)
        Me.T_DamageTextBox.TabIndex = 17
        '
        'T_RatePriceTextBox
        '
        Me.T_RatePriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_TBindingSource, "T_RatePrice", True))
        Me.T_RatePriceTextBox.Enabled = False
        Me.T_RatePriceTextBox.Location = New System.Drawing.Point(742, 50)
        Me.T_RatePriceTextBox.Name = "T_RatePriceTextBox"
        Me.T_RatePriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.T_RatePriceTextBox.TabIndex = 15
        '
        'T_TStopDateTimePicker
        '
        Me.T_TStopDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBL_TBindingSource, "T_TStop", True))
        Me.T_TStopDateTimePicker.Enabled = False
        Me.T_TStopDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.T_TStopDateTimePicker.Location = New System.Drawing.Point(519, 77)
        Me.T_TStopDateTimePicker.Name = "T_TStopDateTimePicker"
        Me.T_TStopDateTimePicker.Size = New System.Drawing.Size(116, 20)
        Me.T_TStopDateTimePicker.TabIndex = 13
        '
        'T_StopDateTimePicker
        '
        Me.T_StopDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBL_TBindingSource, "T_Stop", True))
        Me.T_StopDateTimePicker.Enabled = False
        Me.T_StopDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.T_StopDateTimePicker.Location = New System.Drawing.Point(519, 51)
        Me.T_StopDateTimePicker.Name = "T_StopDateTimePicker"
        Me.T_StopDateTimePicker.Size = New System.Drawing.Size(116, 20)
        Me.T_StopDateTimePicker.TabIndex = 11
        '
        'T_StartDateTimePicker
        '
        Me.T_StartDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBL_TBindingSource, "T_Start", True))
        Me.T_StartDateTimePicker.Enabled = False
        Me.T_StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.T_StartDateTimePicker.Location = New System.Drawing.Point(519, 25)
        Me.T_StartDateTimePicker.Name = "T_StartDateTimePicker"
        Me.T_StartDateTimePicker.Size = New System.Drawing.Size(116, 20)
        Me.T_StartDateTimePicker.TabIndex = 9
        '
        'T_QryTextBox
        '
        Me.T_QryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_TBindingSource, "T_Qry", True))
        Me.T_QryTextBox.Enabled = False
        Me.T_QryTextBox.Location = New System.Drawing.Point(90, 77)
        Me.T_QryTextBox.Name = "T_QryTextBox"
        Me.T_QryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.T_QryTextBox.TabIndex = 7
        '
        'T_BikeComboBox
        '
        Me.T_BikeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_TBindingSource, "T_Bike", True))
        Me.T_BikeComboBox.DataSource = Me.TBLBikeBindingSource
        Me.T_BikeComboBox.DisplayMember = "Bike_ID"
        Me.T_BikeComboBox.Enabled = False
        Me.T_BikeComboBox.FormattingEnabled = True
        Me.T_BikeComboBox.Location = New System.Drawing.Point(290, 27)
        Me.T_BikeComboBox.Name = "T_BikeComboBox"
        Me.T_BikeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.T_BikeComboBox.TabIndex = 5
        '
        'TBLBikeBindingSource
        '
        Me.TBLBikeBindingSource.DataMember = "TBL_Bike"
        Me.TBLBikeBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        'T_CusComboBox
        '
        Me.T_CusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_TBindingSource, "T_Cus", True))
        Me.T_CusComboBox.DataSource = Me.TBLCustomersBindingSource
        Me.T_CusComboBox.DisplayMember = "Cus_ID"
        Me.T_CusComboBox.Enabled = False
        Me.T_CusComboBox.FormattingEnabled = True
        Me.T_CusComboBox.Location = New System.Drawing.Point(90, 50)
        Me.T_CusComboBox.Name = "T_CusComboBox"
        Me.T_CusComboBox.Size = New System.Drawing.Size(121, 21)
        Me.T_CusComboBox.TabIndex = 3
        '
        'TBLCustomersBindingSource
        '
        Me.TBLCustomersBindingSource.DataMember = "TBL_Customers"
        Me.TBLCustomersBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        'T_IDTextBox
        '
        Me.T_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_TBindingSource, "T_ID", True))
        Me.T_IDTextBox.Enabled = False
        Me.T_IDTextBox.Location = New System.Drawing.Point(90, 24)
        Me.T_IDTextBox.Name = "T_IDTextBox"
        Me.T_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.T_IDTextBox.TabIndex = 1
        '
        'TBL_TTableAdapter
        '
        Me.TBL_TTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AdminTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BikeTableAdapter = Me.TBL_BikeTableAdapter
        Me.TableAdapterManager.TBL_CustomersTableAdapter = Me.TBL_CustomersTableAdapter
        Me.TableAdapterManager.TBL_EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.TBL_InTableAdapter = Nothing
        Me.TableAdapterManager.TBL_RTableAdapter = Nothing
        Me.TableAdapterManager.TBL_SubTableAdapter = Nothing
        Me.TableAdapterManager.TBL_TTableAdapter = Me.TBL_TTableAdapter
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
        'TBL_TBindingNavigator
        '
        Me.TBL_TBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TBL_TBindingNavigator.BindingSource = Me.TBL_TBindingSource
        Me.TBL_TBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TBL_TBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TBL_TBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TBL_TBindingNavigatorSaveItem})
        Me.TBL_TBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TBL_TBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TBL_TBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TBL_TBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TBL_TBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TBL_TBindingNavigator.Name = "TBL_TBindingNavigator"
        Me.TBL_TBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TBL_TBindingNavigator.Size = New System.Drawing.Size(1088, 25)
        Me.TBL_TBindingNavigator.TabIndex = 1
        Me.TBL_TBindingNavigator.Text = "BindingNavigator1"
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
        'TBL_TBindingNavigatorSaveItem
        '
        Me.TBL_TBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBL_TBindingNavigatorSaveItem.Image = CType(resources.GetObject("TBL_TBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TBL_TBindingNavigatorSaveItem.Name = "TBL_TBindingNavigatorSaveItem"
        Me.TBL_TBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TBL_TBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FRM_T
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 461)
        Me.Controls.Add(Me.TBL_TBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRM_T"
        Me.Text = "FRM_T"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TBL_TDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_TBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBikeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_TBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TBL_TBindingNavigator.ResumeLayout(False)
        Me.TBL_TBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _BikeRT_V2DataSet As BikeRT_V2._BikeRT_V2DataSet
    Friend WithEvents TBL_TBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_TTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_TTableAdapter
    Friend WithEvents TableAdapterManager As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_TBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TBL_TBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents T_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents T_DPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents T_DamageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents T_RatePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents T_TStopDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents T_StopDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents T_StartDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents T_QryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents T_BikeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents T_CusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TBL_CustomersTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_CustomersTableAdapter
    Friend WithEvents TBLCustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_BikeTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_BikeTableAdapter
    Friend WithEvents TBLBikeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TBL_TDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

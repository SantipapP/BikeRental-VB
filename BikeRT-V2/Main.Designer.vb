<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.สนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.เพมสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รบสนคาเขาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ระบบสมาชกToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.สมครสมาชกToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.งานเชาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.งานคนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.งานบคคลToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.เพมพนกงานToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายชอพนกงานทงหมดToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายการสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.สนคาทถกเชามากทสดToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายการสนคาToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ยอกคงเหลอสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ประวตการเชาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.การเชาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.การคนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ลกคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ยอดการเชาของลกคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายชอสมาชกToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.การเงนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ยอดคาเชาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ออกจากระบบToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me._BikeRT_V2DataSet = New BikeRT_V2._BikeRT_V2DataSet()
        Me.TBL_InBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_InTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_InTableAdapter()
        Me.TableAdapterManager = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RCusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RBikeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RQryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RpledgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RStopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RTimesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_RTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_RTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_InBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.สนคาToolStripMenuItem, Me.ระบบสมาชกToolStripMenuItem, Me.งานเชาToolStripMenuItem, Me.งานคนToolStripMenuItem, Me.งานบคคลToolStripMenuItem, Me.รายงานToolStripMenuItem, Me.ออกจากระบบToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(972, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'สนคาToolStripMenuItem
        '
        Me.สนคาToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.เพมสนคาToolStripMenuItem, Me.รบสนคาเขาToolStripMenuItem})
        Me.สนคาToolStripMenuItem.Name = "สนคาToolStripMenuItem"
        Me.สนคาToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.สนคาToolStripMenuItem.Text = "สินค้า"
        '
        'เพมสนคาToolStripMenuItem
        '
        Me.เพมสนคาToolStripMenuItem.Name = "เพมสนคาToolStripMenuItem"
        Me.เพมสนคาToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.เพมสนคาToolStripMenuItem.Text = "เพิ่มสินค้า"
        '
        'รบสนคาเขาToolStripMenuItem
        '
        Me.รบสนคาเขาToolStripMenuItem.Name = "รบสนคาเขาToolStripMenuItem"
        Me.รบสนคาเขาToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.รบสนคาเขาToolStripMenuItem.Text = "รับสินค้าเข้า"
        '
        'ระบบสมาชกToolStripMenuItem
        '
        Me.ระบบสมาชกToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.สมครสมาชกToolStripMenuItem})
        Me.ระบบสมาชกToolStripMenuItem.Name = "ระบบสมาชกToolStripMenuItem"
        Me.ระบบสมาชกToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.ระบบสมาชกToolStripMenuItem.Text = "ระบบสมาชิก"
        '
        'สมครสมาชกToolStripMenuItem
        '
        Me.สมครสมาชกToolStripMenuItem.Name = "สมครสมาชกToolStripMenuItem"
        Me.สมครสมาชกToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.สมครสมาชกToolStripMenuItem.Text = "สมัครสมาชิก"
        '
        'งานเชาToolStripMenuItem
        '
        Me.งานเชาToolStripMenuItem.Name = "งานเชาToolStripMenuItem"
        Me.งานเชาToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.งานเชาToolStripMenuItem.Text = "งานเช่า"
        '
        'งานคนToolStripMenuItem
        '
        Me.งานคนToolStripMenuItem.Name = "งานคนToolStripMenuItem"
        Me.งานคนToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.งานคนToolStripMenuItem.Text = "งานคืน"
        '
        'งานบคคลToolStripMenuItem
        '
        Me.งานบคคลToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.เพมพนกงานToolStripMenuItem, Me.รายชอพนกงานทงหมดToolStripMenuItem})
        Me.งานบคคลToolStripMenuItem.Name = "งานบคคลToolStripMenuItem"
        Me.งานบคคลToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.งานบคคลToolStripMenuItem.Text = "งานบุคคล"
        '
        'เพมพนกงานToolStripMenuItem
        '
        Me.เพมพนกงานToolStripMenuItem.Name = "เพมพนกงานToolStripMenuItem"
        Me.เพมพนกงานToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.เพมพนกงานToolStripMenuItem.Text = "เพิ่่มพนักงาน"
        '
        'รายชอพนกงานทงหมดToolStripMenuItem
        '
        Me.รายชอพนกงานทงหมดToolStripMenuItem.Name = "รายชอพนกงานทงหมดToolStripMenuItem"
        Me.รายชอพนกงานทงหมดToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.รายชอพนกงานทงหมดToolStripMenuItem.Text = "รายชื่อพนักงานทั้งหมด"
        '
        'รายงานToolStripMenuItem
        '
        Me.รายงานToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.รายการสนคาToolStripMenuItem, Me.ประวตการเชาToolStripMenuItem, Me.ลกคาToolStripMenuItem, Me.การเงนToolStripMenuItem})
        Me.รายงานToolStripMenuItem.Name = "รายงานToolStripMenuItem"
        Me.รายงานToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.รายงานToolStripMenuItem.Text = "รายงาน"
        '
        'รายการสนคาToolStripMenuItem
        '
        Me.รายการสนคาToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.สนคาทถกเชามากทสดToolStripMenuItem, Me.รายการสนคาToolStripMenuItem1, Me.ยอกคงเหลอสนคาToolStripMenuItem})
        Me.รายการสนคาToolStripMenuItem.Name = "รายการสนคาToolStripMenuItem"
        Me.รายการสนคาToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.รายการสนคาToolStripMenuItem.Text = "สินค้า"
        '
        'สนคาทถกเชามากทสดToolStripMenuItem
        '
        Me.สนคาทถกเชามากทสดToolStripMenuItem.Name = "สนคาทถกเชามากทสดToolStripMenuItem"
        Me.สนคาทถกเชามากทสดToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.สนคาทถกเชามากทสดToolStripMenuItem.Text = "สินค้าที่ถูกเช่ามากที่สุด"
        '
        'รายการสนคาToolStripMenuItem1
        '
        Me.รายการสนคาToolStripMenuItem1.Name = "รายการสนคาToolStripMenuItem1"
        Me.รายการสนคาToolStripMenuItem1.Size = New System.Drawing.Size(208, 24)
        Me.รายการสนคาToolStripMenuItem1.Text = "รายการสินค้า"
        '
        'ยอกคงเหลอสนคาToolStripMenuItem
        '
        Me.ยอกคงเหลอสนคาToolStripMenuItem.Name = "ยอกคงเหลอสนคาToolStripMenuItem"
        Me.ยอกคงเหลอสนคาToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.ยอกคงเหลอสนคาToolStripMenuItem.Text = "ยอดคงเหลือสินค้า"
        '
        'ประวตการเชาToolStripMenuItem
        '
        Me.ประวตการเชาToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.การเชาToolStripMenuItem, Me.การคนToolStripMenuItem})
        Me.ประวตการเชาToolStripMenuItem.Name = "ประวตการเชาToolStripMenuItem"
        Me.ประวตการเชาToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.ประวตการเชาToolStripMenuItem.Text = "ประวัติ"
        '
        'การเชาToolStripMenuItem
        '
        Me.การเชาToolStripMenuItem.Name = "การเชาToolStripMenuItem"
        Me.การเชาToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.การเชาToolStripMenuItem.Text = "การเช่า"
        '
        'การคนToolStripMenuItem
        '
        Me.การคนToolStripMenuItem.Name = "การคนToolStripMenuItem"
        Me.การคนToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.การคนToolStripMenuItem.Text = "การคืน"
        '
        'ลกคาToolStripMenuItem
        '
        Me.ลกคาToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ยอดการเชาของลกคาToolStripMenuItem, Me.รายชอสมาชกToolStripMenuItem})
        Me.ลกคาToolStripMenuItem.Name = "ลกคาToolStripMenuItem"
        Me.ลกคาToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.ลกคาToolStripMenuItem.Text = "ลูกค้า"
        '
        'ยอดการเชาของลกคาToolStripMenuItem
        '
        Me.ยอดการเชาของลกคาToolStripMenuItem.Name = "ยอดการเชาของลกคาToolStripMenuItem"
        Me.ยอดการเชาของลกคาToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.ยอดการเชาของลกคาToolStripMenuItem.Text = "ยอดการเช่าของสมาชิก"
        '
        'รายชอสมาชกToolStripMenuItem
        '
        Me.รายชอสมาชกToolStripMenuItem.Name = "รายชอสมาชกToolStripMenuItem"
        Me.รายชอสมาชกToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.รายชอสมาชกToolStripMenuItem.Text = "รายชื่อสมาชิก"
        '
        'การเงนToolStripMenuItem
        '
        Me.การเงนToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ยอดคาเชาToolStripMenuItem})
        Me.การเงนToolStripMenuItem.Name = "การเงนToolStripMenuItem"
        Me.การเงนToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.การเงนToolStripMenuItem.Text = "การเงิน"
        '
        'ยอดคาเชาToolStripMenuItem
        '
        Me.ยอดคาเชาToolStripMenuItem.Name = "ยอดคาเชาToolStripMenuItem"
        Me.ยอดคาเชาToolStripMenuItem.Size = New System.Drawing.Size(139, 24)
        Me.ยอดคาเชาToolStripMenuItem.Text = "ยอดค่าเช่า"
        '
        'ออกจากระบบToolStripMenuItem
        '
        Me.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem"
        Me.ออกจากระบบToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.ออกจากระบบToolStripMenuItem.Text = "ออกจากระบบ"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(626, 23)
        Me.Label1.TabIndex = 1
        '
        '_BikeRT_V2DataSet
        '
        Me._BikeRT_V2DataSet.DataSetName = "_BikeRT_V2DataSet"
        Me._BikeRT_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_InBindingSource
        '
        Me.TBL_InBindingSource.DataMember = "TBL_In"
        Me.TBL_InBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        'TBL_InTableAdapter
        '
        Me.TBL_InTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AdminTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BikeTableAdapter = Nothing
        Me.TableAdapterManager.TBL_CustomersTableAdapter = Nothing
        Me.TableAdapterManager.TBL_EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.TBL_InTableAdapter = Me.TBL_InTableAdapter
        Me.TableAdapterManager.TBL_RTableAdapter = Nothing
        Me.TableAdapterManager.TBL_SubTableAdapter = Nothing
        Me.TableAdapterManager.TBL_TTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RIDDataGridViewTextBoxColumn, Me.RCusDataGridViewTextBoxColumn, Me.RBikeDataGridViewTextBoxColumn, Me.RQryDataGridViewTextBoxColumn, Me.RpledgeDataGridViewTextBoxColumn, Me.RStartDataGridViewTextBoxColumn, Me.RStopDataGridViewTextBoxColumn, Me.RTimesDataGridViewTextBoxColumn, Me.RPriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TBLRBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(948, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'RIDDataGridViewTextBoxColumn
        '
        Me.RIDDataGridViewTextBoxColumn.DataPropertyName = "R_ID"
        Me.RIDDataGridViewTextBoxColumn.HeaderText = "เลขที่เช่า"
        Me.RIDDataGridViewTextBoxColumn.Name = "RIDDataGridViewTextBoxColumn"
        '
        'RCusDataGridViewTextBoxColumn
        '
        Me.RCusDataGridViewTextBoxColumn.DataPropertyName = "R_Cus"
        Me.RCusDataGridViewTextBoxColumn.HeaderText = "รหัสลูกค้า"
        Me.RCusDataGridViewTextBoxColumn.Name = "RCusDataGridViewTextBoxColumn"
        '
        'RBikeDataGridViewTextBoxColumn
        '
        Me.RBikeDataGridViewTextBoxColumn.DataPropertyName = "R_Bike"
        Me.RBikeDataGridViewTextBoxColumn.HeaderText = "รหัสสินค้า"
        Me.RBikeDataGridViewTextBoxColumn.Name = "RBikeDataGridViewTextBoxColumn"
        '
        'RQryDataGridViewTextBoxColumn
        '
        Me.RQryDataGridViewTextBoxColumn.DataPropertyName = "R_Qry"
        Me.RQryDataGridViewTextBoxColumn.HeaderText = "จำนวนที่เช่า"
        Me.RQryDataGridViewTextBoxColumn.Name = "RQryDataGridViewTextBoxColumn"
        '
        'RpledgeDataGridViewTextBoxColumn
        '
        Me.RpledgeDataGridViewTextBoxColumn.DataPropertyName = "R_pledge"
        Me.RpledgeDataGridViewTextBoxColumn.HeaderText = "สิ่งมัดจำ"
        Me.RpledgeDataGridViewTextBoxColumn.Name = "RpledgeDataGridViewTextBoxColumn"
        '
        'RStartDataGridViewTextBoxColumn
        '
        Me.RStartDataGridViewTextBoxColumn.DataPropertyName = "R_Start"
        Me.RStartDataGridViewTextBoxColumn.HeaderText = "เวลาเช่า"
        Me.RStartDataGridViewTextBoxColumn.Name = "RStartDataGridViewTextBoxColumn"
        '
        'RStopDataGridViewTextBoxColumn
        '
        Me.RStopDataGridViewTextBoxColumn.DataPropertyName = "R_Stop"
        Me.RStopDataGridViewTextBoxColumn.HeaderText = "เวลาคืน"
        Me.RStopDataGridViewTextBoxColumn.Name = "RStopDataGridViewTextBoxColumn"
        '
        'RTimesDataGridViewTextBoxColumn
        '
        Me.RTimesDataGridViewTextBoxColumn.DataPropertyName = "R_Times"
        Me.RTimesDataGridViewTextBoxColumn.HeaderText = "จำนวนเวลา / ชม."
        Me.RTimesDataGridViewTextBoxColumn.Name = "RTimesDataGridViewTextBoxColumn"
        '
        'RPriceDataGridViewTextBoxColumn
        '
        Me.RPriceDataGridViewTextBoxColumn.DataPropertyName = "R_Price"
        Me.RPriceDataGridViewTextBoxColumn.HeaderText = "ราคาค่าเช่า"
        Me.RPriceDataGridViewTextBoxColumn.Name = "RPriceDataGridViewTextBoxColumn"
        '
        'TBLRBindingSource
        '
        Me.TBLRBindingSource.DataMember = "TBL_R"
        Me.TBLRBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        'TBL_RTableAdapter
        '
        Me.TBL_RTableAdapter.ClearBeforeFill = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_InBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents สนคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents งานเชาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents งานคนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายงานToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents งานบคคลToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ออกจากระบบToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents เพมสนคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents เพมพนกงานToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายการสนคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ประวตการเชาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents การเชาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents การคนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ลกคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ยอดการเชาของลกคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายชอสมาชกToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายชอพนกงานทงหมดToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents สนคาทถกเชามากทสดToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายการสนคาToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _BikeRT_V2DataSet As BikeRT_V2._BikeRT_V2DataSet
    Friend WithEvents TBL_InBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_InTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_InTableAdapter
    Friend WithEvents TableAdapterManager As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents รบสนคาเขาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ยอกคงเหลอสนคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ระบบสมาชกToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents สมครสมาชกToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents การเงนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ยอดคาเชาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TBLRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_RTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_RTableAdapter
    Friend WithEvents RIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RCusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RBikeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RQryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RpledgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RStartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RStopDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RTimesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

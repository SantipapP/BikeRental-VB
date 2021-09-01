<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_In
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
        Dim In_IDLabel As System.Windows.Forms.Label
        Dim In_BikeLabel As System.Windows.Forms.Label
        Dim In_subLabel As System.Windows.Forms.Label
        Dim In_QtyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_In))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.In_QtyTextBox = New System.Windows.Forms.TextBox()
        Me.TBL_InBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BikeRT_V2DataSet = New BikeRT_V2._BikeRT_V2DataSet()
        Me.In_subTextBox = New System.Windows.Forms.TextBox()
        Me.In_BikeComboBox = New System.Windows.Forms.ComboBox()
        Me.TBLBikeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.In_IDTextBox = New System.Windows.Forms.TextBox()
        Me.TBL_InTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_InTableAdapter()
        Me.TableAdapterManager = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager()
        Me.TBL_BikeTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_BikeTableAdapter()
        Me.TBL_InBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TBL_InBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        In_IDLabel = New System.Windows.Forms.Label()
        In_BikeLabel = New System.Windows.Forms.Label()
        In_subLabel = New System.Windows.Forms.Label()
        In_QtyLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TBL_InBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBikeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_InBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TBL_InBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'In_IDLabel
        '
        In_IDLabel.AutoSize = True
        In_IDLabel.Location = New System.Drawing.Point(17, 62)
        In_IDLabel.Name = "In_IDLabel"
        In_IDLabel.Size = New System.Drawing.Size(63, 13)
        In_IDLabel.TabIndex = 0
        In_IDLabel.Text = "เลขที่รับเข้า:"
        '
        'In_BikeLabel
        '
        In_BikeLabel.AutoSize = True
        In_BikeLabel.Location = New System.Drawing.Point(252, 65)
        In_BikeLabel.Name = "In_BikeLabel"
        In_BikeLabel.Size = New System.Drawing.Size(36, 13)
        In_BikeLabel.TabIndex = 2
        In_BikeLabel.Text = "สินค้า:"
        '
        'In_subLabel
        '
        In_subLabel.AutoSize = True
        In_subLabel.Location = New System.Drawing.Point(11, 119)
        In_subLabel.Name = "In_subLabel"
        In_subLabel.Size = New System.Drawing.Size(69, 13)
        In_subLabel.TabIndex = 4
        In_subLabel.Text = "รับเข้ามาจาก:"
        '
        'In_QtyLabel
        '
        In_QtyLabel.AutoSize = True
        In_QtyLabel.Location = New System.Drawing.Point(209, 119)
        In_QtyLabel.Name = "In_QtyLabel"
        In_QtyLabel.Size = New System.Drawing.Size(79, 13)
        In_QtyLabel.TabIndex = 6
        In_QtyLabel.Text = "จำนวนที่รับเข้า:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(In_QtyLabel)
        Me.GroupBox1.Controls.Add(Me.In_QtyTextBox)
        Me.GroupBox1.Controls.Add(In_subLabel)
        Me.GroupBox1.Controls.Add(Me.In_subTextBox)
        Me.GroupBox1.Controls.Add(In_BikeLabel)
        Me.GroupBox1.Controls.Add(Me.In_BikeComboBox)
        Me.GroupBox1.Controls.Add(In_IDLabel)
        Me.GroupBox1.Controls.Add(Me.In_IDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 188)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รับเข้าสินค้า"
        '
        'In_QtyTextBox
        '
        Me.In_QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_InBindingSource, "In_Qty", True))
        Me.In_QtyTextBox.Location = New System.Drawing.Point(294, 116)
        Me.In_QtyTextBox.Name = "In_QtyTextBox"
        Me.In_QtyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.In_QtyTextBox.TabIndex = 7
        '
        'TBL_InBindingSource
        '
        Me.TBL_InBindingSource.DataMember = "TBL_In"
        Me.TBL_InBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        '_BikeRT_V2DataSet
        '
        Me._BikeRT_V2DataSet.DataSetName = "_BikeRT_V2DataSet"
        Me._BikeRT_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'In_subTextBox
        '
        Me.In_subTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_InBindingSource, "In_sub", True))
        Me.In_subTextBox.Location = New System.Drawing.Point(86, 116)
        Me.In_subTextBox.Name = "In_subTextBox"
        Me.In_subTextBox.Size = New System.Drawing.Size(100, 20)
        Me.In_subTextBox.TabIndex = 5
        '
        'In_BikeComboBox
        '
        Me.In_BikeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_InBindingSource, "In_Bike", True))
        Me.In_BikeComboBox.DataSource = Me.TBLBikeBindingSource
        Me.In_BikeComboBox.DisplayMember = "Bike_ID"
        Me.In_BikeComboBox.FormattingEnabled = True
        Me.In_BikeComboBox.Location = New System.Drawing.Point(294, 62)
        Me.In_BikeComboBox.Name = "In_BikeComboBox"
        Me.In_BikeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.In_BikeComboBox.TabIndex = 3
        '
        'TBLBikeBindingSource
        '
        Me.TBLBikeBindingSource.DataMember = "TBL_Bike"
        Me.TBLBikeBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        'In_IDTextBox
        '
        Me.In_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_InBindingSource, "In_ID", True))
        Me.In_IDTextBox.Location = New System.Drawing.Point(86, 59)
        Me.In_IDTextBox.Name = "In_IDTextBox"
        Me.In_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.In_IDTextBox.TabIndex = 1
        '
        'TBL_InTableAdapter
        '
        Me.TBL_InTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AdminTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BikeTableAdapter = Me.TBL_BikeTableAdapter
        Me.TableAdapterManager.TBL_CustomersTableAdapter = Nothing
        Me.TableAdapterManager.TBL_EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.TBL_InTableAdapter = Me.TBL_InTableAdapter
        Me.TableAdapterManager.TBL_RTableAdapter = Nothing
        Me.TableAdapterManager.TBL_SubTableAdapter = Nothing
        Me.TableAdapterManager.TBL_TTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_BikeTableAdapter
        '
        Me.TBL_BikeTableAdapter.ClearBeforeFill = True
        '
        'TBL_InBindingNavigator
        '
        Me.TBL_InBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TBL_InBindingNavigator.BindingSource = Me.TBL_InBindingSource
        Me.TBL_InBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TBL_InBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TBL_InBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TBL_InBindingNavigatorSaveItem})
        Me.TBL_InBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TBL_InBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TBL_InBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TBL_InBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TBL_InBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TBL_InBindingNavigator.Name = "TBL_InBindingNavigator"
        Me.TBL_InBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TBL_InBindingNavigator.Size = New System.Drawing.Size(451, 25)
        Me.TBL_InBindingNavigator.TabIndex = 1
        Me.TBL_InBindingNavigator.Text = "BindingNavigator1"
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
        'TBL_InBindingNavigatorSaveItem
        '
        Me.TBL_InBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBL_InBindingNavigatorSaveItem.Image = CType(resources.GetObject("TBL_InBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TBL_InBindingNavigatorSaveItem.Name = "TBL_InBindingNavigatorSaveItem"
        Me.TBL_InBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TBL_InBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FRM_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 230)
        Me.Controls.Add(Me.TBL_InBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRM_In"
        Me.Text = "FRM_In"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TBL_InBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBikeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_InBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TBL_InBindingNavigator.ResumeLayout(False)
        Me.TBL_InBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _BikeRT_V2DataSet As BikeRT_V2._BikeRT_V2DataSet
    Friend WithEvents TBL_InBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_InTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_InTableAdapter
    Friend WithEvents TableAdapterManager As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_InBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TBL_InBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents In_QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents In_subTextBox As System.Windows.Forms.TextBox
    Friend WithEvents In_BikeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents In_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TBL_BikeTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_BikeTableAdapter
    Friend WithEvents TBLBikeBindingSource As System.Windows.Forms.BindingSource
End Class

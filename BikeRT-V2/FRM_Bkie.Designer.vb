<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Bkie
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
        Dim Bike_IDLabel As System.Windows.Forms.Label
        Dim Bike_GenLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Bkie))
        Me._BikeRT_V2DataSet = New BikeRT_V2._BikeRT_V2DataSet()
        Me.TBL_BikeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_BikeTableAdapter = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_BikeTableAdapter()
        Me.TableAdapterManager = New BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager()
        Me.TBL_BikeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TBL_BikeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Bike_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Bike_GenTextBox = New System.Windows.Forms.TextBox()
        Bike_IDLabel = New System.Windows.Forms.Label()
        Bike_GenLabel = New System.Windows.Forms.Label()
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_BikeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_BikeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TBL_BikeBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bike_IDLabel
        '
        Bike_IDLabel.AutoSize = True
        Bike_IDLabel.Location = New System.Drawing.Point(55, 75)
        Bike_IDLabel.Name = "Bike_IDLabel"
        Bike_IDLabel.Size = New System.Drawing.Size(55, 13)
        Bike_IDLabel.TabIndex = 1
        Bike_IDLabel.Text = "รหัสสินค้า:"
        '
        'Bike_GenLabel
        '
        Bike_GenLabel.AutoSize = True
        Bike_GenLabel.Location = New System.Drawing.Point(61, 101)
        Bike_GenLabel.Name = "Bike_GenLabel"
        Bike_GenLabel.Size = New System.Drawing.Size(49, 13)
        Bike_GenLabel.TabIndex = 3
        Bike_GenLabel.Text = "ชื่อสินค้า:"
        '
        '_BikeRT_V2DataSet
        '
        Me._BikeRT_V2DataSet.DataSetName = "_BikeRT_V2DataSet"
        Me._BikeRT_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_BikeBindingSource
        '
        Me.TBL_BikeBindingSource.DataMember = "TBL_Bike"
        Me.TBL_BikeBindingSource.DataSource = Me._BikeRT_V2DataSet
        '
        'TBL_BikeTableAdapter
        '
        Me.TBL_BikeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AdminTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BikeTableAdapter = Me.TBL_BikeTableAdapter
        Me.TableAdapterManager.TBL_CustomersTableAdapter = Nothing
        Me.TableAdapterManager.TBL_EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.TBL_InTableAdapter = Nothing
        Me.TableAdapterManager.TBL_RTableAdapter = Nothing
        Me.TableAdapterManager.TBL_SubTableAdapter = Nothing
        Me.TableAdapterManager.TBL_TTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_BikeBindingNavigator
        '
        Me.TBL_BikeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TBL_BikeBindingNavigator.BindingSource = Me.TBL_BikeBindingSource
        Me.TBL_BikeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TBL_BikeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TBL_BikeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TBL_BikeBindingNavigatorSaveItem})
        Me.TBL_BikeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TBL_BikeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TBL_BikeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TBL_BikeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TBL_BikeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TBL_BikeBindingNavigator.Name = "TBL_BikeBindingNavigator"
        Me.TBL_BikeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TBL_BikeBindingNavigator.Size = New System.Drawing.Size(283, 25)
        Me.TBL_BikeBindingNavigator.TabIndex = 0
        Me.TBL_BikeBindingNavigator.Text = "BindingNavigator1"
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
        'TBL_BikeBindingNavigatorSaveItem
        '
        Me.TBL_BikeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBL_BikeBindingNavigatorSaveItem.Image = CType(resources.GetObject("TBL_BikeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TBL_BikeBindingNavigatorSaveItem.Name = "TBL_BikeBindingNavigatorSaveItem"
        Me.TBL_BikeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.TBL_BikeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Bike_IDTextBox
        '
        Me.Bike_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_BikeBindingSource, "Bike_ID", True))
        Me.Bike_IDTextBox.Enabled = False
        Me.Bike_IDTextBox.Location = New System.Drawing.Point(116, 72)
        Me.Bike_IDTextBox.Name = "Bike_IDTextBox"
        Me.Bike_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Bike_IDTextBox.TabIndex = 2
        '
        'Bike_GenTextBox
        '
        Me.Bike_GenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_BikeBindingSource, "Bike_Gen", True))
        Me.Bike_GenTextBox.Enabled = False
        Me.Bike_GenTextBox.Location = New System.Drawing.Point(116, 98)
        Me.Bike_GenTextBox.Name = "Bike_GenTextBox"
        Me.Bike_GenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Bike_GenTextBox.TabIndex = 4
        '
        'FRM_Bkie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 162)
        Me.Controls.Add(Bike_GenLabel)
        Me.Controls.Add(Me.Bike_GenTextBox)
        Me.Controls.Add(Bike_IDLabel)
        Me.Controls.Add(Me.Bike_IDTextBox)
        Me.Controls.Add(Me.TBL_BikeBindingNavigator)
        Me.Name = "FRM_Bkie"
        Me.Text = "FRM_Bkie"
        CType(Me._BikeRT_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_BikeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_BikeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TBL_BikeBindingNavigator.ResumeLayout(False)
        Me.TBL_BikeBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _BikeRT_V2DataSet As BikeRT_V2._BikeRT_V2DataSet
    Friend WithEvents TBL_BikeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_BikeTableAdapter As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TBL_BikeTableAdapter
    Friend WithEvents TableAdapterManager As BikeRT_V2._BikeRT_V2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_BikeBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TBL_BikeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Bike_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bike_GenTextBox As System.Windows.Forms.TextBox
End Class

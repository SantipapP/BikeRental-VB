Public Class FRM_Employee

    Private Sub TBL_EmployeesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBL_EmployeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TBL_EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._BikeRT_V2DataSet)

    End Sub

    Private Sub FRM_Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_Employees' table. You can move, or remove it, as needed.
        Me.TBL_EmployeesTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_Employees)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Em_AddressTextBox.Enabled = True
        Em_BirthDateTimePicker.Enabled = True
        Em_EmailTextBox.Enabled = True
        Em_IDTextBox.Enabled = True
        Em_LNameTextBox.Enabled = True
        Em_NameTextBox.Enabled = True
        Em_PassTextBox.Enabled = True
        Em_TelTextBox.Enabled = True
    End Sub
End Class
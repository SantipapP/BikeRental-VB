Public Class FRM_Customers

    Private Sub TBL_CustomersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBL_CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TBL_CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._BikeRT_V2DataSet)
        MsgBox("บันทึกข้อมูลเรียบร้อย")
        Me.Close()

    End Sub

    Private Sub FRM_Customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_Customers' table. You can move, or remove it, as needed.
        Me.TBL_CustomersTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_Customers)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Cus_AddressTextBox.Enabled = True
        Cus_BirthDateTimePicker.Enabled = True
        Cus_IDTextBox.Enabled = True
        Cus_NameTextBox.Enabled = True
        Cus_TelTextBox.Enabled = True
    End Sub
End Class
Public Class FRM_T

    Private Sub TBL_TBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBL_TBindingNavigatorSaveItem.Click
        TextBox1.Text = DateDiff(DateInterval.Hour, T_StopDateTimePicker.Value, T_TStopDateTimePicker.Value)
        If TextBox1.Text > 0 Then
            T_RatePriceTextBox.Text = TextBox1.Text * 50
        Else
            T_RatePriceTextBox.Text = 0
        End If
        Me.Validate()
        Me.TBL_TBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._BikeRT_V2DataSet)

        MsgBox("บันทึกข้อมูลเรียบร้อย")
        Me.Close()

    End Sub

    Private Sub FRM_T_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_Bike' table. You can move, or remove it, as needed.
        Me.TBL_BikeTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_Bike)
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_Customers' table. You can move, or remove it, as needed.
        Me.TBL_CustomersTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_Customers)
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_T' table. You can move, or remove it, as needed.
        Me.TBL_TTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_T)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        T_BikeComboBox.Enabled = True
        T_CusComboBox.Enabled = True
        T_DamageTextBox.Enabled = True
        T_DPriceTextBox.Enabled = True
        T_IDTextBox.Enabled = True
        T_QryTextBox.Enabled = True
        T_RatePriceTextBox.Enabled = True
        T_StartDateTimePicker.Enabled = True
        T_StopDateTimePicker.Enabled = True
        T_TStopDateTimePicker.Enabled = True

    End Sub
End Class
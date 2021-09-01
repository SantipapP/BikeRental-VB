Public Class FRM_Bkie

    
    

    Private Sub TBL_BikeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBL_BikeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TBL_BikeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._BikeRT_V2DataSet)
        MsgBox("บันทึกข้อมูลเสร็จสิ้น")
        Me.Close()

    End Sub

    Private Sub FRM_Bkie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_Bike' table. You can move, or remove it, as needed.
        Me.TBL_BikeTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_Bike)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Bike_IDTextBox.Enabled = True
        Bike_GenTextBox.Enabled = True
    End Sub
End Class
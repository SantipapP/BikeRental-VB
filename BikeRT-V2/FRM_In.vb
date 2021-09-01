Public Class FRM_In

    Private Sub TBL_InBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBL_InBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TBL_InBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._BikeRT_V2DataSet)

    End Sub

    Private Sub FRM_In_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_Bike' table. You can move, or remove it, as needed.
        Me.TBL_BikeTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_Bike)
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_In' table. You can move, or remove it, as needed.
        Me.TBL_InTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_In)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class
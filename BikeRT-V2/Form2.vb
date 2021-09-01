Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_Admin' table. You can move, or remove it, as needed.
        Me.TBL_AdminTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_Admin)

    End Sub
End Class
Public Class RPT_Customers

    Private Sub RPT_Customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_Customers' table. You can move, or remove it, as needed.
        Me.TBL_CustomersTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_Customers)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
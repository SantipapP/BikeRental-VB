Public Class RPT_Qty

    Private Sub RPT_Qty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.QRY_Qty' table. You can move, or remove it, as needed.
        Me.QRY_QtyTableAdapter.Fill(Me._BikeRT_V2DataSet.QRY_Qty)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
Public Class RPT_CusP

    Private Sub RPT_CusP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.QRY_CusP' table. You can move, or remove it, as needed.
        Me.QRY_CusPTableAdapter.Fill(Me._BikeRT_V2DataSet.QRY_CusP)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
Public Class RPT_FCR

    Private Sub RPT_FCR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.QRY_FC' table. You can move, or remove it, as needed.
        Me.QRY_FCTableAdapter.Fill(Me._BikeRT_V2DataSet.QRY_FC)
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_R' table. You can move, or remove it, as needed.
        Me.TBL_RTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_R)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
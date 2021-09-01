Public Class RPT_FR

    Private Sub RPT_FR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.QRY_FR' table. You can move, or remove it, as needed.
        Me.QRY_FRTableAdapter.Fill(Me._BikeRT_V2DataSet.QRY_FR)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
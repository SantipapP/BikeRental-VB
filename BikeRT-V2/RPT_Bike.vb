Public Class RPT_Bike

    Private Sub RPT_Bike_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_Bike' table. You can move, or remove it, as needed.
        Me.TBL_BikeTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_Bike)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
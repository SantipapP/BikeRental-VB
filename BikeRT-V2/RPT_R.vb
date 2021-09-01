Public Class RPT_R

    Private Sub RPT_R_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_R' table. You can move, or remove it, as needed.
        Me.TBL_RTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_R)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
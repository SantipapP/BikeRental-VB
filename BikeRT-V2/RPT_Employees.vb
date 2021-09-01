Public Class RPT_Employees

    Private Sub RPT_Employees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_Employees' table. You can move, or remove it, as needed.
        Me.TBL_EmployeesTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_Employees)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_R' table. You can move, or remove it, as needed.
        Me.TBL_RTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_R)

    End Sub

    Private Sub ประวตการเชาToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ประวตการเชาToolStripMenuItem.Click

    End Sub

    Private Sub ยอดการเชาของลกคาToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ยอดการเชาของลกคาToolStripMenuItem.Click
        RPT_FCR.Show()
    End Sub

    Private Sub ออกจากระบบToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ออกจากระบบToolStripMenuItem.Click
        Dim q As MsgBoxResult
        q = MsgBox("ยืนยันการออกจากระบบ", MsgBoxStyle.YesNoCancel, "ออกจากระบบ")
        If q = MsgBoxResult.Yes Then
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = System.DateTime.Now
    End Sub

    Private Sub งานคนToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles งานคนToolStripMenuItem.Click
        FRM_T.Show()
    End Sub

    Private Sub เพมสนคาToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles เพมสนคาToolStripMenuItem.Click
        FRM_Bkie.Show()
    End Sub

    Private Sub TBL_BikeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TBL_CustomersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TBL_EmployeesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TBL_InBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub งานเชาToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles งานเชาToolStripMenuItem.Click
        FRM_R.Show()
        Me.Close()
    End Sub

    Private Sub รบสนคาเขาToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles รบสนคาเขาToolStripMenuItem.Click
        FRM_In.Show()
    End Sub

    Private Sub ยอกคงเหลอสนคาToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ยอกคงเหลอสนคาToolStripMenuItem.Click
        RPT_Qty.Show()
    End Sub

    Private Sub รายชอพนกงานทงหมดToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles รายชอพนกงานทงหมดToolStripMenuItem.Click
        RPT_Employees.Show()
    End Sub

    Private Sub การเชาToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles การเชาToolStripMenuItem.Click
        RPT_R.Show()
    End Sub

    Private Sub ยอดคาเชาToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ยอดคาเชาToolStripMenuItem.Click
        RPT_CusP.Show()
    End Sub

    Private Sub สนคาทถกเชามากทสดToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles สนคาทถกเชามากทสดToolStripMenuItem.Click
        RPT_FR.Show()
    End Sub

    Private Sub สมครสมาชกToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles สมครสมาชกToolStripMenuItem.Click
        FRM_Customers.Show()
    End Sub

    Private Sub เพมพนกงานToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles เพมพนกงานToolStripMenuItem.Click
        FRM_Employee.Show()
    End Sub

    Private Sub รายการสนคาToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles รายการสนคาToolStripMenuItem1.Click
        RPT_Bike.Show()
    End Sub

    Private Sub รายชอสมาชกToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles รายชอสมาชกToolStripMenuItem.Click
        RPT_Customers.Show()
    End Sub
End Class
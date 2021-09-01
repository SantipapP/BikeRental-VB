Public Class FRM_R

    Private Sub TBL_RBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBL_RBindingNavigatorSaveItem.Click
        Dim total As Double
        Dim q1 As MsgBoxResult
        q1 = MsgBox("ยืนยันการบันทึกข้อมูล", MsgBoxStyle.YesNoCancel, "การบันทึก")
        If q1 = MsgBoxResult.Yes Then
            R_TimesTextBox.Text = DateDiff(DateInterval.Hour, R_StartDateTimePicker.Value, R_StopDateTimePicker.Value)
            If R_TimesTextBox.Text > 2 Then
                total = R_QryTextBox.Text * (R_TimesTextBox.Text * 70)
                R_PriceTextBox.Text = total

            Else
                total = R_QryTextBox.Text * (R_TimesTextBox.Text * 100)
                R_PriceTextBox.Text = total

            End If

            Me.Validate()
            Me.TBL_RBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._BikeRT_V2DataSet)

            MsgBox("บันทึกข้อมูลสำเร็จ รหัสสินค้า = " & R_BikeComboBox.Text & " จำนวน = " & R_QryTextBox.Text & " จำนวนชั่วโมง = " & R_TimesTextBox.Text & " รวมค่าเช่า = " & R_PriceTextBox.Text & " สิ่งที่มัดจำ = " & R_pledgeComboBox.Text)
            Me.Close()
            Main.Show()
        End If

    End Sub

    Private Sub FRM_R_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_Bike' table. You can move, or remove it, as needed.
        Me.TBL_BikeTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_Bike)
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_Customers' table. You can move, or remove it, as needed.
        Me.TBL_CustomersTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_Customers)
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.QRY_Ready' table. You can move, or remove it, as needed.
        Me.QRY_ReadyTableAdapter.Fill(Me._BikeRT_V2DataSet.QRY_Ready)
        'TODO: This line of code loads data into the '_BikeRT_V2DataSet.TBL_R' table. You can move, or remove it, as needed.
        Me.TBL_RTableAdapter.Fill(Me._BikeRT_V2DataSet.TBL_R)

        


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        R_CusComboBox.Enabled = True
        R_BikeComboBox.Enabled = True
        R_QryTextBox.Enabled = True

        R_StopDateTimePicker.Enabled = True

        TBL_RBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim total As Double
        Dim q1 As MsgBoxResult
        q1 = MsgBox("ยืนยันการบันทึกข้อมูล", MsgBoxStyle.YesNoCancel, "การบันทึก")
        If q1 = MsgBoxResult.Yes Then
            R_TimesTextBox.Text = DateDiff(DateInterval.Hour, R_StartDateTimePicker.Value, R_StopDateTimePicker.Value)
            If R_TimesTextBox.Text > 2 Then
                total = R_QryTextBox.Text * (R_TimesTextBox.Text * 70)
                R_PriceTextBox.Text = total
            Else
                total = R_QryTextBox.Text * (R_TimesTextBox.Text * 100)
                R_PriceTextBox.Text = total
            End If
            Me.Validate()
            Me.TBL_RBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._BikeRT_V2DataSet)
            MsgBox("บันทึกข้อมูลสำเร็จ รหัสสินค้า = " & R_BikeComboBox.Text & " จำนวน = " & R_QryTextBox.Text & " จำนวนชั่วโมง = " & R_TimesTextBox.Text & " รวมค่าเช่า = " & R_PriceTextBox.Text & " สิ่งที่มัดจำ = " & R_pledgeComboBox.Text)

            
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        R_CusComboBox.Enabled = True
        R_BikeComboBox.Enabled = True
        R_QryTextBox.Enabled = True

        R_StopDateTimePicker.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Main.Show()
        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = "เลขที่เช่า  " & R_IDTextBox.Text & "                                                รหัสลูกค้า  " & R_CusComboBox.Text & vbCrLf & vbCrLf & "รหัสสินค้า  " & R_BikeComboBox.Text & "                                                      จำนวน  " & R_QryTextBox.Text & vbCrLf & vbCrLf & "เวลาเช่า  " & R_StartDateTimePicker.Text & "                                                เวลาคืน  " & R_StopDateTimePicker.Text & vbCrLf & vbCrLf & "จำนวนเวลา  " & R_TimesTextBox.Text & " ชั่วโมง " & "                                                        สิ่งมัดจำ  " & R_pledgeComboBox.Text & vbCrLf & vbCrLf & "ค่าเช่า  " & R_PriceTextBox.Text & " บาท  "

        PrintPreviewDialog1.ShowDialog
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(TextBox1.Text, Font, Brushes.Blue, 100, 100)
    End Sub
End Class
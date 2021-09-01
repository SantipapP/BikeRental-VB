Imports System.Data.OleDb

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BikeRT-V2.Accdb;")
        cn.Open()


        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("Please Enter UserID and Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusername.Focus()
            Exit Sub
        End If

        Dim dr1 As OleDbDataReader
        Dim com As New OleDbCommand
        com.CommandText = "select [Em_ID],[Em_Pass] from TBL_Employees where Em_ID = '" & txtusername.Text & "'"
        com.Connection = cn
        If cn.State = ConnectionState.Closed Then cn.Open()
        dr1 = com.ExecuteReader
        If dr1.Read Then
            If UCase(dr1(1)) = UCase(txtpassword.Text) Then

                MessageBox.Show("เข้าสู่ระบบ", "Access", MessageBoxButtons.OK)

                Main.Show()
                txtusername.Text = ""
                txtpassword.Text = ""
                txtusername.Focus()
                Me.Hide()

            Else
                MessageBox.Show("รหัสผ่านผิดพลาด", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'LinkLabel2.Visible = True
                'LinkLabel2.Text = "Forget Password"
                txtpassword.Focus()
            End If
        Else
            MessageBox.Show("รหัสพนักงานผิดพลาด", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtusername.Focus()
            Exit Sub
        End If
        dr1.Close()
        cn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged

    End Sub
End Class

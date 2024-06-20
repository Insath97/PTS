Imports MySql.Data.MySqlClient

Public Class Add_Admin

    Private Sub clear()
        txtname.Clear()
        txtage.Clear()
        txtnic.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtname.Select()
    End Sub



    Private Sub Add_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        clear()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Try
            cm = New MySqlCommand("INSERT INTO admin (`name`, `age`, `nic`, `username`, `password`) VALUES ('" & txtname.Text & "','" & Val(txtage.Text) & "','" & txtnic.Text & "','" & txtusername.Text & "','" & txtpassword.Text & "')", constring)
            cm.ExecuteNonQuery()
            clear()
            MsgBox("New Admin Added ")
        Catch ex As Exception
            MsgBox("Cann't Added ")
        End Try
    End Sub
End Class
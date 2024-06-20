Imports MySql.Data.MySqlClient

Public Class login

    Private Sub clear()
        txtun.Clear()
        txtpw.Clear()
        txtun.Select()
    End Sub
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT username,password FROM `admin` WHERE username ='" & txtun.Text & "' AND password='" & txtun.Text & "'", constring)
        adapter.Fill(table)
        If table.Rows.Count() < 0 Then
            MsgBox("Can't login")

        Else
            MsgBox("Login Successfull")
            Dashboard.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub
End Class

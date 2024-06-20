Imports MySql.Data.MySqlClient
Imports QRCoder

Public Class Add_New_Customer

    Private Sub clear()
        txtname.Clear()
        txtnic.Clear()
        txttel.Clear()
        datepic1.Checked = False
        txtfamount.Clear()
        txtname.Select()
        Pic.Image = Nothing
    End Sub

    Private Sub qrgen()
        Dim gem As New QRCodeGenerator
        Dim Data = gem.CreateQrCode(txtnic.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(Data)
        Pic.Image = code.GetGraphic(6)
    End Sub
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Try
            cm = New MySqlCommand("INSERT INTO `customer`(`name`, `nic`, `phone`, `date`, `Amount`) VALUES ('" & txtname.Text & "','" & txtnic.Text & "','" & txttel.Text & "','" & datepic1.Value.Date.ToString("yyyy/MM/dd") & "','" & Val(txtfamount.Text) & "')", constring)
            cm.ExecuteNonQuery()
            MsgBox("New Customer Added ")
            qrgen()
        Catch ex As Exception
            MsgBox("Cann't Added")
        End Try

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        clear()
    End Sub

    Private Sub Add_New_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click

        Dim gem As New SaveFileDialog

        gem.FileName = txtname.Text
        gem.Filter = "PNG Files only(*.png) | *.png"

        If gem.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Try
                Pic.Image.Save(gem.FileName, System.Drawing.Imaging.ImageFormat.Png)
                MessageBox.Show("Successfully Saved...!")
                clear()
            Catch ex As Exception
                Pic.Image = Nothing
            End Try
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
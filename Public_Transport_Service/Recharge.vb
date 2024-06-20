Imports MySql.Data.MySqlClient
Public Class Recharge

    Private Sub clear()
        id.Clear()
        txtname.Clear()
        txtmoney.Clear()
        datepic1.Checked = False
        id.Select()
    End Sub

    Private Sub displayTable()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select * from customer", constring)
        adapter.Fill(table)
        Guna2DataGridView1.DataSource = table
    End Sub
    Private Sub setView()
        Dim row As DataGridViewRow = Guna2DataGridView1.CurrentRow
        Try
            id.Text = row.Cells(0).Value.ToString()
            txtname.Text = row.Cells(1).Value.ToString()
            txtmoney.Text = row.Cells(5).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim row As DataGridViewRow = Guna2DataGridView1.CurrentRow
        Try
            cm = New MySqlCommand("UPDATE `customer` SET `name`='" & txtname.Text & "',`Amount`='" & Val(txtmoney.Text) & "',`updateDate`='" & datepic1.Value.Date.ToString("yyyy/MM/dd") & "' WHERE `Id`='" & id.Text & "'", constring)
            cm.ExecuteNonQuery()
            MsgBox("Successfully Updated")
            displayTable()
        Catch ex As Exception
            MsgBox("Can't Update")
        End Try
    End Sub

    Private Sub Recharge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        displayTable()

    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        setView()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub
End Class
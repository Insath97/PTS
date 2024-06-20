Imports MySql.Data.MySqlClient
Module dbConnection
    Public constring As MySqlConnection
    Public cm As MySqlCommand

    Sub connect()
        Try
            constring = New MySqlConnection("server=localhost;database=travels;username=root;password=")
            constring.Open()
            MsgBox("Database Connected Successfully")

        Catch ex As Exception
            MsgBox("database not connected")
        End Try
    End Sub
End Module

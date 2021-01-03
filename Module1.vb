Imports MySql.Data.MySqlClient

Module Module1
    Public conn As MySqlConnection = New MySqlConnection
    Public ds As DataSet
    Public sql As String
    Public cmd As MySqlCommand = New MySqlCommand
    Public dr As MySqlDataReader

    Public Sub connect()
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        conn.Open()
        dr = cmd.ExecuteReader

    End Sub

End Module

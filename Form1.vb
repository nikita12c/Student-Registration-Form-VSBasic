Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class delete
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;userid=nikitamysql;port=3306;password=nikitamysql.123;database=sad_loginform"

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        ntxtbox.Text = ""
        Idtxtbox.Text = ""
        semcombo.Text = ""
        yearcombo.Text = ""
        branchcombo.Text = ""

    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ntxtbox.Text = "" Or
            semcombo.Text = "" Or
            Idtxtbox.Text = "" Or
            branchcombo.Text = "" Or
            yearcombo.Text = "") Then
            MsgBox("Plz enter all data", MsgBoxStyle.Critical)
        Else
            sql = "insert into students(studentId,studentName,semester,branch,year) values('" & Idtxtbox.Text & "' ,'" & ntxtbox.Text & "' ,'" & semcombo.Text & "' ,'" & branchcombo.Text & "','" & yearcombo.Text & "')"
            connect()

            If dr.Read = True Then
                MsgBox("You have Registered successfully", MsgBoxStyle.Information, "Added Successully")
                Me.Hide()
            Else
                MsgBox("Please Check again", MsgBoxStyle.Information, "Login Fail")
            End If
            conn.Close()

        End If
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Update done")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ntxtbox.Text = ""
        Idtxtbox.Text = ""
        semcombo.Text = ""
        yearcombo.Text = ""
        branchcombo.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (
            Idtxtbox.Text = ""
            ) Then
            MsgBox("Plz enter all data", MsgBoxStyle.Critical)
        Else
            sql = "delete from students where studentId ='" & Idtxtbox.Text & "'"
            connect()

            If dr.Read = True Then
                MsgBox("Record is deleted successfully", MsgBoxStyle.Information, "Deleted Successully")
                Me.Hide()
            Else
                MsgBox("Please Check again", MsgBoxStyle.Information, "Login Fail")
            End If
            conn.Close()

        End If
    End Sub
End Class

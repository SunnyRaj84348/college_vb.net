Imports System.Data.OleDb

Public Class Form1
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim query As String
    Dim dr As OleDbDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Administrator\Documents\Database3.mdb")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim roll As Integer = Val(TextBox1.Text)
        Dim name As String = TextBox2.Text
        Dim course As String = TextBox3.Text

        Try
            con.Open()

            query = "insert into Stud values(" & roll & ",'" & name & " ','" & course & " ')"
            cmd = New OleDbCommand(query, con)

            cmd.ExecuteReader()

            Dim res As Integer = cmd.ExecuteNonQuery

            If res > 0 Then
                MsgBox("data inserted duccesfully")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim roll As Integer = Val(TextBox1.Text)

        Try
            con.Open()
            query = "select * from Stud where roll=" & roll
            cmd = New OleDbCommand(query, con)
            dr = cmd.ExecuteReader

            If dr.Read Then

                TextBox2.Text = dr("name").ToString
                TextBox3.Text = dr("course").ToString

            Else
                MsgBox("not found")


            End If
        Catch ex As Exception

            MsgBox(ex.ToString)
        Finally
            con.Close()
            dr.Close()


        End Try
    End Sub
End Class

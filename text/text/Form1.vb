Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim len As Integer = 0
        Dim space As Integer = 0
        Dim vowel As Integer = 0

        For Each i In TextBox1.Text
            len += 1

            If i = " " Then
                space += 1
            End If

            If i = "a" Or i = "e" Or i = "i" Or i = "o" Or i = "u" Then
                vowel += 1
            End If

        Next

        TextBox2.Text = len
        TextBox3.Text = space + 1
        TextBox4.Text = space
        TextBox5.Text = vowel
    End Sub
End Class

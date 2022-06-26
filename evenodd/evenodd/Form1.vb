Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer

        n = Val(TextBox1.Text)

        If (n Mod 2 = 0) Then
            TextBox2.Text = "Even number"
        Else
            TextBox2.Text = "Odd number"

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub
End Class

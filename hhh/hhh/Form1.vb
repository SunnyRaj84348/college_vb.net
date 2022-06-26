Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim no As Integer
        no = Val(TextBox1.Text)
        If no / 2 = Int(no / 2) Then
            Label3.Text = "Even"
        Else
            Label3.Text = "Odd"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num As Integer = Val(TextBox2.Text)
        Dim flag As Boolean = True

        For i As Integer = 2 To num / 2 Step 1
            If num Mod i = 0 Then
                flag = False
                Exit For
            End If
        Next

        If flag Then
            Label4.Text = "Prime"
        Else
            Label4.Text = "Not Prime"
        End If

    End Sub
End Class

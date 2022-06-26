Public Class Form1
    Dim num As Integer = 60

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = num
        num -= 1
    End Sub
End Class

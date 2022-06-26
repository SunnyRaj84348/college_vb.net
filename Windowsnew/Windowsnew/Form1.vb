Public Class Form1
    Dim x, y As Integer
    Dim op As String

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        y = Val(ListBox3.SelectedItem)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If op = "+" Then
            TextBox1.Text = x + y
        ElseIf op = "-" Then
            TextBox1.Text = x - y
        ElseIf op = "/" Then
            TextBox1.Text = x / y
        ElseIf op = "*" Then
            TextBox1.Text = x * y
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        x = Val(ListBox1.SelectedItem)
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        op = ListBox2.SelectedItem
    End Sub
End Class

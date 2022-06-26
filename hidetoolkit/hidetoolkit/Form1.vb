Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) > Val(TextBox2.Text) Then
            TextBox3.Text = TextBox1.Text
        Else
            TextBox3.Text = TextBox2.Text
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            Label2.Visible = True
            TextBox2.Visible = True
        Else
            Label2.Visible = False
            TextBox2.Visible = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" Then
            Button1.Visible = True
            TextBox3.Visible = True
        Else
            Button1.Visible = False
            TextBox3.Visible = False
        End If
    End Sub
End Class

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.Add(TextBox1.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Add(TextBox2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each i In ComboBox1.Items
            For Each j In ListBox1.Items
                If i = j Then
                    ListBox2.Items.Add(i)
                End If
            Next
        Next
    End Sub
End Class

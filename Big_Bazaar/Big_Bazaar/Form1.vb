Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim CboxItem As String
        CboxItem = ComboBox1.SelectedItem

        If CboxItem = "Pepsi" Then
            TextBox1.Text = "95"
        ElseIf CboxItem = "Sprite" Then
            TextBox1.Text = "85"
        ElseIf CboxItem = "Lux" Then
            TextBox1.Text = "25"
        Else
            TextBox1.Text = "10"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem Is Nothing Then
            MsgBox("Please select an item")
            Return
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please enter quantity")
            Return
        ElseIf TextBox2.Text < 1 Then
            MsgBox("Quantity should be at least 1")
            Return
        End If

        If ListBox1.Items.Contains(ComboBox1.SelectedItem) Then
            Dim ind As Integer
            ind = ListBox1.Items.IndexOf(ComboBox1.SelectedItem)

            ListBox2.Items.Item(ind) += Val(TextBox2.Text)
            ListBox3.Items.Item(ind) += Val(TextBox1.Text * TextBox2.Text)
        Else
            ListBox1.Items.Add(ComboBox1.SelectedItem)
            ListBox2.Items.Add(TextBox2.Text)
            ListBox3.Items.Add(TextBox1.Text * TextBox2.Text)
        End If

        Dim cnt As Integer = 0
        For Each i In ListBox1.Items
            cnt += 1
        Next

        Dim total_price As Integer = 0
        For Each i In ListBox3.Items
            total_price += i
        Next

        TextBox3.Text = cnt
        TextBox4.Text = total_price

        TextBox2.Text = ""
    End Sub

End Class

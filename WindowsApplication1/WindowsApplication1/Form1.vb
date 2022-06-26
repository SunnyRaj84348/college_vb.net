Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Input string")
            Return
        End If

        Dim str As String = ""
        Dim chrMatched As Boolean = False

        For Each i In TextBox1.Text
            If i = TextBox2.Text Then
                str += TextBox3.Text
                chrMatched = True
            Else
                str += i
            End If
        Next

        If Not chrMatched Then
            MsgBox("Character not matched")
        Else
            TextBox1.Text = str
        End If

        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class

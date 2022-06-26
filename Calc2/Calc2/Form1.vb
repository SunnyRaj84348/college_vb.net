Public Class Calculator
    Dim op, n1, mem As String
    Dim opClicked As Boolean = False
    Dim dotClicked As Boolean = False

    Private Sub sqr()
        Dim x As String = n1
        Dim i As String = 1

        While i < TextBox1.Text
            n1 *= x
            i += 1
        End While
    End Sub

    Private Sub calc()
        Select Case op
            Case "+"
                n1 += Val(TextBox1.Text)
            Case "-"
                n1 -= TextBox1.Text
            Case "*"
                n1 *= TextBox1.Text
            Case "/"
                n1 /= TextBox1.Text
            Case "%"
                n1 = n1 Mod TextBox1.Text
            Case "sqr"
                sqr()
            Case Else
                n1 = TextBox1.Text
        End Select
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If n1 = 0 Then
            n1 = Val(TextBox1.Text)
        Else
            calc()
        End If

        op = "+"
        opClicked = True
        dotClicked = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If n1 = 0 Then
            n1 = Val(TextBox1.Text)
        Else
            calc()
        End If

        op = "-"
        opClicked = True
        dotClicked = False
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If n1 = 0 Then
            n1 = Val(TextBox1.Text)
        Else
            calc()
        End If

        op = "*"
        opClicked = True
        dotClicked = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If n1 = 0 Then
            n1 = Val(TextBox1.Text)
        Else
            calc()
        End If

        op = "/"
        opClicked = True
        dotClicked = False
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If n1 = 0 Then
            n1 = Val(TextBox1.Text)
        Else
            calc()
        End If

        op = "%"
        opClicked = True
        dotClicked = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If opClicked Then
            TextBox1.Text = ""
            opClicked = False
        End If

        TextBox1.Text += Button1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If opClicked Then
            TextBox1.Text = ""
            opClicked = False
        End If

        TextBox1.Text += Button2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If opClicked Then
            TextBox1.Text = ""
            opClicked = False
        End If

        TextBox1.Text += Button3.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If opClicked Then
            TextBox1.Text = ""
            opClicked = False
        End If

        TextBox1.Text += Button4.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If opClicked Then
            TextBox1.Text = ""
            opClicked = False
        End If

        TextBox1.Text += Button5.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If opClicked Then
            TextBox1.Text = ""
            opClicked = False
        End If

        TextBox1.Text += Button6.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If opClicked Then
            TextBox1.Text = ""
            opClicked = False
        End If

        TextBox1.Text += Button7.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If opClicked Then
            TextBox1.Text = ""
            opClicked = False
        End If

        TextBox1.Text += Button8.Text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If opClicked Then
            TextBox1.Text = ""
            opClicked = False
        End If

        TextBox1.Text += Button9.Text
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If opClicked Then
            TextBox1.Text = ""
            opClicked = False
        End If

        TextBox1.Text += Button10.Text
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If opClicked Then
            TextBox1.Text = ""
            opClicked = False
        End If

        If Not dotClicked Then
            TextBox1.Text += "."
            dotClicked = True
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        calc()

        TextBox1.Text = n1
        n1 = 0
        op = ""
        opClicked = True
        dotClicked = False
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = ""
        n1 = 0
        op = ""
        opClicked = False
        dotClicked = False
    End Sub

    ' Memory Start
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        mem += Val(TextBox1.Text)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        mem -= Val(TextBox1.Text)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = mem
        n1 = 0
        opClicked = True
        dotClicked = False
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        mem = ""
    End Sub
    ' Memory End

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim fact As String = 1
        Dim i As String = CInt(TextBox1.Text)

        While i >= 2
            fact *= i
            i -= 1
        End While

        TextBox1.Text = fact
        n1 = fact
        opClicked = True
        dotClicked = False
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox1.Text *= TextBox1.Text
        n1 = TextBox1.Text
        opClicked = True
        dotClicked = False
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim num As String = TextBox1.Text
        num = num * num * num
        TextBox1.Text = num

        n1 = TextBox1.Text
        opClicked = True
        dotClicked = False
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If n1 = 0 Then
            n1 = Val(TextBox1.Text)
        Else
            calc()
        End If

        op = "sqr"
        opClicked = True
        dotClicked = False
    End Sub
End Class

Public Class Form1
    Function CheckDate(ByVal dt As String) As Boolean
        If dt.Length <> 10 Then
            Return False
        End If

        Dim sep1 As String = dt.Substring(2, 1)
        Dim sep2 As String = dt.Substring(5, 1)

        If sep1 <> "/" Or sep2 <> "/" Then
            Return False
        End If

        Dim day As String = dt.Substring(0, 2)
        Dim mon As String = dt.Substring(3, 2)
        Dim year As String = dt.Substring(6, 4)

        If day > 31 Or mon > 12 Or (Not IsNumeric(year)) Then
            Return False
        End If

        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim exp As String = TextBox1.Text
        Dim sale As String = TextBox2.Text

        Dim exp_mon As String
        Dim exp_year As String

        Dim sale_mon As String
        Dim sale_year As String

        Dim rem_mon As String
        Dim rem_year As String

        If Not (CheckDate(exp) And CheckDate(sale)) Then
            MsgBox("Invalid date format")
        Else
            exp_mon = exp.Substring(3, 2)
            exp_year = exp.Substring(6, 4)

            sale_mon = sale.Substring(3, 2)
            sale_year = sale.Substring(6, 4)

            rem_mon = exp_mon - sale_mon
            rem_year = exp_year - sale_year

            If (Val(rem_mon) < 0 And exp_year = sale_year) Or Val(rem_year) < 0 Then
                MsgBox("Item not eligible for sale")
            Else
                MsgBox("Item eligible for sale")
            End If

        End If
    End Sub

End Class

Public Class main
    Dim qaArr(,) As String
    Dim optArr(,) As String
    Dim selOpt As String

    Dim ind As Integer = 0
    Dim gInd As Integer = -1

    Private Sub clrRadChk()
        If RadioButton1.Checked() Then
            RadioButton1.Checked = False

        ElseIf RadioButton2.Checked() Then
            RadioButton2.Checked = False

        ElseIf RadioButton3.Checked() Then
            RadioButton3.Checked = False
        Else
            RadioButton4.Checked = False
        End If
    End Sub

    Private Sub setQ()
        If ind >= qaArr.GetLength(0) Then
            MsgBox("Congratulations, You Have Won Rs. " & GroupBox1.Controls.Item(gInd).Text)
            Me.Close()
            Return
        End If

        Label1.Text = qaArr(ind, 0)
        RadioButton1.Text = optArr(ind, 0)
        RadioButton2.Text = optArr(ind, 1)
        RadioButton3.Text = optArr(ind, 2)
        RadioButton4.Text = optArr(ind, 3)
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qaArr = {
                    {"What is required in each C program?", "The program must have at least one function"},
                    {"How is an array initialized in C language?", "int a[3] = {1, 2, 3};"},
                    {"Which operator is used to free dynamically allocated memory in C++?", "delete"},
                    {"The concept of two functions with same name is know as?", "Function Overloading"},
                    {"How 3rd element in an array is accessed based on pointer notation?", "*(a + 3)"},
                    {"Which loop will always iterate for at least 1 time?", "do-while"},
                    {"What (cout << num++) will output if num = 50?", "50"},
                    {"Which one of the following is bitwise operator?", "^"},
                    {"Which operator symbols are also used for bitwise shift operation in C++?", "<< And >>"},
                    {"Which one of the following is called scope resolution operator", "::"},
                    {"A preprocessor directive is a statement that begins with?", "#"},
                    {"Which one of the following is ternary operator", "?:"},
                    {"char (*x) (char*);   Here, what ""x"" is called?", "Pointer to function"}
                }

        optArr = {
                    {"Input data", "The program must have at least one function", "Output data", "The program does not require any function"},
                    {"int a = {1, 2, 3};", "int a[] = new int[3]", "int a[3] = {1, 2, 3};", "int a(3) = [1, 2, 3];"},
                    {"free", "delete", "release", "memfree"},
                    {"Operator Overloading", "Function Overriding", "Function Overloading", "Function renaming"},
                    {"*a + 3", "*(*a + 3)", "&&(a + 3)", "*(a + 3)"},
                    {"while", "for", "do-while", "None of these"},
                    {"50++", "51", "50", "51++"},
                    {"||", "^", "&&&&", "!"},
                    {"&&&& And ||", "! And ~", "<< And >>", "None of these"},
                    {":", "<<", ">>", "::"},
                    {"{", "#", "//", "/*"},
                    {"?", ":", ":?", "?:"},
                    {"Pointer to char", "Pointer to char pointer", "Pointer to function", "Character pointer"}
                 }
        setQ()
        GroupBox1.Controls.Item(gInd + 1).BackColor = Color.Gray
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        selOpt = RadioButton1.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        selOpt = RadioButton2.Text
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        selOpt = RadioButton3.Text
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        selOpt = RadioButton4.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ind >= qaArr.GetLength(0) Then
            Return
        End If

        If selOpt = "" Then
            MsgBox("Please Select An Option")
            Return
        End If

        If selOpt <> qaArr(ind, 1) Then
            GroupBox1.Controls.Item(gInd + 1).BackColor = Color.Red

            If gInd = -1 Then
                MsgBox("Better Luck Next Time!")
                Me.Close()
                Return
            End If

            MsgBox("You Have Won Rs. " & GroupBox1.Controls.Item(gInd).Text)
            Me.Close()
            Return
        End If

        clrRadChk()

        gInd += 1
        GroupBox1.Controls.Item(gInd).BackColor = Color.Green

        ind += 1
        setQ()

        If ind < qaArr.GetLength(0) Then
            GroupBox1.Controls.Item(gInd + 1).BackColor = Color.Gray
        End If

        selOpt = ""
    End Sub
End Class
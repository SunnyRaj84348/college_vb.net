Imports System

Module Module1

    Sub dec2bin(ByVal dec As Integer)
        If dec <= 0 Then
            Return
        End If

        dec2bin(dec \ 2)
        Console.Write(dec Mod 2)
    End Sub

    Sub Main()
        Dim num As Integer
        Console.Write("Enter number: ")
        num = Console.ReadLine()

        dec2bin(num)

        System.Console.ReadKey()
    End Sub

End Module

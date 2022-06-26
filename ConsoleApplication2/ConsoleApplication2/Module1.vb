Imports System
Module Module1

    Sub Main()
        Dim arr(4) As Integer
        arr = {5, 7, 0, 2, 3}

        For Each i In arr
            Console.Write(i & " ")
        Next

        Console.ReadKey()

    End Sub

End Module

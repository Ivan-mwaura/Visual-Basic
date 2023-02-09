Imports System
Imports System.Runtime.CompilerServices

Module Program
    Sub Main()


     '  Dim y = 1
        Do
            Dim x = 1
            Do
                If (y = 1 Or y = 5 Or y = x) Then
                    Console.Write("&" & Space(2))
                Else
                    Console.Write("*" & Space(2))
                End If
                x = x + 1
            Loop While (x <= 5)
            Console.WriteLine()
            y = y + 1
        Loop While (y <= 5)
    End Sub
End Module

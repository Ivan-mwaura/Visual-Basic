Imports System

Module Program
    Sub Main(args As String())
        Dim i, j As Integer
        For i = 1 To 10
            For j = 1 To 10
                Console.Write(i * j & vbTab)
            Next
            Console.WriteLine()
        Next
    End Sub
End Module

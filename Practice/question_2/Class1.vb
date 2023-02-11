Imports System.Net.NetworkInformation

Public Class Class1

    Private point1, point2 As Integer
    Private x As Integer = 0
    Private y As Integer = 0
    Private output As Double

    Sub getinput()
        Console.Write("Enter your point x : ")
        point1 = Console.ReadLine()

        Console.Write("Enter your point Y : ")
        point2 = Console.ReadLine()

        Console.WriteLine("Your point is : " & Space(2) & point1 & "," & point2)

    End Sub

    Function calculate() As Double
        output = Math.Sqrt(((point1 - x) * (point1 - x)) + ((point2 - y) * (point2 - y)))

        Return output

    End Function

    Sub print()

        If (output <= 10) Then
            Console.WriteLine("Point : " & point1 & "," & point2 & Space(2) & "is inside the circle")
        Else
            Console.WriteLine("Point : " & point1 & "," & point2 & Space(2) & "is Outside the circle")
        End If
    End Sub

End Class

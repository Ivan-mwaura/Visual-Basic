Imports System.Drawing

Public Class Class1

    Private point1, point2 As Integer

    Sub getinput()
        Console.Write("Input point x : ")
        point1 = Console.ReadLine()

        Console.Write("Input point y : ")
        point2 = Console.ReadLine()


    End Sub

    Sub check_quadrant()
        If (point1 > 0 And point2 > 0) Then
            Console.WriteLine("Your points : " & Space(2) & point1 & "," & point2 & " are in the Quadrant 1")
        ElseIf (point1 < 0 And point2 > 0) Then
            Console.WriteLine("Your points : " & Space(2) & point1 & "," & point2 & " are in the Quadrant 2")
        ElseIf (point1 < 0 And point2 < 0) Then
            Console.WriteLine("Your points : " & Space(2) & point1 & "," & point2 & " are in the Quadrant 3")
        ElseIf (point1 > 0 And point2 < 0) Then
            Console.WriteLine("Your points : " & Space(2) & point1 & "," & point2 & " are in the Quadrant 4")
        Else
            Console.WriteLine("Enter valid points")
        End If
    End Sub


End Class

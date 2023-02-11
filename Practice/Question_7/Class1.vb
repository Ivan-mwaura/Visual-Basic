Public Class Class1

    Private num1, num2, input1, input2 As Integer

    Sub generate_numbers()
        Randomize()
        num1 = Int((10 * Rnd()) + 1)
        num2 = Int((10 * Rnd()) + 1)
    End Sub

    Sub getinput()
        Console.WriteLine(num1)
        Console.WriteLine(num2)

        Console.Write("Enter your first Lucky number : ")
        input1 = Console.ReadLine()

        Console.Write("Enter your second Lucky number : ")
        input2 = Console.ReadLine()

    End Sub
    Sub check_win()

        If (input1 = num1 And input2 = num2) Then
            Console.WriteLine("YOU WIN")
            Console.WriteLine("Your award is 10000 ksh")
        ElseIf ((Input1 = num1 Or input2 = num1) And (input1 = num2 Or input2 = num2)) Then
            Console.WriteLine("YOU WIN!!")
            Console.WriteLine("Your award is 3000 ksh")
        ElseIf ((input1 = num1 And input2 <> num2) Or (input1 <> num1 And input2 = num2)) Then
            Console.WriteLine("YOU WIN !!")
            Console.WriteLine("Your award is 1000 ksh")
        Else
            Console.WriteLine("You lost !!")
        End If


    End Sub

End Class

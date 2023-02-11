Public Class Class1

    Private answer, calculated_answer, i As Integer
    Private try_again As Char
    Private num1, num2 As Double


    Sub generate_number()

        Randomize()
        num1 = Int((10 * Rnd()) + 1)
        num2 = Int((10 * Rnd()) + 1)

    End Sub

    Function Calculate_answer() As Integer

        calculated_answer = num1 + num2

        Return calculated_answer

    End Function

    Sub getinput()
        Console.WriteLine("You two number are : " & num1 & Space(2) & "and " & Space(2) & num2 & Space(2) & "Calculate their Sum")
        Console.Write("Please Input Your Answer : ")
        Space(2)
        answer = Console.ReadLine()

    End Sub

    Sub next_try()

        If (answer = calculated_answer) Then

            Console.WriteLine("YOU GOT IT CORRECT !!")
        Else

            Console.WriteLine("Your answer is wrong !!")

            Console.WriteLine(" DO you want to try again ? click y to continue and n to exit !")
            try_again = Console.ReadLine()

            If (try_again = "y") Then
                getinput()

            Else
                Console.WriteLine("Thankyou for trying. Try again next time")
            End If

        End If

    End Sub

    Sub print()
        If (answer = calculated_answer) Then

            Console.WriteLine("YOU GOT IT CORRECT !!")
        Else


            Console.WriteLine("Your answer is wrong !!")

                Console.WriteLine(" DO you want to try again ? click y to continue and n to exit !")
                try_again = Console.ReadLine()

            For i = 1 To 2
                If (try_again = "y") Then
                    getinput()
                    next_try()
                ElseIf (try_again = "n") Then
                    Console.WriteLine("Thankyou for trying. Try again next time")
                End If

            Next
            Console.WriteLine("Your number of trials are Over. The correct answer is : " & calculated_answer)

            End If
    End Sub


End Class

Imports System

Module Program

    Dim inches As Double = 0.0254
    Dim pounds As Double = 0.45359237
    Sub Main()

        Dim weight, height, Calculate_BMI, calc_metres, calc_kgs As Double



        Console.Write("Enter Your Weight in Pounds : ")
        weight = Console.ReadLine()

        Console.Write("Enter Your height in Inches : ")
        height = Console.ReadLine()

        calc_kgs = weight * pounds
        calc_metres = height * inches

        Calculate_BMI = calc_kgs / calc_metres

        Console.WriteLine("YOur BMI is : " & Calculate_BMI)

        Select Case Calculate_BMI
            Case 0 To 18.5
                Console.WriteLine("You are Underweight")
            Case 18.6 To 25.0
                Console.WriteLine("You are Normal")
            Case 25.1 To 30.0
                Console.WriteLine("You are Overweight")
            Case 30.1 To 100
                Console.WriteLine("You are Obese")

        End Select

    End Sub
End Module

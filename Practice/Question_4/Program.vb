Imports System

Module Program
    Sub Main(args As String())

        Dim month_no, year As Integer


        Console.Write("Enter the Months Number : ")
        month_no = Console.ReadLine()

        Console.Write("Enter the Year : ")
        year = Console.ReadLine()

        If (month_no = 1) Then
            Console.Write("January " & year & " has 31 days")
        ElseIf (month_no = 2) Then
            If (year Mod 4 = 0) Then
                Console.Write("February " & year & " has 29 days")
            Else
                Console.Write("February " & year & " has 28 days")
            End If
        ElseIf (month_no = 3) Then
            Console.Write("March " & year & " has 31 days")
        ElseIf (month_no = 4) Then
            Console.Write("April " & year & " has 30 days")
        ElseIf (month_no = 5) Then
            Console.Write("May " & year & " has 31 days")
        ElseIf (month_no = 6) Then
            Console.Write("June " & year & " has 30 days")
        ElseIf (month_no = 7) Then
            Console.Write("July " & year & " has 30 days")
        ElseIf (month_no = 8) Then
            Console.Write("August " & year & " has 31 days")
        ElseIf (month_no = 9) Then
            Console.Write("September " & year & " has 31 days")
        ElseIf (month_no = 10) Then
            Console.Write("October " & year & " has 31 days")
        ElseIf (month_no = 11) Then
            Console.Write("November " & year & " has 31 days")
        ElseIf (month_no = 12) Then
            Console.Write("December " & year & " has 31 days")
        End If
    End Sub
End Module

Module Program
    Sub Main()
        Dim fee As Double ' Initial tuition fee
        Dim rate As Double
        Dim years As Integer  ' Number of years

        Console.Write("Input your Tuition fee : ")
        fee = Console.ReadLine()

        Console.Write("Input the Rate per Annum : ")
        rate = Console.ReadLine() / 100

        ' Loop until tuition is doubled

        years = 0

        Do Until fee >= 20000

            fee += fee * rate
            years += 1

        Loop

        Console.WriteLine("It will take " & years & " years to double the tuition fee.")
    End Sub
End Module

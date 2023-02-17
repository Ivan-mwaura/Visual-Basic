Module Module1

    Sub Main()
        Dim total, cheapest, expensive As Double, i As Integer
        Dim cost() As Double = {50.0, 10.5, 150.0, 10.0, 5.0, 86.0, 107.5, 300.0, 124.0, 36.0} 'using initializers. INITIALIZATION DURING EXECUTION.

        For i = LBound(cost) To UBound(cost) Step 1
            total = total + cost(i)
        Next
        Console.WriteLine("The cost of items = " & total)

        cheapest = cost(0)
        expensive = cost(0)
        For i = LBound(cost) To UBound(cost) Step 1
            If (cost(i) < cheapest) Then
                cheapest = cost(i)
            ElseIf (cost(i) > expensive) Then
                expensive = cost(i)
            End If
        Next
        Console.WriteLine("cheapest item cost = " & cheapest)
        Console.WriteLine("expensive item cost = " & expensive)

        Array.Sort(cost)
        For i = LBound(cost) To UBound(cost)
            Console.Write(cost(i) & Space(1))
        Next

        Console.WriteLine()

        Array.Reverse(cost) 'cannot work unless you sort first.
        For i = LBound(cost) To UBound(cost)
            Console.Write(cost(i) & Space(1))
        Next

        Array.Sort(cost)
        For i = LBound(cost) To UBound(cost)
            Console.Write(cost(i) & Space(1))
        Next
        Console.ReadKey()
    End Sub

End Module
Imports System

Module Program
    Private radius As Integer
    Sub Main()
        getradius()
        print()

    End Sub
    Sub getradius()
        Console.WriteLine("Enter the radius")

        radius = CInt(Console.ReadLine())

    End Sub
    Function computearea() As Double

        Dim area As Double

        area = Math.PI * Math.Pow(radius, 2)

        Return area

    End Function

    Function computeperimeter() As Double

        Dim perimeter As Double

        perimeter = Math.PI * radius * 2

        Return perimeter

    End Function

    Sub print()

        Console.WriteLine(" Area = " & Format(computearea(), "0.000"))
        Console.WriteLine("Perimeter = " & Format(computeperimeter(), "0.000"))
    End Sub

End Module

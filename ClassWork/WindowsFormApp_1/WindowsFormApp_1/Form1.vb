Imports System.Configuration

Public Class Form1
    Private radius As Integer
    Sub getradius()
        radius = CInt(txtrad.Text)

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
        lbloutput.Text = "Area = " & Format(computearea(), "0.00") & vbNewLine & "perimeter =  " & Format(computeperimeter(), "0.00")


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btncompute_Click(sender As Object, e As EventArgs) Handles btncompute.Click
        getradius()
        print()
    End Sub

    Private Sub txtrad_TextChanged(sender As Object, e As EventArgs) Handles txtrad.TextChanged

    End Sub
End Class

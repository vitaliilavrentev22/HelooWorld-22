Imports System.Security.Policy

Module Program

    Sub Main(args As String())
        Console.WriteLine(MathX(-2))
        Console.WriteLine(MathX(7, 5))
    End Sub
    Function MathX(x As Double) As Double
        Dim y As Double
        If x > 0 Then
            y = 2
        Else
            z = Math.Pow(x, 2)
        End If
        MathX = Math.Pow(Math.E, Cos(x, y)) - 2.7 * y
    End Function


End Module

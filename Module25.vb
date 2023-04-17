Module Program
    Sub Main(args As String())
        Dim t, z, x, c, ztc, y As Double
        z = 5.2
        t = 6.7
        c = -2.5
        ztc = 5.2 * 6.7 * -2.5
        t = MathF.Sqrt(MathF.Abs(4 * MathF.Pow(x, 2) - x * z + c))
        Console.WriteLine(t)
        x = MathF.Log(MathF.Abs(z * c - t) - 2) / MathF.Pow(MathF.E, z) - MathF.Pow(Sin, 2) * MathF.Pow(z, 2)
        Console.WriteLine(x)
    End Sub
End Module
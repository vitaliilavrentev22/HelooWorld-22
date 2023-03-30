Imports dada

Module Program
    Sub main(args As String())
        Dim longg As Integer
        Dim sm As Integer
        Dim dm As Integer
        Dim m As Integer

        Console.WriteLine(" Enter the length in centimeters ")

        longg = Console.ReadLine

        sm = longg Mod 100
        dm = longg - m * 100
        m = longg \ 100

        Console.WriteLine(" Centimeters " & longg & " = " & m & " m " & sm & " sm ")
        Console.WriteLine(" Centimeters " & longg & " = " & longg \ 10 & " dm " & sm Mod 10 & " sm ")
        Console.WriteLine(" Centimeters " & longg & " = " & m & " m " & dm \ 10 & " dm " & sm Mod 10 & " sm ")
    End Sub
End Module
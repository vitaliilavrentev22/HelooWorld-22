Imports System

Sub Main(args As String())

    Dim input(4) As Integer
    Console.WriteLine(" Set 5 numbers ")

    For i = 0 To 4
        input(i) = Console.ReadLine()
    Next
    Dim num As Integer

    Console.WriteLine(find(input, num))

End Sub

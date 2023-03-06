Module Module1

    Sub Main(args As String())
        Dim numbers(6) As Integer

        For i = 0 To numbers.Length - 1

            numbers(i) = Console.ReadLine()
        Next


        printReverse(numbers)
        Dim Strings(4) As String
        For i = 0 To Strings.Length - 1

            Strings(i) = Console.ReadLine()
        Next
        printReverse(Strings)
        Console.ReadLine()
    End Sub
    Sub printReverse(list As Integer())

        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next
    End Sub
    Sub printReverse(list As String())

        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next
    End Sub
End Module

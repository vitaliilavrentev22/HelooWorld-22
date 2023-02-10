Module Module1

    Sub Main(args As String())
        Dim Number As String = "1234"
        Dim ver As String
        Console.WriteLine("Угадай число")
        Do
            ver = Console.ReadLine()
            For j As Byte = 0 To 3
                For i As Byte = 0 To 3
                    If ver.Chars(j) = Number.Chars(i) Then
                        Console.WriteLine("{0}я цифра угадана", j + 1)
                        If i = j Then
                            Console.WriteLine("{0}я цифра бык", j + 1)
                        Else
                            Console.WriteLine("{0}я цифра корова", j + 1)
                        End If
                    End If
                Next
            Next

        Loop Until ver = Number
        Console.Read()

    End Sub

End Module

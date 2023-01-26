Module Module1
    Sub Main(args As String())
        Console.WriteLine("Введите строку текста: ")

        Dim text_line As String = Console.ReadLine()

        Dim vowels As Integer = 0, consonants = 0, spaces = 0, punctuation_marks = 0

        For Each symbol As Char In text_line
            Select Case symbol
                Case "A"c To "Z"c
                    vowels += 1
                Case "a"c To "z"c
                    consonants += 1
                Case " "c
                    spaces += 1
                Case ","c To "/"c, ";"c, ":"c, "?"c
                    punctuation_marks += 1
            End Select

    End Sub

End Module

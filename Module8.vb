
Module Program
        Sub Main(args As String())
            Dim N, ver As String
            Dim bulls, cows As Integer
            'TODO: Генерируем число
            Console.ForegroundColor = ConsoleColor.Green
            Randomize()
            Do
                N = Int((9000 * Rnd()) + 1000)
                Console.WriteLine(N)
            Loop Until Not CheckDublicates(N)

            Do
                ver = Console.ReadLine
                For j As Byte = 0 To 3
                    For i As Byte = 0 To 3
                        If (N.Chars(i) = ver.Chars(j)) Then
                            If i = j Then
                                bulls += 1
                            Else
                                cows += 1
                            End If
                        End If
                    Next
                Next
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Вы нашли коров = {0}", cows)
                Console.WriteLine("Вы нашли быков = {0}", bulls)
                cows = 0
                bulls = 0
            Loop Until N = ver
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Выигрыш")

        End Sub

        Function CheckDublicates(Num As String) As Boolean
            CheckDublicates = False
            For j = 0 To 2
                For i = j + 1 To 3
                    If Num.Chars(j) = Num.Chars(i) Then
                        CheckDublicates = True
                        Exit Function
                    End If
                Next
            Next
        End Function


    End Module


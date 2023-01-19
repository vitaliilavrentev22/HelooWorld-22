Module Module1

    Sub Main()
        Dim result As Long = 0
        Dim user_input As Long


        Console.WriteLine("Введите начальное число: ")
        result = Console.ReadLine()

        While True
            Console.WriteLine("Введите число для перемножения: ")
            user_input = Int64.Parse(Console.ReadLine())

            If user_input = 1 Then
                Console.WriteLine("Результат перемножения: {0}", result)
                Exit While
            End If

            If result > Int64.MaxValue / user_input Then
                Console.WriteLine("Произошло переполнение числа! Результат умножения до переполнения: {0}", result)
                Exit While
            End If

            result *= user_input
        End While
        Console.ReadKey()

    End Sub

End Module

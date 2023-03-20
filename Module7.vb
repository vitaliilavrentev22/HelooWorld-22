
Module массивы2
        Sub Main(args As String())

            Dim input(4) As Integer
            Console.WriteLine(" Set 5 numbers ")

            For i = 0 To 4
                input(i) = Console.ReadLine()
            Next
            Dim num As Integer


            Console.WriteLine(find(input, num))

        End Sub

        Sub printrevers(list As Integer())
            For i = list.Length - 1 To 0 Step -1
                Console.WriteLine(list(i))
            Next
        End Sub

        Sub printrevers(list As String())
            For i = list.Length - 1 To 0 Step -1
                Console.WriteLine(list(i))
            Next
        End Sub

        Sub print(list As Integer())

            For i = 0 To list.Length - 1
                Console.WriteLine(list(i))
            Next
        End Sub

        Sub print(list As String())

            For i = 0 To list.Length - 1
                Console.WriteLine(list(i))
            Next
        End Sub


        Function find(list As Integer(), num As Integer) As Integer

            For i = 0 To list.Length - 1
                If list(i) = 22 Then
                    find = i
                    Exit Function
                End If
            Next

            find = -1

        End Function
    End Module



Module massiv
        Sub Main(args As String())
            Console.WriteLine("Введите 5 чисел.")
            Dim numbers(4) As String
            Dim m As Integer


            For i = 0 To 4
                numbers(i) = Console.ReadLine()
            Next

            'Dim n As String
            'Console.WriteLine("Какое число искать")
            'n = Console.ReadLine
            'Console.WriteLine(FindStr(numbers, n))

            add(numbers, "adding", 5)
            print(numbers)

        End Sub

        Sub printRevers(list As Integer())
            For i = list.Length - 1 To 0 Step -1
                Console.WriteLine(list(i))
            Next
        End Sub

        Sub printReverse(list As String())
            For i = list.Length - 1 To 0 Step -1
                Console.WriteLine(list(i))
            Next
        End Sub

        Sub print(list As String())
            For i = 0 To list.Length - 1
                Console.WriteLine(list(i))
            Next
        End Sub

        Sub print(list As Integer())
            For i = 0 To list.Length - 1
                Console.WriteLine(list(i))
            Next
        End Sub

        Function find(List As Integer(), n As Integer) As Integer
            For i = 0 To List.Length - 1
                If List(i) = n Then
                    find = i
                    Exit Function
                End If
            Next
            find = -1
        End Function

        Function FindStr(List As String(), n As String) As Integer
            For i = 0 To List.Length - 1
                If List(i) = n Then
                    FindStr = i
                    Exit Function
                End If
            Next
            FindStr = -1
        End Function
        Function max(list As String()) As Integer
            max = 0
            For i = 1 To list.Length - 1
                If list(max) < list(i) Then
                    max = i
                End If
            Next
        End Function
        Function min(list As String()) As Integer
            min = 0
            For i As Integer = 1 To list.Length - 1
                If list(i) < list(min) Then
                    min = i
                End If
            Next
        End Function

        Sub add(ByRef list As String(), val As String, index As Integer)
            If index < 0 Or index > list.Length Then Exit Sub
            ReDim Preserve list(list.Length)
            For i = list.Length - 1 To index + 1 Step -1
                list(i) = list(i - 1)
            Next
            list(index) = val
        End Sub
    End Module


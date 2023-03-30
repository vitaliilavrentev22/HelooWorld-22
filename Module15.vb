Module Masivmin
    Sub Main(args As String())
        Dim num(6) As Integer
        Console.WriteLine("set 5 numbers")
        Dim m As Integer
        Dim q As Integer

        Dim strings(4) As String

        For i = 0 To strings.Length - 1
            strings(i) = Console.ReadLine()
        Next
        m = min(strings)
        q = max(strings)
        Console.WriteLine("index = {0}, Min = {1}", m, strings(m))
        Console.WriteLine("index = {0}, Max = {1}", q, strings(q))

    End Sub
    Sub printRevers(list As Integer())

        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next

    End Sub
    Sub printRevers(list As String())

        For i = 0 To list.Length - 1
            Console.WriteLine(list(i))
        Next

    End Sub
    Sub print(list As Integer())

        For i = 0 To list.Length - 1
            Console.WriteLine(list(i))
        Next

    End Sub
    Function find(list As Integer(), e As Integer) As Integer

        For f = 0 To list.Length - 1
            If list(f) = e Then
                find = f
                Exit Function
            End If
        Next
        find = -1

    End Function

    Function findStr(list As String(), e As String) As Integer

        For f = 0 To list.Length - 1
            If list(f) = e Then
                findStr = f
                Exit Function
            End If
        Next
        findStr = -1

    End Function
    Function min(list As String()) As Integer
        min = 0
        For i = 1 To list.Length - 1
            If list(min) > list(i) Then
                min = i
            End If
        Next

    End Function
    Function max(list As String()) As Integer
        max = 0
        For i = 1 To list.Length - 1
            If list(max) < list(i) Then
                max = i
            End If
        Next

    End Function
End Module

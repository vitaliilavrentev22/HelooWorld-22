Imports System
Imports System.Net

Module Masiv
    Enum sortDirectionъ
        fewrwegf
        Vfdret
    End Enum
    Sub Main(args As String())
        Dim num(4), Mas As Integer
        'Dim Slovo() As String
        Console.WriteLine("have 5 Name")
        Dim m, n As Integer

        For i = 0 To 4
            num(i) = Console.ReadLine()
        Next

        'printRevers(Slovo)

        'Console.WriteLine("index = {0}", find(num, 21))

        'Dim strings(4) As String

        'For i = 0 To strings.Length - 1
        ' strings(i) = Console.ReadLine()
        'Next
        ''printRevers(strings)

        'Console.WriteLine("Write 5 values (Килограммы)")

        'For i = 0 To 4
        ' num(i) = Console.ReadLine()
        'Next
        'Console.WriteLine("Numbers")
        'For i = 0 To 4
        ' num(i) = Console.ReadLine()
        'Next
        ''n = min(strings)
        ''m = max(strings)
        ''Console.WriteLine("index = {0}, Min = {1}", n, strings(n))
        ''Console.WriteLine("index = {0}, Max = {1}", m, strings(m))
        ''add(num, "add", 2)


        'printRevers(strings)
        'printRevers(num)
        'Console.WriteLine("index = {0}", minInt(num))
        'delete(num, 2)
        'print(num)
        'Dim minIndex As Integer = min(num)
        'If minIndex > 0 Then
        ' Dim Boofer As String = num(0)
        ' num(0) = num(minIndex)
        ' num(minIndex) = Boofer
        'End If
        Sort(num, sortDirection.Vfdret)

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
    Function max(list As Integer(), Optional start As Integer = 0) As Integer
        max = 0
        For i = 1 To list.Length - 1
            If list(max) < list(i) Then
                max = i
            End If
        Next

    End Function

    Function min(list As Integer(), Optional start As Integer = 0) As Integer
        min = start
        For i = start To list.Length - 1
            If list(min) > list(i) Then
                min = i
            End If
        Next

    End Function

    'Function minInt(list As Integer()) As Integer
    ' minInt = 0
    ' For i = 1 To list.Length - 1
    ' If list(minInt) > list(i) Then
    ' minInt = i
    ' End If
    ' Next

    'End Function

    Sub add(ByRef list As String(), val As String, index As Integer)
        If index < 0 Or index > list.Length Then Exit Sub
        ReDim Preserve list(list.Length)
        For i = list.Length - 1 To index + 1 Step -1
            list(i) = list(i - 1)
        Next
        list(index) = val
    End Sub

    Sub delete(ByRef list As String(), index As Integer)
        If index < 0 Or index >= list.Length Then Exit Sub
        For i As Integer = index To list.Length - 2

        Next
        ReDim Preserve list(list.Length - 2)
    End Sub

    Sub Sort(list As Integer(), derection As Boolean)
        Dim index As Integer
        Dim boofer As Integer
        For i = 0 To list.Length - 1
            If derection Then
                index = min(list, i)
            ElseIf sortDirection.Vfdret Then
                index = max(list, i)
            End If
            If index > i Then
                boofer = list(index)
                list(index) = list(i)
                list(i) = boofer
            End If
        Next
    End Sub
    Sub Sort1(list As Integer(), Optional start As Integer = 0)
        Dim Maxindex As Integer
        Dim boofer As Integer
        For i = 0 To list.Length - 1
            If Maxindex > i Then
                boofer = list(Maxindex)
                list(Maxindex) = list(i)
                list(i) = boofer
            End If
            Maxindex = max(list, i)
        Next
    End Sub
End Module
Module Program
    Enum SortDirection
        Vozrastanie
        Ybivanie
    End Enum
    Sub Main(args As String())

        Console.WriteLine("Enter five numbers:")
        Dim numbers(4) As Integer
        Dim n As Integer
        For i = 0 To 4
            numbers(i) = Console.ReadLine
        Next
        Console.WriteLine("Choose what you need: 1 - Find a number in the array, 2 - Find the minimum number in the array, 3 - Find the maximum number in the array, 4 - Output the array in reverse order, 5 - Output the array in the usual order, 6 - Add a new element to the array, 7 - Remove an element from the array, 8 - Sort the numbers in ascending order, 9 - Sort the numbers in descending order:")
        n = Console.ReadLine
        Select Case n
            Case 1

                Console.WriteLine("Which number do you want to search for?")
                n = Console.ReadLine
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("----------------------------------------------------------")
                Console.WriteLine("The number you are looking for is in the {0} index", find(numbers, n))
                Console.WriteLine("----------------------------------------------------------")

            Case 2
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("----------------------------------------------------------")
                Console.WriteLine("index of the number {0}, minimum number {1}", Min(numbers), numbers(Min(numbers)))
                Console.WriteLine("----------------------------------------------------------")
            Case 3
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("----------------------------------------------------------")
                Console.WriteLine("index of the number {0}, maximum number {1}", Max(numbers), numbers(Max(numbers)))
                Console.WriteLine("----------------------------------------------------------")
            Case 4
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("---------")
                printRevers(numbers)
                Console.WriteLine("---------")
            Case 5
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("---------")
                print(numbers)
                Console.WriteLine("---------")
            Case 6
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("---------")
                add(numbers, "adding", 0)
                print(numbers)
                Console.WriteLine("---------")
            Case 7
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("---------")
                delete(numbers, 3)
                print(numbers)
                Console.WriteLine("---------")
            Case 8

                Sort(numbers, SortDirection.Vozrastanie)
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("---------")
                print(numbers)
                Console.WriteLine("---------")
            Case 9
                Sort(numbers, SortDirection.Ybivanie)
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("---------")
                print(numbers)
                Console.WriteLine("---------")


        End Select
    End Sub

    Sub printRevers(list As Integer())
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
    Sub printReverse(list As String())
        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next
    End Sub
    Function find(list As Integer(), n As Integer)
        For i = 0 To list.Length - 1
            If list(i) = n Then
                find = i
                Exit Function
            End If
        Next
        find = -1
    End Function

    Function Max(list As Integer(), Optional start As Integer = 0) As Integer
        Max = start
        For i = start + 1 To list.Length - 1
            If list(i) > list(Max) Then
                Max = i
            End If
        Next
    End Function
    Function Min(list As Integer(), Optional start As Integer = 0) As Integer
        Min = start
        For i = start + 1 To list.Length - 1
            If list(i) < list(Min) Then
                Min = i
            End If
        Next

    End Function

    Sub add(ByRef list As Integer(), val As String, index As Integer)
        If index < 0 Or index > list.Length Then Exit Sub
        ReDim Preserve list(list.Length)
        For i = list.Length - 1 To index + 1 Step -1
            list(i) = list(i - 1)
        Next

        list(index) = val

    End Sub
    Sub delete(ByRef list As Integer(), index As Integer
            End Sub
    Sub BubbleSort(list As String(), Optional dir As SortType = SortType.Ascending)
    Dim b As String
    For j = 0 To list.Length - 2
        For i = 0 To list.Length - 2 - j
            If list(i) > list(i + 1) Then
                b = list(i)
                list(i) = list(i + 1)
                list(i + 1) = b
            End If
        Next
    Next
End Sub

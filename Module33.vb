Module Module1

    Sub Main()
        Dim massiv(4) As String
        For i = 0 To 4
            massiv(i) = Console.ReadLine()

        Next

    End Sub
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
End Module


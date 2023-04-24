Module Module1
    Dim brush As Char = "0"c
    Sub Hline(leftX As Byte, topY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 0 To length - 1
            Console.Write(brush)
        Next
    End Sub
    Sub Vline(leftX As Byte, topY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, topY)
        Console.Write(brush)
        For i = 0 To length - 1
            Console.SetCursorPosition(leftX, topY + i)
            Console.Write(brush)
        Next
    End Sub
    Sub FillRectMod(leftX As Byte, topY As Byte, width As Byte, height As Byte, x As Byte, y As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 0 To height - 1
            If i Mod (x + y) < x Then
                Console.BackgroundColor = ConsoleColor.DarkBlue
            Else
                Console.BackgroundColor = ConsoleColor.White
            End If
            Hline(leftX, topY + i, width)
        Next
        Console.WriteLine()
    End Sub
    Sub FillRect(leftX As Byte, topY As Byte, width As Byte, height As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 0 To height - 1
            Hline(leftX, topY + i, width)
        Next
        Console.WriteLine()
    End Sub
    Sub Rect(leftX As Byte, topY As Byte, width As Byte, height As Byte)
        Hline(leftX, topY, width)
        Vline(leftX, topY, height)
        Hline(leftX, topY + height, width)
        Vline(leftX + width, topY, height + 1)
        Console.WriteLine()
    End Sub

    Sub Main()
        Console.SetWindowSize(100, 50)
        Dim N As Integer, key As ConsoleKeyInfo, top, left, height, width, gap, quantity As Byte
        Do
            Console.Write("Что нарисовать: отметка - 1, отметка с цветом - 2, квадраты цветные - 3: ")
            N = CInt(Console.ReadLine())


            If N = 1 Then
                Console.BackgroundColor = ConsoleColor.Black 'восстанавливаем цвет
                Console.ForegroundColor = ConsoleColor.White
                brush = "H"c
                Console.Clear()
                Console.WriteLine("Введите координаты отметки")
                Console.Write("Координаты по вертикали: ")
                top = CByte(Console.ReadLine)
                Console.Write("Координаты по горизонтали: ")
                left = CByte(Console.ReadLine)
                Console.WriteLine("Введите размеры")
                Console.Write("Длина: ")
                height = CByte(Console.ReadLine)
                Console.Write("Ширина: ")
                width = CByte(Console.ReadLine)
                Console.Clear()
                height = height / 2


                While width > 8 And height > 4
                    Rect(left, top, width, height)
                    left += 4
                    top += 2
                    width -= 8
                    height -= 4
                End While
            End If


            If N = 2 Then
                Console.BackgroundColor = ConsoleColor.Black 'восстанавливаем цвет
                Console.ForegroundColor = ConsoleColor.White
                brush = "H"c
                Console.Clear()
                Console.WriteLine("Введите координаты отметки с цветом")
                Console.Write("Координаты по вертикали: ")
                top = CByte(Console.ReadLine)
                Console.Write("Координаты по горизонтали: ")
                left = CByte(Console.ReadLine)
                Console.WriteLine("Введите размеры")
                Console.Write("Длина: ")
                height = CByte(Console.ReadLine)
                Console.Write("Ширина: ")
                width = CByte(Console.ReadLine)
                Console.Clear()
                height = height / 2

                Dim colors = New ConsoleColor() {ConsoleColor.DarkYellow, ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.DarkBlue, ConsoleColor.DarkMagenta}

                Dim i As Integer

                While width > 8 And height > 4
                    If i > colors.Length - 1 Then
                        i = 0
                    End If
                    Console.ForegroundColor = colors(i)
                    Rect(left, top, width, height)
                    left += 4
                    top += 2
                    width -= 8
                    height -= 4
                    i += 1

                End While
                Console.BackgroundColor = ConsoleColor.Black 'восстанавливаем цвет
                Console.ForegroundColor = ConsoleColor.White

            End If

            If N = 3 Then
                brush = " "c
                Console.BackgroundColor = ConsoleColor.Black 'восстанавливаем цвет
                Console.ForegroundColor = ConsoleColor.White
                Console.Clear()
                Console.WriteLine("Введите координаты квадрата")
                Console.Write("Координаты по вертикали: ")
                top = CByte(Console.ReadLine)
                Console.Write("Координаты по горизонтали: ")
                left = CByte(Console.ReadLine)
                Console.WriteLine("Введите размеры")
                Console.Write("Длина: ")
                height = CByte(Console.ReadLine)
                Console.Write("Ширина: ")
                width = CByte(Console.ReadLine)
                Console.Clear()
                height = height / 2
                FillRectMod(left, top, width, height, 2, 2)
                FillRectMod(left + width + 2, top, width, height, 3, 1)
                FillRectMod(left, top + height + 2, width, height, 1, 3)
                FillRectMod(left + width + 2, top + height + 2, width, height, 3, 2)

                Console.BackgroundColor = ConsoleColor.Black 'воcстанавливаем цвет
                Console.ForegroundColor = ConsoleColor.White
            End If
        Loop
    End Sub

End Module

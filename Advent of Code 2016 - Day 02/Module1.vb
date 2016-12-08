Module Module1
    Dim input_file_name As String = "input.txt"

    Dim x As Integer = 2
    Dim y As Integer = 2

    Sub Main()

        Dim input_list As New ArrayList
        input_list = readFile()
        For i As Integer = 0 To input_list.Count - 1
            Dim input_line As String = input_list(i)
            For c As Integer = 0 To input_line.Length - 1
                Dim chr As String = input_line(c)
                'D - U - R - L
                doStep(chr)
                Console.Write(chr)
            Next
            Console.WriteLine(x & "; " & y)
        Next

        Dim abc As String = Console.ReadLine
    End Sub

    Function readFile()
        Dim input_lines As New ArrayList
        Dim objReader As New System.IO.StreamReader("./" & input_file_name)

        Do While objReader.Peek() <> -1
            input_lines.Add(objReader.ReadLine() & vbNewLine)
        Loop

        Return input_lines
    End Function

    Sub doStep(ByVal direction As String)
        If direction = "D" Then
            If y < 3 Then
                y = y + 1
            End If
        ElseIf direction = "U" Then
            If y > 1 Then
                y = y - 1
            End If
        ElseIf direction = "R" Then
            If x < 3 Then
                x = x + 1
            End If
        ElseIf direction = "L" Then
            If x > 1 Then
                x = x - 1
            End If
        End If
    End Sub
End Module

Module Module1
    Dim input_file_name As String = "input.txt"

    Dim x As Integer = 2
    Dim y As Integer = 2
    Dim pad As New DataTable

    Sub Main()

        pad.Columns.Add("First")
        pad.Columns.Add("Second")
        pad.Columns.Add("Third")
        pad.Rows.Add("1", "2", "3")
        pad.Rows.Add("4", "5", "6")
        pad.Rows.Add("7", "8", "9")

        Dim solution As String = ""
        Dim input_list As New ArrayList
        input_list = readFile()
        For i As Integer = 0 To input_list.Count - 1
            Dim input_line As String = input_list(i)
            For c As Integer = 0 To input_line.Length - 1
                'D - U - R - L
                doStep(input_line(c))
                Console.Write(input_line(c))
            Next
            Console.WriteLine("> POSITION: " & x & " ; " & y)
            solution = solution & pad.Rows(y - 1).Item(x - 1)
        Next
        Console.WriteLine("> SOLUTION: " & solution)
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

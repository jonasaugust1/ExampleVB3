Imports System

Module Program
    Sub Main(args As String())
        Dim score As String

        Console.Write("Please enter a score: ")
        score = Console.ReadLine()

        If score >= 8 Then
            Console.WriteLine("Congratulations!!")
        ElseIf score >= 5 Then
            Console.WriteLine("You are approved!")
        Else
            Console.WriteLine("You failed!")
        End If

        'CInt convert string to integer
        Select Case CInt(score)
            Case 90 To 100
                Console.WriteLine("You are approved - A")
            Case 70 To 89
                Console.WriteLine("You are approved - B")
            Case 50 To 60
                Console.WriteLine("You are approved - C")
        End Select

        Dim number As Integer = 2

        While number <= 50
            Console.WriteLine(number)
            number = number + 2
        End While
        Console.WriteLine("Finish While")

        'while the condition is true
        Do While number <= 60
            Console.WriteLine(number)
            number += 4

            If number = 56 Then
                Exit Do
            End If
        Loop
        Console.WriteLine("Finish Do While")

        'until the condition is true
        Do Until number > 100
            Console.WriteLine(number)
            number += 4
        Loop
        Console.WriteLine("Finish Do Until")

        'The condition is verified after the Do is executed
        Do
            Console.WriteLine(number)
            number += 2
        Loop While number <= 100
        Console.WriteLine("Finish Do Loop While")

        Do
            Console.WriteLine(number)
            number += 2
        Loop Until number > 100
        Console.WriteLine("Finish Do Loop Until")

        Dim counter As Integer

        For counter = 1 To 10 Step 2
            Console.WriteLine("Counter = {0}", counter)
        Next
    End Sub
End Module

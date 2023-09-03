﻿'Zachary Christensen
'RCET 2265
'Fall 2023
'Simple Calculator
'https://github.com/Minidude140/SimpleCalculator.git


Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()
        'TODO
        '[~]Prompt user for a number and reflect back thier input
        '[~]Prompt user for a second number and reflect back both thier inputs
        '[~]Ask user if they would like to multiply or divide thier input
        '[~]Return computated value
        '[~]Prompt to exit program

        Dim userInput As String
        Dim numberOne As Integer
        Dim numberTwo As Integer

        'First Number Aquisition
        Console.WriteLine("Please enter a number.")
        userInput = Console.ReadLine()
        Console.WriteLine($"You have entered {userInput}.")
        '*****WILL CRASH HERE IF INVALID CONVERSION********
        numberOne = CInt(userInput)

        'Second Number Aquistion
        Console.WriteLine("Please enter a second number.")
        userInput = Console.ReadLine()
        Console.WriteLine($"You have entered {numberOne} and {userInput}.")
        '*****WILL CRASH HERE IF INVALID CONVERSION********
        numberTwo = CInt(userInput)

        'Prompt, Compute, and Return
        Console.WriteLine("Would you like to add or multiply these two numbers?" & vbLf & "Please enter '+' or '*'")
        userInput = Console.ReadLine()

        'Determine Desired Operation
        If (userInput = "+") Then
            'Add
            Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}")
        ElseIf (UserInput = "*") Then
            'Multiply
            Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}")
        Else
            'not multiply or divide
            Console.WriteLine($"{numberOne} {userInput} {numberTwo} = ???" & vbLf & "I don't know that kind of math.")
        End If

        'End greeting and exit
        Console.WriteLine("Too much math for me, have a good day." & vbLf & "(Please press enter to exit)")
        Console.Read()

    End Sub

End Module

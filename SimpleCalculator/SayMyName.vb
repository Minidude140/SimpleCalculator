'Zachary Christensen
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
        '[]Prompt user for a second number and reflect back both thier inputs
        '[]Ask user if they would like to multiply or divide thier input
        '[]Return computated value


        Dim userInput As String
        Dim numberOne As Integer
        Dim numberTwo As Integer
        'Dim operator As String

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

        Console.Read()

    End Sub

End Module

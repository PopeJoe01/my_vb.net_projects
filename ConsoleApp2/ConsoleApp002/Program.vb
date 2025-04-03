Imports System
Imports System.Transactions

Module Program
    Sub Main(args As String())
        Dim favoriteNumber As Integer
        Dim goodname As String
        Dim age As Double

        Console.WriteLine("Enter your favorite number")
        favoriteNumber = Console.ReadLine

        Console.WriteLine("Enter your good name")
        goodname = Console.ReadLine

        Console.WriteLine("Enter your age")
        age = Console.ReadLine



        Console.WriteLine("you have entered:" & favoriteNumber)
        Console.WriteLine("you have entered:" & goodname)
        Console.WriteLine("you have entered:" & age)
    End Sub
End Module

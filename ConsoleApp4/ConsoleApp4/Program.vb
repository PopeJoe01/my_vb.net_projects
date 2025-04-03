Imports System

Module Program
    Sub Main(args As String())
        Dim x As Integer = 5
        Dim y As Integer = 10

        Dim obj As Object = "Hello"
        Dim obj2 As Object = "World"

        Dim str As String = "Hello"
        Dim str2 As String = "H*"

        Console.WriteLine("x > y is " & (x > y).ToString())
        Console.WriteLine("x < y is " & (x < y).ToString())
        Console.WriteLine("x = y is " & (x = y).ToString())
        Console.WriteLine("x <> y is " & (x <> y).ToString())
        Console.WriteLine("x >= y is " & (x >= y).ToString())
        Console.WriteLine("x <= y is " & (x <= y).ToString())
        Console.WriteLine("obj Is obj2 is " & (obj Is obj2).ToString())
        Console.WriteLine("obj IsNot obj2 is " & (obj IsNot obj2).ToString())
        Console.WriteLine("str Like str2 is " & (str Like str2).ToString())

        Console.ReadLine()

    End Sub
End Module

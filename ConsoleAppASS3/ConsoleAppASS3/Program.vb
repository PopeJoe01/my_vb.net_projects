Imports System

Module Program
    Sub Main(args As String())
        'Declaration and initilization
        Dim a As Integer = 17
        Dim b As Integer = 4

        'Calculation
        Dim sum As Integer = a + b
        Dim subtraction As Integer = a - b
        Dim multiplication As Integer = a * b
        Dim division As Integer = a / b
        Dim modulus As Integer = a Mod b
        Dim power As Double = a ^ b

        'display results
        Console.WriteLine("Sum of a+b {21}")
        Console.WriteLine("Subtraction of a-b")
        Console.WriteLine("Multiplication of a*b")
        Console.WriteLine("Modulus of a%b")
        Console.WriteLine("Power of a^b")

    End Sub
End Module

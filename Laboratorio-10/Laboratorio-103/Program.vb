Imports System
Module peso
    Sub Main()
        'Declaración de variables
        Dim M As Double
        Dim G As Double
        Dim P As Double
        G = 9.8

        'Ingresar valores para las variables
        Console.Write("Ingrese la masa del objeto:")
        M = Console.ReadLine()

        'Realizar los procesos
        P = M * G

        'Mostrar resultados
        Console.WriteLine("Peso del objeto (N): " & P)

    End Sub
End Module

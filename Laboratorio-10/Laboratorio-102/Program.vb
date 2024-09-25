Module area
    Sub Main()
        Dim radio As Single
        Dim area As Single
        Dim circunferencia As Single
        Const pi = 3.14159265

        Console.WriteLine("Ingrese el radio: ")
        radio = Console.ReadLine()

        area = pi * radio ^ 2
        circunferencia = 2 * pi * radio

        Console.WriteLine("El área es {0}", area)

        Console.WriteLine("La circunferencia es: {0}", circunferencia)
    End Sub
End Module

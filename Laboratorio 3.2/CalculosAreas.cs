using System;

internal class CalculosAreas
{
    private static void Main(string[] args)
    {
        double radio;

        Console.Write("Introduce el radio del círculo para calcular el área: ");
        radio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("El área del círculo es: {0}", calculoArea(radio));
    }

    private static double calculoArea(double radio)
    {
        double area = Math.PI * Math.Pow(radio, 2);
        return area;
    }
}

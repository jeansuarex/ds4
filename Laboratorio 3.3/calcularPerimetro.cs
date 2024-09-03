using System;

internal class calcularPerimetro
{
    private static void Main(string[] args)
    {
        double ancho, alto;

        Console.Write("Introduce el ancho del rectángulo: ");
        ancho = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el alto del rectángulo: ");
        alto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("El perímetro del rectángulo es: {0}", CalcularPerimetro(ancho, alto));
    }

    private static double CalcularPerimetro(double ancho, double alto)
    {
        double perimetro = 2 * (ancho + alto);
        return perimetro;
    }
}

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        Console.Write("Ingrese el límite inferior: ");
        int min = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el límite superior: ");
        int max = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la cantidad de números no repetidos a generar: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        try
        {
            int[] arregloNoRepetidos = aleatorios.GenerarArregloNoRepetidos(min, max, cantidad);
            Console.WriteLine("Arreglo de números no repetidos generados:");
            foreach (int numero in arregloNoRepetidos)
            {
                Console.WriteLine(numero);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}

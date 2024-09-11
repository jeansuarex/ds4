using System;

internal class Program
{
    private int[] sueldos;

    private void Cargar()
    {
        sueldos = new int[5]; 
        for (int f = 0; f < 5; f++) 
        {
            Console.Write("Ingrese saldo del operario " + (f + 1) + ": ");
            string linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea);
        }
    }

    private void Imprimir()
    {
        Console.WriteLine("Los 5 sueldos de los operarios:");
        for (int f = 0; f < 5; f++) 
        {
            Console.Write("[" + sueldos[f] + "] ");
        }
        Console.WriteLine(); 
        Console.ReadKey(); 
    }

    private static void Main(string[] args)
    {
        Program pv = new Program();
        pv.Cargar();
        pv.Imprimir();
    }
}

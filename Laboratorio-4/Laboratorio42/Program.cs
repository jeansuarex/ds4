﻿internal class Program
{
    private static void Main(string[] args)
    {
        int fac = 1, n;
        string linea;
        Console.Write("ingrese un numero: ");
        linea = Console.ReadLine(); 
        n = int.Parse(linea);
        for (int i =1; i <= n; i++)
        {
            fac = fac * i;
        }
        Console.Write("La factorial es: " + fac);
        Console.ReadKey();
    }
}
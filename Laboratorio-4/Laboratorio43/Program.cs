using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0, cant = 0, valor;
        string linea;
        double promedio;

        do
        {
            Console.Write("Ingrese un numero (0 para finalizar): ");
            linea = Console.ReadLine();
            valor = int.Parse(linea);

            if (valor != 0)
            {
                suma += valor;
                cant++;
            }
        } while (valor != 0);

        if (cant != 0)
        {
            promedio = (double)suma / cant;
            Console.WriteLine("El promedio de los valores ingresados es: " + promedio);
        }
        else
        {
            Console.WriteLine("No se ingresaron valores.");
        }

        Console.ReadLine();
    }
}

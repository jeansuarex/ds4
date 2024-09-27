using System;

public class Aleatorios
{
    private Random random;

    public Aleatorios()
    {
        random = new Random();
    }

    public int GenerarNumeroEntre(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    public int[] GenerarArregloEntre(int min, int max, int cantidad)
    {
        int[] arreglo = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = GenerarNumeroEntre(min, max);
        }
        return arreglo;
    }

    public int[] GenerarArregloNoRepetidos(int min, int max, int cantidad)
    {
        if (cantidad > (max - min + 1))
            throw new ArgumentException("La cantidad solicitada excede el rango de números disponibles.");

        int[] arreglo = new int[cantidad];
        HashSet<int> numerosGenerados = new HashSet<int>();

        for (int i = 0; i < cantidad; i++)
        {
            int numero;
            do
            {
                numero = GenerarNumeroEntre(min, max);
            } while (numerosGenerados.Contains(numero));

            numerosGenerados.Add(numero);
            arreglo[i] = numero;
        }

        return arreglo;
    }
}

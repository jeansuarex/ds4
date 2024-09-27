internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el primer lado: ");
        decimal lado1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese el segundo lado: ");
        decimal lado2 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese el tercer lado: ");
        decimal lado3 = Convert.ToDecimal(Console.ReadLine());

        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Los lados ingresados no pueden formar un triángulo.");
        }

        Console.ReadLine();
    }
}

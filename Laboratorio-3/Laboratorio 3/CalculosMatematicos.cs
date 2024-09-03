internal class CalculosMatematicos
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero, operacion;

        Console.Write("Introduce el primer número: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        operacion = Calcular(primerNumero, segundoNumero);

        Console.WriteLine($"El resultado de la operación es: {operacion}");
    }

    private static int Calcular(int a, int b)
    {
        int operacion = (a + b) * (a - b);
        return operacion;
    }
}

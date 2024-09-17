internal class Program
{
    static void CheckAge(int age)
    {
        if (age < 10)
        {
            throw new ArithmeticException("Acceso negado, no cumple con el criterio de edad.");
        }
        else
        {
            Console.WriteLine("Acceso concedido.");
        }
    }

    private static void Main(string[] args)
    {
        CheckAge(15);
    }
}

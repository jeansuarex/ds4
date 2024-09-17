internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Digite el número deseado");

        try
        {
            num = Int16.Parse(Console.ReadLine());
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("El número introducido es muy grande.");
            num = -1;
        }

        Console.WriteLine(num);
    }
}


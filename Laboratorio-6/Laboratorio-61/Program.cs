internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Digite el número deseado");

        try
        {
            num = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("No se ha introducido un dígito válido.");
            num = -1;
        }

        Console.WriteLine(num);
    }
}

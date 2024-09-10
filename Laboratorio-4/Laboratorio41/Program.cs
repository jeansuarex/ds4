internal class Program
{
    private static void Main(string[] args)
    {
        int n, x;
        string line;
        Console.Write("Ingrese un valor n: ");
        line = Console.ReadLine();
        n = int.Parse(line);
        x = 1;
        while (x <= n)  
        {
            Console.Write(x);

            if (x < n)
            {
                Console.Write(", ");
            }

            x = x + 1;
        }
        Console.ReadKey();
    }
}

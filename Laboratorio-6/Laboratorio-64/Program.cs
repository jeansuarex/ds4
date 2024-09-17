using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int[] mynumeros = { 1, 2, 3 };
            Console.WriteLine(mynumeros[10]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Algo salió mal, valide el índice.");
        }
        finally
        {
            Console.WriteLine("Continuación de la aplicación, luego del bloque try/catch.");
        }
    }
}

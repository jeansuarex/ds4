using System;

namespace Laboratorio_2
{
    internal class VarEstatica
    {
        public static void Main()
        {
            Myclass.Valor = 1;
            Console.WriteLine(Myclass.Valor);
        }
    }

    public class Myclass
    {
        public static int Valor;
    }
}

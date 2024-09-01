class VarLocalSum
{
    static void Main(string[] args)
    {
        VarLocalSum program = new VarLocalSum();

        program.Sumar(5, 10);         
        program.SumarYMostrar(3, 7);  
    }

    public void Sumar(int valor1, int valor2)
    {
        int variableLocal = valor1 + valor2;
        Console.WriteLine(variableLocal);
    }

    public void SumarYMostrar(int valor1, int valor2)
    {
        int variableLocal = valor1 + valor2;
        Console.WriteLine(variableLocal);
        Console.WriteLine(valor1);
    }
}

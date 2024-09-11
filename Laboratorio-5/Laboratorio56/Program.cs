using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> paisesYcapitales = new Dictionary<string, string>
        {
            { "Francia", "París" },
            { "España", "Madrid" },
            { "Italia", "Roma" }
        };

        foreach (KeyValuePair<string, string> pair in paisesYcapitales)
        {
            Console.WriteLine("La capital de " + pair.Key + " es " + pair.Value + ".");
        }
    }
}

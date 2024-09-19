using System;

namespace Laboratorio_81
{
    public class Trabajador : Persona
    {
        public int Sueldo { get; set; }

        public Trabajador(string nombre, int edad, string nif, int sueldo) : base(nombre, edad, nif)
        {
            Sueldo = sueldo;
        }
    }
}

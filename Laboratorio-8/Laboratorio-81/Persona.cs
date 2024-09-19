using System;

namespace Laboratorio_81
{
    public class Persona 
    {
        public string Nombre { get; set; } 
        public int Edad { get; set; } 
        public string NIF { get; set; } 

        public void Cumpleaños()
        {
            Edad++;
        }

        public Persona(string nombre, int edad, string nif)
        {
            Nombre = nombre;
            Edad = edad;
            NIF = nif;
        }
    }
}

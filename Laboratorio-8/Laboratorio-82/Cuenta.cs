﻿using System;

namespace Laboratorio_82
{
    internal class Cuenta
    {
        private string idCuenta;

        public Cuenta(string prmtIdCuenta)
        {
            this.idCuenta = prmtIdCuenta;
            Console.WriteLine("Constructor Clase Base para cuenta {0}", prmtIdCuenta);
        }

        public virtual void CalcularIntereses()
        {
            Console.WriteLine("Cuenta.CalcularIntereses() efectuado para la cuenta {0}", this.idCuenta);
        }

        public string GetIdCuenta()
        {
            return this.idCuenta;
        }
    }
}

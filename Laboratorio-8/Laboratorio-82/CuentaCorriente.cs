﻿using System;

namespace Laboratorio_82
{
    internal class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta)
        {
        }

        public override void CalcularIntereses()
        {
            Console.WriteLine("CuentaCorriente.CalcularIntereses() efectuado para la cuenta {0}", GetIdCuenta());
        }
    }
}

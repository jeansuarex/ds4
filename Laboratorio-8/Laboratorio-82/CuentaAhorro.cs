﻿using System;

namespace Laboratorio_82
{
    internal class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(string prmtIdCuenta) : base(prmtIdCuenta)
        {
        }

        public override void CalcularIntereses()
        {
            Console.WriteLine("CuentaAhorro.CalcularIntereses() efectuado para la cuenta {0}", GetIdCuenta());
        }
    }
}

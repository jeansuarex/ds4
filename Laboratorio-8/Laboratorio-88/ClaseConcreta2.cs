using Laboratorio_88;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_88
{
    internal class ClaseConcreta2 : ClaseAbstracta
    {
        protected override string tomarValor()
        {
            return "ClaseConcreta2";
        }
        public override string prefixValor(string prefix)
        {
            return $"{prefix}ClaseConcreta2";
        }
    }
}
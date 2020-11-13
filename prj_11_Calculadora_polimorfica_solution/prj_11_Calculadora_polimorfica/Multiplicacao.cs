using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_11_Calculadora_polimorfica
{
    class Multiplicacao:Operacao
    {
        public override double Calculo(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
    }
}

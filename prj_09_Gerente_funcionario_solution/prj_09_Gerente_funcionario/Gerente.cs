using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_09_Gerente_funcionario
{
    class Gerente:Funcionario
    {
        private decimal aBonus;

        public Gerente(string nome, decimal valor, double hora, decimal bonus):base(nome, valor, hora)
        {
            this.aBonus = bonus;
        }

        public decimal Bonus { get { return this.aBonus; } }

        public decimal Salario { get { return base.Salario + Bonus; } }
    }
}

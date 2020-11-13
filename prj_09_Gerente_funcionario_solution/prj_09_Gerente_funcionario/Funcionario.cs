using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_09_Gerente_funcionario
{
    class Funcionario
    {
        private string aNome;
        private decimal aValor;
        private double aHora;

        // Construtor
        public Funcionario(string nome, decimal valor, double hora)
        {
            this.aNome = nome;
            this.aValor = valor;
            this.aHora = hora;
        }

        //Propriedades
        public string Nome { get { return this.aNome; } }

        public decimal Valor { get { return this.aValor; } }

        public double Hora { get { return this.aHora; } }

        public decimal Salario { get { return Convert.ToDecimal(Hora) * Valor; } }
    }
}

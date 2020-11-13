using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_10_seguradora
{
    class Juridica:Fisica
    {
        public Juridica(string nome, string sexo, string rg, string pessoa):base(nome, sexo, rg, pessoa) { }

        public decimal Valor { get { return base.Valor * 0.85M; } }

        public decimal DescontoSeguro { get { return base.Valor - Valor; } }

    }
}

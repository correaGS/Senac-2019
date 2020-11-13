using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_10_seguradora
{
    class Fisica
    {
        private string aNome, aSexo, aRg, aPessoa;


        public Fisica(string nome, string sexo, string rg, string pessoa)
        {
            this.aNome = nome;
            this.aSexo = sexo;
            this.aRg = rg;
            this.aPessoa = pessoa;
        }

        public string Nome { get { return this.aNome; } }

        public string Sexo { get { return this.aSexo; } }

        public string Rg { get { return this.aRg; } }

        public string Pessoa { get { return this.aPessoa; } }

        public decimal Valor
        {
            get
            {
                if ((Sexo == "f") && (Pessoa == "f"))
                {
                    return 1000 * 0.94m;
                }
                else
                {
                    return 1000;
                }
            }
        }
    }
}

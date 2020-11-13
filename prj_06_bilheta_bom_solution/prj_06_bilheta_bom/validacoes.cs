using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_06_bilhete_bom
{
    class Validacoes
    {
        Recarga recarga = new Recarga();

        private string aOpcao;
        private int aOp;

        public int SetOp(int op)
        {
            return this.aOp = op;
        }

        public int GetOp()
        {
            return this.aOp;
        }

        public bool isOp()
        {
            return GetOp() != 1 && GetOp() != 0;
        }
        public bool Passe()
        {
            return recarga.Saldo() >= recarga.ValorPassagem();
        }

        public string SetOpcao(string opcao)
        {
            return this.aOpcao = opcao;
        }

        public string GetOpcao()
        {
            return this.aOpcao;
        }

        public bool isOpcao()
        {
            return GetOpcao() != "s" && GetOpcao() != "n";
        }

        public decimal MostraSaldo()
        {
            return recarga.NovoSaldo();
        }

      
    }
}

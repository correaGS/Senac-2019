using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_06_bilhete_bom
{
    class Recarga
    {
        //Validacoes valida = new Validacoes(); 

        private int aOp;
        private decimal aValorRecarga;

        public decimal SetRecarga(decimal recarga)
        {
            return this.aValorRecarga = recarga;
        }

        public decimal ValorPassagem()
        {
            return 4.80m;
        }

        public int SetOperacao(int op)
        {
            return this.aOp = op;
        }

        public int GetOperacao()
        {
            return this.aOp; 
        }

        public decimal Saldo()
        {
            return 2;
        }

        public decimal NovoSaldo()
        {
            decimal nValor = 0;

            switch(GetOperacao())
            {
                case 1:
                    nValor = Saldo() - ValorPassagem();
                    break;

                case 2:
                    nValor = Saldo() + GetRecarga();
                    break;
            }
            return nValor;

        }

        public decimal GetRecarga()
        {
            return this.aValorRecarga;
        }

        public void MsgSaldo()
        {
            Console.WriteLine("Saldo atual R$ " + NovoSaldo());
        }




    }
}

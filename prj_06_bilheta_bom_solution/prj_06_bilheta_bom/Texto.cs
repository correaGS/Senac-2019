using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_06_bilheta_bom
{
    class Texto
    {
        public void Inicio()
        {
            Console.Write("Encoste o cartão: ");
        }
        public void OperacaoInvalida()
        {
            Console.Write("Ação inválida. Selecione uma opção válida: ");
        }

        public void CatracaLiberada()
        {
            Console.WriteLine(".....Passe.....");
        }

        public void Saldoinsuficiente()
        {
            Console.WriteLine("Saldo Insuficiente!");
            Console.Write("Deseja efetuar uma recarga? (S) - Sim ou (N) - Não: ");
        }

        public void ValorRecarga()
        {
            Console.Write("Informe o valor de Recarga: R$ ");
        }

        public void RecargaEfetuada()
        {
            Console.WriteLine("Recarga efetuada com sucesso!");
        }

        public void Tchau()
        {
            Console.WriteLine("Infelizmente não podemos leva-lo ao seu " +
                                    "destino final.");
        }

        public void AcaoInvalida()
        {
            Console.WriteLine("Ação inválida");
        }
     
    }
}

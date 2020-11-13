using prj_06_bilheta_bom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_06_bilhete_bom
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Texto texto = new Texto();  
                texto.Inicio();
                int op = int.Parse(Console.ReadLine());

                Validacoes valida = new Validacoes();
                valida.SetOp(op);

                Recarga recarga = new Recarga();
                recarga.SetOperacao(op);

                while (valida.isOp())
                {
                    texto.OperacaoInvalida();
                    op = int.Parse(Console.ReadLine());
                    valida.SetOp(op);
                }

                switch (op)
                {
                    case 1:

                        if (valida.Passe())
                        {
                            texto.CatracaLiberada();
                            recarga.MsgSaldo();
                        }
                        else
                        {

                            texto.Saldoinsuficiente();
                            string opcao = (Console.ReadLine());

                            valida.SetOpcao(opcao);

                            while (valida.isOpcao())
                            {
                                texto.OperacaoInvalida();
                                opcao = Console.ReadLine();
                                valida.SetOpcao(opcao);
                            }

                            switch (valida.GetOpcao())
                            {
                                case "s":

                                    recarga.SetOperacao(2);

                                    texto.ValorRecarga();
                                    decimal valorRecarga = decimal.Parse(Console.ReadLine());

                                    recarga.SetRecarga(valorRecarga);

                                    texto.RecargaEfetuada();
                                    recarga.MsgSaldo();
                                    break;

                                case "n":

                                    texto.Tchau();
                                    break;
                            }
                        }
                        break;

                    case 0:
                        texto.Tchau();
                        break;

                }
            }
            catch (FormatException)
            {
               Texto texto = new Texto();

               texto.AcaoInvalida();
            }
        }
    }
}

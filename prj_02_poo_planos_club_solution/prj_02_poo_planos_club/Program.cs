using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_02_poo_planos_club
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // abaixo fica as instancia de classes 
                Validacao valida = new Validacao();
                Clube clube = new Clube();
                Banco banco = new Banco();

                string[] modalidade = new string[5];

                modalidade[0] = banco.Piscina();
                modalidade[1] = banco.Academia();
                modalidade[2] = banco.QuadraTenis();
                modalidade[3] = banco.QuadraFutebol();
                modalidade[4] = banco.Churrasqueira();

                int cont = 1;

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" {0} para {1}", cont, modalidade[i]);
                    cont++;
                }

                Console.Write(" Selecione a atividade que deseja praticar: ");
                int atividade = int.Parse(Console.ReadLine());

                valida.SetAtividade(atividade);

                while(valida.isAtividade())
                {
                    Console.Write(valida.MsgAtividade());
                    atividade = int.Parse(Console.ReadLine());

                    valida.SetAtividade(atividade);
                }

                atividade -= 1;

                Console.Write(" Informe seu plano: ");
                int plano = int.Parse(Console.ReadLine());

                valida.SetPlano(plano);

                while (valida.isPlano())
                {
                    Console.Write(valida.MsgPlano());
                    plano = int.Parse(Console.ReadLine());

                    valida.SetPlano(plano);
                }

                Console.Write(" Digite a quantidade de amigos que irá levar: ");
                int qtd = int.Parse(Console.ReadLine());

                clube.SetPlano(plano);
                clube.SetAtividade(atividade);
                clube.SetQtd(qtd);

                Console.WriteLine();
                Console.WriteLine(clube.GetMsg());
                Console.WriteLine();

                if(clube.GetBoasVindas())
                {
                    Console.WriteLine(clube.GetMsgQtd());
                }

            }
            catch(FormatException e)
            {
                Console.WriteLine(" Valor digitado não é um número. {0}", e);

            }
        }
    }
}

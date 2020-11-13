using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_07_plano_internet
{
    class Program
    {
        static void Main(string[] args)
        {
            Planos planos = new Planos();

            Console.WriteLine("Planos Disponíveis: ");
            Console.WriteLine(planos.PlanoB());
            Console.WriteLine(planos.PlanoM());
            Console.WriteLine(planos.PlanoP());

            Console.Write("Digite 'info' para mais informações ou 'op' para mais opções: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "info":


                    Console.WriteLine(planos.InfoB());
                    Console.WriteLine(planos.InfoM());
                    Console.WriteLine(planos.InfoP());

                    break;

                case "op":

                    string[] plano = new string[3];

                    plano[0] = planos.PlanoB();
                    plano[1] = planos.PlanoM();
                    plano[2] = planos.PlanoP();

                    int cont = 1;

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(" {0} para {1}", cont, plano[i]);
                        cont++;
                    }

                    break;
            }

        }
    }
}

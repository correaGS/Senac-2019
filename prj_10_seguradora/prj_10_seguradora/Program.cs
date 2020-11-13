using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_10_seguradora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Nome: ");
            string nome = Console.ReadLine();

            Console.Write(" RG: ");
            string rg = Console.ReadLine();

            Console.Write(" Sexo - M(masculino) ou F(feminino) - : ");
            string sexo = Console.ReadLine();

            Console.Write("Pessoa Jurídica(P) ou Fisíca(F): ");
            string pessoa = Console.ReadLine();


            if(pessoa == "f")
            {
                Fisica f = new Fisica(nome, sexo, rg, pessoa);

                Console.WriteLine(" {0} sua seguradora saira no valor de R$ {1}.", f.Nome, f.Valor);

            }
            else if(pessoa == "j")
            {
                Juridica j = new Juridica(nome, sexo, rg, pessoa);

                Console.WriteLine(" {0} sua seguradora saira no valor de R$ {1}, tendo" +
                    " um desconto de R$ {2}.", j.Nome, j.Valor, j.DescontoSeguro);
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }
}

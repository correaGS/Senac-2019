using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj14_revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();

            Console.Write("Informe o nome do produto: ");
            prod.Nome = Console.ReadLine();

            Console.Write("Informe a quantidade: ");
            prod.Qtd = int.Parse(Console.ReadLine());

            Console.Write("Informe o preço do produto: ");
            prod.Preco = decimal.Parse(Console.ReadLine());



            Console.WriteLine(prod);

            Console.WriteLine();

            string resp;
            do
            {
                Console.Write("Chegaram mais {0}? ", prod.Nome);
                resp = Console.ReadLine();

                if (resp == "s")
                {
                    Console.Write("Informe quatidade de {0} que chegaram: ", prod.Nome);
                    int novosProdutos = int.Parse(Console.ReadLine());

                    prod.NovosProdutos(novosProdutos);
                    Console.WriteLine(prod);
                }

                if(resp != "s" && resp != "n")
                {
                    Console.WriteLine("Resposta inválida! (S)-Sim ou (N)-Não");
                }

            } while (resp != "s" && resp != "n");

            Console.WriteLine();

            Console.Write("Informe quantos {0} foram vendidos: ", prod.Nome);
            int venda = int.Parse(Console.ReadLine());
            prod.VendaProduto(venda);

            Console.WriteLine(prod);
        }
    }
}

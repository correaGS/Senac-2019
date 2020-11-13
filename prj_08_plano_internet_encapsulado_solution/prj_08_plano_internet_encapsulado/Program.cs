using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_08_plano_internet_encapsulado
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Planos planos = new Planos();
                planos.ApresentacaoPlanos();
                
                planos.MaisInfornacoes();
                planos.ContratacaoPlano();

            }
            catch (FormatException)
            {
                Console.WriteLine("O campo pede para ser digitado um número!!");
            }
        }
    }
}

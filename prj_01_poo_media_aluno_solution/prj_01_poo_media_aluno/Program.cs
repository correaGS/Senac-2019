using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_01_poo_media_aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Validacao validacao = new Validacao();

                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a sua nota 1: ");
                double nota1 = double.Parse(Console.ReadLine());

                validacao.SetNota1(nota1);

                while(validacao.GetN1Valido())
                {
                    Console.Write("{0} não é um número válido para nota. Digite novamente: ", nota1);
                    nota1 = double.Parse(Console.ReadLine());
                    validacao.SetNota1(nota1);
                }

                Console.Write("Digite a sua nota 2: ");
                double nota2 = double.Parse(Console.ReadLine());

                validacao.SetNota2(nota2);

                while(validacao.GetN2Valido())
                {
                    Console.Write("{0} não é um número válido para nota. Digite novamente: ", nota2);
                    nota2 = double.Parse(Console.ReadLine());
                    validacao.SetNota2(nota2);
                }

                Console.Write("Digite a sua Frequência: ");
                double freq = double.Parse(Console.ReadLine());

                validacao.SetFreq(freq);

                while(validacao.GetFreqValido())
                {
                    Console.Write("{0} não é um número válido para frequência. Digite novamente: ", freq);
                    freq = double.Parse(Console.ReadLine());
                    validacao.SetFreq(freq);
                }

                // a linha abaixo cria uma instancia
                CalculaMedia cm = new CalculaMedia();

                cm.SetNome(nome);
                cm.SetNota1(nota1);
                cm.SetNota2(nota2);
                cm.SetFreq(freq);

                Console.WriteLine("Olá {0}. sua média é {1} e você está {2}!", cm.GetNome(), cm.GetMedia(), cm.GetStatus());
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado não é um número!");
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_11_Calculadora_polimorfica
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacao[] operacoes = new Operacao[]
            {
                new Soma(),
                new Subtracao(),
                new Multiplicacao(),
                new Divisao()
            };

            Console.Write("Valor 1: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.Write("Valor 2: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.Write("Operação: ");
            int opcao = int.Parse(Console.ReadLine());

            Operacao op = operacoes[opcao];

            double resultado = op.Calculo(valor1, valor2);

            Console.WriteLine("O resultado da sua operação é {}", resultado);
        }
    }
}

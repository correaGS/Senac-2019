using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_09_Gerente_funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Nome: ");
            string nome = Console.ReadLine();

            Console.Write(" Valor: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.Write(" Hora: ");
            double hora = double.Parse(Console.ReadLine());

            Console.Write(" Cargo: ");
            string cargo = Console.ReadLine();

            if(cargo == "f")
            {
                Funcionario f = new Funcionario(nome, valor, hora);

                Console.WriteLine(" {0} você trbalhou {1} horas no valor de R$ {2} e receberá R$ {3}",
                    f.Nome, f.Hora, f.Valor, f.Salario);
            }
            else if(cargo == "g")
            {
                Console.Write(" Bonus: ");
                decimal bonus = decimal.Parse(Console.ReadLine());

                Gerente g = new Gerente(nome, valor, hora, bonus);

                Console.WriteLine(" {0} você trbalhou {1} horas no valor de R$ {2} com o bonus de R$ {3} e você" +
                    " receberá R$ {4}", g.Nome, g.Hora, g.Valor, g.Bonus, g.Salario);
            }
            else
            {
                Console.WriteLine(" Cargo não existe!");
            }
        }
    }
}

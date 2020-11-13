using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj14_revisao
{
    class Produto
    {
        public string Nome { get; set; }
        public int Qtd { get; set; }
        public decimal Preco { get; set; }

        public void NovosProdutos(int novosProdutos)
        {
            Qtd += novosProdutos;
        }

        public void VendaProduto(int venda)
        {
            Qtd -= venda;
        }

        public override string ToString()
        {
            return string.Format("{0} tem em estoque {1} no valor unitário de R$ {2}" +
                ", totalizando R$ {3}", Nome, Qtd, Preco, Preco*Qtd);
        }
    }
}

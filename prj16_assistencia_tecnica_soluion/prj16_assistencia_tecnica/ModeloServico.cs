using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj16_assistencia_tecnica
{
    class ModeloServico
    {
        private string problema;
        private int valor;
        private int equipamento;
        private int cliente;
        private int os;

        public int OS
        {
            get { return this.os; }
            set { this.os = value; }
        }
        public int Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
        public int Equipamento
        {
            get { return this.equipamento; }
            set { this.equipamento = value; }
        }
        public string Problema
        {
            get { return this.problema; }
            set { this.problema = value; }
        }
        public int Valor
        {
            get { return this.valor; }
            set { this.valor = value; }
        }
    }
}
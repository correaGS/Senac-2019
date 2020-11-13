using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj16_assistencia_tecnica
{
    class ModeloCliente
    {
        private string nome;
        private String email;
        private string contato;
        private int idCliente;

        public int IdCliente
        {
            get { return this.idCliente; }
            set { this.idCliente = value; }
        }
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public string Contato
        {
            get { return this.contato; }
            set { this.contato = value; }
        }
        public String Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
    }
}

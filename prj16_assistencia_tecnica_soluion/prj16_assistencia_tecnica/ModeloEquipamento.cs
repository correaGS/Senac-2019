using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj16_assistencia_tecnica
{
    class ModeloEquipamento
    {
        private string aparelho;
        private int modelo;
        private int idEquipamento;

        public int IdEquipamento
        {
            get { return this.idEquipamento; }
            set { this.idEquipamento = value; }
        }
        public int Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }
        public string Aparelho
        {
            get { return this.aparelho; }
            set { this.aparelho = value; }
        }
    }
}

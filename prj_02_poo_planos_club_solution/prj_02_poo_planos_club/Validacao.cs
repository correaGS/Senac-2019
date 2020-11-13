using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_02_poo_planos_club
{
    class Validacao
    {
        private int aPlano, aAtividade, aQtd;

        public int SetPlano(int plano)
        {
            return this.aPlano = plano;
        }

        public int SetAtividade(int atividade)
        {
            return this.aAtividade = atividade;
        }

        public int GetAtividade()
        {
            return this.aAtividade;
        }

        public int GetPlano()
        {
            return this.aPlano;
        }

        public bool isAtividade()
        {
            return GetAtividade() > 5 || GetAtividade() < 1;
        }

        public string MsgAtividade()
        {
            return "Atvidade inválida, selecione uma atividade da lista: ";
        }

        public bool isPlano()
        {
            return GetPlano() > 3 || GetPlano() < 1;
        }

        public string MsgPlano()
        {
            return "Plano inválido, selecione um plano válido: ";
        }

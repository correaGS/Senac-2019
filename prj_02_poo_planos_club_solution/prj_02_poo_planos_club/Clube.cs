using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_02_poo_planos_club
{
    class Clube
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
        public int SetQtd(int qtd)
        {
            return this.aQtd = qtd;
        }


        public int GetAtividade()
        {
            return this.aAtividade;
        }

        public int GetPlano()
        {
            return this.aPlano;
        }

        public int GetQtd()
        {
            return this.aQtd;
        }

        public string GetMsg()
        {
            string msg;

            if(GetAtividade() == 1 && GetPlano() != 1)
            {
                msg = "Acesso Negado. Atividade exclusiva no plano 1!";
            }
            else if(GetAtividade() == 0 && (GetPlano() != 1 && GetPlano() != 2))
            {
                msg = "Acesso Negado. Atividade exclusiva no plano 1 e 2!";
            }
            else
            {
                msg = "Acesso permitido"; 
            }

            return msg;
        }

        public string GetMsgQtd()
        {
            string msg;

            if(GetPlano() == 1 && GetQtd() > 10)
            {
                msg = "O plano 1 só permite até 10 amigos!";
            }
            else if(GetPlano() == 2 && GetQtd() > 7)
            {
                msg = "O plano 2 só permite até 7 amigos!";
            }
            else if(GetPlano() == 3 && GetQtd() > 4)
            {
                msg = "O plano 3 só permite até 4 amigos!";
            }
            else
            {
                msg = "Seja bem-vindo!!";
            }

            return msg;
        }

        public bool GetBoasVindas()
        {
            return GetMsg() == "Acesso Permitido" || GetMsgQtd() == "Seja bem-vindo!!";
        }
        
    }
}

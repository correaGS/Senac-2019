using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_07_plano_internet
{
    class Planos
    {
        public decimal ValorBasico()
        {
            return 39.90m;
        }

        public string PlanoB()
        {
            return "Plano Básico";
        }
        public string InfoB()
        {
            return "O Plano Básico contem internet e custa R$ " + ValorBasico();
        }

        public decimal ValorMedio()
        {
            return 59.90m;
        }

        public string PlanoM()
        {
            return "Plano Médio";
        }

        public string InfoM()
        {
            return "O Plano Médio contem internet, telefone e custa R$ " + ValorMedio();
        }

        public decimal ValorPremium()
        {
            return 99.90m;
        }

        public string PlanoP()
        {
            return "Plano Premium";
        }

        public string InfoP()
        {
            return "O Plano Premium contem internet, telefone, tv e custa R$ " + ValorPremium();
        }
    }
}

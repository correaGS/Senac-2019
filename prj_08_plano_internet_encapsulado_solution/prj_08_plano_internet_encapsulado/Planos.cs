using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_08_plano_internet_encapsulado
{
    class Planos
    {
        //a variavel abaixo como não foi identificada se torna privada
        //por regra de segurança c#.
        string maisInfo, contratoPlano, codPromocao, tenho;
        int codPlanoDesejado;
        const string simNao = "(S) - Sim ou (N) - Não: ";
        string[] tipoPlano = new string[3];
        decimal[] valorPlano = new decimal[3];
        const string msgInvalidaCod = "Código inválido! Selecione um código válido: ";
        const string msgInvalidaSimNao = "Você só pode digitar" + simNao + ". Digite novamnete: ";


        //Sequência de métodos VOID.
        public void ApresentacaoPlanos()
        {
            tipoPlano[0] = "Plano Básico";
            valorPlano[0] = 39.90m;

            tipoPlano[1] = "Plano Plus";
            valorPlano[1] = 59.90m;

            tipoPlano[2] = "Plano Premium";
            valorPlano[2] = 99.90m;

            int cont = 1;

            for (int i = 0; i < tipoPlano.Length; i++)
            {
                Console.WriteLine("{0} - {1} no valor de R$ {2}", cont, tipoPlano[i], valorPlano[i]);
                cont++;
            }

            Console.Write("Deseja mais informações do plano? {0}", simNao);
            maisInfo = Console.ReadLine();

            while (isSimNaoInfo())
            {
                Console.Write(msgInvalidaSimNao);
                maisInfo = Console.ReadLine();
            }
        }

        public void MaisInfornacoes()
        {
            if (maisInfo == "s")
            {
                Console.Write("Informe o plano que deseja mais informações: ");
                codPlanoDesejado = int.Parse(Console.ReadLine());

                while (isCodigoValido())
                {
                    Console.Write(msgInvalidaCod);
                    codPlanoDesejado = int.Parse(Console.ReadLine());
                }

                InformacoesSolicitadas();
            }

        }

        public void InformacoesSolicitadas()
        {
            string infoSolicitada = "";

            switch (GetCodPlanoDesejado())
            {
                case 1:
                    infoSolicitada = PlanosBasico();
                    break;

                case 2:
                    infoSolicitada = PlanosPlus();
                    break;

                case 3:
                    infoSolicitada = PlanosPremium();
                    break;
            }

            Console.WriteLine(infoSolicitada);
        }

        public void ContratacaoPlano()
        {
            Console.Write("Deseja contratar algum plano? {0}", simNao);
            contratoPlano = Console.ReadLine();

            while (isSimNaoContratoPlano())
            {
                Console.Write(msgInvalidaSimNao);
                contratoPlano = Console.ReadLine();
            }

            if (isVaiContratar())
            {
                Console.Write("Informe o plano que deseja contratar: ");
                codPlanoDesejado = int.Parse(Console.ReadLine());

                while (isCodigoValido())
                {
                    Console.Write(msgInvalidaCod);
                    codPlanoDesejado = int.Parse(Console.ReadLine());
                }

                int planoComprado = GetCodPlanoDesejado() - 1;

                Console.Write("Você possui algum código promocional? {0}", simNao);
                tenho = Console.ReadLine();

                while (isTenho())
                {
                    Console.Write(msgInvalidaSimNao);
                    tenho = Console.ReadLine();
                }

                if (Tenho() == "s")
                {
                    Console.Write("Informe o código: ");
                    codPromocao = Console.ReadLine();
                }

                Console.WriteLine("");
                Console.WriteLine("Você está contratando o {0}.", tipoPlano[planoComprado]);
                Console.WriteLine("{0} no valor de R$ {1} mensais.", InformacoesPlanoDesejado(), ValorMensal(planoComprado));


            }
        }

        //Sequência de metodos GET.

        public string Tenho()
        {
            return this.tenho;
        }

        public string CodPromocao()
        {
            return this.codPromocao;
        }

        public string GetContratoPlano()
        {
            return this.contratoPlano;
        }

        public string GetMaisInfo()
        {
            return this.maisInfo;
        }

        public int GetCodPlanoDesejado()
        {
            return this.codPlanoDesejado;
        }

        //Sequência de métodos SET.

        public string SetMaisInfo(string info)
        {
            return this.maisInfo = info;
        }

        //Sequência de métodos COM AS DESCRIÇÕES.

        public string PlanosBasico()
        {
            return "O Plano Básico oferece apenas o serviço de internet.";
        }

        public string PlanosPlus()
        {
            return "O Plano Plus oferece os serviços de internet e telefone.";
        }

        public string PlanosPremium()
        {
            return "O Plano Premium oferece os serviços de internet, telefone e Tv.";
        }

        public string InformacoesPlanoDesejado()
        {
            string seuplano = "";

            switch (GetCodPlanoDesejado())
            {
                case 1:
                    seuplano = PlanosBasico();
                    break;

                case 2:
                    seuplano = PlanosPlus();
                    break;

                case 3:
                    seuplano = PlanosPremium();
                    break;

                default:
                    seuplano = "Informe o plano correto!";
                    break;
            }

            return seuplano;
        }

        public decimal ValorMensal(int planoComprado)
        {
            decimal valorPagar = valorPlano[planoComprado];

            if (isTemMesmo())
            {
                valorPagar = (valorPlano[planoComprado] * 0.75M);
            }

            return valorPagar;
        }

        //Sequência de métodos COM VALIDAÇÕES

        public bool isSimNaoInfo()
        {
            return maisInfo != "s" && maisInfo != "n";
        }

        public bool isCodigoValido()
        {
            return GetCodPlanoDesejado() < 1 || GetCodPlanoDesejado() > 3;
        }

        public bool isSimNaoContratoPlano()
        {
            return GetContratoPlano() != "s" && GetContratoPlano() != "n";
        }

        public bool isTenho()
        {
            return Tenho() != "s" && Tenho() != "n";
        }

        public bool isTemMesmo()
        {
            return (CodPromocao() == "A32") || (CodPromocao() == "B51")
                 || (CodPromocao() == "C75") || (CodPromocao() == "D93");
        }

        public bool isVaiContratar()
        {
            return (GetContratoPlano() == "s");
        }
    }
}

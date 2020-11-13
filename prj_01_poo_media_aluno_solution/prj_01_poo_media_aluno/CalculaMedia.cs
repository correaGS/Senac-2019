using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_01_poo_media_aluno
{
    class CalculaMedia
    {
        // abaixo ficam os atributos
        private string aNome;
        private double aN1, aN2, aFreq;

        // sequencia de métodos
        public string SetNome(string n)
        {
            return this.aNome = n;
        }

        public double SetNota1(double nota1)
        {
            return this.aN1 = nota1;
        }

        public double SetNota2(double nota2)
        {
            return this.aN2 = nota2;
        }

        public double SetFreq(double freq)
        {
            return this.aFreq = freq;
        }

        public string GetNome()
        {
            return this.aNome;
        }

        public double GetNota1()
        {
            return this.aN1;
        }

        public double GetNota2()
        {
            return this.aN2;
        }

        public double GetMedia()
        {
            return (GetNota1() + GetNota2()) / 2;
        }

        public string GetStatus()
        {
            string status;
            if (Aprovado())
            {
                status = "Aprovado";
            }
            else
            {
                status = "Reprovado";
            }

            return status;

        }
        public double GetFreq()
        {
            return this.aFreq;
        }

        public bool Aprovado()
        {
            return GetMedia() >= 6 && GetFreq() >= 75;
        }
    }
}

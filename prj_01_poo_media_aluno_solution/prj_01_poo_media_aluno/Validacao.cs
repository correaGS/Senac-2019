using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_01_poo_media_aluno
{
    class Validacao
    {
        private double aN1, aN2, aFreq;

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

        public double GetNota1()
        {
            return this.aN1;
        }
        public double GetNota2()
        {
            return this.aN2;
        }
        public double GetFreq()
        {
            return this.aFreq;
        }

        public bool GetN1Valido()
        {
            return GetNota1() < 0 || GetNota1() > 10;
        }

        public bool GetN2Valido()
        {
            return GetNota2() < 0 || GetNota2() > 10;
        }

        public bool GetFreqValido()
        {
            return GetFreq() < 0 || GetFreq() > 100;
        }
    }
}

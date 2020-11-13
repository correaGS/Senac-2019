using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaSenac
{
    class Conexao
    {
        public static string conector()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gabriel.scorrea4\source\repos\lojaSenac_solution\lojaSenac\dbSistemaSenac.mdf;Integrated Security=True";
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEV.Classes
{
    public class CConexao
    {
        public static string Get_StringConexao()
        {
            string Host = "localhost";
            // string Banco = "pev";
            string Banco = "ecce";
            string Usuario = "root";
            string Senha = "";
            return "Data Source = " + Host + "; Initial Catalog = " + Banco + "; User Id = " + Usuario + "; Password = " + Senha + "; ";
        }
    }
}

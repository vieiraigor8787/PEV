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
            //string Host = "mysql5035.site4now.net";
            //string Banco = "db_a787ec_pev";
            //string Usuario = "a787ec_pev";
            //string Senha = "escolha1234";

            //string Host = "localhost";
            //string Banco = "pev";
            //string Usuario = "root";
            //string Senha = "1234";

            string Host = "pev.mysql.uhserver.com";
            string Banco = "pev";
            string Usuario = "pevdb";
            string Senha = "!ev4.0";

            return "Data Source = " + Host + "; Initial Catalog = " + Banco + "; User Id = " + Usuario + "; Password = " + Senha + "; ";
        }
    }
}

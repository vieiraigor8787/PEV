﻿using System;
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
            string Banco = "pev";
            string Usuario = "root";
            string Senha = "1234";
            return "Data Source = " + Host + "; Initial Catalog = " + Banco + "; User Id = " + Usuario + "; Password = " + Senha + "; ";
        }
    }
}

using PEV.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEV.Classes;
using Newtonsoft.Json;

namespace PEV.Data
{
    public class LogoDB
    {
        public bool InserirLogo(string logo)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                cmd.Connection = cn;
                sSQL = "TRUNCATE TABLE tb_logomarca; insert into  tb_logomarca (Nome)values(@Nome)";
                cmd.Parameters.AddWithValue("@Nome", logo);
                cmd.CommandText = sSQL;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }

        public List<tb_logomarca> LogoMarca()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_logomarca";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_logomarca>();

                while (Dr.Read())
                {
                    var item = new tb_logomarca
                    {
                        Nome = Dr["Nome"].ToString()
                    };
                    Lista.Add(item);
                }

                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                var Lista = new List<tb_logomarca>();
                var item = new tb_logomarca
                {
                    Nome = "sua_logo_aqui_b83d.jpg"
                };
                Lista.Add(item);
                return Lista;
            }
        }
    }


}


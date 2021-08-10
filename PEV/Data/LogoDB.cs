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
        public bool InserirLogo(LogomarcaModel obj)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    Culture = new System.Globalization.CultureInfo("pt-BR")
                };

                obj.JsonLTLogomarca = obj.JsonLTLogomarca.Replace("Descricao", "Caminho");

                var prodFotos = JsonConvert.DeserializeObject<LogomarcaModel>(obj.JsonLTLogomarca, settings);

                cmd.Connection = cn;
                sSQL = "insert into  tb_logomarca (Caminho)values(@Caminho)";
                cmd.Parameters.AddWithValue("@Caminho", prodFotos.Caminho);
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

        public bool UpDateDados(tb_genero obj)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "update tb_genero set descricao=@descricao where codigogenero=@codigogenero";
                    cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                    cmd.Parameters.AddWithValue("@codigogenero", obj.CodigoGenero);

                    cmd.CommandText = sSQL;
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception e)
                {
                    string msg = e.Message;
                    return false;
                }
            }

        }

        public bool ExcluirDados(int Codigo)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "delete from tb_genero  where codigogenero=@codigogenero";
                    cmd.Parameters.AddWithValue("@codigogenero", Codigo);

                    cmd.CommandText = sSQL;
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception e)
                {
                    string msg = e.Message;
                    return false;
                }
            }
        }
    }


}


using PEV.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEV.Classes;

namespace PEV.Data
{
    public class FreteDB
    {
        public bool InserirDados(tb_frete_dados obj)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "insert into tb_frete_dados (CEP) values (@CEP)";
                cmd.Parameters.AddWithValue("@CEP", obj.CEP);

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

        public bool UpDateDados(tb_frete_dados obj)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "update tb_frete_dados set CEP=@CEP  where IdFrete=@IdFrete";
                    cmd.Parameters.AddWithValue("@Email", obj.CEP);

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

                    sSQL = "delete from tb_frete_dados  where IdFrete=@IdFrete";
                    cmd.Parameters.AddWithValue("@IdFrete", Codigo);

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

        public List<tb_frete_dados> ListaFreteDados()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_frete_dados";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_frete_dados>();

                while (Dr.Read())
                {
                    var item = new tb_frete_dados
                    {
                        IdFrete = Convert.ToInt32(Dr["IdFrete"]),
                        CEP = Dr["CEP"].ToString(),
                    };
                    Lista.Add(item);
                }

                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public tb_frete_dados FreteDados()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_frete_dados";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();
                Dr.Read();

                var Dados = new tb_frete_dados()
                {
                    IdFrete = Convert.ToInt32(Dr["IdFrete"]),
                    CEP = Dr["CEP"].ToString()
                };

                var model = new tb_frete_dados();
                model.IdFrete = Convert.ToInt32(Dados.IdFrete);
                model.CEP = Dados.CEP;

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                var model = new tb_frete_dados();
                model.IdFrete = 00000;
                model.CEP = "000000000";

                return model;
            }
        }
    }
}


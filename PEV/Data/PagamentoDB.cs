using PEV.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEV.Classes;

namespace PEV.Data
{
    public class PagamentoDB
    {
        public bool InserirDados(tb_pagamento_dados obj)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "TRUNCATE TABLE tb_pagamento_dados; insert into tb_pagamento_dados (Email, Token) values (@Email, @Token)";
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                cmd.Parameters.AddWithValue("@Token", obj.Token);

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

        public bool UpDateDados(tb_pagamento_dados obj)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "update tb_pagamento_dados set Email=@Email, Token=@Token  where IdPagamento=@IdPagamento";
                    cmd.Parameters.AddWithValue("@Email", obj.Email);
                    cmd.Parameters.AddWithValue("@Token", obj.Token);
                    cmd.Parameters.AddWithValue("@IdPagamento", obj.IdPagamento);

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

                    sSQL = "delete from tb_pagamento_dados  where IdPagamento=@IdPagamento";
                    cmd.Parameters.AddWithValue("@IdPagamento", Codigo);

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

        public List<tb_pagamento_dados> ListaPagamentoDados()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_pagamento_dados";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_pagamento_dados>();

                while (Dr.Read())
                {
                    var item = new tb_pagamento_dados
                    {
                        IdPagamento = Convert.ToInt32(Dr["IdPagamento"]),
                        Email = Dr["Email"].ToString(),
                        Token = Dr["Token"].ToString()
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

        public tb_pagamento_dados PagamentoDados()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_pagamento_dados";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();
                Dr.Read();

                var Dados = new tb_pagamento_dados()
                {
                    IdPagamento = Convert.ToInt32(Dr["IdPagamento"]),
                    Email = Dr["Email"].ToString(),
                    Token = Dr["Token"].ToString()
                };

                var model = new tb_pagamento_dados();
                model.IdPagamento = Convert.ToInt32(Dados.IdPagamento);
                model.Email = Dados.Email;
                model.Token = Dados.Token;

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                var model = new tb_pagamento_dados();
                model.IdPagamento = 00000;
                model.Email = "sem dados";
                model.Token = "Cadastre os dados";

                return model;
            }
        }
    }
}


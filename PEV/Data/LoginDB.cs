using PEV.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEV.Classes;

namespace PEV.Data
{
    public class LoginDB
    {

        public bool RedefineSenhaPasso1(string Email, string CPF)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "SELECT * FROM tb_login WHERE Email='" + Email + "' AND CPF_CNPJ='" + CPF + "'";

                    cmd.CommandText = sSQL;
                    cmd.Connection = cn;
                    var Dr = cmd.ExecuteReader();
                    return Dr.HasRows;
                }
                catch (Exception e)
                {
                    string msg = e.Message;
                    return false;
                }
            }
        }


        //Retorna o CodigoLogin do usuário que quer recuperar a senha
        public tb_login CodigoLoginRecuperaSenha(string Email, string CPF)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT CodigoLogin FROM tb_login WHERE Email='" + Email + "' AND CPF_CNPJ='" + CPF + "'";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrUsuario = cmd.ExecuteReader();

                DrUsuario.Read();

                var usuario = new tb_login()
                {
                   CodigoLogin  = Convert.ToInt32(DrUsuario["CodigoLogin"])
                };

                var model = new tb_login();
                model.CodigoLogin = Convert.ToInt32(usuario.CodigoLogin);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }
    }
}


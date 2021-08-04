using MySql.Data.MySqlClient;
using PEV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PEV.Classes
{
    public class EnviarEmail
    {
        public bool Enviar(string Email, string Msg, string Titulo)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("escolhavirtual4.0@gmail.com");
                message.To.Add(new MailAddress(Email));
                message.Subject = Titulo;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = Msg;
                //message.IsBodyHtml = true;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("escolhavirtual4.0@gmail.com", "plataforma");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public tb_venda EmailPedido(int CodVenda)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();


                sSQL = "SELECT v.CodigoVenda, v.CodigoLogin, v.`Status`, l.Email FROM tb_venda AS v " +
                       "INNER JOIN tb_login AS l ON v.CodigoLogin = l.CodigoLogin WHERE v.CodigoVenda=" + CodVenda;

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var eEmail = new tb_venda
                {
                    Email = DrVenda["Email"].ToString(),
                    Status = DrVenda["Status"].ToString()
                };

                var model = new tb_venda();
                model.Email = eEmail.Email.ToString();
                model.Status = eEmail.Status.ToString();

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                var model = new tb_venda();
                model.Email = "Sem Registros!";
                return model;
            }
        }


    }

}

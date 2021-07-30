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

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace AlquilerCochesWeb
{
    public partial class EnviarMail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string listaCorreos = "adrims1986@gmail.com";
            string correoEnvio = "rentacarcontacto@gmail.com";
            string contraseña = "123456=abc";


            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(correoEnvio);
            mail.To.Add(listaCorreos);
            mail.Body = Page.Request.Form["Nombre"].ToString();
            SmtpClient server = new SmtpClient("smtp.gmail.com");
            server.Port = 25;
            server.EnableSsl = true;
            server.Credentials = new NetworkCredential(correoEnvio, contraseña);
            server.Send(mail);
            
            
        }
    }
}
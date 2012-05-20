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
           // string listaCorreos = "adrims1986@gmail.com"; //donde ira el mensaje
            string listaCorreos = "adrims1986@gmail.com,dsarabia.m@gmail.com,javiumbe@gmail.com,jorgedgm11@gmail.com,angelcastejon2@gmail.com"; //donde ira el mensaje
            string correoEnvio = "rentacarcontacto@gmail.com";//esta es la cuenta que nos enviara el mensaje
            string contraseña = "123456=abc";

            if (Session["MailUser"] != null)
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(correoEnvio);
                mail.To.Add(Session["MailUser"].ToString());
                mail.Subject = Session["MailUserSubject"].ToString();
                //mail.Body = Page.Request.Form["Nombre"].ToString();
                mail.Body = Session["MailUserBody"].ToString();
                SmtpClient server = new SmtpClient(); //servidor gmail
                server.Host = "smtp.gmail.com";
                server.Port = 25;
                server.EnableSsl = true;
                server.Credentials = new NetworkCredential(correoEnvio, contraseña);
                server.Send(mail);
                Session["MailUser"] = null;
                Session["MailUserSubject"] = null;
                Session["MailUserBody"] = null;
            }
            if (Session["MailSubject"] != null)
            {
                MailMessage mail2 = new MailMessage();
                mail2.From = new MailAddress(correoEnvio);
                mail2.To.Add(listaCorreos);
                mail2.Subject = Session["MailSubject"].ToString();
                //mail.Body = Page.Request.Form["Nombre"].ToString();
                mail2.Body = Session["MailBody"].ToString();
                SmtpClient server = new SmtpClient(); //servidor gmail
                server.Host = "smtp.gmail.com";
                server.Port = 25;
                server.EnableSsl = true;
                server.Credentials = new NetworkCredential(correoEnvio, contraseña);
                server.Send(mail2);
                Session["MailSubject"] = null;
                Session["MailBody"] = null;
            }

            Response.Redirect(Session["MailUrl"].ToString());
        }
    }
}
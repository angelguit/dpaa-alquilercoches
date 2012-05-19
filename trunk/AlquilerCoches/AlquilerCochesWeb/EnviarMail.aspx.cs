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
        { //ATENCION ESTA PAGINA NO SE USA!!!! ESTOY HACIENDO EL ENVIO DE CORREOS DIRECTAMENTE EN LA PAGINA DE SITUACION
           
           // string listaCorreos = "adrims1986@gmail.com"; //donde ira el mensaje
            string listaCorreos = "dsarabia.m@gmail.com"; //donde ira el mensaje
            string correoEnvio = "rentacarcontacto@gmail.com";//esta es la cuenta que nos enviara el mensaje
            string contraseña = "123456=abc";
           

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(correoEnvio);
            mail.To.Add(listaCorreos);
            mail.Subject = "Prueba mail" + Session["MensajeNombre"].ToString() ;
            //mail.Body = Page.Request.Form["Nombre"].ToString();
            mail.Body = "probando aplicacion de correo"+Session["MensajeEmail"].ToString();
            SmtpClient server = new SmtpClient(); //servidor gmail
            server.Host = "smtp.gmail.com";
            server.Port = 25;
            server.EnableSsl = true;
            server.Credentials = new NetworkCredential(correoEnvio, contraseña);
            server.Send(mail);
            Server.Transfer("Situacion.aspx");
          
            
        }
    }
}
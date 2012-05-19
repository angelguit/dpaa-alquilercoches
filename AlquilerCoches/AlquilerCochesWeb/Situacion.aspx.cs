using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using EN;
using System.Net.Mail;
using System.Net;

namespace AlquilerCochesWeb
{
    public partial class Situacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Server.Transfer("EnviarMail.aspx");
            LabelError.Visible = false;
            LabelCorrecto.Visible = false;
        }

        protected void CustomValidatorNombre_ServerValidate(object source, ServerValidateEventArgs args)
        { 
            string username = args.Value.ToLower();

            if (TTextBoxNombre.Text != "")
            {
                if (!Regex.Match(username, @"^[A-Za-zñÑáéíóúÁÉÍÓÚçÇ\s]{3,30}$").Success)
                {
                    args.IsValid = false;
                }
                else { args.IsValid = true; }
            }
            else { args.IsValid = false;}
            
        }
        protected void CustomValidatorApellidos_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string username = args.Value.ToLower();

            if (!Regex.Match(username, @"^[A-Za-zñÑáéíóúÁÉÍÓÚçÇ\s]{3,30}$").Success)
            {
                args.IsValid = false;
            }
            else { args.IsValid = true; }
        }

        protected void CustomValidatorEmail_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string username = args.Value.ToLower();

            if (!Regex.Match(username, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                args.IsValid = false;
            }
            else { args.IsValid = true; }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TTextBoxNombre.Text == "" || TTextBoxEmail.Text == "" || TTextBoxApellidos.Text == "" || TTextArea.Value == "")
            {
                LabelError.Visible = true;
                LabelCorrecto.Visible = false;
            }
            else
            {
                LabelError.Visible = false;
                LabelCorrecto.Visible = true;
                if (Page.IsValid)
                {

                    string listaCorreos = "dsarabia.m@gmail.com"; //donde ira el mensaje
                    // string listaCorreos2 = "rentacarcontacto@gmail.com"; //donde ira el mensaje
                    string correoEnvio = "rentacarcontacto@gmail.com";//esta es la cuenta que nos enviara el mensaje
                    string contraseña = "123456=abc";


                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(correoEnvio);
                    mail.To.Add(listaCorreos);
                    // mail.To.Add(listaCorreos2);
                    mail.Subject = "Consulta de: " + TTextBoxEmail.Text.ToString();
                    //mail.Body = Page.Request.Form["Nombre"].ToString();
                    mail.Body = "Nombre y apellidos: " + TTextBoxNombre.Text.ToString() + " " + TTextBoxApellidos.Text.ToString()+ "\n\n"+ TTextArea.Value.ToString();
                    SmtpClient server = new SmtpClient(); //servidor gmail
                    server.Host = "smtp.gmail.com";
                    server.Port = 25;
                    server.EnableSsl = true;
                    server.Credentials = new NetworkCredential(correoEnvio, contraseña);
                    server.Send(mail);

                    /* Button1.Text = Page.IsValid.ToString();*/
                    TTextBoxNombre.Text = "";
                    TTextBoxApellidos.Text = "";
                    TTextBoxEmail.Text = "";
                    TTextArea.Value = "";

                }
                else
                { Button1.Text = "Incorrecto"; }
            }

           

            
        }

        protected void TTextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            LabelCorrecto.Visible = false;
        }

    }
}
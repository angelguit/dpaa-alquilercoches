using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using EN;

namespace AlquilerCochesWeb
{
    public partial class Situacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
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
            if (Page.IsValid)
            { Button1.Text = Page.IsValid.ToString();
            TTextBoxNombre.Text = "";
            TTextBoxApellidos.Text = "";
            TTextBoxEmail.Text = "";
            TTextArea.Value = "";

            EN.ENCliente cli = new ENCliente();
            DataSet dscli = new DataSet();
            dscli = cli.ObtenerDatosClienteConDni("11111111A");

            TTextBoxNombre.Text = dscli.Tables["Cliente"].Rows[0][1].ToString();
            }
            else
            { Button1.Text = "Incorrecto"; }
        }

    }
}
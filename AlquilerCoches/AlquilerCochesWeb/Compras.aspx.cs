using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace AlquilerCochesWeb
{
    public partial class Compras : System.Web.UI.Page
    {
        private EN.ENVentas ventas = new EN.ENVentas();

        protected void Page_Load(object sender, EventArgs e)
        {
            switch (ComprasMultiView.ActiveViewIndex)
            {
                case 0:
                    ComprasListView.DataSource = ventas.ObtenerVentasCategoria(1);
                    ComprasListView.DataBind();
                    break;
                case 1:
                    ListView1.DataSource = ventas.ObtenerVentasCategoria(2);
                    ListView1.DataBind();
                    break;
                case 2:
                    ListView2.DataSource = ventas.ObtenerVentasCategoria(3);
                    ListView2.DataBind();
                    break;
                case 3:
                    ListView3.DataSource = ventas.ObtenerVentasCategoria(4);
                    ListView3.DataBind();
                    break;
            }
        }

        protected void ComprasMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "Turismos":
                    ComprasMultiView.ActiveViewIndex = 0;
                    break;
                case "Familiares":
                    ComprasMultiView.ActiveViewIndex = 1;
                    break;
                case "Furgonetas":
                    ComprasMultiView.ActiveViewIndex = 2;
                    break;
                case "Especiales":
                    ComprasMultiView.ActiveViewIndex = 3;
                    break;

            }
            Page_Load(null, null);
        }

        protected void ComprasListView_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            ventas.Matricula = e.CommandArgument.ToString();
            ventas.ObtenerDatosVehiculos();
            ventas.Reservado = 1;
            ventas.EditarVentas();
            ComprasMultiView.ActiveViewIndex = 0;

            /*/Session["MailSubject"] = "Consulta de: " + 
            Session["MailBody"] = "Nombre y apellidos: " + TTextBoxNombre.Text.ToString() + " " + TTextBoxApellidos.Text.ToString() + "\n\n Consulta: \n" + TTextArea.Value.ToString();
            Session["MailUser"] = TTextBoxEmail.Text.ToString();
            Session["MailUserSubject"] = "Tu consulta ha sido enviada con éxito";
            Session["MailUserBody"] = "Esta ha sido tu consulta: \n Nombre y apellidos: " + TTextBoxNombre.Text.ToString() + " " + TTextBoxApellidos.Text.ToString() + "\n\n Consulta: \n" + TTextArea.Value.ToString();
            Session["MailUrl"] = HttpContext.Current.Request.Url.ToString();
            Response.Redirect("EnviarMail.aspx");*/

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
    }
}
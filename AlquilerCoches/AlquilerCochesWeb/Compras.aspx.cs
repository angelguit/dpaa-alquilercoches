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
            if (Session["Usuario"] == null)
            {
                Server.Transfer("ReservaNoRegistrado.aspx");
            }
            else
            {                
                ventas.Matricula = e.CommandArgument.ToString();
                ventas.ObtenerDatosVehiculos();
                ventas.Reservado = 1;
                ventas.EditarVentas();
                ComprasMultiView.ActiveViewIndex = 0;

                Session["MailSubject"] = "Reserva de compra de: " + Session["email"].ToString();
                Session["MailBody"] = "Nombre y apellidos: " + Session["nombre"].ToString() + " " + Session["apellidos"].ToString() 
                    + "\n\n Este cliente ha realizado una reserva del coche: \n Matrícula: " + ventas.Matricula + "\n Modelo: " + ventas.Marca + " " + ventas.Modelo
                    + "\n KM: " + ventas.KM.ToString() + "\n Precio: " + ventas.PrecioVenta + "\n Garantía: " + ventas.Garantia; 
                Session["MailUser"] = Session["email"].ToString();
                Session["MailUserSubject"] = "La reserva se ha realizado con éxito.";
                Session["MailUserBody"] = "Has realizado una reserva del coche: \n Matrícula: " + ventas.Matricula + "\n Modelo: " + ventas.Marca + " " + ventas.Modelo
                    + "\n KM: " + ventas.KM.ToString() + "\n Precio: " + ventas.PrecioVenta + "\n Garantía: " + ventas.Garantia
                    + "\n\n Tiene reservado este coche durante 3 días. Pase por nuestras oficinas para tomar todos los datos necesarios y completar la compra.";
                Session["MailUrl"] = HttpContext.Current.Request.Url.ToString();
                Response.Redirect("EnviarMail.aspx");
            }

        }
    }
}
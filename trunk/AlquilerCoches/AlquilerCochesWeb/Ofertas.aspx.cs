using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace AlquilerCochesWeb
{

    public partial class Ofertas : System.Web.UI.Page
    {

        private EN.ENVentas vehiculo = new EN.ENVentas();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Oferta"] != null)
            {
                
                vehiculo.Matricula = Session["Oferta"].ToString();
                MultiView1.ActiveViewIndex = 4;
                Session["Oferta"] = null;
            }

            switch (MultiView1.ActiveViewIndex)
            {
                case 0:
                    VehiculosListView.DataSource = vehiculo.ObtenerCochesCategoria("KM > 50000 and Categoria=1");
                    VehiculosListView.DataBind();
                    break;
                case 1:
                    ListView1.DataSource = vehiculo.ObtenerCochesCategoria("KM > 50000 and Categoria=2");
                    ListView1.DataBind();
                    break;
                case 2:
                    ListView2.DataSource = vehiculo.ObtenerCochesCategoria("KM > 50000 and Categoria=3");
                    ListView2.DataBind();
                    break;
                case 3:
                    ListView2.DataSource = vehiculo.ObtenerCochesCategoria("KM > 50000 and Categoria=4");
                    ListView2.DataBind();
                    break;
                case 4:
                    if(vehiculo.Matricula!=null)rellenaView4();
                    break;

            }
            
            
        }

        protected void mnuMainMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "Turismos":
                    MultiView1.ActiveViewIndex = 0;
                    break;
                case "Familiares":
                    MultiView1.ActiveViewIndex = 1;
                    break;
                case "Furgonetas":
                    MultiView1.ActiveViewIndex = 2;
                    break;
                case "Especiales":
                    MultiView1.ActiveViewIndex = 3;
                    break;

            }
            Page_Load(null,null);
            
        }

        protected void VehiculosListView_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "Alquilar")
            {
                vehiculo.Matricula = e.CommandArgument.ToString();
                rellenaView4();
            }
            
        }

        protected void rellenaView4()
        {
            vehiculo.ObtenerDatosVehiculos();
            MultiView1.ActiveViewIndex = 4;
            Label1.Text = vehiculo.Marca + " " + vehiculo.Modelo;
            ComprasLabelDescripcion.Text = "Matricula:  "+ vehiculo.Matricula;
            ComprasLabelPrecio.Text = "Precio Compra: " + vehiculo.PrecioVenta;
            ComprasLabelGarantia.Text = "Garantia: " + vehiculo.Garantia;
            Image3.ImageUrl = @"/Imagenes/ImagenesCompra/CochesCompra/";
            switch (vehiculo.Categoria)
            {
                case 1:
                    Image3.ImageUrl += "Turismos/";
                    break;
                case 2:
                    Image3.ImageUrl+="Familiares/";
                    break;
                case 3:
                    Image3.ImageUrl+="Furgonetas/";
                    break;
                case 4:
                    Image3.ImageUrl+="Especiales/";
                    break;
            } 
            Image3.ImageUrl += vehiculo.Matricula + ".jpg";

            if (Int32.Parse(vehiculo.KM) < 100000)
                ComprasLabelPrecio.Text += " - 20%";
            else if (Int32.Parse(vehiculo.KM) < 150000)
                ComprasLabelPrecio.Text += " - 25%";
            else
                ComprasLabelPrecio.Text += " - 30%";
        }

        protected void OfertaComprar_Click(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Server.Transfer("ReservaNoRegistrado.aspx");
            }
            else
            {
                vehiculo.ObtenerDatosVehiculos();
                vehiculo.Reservado = 1;
                if (Int32.Parse(vehiculo.KM) < 100000)
                    vehiculo.PrecioVenta = ((int.Parse(vehiculo.PrecioVenta)*20 / 100)).ToString();
                else if (Int32.Parse(vehiculo.KM) < 150000)
                    vehiculo.PrecioVenta = ((int.Parse(vehiculo.PrecioVenta) * 25 / 100)).ToString();
                else
                    vehiculo.PrecioVenta = ((int.Parse(vehiculo.PrecioVenta) * 30 / 100)).ToString();

                vehiculo.EditarVentas();

                Session["MailSubject"] = "Reserva de compra de: " + Session["email"].ToString();
                Session["MailBody"] = "Nombre y apellidos: " + Session["nombre"].ToString() + " " + Session["apellidos"].ToString()
                    + "\n\n Este cliente ha realizado una reserva del coche: \n Matrícula: " + vehiculo.Matricula + "\n Modelo: " + vehiculo.Marca + " " + vehiculo.Modelo
                    + "\n KM: " + vehiculo.KM.ToString() + "\n Precio: " + vehiculo.PrecioVenta + "\n Garantía: " + vehiculo.Garantia;
                Session["MailUser"] = Session["email"].ToString();
                Session["MailUserSubject"] = "La reserva se ha realizado con éxito.";
                Session["MailUserBody"] = "Has realizado una reserva del coche: \n Matrícula: " + vehiculo.Matricula + "\n Modelo: " + vehiculo.Marca + " " + vehiculo.Modelo
                    + "\n KM: " + vehiculo.KM.ToString() + "\n Precio: " + vehiculo.PrecioVenta + "\n Garantía: " + vehiculo.Garantia
                    + "\n\n Tiene reservado este coche durante 3 días. Pase por nuestras oficinas para tomar todos los datos necesarios y completar la compra.";
                Session["MailUrl"] = HttpContext.Current.Request.Url.ToString();
                Response.Redirect("EnviarMail.aspx");
            }

        }

    }
}
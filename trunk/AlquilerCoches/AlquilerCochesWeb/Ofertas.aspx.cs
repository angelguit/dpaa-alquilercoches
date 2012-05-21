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
                    VehiculosListView.DataSource = vehiculo.ObtenerCochesCategoria("KM > 5000 and Categoria=1");
                    VehiculosListView.DataBind();
                    break;
                case 1:
                    ListView1.DataSource = vehiculo.ObtenerCochesCategoria("KM > 5000 and Categoria=2");
                    ListView1.DataBind();
                    break;
                case 2:
                    ListView2.DataSource = vehiculo.ObtenerCochesCategoria("KM > 5000 and Categoria=3");
                    ListView2.DataBind();
                    break;
                case 3:
                    ListView2.DataSource = vehiculo.ObtenerCochesCategoria("KM > 5000 and Categoria=4");
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
            vehiculo.Matricula=e.CommandArgument.ToString();
            rellenaView4();
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
        }

    }
}
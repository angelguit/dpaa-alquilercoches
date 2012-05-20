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

    public class MyObject
    {
        public String MyProperty { get; set; }
    } 

    public partial class Ofertas : System.Web.UI.Page
    {

        private EN.ENVentas vehiculo = new EN.ENVentas();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Oferta"] != null)
            {
                
                vehiculo.Matricula = Session["Oferta"].ToString();
                MultiView1.ActiveViewIndex = 4;
            }
            if (!Page.IsPostBack)
            {
                List<MyObject> col = new List<MyObject>();
                col.Add(new MyObject { MyProperty = "test 1" });
                col.Add(new MyObject { MyProperty = "test 2" });
                ListView3.DataSource = col;
                ListView3.DataBind();
            }

            switch (MultiView1.ActiveViewIndex)
            {
                case 0:
                    VehiculosListView.DataSource = vehiculo.ObtenerCochesCategoria("KM > 5000");
                    VehiculosListView.DataBind();
                    break;
                case 1:
                    ListView1.DataSource = vehiculo.ObtenerCochesCategoria("KM > 3000 and KM < 5000");
                    ListView1.DataBind();
                    break;
                case 2:
                    ListView2.DataSource = vehiculo.ObtenerCochesCategoria("KM < 3000 and KM > 1000");
                    ListView2.DataBind();
                    break;
                case 3:
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
                case "Clase 50%":
                    MultiView1.ActiveViewIndex = 0;
                    break;
                case "Clase 20%":
                    MultiView1.ActiveViewIndex = 1;
                    break;
                case "Clase 10%":
                    MultiView1.ActiveViewIndex = 2;
                    break;
                case "Clase 5%":
                    MultiView1.ActiveViewIndex = 3;
                    break;

            }
            Page_Load(null,null);
            
        }

        protected void ListView1_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Literal1.Text = "You clicked the " + (String)e.CommandArgument + " button";
            Server.Transfer("Reservas.aspx");
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
            Image2.ImageUrl = @"/Imagenes/ImagenesReserva/fotosCoches/" + vehiculo.Matricula + ".jpg";
        }

    }
}
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

        private EN.ENVehiculo vehiculo = new EN.ENVehiculo();
        protected void Page_Load(object sender, EventArgs e)
        {
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
                    VehiculosListView.DataSource = vehiculo.ObtenerCochesCategoria("A");
                    VehiculosListView.DataBind();
                    break;
                case 1:
                    ListView1.DataSource = vehiculo.ObtenerCochesCategoria("B");
                    ListView1.DataBind();
                    break;
                case 2:
                    ListView2.DataSource = vehiculo.ObtenerCochesCategoria("C");
                    ListView2.DataBind();
                    break;
                case 3:
                    break;

            }
            
            
        }

        protected void mnuMainMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "Clase A":
                    MultiView1.ActiveViewIndex = 0;
                    break;
                case "Clase B":
                    MultiView1.ActiveViewIndex = 1;
                    break;
                case "Clase C":
                    MultiView1.ActiveViewIndex = 2;
                    break;
                case "Clase D":
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
            Server.Transfer("Reservas.aspx");
        }

    }
}
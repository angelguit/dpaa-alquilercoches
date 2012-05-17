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
        private EN.ENVehiculo vehiculo = new EN.ENVehiculo();
        protected void Page_Load(object sender, EventArgs e)
        {
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

            }
            
            
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            
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

            }
            Page_Load(null,null);
            
        }

    }
}
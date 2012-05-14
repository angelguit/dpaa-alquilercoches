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
            VehiculosListView.DataSource = vehiculo.ObtenerListaVehiculos();
            VehiculosListView.DataBind();
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            
        }

    }
}
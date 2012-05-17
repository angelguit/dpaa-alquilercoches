using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlquilerCochesWeb
{
    public partial class Compras : System.Web.UI.Page
    {
        private EN.ENVentas ventas = new EN.ENVentas();

        protected void Page_Load(object sender, EventArgs e)
        {
            ComprasListView.DataSource = ventas.ObtenerListaVentas();
            ComprasListView.DataBind();

        }
    }
}
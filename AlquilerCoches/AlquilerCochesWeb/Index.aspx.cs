using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN;

namespace AlquilerCochesWeb
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void IndexBotonReserva_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reservas.aspx");
        }

        private void RellenarOfertas()
        {
            EN.ENVehiculo enVe = new EN.ENVehiculo();
            DataSet ds = new DataSet();
            
        }
    }
}
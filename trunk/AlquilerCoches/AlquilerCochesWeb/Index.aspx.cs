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
        private bool aux;
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

        protected void IndexLoginC_Authenticate(object sender, AuthenticateEventArgs e)
        {
            EN.ENCliente enCli = new EN.ENCliente();
            DataSet ds = new DataSet();

            ds = enCli.ObtenerDatosClienteConDni(IndexLoginC.UserName.ToString());
            if (ds.Tables["Cliente"].Rows.Count > 0)
            {
                if (ds.Tables["Cliente"].Rows[0][10].ToString() == IndexLoginC.Password.ToString())
                {
                    Session["Usuario"] = IndexLoginC.UserName.ToString();
                    e.Authenticated = true;

                }
                else
                {
                    e.Authenticated = false;
                }
            }
            
        }

        protected void CustomValidatorLogin_ServerValidate(object source, ServerValidateEventArgs args)
        {
        }

    }
}
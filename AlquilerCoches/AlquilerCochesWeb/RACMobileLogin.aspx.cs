using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlquilerCochesWeb
{
    public partial class RACMobile2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Request.Form["_username"];
            string pass = Request.Form["_password"];
            string red = "RACMobile.aspx";

            EN.ENCliente enCli = new EN.ENCliente();
            DataSet ds = new DataSet();

            ds = enCli.ObtenerDatosClienteConDni(user);
            if (ds.Tables["Cliente"].Rows.Count > 0)
            {
                if (ds.Tables["Cliente"].Rows[0][10].ToString() == pass)
                {
                    Session["Usuario"] = user.ToString();
                    Response.Redirect(red);
                }
                else
                {
                    red += "#registro";
                    Response.Redirect(red);
                }
            }
            
            
        }
    }
}
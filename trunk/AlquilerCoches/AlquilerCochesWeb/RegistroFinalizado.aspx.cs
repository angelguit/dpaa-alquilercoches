using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN;


namespace AlquilerCochesWeb
{
    public partial class RegistroFinalizado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void IndexLoginC_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            EN.ENCliente enCli = new EN.ENCliente();
            DataSet ds = new DataSet();

            ds = enCli.ObtenerDatosClienteConDni(Login1.UserName.ToString());
            if (ds.Tables["Cliente"].Rows.Count > 0)
            {
                if (ds.Tables["Cliente"].Rows[0][10].ToString() == Login1.Password.ToString())
                {
                    Session["Usuario"] = Login1.UserName.ToString();
                    e.Authenticated = true;

                    
            EN.ENCliente cli = new ENCliente();
            DataSet dscli = new DataSet();
            if (Session["Usuario"] != null)
            {
                dscli = cli.ObtenerDatosClienteConDni(Session["Usuario"].ToString());

                Session["nombre"]  = dscli.Tables["Cliente"].Rows[0][1].ToString();
                Session["apellidos"]  = dscli.Tables["Cliente"].Rows[0][2].ToString();
                Session["telefono"]= dscli.Tables["Cliente"].Rows[0][3].ToString();
                Session["email"] = dscli.Tables["Cliente"].Rows[0][4].ToString();
                Session["direccion"]  = dscli.Tables["Cliente"].Rows[0][5].ToString();
                Session["provincia"]= dscli.Tables["Cliente"].Rows[0][6].ToString();
                Session["ciudad"] = dscli.Tables["Cliente"].Rows[0][7].ToString();
            }

            Response.Redirect("Index.aspx");
                }
                else
                {
                    e.Authenticated = false;
                    Login1.FailureText = "Contraseña o usuario incorrecto.";
                }
            }
            else
            {
                e.Authenticated = false;
                Login1.FailureText = "No existe ese usuario.";
            }
        }
    }
}
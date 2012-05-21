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
    public partial class RACMobile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                string s = "<script type=\"text/javascript\">alert(\"" + Session["Usuario"].ToString() + "\");</script>";
                ENCliente enCli = new EN.ENCliente();
                DataSet ds = new DataSet();
                ds = enCli.ObtenerDatosClienteConDni(Session["Usuario"].ToString());
                string script = "<script type=\"text/javascript\">document.getElementById(\"tit\").innerHTML = \"Bienvenido " + ds.Tables["Cliente"].Rows[0][1].ToString() + ".\";</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Rellenar", s);
            }

            EN.ENVentas enVe = new EN.ENVentas();
            DataSet ds2 = new DataSet();
            ds2 = enVe.ObtenerListaVentas();
            ArrayList lista = new ArrayList();
            StringBuilder cstext1 = new StringBuilder();
            StringBuilder cstext2 = new StringBuilder();

            if (ds2.Tables["Ventas"].Rows.Count > 0)
            {
                cstext1.Append("<script type=\"text/javascript\">");
                cstext1.Append("var ul = document.getElementById(\"Ofertas\");");
                
                for (int i = 0; i < ds2.Tables["Ventas"].Rows.Count; i++)
                {

                    cstext1.Append("var a = document.createElement(\"a\");");
                    cstext1.Append("a.href = \"Ofertas.aspx\";");
                    cstext1.Append("a.setAttribute('onclick','AlquilerCochesWeb.ServicioWeb.RellenarOferta(\"" + ds2.Tables["Ventas"].Rows[i][0].ToString() + "\")');");
                    cstext1.Append("a.text =" + ds2.Tables["Ventas"].Rows[i][1].ToString() + " " + ds2.Tables["Ventas"].Rows[i][2].ToString() + " KM: " + ds2.Tables["Ventas"].Rows[i][3].ToString() + " PVP: " + ds2.Tables["Ventas"].Rows[i][5].ToString() + "€\";");
                    cstext1.Append("var li = document.createElement(\"li\");");
                    cstext1.Append("li.appendChild(a);");
                    cstext1.Append("ul.appendChild(li);");

                }
                cstext1.Append("</");
                cstext1.Append("script>");
            }

            cstext2.Append("<script type=\"text/javascript\">");
            cstext2.Append("$(\"#scroller\").simplyScroll();");
            cstext2.Append("</");
            cstext2.Append("script>");


            Page.ClientScript.RegisterStartupScript(this.GetType(), "Rellenar", cstext1.ToString());
        }
    }
}
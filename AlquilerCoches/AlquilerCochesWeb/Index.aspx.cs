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
    public partial class Index : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder cstext1 = new StringBuilder();
            Posterior.ValueToCompare = System.DateTime.Today.AddDays(-1).ToString();
            RellenarOfertas();
            if (Session["Usuario"] != null)
            {
                EN.ENCliente enCli = new EN.ENCliente();
                DataSet ds = new DataSet();
                ds = enCli.ObtenerDatosClienteConDni(Session["Usuario"].ToString());
                IndexLoginC.Visible = false;
                IndexRegistroPH.Visible = false;
                cstext1.Append("<script type=\"text/javascript\">");
                cstext1.Append("var id = document.getElementById(\"IndexLogin\");");
                cstext1.Append("id.style.height = \"300px\";");
                cstext1.Append("</");
                cstext1.Append("script>");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Agrandar", cstext1.ToString());
                TLabelBienvenida.Text = "Bienvenido " + ds.Tables["Cliente"].Rows[0][1].ToString();
                TLabelBienvenida.Visible = true;
                IndexLogoUsuario.ImageUrl = "Imagenes/ImagenesPerfil/" + Session["Usuario"].ToString() + ".jpg";
                IndexLogoUsuario.Visible = true;
                if (enCli.HaReservado())
                {
                    IndexReservaRapida.Visible = true;
                }
            }
            else
            {
                IndexLoginC.Visible = true;
                TLabelBienvenida.Visible = false;
                IndexLogoUsuario.Visible = false;
                IndexReservaRapida.Visible = false;
            }
        }

        protected void IndexBotonReserva2_Click(object sender, EventArgs e)
        {
            if (Posterior.IsValid && CompareValidatorFechas.IsValid)
            {
                Session["FechaInicioIndex"] = IndexTextFechaInicio.Text.ToString();
                Session["FechaFinIndex"] = IndexTextFechaFin.Text.ToString();
                Response.Redirect("Reservas.aspx");
            }
        }

 
        private void RellenarOfertas()
        {
            EN.ENVentas enVe = new EN.ENVentas();
            DataSet ds = new DataSet();
            ds = enVe.ObtenerListaVentas();
            ArrayList lista = new ArrayList();
            StringBuilder cstext1 = new StringBuilder();
            StringBuilder cstext2 = new StringBuilder();
            
            if (ds.Tables["Ventas"].Rows.Count > 0)
            {
                cstext1.Append("<script type=\"text/javascript\"> var ofertas = document.getElementById(\"IndexBoxOfertas\");");
                cstext1.Append("var ul = document.createElement(\"ul\");");
                cstext1.Append("ul.id = \"scroller\";");
                cstext1.Append("ofertas.appendChild(ul);");
                string aux = "";
                
                for (int i = 0; i < ds.Tables["Ventas"].Rows.Count; i++)
                {
                    switch(Int32.Parse(ds.Tables["Ventas"].Rows[i][7].ToString()))
                    {
                        case 1: aux = "Turismos/";
                            break;
                        case 2: aux = "Familiares/";
                            break;
                        case 3: aux = "Furgonetas/";
                            break;
                        case 4: aux = "Especiales/";
                            break;
                    }
                    cstext1.Append("var img = document.createElement(\"img\");");
                    cstext1.Append("img.title = \"" + ds.Tables["Ventas"].Rows[i][1].ToString() + " " + ds.Tables["Ventas"].Rows[i][2].ToString() + " KM: " + ds.Tables["Ventas"].Rows[i][3].ToString() + " PVP: " + ds.Tables["Ventas"].Rows[i][5].ToString() + "€\";");
                    cstext1.Append("img.alt = \"" + ds.Tables["Ventas"].Rows[i][2].ToString() + "\";");
                    cstext1.Append("img.src = \"Imagenes/ImagenesCompra/CochesCompra/" + aux + ds.Tables["Ventas"].Rows[i][0].ToString() + ".jpg\";");
                    cstext1.Append("img.setAttribute('width','200');");
                    cstext1.Append("img.setAttribute('height','200');");
                    cstext1.Append("var a = document.createElement(\"a\");");
                    cstext1.Append("a.href = \"Ofertas.aspx\";");
                    cstext1.Append("a.setAttribute('onclick','AlquilerCochesWeb.ServicioWeb.RellenarOferta(\"" + ds.Tables["Ventas"].Rows[i][0].ToString() + "\")');");
                    cstext1.Append("a.appendChild(img);");
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
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Rellenar2", cstext2.ToString());
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

                    EN.ENCliente cli = new ENCliente();
                    DataSet dscli = new DataSet();
                    if (Session["Usuario"] != null)
                    {
                        dscli = cli.ObtenerDatosClienteConDni(Session["Usuario"].ToString());

                        Session["nombre"] = dscli.Tables["Cliente"].Rows[0][1].ToString();
                        Session["apellidos"] = dscli.Tables["Cliente"].Rows[0][2].ToString();
                        Session["telefono"] = dscli.Tables["Cliente"].Rows[0][3].ToString();
                        Session["email"] = dscli.Tables["Cliente"].Rows[0][4].ToString();
                        Session["direccion"] = dscli.Tables["Cliente"].Rows[0][5].ToString();
                        Session["provincia"] = dscli.Tables["Cliente"].Rows[0][6].ToString();
                        Session["ciudad"] = dscli.Tables["Cliente"].Rows[0][7].ToString();
                    }
                }
                else
                {
                    e.Authenticated = false;
                    IndexLoginC.FailureText = "Contraseña o usuario incorrecto.";
                }
            }
            else
            {
                e.Authenticated = false;
                IndexLoginC.FailureText = "No existe ese usuario.";
            }
            
        }

        protected void TButtonReservar_Click(object sender, EventArgs e)
        {
            if (RequiredFieldValidatorReservaRapida.IsValid)
            {
                if (TRadioButtonList.SelectedIndex == 1)
                {
                    Session["ReservaRapida"] = "Habitual";
                }
                else
                {
                    Session["ReservaRapida"] = "Ultima";
                }
                Response.Redirect("Reservas.aspx");
            }
        }

        protected void IndexLogoUsuario_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Perfil.aspx");
        }
    }
}
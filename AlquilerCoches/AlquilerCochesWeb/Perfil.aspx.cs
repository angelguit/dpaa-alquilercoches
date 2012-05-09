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
    public partial class Perfil : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            EN.ENCliente cli = new ENCliente();
            DataSet dscli = new DataSet();
            dscli = cli.ObtenerDatosClienteConDni("11111111A");

            Session["nombre"] = TLabelNombre.Text = dscli.Tables["Cliente"].Rows[0][1].ToString();
            Session["apellidos"] = TLabelApellidos.Text = dscli.Tables["Cliente"].Rows[0][2].ToString();
            Session["telefono"] = TLabelTelefono.Text = dscli.Tables["Cliente"].Rows[0][3].ToString();
            Session["email"] = TLabelEmail.Text = dscli.Tables["Cliente"].Rows[0][4].ToString();
            Session["direccion"] = TLabelDireccion.Text = dscli.Tables["Cliente"].Rows[0][5].ToString();
            Session["provincia"] = TLabelProvincia.Text = dscli.Tables["Cliente"].Rows[0][6].ToString();
            Session["ciudad"] = TLabelCiudad.Text = dscli.Tables["Cliente"].Rows[0][7].ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlquilerCochesWeb
{
	public partial class PerfilEditar : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            TTextBoxNombre.Text = Session["nombre"].ToString();
            TTextBoxApellidos.Text = Session["apellidos"].ToString();
            TDropDownListProvincia.Items.Add(Session["provincia"].ToString());
            TDropDownListCiudad.Items.Add(Session["ciudad"].ToString());
            TTextBoxEmail.Text = Session["email"].ToString();
            TTextBoxTelefono.Text = Session["telefono"].ToString();
            TTextBoxDireccion.Text = Session["direccion"].ToString();
            
		}
	}
}
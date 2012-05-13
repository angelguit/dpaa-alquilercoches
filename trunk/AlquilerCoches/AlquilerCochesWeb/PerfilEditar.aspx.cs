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
	public partial class PerfilEditar : System.Web.UI.Page
	{
        private DataSet numProvincia = new DataSet();
        private bool primeravez = true;
        private bool vengodeload = true;
		protected void Page_Load(object sender, EventArgs e)
		{
            TTextBoxNombre.Text = Session["nombre"].ToString();
            TTextBoxApellidos.Text = Session["apellidos"].ToString();
            
           

            TDropDownListCiudad.Items.Add(Session["ciudad"].ToString());
            TTextBoxEmail.Text = Session["email"].ToString();
            TTextBoxTelefono.Text = Session["telefono"].ToString();
            //TTextBoxDireccion.Text = Session["direccion"].ToString();
            TTextBoxDireccion.Text = "GAY";
            TDropDownListProvincia.Items.Add("Alicante");
		}

        protected void TDropDownListProvincia_TextChanged(object sender, EventArgs e)
        {
            vengodeload = false;
            EN.ENCliente enCiu = new EN.ENCliente();
            DataSet dsCiu = new DataSet();
            TTextBoxDireccion.Text = "Cerdaco";
            try
            {
                string prov = TDropDownListProvincia.Text.ToString();
                TTextBoxTelefono.Text = prov;
                bool parar = false;
                // MessageBox.Show(numProvincia.Tables["Provincia"].Rows.Count.ToString());
                for (int i = 0; i < 53 && parar != true; i++)
                {
                    //MessageBox.Show(numProvincia.Tables["Provincia"].Rows[i][1].ToString());
                    if (numProvincia.Tables["Provincia"].Rows[i][1].ToString() == prov)
                    {
                        string numprov = numProvincia.Tables["Provincia"].Rows[i][0].ToString();// en la posicion 0 esta el id de la provincia
                        parar = true;
                        dsCiu = enCiu.ObtenerListaCiudades(numprov);

                    }
                }
                ObtenerCiudades(dsCiu);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        private void ObtenerCiudades(DataSet dsCiu)
        {
            TDropDownListCiudad.DataSource = "";

            TDropDownListCiudad.DataSource = dsCiu;
            TDropDownListCiudad.DataValueField = "municipio"; // en el dataset con DataValueField nos permite elegir la columna que queremos
            TDropDownListCiudad.DataBind(); //hay que ponerlo para que se muestren bien los datos
            if (vengodeload == true)
            {
                TDropDownListCiudad.SelectedValue = Session["ciudad"].ToString(); // con selectedvalue le decimos que valor queremos que este marcado en el combobox
            }
            //Fin Provincias
            
        }

        protected void TDropDownListProvincia_Load(object sender, EventArgs e)
        {
            TDropDownListProvincia.Items.Clear();
            //Provincias
            EN.ENCliente provincia = new EN.ENCliente();
            DataSet dsProv = new DataSet();
            dsProv = provincia.ObtenerListaProvincias();
            numProvincia = dsProv; // nos hacemos esta copia para usarla despues en ciudades

            /*TDropDownListProvincia.DataSource = dsProv;
            TDropDownListProvincia.DataValueField = "nombre"; // en el dataset nos vienen dos columnas (id,nombre) con DataValueField nos permite elegir la columna que queremos
            TDropDownListProvincia.DataBind(); //hay que ponerlo para que se muestren bien los datos
            TDropDownListProvincia.SelectedValue = Session["provincia"].ToString(); // con selectedvalue le decimos que valor queremos que este marcado en el combobox
            */
            for (int i = 0; i < dsProv.Tables["Provincia"].Rows.Count; i++)
            {
                TDropDownListProvincia.Items.Add(dsProv.Tables["Provincia"].Rows[i][1].ToString());
            }

            TDropDownListProvincia.Items.Insert(0, Session["provincia"].ToString());

           /* if(primeravez == true)
            {
                TDropDownListProvincia.SelectedValue = Session["provincia"].ToString();
                
                primeravez = false;
            }*/
            //Fin Provincias

        }
      
	}
}
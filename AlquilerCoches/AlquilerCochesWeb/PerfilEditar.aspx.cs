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
        private bool vengodeload = false;
        protected void Page_Load(object sender, EventArgs e)
		{
            TTextBoxNombre.Text = Session["nombre"].ToString();
            TTextBoxApellidos.Text = Session["apellidos"].ToString();
            TTextBoxEmail.Text = Session["email"].ToString();
            TTextBoxTelefono.Text = Session["telefono"].ToString();
            TTextBoxDireccion.Text = Session["direccion"].ToString();
           
		}

        protected void TDropDownListProvincia_TextChanged(object sender, EventArgs e)
        {
            EN.ENCliente enCiu = new EN.ENCliente();
            DataSet dsCiu = new DataSet();
            try
            {
                string prov = TDropDownListProvincia.Text.ToString();
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
                vengodeload = false;
            }
            
            
        }

        protected void TDropDownListProvincia_Load(object sender, EventArgs e)
        {
            //Provincias
            
            EN.ENCliente provincia = new EN.ENCliente();
            DataSet dsProv = new DataSet();
            dsProv = provincia.ObtenerListaProvincias();
            numProvincia = dsProv; // nos hacemos esta copia para usarla despues en ciudades

            if (TDropDownListProvincia.Items.Count == 0)
            {
                vengodeload = true;
                TDropDownListProvincia.Items.Clear();

                for (int i = 0; i < dsProv.Tables["Provincia"].Rows.Count; i++)
                {
                    TDropDownListProvincia.Items.Add(dsProv.Tables["Provincia"].Rows[i][1].ToString());
                }

                TDropDownListProvincia.SelectedValue = Session["provincia"].ToString(); //valor por defecto

                //FIN provi

                //Cargar CIudad

                EN.ENCliente enCiu = new EN.ENCliente();
                DataSet dsCiu = new DataSet();
                try
                {
                    string prov = TDropDownListProvincia.Text.ToString();
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
                //Fin Ciudad
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ENCliente cli = new ENCliente();
            DataSet ds = new DataSet();
            ds = cli.ObtenerDatosClienteConDni(Session["Usuario"].ToString());

            cli.DNI = ds.Tables["Cliente"].Rows[0][0].ToString();
            cli.Nombre = TTextBoxNombre.Text;
            cli.Apellidos = TTextBoxApellidos.Text;
            cli.Provincia = TDropDownListProvincia.Text;
            cli.Ciudad = TDropDownListCiudad.Text;
            cli.Direccion = TTextBoxDireccion.Text;
            cli.Email = TTextBoxEmail.Text;
            cli.Tarifa = ds.Tables["Cliente"].Rows[0][8].ToString();
            cli.Sexo = ds.Tables["Cliente"].Rows[0][9].ToString();
           // cli.Pass


        }

      
      
	}
}
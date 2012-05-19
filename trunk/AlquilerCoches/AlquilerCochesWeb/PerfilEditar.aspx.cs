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
            if (!Page.IsPostBack)
            {
                FotoUsuario.ImageUrl = "/Imagenes/ImagenesPerfil/" + Session["Usuario"].ToString() + ".jpg";
                TTextBoxNombre.Text = Session["nombre"].ToString();
                TTextBoxApellidos.Text = Session["apellidos"].ToString();
                TTextBoxEmail.Text = Session["email"].ToString();
                TTextBoxTelefono.Text = Session["telefono"].ToString();
                TTextBoxDireccion.Text = Session["direccion"].ToString();

                ENCliente cli = new ENCliente();
                DataSet ds = new DataSet();
                ds = cli.ObtenerDatosClienteConDni(Session["Usuario"].ToString());

                TTextBoxPass.Text = ds.Tables["Cliente"].Rows[0][10].ToString();
            }
           
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
                Session["nombre"] =  cli.Nombre = TTextBoxNombre.Text;
                Session["apellidos"] = cli.Apellidos = TTextBoxApellidos.Text;
                Session["provincia"] = cli.Provincia = TDropDownListProvincia.Text;
                Session["ciudad"] = cli.Ciudad = TDropDownListCiudad.Text;
                Session["direccion"] =cli.Direccion = TTextBoxDireccion.Text;
                Session["email"] = cli.Email = TTextBoxEmail.Text;
                cli.Tarifa = ds.Tables["Cliente"].Rows[0][8].ToString();
                cli.Sexo = ds.Tables["Cliente"].Rows[0][9].ToString();
                cli.PassWeb = TTextBoxPass.Text;
                TTextBoxPass2.Text = cli.PassWeb;
                Session["telefono"] = cli.Telefono = Int32.Parse(TTextBoxTelefono.Text);

                cli.EditarCliente();
                // Response.Redirect("Perfil.aspx");

                ENCliente clien = new ENCliente();
                DataSet dscli = new DataSet();
                dscli = clien.ObtenerDatosClienteConDni(Session["Usuario"].ToString());

                TTextBoxEmail.Text = dscli.Tables["Cliente"].Rows[0][4].ToString();

           
        }

        protected void ButtonSubirImagen_Click(object sender, EventArgs e)
        {

            string saveDir = @"/Imagenes/ImagenesPerfil/";

            // Get the physical file system path for the currently
            // executing application.
            string appPath = Request.PhysicalApplicationPath;

            if (FileUpload1.HasFile)
            {
                 int fileSize = FileUpload1.PostedFile.ContentLength;


                 if (fileSize < 2100000)
                 {
                     string fileName = Server.HtmlEncode(FileUpload1.FileName);
                     string extension = System.IO.Path.GetExtension(fileName);

                     if (extension == ".jpg")
                     {

                         string savePath = appPath + saveDir +
                         Server.HtmlEncode(Session["Usuario"].ToString() + ".jpg");


                         FileUpload1.SaveAs(savePath);

                         // Notify the user that the file was uploaded successfully.
                         UploadStatusLabel.Text = "Su imagen ha sido subida correctamente";
                         //Response.Redirect("PerfilEditar.aspx");
                        // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Prueba", "location.reload()", true);
                      
                     }
                     else
                     {
                         UploadStatusLabel.Text = "Su imagen no se ha podido subir porque su extension no es .jpg";
                     }
                 }
                 else
                     UploadStatusLabel.Text = "Su imagen no se ha podido subir porq supera los 2 MB de tamaño maximo";
                                         
            }
            else
            {
                // Notify the user that a file was not uploaded.
                UploadStatusLabel.Text = "No ha especificado un directorio";
            }
            
        }

      
      
	}
}
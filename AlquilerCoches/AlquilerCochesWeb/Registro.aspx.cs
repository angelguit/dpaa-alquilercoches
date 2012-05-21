using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN;
using System.Text.RegularExpressions;
using System.Collections;

namespace AlquilerCochesWeb
{
    public partial class Registro : System.Web.UI.Page
    {
        private DataSet numProvincia = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
           

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
          

        }
        protected void TDropDownListProvincia_Load(object sender, EventArgs e)
        {
            EN.ENCliente provincia = new EN.ENCliente();
            DataSet dsProv = new DataSet();
            dsProv = provincia.ObtenerListaProvincias();
            numProvincia = dsProv; // nos hacemos esta copia para usarla despues en ciudades

            if (TDropDownListProvincia.Items.Count == 0)
            {
           
                TDropDownListProvincia.Items.Clear();

                for (int i = 0; i < dsProv.Tables["Provincia"].Rows.Count; i++)
                {
                    TDropDownListProvincia.Items.Add(dsProv.Tables["Provincia"].Rows[i][1].ToString());
                }

       
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

        protected void TDropDownListProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EN.ENCliente en_cliente = new EN.ENCliente();
            if (Page.IsValid)
            {
                en_cliente.DNI = TextBox5.Text;
                en_cliente.Nombre = TTextBoxNombre.Text;
                en_cliente.Apellidos = TTextBoxApellidos.Text;
                en_cliente.PassWeb = TextBox1.Text;
                en_cliente.Direccion = TTextBoxDireccion.Text;
                en_cliente.Provincia = TDropDownListProvincia.SelectedItem.ToString();
                en_cliente.Ciudad = TDropDownListCiudad.SelectedItem.ToString();
                en_cliente.Email = TTextBoxEmail.Text;
                en_cliente.Telefono = Convert.ToInt32(TextBox3.Text);
               
                if (CheckBox1.Checked)
                {
                    en_cliente.Sexo = "H";
                }
                else { en_cliente.Sexo = "M"; }

                en_cliente.AnyadirCliente();

                
                Button2_Click(null, null);

                Response.Redirect("RegistroFinalizado.aspx");

            }
           
        }

        protected void ComprobarUsuario(object source, ServerValidateEventArgs args)
        {

           

        }

        protected void ComprobarTelefono(object source, ServerValidateEventArgs args)
        {

        }

        protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
        {
          
        }

        protected void TTextBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TTextBoxEmail_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void CustomValidator5_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }

        protected void CustomValidator4_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CustomValidator4_ServerValidate1(object source, ServerValidateEventArgs args)
        {
            if (Regex.Match(TextBox3.Text, @"^[0-9]{9}$").Success)
            {

                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;

            }
        }

        protected void CustomSexo_ServerValidate1(object source, ServerValidateEventArgs args)
        {
            if (CheckBox1.Checked || CheckBox2.Checked)
            {
                args.IsValid = true;
            }
            else { args.IsValid = false; } 
        }

        protected void CustomEmail_ServerValidate1(object source, ServerValidateEventArgs args)
        {
            if (Regex.Match(TTextBoxEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {

                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;

            }
        }

        protected void CustomValidatorDNI_ServerValidate1(object source, ServerValidateEventArgs args)
        {

        }

        protected void CustomValidator6_ServerValidate(object source, ServerValidateEventArgs args)
        {


            if (Regex.Match(TextBox5.Text, @"^(([A-Z]\d{8})|(\d{8}[A-Z]))$").Success)
            {
                EN.ENCliente en_cliente = new EN.ENCliente();
               // bool parar=false;
               // ArrayList array = new ArrayList();
               // string todo="DNI='"+TextBox5.Text+"'"; 

                string dni = TextBox5.Text;
                DataSet ds = new DataSet();
               
                ds = en_cliente.ObtenerDatosClienteConDni(dni);
                //DataColumn colum = new DataColumn();
                if (ds.Tables["Cliente"].Rows.Count == 0) // si el dataset no tiene ningun resultado quiere decir q no hay ningun dni con el valor que le hemos pasado en la base de datos
                {
                    //Label15.Text = ds.Tables["Cliente"].Rows[0][0].ToString();
                    args.IsValid = true;
                   
                }
                else
                {
                    args.IsValid = false;
                }
       

                

                
               
              
            }
            else
            {
                args.IsValid = false;
                 //Label15.Text = "falso";
                 
                
               
            }
        }

      

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void IndexLoginC_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
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
                            TextBox5.Text + ".jpg";


                        FileUpload1.SaveAs(savePath);

                        // Notify the user that the file was uploaded successfully.
                        UploadStatusLabel.Text = "Su imagen ha sido subida correctamente";
                        //Response.Redirect("PerfilEditar.aspx");
                        // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Prueba", "location.reload()", true);
                        Image1.ImageUrl = "/Imagenes/ImagenesPerfil/" + TextBox5.Text + ".jpg";
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
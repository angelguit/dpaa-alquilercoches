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
    public partial class Registro : System.Web.UI.Page
    {
        /*
        private DataSet numProvincia = new DataSet();
        private bool vengodeload = false; */
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TDropDownListProvincia_TextChanged(object sender, EventArgs e)
        {

            /*
            EN.ENCliente enCiu = new EN.ENCliente();
            DataSet dsCiu = new DataSet();
            //try
            //{
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
            ObtenerCiudades(dsCiu); */
            // }
            // catch (Exception ex)
            //{
            //  throw (ex);
            //}
        }
        /*
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
         * */

        protected void TDropDownListProvincia_Load(object sender, EventArgs e)
        {
            //Provincias
            /*
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

         //       TDropDownListProvincia.SelectedValue = Session["provincia"].ToString(); //valor por defecto
       
                //FIN provi

                //Cargar CIudad

                EN.ENCliente enCiu = new EN.ENCliente();
                DataSet dsCiu = new DataSet();
                try
                {
                    string prov = TDropDownListProvincia.SelectedIndex.ToString();  //provincia elegida
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
             * */
        }

        protected void TDropDownListProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           /*
               bool incorrecto=false;

               if(incorrecto!=true)
               {
                EN.ENPedidos enPedidos = new EN.ENPedidos();

                string envio = "";
              

                if (TEnvioButtonOrdinario.Checked==true)
                {
                    envio = "Ordinario";
                }
                if (TEnvioButtonUrgente.Checked==true)
                {
                    envio = "Urgente";
                }

                enPedidos.IDTransaccion = TIDtextBox.Text; // idtransaccion
                enPedidos.Proveedor = TProveecomboBox1.Text;  //proveedor
                enPedidos.Marca = TMarcacomboBox2.Text;  //marca
                enPedidos.Modelo = TModelocomboBox3.Text;   //modelo
                enPedidos.Cantidad = numericUpDown1.Text;  //cantidad
                enPedidos.Observaciones = TObservTextBox.Text;  //observaciones
                enPedidos.Empleado = TVendedorText.Text; //empleado
                enPedidos.TipoEnvio = envio;  //tipo de envio
                enPedidos.EstadoPedido = " Abierto";

                if (editar == "SI")
                {
                    enPedidos.EditarPedidos();
                    label1.Text = "* Pedido modificado con éxito. *";

                }
                else
                {
                    enPedidos.AnyadirPedidos();
                    label1.Text = "* Pedido realizado con éxito. *";
                }
             */
        }

        protected void ComprobarUsuario(object source, ServerValidateEventArgs args)
        {

            string user = args.Value.ToLower();

            
            
            if (user =="hola") 
            {
                args.IsValid = false;
            }

        }

        protected void ComprobarTelefono(object source, ServerValidateEventArgs args)
        {

        }

        protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (TTextBoxNombre.Text == "hola")
            {
                args.IsValid = false;
            }
            else args.IsValid = true;
        }
             
            
    }
}
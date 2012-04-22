using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AlquilerCoches
{
    public partial class GestionPedidos : Form
    {
        public GestionPedidos()
        {
            InitializeComponent();

            EN.ENPedidos marca = new EN.ENPedidos();
            DataSet dsMarc = new DataSet();
            dsMarc = marca.ObtenerListaMarcas();

            numMarca = new DataSet();
            numMarca = dsMarc;


            //Recuperar empleado
            EN.ENPersonal Personal = new EN.ENPersonal();
             Personal = new EN.ENPersonal();
             Personal.DNI = "33456789E";
             Personal.ObtenerDatosPersonal();
             TVendedorText.Text = Personal.Nombre+" "+Personal.Apellidos;

        }
      
         public GestionPedidos(string id,string proveedor, string marca, string modelo, string cantidad, string observaciones, string estado, string empleado, string tipoenvio, string nombrebotonguardar)//constructor sobrecargado
        {
            InitializeComponent();
          
            
            TMarcacomboBox2.Items.Add(marca);
            TMarcacomboBox2.SelectedIndex = 0;
            TModelocomboBox3.Items.Add(modelo);
            TModelocomboBox3.SelectedIndex = 0;

            TProveecomboBox1.Text = proveedor;

            TVendedorText.Text = empleado;
            //Combobox
            TProveecomboBox1.Text = proveedor;
            TMarcacomboBox2.Text = marca;
            TModelocomboBox3.Text = modelo;
            //Radiobutton
            if (tipoenvio == "Ordinario")
            {
                TEnvioButtonOrdinario.Checked = true;
            }
            else TEnvioButtonOrdinario.Checked = true;

            TEnvioButtonOrdinario.Checked = true;
            TObservTextBox.Text = observaciones;
            numericUpDown1.Text = cantidad;

            EN.ENPedidos pedid = new EN.ENPedidos();
            DataSet dsPedid = new DataSet();
            dsPedid = pedid.ObtenerListaMarcas();
            //ObtenerProvincias(dsProv)

            numMarca = new DataSet();
            numMarca = dsPedid;
           
            /*

            TButtonGuardarPersonal.Text = nombrebotonguardar; // importante le cambiamos el nombre al boton para saber que venimos del formulario buscar, y estamos editando no guardando uno nuevo
            TButtonGuardarPersonal.Size = new Size(105, 24);
            */
        }

        bool incorrecto = false;

        private void GestionPedidos_Load(object sender, EventArgs e)
        {
            EN.ENPedidos enID = new EN.ENPedidos();
            DataSet dsIDs = new DataSet();
            dsIDs = enID.ObtenerListaID();

           
            DataSet id_pedidos = new DataSet();
            id_pedidos = dsIDs;

            TEstadoTextBox.Text = "   ABIERTO";


            // Obtener ID base de datos
            try
            {
         
                bool parar = false;
                int n = 0;
                for (int i = 0; i < 4 && parar!= true; i++)
                {

                    if (id_pedidos.Tables["Pedidos"].Rows[i][0].ToString()!=null )
                    {

                        n++;
                    }
                    if (id_pedidos.Tables["Pedidos"].Rows[i][0].ToString() == null)
                    {
                        parar = true;
                    }
                }

                n++;
               


                string s = Convert.ToString(n);
                string p = "P";
                string total = "";
                total +=" "+ s + p;
                TIDtextBox.Text = total;

            }
            catch (Exception ex)
            {
                throw(ex);
            }
          
       

        }
        
        private void TButtonOK_Click(object sender, EventArgs e)
        {
            if (TProveecomboBox1.Text == "" || TMarcacomboBox2.Text == "" || TModelocomboBox3.Text == "" || TVendedorText.Text=="")
            {
                MessageBox.Show("Campos invalidos, no puede haber ninguno vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (incorrecto == true)
            {
                MessageBox.Show("Campos invalidos, reviselos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                EN.ENPedidos enPedidos = new EN.ENPedidos();

                string envio="";

                if (TEnvioButtonOrdinario.Checked)
                {
                    envio = "Ordinario";
                }
                if (TEnvioButtonUrgente.Checked)
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

           

                enPedidos.AnyadirPedidos();


         /*       if (TAceptarbutton1.Text.ToString() == "Guardar")
                {
                    enPersonal.AnyadirPersonal();
                }
                else
                {
                    enPersonal.EditarPersonal();
                }   */
            }

           // this.Close();

             
                
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TEstadoTextBox_TextChanged(object sender, EventArgs e)
        {
            TEstadoTextBox.Text = "Abierto";
        }

        private void TProveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBorrarbutton3_Click(object sender, EventArgs e)
        {
            TVendedorText.Text = "";
            //Combobox
            TProveecomboBox1.SelectedIndex = 0;
            TMarcacomboBox2.SelectedIndex = 0;
            TModelocomboBox3.SelectedIndex = 0;
            //Radiobutton
            TEnvioButtonOrdinario.Checked = true;
            TObservTextBox.Text = "";
            numericUpDown1.Value = 1;

        }

        private void TCancelarbutton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(numericUpDown1.Text, @"^[1-9]{1}$").Success)
            {
                errorProvider1.SetError(numericUpDown1, "El número de pedidos es entre 1 y 9");
                incorrecto = true;
            }
            else { errorProvider1.SetError(numericUpDown1, ""); }
        }

        private void TProveecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private DataSet numMarca; //usado en funcion TModelos
        private void ObtenerMarcas(DataSet dsMarc)
        {
            TMarcacomboBox2.Text = "Seleccione Marca del coche";
            TMarcacomboBox2.DataSource = dsMarc.Tables["Marca"];
            TMarcacomboBox2.DisplayMember = dsMarc.Tables["Marca"].Columns[1].Caption.ToString(); 

        }

        private void ObtenerModelos(DataSet dsMod)
        {
            TModelocomboBox3.Text = "Seleccione el modelo del coche";
            TModelocomboBox3.DataSource = dsMod.Tables["Modelo"];
            TModelocomboBox3.DisplayMember = dsMod.Tables["Modelo"].Columns[0].Caption.ToString();
        }
        private void TMarcacomboBox2_Leave(object sender, EventArgs e)
        {
            if (TMarcacomboBox2.Text=="")
            {
                errorProvider1.SetError(TMarcacomboBox2, "Seleccione la marca del coche");
                incorrecto = true;
            } 
            else
            {
                errorProvider1.SetError(TMarcacomboBox2, "");
            } 
        }

        private void TModelocomboBox3_Leave(object sender, EventArgs e)
        {
             if (TModelocomboBox3.Text=="")
             {
                 errorProvider1.SetError(TModelocomboBox3, "Seleccione el modelo del coche");
                 incorrecto = true;
             } 
            else
            {
                errorProvider1.SetError(TModelocomboBox3, "");
            } 
        }

        private void TProveecomboBox1_Leave(object sender, EventArgs e)
        {
            incorrecto = false;
            if (TProveecomboBox1.Text=="")
            {
                errorProvider1.SetError(TProveecomboBox1, "Seleccione un proveedor");
                incorrecto = true;
            } 
            else
            {
                errorProvider1.SetError(TProveecomboBox1, "");
            } 
        }

        private void ObtenerProveedores(DataSet dsProvee)
        {
            TProveecomboBox1.Text = "Seleccione el proveedor";
            TProveecomboBox1.DataSource = dsProvee.Tables["Proveedores"];
            TProveecomboBox1.DisplayMember = dsProvee.Tables["Proveedores"].Columns[0].Caption.ToString();

        }
        private void TProveecomboBox1_Click(object sender, EventArgs e)
        {

            EN.ENPedidos enProvee = new EN.ENPedidos();
            DataSet dsProvee = new DataSet();
            dsProvee = enProvee.ObtenerListaProveedores();
            ObtenerProveedores(dsProvee);

        }

        private void TMarcacomboBox2_Click(object sender, EventArgs e)
        {
            
            EN.ENPedidos enMarc = new EN.ENPedidos();
            DataSet dsMarc = new DataSet();
            dsMarc = enMarc.ObtenerListaMarcas();
            ObtenerMarcas(dsMarc);
        
        }

        private void TModelocomboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }



        private void TModelocomboBox3_Click(object sender, EventArgs e)
        {

            EN.ENPedidos enMod = new EN.ENPedidos();
            DataSet dsMod = new DataSet();
            try
            {
                string marc = TMarcacomboBox2.Text.ToString();
                bool parar = false;
    
                for (int i = 0; i < 16 && parar != true; i++)
                {
     
                    if (numMarca.Tables["Marca"].Rows[i][1].ToString() == marc)
                    {
     
                        string num_marc = numMarca.Tables["Marca"].Rows[i][0].ToString();
                        parar = true;
                        
                        dsMod = enMod.ObtenerListaModelos(num_marc);
                      
                    }
                }
                ObtenerModelos(dsMod);
                
          }
          catch (Exception ex)
          {
                MessageBox.Show("Si desea cambiar el modelo debe cambiar la marca", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
            
        }

        private void TObservTextBox_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TObservTextBox.Text, @"^[A-Za-z\s]{3,100}$").Success)
            {
                errorProvider1.SetError(TObservTextBox, "Máximo 300 caracteres.");
                incorrecto = true;
            }
            if (TObservTextBox.Text == "")
            {
                errorProvider1.SetError(TObservTextBox, "Introduzca un comentario.");
            }
            else { errorProvider1.SetError(TObservTextBox, ""); }
        }

        private void TEnvioButtonOrdinario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TEnvioButtonUrgente_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void TIDtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TVendedorText_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TVendedorText.Text, @"^[A-Za-z\s]{3,100}$").Success)
            {
                errorProvider1.SetError(TVendedorText, "Máximo 100 caracteres.");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TVendedorText, ""); } 
        }

        private void TMarcacomboBox2_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void TVendedorText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void TButtonBorrar_Click(object sender, EventArgs e)
        {
            TVendedorText.Text = "";
            //Combobox
            TProveecomboBox1.Text ="";
            TMarcacomboBox2.Text="";
            TModelocomboBox3.Text="";
            //Radiobutton
            TEnvioButtonOrdinario.Checked = true;
            TObservTextBox.Text = "";
            numericUpDown1.Value = 1;
        }

        private void TButtonBuscar_Click(object sender, EventArgs e)
        {
            BuscarPedidos buscar = new BuscarPedidos();
            buscar.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class GestionClientes : Form
    {
        bool incorrecto = false; //variable global usada para validar campos
        private DataSet numProvincia;// usado en funcion TComboBoxCiudades_Click
        public EN.ENCliente enCliPub = new EN.ENCliente();
        public bool cambios = false;

        public GestionClientes()
        {
            InitializeComponent();

        }
        public GestionClientes(EN.ENCliente enCliente, string nombrebotonguardar,string provincias,string ciudades)
        {
            InitializeComponent();
            TTextBoxDNI.Enabled = false;
            DataSet dscli = new DataSet();
            dscli = enCliente.ObtenerDatosClienteConDni(enCliente.DNI);
            

            TTextBoxNombre.Text = enCliente.Nombre = dscli.Tables["Cliente"].Rows[0][1].ToString();
            TTextBoxApellidos.Text = enCliente.Apellidos =  dscli.Tables["Cliente"].Rows[0][2].ToString();
            TTextBoxDNI.Text = enCliente.DNI = dscli.Tables["Cliente"].Rows[0][0].ToString(); 
            enCliente.Telefono = int.Parse(dscli.Tables["Cliente"].Rows[0][3].ToString());
            TTextBoxTelefono.Text = enCliente.Telefono.ToString();
            TTextBoxEmail.Text = enCliente.Email = dscli.Tables["Cliente"].Rows[0][4].ToString();;
            TTextBoxDireccion.Text = enCliente.Direccion = dscli.Tables["Cliente"].Rows[0][5].ToString(); 
          /* if (provincias != null && ciudades != null)
            {
                TComboBoxProvincias.Items.Add(provincias);
                TComboBoxProvincias.SelectedIndex = 0;
                TComboBoxCiudades.Items.Add(ciudades);
                TComboBoxCiudades.SelectedIndex = 0;
            }*/
            enCliente.Provincia = dscli.Tables["Cliente"].Rows[0][6].ToString();
            enCliente.Ciudad = dscli.Tables["Cliente"].Rows[0][7].ToString();

            TComboBoxProvincias.Items.Add(enCliente.Provincia);
            TComboBoxProvincias.SelectedIndex = 0;
            TComboBoxCiudades.Items.Add(enCliente.Ciudad);
            TComboBoxCiudades.SelectedIndex = 0;

            enCliente.Tarifa = dscli.Tables["Cliente"].Rows[0][8].ToString();
            TComboBoxTarifa.Items.Add(enCliente.Tarifa);
            TComboBoxTarifa.SelectedIndex = 0;

            enCliente.Sexo = dscli.Tables["Cliente"].Rows[0][9].ToString();

            if (enCliente.Sexo == "V")
                TRadioButtonH.Checked = true;
            else if (enCliente.Sexo == "M")
                TRadioButtonM.Checked = true;


            TButtonGuardarCliente.Text = nombrebotonguardar; // importante le cambiamos el nombre al boton para saber que venimos del formulario buscar, y estamos editando no guardando uno nuevo
            TButtonGuardarCliente.Size = new Size(105, 24);

            ////////////////////////////////////////////////
            EN.ENProveedores provi = new EN.ENProveedores(); //PAra arreglar el problema de los combobox y que el de ciudad vaya a la primera sin pulsar primero provincia
            DataSet dsProv = new DataSet();
            dsProv = provi.ObtenerListaProvincias();
            //ObtenerProvincias(dsProv)

            numProvincia = new DataSet();
            numProvincia = dsProv;
            /////////////////////////////////////////////////

            
        }

        public GestionClientes(string nombre, string dni, string apell, string telef, string mail, string direc, string ciu, string prov, string tarifa, string sexo, string nombrebotonguardar)//constructor sobrecargado
        {//lo uso yo para editar un usuario a partir del formulario clientebuscar

            InitializeComponent();
            TTextBoxDNI.Enabled = false;
            TTextBoxNombre.Text = nombre;
            TTextBoxApellidos.Text = apell;
            TTextBoxDNI.Text = dni;
            TTextBoxTelefono.Text = telef;
            TTextBoxEmail.Text = mail;
            TTextBoxDireccion.Text = direc;

            TComboBoxProvincias.Items.Add(prov);
            TComboBoxProvincias.SelectedIndex = 0;
            TComboBoxCiudades.Items.Add(ciu);
            TComboBoxCiudades.SelectedIndex = 0;
    
            TComboBoxTarifa.Items.Add(tarifa);
            TComboBoxTarifa.SelectedIndex = 0;

            if (sexo == "V")
                TRadioButtonH.Checked = true;
            else if (sexo == "M")
                TRadioButtonM.Checked = true;
            ////////////////////////////////////////////////
            EN.ENProveedores provi = new EN.ENProveedores(); //PAra arreglar el problema de los combobox y que el de ciudad vaya a la primera sin pulsar primero provincia
            DataSet dsProv = new DataSet();
            dsProv = provi.ObtenerListaProvincias();
            //ObtenerProvincias(dsProv)

            numProvincia= new DataSet();
            numProvincia = dsProv;
            /////////////////////////////////////////////////

            TButtonGuardarCliente.Text = nombrebotonguardar; // importante le cambiamos el nombre al boton para saber que venimos del formulario buscar, y estamos editando no guardando uno nuevo
            TButtonGuardarCliente.Size = new Size(105, 24);
        }

        private void TTextBoxDNI_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxDNI.Text, @"^(([A-Z]\d{8})|(\d{8}[A-Z]))$").Success)
            {
                errorProvider1.SetError(TTextBoxDNI, "DNI incorrecto");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxDNI, ""); incorrecto = false; }
        }

        private void TTextBoxNombre_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxNombre.Text, @"^[A-Za-z]{3,15}$").Success)
            {
                errorProvider1.SetError(TTextBoxNombre, "Nombre incorrecto");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxNombre, ""); incorrecto = false; }
        }

        private void TTextBoxApellidos_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxApellidos.Text, @"^[A-Za-z\s]{3,40}$").Success)
            {
                errorProvider1.SetError(TTextBoxApellidos, "Apellidos incorrectos, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxApellidos, ""); incorrecto = false; }
        }

        private void TTextBoxTelefono_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxTelefono.Text, @"^[0-9]{9}$").Success)
            {
                errorProvider1.SetError(TTextBoxTelefono, "Telefono incorrecto, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxTelefono, ""); incorrecto = false; }
        }

        private void TTextBoxEmail_Leave(object sender, EventArgs e)
        {
            if (TTextBoxEmail.Text == "") errorProvider1.SetError(TTextBoxEmail, "");
            else if (!Regex.Match(TTextBoxEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                errorProvider1.SetError(TTextBoxEmail, "Email incorrectos, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxEmail, ""); incorrecto = false; }
        }

        private void TTextBoxDireccion_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxDireccion.Text, @"^[A-Za-z\s]{3,40}$").Success)
            {
                errorProvider1.SetError(TTextBoxDireccion, "Dirección incorrecta, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxDireccion, ""); incorrecto = false; }
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       /* private void TTextBoxCiudad_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxCiudad.Text, @"^[A-Za-z]{3,40}$").Success)
            {
                errorProvider1.SetError(TTextBoxCiudad, "Ciudad incorrecta, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxCiudad, ""); }
        }

        private void TTextBoxProvincia_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxProvincia.Text, @"^[A-Za-z]{3,40}$").Success)
            {
                errorProvider1.SetError(TTextBoxProvincia, "Provincia incorrecta, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxProvincia, ""); }
        }
        */

        private void TButtonGuardarCliente_Click(object sender, EventArgs e)
        {
            if (TTextBoxDNI.Text == "" || TTextBoxNombre.Text == "" || TTextBoxApellidos.Text == "" || TTextBoxTelefono.Text == "" ||
                 TTextBoxEmail.Text == "" || TTextBoxDireccion.Text == "" || TComboBoxCiudades.Text == null || TComboBoxProvincias.Text == null)
            {
                MessageBox.Show("Campos invalidos, no puede haber ninguno vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (incorrecto == true)
            {
                MessageBox.Show("Campos invalidos, reviselos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                EN.ENCliente enCliente = new EN.ENCliente();

                enCliente.DNI = TTextBoxDNI.Text; enCliente.Nombre = TTextBoxNombre.Text; enCliente.Apellidos = TTextBoxApellidos.Text; enCliente.Telefono = Int32.Parse(TTextBoxTelefono.Text);
                enCliente.Email = TTextBoxEmail.Text; enCliente.Direccion = TTextBoxDireccion.Text; enCliente.Ciudad = TComboBoxCiudades.Text; enCliente.Provincia = TComboBoxProvincias.Text;
                enCliente.Tarifa = TComboBoxTarifa.Text;

               /////////////////////////////de ADRI/////
                cambios = true;
                enCliPub.DNI = TTextBoxDNI.Text.ToString();
                enCliPub.Nombre = TTextBoxNombre.Text.ToString();
                enCliPub.Apellidos = TTextBoxApellidos.Text.ToString();
                enCliPub.Telefono = Int32.Parse(TTextBoxTelefono.Text.ToString());
                enCliPub.Email = TTextBoxEmail.Text.ToString();
                enCliPub.Direccion = TTextBoxDireccion.Text.ToString();
                /////////////////////////////////////////////
                
                
                
                if (TRadioButtonH.Checked == true) { enCliente.Sexo = "V"; }
                else if (TRadioButtonM.Checked == true) { enCliente.Sexo = "M"; }


                if (TButtonGuardarCliente.Text.ToString() == "Guardar")
                {
                    enCliente.AnyadirCliente();
                }
                else
                    enCliente.EditarCliente();

                this.Close();

            }

        }

        private void TButtonFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFich = new OpenFileDialog();
            OFich.Filter = "jpg (*.jpg)|*.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (OFich.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = System.Drawing.Image.FromFile(OFich.FileName);
        }


        private void ObtenerProvincias(DataSet dsProv)
        {
            TComboBoxProvincias.Text = "Seleccione Provincia";
            TComboBoxProvincias.DataSource = dsProv.Tables["Provincia"];
            TComboBoxProvincias.DisplayMember = dsProv.Tables["Provincia"].Columns[1].Caption.ToString(); // como dsProv lleva el id_prov y el nombre ponemos 1 que es la columna del nombre
            // TComboBoxProvincias.DisplayMember = dsProv.Tables["Provincia"].Columns[0].Caption.ToString(); // como dsProv lleva el id_prov y el nombre ponemos 1 que es la columna del nombre
        }

        private void ObtenerCiudades(DataSet dsCiu)
        {
            TComboBoxCiudades.Text = "Seleccione Ciudad";
            TComboBoxCiudades.DataSource = dsCiu.Tables["Ciudades"];
            TComboBoxCiudades.DisplayMember = dsCiu.Tables["Ciudades"].Columns[0].Caption.ToString();
        }
        private void TComboBoxProvincias_Click(object sender, EventArgs e)
        {
            EN.ENProveedores provincia = new EN.ENProveedores();
            DataSet dsProv = new DataSet();
            dsProv = provincia.ObtenerListaProvincias();
            ObtenerProvincias(dsProv);
        }

        private void TComboBoxProvincias_TextChanged(object sender, EventArgs e)
        {
            EN.ENProveedores enCiu = new EN.ENProveedores();
            DataSet dsCiu = new DataSet();
            try
            {
                if (TComboBoxProvincias.SelectedIndex > 0)
                {
                   
                    //MessageBox.Show("iusdhg");
                    string prov = TComboBoxProvincias.Text.ToString();
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
                else { TComboBoxCiudades.SelectedIndex = -1; TComboBoxCiudades.DataSource = null; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione primero una provincia", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TComboBoxCiudades_Click(object sender, EventArgs e)
        {
            EN.ENCliente enCiu = new EN.ENCliente();
            DataSet dsCiu = new DataSet();
            try
            {
                string prov = TComboBoxProvincias.Text.ToString();
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
               MessageBox.Show("Seleccione primero una provincia", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       /*  private void TButtonGuardarCliente_Click(object sender, EventArgs e) //DE ADRI
         {
             cambios = true;
             enCliPub.DNI = TTextBoxDNI.Text.ToString();
             enCliPub.Nombre = TTextBoxNombre.Text.ToString();
             enCliPub.Apellidos = TTextBoxApellidos.Text.ToString();
             enCliPub.Telefono = Int32.Parse(TTextBoxTelefono.Text.ToString());
             enCliPub.Email = TTextBoxEmail.Text.ToString();
             enCliPub.Direccion = TTextBoxDireccion.Text.ToString();
             Close();  
         }*/

        private void TComboBoxTarifa_Click(object sender, EventArgs e)
        {
            EN.ENCliente clien = new EN.ENCliente();
            DataSet dsTarifa = new DataSet();
            dsTarifa = clien.ConseguirTarifa();
            TComboBoxTarifa.DataSource = dsTarifa.Tables["Tarifas"];
            TComboBoxTarifa.DisplayMember = dsTarifa.Tables["Tarifas"].Columns[0].Caption.ToString();
        }

        private void GestionClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["GestionClienteBuscar"] != null)
            {
                Application.OpenForms["GestionClienteBuscar"].Activate();
            }
        }


    }
}

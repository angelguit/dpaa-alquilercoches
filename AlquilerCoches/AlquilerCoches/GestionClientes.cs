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
        public GestionClientes()
        {
            InitializeComponent();

        }
        public GestionClientes(EN.ENCliente enCliente, string nombrebotonguardar,string provincias,string ciudades)
        {
            InitializeComponent();
            TTextBoxDNI.Enabled = false;
            TTextBoxNombre.Text = enCliente.Nombre;
            TTextBoxApellidos.Text = enCliente.Apellidos;
            TTextBoxDNI.Text = enCliente.DNI;
            TTextBoxTelefono.Text = enCliente.Telefono.ToString();
            TTextBoxEmail.Text = enCliente.Email;
            TTextBoxDireccion.Text = enCliente.Direccion;

            TComboBoxProvincias.Items.Add(provincias);
            TComboBoxProvincias.SelectedIndex = 0;
            TComboBoxCiudades.Items.Add(ciudades);
            TComboBoxCiudades.SelectedIndex = 0;

            TButtonGuardarCliente.Text = nombrebotonguardar; // importante le cambiamos el nombre al boton para saber que venimos del formulario buscar, y estamos editando no guardando uno nuevo
            TButtonGuardarCliente.Size = new Size(105, 24);
        }
            
        public GestionClientes(string nombre,string dni, string apell, string telef, string mail, string direc, string ciu, string prov, string puesac, string nombrebotonguardar)//constructor sobrecargado
        {
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
           
            TButtonGuardarCliente.Text = nombrebotonguardar; // importante le cambiamos el nombre al boton para saber que venimos del formulario buscar, y estamos editando no guardando uno nuevo
            TButtonGuardarCliente.Size = new Size(105, 24);
        }

        bool incorrecto = false;
        private void TTextBoxDNI_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxDNI.Text, @"^(([A-Z]\d{8})|(\d{8}[A-Z]))$").Success)
            {
                errorProvider1.SetError(TTextBoxDNI, "DNI incorrecto");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxDNI, ""); }
        }

        private void TTextBoxNombre_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxNombre.Text, @"^[A-Za-z]{3,15}$").Success)
            {
                errorProvider1.SetError(TTextBoxNombre, "Nombre incorrecto");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxNombre, ""); }
        }

        private void TTextBoxApellidos_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxApellidos.Text, @"^[A-Za-z\s]{3,40}$").Success)
            {
                errorProvider1.SetError(TTextBoxApellidos, "Apellidos incorrectos, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxApellidos, ""); }
        }

        private void TTextBoxTelefono_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxTelefono.Text, @"^[0-9]{9}$").Success)
            {
                errorProvider1.SetError(TTextBoxTelefono, "Telefono incorrecto, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxTelefono, ""); }
        }

        private void TTextBoxEmail_Leave(object sender, EventArgs e)
        {
            if (TTextBoxEmail.Text == "") errorProvider1.SetError(TTextBoxEmail, "");
            else if (!Regex.Match(TTextBoxEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                errorProvider1.SetError(TTextBoxEmail, "Email incorrectos, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxEmail, ""); }
        }

        private void TTextBoxDireccion_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxDireccion.Text, @"^[A-Za-z\s]{3,40}$").Success)
            {
                errorProvider1.SetError(TTextBoxDireccion, "Dirección incorrecta, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxDireccion, ""); }
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TComboBoxProvincias_Click(object sender, EventArgs e)
        {
            if (TComboBoxCiudades.Items.Count > 0) //lo dejamos en blanco por si hubiera alguna ciudad, para realizar nueva busqueda de provincia
                TComboBoxCiudades.DataSource = null;

            EN.ENCliente enProv = new EN.ENCliente();
            DataSet dsProv = new DataSet();
            dsProv = enProv.ObtenerListaProvincias();
            ObtenerProvincias(dsProv);
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

        private void TButtonGuardarPersonal_Click(object sender, EventArgs e)
        {
            if (TTextBoxDNI.Text == "" || TTextBoxNombre.Text == "" || TTextBoxApellidos.Text == "" || TTextBoxTelefono.Text == "" ||
                 TTextBoxEmail.Text == "" || TTextBoxDireccion.Text == "" || TComboBoxCiudades.Text == null || TComboBoxProvincias.Text == null )
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
                
                if (TButtonGuardarCliente.Text.ToString() == "Guardar")
                {
                    enCliente.AnyadirCliente();
                }
                else
                    enCliente.EditarCliente();

                this.Close();

            }

        }

        private void TButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TButtonFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFich = new OpenFileDialog();
            OFich.Filter = "jpg (*.jpg)|*.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (OFich.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = System.Drawing.Image.FromFile(OFich.FileName);
        }

        private DataSet numProvincia;// usado en funcion TComboBoxCiudades_Click
        private void ObtenerProvincias(DataSet dsProv)
        {
            TComboBoxProvincias.Text = "Seleccione Provincia";
            TComboBoxProvincias.DataSource = dsProv.Tables["Provincia"];
            TComboBoxProvincias.DisplayMember = dsProv.Tables["Provincia"].Columns[1].Caption.ToString(); // como dsProv lleva el id_prov y el nombre ponemos 1 que es la columna del nombre
            // TComboBoxProvincias.DisplayMember = dsProv.Tables["Provincia"].Columns[0].Caption.ToString(); // como dsProv lleva el id_prov y el nombre ponemos 1 que es la columna del nombre


            numProvincia = new DataSet();
            numProvincia = dsProv;
        }

        private void ObtenerCiudades(DataSet dsCiu)
        {
            TComboBoxCiudades.Text = "Seleccione Ciudad";
            TComboBoxCiudades.DataSource = dsCiu.Tables["Ciudades"];
            TComboBoxCiudades.DisplayMember = dsCiu.Tables["Ciudades"].Columns[0].Caption.ToString();
        }
        private void TComboBoxProvincias_Click_1(object sender, EventArgs e)
        {
            if (TComboBoxCiudades.Items.Count > 0) //lo dejamos en blanco por si hubiera alguna ciudad, para realizar nueva busqueda de provincia
            {
                // MessageBox.Show("hola");
                if (TComboBoxCiudades.Items.Count == 1)
                    TComboBoxCiudades.Items.Clear();

                TComboBoxCiudades.DataSource = null;
            }

            EN.ENPersonal enProv = new EN.ENPersonal();
            DataSet dsProv = new DataSet();
            dsProv = enProv.ObtenerListaProvincias();
            ObtenerProvincias(dsProv);
        }

         private void TComboBoxCiudades_Click(object sender, EventArgs e)
        {
            EN.ENPersonal enCiu = new EN.ENPersonal();
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
                MessageBox.Show("Si desea cambiar la ciudad debe de volver a seleccionar una provincia", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }






       

 
    }
}

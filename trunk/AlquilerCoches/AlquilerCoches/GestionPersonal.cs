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
    public partial class GestionPersonal : Form
    {
        private string textoProvincia = "";
        bool incorrecto = false;//variable global usada para validar campos
        private DataSet numProvincia;// usado en funcion TComboBoxCiudades_Click

        public GestionPersonal()
        {
            InitializeComponent();
            EN.ENProveedores provi = new EN.ENProveedores();
            DataSet dsProv = new DataSet();
            dsProv = provi.ObtenerListaProvincias();
            //ObtenerProvincias(dsProv)

            numProvincia = new DataSet();
            numProvincia = dsProv;
        }
        public GestionPersonal(string nombre,string dni, string apell, string telef, string mail, string direc, string ciu, string prov, string puesac, string nombrebotonguardar)//constructor sobrecargado
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
            textoProvincia = TComboBoxProvincias.Text;

            EN.ENProveedores provi = new EN.ENProveedores();
            DataSet dsProv = new DataSet();
            dsProv = provi.ObtenerListaProvincias();
            //ObtenerProvincias(dsProv)

            numProvincia = new DataSet();
            numProvincia = dsProv;
           
            TTextBoxPuestoAc.Text = puesac;

            TButtonGuardarPersonal.Text = nombrebotonguardar; // importante le cambiamos el nombre al boton para saber que venimos del formulario buscar, y estamos editando no guardando uno nuevo
            TButtonGuardarPersonal.Size = new Size(105, 24);
        }

        
        
        private void TTextBoxDNI_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxDNI.Text, @"^(([A-Z]\d{8})|(\d{8}[A-Z]))$").Success)
            {
                errorProvider1.SetError(TTextBoxDNI, "DNI incorrecto, formato correcto: 00000000X");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxDNI, ""); incorrecto = false; }
        }

        private void TTextBoxNombre_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxNombre.Text, @"^[A-Za-zñÑáéíóúÁÉÍÓÚçÇ]{3,25}$").Success)
            {
                errorProvider1.SetError(TTextBoxNombre, "Nombre incorrecto");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxNombre, ""); incorrecto = false; }
        }

        private void TTextBoxApellidos_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxApellidos.Text, @"^[A-Za-zñÑáéíóúÁÉÍÓÚçÇ\s]{3,40}$").Success) // "\s" para que admita espacios en blanco
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
            if (!Regex.Match(TTextBoxEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                errorProvider1.SetError(TTextBoxEmail, "Email incorrectos, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxEmail, ""); incorrecto = false; }
        }
        private void TTextBoxDireccion_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxDireccion.Text, @"^[A-Za-zñÑáéíóúÁÉÍÓÚçÇ\s]{3,50}$").Success)
            {
                errorProvider1.SetError(TTextBoxDireccion, "Dirección incorrecta, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxDireccion, ""); incorrecto = false; }
        }

       /* private void TTextBoxCiudad_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TComboBoxCiudades.Text, @"^[A-Za-zñÑáéíóúÁÉÍÓÚ]{3,40}$").Success)
            {
                errorProvider1.SetError(TComboBoxCiudades, "Ciudad incorrecta, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TComboBoxCiudades, ""); incorrecto = false; }
        }
        */

        private void TComboboxProvincia_Leave(object sender, EventArgs e)
        {
            if (TComboBoxProvincias.SelectedIndex == -1)
            {
                errorProvider1.SetError(TComboBoxProvincias, "Provincia incorrecta, no puede estar vacio");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TComboBoxProvincias, ""); incorrecto = false; }
        }

        private void TTextBoxPuestoAc_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxPuestoAc.Text, @"^[A-Za-zñÑáéíóúÁÉÍÓÚçÇ\s]{3,100}$").Success) // "\s" para que admita espacios en blanco
            {
                errorProvider1.SetError(TTextBoxPuestoAc, "Puesto incorrecto, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxPuestoAc, ""); incorrecto = false; }
        }
      
       
        private void TButtonGuardarPersonal_Click(object sender, EventArgs e)
        {
            if (TTextBoxDNI.Text == "" || TTextBoxNombre.Text == "" || TTextBoxApellidos.Text == "" || TTextBoxTelefono.Text == "" ||
                 TTextBoxEmail.Text == "" || TTextBoxDireccion.Text == "" || TComboBoxProvincias.Text == "" ||
                TTextBoxPuestoAc.Text == "" || (TComboBoxProvincias.SelectedIndex == 0 && TComboBoxProvincias.Text != textoProvincia))
            {
                MessageBox.Show("Campos invalidos, no puede haber ninguno vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (incorrecto == true)
            {
                MessageBox.Show("Campos invalidos, reviselos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                EN.ENPersonal enPersonal = new EN.ENPersonal();

                enPersonal.DNI=TTextBoxDNI.Text; enPersonal.Nombre=TTextBoxNombre.Text; enPersonal.Apellidos=TTextBoxApellidos.Text; enPersonal.Telefono = Int32.Parse(TTextBoxTelefono.Text);
                enPersonal.Email = TTextBoxEmail.Text; enPersonal.Direccion = TTextBoxDireccion.Text; enPersonal.Ciudad = TComboBoxCiudades.Text; enPersonal.Provincia = TComboBoxProvincias.Text;
                enPersonal.PuestoAc = TTextBoxPuestoAc.Text; enPersonal.OtrosPuestos = TRichTextBoxOtrosPuestos.Text;

                if (TButtonGuardarPersonal.Text.ToString() == "Guardar")
                {
                    enPersonal.AnyadirPersonal();
                }
                else
                    enPersonal.EditarPersonal();

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

        private void TComboBoxProvincias_Click_1(object sender, EventArgs e)
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
                else { TComboBoxCiudades.SelectedIndex = -1; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione primero una provincia", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TComboBoxCiudades_Click(object sender, EventArgs e)
        {
            EN.ENProveedores enCiu = new EN.ENProveedores();
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

        private void GestionPersonal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["GestionPersonalBuscar"] != null)
            {
                Application.OpenForms["GestionPersonalBuscar"].Activate();
            }
        }            

           
    }
}

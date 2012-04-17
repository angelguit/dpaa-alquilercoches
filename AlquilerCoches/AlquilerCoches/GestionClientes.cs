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
            TTextBoxTelefono.Text = enCliente.Telefono;
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
            if (!Regex.Match(TTextBoxApellidos.Text, @"^[A-Za-z]{3,40}$").Success)
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
            if (!Regex.Match(TTextBoxDireccion.Text, @"^[A-Za-z]{3,40}$").Success)
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






       

 
    }
}

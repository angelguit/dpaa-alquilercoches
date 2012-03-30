﻿using System;
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
        public GestionPersonal()
        {
            InitializeComponent();
        }
        public GestionPersonal(string nombre,string dni, string apell, string telef, string mail, string direc, string ciu, string prov, string puesac)//constructor sobrecargado
        {
            InitializeComponent();
            TTextBoxNombre.Text = nombre;
            TTextBoxApellidos.Text = apell;
            TTextBoxDNI.Text = dni;
            TTextBoxTelefono.Text = telef;
            TTextBoxEmail.Text = mail;
            TTextBoxDireccion.Text = direc;
            TTextBoxCiudad.Text = ciu;
            TTextBoxProvincia.Text = prov;
            TTextBoxPuestoAc.Text = puesac;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TLabelTelefono1_Click(object sender, EventArgs e)
        {

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
            else {  errorProvider1.SetError(TTextBoxNombre, ""); }
        }

        private void TTextBoxApellidos_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxApellidos.Text, @"^[A-Za-z]{3,40}$").Success)
            {
                errorProvider1.SetError(TTextBoxApellidos, "Apellidos incorrectos, caracteres invalidos");
                incorrecto = true;
            }
            else {  errorProvider1.SetError(TTextBoxApellidos, ""); }
        }

        private void TTextBoxTelefono_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxTelefono.Text, @"^[0-9]{9}$").Success)
            {
                errorProvider1.SetError(TTextBoxTelefono, "Telefono incorrecto, caracteres invalidos");
                incorrecto = true;
            }
            else {  errorProvider1.SetError(TTextBoxTelefono, ""); }
        }


        private void TTextBoxEmail_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                errorProvider1.SetError(TTextBoxEmail, "Email incorrectos, caracteres invalidos");
                incorrecto = true;
            }
            else {  errorProvider1.SetError(TTextBoxEmail, ""); }
        }
        private void TTextBoxDireccion_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxDireccion.Text, @"^[A-Za-z]{3,40}$").Success)
            {
                errorProvider1.SetError(TTextBoxDireccion, "Dirección incorrecta, caracteres invalidos");
                incorrecto = true;
            }
            else {  errorProvider1.SetError(TTextBoxDireccion, ""); }
        }

        private void TTextBoxCiudad_Leave(object sender, EventArgs e)
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
            else {errorProvider1.SetError(TTextBoxProvincia, ""); }
        }

        private void TTextBoxPuestoAc_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxPuestoAc.Text, @"^[A-Za-z]{3,15}$").Success)
            {
                errorProvider1.SetError(TTextBoxPuestoAc, "Puesto incorrecto, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxPuestoAc, ""); }
        }

        private void TButtonGuardarPersonal_Click(object sender, EventArgs e)
        {
            if (TTextBoxDNI.Text == "" || TTextBoxNombre.Text == "" || TTextBoxApellidos.Text == "" || TTextBoxTelefono.Text == "" ||
                 TTextBoxEmail.Text == "" || TTextBoxDireccion.Text == "" || TTextBoxCiudad.Text == "" || TTextBoxProvincia.Text == "" ||
                TTextBoxPuestoAc.Text == "")
            {
                MessageBox.Show("Campos invalidos, no puede haber ninguno vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (incorrecto == true)
            {
                MessageBox.Show("Campos invalidos, reviselos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                string dni=TTextBoxDNI.Text; string nomb=TTextBoxNombre.Text; string apell=TTextBoxApellidos.Text; string telef = TTextBoxTelefono.Text;
                string mail = TTextBoxEmail.Text; string direcc = TTextBoxDireccion.Text; string ciud = TTextBoxCiudad.Text; string prov = TTextBoxProvincia.Text;
                string puestoac = TTextBoxPuestoAc.Text;

                //DataSet dsPersonGuarda = new DataSet();
                EN.ENPersonal enPerson = new EN.ENPersonal();
                bool correcto = enPerson.GuardarCambios(dni,nomb,apell,telef,mail,direcc,ciud,prov,puestoac);

                if (correcto == true)
                {
                    MessageBox.Show("modificacion correcta");
                }
                //TDataGridViewPersonal.DataSource = ds;
                //TDataGridViewPersonal.DataMember = "Personal";
                this.Close();

            }

        }

            private void TButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

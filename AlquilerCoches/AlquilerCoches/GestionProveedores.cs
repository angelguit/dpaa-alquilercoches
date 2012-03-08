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
    public partial class GestionProveedores : Form
    {
        public GestionProveedores()
        {
            InitializeComponent();
        }

        private void GestionProveedores_Load(object sender, EventArgs e)
        {

        }

        bool incorrecto= false;

        private void TTextBoxCIF_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxCIF.Text, @"^(([A-Z]\d{8})|(\d{8}[A-Z]))$").Success)
            {
                errorProvider1.SetError(TTextBoxCIF, "CIF incorrecto");
                incorrecto = true;
            }
            else 
            { 
                errorProvider1.SetError(TTextBoxCIF, ""); 
            }
        }
        private void TTextBoxTelefono_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxTelefono.Text, @"^[0-9]{9}$").Success)
            {
                errorProvider1.SetError(TTextBoxTelefono, "Telefono incorrecto, caracteres invalidos");
                incorrecto = true;
            }
            else 
            { 
                errorProvider1.SetError(TTextBoxTelefono, ""); 
            }
        }//@"^\d{5}$"; 

        private void TTextBoxCPostal_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxCPostal.Text, @"^\d{5}$").Success)
            {
                MessageBox.Show("sodiugh");
                errorProvider1.SetError(TTextBoxCPostal, "Codigo Postal incorrecto");
                incorrecto = true;
            }
            else
            {
                MessageBox.Show("sodiugh2333333333");
                errorProvider1.SetError(TTextBoxCPostal, "");
            }
        }
        private void TTextBoxEmail_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                errorProvider1.SetError(TTextBoxEmail, "Email incorrectos, caracteres invalidos");
                incorrecto = true;
            }
            else 
            {
                errorProvider1.SetError(TTextBoxEmail, ""); 
            }
        }
    }
}

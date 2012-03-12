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
            if (!Regex.Match(TTextBoxCIF.Text, @"^(([A-Z]\d{8}))$").Success)
            {
                errorProvider1.SetError(TTextBoxCIF, "Formato correcto: X00000000");
                incorrecto = true;
            }
            else 
            { 
                errorProvider1.SetError(TTextBoxCIF, ""); 
            }
        }

        private void TTextBoxEmail_Leave_1(object sender, EventArgs e)
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

        private void TTextBoxCPostal_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxCPostal.Text, @"^\d{5}$").Success)
            {
                errorProvider1.SetError(TTextBoxCPostal, "Formato correcto: 00000");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxCPostal, "");
            }
        }

        private void TTextBoxTelefono_Leave_1(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxTelefono.Text, @"^[0-9]{9}$").Success)
            {
                errorProvider1.SetError(TTextBoxTelefono, "Formato correcto: 000000000");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxTelefono, "");
            }
        }

        private void TTextBoxProvincia_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxProvincia.Text, @"^[A-Za-z]{3,20}$").Success)
            {
                errorProvider1.SetError(TTextBoxProvincia, "Entre 3 y 20 caracteres");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxMarca, "");
            }
        }

        private void TTextBoxCiudad_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxCiudad.Text, @"^[A-Za-z]{3,20}$").Success)
            {
                errorProvider1.SetError(TTextBoxCiudad, "Entre 3 y 20 caracteres");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxCiudad, "");
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

        private void TTextBoxCalle_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxCalle.Text, @"^[A-Za-z]{3,30}$").Success)
            {
                errorProvider1.SetError(TTextBoxCalle, "Entre 3 y 30 caracteres");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxCiudad, "");
            }
        }

        private void TTextBoxNumero_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxNumero.Text, @"^\d{1,5}$").Success)
            {
                errorProvider1.SetError(TTextBoxNumero, "Entre 1 y 5 digitos");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxNumero, "");
            }
        }

        private void TButtonGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (TTextBoxCalle.Text == "" || TTextBoxCIF.Text == "" || TTextBoxCiudad.Text == ""
                || TTextBoxCPostal.Text == "" || TTextBoxEmail.Text == "" || TTextBoxMarca.Text == ""
                || TTextBoxTelefono.Text == "" || TTextBoxHorario.Text == "" || TTextBoxNumero.Text == "" || TTextBoxProvincia.Text == "")
            {
                MessageBox.Show("No pueden haber campos vacios");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TTextBoxMarca_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxMarca.Text, @"^[A-Za-z]{3,15}$").Success)
            {
                errorProvider1.SetError(TTextBoxMarca, "Entre 3 y 15 caracteres");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxMarca, "");
            }
        }

    }
}

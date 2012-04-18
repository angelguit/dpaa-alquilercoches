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
    public partial class EditarVentas : Form
    {
        bool incorrecto = false;
        private EN.ENVentas ventas = new EN.ENVentas();

        public EditarVentas()
        {
            InitializeComponent();
            limpiaFormulario();
           // rellenaMarcas();
        }

        public void limpiaFormulario()
        {
            ventas.ClearEnVentas();
            TListBoxMarcas.Items.Clear();
            TListBoxModelos.Items.Clear();
            TListBoxMatriculas.Items.Clear();
            TTextBoxMatricula.Text = "";
            TTextBoxMarca.Text = "";
            TTextBoxModelo.Text = "";
            TTextBoxKm.Text = "";
            TCheckBoxGarantia.Checked = false;
            TTextBoxMeses.Text = "";
            TTextBoxPrecioVenta.Text = "";
            errorProvider1.Clear();
            TTextBoxMeses.Enabled = false;
            TGroupBoxDatosVehiculo.Enabled = false;
            TButtonBorrar.Enabled = false;
        }

        private void TTextBoxMeses_Click(object sender, EventArgs e)
        {
            TTextBoxMeses.Text = "";
        }

        private void TCheckBoxGarantia_CheckedChanged(object sender, EventArgs e)
        {
            if (TCheckBoxGarantia.Checked)
            {
                TTextBoxMeses.Enabled = true;
            }
            else
            {
                TTextBoxMeses.Enabled = false;
                TTextBoxMeses.Text = "Meses";
                errorProvider1.SetError(TTextBoxMeses, "");
                incorrecto = false;
            }
        }

        private void TextBoxMatricula_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxMatricula.Text, @"^\d{4}-[A-Za-z]{3}$").Success)
            {
                errorProvider1.SetError(TTextBoxMatricula, "Matrícula incorrecta. Formato 0000-XXX");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxMatricula, "");
                incorrecto = false;
            }
        }

        private void TTextBoxMarca_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxMarca.Text, @"^\w+$").Success)
            {
                errorProvider1.SetError(TTextBoxMarca, "Marca incorrecta.");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxMarca, "");
                incorrecto = false;
            }
        }

        private void TTextBoxModelo_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxModelo.Text, @"^\w+$").Success)
            {
                errorProvider1.SetError(TTextBoxModelo, "Modelo incorrecto.");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxModelo, "");
                incorrecto = false;
            }
        }

        private void TTextBoxKm_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxKm.Text, @"^\d{1,6}$").Success)
            {
                errorProvider1.SetError(TTextBoxKm, "KM incorrectos");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxKm, "");
                incorrecto = false;
            }
        }

        private void TTextBoxMeses_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxMeses.Text, @"^\d{1,2}$").Success)
            {
                errorProvider1.SetError(TTextBoxMeses, "Meses de garantía incorrectos");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxMeses, "");
                incorrecto = false;
            }
        }

        private void TTextBoxPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxPrecioVenta.Text, @"^\d{1,6}$").Success)
            {
                errorProvider1.SetError(TTextBoxPrecioVenta, "Precio incorrecto");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxPrecioVenta, "");
                incorrecto = false;
            }
        }

        private void TGroupBoxDatosVehiculo_Enter(object sender, EventArgs e)
        {

        }

    }
}

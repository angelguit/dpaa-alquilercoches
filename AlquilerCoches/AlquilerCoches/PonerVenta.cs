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
    public partial class PonerVenta : Form
    {
        bool incorrecto = false;
        private EN.ENVentas ventas = new EN.ENVentas();

        public PonerVenta()
        {
            InitializeComponent();
            limpiaFormulario();
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
            TTextBoxAnyo.Text = "";
            TTextBoxKm.Text = "";
            TCheckBoxGarantia.Checked = false;
            TTextBoxMeses.Text = "";
            TTextBoxPrecioVenta.Text = "";
            errorProvider1.Clear();
            TTextBoxMeses.Enabled = false;
            TGroupBoxDatosVehiculo.Enabled = false;
        }

        private void PonerVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Dispose();
        }

        private void TButtonVender_MouseHover(object sender, EventArgs e)
        {
            TLabelAviso.Text="*El precio de alquiler se pondrá a 0 automáticamente al vender";
        }

        private void TButtonVender_MouseLeave(object sender, EventArgs e)
        {
            TLabelAviso.Text = "";
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

        private void TTextBoxKm_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxKm.Text, @"^\d{1,6}$").Success)
            {
                errorProvider1.SetError(TTextBoxKm, "KM incorrectos, debe contener solo numeros y no más de 6 dígitos.");
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
                errorProvider1.SetError(TTextBoxMeses, "Meses de garantía incorrectos, debe contener solo números y como mucho 2 cifras.");
                incorrecto = true;
            }
            else
            {
                if (Int32.Parse(TTextBoxMeses.Text) < 0)
                {
                    errorProvider1.SetError(TTextBoxMeses, "Solo se adminten valores mayores que cero");
                }
                else
                {
                    errorProvider1.SetError(TTextBoxMeses, "");
                    incorrecto = false;
                }
            }
        }

        private void TTextBoxPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxPrecioVenta.Text, @"^\d{1,6}$").Success)
            {
                errorProvider1.SetError(TTextBoxPrecioVenta, "Precio incorrecto, debe contener solo números y no más de 6 cifras.");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TTextBoxPrecioVenta, "");
                incorrecto = false;
            }
        }

        private void TButtonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TButtonVender_Click(object sender, EventArgs e)
        {
            EN.ENVehiculo vehiculo = new EN.ENVehiculo();
            
            
            vehiculo.Matricula = TTextBoxMatricula.Text;
            vehiculo.BorrarVehiculo();
        }

        private void TButtonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar?\n Se perderan los cambios no guardados", "¿CANCELAR?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                limpiaFormulario();
                TGroupBoxDatosVehiculo.Enabled = false;
            }
        }



    }
}

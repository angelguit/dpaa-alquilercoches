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
    public partial class GestionVehiculos : Form
    {
        public GestionVehiculos()
        {
            InitializeComponent();
        }

        public void setTipo(string Option)
        {
            switch (Option)
            {
                case "Editar":
                    break;
                case "Buscar":
                    break;
                case "Insertar":
                    break;
                case "Borrar":
                    break;
            }
        }

        private void TListViewMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TGroupBoxDatosVehiculo_Enter(object sender, EventArgs e)
        {

        }

        private void TLabel_Click(object sender, EventArgs e)
        {

        }

        private void GestionVehiculos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Dispose();
        }

        private void TTextBoxMatricula_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxMatricula.Text, @"^\d{4}-\w$"))
            {
                errorProvider1.SetError(TTextBoxMatricula, "Formato de la matricula: dddd-x");
            }
            else
            {
                errorProvider1.SetError(TTextBoxMatricula, "");
            }
                
        }

        private void TTextBoxMarca_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxMarca.Text, @"^\w+$"))
            {
                errorProvider1.SetError(TTextBoxMarca, "Solo se adminten nombres con letras");
            }
            else
            {
                errorProvider1.SetError(TTextBoxMarca, "");
            }
        }

        private void TTextBoxModelo_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxModelo.Text, @"^[\w\d]+$"))
            {
                errorProvider1.SetError(TTextBoxModelo, "Solo se adminten nombres con letras y numeros");
            }
            else
            {
                errorProvider1.SetError(TTextBoxModelo, "");
            }
        }

        private void TTextBoxAnyo_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxAnyo.Text, @"^\d{4}$"))
            {
                errorProvider1.SetError(TTextBoxAnyo, "Solo se adminten numeros");
            }
            else
            {
                if (Int32.Parse(TTextBoxAnyo.Text) < 1960 || Int32.Parse(TTextBoxAnyo.Text) > DateTime.Now.Year)
                {
                    errorProvider1.SetError(TTextBoxAnyo, "Solo se adminten anyos entre 1960-actual");
                }
                else
                {
                    errorProvider1.SetError(TTextBoxAnyo, "");
                }
            }
        }

        private void TTextBoxPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxPrecioCompra.Text, @"^\d+$"))
            {
                errorProvider1.SetError(TTextBoxPrecioCompra, "Solo se adminten numeros");
            }
            else
            {
                if (Int32.Parse(TTextBoxPrecioCompra.Text) < 0)
                {
                    errorProvider1.SetError(TTextBoxPrecioCompra, "Solo se adminten valores mayores que cero");
                }
                else
                {
                    errorProvider1.SetError(TTextBoxPrecioCompra, "");
                }
            }
        }

        private void TTextBoxPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxPrecioVenta.Text, @"^\d+$"))
            {
                errorProvider1.SetError(TTextBoxPrecioVenta, "Solo se adminten numeros");
            }
            else
            {
                if (Int32.Parse(TTextBoxPrecioVenta.Text) < 0)
                {
                    errorProvider1.SetError(TTextBoxPrecioVenta, "Solo se adminten valores mayores que cero");
                }
                else
                {
                    errorProvider1.SetError(TTextBoxPrecioVenta, "");
                }
            }
        }

        private void TTextBoxPrecioAlquiler_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxPrecioAlquiler.Text, @"^\d+$"))
            {
                errorProvider1.SetError(TTextBoxPrecioAlquiler, "Solo se adminten numeros");
            }
            else
            {
                if (Int32.Parse(TTextBoxPrecioAlquiler.Text) < 0)
                {
                    errorProvider1.SetError(TTextBoxPrecioAlquiler, "Solo se adminten valores mayores que cero");
                }
                else
                {
                    errorProvider1.SetError(TTextBoxPrecioAlquiler, "");
                }
            }
        }

        private void TTextBoxKM_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxKM.Text, @"^\d+$"))
            {
                errorProvider1.SetError(TTextBoxKM, "Solo se adminten numeros");
            }
            else
            {
                if (Int32.Parse(TTextBoxKM.Text) < 0)
                {
                    errorProvider1.SetError(TTextBoxKM, "Solo se adminten valores mayores que cero");
                }
                else
                {
                    errorProvider1.SetError(TTextBoxKM, "");
                }
            }
        }

        private void TTextBoxGarantia_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxGarantia.Text, @"^\d+$"))
            {
                errorProvider1.SetError(TTextBoxGarantia, "Solo se adminten numeros");
            }
            else
            {
                if (Int32.Parse(TTextBoxGarantia.Text) < 0)
                {
                    errorProvider1.SetError(TTextBoxGarantia, "Solo se adminten valores mayores que cero");
                }
                else
                {
                    errorProvider1.SetError(TTextBoxGarantia, "");
                }
            }
        }

        private void TListBoxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TListBoxModelos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

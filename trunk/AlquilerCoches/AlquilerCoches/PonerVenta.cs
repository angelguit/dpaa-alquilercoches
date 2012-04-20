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
        public bool incorrecto = false;
        private EN.ENVentas ventas = new EN.ENVentas();
        private EN.ENVehiculo vehiculos = new EN.ENVehiculo();

        public PonerVenta()
        {
            InitializeComponent();
            limpiaFormulario();
            rellenaMarcas();
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
            TButtonCancelar.Enabled = false;
            TButtonVender.Enabled = false;
        }

        private void PonerVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Dispose();
        }

        private void TButtonVender_MouseHover(object sender, EventArgs e)
        {
            TLabelAviso.Text="*El vehículo se eliminará de la lista de alquiler automáticamente al vender.";
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
                errorProvider1.SetError(TTextBoxKm, "KM incorrectos, no puede estar vacío, debe contener solo numeros y no más de 6 dígitos.");
                incorrecto = true;
            }
            else
            {
                if (TTextBoxKm.Text == "")
                {
                    errorProvider1.SetError(TTextBoxKm, "KM incorrectos, no puede estar vacío, debe contener solo numeros y no más de 6 dígitos.");
                    incorrecto = true;
                }
                else
                {
                    errorProvider1.SetError(TTextBoxKm, "");
                    incorrecto = false;
                }
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
                errorProvider1.SetError(TTextBoxPrecioVenta, "Precio incorrecto, no puede estar vacío, debe contener solo números y no más de 6 cifras.");
                incorrecto = true;
            }
            else
            {
                if (TTextBoxPrecioVenta.Text == "")
                {
                    errorProvider1.SetError(TTextBoxPrecioVenta, "Precio incorrecto, no puede estar vacío, debe contener solo números y no más de 6 cifras.");
                    incorrecto = true;
                }
                else
                {
                    errorProvider1.SetError(TTextBoxPrecioVenta, "");
                    incorrecto = false;
                }
            }
        }

        private void TButtonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TButtonVender_Click(object sender, EventArgs e)
        {
            //MODIFICAR COSAS PARA AÑADIR LA VENTA A LA BD
            if (incorrecto == false && TTextBoxPrecioVenta.Text != "")
            {
                guardaCampos();
                ventas.AnyadirVenta();

                vehiculos.ClearEnVehiculo();
                vehiculos.Matricula = TTextBoxMatricula.Text;
                vehiculos.BorrarVehiculo();

                limpiaFormulario();
                rellenaMarcas();
            }
            else
            {
                MessageBox.Show("Hay algún error en los datos introducidos.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void TButtonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar?\n Se perderan los cambios no guardados", "¿CANCELAR?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                limpiaFormulario();
                TGroupBoxDatosVehiculo.Enabled = false;
                rellenaMarcas();
            }
        }

        private void rellenaMarcas()
        {
            TListBoxMarcas.Items.Clear();
            TListBoxModelos.Items.Clear();
            TListBoxMatriculas.Items.Clear();
            vehiculos.ObtenerMarcas();
            TListBoxMarcas.Items.AddRange(vehiculos.ListaMarcas.ToArray());
        }

        void rellenaCampos()
        {
            TGroupBoxDatosVehiculo.Enabled = true;
            TButtonCancelar.Enabled = true;
            TButtonVender.Enabled = true;

            TTextBoxMatricula.Text = vehiculos.Matricula;
            TTextBoxMarca.Text = vehiculos.Marca;
            TTextBoxModelo.Text = vehiculos.Modelo;
            TTextBoxKm.Text = vehiculos.KM.ToString();
        }

        void guardaCampos()
        {
            ventas.Matricula = TTextBoxMatricula.Text;
            ventas.Marca = TTextBoxMarca.Text;
            ventas.Modelo = TTextBoxModelo.Text;
            if (TCheckBoxGarantia.Checked == true)
            {
                ventas.Garantia = TTextBoxMeses.Text;
            }
            else
            {
                ventas.Garantia = "0";
            }
            ventas.KM = TTextBoxKm.Text;
            ventas.PrecioVenta = TTextBoxPrecioVenta.Text;
        }

        private void TListBoxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TListBoxMarcas.SelectedIndex != -1)
            {
                TListBoxModelos.Items.Clear();
                TListBoxMatriculas.Items.Clear();
                vehiculos.Marca = TListBoxMarcas.Items[TListBoxMarcas.SelectedIndex].ToString();
                vehiculos.ObtenerModelo();
                TListBoxModelos.Items.AddRange(vehiculos.ListaModelos.ToArray());
            }
        }

        private void TListBoxModelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TListBoxModelos.SelectedIndex != -1)
            {
                TListBoxMatriculas.Items.Clear();
                vehiculos.Modelo = TListBoxModelos.Items[TListBoxModelos.SelectedIndex].ToString();
                vehiculos.ObtenerMatriculas();
                TListBoxMatriculas.Items.AddRange(vehiculos.ListaMatriculas.ToArray());
            }
        }

        private void TListBoxMatriculas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (TListBoxMatriculas.SelectedIndex != -1)
            {
                vehiculos.Matricula = TListBoxMatriculas.Items[TListBoxMatriculas.SelectedIndex].ToString();
                vehiculos.ObtenerDatosVehiculos();
                rellenaCampos();
            }
        }

        private void TTextBoxMeses_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class EditarVentas : Form
    {
        public bool incorrecto = false;
        private EN.ENVentas ventas = new EN.ENVentas();

        public EditarVentas()
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
            TButtonBorrar.Enabled = false;
            TTextBoxMatricula.Enabled = false;
            TCheckBoxReservado.Checked = false;
            TComboBoxCategoria.SelectedIndex = -1;
        }

        private void rellenaMarcas()
        {
            TListBoxMarcas.Items.Clear();
            TListBoxModelos.Items.Clear();
            TListBoxMatriculas.Items.Clear();
            ventas.ObtenerMarcas();
            TListBoxMarcas.Items.AddRange(ventas.ListaMarcas.ToArray());
        }

        void rellenaCampos()
        {
            TGroupBoxDatosVehiculo.Enabled = true;

            TTextBoxMatricula.Text = ventas.Matricula;
            TTextBoxMarca.Text = ventas.Marca;
            TTextBoxModelo.Text = ventas.Modelo;
            TTextBoxKm.Text = ventas.KM.ToString();
            if (ventas.Garantia != "" && ventas.Garantia != "0")
            {
                TCheckBoxGarantia.Checked = true;
                TTextBoxMeses.Text = ventas.Garantia;
            }
            else
            {
                TCheckBoxGarantia.Checked = false;
                TTextBoxMeses.Text = "Meses";
            }
            TTextBoxPrecioVenta.Text = ventas.PrecioVenta.ToString();
            if (ventas.Reservado != 0)
            {
                TCheckBoxReservado.Checked = true;
            }
            else
            {
                TCheckBoxReservado.Checked = false;
            }

            if (ventas.Categoria == 1)
            {
                TComboBoxCategoria.SelectedIndex = 0;
            }
            else
            {
                if (ventas.Categoria == 2)
                {
                    TComboBoxCategoria.SelectedIndex = 1;
                }
                else
                {
                    if (ventas.Categoria == 3)
                    {
                        TComboBoxCategoria.SelectedIndex = 2;
                    }
                    else
                        if (ventas.Categoria == 4)
                        {
                            TComboBoxCategoria.SelectedIndex = 3;
                        }
                }
            }
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
            if (TCheckBoxReservado.Checked == true)
            {
                ventas.Reservado = 1;
            }
            else
            {
                ventas.Reservado = 0;
            }
            if (TComboBoxCategoria.SelectedIndex == 0)
            {
                ventas.Categoria = 1;
            }
            else
            {
                if (TComboBoxCategoria.SelectedIndex == 1)
                {
                    ventas.Categoria = 2;
                }
                else
                {
                    if (TComboBoxCategoria.SelectedIndex == 2)
                    {
                        ventas.Categoria = 3;
                    }
                    else
                    {
                        if (TComboBoxCategoria.SelectedIndex == 3)
                        {
                            ventas.Categoria = 4;
                        }
                    }
                }
            }
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
            if (!Regex.Match(TTextBoxMatricula.Text, @"^\d{4}\w{3}$").Success)
            {
                errorProvider1.SetError(TTextBoxMatricula, "Matrícula incorrecta. Formato 0000XXX");
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
            if (!Regex.Match(TTextBoxMarca.Text, @"^[\w\d\s]+$").Success)
            {
                errorProvider1.SetError(TTextBoxMarca, "Marca incorrecta, solo admite numeros y letras.");
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
            if (!Regex.Match(TTextBoxModelo.Text, @"^[\w\d\s]+$").Success)
            {
                errorProvider1.SetError(TTextBoxModelo, "Modelo incorrecto, solo admite numeros y letras.");
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

        private void TButtonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar?\n Se perderan los cambios no guardados", "¿CANCELAR?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                limpiaFormulario();
                TGroupBoxDatosVehiculo.Enabled = false;
                rellenaMarcas();
            }
        }

        private void TListBoxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TListBoxMarcas.SelectedIndex != -1)
            {
                TTextBoxMatricula.Text = "";
                TTextBoxMarca.Text = "";
                TTextBoxModelo.Text = "";
                TTextBoxKm.Text = "";
                TCheckBoxGarantia.Checked = false;
                TCheckBoxReservado.Checked = false;
                TComboBoxCategoria.SelectedIndex = -1;
                TTextBoxMeses.Text = "";
                TTextBoxPrecioVenta.Text = "";
                errorProvider1.Clear();
                TTextBoxMeses.Enabled = false;
                TGroupBoxDatosVehiculo.Enabled = false;
                TButtonBorrar.Enabled = false;
                TTextBoxMatricula.Enabled = false;
                TListBoxModelos.Items.Clear();
                TListBoxMatriculas.Items.Clear();
                ventas.Marca = TListBoxMarcas.Items[TListBoxMarcas.SelectedIndex].ToString();
                ventas.ObtenerModelo();
                TListBoxModelos.Items.AddRange(ventas.ListaModelos.ToArray());
            }
        }

        private void TListBoxModelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TListBoxModelos.SelectedIndex != -1)
            {
                TTextBoxMatricula.Text = "";
                TTextBoxMarca.Text = "";
                TTextBoxModelo.Text = "";
                TTextBoxKm.Text = "";
                TCheckBoxReservado.Checked = false;
                TCheckBoxGarantia.Checked = false;
                TComboBoxCategoria.SelectedIndex = -1;
                TTextBoxMeses.Text = "";
                TTextBoxPrecioVenta.Text = "";
                errorProvider1.Clear();
                TTextBoxMeses.Enabled = false;
                TGroupBoxDatosVehiculo.Enabled = false;
                TButtonBorrar.Enabled = false;
                TTextBoxMatricula.Enabled = false;
                TListBoxMatriculas.Items.Clear();
                ventas.Modelo = TListBoxModelos.Items[TListBoxModelos.SelectedIndex].ToString();
                ventas.ObtenerMatriculas();
                TListBoxMatriculas.Items.AddRange(ventas.ListaMatriculas.ToArray());
            }
        }

        private void TListBoxMatriculas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (TListBoxMatriculas.SelectedIndex != -1)
            {
                ventas.Matricula = TListBoxMatriculas.Items[TListBoxMatriculas.SelectedIndex].ToString();
                ventas.ObtenerDatosVehiculos();
                rellenaCampos();
                TButtonBorrar.Enabled = true;
            }
        }

        private void TButtonAceptar_Click(object sender, EventArgs e)
        {
            if (incorrecto == false && (TTextBoxPrecioVenta.Text != "" && TTextBoxModelo.Text != "" && TTextBoxMatricula.Text != "" && TTextBoxMarca.Text != "" && TTextBoxKm.Text != ""))
            {
                if (MessageBox.Show("¿Desea guardar cambios?\n Se sobrescribirán los datos.", "¿SOBRESCRIBIR?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    guardaCampos();
                    ventas.EditarVentas();
                    limpiaFormulario();
                    rellenaMarcas();
                }
            }
            else
            {
                MessageBox.Show("Hay algún error en los datos introducidos.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void TButtonBorrar_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("¿Desea borrar?\n Se perderan los datos del vehículo.", "¿BORRAR?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
           {
                ventas.ClearEnVentas();
                ventas.Matricula = TTextBoxMatricula.Text;
                ventas.BorrarVentas();
                limpiaFormulario();
                rellenaMarcas();
           }
            
        }

        private void TGroupBoxDatosVehiculo_Enter(object sender, EventArgs e)
        {

        }

    }
}

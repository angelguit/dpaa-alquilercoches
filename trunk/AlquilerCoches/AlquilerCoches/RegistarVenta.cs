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
    public partial class RegistrarVenta : Form
    {
        public bool incorrecto = false;
        private EN.ENVentas ventas = new EN.ENVentas();
        private EN.ENCliente cliente = new EN.ENCliente();

        public RegistrarVenta()
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
            //TButtonBorrar.Enabled = false;
            TTextBoxMatricula.Enabled = false;
        }

        private void rellenaClientes()
        {
            TListBoxClientes.Items.Clear();


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
        }

        //MODIFICAR!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
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
                //TButtonBorrar.Enabled = true;
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

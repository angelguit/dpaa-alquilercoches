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
        private EN.ENVentasRealizadas realizadas = new EN.ENVentasRealizadas();
        private EN.ENVentas ventas = new EN.ENVentas();

        public RegistrarVenta()
        {
            InitializeComponent();
            limpiaFormulario();
            rellenaMarcas();
        }

        public void limpiaFormulario()
        {
            ventas.ClearEnVentas();
            realizadas.ClearEnVentas();
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
            TTextBoxMatricula.Enabled = false;
            TTextBoxApellidos.Text = "";
            TTextBoxDNI.Text = "";
            TTextBoxNombre.Text = "";
            TDateTimePicker1.Text = "";
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

        
        void guardaCampos()
        {
            realizadas.Matricula = TTextBoxMatricula.Text;
            realizadas.Marca = TTextBoxMarca.Text;
            realizadas.Modelo = TTextBoxModelo.Text;
            if (TCheckBoxGarantia.Checked == true)
            {
                realizadas.Garantia = TTextBoxMeses.Text;
            }
            else
            {
                realizadas.Garantia = "0";
            }
            realizadas.DNI = TTextBoxDNI.Text;
            realizadas.PrecioVenta = TTextBoxPrecioVenta.Text;
            realizadas.Fecha = TDateTimePicker1.Text.ToString();
            realizadas.Facturado = "0";
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
            if (incorrecto == false && (TTextBoxDNI.Text !="" || TTextBoxNombre.Text !=""))
            {
                if (MessageBox.Show("¿Desea registrar venta?\n Se borrará el coche de la lista de ventas.", "¿REGISTRAR?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    guardaCampos();
                    realizadas.AnyadirVenta();

                    ventas.ClearEnVentas();
                    ventas.Matricula = TTextBoxMatricula.Text;
                    ventas.BorrarVentas(); 

                    FacturaVentas Formu = new FacturaVentas(realizadas);
                    Formu.StartPosition = FormStartPosition.CenterScreen;
                    Formu.MdiParent = this.MdiParent;
                    Formu.Show(); 
 
                    limpiaFormulario();
                    rellenaMarcas();
                    
                }
            }
            else
            {
                MessageBox.Show("Hay algún error en los datos introducidos.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void TTextBoxDNI_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxDNI.Text, @"^(([A-Z]\d{8})|(\d{8}[A-Z]))$").Success)
            {
                errorProvider1.SetError(TTextBoxDNI, "DNI incorrecto, formato correcto: 00000000X");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxDNI, ""); incorrecto = false; }
        }

        private void TButtonBuscar_Click(object sender, EventArgs e)
        {
            EN.ENCliente cliente = new EN.ENCliente();
            DataSet cli = new DataSet();

            if (incorrecto == false)
            {
                string dni = TTextBoxDNI.Text.ToString();

                cliente.DNI = TTextBoxDNI.Text;
                cli = cliente.ObtenerDatosClienteConDni(TTextBoxDNI.Text);
                if (cli.Tables["Cliente"].Rows.Count != 1)
                {
                    MessageBox.Show("No se encuentra ningún cliente.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    incorrecto = true;
                    TTextBoxNombre.Text = "";
                    TTextBoxApellidos.Text = "";
                }
                else
                {
                    cliente.RellenarCliente();
                    incorrecto = false;
                    TTextBoxNombre.Text = cliente.Nombre;
                    TTextBoxApellidos.Text = cliente.Apellidos;
                }
            }
        }
    }
}

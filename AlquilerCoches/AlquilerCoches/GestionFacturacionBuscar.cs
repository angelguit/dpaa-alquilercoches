using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlquilerCoches
{
    public partial class GestionFacturacionBuscar : Form
    {
        EN.ENCliente enCliente = new EN.ENCliente();
        public GestionFacturacionBuscar()
        {
            InitializeComponent();
            dataGridBuscarFacturas.Visible = false;
        }

        private void TButtonBuscarCliente_Click(object sender, EventArgs e)
        {
            GestionClientesBuscar F1 = new GestionClientesBuscar(false);
            F1.ShowDialog();
            enCliente = F1.enClientePub;
            TButtonBuscarCliente.Visible = false;
            TLabelCliente.Text = "Cliente: " + enCliente.Nombre + enCliente.Apellidos;
            TLabelCliente.Visible = true;
            TButtonCambiarCliente.Visible = true;
            TButtonQuitarCliente.Visible = true;
        }

        private void TButtonQuitarCliente_Click(object sender, EventArgs e)
        {
            TLabelCliente.Visible = false;
            TButtonCambiarCliente.Visible = false;
            TButtonQuitarCliente.Visible = false;
            TButtonBuscarCliente.Visible = true;
        }

        private void TButtonCambiarCliente_Click(object sender, EventArgs e)
        {
            GestionClientesBuscar F1 = new GestionClientesBuscar(false);
            F1.ShowDialog();
            enCliente = F1.enClientePub;
            TButtonBuscarCliente.Visible = false;
            TLabelCliente.Text = "Cliente: " + enCliente.Nombre + enCliente.Apellidos;
            TLabelCliente.Visible = true;
            TButtonCambiarCliente.Visible = true;
            TButtonQuitarCliente.Visible = true;
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TButtonBuscarFechas_Click(object sender, EventArgs e)
        {
            TButtonBuscarFechas.Visible = false;
            TLabelFechaInicio.Visible = true;
            TLabelFechaFin.Visible = true;
            TDateTimePickerFechaInicio.Visible = true;
            TDateTimePickerFechaFin.Visible = true;
            TButtonOcultarFechas.Visible = true;
            TDateTimePickerFechaFin.Value = TDateTimePickerFechaInicio.Value = DateTime.Today;

        }

        private void TButtonOcultarFechas_Click(object sender, EventArgs e)
        {
            TButtonBuscarFechas.Visible = true;
            TLabelFechaInicio.Visible = false;
            TLabelFechaFin.Visible = false;
            TDateTimePickerFechaInicio.Visible = false;
            TDateTimePickerFechaFin.Visible = false;
            TButtonOcultarFechas.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TButtonBuscar_Click(object sender, EventArgs e)
        {
            dataGridBuscarFacturas.Visible = true;
            TPanelReservas.Location = new Point(175, 372); //para desplazar el panel de busqueda hacia abajo.
            EN.ENFacturacion enFacturacion = new EN.ENFacturacion();

            DataSet dsFacturacion = new DataSet();

            string sentencia = "";
            if (TTextBoxNumeroFactura.Text.ToString() != "")
            {
                sentencia += " numero='" + TTextBoxNumeroFactura.Text.ToString() + "'";
            }
            if (TDateTimePickerFechaFin.Visible == true)
            {
                if (sentencia == "")
                {
                    sentencia += " Fecha inicio between '" + TDateTimePickerFechaInicio.Value.ToString() + "'" + " and '" + TDateTimePickerFechaFin.Value.ToString() + "'";
                    sentencia += " and Fecha fin between '" + TDateTimePickerFechaInicio.Value.ToString() + "'" + " and '" + TDateTimePickerFechaFin.Value.ToString() + "'";
                }
                else
                {
                    sentencia += " and Fecha inicio between'" + TDateTimePickerFechaFin.Value.ToString() + "' and '" + TDateTimePickerFechaInicio.Value.ToString() + "'";
                    sentencia += " and Fecha fin between '" + TDateTimePickerFechaInicio.Value.ToString() + "'" + " and '" + TDateTimePickerFechaFin.Value.ToString() + "'";
                }
            }
            if (TLabelCliente.Visible == true)
            {
                if (sentencia == "")
                {
                    sentencia += " FK_Cliente ='" + enCliente.DNI.ToString() + "'";
                }
                else
                {
                    sentencia += " and FK_Cliente ='" + enCliente.DNI.ToString() + "'";
                }
            }

            dsFacturacion = enFacturacion.ObtenerFacturas(sentencia);
            dataGridBuscarFacturas.DataSource = dsFacturacion;
            dataGridBuscarFacturas.DataMember = "Facturas";
        }
    }
}

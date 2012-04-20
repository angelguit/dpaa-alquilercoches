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
    public partial class GestionFacturacionBuscar : Form
    {
        EN.ENCliente enCliente = new EN.ENCliente();
        private string eliminado = "";
        public GestionFacturacionBuscar()
        {
            InitializeComponent();
            dataGridBuscarFacturas.Visible = false;
        }

        private void TButtonBuscarCliente_Click(object sender, EventArgs e)
        {
            /*GestionClientesBuscar F1 = new GestionClientesBuscar(false);
            F1.ShowDialog();
            enCliente = F1.enClientePub;
            TButtonBuscarCliente.Visible = false;
            TLabelCliente.Text = "Cliente: " + enCliente.Nombre + enCliente.Apellidos;
            TLabelCliente.Visible = true;
            TButtonCambiarCliente.Visible = true;
            TButtonQuitarCliente.Visible = true;*/
            GestionClientesBuscar F1 = new GestionClientesBuscar(false);
            F1.StartPosition = FormStartPosition.Manual;
            F1.Location = Location;
            F1.Left += 147;
            F1.Top += 48;
            F1.ShowDialog();
            enCliente = F1.enClientePub;
            if (enCliente.Nombre != null)
            {
                TButtonBuscarCliente.Visible = false;
                TLabelCliente.Text = "Cliente: " + enCliente.Nombre + enCliente.Apellidos;
                TLabelCliente.Visible = true;
                TButtonCambiarCliente.Visible = true;
                TButtonQuitarCliente.Visible = true;
            }
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
            EN.ENFacturacion enFacturacion = new EN.ENFacturacion();

            DataSet dsFacturacion = new DataSet();
            
            bool correcto = true;
            string sentencia = "";
           
            if (!Regex.Match(TTextBoxNumeroFactura.Text, @"^[0-9]{1,10000}$").Success && TTextBoxNumeroFactura.Text.ToString() != "")
            {
                errorProvider1.SetError(TTextBoxNumeroFactura, "Solo se admiten números (vacio para buscar todas)");
                correcto = false;
            }
            else
            {
                errorProvider1.Clear();
                if (TTextBoxNumeroFactura.Text.ToString() != "")
                {
                    sentencia += " Numero='" + TTextBoxNumeroFactura.Text.ToString() + "'";
                }
            }
            if (TDateTimePickerFechaFin.Visible == true)
            {
                if (TDateTimePickerFechaInicio.Value <= TDateTimePickerFechaFin.Value)
                {
                    errorProvider1.Clear();
                    if (sentencia == "")
                    {
                        sentencia += " DiaFacturacion between " + Convert.ToDateTime(TDateTimePickerFechaInicio.Value.ToString()) + " and " + Convert.ToDateTime(TDateTimePickerFechaFin.Value.ToString());
                    }
                    else
                    {
                        sentencia += " and DiaFacturacion between'" + Convert.ToDateTime(TDateTimePickerFechaFin.Value.ToString()) + "' and '" + Convert.ToDateTime(TDateTimePickerFechaInicio.Value.ToString()) + "'";
                    }
                }
                else
                {
                    errorProvider1.SetError(TDateTimePickerFechaFin, "Fecha fin superior a fecha inicio");
                    correcto = false;
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

   
            if (correcto)
            {
                dataGridBuscarFacturas.Visible = true;
                TPanelReservas.Location = new Point(108, 277); //para desplazar el panel de busqueda hacia abajo.
                EN.ENFacturacion enFa = new EN.ENFacturacion();

                TButtonEliminar.Visible = true;
                DataSet ds = new DataSet();

                eliminado = sentencia;
                ds = enFa.ObtenerFacturas(sentencia);
                dataGridBuscarFacturas.DataSource = ds;
                dataGridBuscarFacturas.DataMember = "Facturas";

                for (int i = 0; i < dataGridBuscarFacturas.Columns.Count; i++) //esto nos servira para bloquear todas las columnas para que no se puedan editar 
                {
                    if (i != 0) { dataGridBuscarFacturas.Columns[i].ReadOnly = true; } //dejamos desbloqueada la columna de eliminar para que podamos pulsar, la columna boton no se bloquea asiq no hace falta desbloquearla
                }
            }
        }

        private void TButtonQuitarCliente_Click_1(object sender, EventArgs e)
        {
            TLabelCliente.Visible = false;
            TButtonCambiarCliente.Visible = false;
            TButtonQuitarCliente.Visible = false;
            TButtonBuscarCliente.Visible = true;
        }
    }
}

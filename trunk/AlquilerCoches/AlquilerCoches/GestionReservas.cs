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
    public partial class GestionReservas : Form
    {
        private EN.ENCliente enCliente = new EN.ENCliente();
        public GestionReservas()
        {
            InitializeComponent();

            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            {
                buttons.HeaderText = "Editar"; //texto de la columna
                buttons.Text = "Editar"; //texto de cada boton, sale al introducir texto
                buttons.UseColumnTextForButtonValue = true;
                buttons.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                buttons.FlatStyle = FlatStyle.Standard;
                buttons.CellTemplate.Style.BackColor = Color.Honeydew;
                buttons.DisplayIndex = 0;
            }

            DataGridViewCheckBoxColumn boton = new DataGridViewCheckBoxColumn();
            {
                boton.HeaderText = "Eliminar";//texto de la columna
                boton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //tamaño
                boton.DisplayIndex = 0; //indice que ocupara en la tabla
            }


            TDataGridViewReservas.Columns.Add(boton);
            TDataGridViewReservas.Columns.Add(buttons);
            /* TDataGridViewPersonal.ReadOnly = true;
             TDataGridViewPersonal.Columns[1].ReadOnly = false;*/
        }

        private void GestionReservas_Load(object sender, EventArgs e)
        {
            EN.ENReservas enRe = new EN.ENReservas();
            DataSet dsRe = new DataSet();
            dsRe = enRe.ObtenerReservas();
            TDataGridViewReservas.DataSource = dsRe;
            TDataGridViewReservas.DataMember = "Reservas";
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void TButtonBuscar_Click(object sender, EventArgs e)
        {
            TDataGridViewReservas.Visible = true;
            TPanelReservas.Location = new Point(175, 372); //para desplazar el panel de busqueda hacia abajo.
            EN.ENReservas enRe = new EN.ENReservas();

            TButtonEliminar.Visible = true;
            DataSet ds = new DataSet();

            string sentencia = "";
            if (TTextBoxNumeroReserva.Text.ToString() != "")
            {
                sentencia += " NºReserva='" + TTextBoxNumeroReserva.Text.ToString() + "'";
            }
            if (TDateTimePickerFechaFin.Visible == true)
            {
                if (sentencia == "")
                {
                    sentencia += " Fecha inicio >='" + TDateTimePickerFechaFin.Value.ToString() + "' and Fecha fin <='" + TDateTimePickerFechaInicio.Value.ToString() + "'";
                }
                else
                {
                    sentencia += " and Fecha inicio >='" + TDateTimePickerFechaFin.Value.ToString() + "' and Fecha fin <= '" + TDateTimePickerFechaInicio.Value.ToString() + "'";
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

            ds = enRe.ObtenerReservas(sentencia);
            TDataGridViewReservas.DataSource = ds;
            TDataGridViewReservas.DataMember = "Reservas";
        }

        private void TButtonQuitarCliente_Click(object sender, EventArgs e)
        {
            TLabelCliente.Visible = false;
            TButtonCambiarCliente.Visible = false;
            TButtonQuitarCliente.Visible = false;
            TButtonBuscarCliente.Visible = true;
        }

    }
}

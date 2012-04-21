﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace AlquilerCoches
{
    public partial class NuevaFactura : Form
    {
        private EN.ENCliente enCliente = new EN.ENCliente();
        string eliminado = "";
        ErrorProvider err1 = new ErrorProvider();
        ErrorProvider err2 = new ErrorProvider();
        public NuevaFactura()
        {
            InitializeComponent();
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

        private void TButtonBuscarCliente_Click(object sender, EventArgs e)
        {
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

        private void TButtonBuscar_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            string sentencia = "";
            if (!Regex.Match(TTextBoxNumeroReserva.Text, @"^[0-9]{1,10000}$").Success && TTextBoxNumeroReserva.Text.ToString() != "")
            {
                err1.SetError(TTextBoxNumeroReserva, "Solo se admiten números (vacio para buscar todas)");
                correcto = false;
            }
            else
            {
                err1.Clear();
                if (TTextBoxNumeroReserva.Text.ToString() != "")
                {
                    sentencia += " NºReserva='" + TTextBoxNumeroReserva.Text.ToString() + "'";
                }
            }
            if (TDateTimePickerFechaFin.Visible == true)
            {
                if (TDateTimePickerFechaInicio.Value <= TDateTimePickerFechaFin.Value)
                {
                    err2.Clear();
                    if (sentencia == "")
                    {
                        sentencia += " FechaInicio between '" + Convert.ToDateTime(TDateTimePickerFechaInicio.Value.ToString()) + "' and '" + Convert.ToDateTime(TDateTimePickerFechaFin.Value.ToString())+ "'";
                        sentencia += " and FechaFin <= '" + Convert.ToDateTime(TDateTimePickerFechaFin.Value.ToString())+"'";
                    }
                    else
                    {
                        sentencia += " and FechaInicio between '" + Convert.ToDateTime(TDateTimePickerFechaFin.Value.ToString()) + "' and '" + Convert.ToDateTime(TDateTimePickerFechaInicio.Value.ToString()) + "'";
                        sentencia += " and FechaFin <= '" + Convert.ToDateTime(TDateTimePickerFechaFin.Value.ToString()) + "'";
                    }
                }
                else
                {
                    err2.SetError(TDateTimePickerFechaFin, "Fecha fin superior a fecha inicio");
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
                //location 199,38 size 558 285
                //location 142 343
                TDataGridViewReservas.Visible = true;
                TGroupBoxReservas.Location = new Point(26, 343); //para desplazar el panel de busqueda hacia abajo.
                EN.ENReservas enRe = new EN.ENReservas();

                DataSet ds = new DataSet();

                eliminado = sentencia;
                ds = enRe.ObtenerReservas(sentencia);
                TDataGridViewReservas.DataSource = ds;
                TDataGridViewReservas.DataMember = "Reservas";

                for (int i = 0; i < TDataGridViewReservas.Columns.Count; i++) //esto nos servira para bloquear todas las columnas para que no se puedan editar 
                {
                    if (i != 0) { TDataGridViewReservas.Columns[i].ReadOnly = true; } //dejamos desbloqueada la columna de eliminar para que podamos pulsar, la columna boton no se bloquea asiq no hace falta desbloquearla
                }
            }
        }

        private void TRadioButtonReservas_CheckedChanged(object sender, EventArgs e)
        {
            if (TRadioButtonReservas.Checked == true)
            {
                TGroupBoxReservas.Visible = true;
            }
            else
            {
                TGroupBoxReservas.Visible = false;
            }
        }

        private void NuevaFactura_Load(object sender, EventArgs e)
        {
            TRadioButtonReservas.Checked = TRadioButtonVentas.Checked = false;
        }
    }
}
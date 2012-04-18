﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace AlquilerCoches
{
    public partial class GestionReservas : Form
    {
        private EN.ENCliente enCliente = new EN.ENCliente();
        private ArrayList arraynumRes = new ArrayList();
        private string eliminado = "";
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
            eliminado = sentencia;
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


        private void TDataGridViewReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           // try
            //{

                if (TDataGridViewReservas.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex.ToString() == "0") // la columna 0 es el checkbox de eliminiar
                {
                    string numRes = TDataGridViewReservas.Rows[e.RowIndex].Cells[2].Value.ToString();

                    if (arraynumRes.Count == 0)
                    {
                        arraynumRes.Add(numRes);
                    }
                    else
                    {
                        bool esta = false;
                        for (int i = 0; i < arraynumRes.Count; i++)
                        {
                            if (arraynumRes[i].ToString() == numRes)
                            {
                                arraynumRes.RemoveAt(i);//para borrarlo de la array porque esto quiere decir que lo hemos deseleccionado
                                esta = true;
                            }
                        }
                        if (esta == false)
                            arraynumRes.Add(numRes);
                    }
                }
                else if (TDataGridViewReservas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Editar")
                {

                        EN.ENReservas enRe = new EN.ENReservas();
                        enRe.Cliente = TDataGridViewReservas.Rows[e.RowIndex].Cells[2].Value.ToString();
                        enRe.Matricula = enRe.Cliente = TDataGridViewReservas.Rows[e.RowIndex].Cells[3].Value.ToString();
                        enRe.FechaInicio = Convert.ToDateTime(TDataGridViewReservas.Rows[e.RowIndex].Cells[5].Value);
                        enRe.FechaFin = Convert.ToDateTime(TDataGridViewReservas.Rows[e.RowIndex].Cells[6].Value);
                        enRe.Conductores = Int32.Parse(TDataGridViewReservas.Rows[e.RowIndex].Cells[7].Value.ToString());
                        

                        AltaReservas F1 = new AltaReservas(enRe, "Guardar Cambios");
                        F1.ShowDialog();

                    
                }

            //}
           /* catch (Exception ex)
            {
                throw (ex);
            }*/
        }

        private void TButtonEliminar_Click(object sender, EventArgs e)
        {
            EN.ENReservas enRes = new EN.ENReservas();
            if (arraynumRes.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar '" + arraynumRes.Count.ToString() + "' registros?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    enRes.EliminarReserva(arraynumRes);
                }

                arraynumRes.Clear();
                DataSet ou = new DataSet();
                ou = enRes.ObtenerReservas(eliminado);
                TDataGridViewReservas.DataSource = ou;

            }
            else
                MessageBox.Show("Debe seleccionar algún registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

        

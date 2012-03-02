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
    public partial class GestionClientesBuscar : Form
    {
        public GestionClientesBuscar()
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


            TDataGridViewCliente.Columns.Add(boton);
            TDataGridViewCliente.Columns.Add(buttons);

        }

        private void GestionClientesBuscar_Load(object sender, EventArgs e)
        {

        }

        private void GestionClientesBuscar_Closed(object sender, EventArgs e)
        {

        }

        private void TButtonBuscar_Click(object sender, EventArgs e)
        {
            TButtonEliminar.Visible = true;
        }
    }
}

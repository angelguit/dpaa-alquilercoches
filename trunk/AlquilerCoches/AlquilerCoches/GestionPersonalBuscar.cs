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
    public partial class GestionPersonalBuscar : Form
    {
        public GestionPersonalBuscar()
        {
            InitializeComponent();

            /*  DataGridViewButtonColumn colBotones = new DataGridViewButtonColumn();
              colBotones.Name = "colBotones";
              colBotones.HeaderText = "Editar";
              colBotones.ReadOnly = true;
              colBotones.Text="Editar";
              colBotones.

              this.TDataGridViewPersonal.Columns.Add(colBotones);*/
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


            TDataGridViewPersonal.Columns.Add(boton);
            TDataGridViewPersonal.Columns.Add(buttons);
        }

        private void TButtonBuscar_Click(object sender, EventArgs e)
        {
            //if(hay resultados) mostrar boton eliminar
            TButtonEliminar.Visible = true;
        }


    }
}

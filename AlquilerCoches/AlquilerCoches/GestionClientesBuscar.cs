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
    public partial class GestionClientesBuscar : Form
    {
        private bool dondevengo;
        public GestionClientesBuscar(bool directo)
        {
            dondevengo = directo;//si es true ha sido llamado directamente, si es false lo han llamado desde otro formulario
            InitializeComponent();

            if (directo == true)//si se llama directamente a este formulario sin pasar por otro formulario antes
            {
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
            else
            {
                DataGridViewCheckBoxColumn boton = new DataGridViewCheckBoxColumn();
                {
                    boton.HeaderText = "Seleccionar";//texto de la columna
                    boton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //tamaño
                    boton.DisplayIndex = 0; //indice que ocupara en la tabla

                }
                TDataGridViewCliente.Columns.Add(boton);
            }

        }

        private void GestionClientesBuscar_Closed(object sender, EventArgs e)
        {

        }

        bool incorrecto = true;
        private void TTextBoxDNI_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxDNI.Text, @"^(([A-Z]\d{8})|(\d{8}[A-Z]))$").Success)
            {
                errorProvider1.SetError(TTextBoxDNI, "DNI incorrecto");
                incorrecto = true;
            }
            else { incorrecto = false; errorProvider1.SetError(TTextBoxDNI, ""); }
        }

        private void TTextBoxApellidos_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxApellidos.Text, @"^[A-Za-z]{3,40}$").Success)
            {
                errorProvider1.SetError(TTextBoxApellidos, "Apellidos incorrectos, caracteres invalidos");
                incorrecto = true;
            }
            else { incorrecto = false; errorProvider1.SetError(TTextBoxApellidos, ""); }
        }

        private void TTextBoxNombre_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxNombre.Text, @"^[A-Za-z]{3,15}$").Success)
            {
                errorProvider1.SetError(TTextBoxNombre, "Nombre incorrecto, carateres invalidos");
                incorrecto = true;
            }
            else { incorrecto = false; errorProvider1.SetError(TTextBoxNombre, ""); }
        }

        private void TTextBoxProvincia_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxProvincia.Text, @"^[A-Za-z]{3,15}$").Success)
            {
                errorProvider1.SetError(TTextBoxProvincia, "Provincia incorrecta, caracteres invalidos");
                incorrecto = true;
            }
            else { incorrecto = false; errorProvider1.SetError(TTextBoxProvincia, ""); }
        }


        private void TButtonBuscar_Click(object sender, EventArgs e)
        {

            if (incorrecto == true)
            {
                MessageBox.Show("Campos invalidos, reviselos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if(dondevengo==true)
                        TButtonEliminar.Visible = true;

            }
                
            
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
    }
}

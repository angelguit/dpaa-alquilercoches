﻿using System;
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
    public partial class GestionPersonalBuscar : Form
    {
        private DataSet ds;

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

        bool incorrecto = false;
        private void TTextBoxDNI_Leave(object sender, EventArgs e)
        {

            if (TTextBoxDNI.Text == "") errorProvider1.SetError(TTextBoxDNI, ""); //si esta vacio no hace falta que demos error simplemente en la busqueda
                //no contemplaremos el dni para buscar.

            else if (!Regex.Match(TTextBoxDNI.Text, @"^(([A-Z]\d{8})|(\d{8}[A-Z]))$").Success)
            {
                errorProvider1.SetError(TTextBoxDNI, "DNI incorrecto");
                incorrecto = true;
            }
            else {  errorProvider1.SetError(TTextBoxDNI, ""); }
        }

        private void TTextBoxNombre_Leave(object sender, EventArgs e)
        {
            if (TTextBoxNombre.Text == "") errorProvider1.SetError(TTextBoxNombre, "");
            else if (!Regex.Match(TTextBoxNombre.Text, @"^[A-Za-z]{3,15}$").Success)
            {
                errorProvider1.SetError(TTextBoxNombre, "Nombre incorrecto");
                incorrecto = true;
            }
            else {  errorProvider1.SetError(TTextBoxNombre, ""); }
        }

        private void TTextBoxApellidos_Leave(object sender, EventArgs e)
        {
            if (TTextBoxApellidos.Text == "") errorProvider1.SetError(TTextBoxApellidos, "");
            
            else if (!Regex.Match(TTextBoxApellidos.Text, @"^[A-Za-z]{3,40}$").Success)
            {
                errorProvider1.SetError(TTextBoxApellidos, "Apellidos incorrectos, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxApellidos, ""); }
        }

        private void TTextBoxPuestoAc_Leave(object sender, EventArgs e)
        {
            if (TTextBoxPuestoAc.Text == "") errorProvider1.SetError(TTextBoxPuestoAc, "");         
            else if (!Regex.Match(TTextBoxPuestoAc.Text, @"^[A-Za-z]{3,15}$").Success)
            {
                errorProvider1.SetError(TTextBoxPuestoAc, "Puesto incorrecto, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TTextBoxPuestoAc, ""); }
        }

        private void TButtonBuscar_Click(object sender, EventArgs e)
        {
            //if(hay resultados) mostrar boton eliminar
            if (incorrecto == true)
            {
                MessageBox.Show("Campos invalidos, reviselos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } 
            else
            TButtonEliminar.Visible = true;

            ds = new DataSet();
            EN.ENPersonal enPerson = new EN.ENPersonal();

            ds = enPerson.ObtenerListaPersonal();


            TTextBoxApellidos.Text = ds.Tables[0].Rows[0][1].ToString();
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TDataGridViewPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          /*  try
            {*/

                if (TDataGridViewPersonal.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex.ToString()=="5")
                {
                    MessageBox.Show("eyyy");
                }
                else if (TDataGridViewPersonal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Editar")
                {
                    if (Application.OpenForms["GestionPersonal"] != null)
                    {
                        Application.OpenForms["GestionPersonal"].Activate();
                    }
                    else
                    {

                        string nom = TDataGridViewPersonal.Rows[e.RowIndex].Cells[1].Value.ToString();//indice 1 para cojer el nombre
                        // MessageBox.Show("mensaje" + e.ColumnIndex+" , "+e.RowIndex); 

                        GestionPersonal Formu = new GestionPersonal(nom);

                        Formu.StartPosition = FormStartPosition.CenterScreen;
                        //Formu.MdiParent = this;
                        Formu.Show();
                        Formu.WindowState = FormWindowState.Maximized;
                    }
                }
                else
                {

                   TTextBoxNombre.Text = TDataGridViewPersonal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    
                }
           /* }
            catch (Exception ex)
            {
                MessageBox.Show("Error no hay valores en la fila");

            }*/

           // MessageBox.Show("hola"+TDataGridViewPersonal.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex.ToString());
        }
              
    }
}

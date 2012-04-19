using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using EN;
using System.Collections;

namespace AlquilerCoches
{
    public partial class BuscarPedidos : Form
    {
        EN.ENPedidos enPedidos = new EN.ENPedidos();

        public BuscarPedidos()
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


            TDataGridViewPedidos.Columns.Add(boton);
            TDataGridViewPedidos.Columns.Add(buttons);
        }

        private void BuscarPedidos_Load(object sender, EventArgs e)
        {
            TDataGridViewPedidos.Visible = false;
            radioButton3.Checked = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        bool incorrecto = true;
        private void TIDtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(TIDtextBox.Text, @"^[A-Za-z]{5,15}$").Success)
            {
                errorProvider1.SetError(TIDtextBox, "ID incorrecto, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TIDtextBox, ""); }
        }

        private void TNametextbox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(TNametextbox.Text, @"^[A-Za-z]{5,20}$").Success)
            {
                errorProvider1.SetError(TNametextbox, "Nombre incorrecta, caracteres invalidos");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TNametextbox, ""); }
        }

        string eliminado = "";
        private void TBuscarbutton_Click(object sender, EventArgs e)
        {
                TDataGridViewPedidos.Visible = true;
          /*  if (incorrecto == true)
            {
                MessageBox.Show("Campos invalidos, reviselos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } 
            else
            { */
                
                DataSet ds = new DataSet();

                string envio="";

                if (radioButton1.Checked)
                {
                    envio = "Abierto";
                }
                if (radioButton2.Checked)
                {
                    envio = "Urgente";
                }

                string id= TIDtextBox.Text.ToString();
                string nombre = TNametextbox.Text.ToString();
                string tipo_envio = envio;
                string todo = "";

                if (id != "") //id transaccion
                {
                    todo += " IDTransaccion='" + id + "' ";
                }
                if (nombre != "" ) //nombre
                {
                    todo += " Marca='" + nombre + "' ";
                }
             


                MessageBox.Show("select * from tabla where" + todo);
                ds = enPedidos.ObtenerListaPedidos(todo);
                eliminado = todo;

                TDataGridViewPedidos.DataSource = ds;
                TDataGridViewPedidos.DataMember = "Pedidos";
         //   }
        }
        ArrayList arrayid = new ArrayList();
        private void TDataGridViewPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            try
            {

                if (TDataGridViewPedidos.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex.ToString()=="0") // la columna 0 es el checkbox de eliminiar
                {
                    string id = TDataGridViewPedidos.Rows[e.RowIndex].Cells[2].Value.ToString(); //el indice 2 hace referencia al dni del datagridview
                    
                    if (arrayid.Count == 0)
                    {
                        arrayid.Add(id);
                    }
                    else
                    {
                        bool esta = false;
                        for (int i = 0; i < arrayid.Count; i++)
                        {
                            if (arrayid[i].ToString() == id)
                            {
                                arrayid.RemoveAt(i);//para borrarlo de la array porque esto quiere decir que lo hemos deseleccionado
                                esta = true;
                            }
                        }
                        if (esta == false)
                            arrayid.Add(id);
                    }
                }
                else if (TDataGridViewPedidos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Editar")
                {
                    if (Application.OpenForms["GestionPedidos"] != null)
                    {
                        Application.OpenForms["GestionPedidos"].Activate();
                    }
                    else
                    {
                        string id = TDataGridViewPedidos.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string proveedor = TDataGridViewPedidos.Rows[e.RowIndex].Cells[3].Value.ToString();//indice 1 para cojer el nombre
                        string marca = TDataGridViewPedidos.Rows[e.RowIndex].Cells[4].Value.ToString();
                        string modelo = TDataGridViewPedidos.Rows[e.RowIndex].Cells[5].Value.ToString();
                        string cantidad = TDataGridViewPedidos.Rows[e.RowIndex].Cells[6].Value.ToString();
                        string observaciones = TDataGridViewPedidos.Rows[e.RowIndex].Cells[7].Value.ToString();
                        string estado = TDataGridViewPedidos.Rows[e.RowIndex].Cells[8].Value.ToString();
                        string empleado = TDataGridViewPedidos.Rows[e.RowIndex].Cells[9].Value.ToString();
                        string tipoenvio = TDataGridViewPedidos.Rows[e.RowIndex].Cells[10].Value.ToString();

                        string nombrebotonguardar = "Guardar Cambios";
                    //    GestionPedidos Formu = new GestionPedidos(id,proveedor,marca,modelo,cantidad,observaciones,estado,
                      //      ,empleado, tipoenvio,nombrebotonguardar);

                    //    Formu.StartPosition = FormStartPosition.CenterScreen;
                      //  Formu.MdiParent = this.MdiParent;
                      //  Formu.Show();
                       // ActualizaDatagridView();
                                           
                    }
                }
                else
                {

                   TNametextbox.Text = TDataGridViewPedidos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no hay valores en la fila");

            }
            

                        
        }

        private void TButtonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void TMarcacomboBox2_Click(object sender, EventArgs e)
        {

        }


        private void TModelocomboBox3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

    }
}

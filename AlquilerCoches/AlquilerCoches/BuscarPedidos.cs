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

            EN.ENPedidos marca = new EN.ENPedidos();
            DataSet dsMarc = new DataSet();
            dsMarc = marca.ObtenerListaMarcas();

            numMarca = new DataSet();
            numMarca = dsMarc;

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
        private void TButtonBuscar_Click(object sender, EventArgs e)
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
                string estado="";

                if (radioButton1.Checked)
                {
                    estado = "Abierto";
                }
                if (radioButton2.Checked)
                {
                    estado = "Cerrado";
                }
                if (radioButton3.Checked)
                {
                    envio = "Ordinario";
                }
                if (radioButton4.Checked)
                {
                    envio = "Urgente";
                }

                string id= TIDtextBox.Text.ToString();
                string marca = TMarcacomboBox2.Text.ToString();
                string modelo = TModelocomboBox3.Text.ToString();
                string tipo_envio = envio;
                string empleado = TNametextbox.Text.ToString();
                string siguiente = "";
                string todo = "";
                int n = 0;

                if (id != "") //id transaccion
                {
                    todo += " IDTransaccion='" + id + "' ";
                    n++; // Si hay mas de un criterio
                }

                if (marca != "") //marca
                {
                    if (n != 0)
                    {
                        siguiente += " and Marca='" + marca + "' and Modelo='" + modelo + "' and EstadoPedido='" + estado + "' and TipoEnvio='" + envio + "'";
                                           
                    }
                    else
                    {
                        siguiente += " Marca='" + marca + "' and Modelo='" + modelo + "'";
                    }
                }
                if (empleado!="")
                {
                    if (n != 0)
                    {
                        siguiente += " and Empleado='"+empleado+"' and Marca='" + marca + "' and Modelo='" + modelo + "' and EstadoPedido='" + estado + "' and TipoEnvio='" + envio + "'";
                    }
                    else
                    {
                        siguiente += " Empleado='"+empleado+"' and Marca='" + marca + "' and Modelo='" + modelo + "' and EstadoPedido='" + estado + "' and TipoEnvio='" + envio + "'";
                    }

                }

                todo += siguiente;
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

        private void groupBox2_Enter_1(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private DataSet numMarca; //usado en funcion TModelos
        private void ObtenerMarcas(DataSet dsMarc)
        {
            TMarcacomboBox2.Text = "Seleccione Marca del coche";
            TMarcacomboBox2.DataSource = dsMarc.Tables["Marca"];
            TMarcacomboBox2.DisplayMember = dsMarc.Tables["Marca"].Columns[1].Caption.ToString();

        }

        private void ObtenerModelos(DataSet dsMod)
        {
            TModelocomboBox3.Text = "Seleccione el modelo del coche";
            TModelocomboBox3.DataSource = dsMod.Tables["Modelo"];
            TModelocomboBox3.DisplayMember = dsMod.Tables["Modelo"].Columns[0].Caption.ToString();
        }
        private void TProveecomboBox1_Click(object sender, EventArgs e)
        {

        }

        private void TMarcacomboBox2_Click(object sender, EventArgs e)
        {
            if (TModelocomboBox3.Items.Count > 0) //lo dejamos en blanco por si hubiera alguna ciudad, para realizar nueva busqueda de provincia
                TModelocomboBox3.DataSource = null;

            EN.ENPedidos enMarc = new EN.ENPedidos();
            DataSet dsMarc = new DataSet();
            dsMarc = enMarc.ObtenerListaMarcas();
            ObtenerMarcas(dsMarc);
        }

        private void TModelocomboBox3_Click(object sender, EventArgs e)
        {
            EN.ENPedidos enMod = new EN.ENPedidos();
            DataSet dsMod = new DataSet();
            try
            {
                string marc = TMarcacomboBox2.Text.ToString();
                bool parar = false;

                for (int i = 0; i < 16 && parar != true; i++)
                {

                    if (numMarca.Tables["Marca"].Rows[i][1].ToString() == marc)
                    {

                        string num_marc = numMarca.Tables["Marca"].Rows[i][0].ToString();
                        parar = true;

                        dsMod = enMod.ObtenerListaModelos(num_marc);

                    }
                }
                ObtenerModelos(dsMod);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Si desea cambiar el modelo debe cambiar la marca", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace AlquilerCoches
{
    public partial class GestionProveedoresBuscar : Form
    {
        ArrayList arraydni = new ArrayList();

        public GestionProveedoresBuscar()
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
            dataGridView1.Columns.Add(boton);
            dataGridView1.Columns.Add(buttons);
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void TButtonBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "";
            EN.ENProveedores buscarProveedores = new EN.ENProveedores();
            DataSet resultadoProveedores = new DataSet();
            //muestra todo
            if (TTextBoxCIF.Text == "" && TComboBoxProvincias.Text == "" && TTextBoxMarca.Text == "" && TComboBoxCiudades.Text == "" && TTextBoxCPostal.Text=="")
            {
                resultadoProveedores = buscarProveedores.ObtenerListaProveedores(cadena);
                dataGridView1.DataSource = resultadoProveedores;
                dataGridView1.DataMember = "Proveedores";
            }
            else//con filtro
            {
                string buscarCIF = TTextBoxCIF.Text;
                string buscarMarca = TTextBoxMarca.Text;
                string buscarProvincia = TComboBoxProvincias.Text;
                string buscarCiudad = TComboBoxCiudades.Text;
                string buscarCPostal = TTextBoxCPostal.Text;
                if (TTextBoxCIF.Text != "")
                {
                    cadena += " CIF='"+buscarCIF+"' ";
                }

                //Marca
                if (TTextBoxMarca.Text != "" && cadena == "")
                {
                    cadena += " Marca='" + buscarMarca + "' ";
                }
                else
                {
                    if (TTextBoxMarca.Text != "" && cadena != "")
                    {
                        cadena += " and Marca='" + buscarMarca + "' ";
                    }
                }

                //Provincia
                if (TComboBoxProvincias.Text != "" && cadena == "")
                {
                    MessageBox.Show(TComboBoxProvincias.Text);
                    cadena += " Provincia='" + buscarProvincia + "' ";
                }
                else
                {
                    MessageBox.Show("2");
                    if (TComboBoxProvincias.Text != "" && cadena != "")
                    {
                        cadena += " and Provincia='" + buscarProvincia + "' ";
                    }
                }

                //Ciudad
                if (TComboBoxCiudades.Text != "" && cadena == "")
                {
                    cadena += " Ciudad='" + buscarCiudad + "' ";
                }
                else
                {
                    if (TComboBoxCiudades.Text != "" && cadena != "")
                    {
                        cadena += " and Ciudad='" + buscarCiudad + "' ";
                    }
                }

                //Codigo Postal
                if (TTextBoxCPostal.Text != "" && cadena == "")
                {
                    cadena += " CodigoPostal='" + buscarCPostal + "' ";
                }
                else
                {
                    if (TTextBoxCPostal.Text != "" && cadena != "")
                    {
                        cadena += " and CodigoPostal='" + buscarCPostal + "' ";
                    }
                }
                MessageBox.Show("Select * FROM Proveedores where " + cadena + "");
                resultadoProveedores = buscarProveedores.ObtenerListaProveedores(cadena);
                dataGridView1.DataSource = resultadoProveedores;
                dataGridView1.DataMember = "Proveedores";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TComboBoxProvincias_Click(object sender, EventArgs e)
        {
            EN.ENProveedores provincia = new EN.ENProveedores();
            DataSet dsProv = new DataSet();
            dsProv = provincia.ObtenerListaProvincias();
            ObtenerProvincias(dsProv);
        }

        private DataSet numProvincia;// usado en funcion TComboBoxCiudades_Click
        private void ObtenerProvincias(DataSet dsProv)
        {
            TComboBoxProvincias.Text = "Seleccione Provincia";
            TComboBoxProvincias.DataSource = dsProv.Tables["Provincia"];
            TComboBoxProvincias.DisplayMember = dsProv.Tables["Provincia"].Columns[1].Caption.ToString(); // como dsProv lleva el id_prov y el nombre ponemos 1 que es la columna del nombre
            numProvincia = new DataSet();
            numProvincia = dsProv;
        }

        private void ObtenerCiudades(DataSet dsCiu)
        {
            TComboBoxCiudades.Text = "Seleccione Ciudad";
            TComboBoxCiudades.DataSource = dsCiu.Tables["Ciudades"];
            TComboBoxCiudades.DisplayMember = dsCiu.Tables["Ciudades"].Columns[0].Caption.ToString();
        }

        private void TComboBoxCiudades_Click_1(object sender, EventArgs e)
        {
            EN.ENProveedores enCiu = new EN.ENProveedores();
            DataSet dsCiu = new DataSet();
            try
            {
                string prov = TComboBoxProvincias.Text.ToString();
                bool parar = false;
                // MessageBox.Show(numProvincia.Tables["Provincia"].Rows.Count.ToString());
                for (int i = 0; i < 53 && parar != true; i++)
                {
                    //MessageBox.Show(numProvincia.Tables["Provincia"].Rows[i][1].ToString());
                    if (numProvincia.Tables["Provincia"].Rows[i][1].ToString() == prov)
                    {
                        string numprov = numProvincia.Tables["Provincia"].Rows[i][0].ToString();// en la posicion 0 esta el id de la provincia
                        parar = true;
                        dsCiu = enCiu.ObtenerListaCiudades(numprov);

                    }
                }
                ObtenerCiudades(dsCiu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione primero una provincia", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TTextBoxCIF_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxCIF.Text, @"^(([A-Z]\d{8}))$").Success)
            {
                errorProvider1.SetError(TTextBoxCIF, "Formato correcto: X00000000");
            }
            else 
            { 
               errorProvider1.SetError(TTextBoxCIF, ""); 
            }
        }

        private void TButtonEliminar_Click(object sender, EventArgs e)
        {
            string cadena = "";
            EN.ENProveedores borrar = new EN.ENProveedores();
            if (arraydni.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar '" + arraydni.Count.ToString() + "' registros?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    string frase = "";
                    for (int i = 0; i < arraydni.Count; i++)
                    {
                        if (i == 0) { frase += "'" + arraydni[i] + "'"; }
                        else
                        {
                            frase += ",";
                            frase += "'" + arraydni[i] + "'";
                        }
                    }
                    MessageBox.Show("Select * from Personal where DNI in (" + frase + ")");
                    borrar.BorrarProveedorEN(arraydni);
                }

                arraydni.Clear();
                DataSet ou = new DataSet();
                ou = borrar.ObtenerListaProveedores(cadena);
                dataGridView1.DataSource = ou;

            }
            else
                MessageBox.Show("Debe seleccionar algún registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex.ToString() == "0") // la columna 0 es el checkbox de eliminiar
                {
                    string dni = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); //el indice 2 hace referencia al dni del datagridview

                    if (arraydni.Count == 0)
                    {
                        arraydni.Add(dni);
                    }
                    else
                    {
                        bool esta = false;
                        for (int i = 0; i < arraydni.Count; i++)
                        {
                            if (arraydni[i].ToString() == dni)
                            {
                                arraydni.RemoveAt(i);//para borrarlo de la array porque esto quiere decir que lo hemos deseleccionado
                                esta = true;
                            }
                        }
                        if (esta == false)
                        {
                            arraydni.Add(dni);
                        }
                    }
                }
                 else if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Editar")
                 {
                     if (Application.OpenForms["GestionPersonal"] != null)
                     {
                         Application.OpenForms["GestionPersonal"].Activate();
                     }
                     else
                     {
                         string cif = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                         string marca = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();//indice 1 para cojer el nombre
                         string calle = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                         int numero = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                         int telefono = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                         string email = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                         string ciudad = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                         string provincia = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                         int codigopostal = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString());
                         string horario = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();

                         string nombrebotonguardar = "Guardar Cambios";
                         GestionProveedores Formu = new GestionProveedores(cif, marca, calle, numero, telefono, email, ciudad, provincia, codigopostal, horario);

                         Formu.StartPosition = FormStartPosition.CenterScreen;
                         Formu.MdiParent = this.MdiParent;
                         Formu.Show();
                         
                     }
                 }
                 else
                 {

                    // TTextBoxNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no hay valores en la fila");

            }
        }
    }
}

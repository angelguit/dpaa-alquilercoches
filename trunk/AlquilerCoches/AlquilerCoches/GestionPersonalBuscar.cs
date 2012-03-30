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

namespace AlquilerCoches
{
    public partial class GestionPersonalBuscar : Form
    {
        public GestionPersonalBuscar()
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
            {
                TButtonEliminar.Visible = true;
                DataSet ds = new DataSet();
                EN.ENPersonal enPerson = new EN.ENPersonal();

                string apell = TTextBoxApellidos.Text.ToString();
                string ciu = TTextBoxCiudad.Text.ToString();
                string nom = TTextBoxNombre.Text.ToString();
                string prov = TComboBoxProvincias.Text.ToString();
                string dni = TTextBoxDNI.Text.ToString();
                string todo = "";

                if (apell != "") //apellidos
                {
                    todo +=" apellidos='"+apell+"' ";
                }
                if (dni != "" && todo != "") //nombre
                {
                    todo += " and DNI='" + dni + "' ";
                }
                else if (dni != "" && todo == "")
                {
                    todo += " DNI='" + dni + "' ";
                }
                if (nom != "" && todo != "") //nombre
                {
                    todo += " and nombre='"+nom+"' ";
                }
                else if (nom != "" && todo == "") 
                {
                    todo += " nombre='" + nom + "' ";
                }
                if (ciu != "" && todo!="") //ciudad
                {
                    todo += "and ciudad like '%" + ciu + "%' ";
                }
                else if (ciu != "" && todo == "")
                {
                    todo += " ciudad like '%" + ciu + "%' ";
                }
                if (prov != "" && todo != "") //provincia
                {
                    todo += "and provincia like '%" + prov + "%' ";
                }
                else if (prov != "" && todo == "")
                {
                    todo += " provincia like '%" + prov + "%' ";
                }

                MessageBox.Show("select * from tabla where" + todo);
                ds = enPerson.ObtenerListaPersonal(todo);
                

                  TDataGridViewPersonal.DataSource = ds;
                  TDataGridViewPersonal.DataMember = "Personal";
                

            }
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TDataGridViewPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

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
                        string nom = TDataGridViewPersonal.Rows[e.RowIndex].Cells[3].Value.ToString();//indice 1 para cojer el nombre
                        string dni = TDataGridViewPersonal.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string apell = TDataGridViewPersonal.Rows[e.RowIndex].Cells[4].Value.ToString();
                        string telef = TDataGridViewPersonal.Rows[e.RowIndex].Cells[5].Value.ToString();
                        string mail = TDataGridViewPersonal.Rows[e.RowIndex].Cells[6].Value.ToString();
                        string direc = TDataGridViewPersonal.Rows[e.RowIndex].Cells[7].Value.ToString();
                        string ciu = TDataGridViewPersonal.Rows[e.RowIndex].Cells[8].Value.ToString();
                        string prov = TDataGridViewPersonal.Rows[e.RowIndex].Cells[9].Value.ToString();
                        string puesac = TDataGridViewPersonal.Rows[e.RowIndex].Cells[10].Value.ToString();

                        GestionPersonal Formu = new GestionPersonal(nom,dni,apell,telef,mail,direc,ciu,prov,puesac);

                        Formu.StartPosition = FormStartPosition.CenterScreen;
                        Formu.MdiParent = this.MdiParent;
                        Formu.Show();
                     
                    }
                }
                else
                {

                   TTextBoxNombre.Text = TDataGridViewPersonal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no hay valores en la fila");

            }

           // MessageBox.Show("hola"+TDataGridViewPersonal.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex.ToString());
        }

        private void ObtenerProvincias(DataSet dsProv)
        {
            TComboBoxProvincias.Text = "Seleccione Provincia";
            TComboBoxProvincias.DataSource = dsProv.Tables["Provincia"];
            TComboBoxProvincias.DisplayMember = dsProv.Tables["Provincia"].Columns[0].Caption.ToString();
        }
 
        private void TComboBoxProvincias_Click(object sender, EventArgs e)
        { 
            EN.ENPersonal enProv = new EN.ENPersonal();
            DataSet dsProv = new DataSet();
            dsProv = enProv.ObtenerListaProvincias();
            ObtenerProvincias(dsProv);
        }


      
    }
}

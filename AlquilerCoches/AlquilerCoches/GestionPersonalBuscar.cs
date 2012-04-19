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
    public partial class GestionPersonalBuscar : Form
    {
        EN.ENPersonal enPerson = new EN.ENPersonal();//declaramos enPerson que lo usaremos en cualquier operacion relacionada con personal
        private DataSet numProvincia;// usado en funcion TComboBoxCiudades_Click
        bool incorrecto = false;
        string eliminado = "";
        ArrayList arraydni = new ArrayList();

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
            TDataGridViewPersonal.Visible = true;
            panel1.Location = new Point(94, 267); //para desplazar el panel de busqueda hacia abajo.
            //if(hay resultados) mostrar boton eliminar
            arraydni.Clear();// donde meteremos los dni que seleccionemos en el checkbox eliminar, hay q utilizar clear para que si hacemos una nueva busqueda vacie el array

            if (incorrecto == true)
            {
                MessageBox.Show("Campos invalidos, reviselos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                TButtonEliminar.Visible = true;
                DataSet ds = new DataSet();
                

                string apell = TTextBoxApellidos.Text.ToString();
                string ciu = TComboBoxCiudades.Text.ToString();
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
                if (prov != " " && todo != "") //provincia
                {
                    todo += "and provincia like '%" + prov + "%' ";
                }
                else if (prov != " " && todo =="")
                {
                    todo += " provincia like '%" + prov + "%' ";
                }

                //MessageBox.Show("select * from tabla where" + todo);
                ds = enPerson.ObtenerListaPersonal(todo);
                eliminado = todo;

                TDataGridViewPersonal.DataSource = ds;
                TDataGridViewPersonal.DataMember = "Personal";

               // if (ds.Tables[0].Rows.Count > 0)
               // {
                    
                    for (int i = 0; i < TDataGridViewPersonal.Columns.Count; i++) //esto nos servira para bloquear todas las columnas para que no se puedan editar 
                    {
                        if (i != 0) { TDataGridViewPersonal.Columns[i].ReadOnly = true; } //dejamos desbloqueada la columna de eliminar para que podamos pulsar, la columna boton no se bloquea asiq no hace falta desbloquearla
                    }
                 //   MessageBox.Show("Adios");
                //}
                //else { TDataGridViewPersonal.ReadOnly = true; MessageBox.Show("hola"); }

                    TDataGridViewPersonal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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

                if (TDataGridViewPersonal.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex.ToString()=="0") // la columna 0 es el checkbox de eliminiar
                {
                    string dni = TDataGridViewPersonal.Rows[e.RowIndex].Cells[2].Value.ToString(); //el indice 2 hace referencia al dni del datagridview
                    
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
                            arraydni.Add(dni);
                    }
                }
                else if (TDataGridViewPersonal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Editar")
                {
                    arraydni.Clear();//la vaciamos ya que al cambiar de formulario se borran las marcas de los checkbox

                    string nom = TDataGridViewPersonal.Rows[e.RowIndex].Cells[3].Value.ToString();//indice 1 para cojer el nombre
                    string dni = TDataGridViewPersonal.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string apell = TDataGridViewPersonal.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string telef = TDataGridViewPersonal.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string mail = TDataGridViewPersonal.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string direc = TDataGridViewPersonal.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string ciu = TDataGridViewPersonal.Rows[e.RowIndex].Cells[8].Value.ToString();
                    string prov = TDataGridViewPersonal.Rows[e.RowIndex].Cells[9].Value.ToString();
                    string puesac = TDataGridViewPersonal.Rows[e.RowIndex].Cells[10].Value.ToString();

                    string nombrebotonguardar = "Guardar Cambios";

                    if (Application.OpenForms["GestionPersonal"] != null)
                    {
                        Application.OpenForms["GestionPersonal"].Close();

                    }
                      
                        GestionPersonal Formu = new GestionPersonal(nom,dni,apell,telef,mail,direc,ciu,prov,puesac, nombrebotonguardar);
                        Formu.StartPosition = FormStartPosition.CenterScreen;
                        Formu.MdiParent = this.MdiParent;
                        Formu.Show();

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no hay valores en la fila");
            }
        
           
        }

        
        private void ObtenerProvincias(DataSet dsProv)
        {
            TComboBoxProvincias.Text = "Seleccione Provincia";
            TComboBoxProvincias.DataSource = dsProv.Tables["Provincia"];
            TComboBoxProvincias.DisplayMember = dsProv.Tables["Provincia"].Columns[1].Caption.ToString(); // como dsProv lleva el id_prov y el nombre ponemos 1 que es la columna del nombre
           // TComboBoxProvincias.DisplayMember = dsProv.Tables["Provincia"].Columns[0].Caption.ToString(); // como dsProv lleva el id_prov y el nombre ponemos 1 que es la columna del nombre


            numProvincia = new DataSet();
            numProvincia = dsProv;
            

        }

        private void ObtenerCiudades(DataSet dsCiu)
        {
            TComboBoxCiudades.Text = "Seleccione Ciudad";
            TComboBoxCiudades.DataSource = dsCiu.Tables["Ciudades"];
            TComboBoxCiudades.DisplayMember = dsCiu.Tables["Ciudades"].Columns[0].Caption.ToString();
        }
 
        private void TComboBoxProvincias_Click(object sender, EventArgs e)
        {
            if (TComboBoxCiudades.Items.Count > 0) //lo dejamos en blanco por si hubiera alguna ciudad, para realizar nueva busqueda de provincia
                TComboBoxCiudades.DataSource = null;

            EN.ENPersonal enProv = new EN.ENPersonal();
            DataSet dsProv = new DataSet();
            dsProv = enProv.ObtenerListaProvincias();
            ObtenerProvincias(dsProv);
        }

       private void TComboBoxCiudades_Click(object sender, EventArgs e)
        {
            EN.ENPersonal enCiu = new EN.ENPersonal();
            DataSet dsCiu = new DataSet();
          try
          {
                string prov = TComboBoxProvincias.Text.ToString();
               bool parar= false;
              // MessageBox.Show(numProvincia.Tables["Provincia"].Rows.Count.ToString());
                for (int i = 0; i < 53 && parar != true; i++)
                {
                    //MessageBox.Show(numProvincia.Tables["Provincia"].Rows[i][1].ToString());
                    if(numProvincia.Tables["Provincia"].Rows[i][1].ToString() == prov)
                    {
                        string numprov = numProvincia.Tables["Provincia"].Rows[i][0].ToString();// en la posicion 0 esta el id de la provincia
                        parar = true;
                        dsCiu = enCiu.ObtenerListaCiudades(numprov);
                        
                    }
                }
                ObtenerCiudades(dsCiu);             
           }
           catch(Exception ex)
           {
                MessageBox.Show("Seleccione primero una provincia", "Cuidado", MessageBoxButtons.OK,MessageBoxIcon.Information);
           }
        }

       private void TButtonEliminar_Click(object sender, EventArgs e)
       {
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
                   enPerson.EliminarPersonal(arraydni);
               }

               arraydni.Clear();
               DataSet ou = new DataSet();
               ou = enPerson.ObtenerListaPersonal(eliminado);
               TDataGridViewPersonal.DataSource = ou;
               
           }
           else
               MessageBox.Show("Debe seleccionar algún registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

       }

       public void ActualizaDatagridView()
       {
           string cadena = "";
           DataSet ou = new DataSet();
           ou = enPerson.ObtenerListaPersonal(cadena);
           TDataGridViewPersonal.DataSource = ou;

       }

       private void GestionPersonalBuscar_Activated(object sender, EventArgs e)
       {
           ActualizaDatagridView();
       }
      
    }
}

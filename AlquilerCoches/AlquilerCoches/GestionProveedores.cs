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
    public partial class GestionProveedores : Form
    {
        private string accionGuardar = "";
        private string textoProvincia = "";
        public GestionProveedores(string cif, string marca,string calle,int numero,int telefono,string email,string ciudad,string provincia,int  codigopostal,string horario,string accion)
        {
            InitializeComponent();
            accionGuardar = accion;
            if (accion == "modificar")
            {
                TTextBoxCIF.Enabled = false;
                TTextBoxCalle.Text = calle;
                TTextBoxCIF.Text = cif;
                TTextBoxCPostal.Text = codigopostal.ToString();
                TTextBoxEmail.Text = email;
                TTextBoxHorario.Text = horario;
                TTextBoxMarca.Text = marca;
                TTextBoxNumero.Text = numero.ToString();
                TTextBoxTelefono.Text = telefono.ToString();
                TComboBoxProvincias.Items.Add(provincia);
                TComboBoxProvincias.SelectedIndex = 0;
                TComboBoxCiudades.Items.Add(ciudad);
                TComboBoxCiudades.SelectedIndex = 0;
                textoProvincia = TComboBoxProvincias.Text;
                EN.ENProveedores provi = new EN.ENProveedores();
                DataSet dsProv = new DataSet();
                dsProv = provi.ObtenerListaProvincias();

                numProvincia = new DataSet();
                numProvincia = dsProv;
            }
        }
        bool incorrecto= false;

        private void TTextBoxCIF_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxCIF.Text, @"^(([A-Z]\d{8}))$").Success)
            {
                errorProvider1.SetError(TTextBoxCIF, "Formato correcto: X00000000");
                incorrecto = true;
            }
            else 
            {
                incorrecto = false;
                errorProvider1.SetError(TTextBoxCIF, ""); 
            }
        }

        private void TTextBoxEmail_Leave_1(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                errorProvider1.SetError(TTextBoxEmail, "Email incorrectos, caracteres invalidos");
                incorrecto = true;
            }
            else
            {
                incorrecto = false;
                errorProvider1.SetError(TTextBoxEmail, "");
            }
        }

        private void TTextBoxCPostal_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxCPostal.Text, @"^\d{5}$").Success)
            {
                errorProvider1.SetError(TTextBoxCPostal, "Formato correcto: 00000");
                incorrecto = true;
            }
            else
            {
                incorrecto = false;
                errorProvider1.SetError(TTextBoxCPostal, "");
            }
        }

        private void TTextBoxTelefono_Leave_1(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxTelefono.Text, @"^[0-9]{9}$").Success)
            {
                errorProvider1.SetError(TTextBoxTelefono, "Formato correcto: 000000000");
                incorrecto = true;
            }
            else
            {
                incorrecto = false;
                errorProvider1.SetError(TTextBoxTelefono, "");
            }
        }

        private void TComboBoxProvincias_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TComboBoxProvincias.Text, @"^[A-Za-z]{3,20}$").Success)
            {
                errorProvider1.SetError(TComboBoxProvincias, "Entre 3 y 20 caracteres");
                incorrecto = true;
            }
            else
            {
                incorrecto = false;
                errorProvider1.SetError(TComboBoxProvincias, "");
            }
        }

        private void TComboBoxCiudades_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TComboBoxCiudades.Text, @"^[A-Za-z]{3,20}$").Success)
            {
                errorProvider1.SetError(TComboBoxCiudades, "Entre 3 y 20 caracteres");
                incorrecto = true;
            }
            else
            {
                incorrecto = false;
                errorProvider1.SetError(TComboBoxCiudades, "");
            }
        }

        private void TButtonFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFich = new OpenFileDialog();
            OFich.Filter = "jpg (*.jpg)|*.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (OFich.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = System.Drawing.Image.FromFile(OFich.FileName); 
        }

        private void TTextBoxCalle_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxCalle.Text, @"^[A-Za-zñÑáéíóúÁÉÍÓÚçÇ\s]{3,30}$").Success)
            {
                errorProvider1.SetError(TTextBoxCalle, "Entre 3 y 30 caracteres");
                incorrecto = true;
            }
            else
            {
                incorrecto = false;
                errorProvider1.SetError(TTextBoxCalle, "");
            }
        }

        private void TTextBoxNumero_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxNumero.Text, @"^\d{1,5}$").Success)
            {
                errorProvider1.SetError(TTextBoxNumero, "Entre 1 y 5 digitos");
                incorrecto = true;
            }
            else
            {
                incorrecto = false;
                errorProvider1.SetError(TTextBoxNumero, "");
            }
        }

        private void TTextBoxMarca_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxMarca.Text, @"^[A-Za-zñÑáéíóúÁÉÍÓÚçÇ\s]{3,50}$").Success)
            {
                errorProvider1.SetError(TTextBoxMarca, "Entre 3 y 50 caracteres");
                incorrecto = true;
            }
            else
            {
                incorrecto = false;
                errorProvider1.SetError(TTextBoxMarca, "");
            }
        }

        private void TButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void TComboBoxCiudades_Click(object sender, EventArgs e)
        {
            EN.ENProveedores enCiu = new EN.ENProveedores();
            DataSet dsCiu = new DataSet();
            try
            {
                string prov = TComboBoxProvincias.Text.ToString();
                bool parar = false;
                for (int i = 0; i < 53 && parar != true; i++)
                {
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

        private void TComboBoxProvincias_TextChanged(object sender, EventArgs e)
        {
            EN.ENProveedores enCiu = new EN.ENProveedores();
            DataSet dsCiu = new DataSet();
            try
            {
                if (TComboBoxProvincias.SelectedIndex>0)
                {
                    string prov = TComboBoxProvincias.Text.ToString();
                    bool parar = false;
                    for (int i = 0; i < 53 && parar != true; i++)
                    {
                        if (numProvincia.Tables["Provincia"].Rows[i][1].ToString() == prov)
                        {
                            string numprov = numProvincia.Tables["Provincia"].Rows[i][0].ToString();// en la posicion 0 esta el id de la provincia
                            parar = true;
                            dsCiu = enCiu.ObtenerListaCiudades(numprov);

                        }
                    }
                    ObtenerCiudades(dsCiu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione primero una provincia", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GestionProveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["GestionProveedoresBuscar"] != null)
            {
                Application.OpenForms["GestionProveedoresBuscar"].Activate();
            }
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TButtonGuardarCliente_Click(object sender, EventArgs e)
        {
            if (TTextBoxCalle.Text == "" || TTextBoxCIF.Text == "" || TComboBoxCiudades.Text == ""
               || TTextBoxCPostal.Text == "" || TTextBoxEmail.Text == "" || TTextBoxMarca.Text == ""
                 || TTextBoxTelefono.Text == "" || TTextBoxHorario.Text == "" || TTextBoxNumero.Text == "" || TComboBoxProvincias.Text == "" || (TComboBoxProvincias.SelectedIndex ==0 && TComboBoxProvincias.Text!=textoProvincia))
            {
                MessageBox.Show("No pueden haber campos vacios");
            }
            else
            {
                if (!incorrecto)
                {
                    if (accionGuardar == "modificar")//editar proveedor
                    {
                        EN.ENProveedores modificar = new EN.ENProveedores();

                        modificar.CIF = TTextBoxCIF.Text;
                        modificar.Marca = TTextBoxMarca.Text;
                        modificar.Calle = TTextBoxCalle.Text;
                        modificar.Numero = Int32.Parse(TTextBoxNumero.Text);
                        modificar.Telefono = Int32.Parse(TTextBoxTelefono.Text);
                        modificar.Email = TTextBoxEmail.Text;
                        modificar.Ciudad = TComboBoxCiudades.Text;
                        modificar.Provincia = TComboBoxProvincias.Text;
                        modificar.Codigopostal = Int32.Parse(TTextBoxCPostal.Text);
                        modificar.Horario = TTextBoxHorario.Text;

                        modificar.modificarProveedorEN();

                        //Close();
                    }
                    else//guardar nuevo proveedor
                    {
                        EN.ENProveedores insertar = new EN.ENProveedores();
                        if (!insertar.ExisteProveedorEN(TTextBoxCIF.Text))
                        {

                            //insertar datos
                            insertar.CIF = TTextBoxCIF.Text;
                            insertar.Marca = TTextBoxMarca.Text;
                            insertar.Calle = TTextBoxCalle.Text;
                            insertar.Numero = Int32.Parse(TTextBoxNumero.Text);
                            insertar.Telefono = Int32.Parse(TTextBoxTelefono.Text);
                            insertar.Email = TTextBoxEmail.Text;
                            insertar.Ciudad = TComboBoxCiudades.Text;
                            insertar.Provincia = TComboBoxProvincias.Text;
                            insertar.Codigopostal = Int32.Parse(TTextBoxCPostal.Text);
                            insertar.Horario = TTextBoxHorario.Text;

                            insertar.InsertarProveedorEN();
                        }
                        else
                        {
                            MessageBox.Show("El CIF ya existe");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hay campos incorrectos");
                }
            }
        }

        private void TComboBoxProvincias_Leave_1(object sender, EventArgs e)
        {
            if (TComboBoxProvincias.SelectedIndex == -1)
            {
                errorProvider1.SetError(TComboBoxProvincias, "Debe seleccionar una provincia");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TComboBoxProvincias, "");
            }
        }

        private void TComboBoxCiudades_Leave_1(object sender, EventArgs e)
        {
            if (TComboBoxCiudades.SelectedIndex == -1)
            {
                errorProvider1.SetError(TComboBoxCiudades, "Debe seleccionar una ciudad");
                incorrecto = true;
            }
            else
            {
                errorProvider1.SetError(TComboBoxCiudades, "");
            }
        }



    }
}

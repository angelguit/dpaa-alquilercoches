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
    public partial class GestionPedidos : Form
    {
        public GestionPedidos()
        {
            InitializeComponent();
        }

        bool incorrecto = false;

        private void GestionPedidos_Load(object sender, EventArgs e)
        {            
            TEstadoTextBox.Text = "   ABIERTO";


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (TProveecomboBox1.Text == "" || TMarcacomboBox2.Text == "" || TModelocomboBox3.Text == "")
            {
                MessageBox.Show("Campos invalidos, no puede haber ninguno vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (incorrecto == true)
            {
                MessageBox.Show("Campos invalidos, reviselos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                EN.ENPedidos enPedidos = new EN.ENPedidos();


                enPedidos.IDTransaccion = textBox1.Text; enPedidos.Proveedor = TProveecomboBox1.Text; enPedidos.Marca = TMarcacomboBox2.Text;
                enPedidos.Modelo = TModelocomboBox3.Text; enPedidos.Cantidad = numericUpDown1.Text;
                enPedidos.Observaciones = TObservTextBox.Text;/* enPedidos.Fecha = TDateTimePickerFecha; */
                //falta fecha, tipo envio, y empleado

                EN.ENPersonal enPersonal = new EN.ENPersonal();

                enPedidos.AnyadirPedidos();


                if (TAceptarbutton1.Text.ToString() == "Guardar")
                {
                    enPersonal.AnyadirPersonal();
                }
                else
                {
                    enPersonal.EditarPersonal();
                }
            }

             
                
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TEstadoTextBox_TextChanged(object sender, EventArgs e)
        {
            TEstadoTextBox.Text = "Abierto";
        }

        private void TProveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBorrarbutton3_Click(object sender, EventArgs e)
        {
            //Combobox
            TProveecomboBox1.SelectedIndex = 0;
            TMarcacomboBox2.SelectedIndex = 0;
            TModelocomboBox3.SelectedIndex = 0;
            //Radiobutton
            TEnvioButtonOrdinario.Checked = true;
            TObservTextBox.Text = "";
            numericUpDown1.Value = 1;

        }

        private void TCancelarbutton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(numericUpDown1.Text, @"^[1-9]{1}$").Success)
            {
                errorProvider1.SetError(numericUpDown1, "El número de pedidos es entre 1 y 9");
                incorrecto = true;
            }
            else { errorProvider1.SetError(numericUpDown1, ""); }
        }

        private void TProveecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TProveecomboBox1.SelectedIndex==0)
            {
                errorProvider1.SetError(TProveecomboBox1, "Seleccione un proveedor");
                incorrecto = true;
            }
        }

        private void TMarcacomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TMarcacomboBox2.SelectedIndex == 0)
            {
                errorProvider1.SetError(TMarcacomboBox2, "Seleccione una marca");
                incorrecto = true;
            }

        }

        private void TModelocomboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TModelocomboBox3.SelectedIndex == 0)
            {
                errorProvider1.SetError(TModelocomboBox3, "Seleccione un modelo");
                incorrecto = true;
            }

        }

        private void TObservTextBox_TextChanged(object sender, EventArgs e)
        {
          /*  if (Regex.Match(TObservTextBox.Text, @"^[A-Za-z\s]{3,100}$").Success)
            {
                errorProvider1.SetError(TObservTextBox, "Máximo 300 caracteres.");
                incorrecto = true;
            }
            else { errorProvider1.SetError(TObservTextBox, ""); } */
        }

        private void TEnvioButtonOrdinario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TEnvioButtonUrgente_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

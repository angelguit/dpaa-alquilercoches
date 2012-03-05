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
    public partial class GestionPedidos : Form
    {
        public GestionPedidos()
        {
            InitializeComponent();
        }

        private void GestionPedidos_Load(object sender, EventArgs e)
        {            
            TEstadoTextBox.Text = "   ABIERTO";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            if (TProveecomboBox1.Text == "")
            {
                TErrorProvee.Text = "*Seleccione un proveedor";
                cont++;
                TErrorProvee.Show();
            }
            
            if (TMarcacomboBox2.Text == "")
            {
                    TErrorMarca.Text = "*Seleccione la marca del coche";
                    cont++;
                    TErrorMarca.Show();
            }
            if (TModelocomboBox3.Text == "")
            {
                   TErrorModelo.Text = "*Seleccione el modelo del coche";
                   cont++;
                   TErrorModelo.Show();
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
            TProveecomboBox1.Text = "";
            TMarcacomboBox2.Text = "";
            TModelocomboBox3.Text = "";
           
         

            
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

        }
    }
}

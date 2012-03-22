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
    public partial class BuscarPedidos : Form
    {
        private DataSet ds;

        public BuscarPedidos()
        {
            InitializeComponent();
        }

        private void BuscarPedidos_Load(object sender, EventArgs e)
        {

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

        private void TBuscarbutton_Click(object sender, EventArgs e)
        {
            if (incorrecto == true)
            {
                MessageBox.Show("Campos invalidos, reviselos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } 
            else
            {
                  ds=new DataSet;
                  EN.ENPedidos enPedidos= new EN.ENPedidos();

                  ds= enPedidos.ObtenerListaPedidos();
            }
        }
    }
}

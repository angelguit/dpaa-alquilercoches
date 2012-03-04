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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void TLabelCategoria_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["GestionClientesBuscar"] != null)
            {

                Application.OpenForms["GestionClientesBuscar"].Activate();
            }
            else
            {
                GestionClientesBuscar F1 = new GestionClientesBuscar();
                F1.Show();
            }
        }
    }
}

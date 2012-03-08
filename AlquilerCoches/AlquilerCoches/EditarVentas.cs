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
    public partial class EditarVentas : Form
    {
        public EditarVentas()
        {
            InitializeComponent();
        }

        private void TTextBoxMeses_Click(object sender, EventArgs e)
        {
            TTextBoxMeses.Text = "";
        }

        private void TCheckBoxGarantia_CheckedChanged(object sender, EventArgs e)
        {
            if (TCheckBoxGarantia.Checked)
            {
                TTextBoxMeses.Enabled = true;
            }
            else
            {
                TTextBoxMeses.Enabled = false;
                TTextBoxMeses.Text = "Meses";
            }
        }
    }
}

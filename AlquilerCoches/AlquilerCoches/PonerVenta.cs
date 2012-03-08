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
    public partial class PonerVenta : Form
    {
        public PonerVenta()
        {
            InitializeComponent();
        }

        private void TButtonVender_MouseHover(object sender, EventArgs e)
        {
            TLabelAviso.Text="*El precio de alquiler se pondrá a 0 automáticamente al vender";
        }

        private void TButtonVender_MouseLeave(object sender, EventArgs e)
        {
            TLabelAviso.Text = "";
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

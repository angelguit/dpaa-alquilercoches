﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlquilerCoches
{
    public partial class GestionVentas : Form
    {
        public GestionVentas()
        {
            InitializeComponent();
        }

        private void TGroupBoxDatosVehiculo_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            TLabelMeses.Text = "Garantía mostrada en meses";
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            TLabelMeses.Text = "";
        }
    }
}
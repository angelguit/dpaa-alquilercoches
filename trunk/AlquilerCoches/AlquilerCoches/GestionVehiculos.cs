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
    public partial class GestionVehiculos : Form
    {
        public GestionVehiculos(string Action)
        {
            InitializeComponent();
            switch (Action)
            {
                case "Buscar":
                    TButtonAnyadir.Visible = false;
                    TButtonEditar.Visible  =false;
                    break;       
                default:
                    break;
            }
        }

        private void TListViewMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TGroupBoxDatosVehiculo_Enter(object sender, EventArgs e)
        {

        }

        private void TLabel_Click(object sender, EventArgs e)
        {

        }

        private void GestionVehiculos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Dispose();
        }
    }
}

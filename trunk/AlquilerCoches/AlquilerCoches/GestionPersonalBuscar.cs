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
    public partial class GestionPersonalBuscar : Form
    {
        public GestionPersonalBuscar()
        {
            InitializeComponent();
        }

        private void TButtonBuscar_Click(object sender, EventArgs e)
        {
            //if(hay resultados) mostrar boton eliminar
            TButtonEliminar.Visible = true;
        }
    }
}

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
    public partial class GestionReservas : Form
    {
        public GestionReservas()
        {
            InitializeComponent();
        }

        private void GestionReservas_Load(object sender, EventArgs e)
        {
            EN.ENReservas enRe = new EN.ENReservas();
            DataSet dsRe = new DataSet();
            dsRe = enRe.ObtenerReservas();
            TDataGridViewReservas.DataSource = dsRe;
            TDataGridViewReservas.DataMember = "Reservas";
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

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
        private string mens, provincias, ciudades;
        private EN.ENCliente enCliente = new EN.ENCliente();
        public Facturacion()
        {
            InitializeComponent();
        }

        private void TLabelCategoria_Click(object sender, EventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {

        }

        private void TButtonBuscarCliente_Click(object sender, EventArgs e)
        {
            GestionClientesBuscar F1 = new GestionClientesBuscar(false);
            F1.ShowDialog();
            enCliente = F1.enClientePub;
            provincias = F1.provincias;
            ciudades = F1.ciudades;
            TLabelNombre.Text = "Nombre: " + enCliente.Nombre + "Apellidos: " + enCliente.Apellidos;
            TLabelDNI.Text = "DNI: " + enCliente.DNI + " " + "Telf: " + enCliente.Telefono;
            TLabelDirec.Text = "Direccion: " + enCliente.Direccion;
            TLabelDNI.Visible = true;
            TLabelNombre.Visible = true;
            TLabelDirec.Visible = true;
            //TButtonBuscarCliente.Visible = false;
            /*TLabelInfoCliente.Visible = true;
            TButtonBuscarOtro.Visible = true;
            TButtonEditar.Visible = true;
            TRectangleShapeCliente.Visible = true;
             */
        }
    }
}

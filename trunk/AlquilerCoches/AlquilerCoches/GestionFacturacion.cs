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
    public partial class GestionFacturacion : Form
    {
        private EN.ENFacturacion enFa = new EN.ENFacturacion();
        private EN.ENReservas enRes = new EN.ENReservas();
        private EN.ENVehiculo enVe = new EN.ENVehiculo();
        private EN.ENCliente enCli = new EN.ENCliente();

        public GestionFacturacion(EN.ENReservas enRe)
        {
            InitializeComponent();

            enRes = enRe;

            TimeSpan ts = enRe.FechaFin - enRe.FechaInicio;

            enVe.Matricula = enRe.Matricula;
            enVe.ObtenerDatosVehiculos();
            enCli.DNI = enRe.Cliente;
            enCli.RellenarCliente();
            enFa.Categoria = enVe.Categoria;
            enFa.Conductores = enRe.Conductores;
            enFa.Cliente = enRe.Cliente;
            enFa.Tarifa = enCli.Tarifa;
            enFa.Tiempo = ts.Days + 1;
            enFa.Vehiculo = enRe.Matricula;
            enFa.ObtenerPrecio();
            

            TTextBoxCategoria.Text = enVe.Categoria;
            TTextBoxVehiculo.Text = enRe.Matricula;
            TTextBoxConductores.Text = enRe.Conductores.ToString();
            TTextBoxTiempo.Text = ( ts.Days + 1).ToString();
            TTextBoxTarifa.Text = enCli.Tarifa;
            TLabelCliente.Text = "Nombre: " + enCli.Nombre + " Apellidos: " + enCli.Apellidos;
            TLabelDirec.Text = "Dirección: " + enCli.Direccion;
            TLabelTelf.Text = "Teléfono: " + enCli.Telefono;
            TLabelDNI.Text = "DNI: " + enCli.DNI;
            TLabelTar.Text = "Tarifa aplicada: " + enCli.Tarifa;
            TTextBoxPTotal.Text = enFa.PrecioTotal.ToString();
            TTextBoxTIva.Text = enFa.IVA.ToString();
            TTextBoxTPSinIva.Text = enFa.PrecioSinIVA.ToString();


        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TButtonReserva_Click(object sender, EventArgs e)
        {
            
            enFa.DiaFacturacion = DateTime.Today;
            enFa.AnyadirFactura();
            MessageBox.Show("Factura realizada con éxito", "Factura Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            enVe.Estado = "Disponible";
            enRes.Activa = false;
            enVe.EditarVehiculo();
            enRes.EditarReserva();
            ImprimirFacturaVenta Fp = new ImprimirFacturaVenta(enCli,enVe,enFa,enFa.UltimaFactura());
            Fp.Show();
            Fp.Imprimir();
            Close();
            Application.OpenForms["NuevaFactura"].Close();
        }
    }
}

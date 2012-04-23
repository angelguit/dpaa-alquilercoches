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
    public partial class FacturaVentas : Form
    {
        private EN.ENFacturacion enFa = new EN.ENFacturacion();
        private EN.ENCliente enCli = new EN.ENCliente();
        private EN.ENVentasRealizadas realizadas = new EN.ENVentasRealizadas();

        public FacturaVentas(EN.ENVentasRealizadas realizada)
        {

            InitializeComponent();

            realizadas = realizada;

            realizadas.Matricula = realizada.Matricula;
            realizadas.ObtenerDatosVentas(realizada.DNI);

            enCli.DNI = realizada.DNI;
            enCli.RellenarCliente();



            TTextBoxMatricula.Text = realizadas.Matricula;
            TTextBoxMarca.Text = realizadas.Marca;
            TTextBoxModelo.Text = realizadas.Modelo;
            if (realizadas.Garantia != "" && realizadas.Garantia != "0")
            {
                TCheckBoxGarantia.Checked = true;
                TTextBoxMeses.Text = realizadas.Garantia;
            }
            else
            {
                TCheckBoxGarantia.Checked = false;
                TTextBoxMeses.Text = "Meses";
            }
            TTextBoxFecha.Text = realizadas.Fecha;
            TLabelCliente.Text = "Nombre: " + enCli.Nombre + " Apellidos: " + enCli.Apellidos;
            TLabelDirec.Text = "Dirección: " + enCli.Direccion;
            TLabelTelf.Text = "Teléfono: " + enCli.Telefono;
            TLabelDNI.Text = "DNI: " + enCli.DNI;
            TLabelTar.Text = "Tarifa aplicada: " + enCli.Tarifa;
            TTextBoxPTotal.Text = realizadas.PrecioVenta;
            int iva = Int32.Parse(realizadas.PrecioVenta);
            iva = (iva * 18) / 100;
            TTextBoxTIva.Text = iva.ToString();
            int sinIVA = Int32.Parse(realizadas.PrecioVenta);
            sinIVA = sinIVA - iva;
            TTextBoxTPSinIva.Text = sinIVA.ToString();

            if (realizadas.Facturado == "0")
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TButtonReserva_Click(object sender, EventArgs e)
        {
            string dni = enCli.DNI;

            realizadas.ObtenerDatosVentas(dni);
            realizadas.Facturado = "1";
            realizadas.EditarFacturado(dni);
            MessageBox.Show("Factura realizada con éxito", "Factura Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();



            /* enFa.DiaFacturacion = DateTime.Today;
             enFa.AnyadirFactura();
             MessageBox.Show("Factura realizada con éxito", "Factura Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
             enVe.Estado = "Disponible";
             enRes.Activa = false;
             enVe.EditarVehiculo();
             enRes.EditarReserva();
             ImprimirFactura Fp = new ImprimirFactura(enCli,enVe,enFa,enFa.UltimaFactura());
             Fp.Show();
             Fp.Imprimir();
             Close();
             Application.OpenForms["NuevaFactura"].Close();*/
        }
    }
}

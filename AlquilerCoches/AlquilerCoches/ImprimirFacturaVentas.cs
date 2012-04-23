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
    public partial class ImprimirFacturaVentas : Form
    {
        public ImprimirFacturaVentas(EN.ENCliente cli, EN.ENVentasRealizadas realizada)
        {
            InitializeComponent();

            TTextBoxNumFac.Text = realizada.Facturado;
            TLabelNombre.Text = "Nombre: " + cli.Nombre + " Apellidos: " + cli.Apellidos;
            TLabelDNI.Text = "DNI: " + cli.DNI + " Telf: " + cli.Telefono;
            TLabelDirec.Text = "Dirección: " + cli.Direccion;
            TTextBoxMarca.Text = realizada.Marca.ToString();
            TTextBoxModelo.Text = realizada.Modelo.ToString();
            TTextBoxMatricula.Text = realizada.Matricula.ToString();
            if (realizada.Garantia != "" && realizada.Garantia != "0")
            {
                TCheckBoxGarantia.Checked = true;
                TTextBoxMeses.Text = realizada.Garantia;
            }
            else
            {
                TCheckBoxGarantia.Checked = false;
                TTextBoxMeses.Text = "Meses";
            }
            TLabelFecha.Text = DateTime.Today.ToString();
            TTextBoxPTotal.Text = realizada.PrecioVenta;
            int iva = Int32.Parse(realizada.PrecioVenta);
            iva = (iva * 18) / 100;
            TTextBoxTIva.Text = iva.ToString();
            int sinIVA = Int32.Parse(realizada.PrecioVenta);
            sinIVA = sinIVA - iva;
            TTextBoxTPSinIva.Text = sinIVA.ToString();
        }
        public void Imprimir()
        {
            printForm1.Print(this, Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly);
            Close();
        }
    }
}

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
    public partial class ImprimirFactura : Form
    {
        public ImprimirFactura(EN.ENCliente cli, EN.ENReservas re, EN.ENVehiculo ve, EN.ENFacturacion enFa, int numFac)
        {
            InitializeComponent();

            TLabelNombre.Text = "Nombre: " + cli.Nombre + " Apellidos: " + cli.Apellidos;
            TLabelDNI.Text = "DNI: " + cli.DNI + " Telf: " + cli.Telefono;
            TLabelDirec.Text = "Dirección: " + cli.Direccion;
            TTextBoxMarca.Text = ve.Marca.ToString();
            TTextBoxModelo.Text = ve.Modelo.ToString();
            TTextBoxMatricula.Text = ve.Matricula.ToString();
            TTextBoxConductores.Text = re.Conductores.ToString();
            TTextBoxCategoria.Text = ve.Categoria;
            TTextBoxNumFac.Text = numFac.ToString();
            TTextBoxTiempo.Text = enFa.Tiempo.ToString();
            TTextBoxTarifa.Text = enFa.Tarifa;
            TTextBoxTPSinIva.Text = enFa.PrecioSinIVA.ToString();
            TTextBoxTIva.Text = enFa.IVA.ToString();
            TTextBoxPTotal.Text = enFa.PrecioTotal.ToString();        
            
        }

        public void Imprimir()
        {
            TPrintFormFacturas.Print(this, Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly);
            Close();
        }
    }
}

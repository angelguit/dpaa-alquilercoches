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
    public partial class ImprimirReserva : Form
    {
        public ImprimirReserva( EN.ENCliente cli, EN.ENReservas re, EN.ENVehiculo ve, int numRes,double precio,string tar)
        {
            InitializeComponent();

            TLabelNombre.Text = "Nombre: " + cli.Nombre + " Apellidos: " + cli.Apellidos;
            TLabelDNI.Text = "DNI: " + cli.DNI + " Telf: " + cli.Telefono;
            TLabelDirec.Text = "Dirección: " + cli.Direccion;

            TTextBoxNumRes.Text = numRes.ToString();
            TTextBoxMarca.Text = ve.Marca.ToString();
            TTextBoxModelo.Text = ve.Modelo.ToString();
            TTextBoxMatricula.Text = ve.Matricula.ToString();
            TTextBoxConductores.Text = re.Conductores.ToString();
            TTextBoxFechaInicio.Text = re.FechaInicio.ToShortDateString();
            TTextBoxFechaFin.Text = re.FechaFin.ToShortDateString();
            TTextBoxCategoria.Text = ve.Categoria;
            TTextBoxPrecio.Text = precio.ToString();
            TLabelTarifa.Text = tar;
            TLabelCategoria.Select();
        }

        public void Imprimir()
        {
            TPrintFormReservas.Print(this,Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly);
            Close();
        }
    }
}

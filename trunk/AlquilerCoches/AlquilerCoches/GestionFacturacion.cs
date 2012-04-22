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
        public GestionFacturacion(EN.ENReservas enRe)
        {
            InitializeComponent();

            EN.ENVehiculo enVe = new EN.ENVehiculo();
            EN.ENCliente enCli = new EN.ENCliente();
            EN.ENFacturacion enFa = new EN.ENFacturacion();

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
    }
}

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
    public partial class AltaReservas : Form
    {
        public AltaReservas(EN.ENReservas enRe, string texto)
        {
            InitializeComponent();
            DataSet dsCli = new DataSet();
            EN.ENVehiculo enVe = new EN.ENVehiculo();
            EN.ENCliente enCli = new EN.ENCliente();
            dsCli = enCli.ObtenerDatosClienteConDni(enRe.Cliente.ToString());
            enVe.Matricula = enRe.Matricula;
            enVe.ObtenerDatosVehiculos();

            string nombre = dsCli.Tables["Cliente"].Rows[0][1].ToString();
            string apellidos = dsCli.Tables["Cliente"].Rows[0][2].ToString();
            string dni = dsCli.Tables["Cliente"].Rows[0][0].ToString();
            string telf = dsCli.Tables["Cliente"].Rows[0][4].ToString();
            string direc = dsCli.Tables["Cliente"].Rows[0][6].ToString();
            
            TLabelNombre.Text = "Nombre: " + nombre + "Apellidos: " + apellidos;
            TLabelDNI.Text = "DNI: " + dni + "Telf: " + telf;
            TLabelDirec.Text = "Direccion: " + direc;
            TButtonBuscarCliente.Visible = false;
            TLabelNombre.Visible = true;
            TLabelDirec.Visible = true;
            TLabelDNI.Visible = true;
            TRectangleShapeCliente.Visible = true;
            TButtonEditar.Visible = true;

            TComboBoxConductores.SelectedIndex = TComboBoxConductores.FindStringExact(enRe.Conductores.ToString());
            TComboBoxCategoria.SelectedIndex = TComboBoxCategoria.FindStringExact(enVe.Categoria);
            //TComboBoxMarca
            
            
        }
        private string mens,provincias,ciudades;
        private EN.ENCliente enCliente = new EN.ENCliente();
        private void RellenarMarcas(DataSet dsMar)
        {
            TComboBoxMarca.DataSource = dsMar.Tables["Marcas"];
            TComboBoxMarca.DisplayMember = dsMar.Tables["Marcas"].Columns[0].Caption.ToString();
            TComboBoxMarca.Text = "Seleccione Marca";
        }

        private void RellenarCategoria(DataSet dsCat)
        {
            TComboBoxCategoria.DataSource = dsCat.Tables["Categorias"];
            TComboBoxCategoria.DisplayMember = dsCat.Tables["Categorias"].Columns[0].Caption.ToString();
            TComboBoxCategoria.Text = "Seleccione Categoria";
        }

        private void RellenarModelos(DataSet dsMod)
        {
            TComboBoxModelo.DataSource = dsMod.Tables["Modelos"];
            TComboBoxModelo.DisplayMember = dsMod.Tables["Modelos"].Columns[0].Caption.ToString();
            TComboBoxModelo.Text = "Seleccione Modelo";
        }

        private void RellenarMatriculas(DataSet dsMod)
        {
            TComboBoxMatricula.DataSource = dsMod.Tables["Vehiculo"];
            TComboBoxMatricula.DisplayMember = dsMod.Tables["Vehiculo"].Columns[0].Caption.ToString();
            TComboBoxMatricula.Text = "Seleccione Matricula";
        }

        public AltaReservas()
        {
            InitializeComponent();
        }

        private void AltaReservas_Load(object sender, EventArgs e)
        {
            TDateTimePickerFechaInicio.Value = TDateTimePickerFechaFin.Value = DateTime.Today;
            EN.ENReservas enRes = new EN.ENReservas();
            DataSet dsRes = new DataSet();
            dsRes = enRes.RellenarCategoria();
            RellenarCategoria(dsRes); 
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
            TButtonBuscarCliente.Visible = false;
            TLabelInfoCliente.Visible = true;
            TButtonBuscarOtro.Visible = true;
            TButtonEditar.Visible = true;
            TRectangleShapeCliente.Visible = true;
        }


 
        private void TComboBoxCategoria_TextChanged(object sender, EventArgs e)
        {

            EN.ENVehiculo enVe = new EN.ENVehiculo();
            DataSet dsVe = new DataSet();
            dsVe = enVe.ObtenerMarcas(TComboBoxCategoria.Text.ToString());
            RellenarMarcas(dsVe);
        }

        private void TComboBoxModelo_TextChanged(object sender, EventArgs e)
        {
            EN.ENVehiculo enVe = new EN.ENVehiculo();
            DataSet dsVe = new DataSet();
            dsVe = enVe.ObtenerMatriculas(TComboBoxMarca.Text.ToString(), TComboBoxModelo.Text.ToString());
            RellenarMatriculas(dsVe);
        }

        private bool Comprobar_OK()
        {
            bool retorno = true;
            if (TLabelErrorFecha.Visible)
            {
                mens = "Fecha fin no puede ser superior a fecha inicio";
                retorno = false;
            }
            if (TComboBoxCategoria.Text == "Seleccione Categoria" || TComboBoxMarca.Text == "Seleccione Marca" || TComboBoxMatricula.Text == "Seleccione Matricula" || TComboBoxModelo.Text == "Seleccione Modelo")
            {
                mens = "Falta añadir vehiculo";
                retorno = false;
                TLabelSinCoche.Visible = true;
            }
            else
            {
                TLabelSinCoche.Visible = false;
            }
            if (TComboBoxConductores.Text == "Nº")
            {
                mens = "Falta añadir conductores";
                retorno = false;
                TLabelSinConductores.Visible = true;
            }
            else
            {
                TLabelSinConductores.Visible = false;
            }
            if (TLabelDNI.Visible == false)
            {
                mens = "Falta seleccionar un cliente";
                retorno = false;
            }
            return retorno;
        }

        private void TButtonReserva_Click(object sender, EventArgs e)
        {
            if (!Comprobar_OK())
            {
                MessageBox.Show(mens, "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EN.ENReservas enRe = new EN.ENReservas();
                EN.ENVehiculo enVe = new EN.ENVehiculo();
                enVe.Matricula = TComboBoxMatricula.Text.ToString();
                enRe.Cliente = enCliente.DNI;
                enRe.Conductores = Int32.Parse(TComboBoxConductores.Text);
                enRe.FechaFin = TDateTimePickerFechaFin.Value;
                enRe.FechaInicio = TDateTimePickerFechaInicio.Value;
                enRe.Matricula = TComboBoxMatricula.Text.ToString();
                enRe.Modelo = TComboBoxModelo.Text.ToString();
                enRe.AnyadirReserva();
                enVe.ObtenerDatosVehiculos();
                enVe.Estado = "Reservado";
                enVe.EditarVehiculo();
                MessageBox.Show("Reserva realizada con éxito", "Nueva Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    
            private void TDateTimePickerFechaFin_ValueChanged(object sender, EventArgs e)
            {
                if (TDateTimePickerFechaInicio.Value > TDateTimePickerFechaFin.Value)
                {
                    TLabelErrorFecha.Visible = true;
                }
                else
                {
                    TLabelErrorFecha.Visible = false;
                }
            }

        private void TDateTimePickerFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (TDateTimePickerFechaInicio.Value > TDateTimePickerFechaFin.Value)
            {
                TLabelErrorFecha.Visible = true;
            }
            else
            {
                TLabelErrorFecha.Visible = false;
            }
        }

        private void TComboBoxMarca_TextChanged(object sender, EventArgs e)
        {
            EN.ENVehiculo enVe = new EN.ENVehiculo();
            DataSet dsVe = new DataSet();
            dsVe = enVe.ObtenerModelosVehiculos(TComboBoxCategoria.Text.ToString(), TComboBoxMarca.Text.ToString());
            RellenarModelos(dsVe);
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TButtonEditar_Click(object sender, EventArgs e)
        {
            GestionClientes Formu = new GestionClientes(enCliente,"Guardar Cambios",provincias,ciudades);
            Formu.StartPosition = FormStartPosition.CenterScreen;
            Formu.ShowDialog();
        }
    }
}

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
            EN.ENReservas enRes = new EN.ENReservas();
            DataSet dsRes = new DataSet();
            dsRes = enRes.RellenarCategoria();
            RellenarCategoria(dsRes); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionClientesBuscar F1 = new GestionClientesBuscar(false);
            F1.ShowDialog();
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

        private bool Comprobar_OK(string mens)
        {
            bool retorno = true;
            if (TLabelErrorFecha.Visible)
            {
                mens = "Fecha fin no puede ser superior a fecha inicio";
            }
            return retorno;
        }
  
        private void TButtonReserva_Click(object sender, EventArgs e)
        {
            if (TLabelErrorFecha.Visible)
            {
                MessageBox.Show("Fecha fin no puede ser superior a fecha inicio", "Fechas incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            EN.ENReservas enRe = new EN.ENReservas();
            DataSet dsRe = new DataSet();
            dsRe = enRe.ObtenerReservas();
            DataTable dtRe = new DataTable();
            dtRe = dsRe.Tables["Reservas"];
            DataRow drRe = dtRe.NewRow();
            drRe[1] = "11111111A";
            drRe[2] = TComboBoxMatricula.Text;
            drRe[3] = TDateTimePickerFechaInicio.Text;
            drRe[4] = TDateTimePickerFechaFin.Text;
            drRe[5] = TComboBoxConductores.Text;
            dtRe.Rows.Add(drRe);
            if (enRe.ActualizarReservas(dsRe))
            {
                MessageBox.Show("Reserva realizada con éxito", "Nueva Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
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
    }
}

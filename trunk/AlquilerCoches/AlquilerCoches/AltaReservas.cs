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
            TComboBoxMatricula.DataSource = dsMod.Tables["Matriculas"];
            TComboBoxMatricula.DisplayMember = dsMod.Tables["Matriculas"].Columns[0].Caption.ToString();
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
            dsVe = enVe.ObtenerListaModelosVehiculos(TComboBoxCategoria.Text.ToString());
            RellenarModelos(dsVe);
        }

        private void TComboBoxModelo_TextChanged(object sender, EventArgs e)
        {
            EN.ENVehiculo enVe = new EN.ENVehiculo();
            DataSet dsVe = new DataSet();
            dsVe = enVe.ObtenerListaMatriculasVehiculos(TComboBoxModelo.Text.ToString());
            RellenarMatriculas(dsVe);
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
    }
}

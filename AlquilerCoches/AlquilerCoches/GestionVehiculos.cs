using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AlquilerCoches
{
    public partial class GestionVehiculos : Form
    {
        private string accion;
        private EN.ENVehiculo vehiculos = new EN.ENVehiculo();
        public GestionVehiculos()
        {
            InitializeComponent();
            TGroupBoxSeleccion.Enabled = false;
            TGroupBoxDatosVehiculo.Enabled = false;
        }

        public void setTipo(string Option)
        {
            switch (Option)
            {
                case "Editar":
                    break;
                case "Buscar":
                    TButtonBuscar_Click(null, null);
                    break;
                case "Insertar":
                    break;
                case "Borrar":
                    break;
            }
        }

        private void GestionVehiculos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Dispose();
        }

        private void TTextBoxMatricula_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxMatricula.Text, @"^\d{4}-\w$"))
            {
                errorProvider1.SetError(TTextBoxMatricula, "Formato de la matricula: dddd-x");
            }
            else
            {
                errorProvider1.SetError(TTextBoxMatricula, "");
            }

        }

        private void TTextBoxMarca_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxMarca.Text, @"^\w+$"))
            {
                errorProvider1.SetError(TTextBoxMarca, "Solo se adminten nombres con letras");
            }
            else
            {
                errorProvider1.SetError(TTextBoxMarca, "");
            }
        }

        private void TTextBoxModelo_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxModelo.Text, @"^[\w\d]+$"))
            {
                errorProvider1.SetError(TTextBoxModelo, "Solo se adminten nombres con letras y numeros");
            }
            else
            {
                errorProvider1.SetError(TTextBoxModelo, "");
            }
        }

        private void TTextBoxAnyo_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxAnyo.Text, @"^\d{4}$"))
            {
                errorProvider1.SetError(TTextBoxAnyo, "Solo se adminten numeros");
            }
            else
            {
                if (Int32.Parse(TTextBoxAnyo.Text) < 1960 || Int32.Parse(TTextBoxAnyo.Text) > DateTime.Now.Year)
                {
                    errorProvider1.SetError(TTextBoxAnyo, "Solo se adminten anyos entre 1960-actual");
                }
                else
                {
                    errorProvider1.SetError(TTextBoxAnyo, "");
                }
            }
        }

        private void TTextBoxPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxPrecioCompra.Text, @"^\d+$"))
            {
                errorProvider1.SetError(TTextBoxPrecioCompra, "Solo se adminten numeros");
            }
            else
            {
                if (Int32.Parse(TTextBoxPrecioCompra.Text) < 0)
                {
                    errorProvider1.SetError(TTextBoxPrecioCompra, "Solo se adminten valores mayores que cero");
                }
                else
                {
                    errorProvider1.SetError(TTextBoxPrecioCompra, "");
                }
            }
        }

        private void TTextBoxPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxPrecioVenta.Text, @"^\d+$"))
            {
                errorProvider1.SetError(TTextBoxPrecioVenta, "Solo se adminten numeros");
            }
            else
            {
                if (Int32.Parse(TTextBoxPrecioVenta.Text) < 0)
                {
                    errorProvider1.SetError(TTextBoxPrecioVenta, "Solo se adminten valores mayores que cero");
                }
                else
                {
                    errorProvider1.SetError(TTextBoxPrecioVenta, "");
                }
            }
        }

        private void TTextBoxPrecioAlquiler_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxPrecioAlquiler.Text, @"^\d+$"))
            {
                errorProvider1.SetError(TTextBoxPrecioAlquiler, "Solo se adminten numeros");
            }
            else
            {
                if (Int32.Parse(TTextBoxPrecioAlquiler.Text) < 0)
                {
                    errorProvider1.SetError(TTextBoxPrecioAlquiler, "Solo se adminten valores mayores que cero");
                }
                else
                {
                    errorProvider1.SetError(TTextBoxPrecioAlquiler, "");
                }
            }
        }

        private void TTextBoxKM_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxKM.Text, @"^\d+$"))
            {
                errorProvider1.SetError(TTextBoxKM, "Solo se adminten numeros");
            }
            else
            {
                if (Int32.Parse(TTextBoxKM.Text) < 0)
                {
                    errorProvider1.SetError(TTextBoxKM, "Solo se adminten valores mayores que cero");
                }
                else
                {
                    errorProvider1.SetError(TTextBoxKM, "");
                }
            }
        }

        private void TTextBoxGarantia_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxGarantia.Text, @"^\d+$"))
            {
                errorProvider1.SetError(TTextBoxGarantia, "Solo se adminten numeros");
            }
            else
            {
                if (Int32.Parse(TTextBoxGarantia.Text) < 0)
                {
                    errorProvider1.SetError(TTextBoxGarantia, "Solo se adminten valores mayores que cero");
                }
                else
                {
                    errorProvider1.SetError(TTextBoxGarantia, "");
                }
            }
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TButtonBuscar_Click(object sender, EventArgs e)
        {
            accion = "Buscar";
            TGroupBoxSeleccion.Enabled = true;
            TGroupBoxDatosVehiculo.Enabled = false;
            TGroupBoxAccion.Enabled = false;
            TButtonCancelar.Enabled = true;
            rellenaMarcas();
        }

        private void TButtonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar?\n Se perderan los cambios no guardados", "¿CANCELAR?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                TGroupBoxAccion.Enabled = true;
                TGroupBoxDatosVehiculo.Enabled = false;
                TGroupBoxSeleccion.Enabled = false;
                TButtonCancelar.Enabled = false;
                TButtonOK.Enabled = false;
            }
        }

        private void rellenaMarcas()
        {
            TListBoxMarcas.Items.Clear();
            TListBoxModelos.Items.Clear();
            TListBoxMatriculas.Items.Clear();
            DataSet listamarcas = vehiculos.ObtenerMarcas();
            for (int i = 0; !listamarcas.Tables["Vehiculo"].Rows.Count.Equals(i); i++)
                if (!TListBoxMarcas.Items.Contains(listamarcas.Tables["Vehiculo"].Rows[i].ItemArray[0])) TListBoxMarcas.Items.Add(listamarcas.Tables["Vehiculo"].Rows[i].ItemArray[0]);

        }

        private void TListBoxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TListBoxMarcas.SelectedIndex != -1)
            {
                TListBoxModelos.Items.Clear();
                DataSet listaModelos = vehiculos.ObtenerModelo(TListBoxMarcas.Items[TListBoxMarcas.SelectedIndex].ToString());
                for (int i = 0; !listaModelos.Tables["Vehiculo"].Rows.Count.Equals(i); i++)
                    if (!TListBoxModelos.Items.Contains(listaModelos.Tables["Vehiculo"].Rows[i].ItemArray[0])) TListBoxModelos.Items.Add(listaModelos.Tables["Vehiculo"].Rows[i].ItemArray[0]);
            }
        }

        private void TListBoxModelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TListBoxModelos.SelectedIndex != -1)
            {
                //MessageBox.Show(TListBoxMarcas.Items[TListBoxMarcas.SelectedIndex].ToString(), TListBoxModelos.Items[TListBoxModelos.SelectedIndex].ToString());
                TListBoxMatriculas.Items.Clear();
                DataSet listaMatriculas = vehiculos.ObtenerMatriculas(TListBoxMarcas.Items[TListBoxMarcas.SelectedIndex].ToString(), TListBoxModelos.Items[TListBoxModelos.SelectedIndex].ToString());
                for (int i = 0; !listaMatriculas.Tables["Vehiculo"].Rows.Count.Equals(i); i++)
                    if (!TListBoxMatriculas.Items.Contains(listaMatriculas.Tables["Vehiculo"].Rows[i].ItemArray[0])) TListBoxMatriculas.Items.Add(listaMatriculas.Tables["Vehiculo"].Rows[i].ItemArray[0]);
            }
        }

        private void TListBoxMatriculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TListBoxMatriculas.SelectedIndex != -1)
            {
                if (accion == "Buscar")
                {
                    TGroupBoxDatosVehiculo.Enabled = false;
                    TGroupBoxAccion.Enabled = true;
                    TButtonCancelar.Enabled = false;
                }
                TGroupBoxSeleccion.Enabled = false;

                DataSet DatosVehiculo = vehiculos.ObtenerDatosVehiculos(TListBoxMatriculas.Items[TListBoxMatriculas.SelectedIndex].ToString());

                TTextBoxMatricula.Text = DatosVehiculo.Tables["Vehiculo"].Rows[0][0].ToString();
                TTextBoxMarca.Text = DatosVehiculo.Tables["Vehiculo"].Rows[0][1].ToString();
                TTextBoxModelo.Text = DatosVehiculo.Tables["Vehiculo"].Rows[0][2].ToString();
            }
        }

        private void TButtonAnyadir_Click(object sender, EventArgs e)
        {
            accion = "Anyadir";
        }
    }
}

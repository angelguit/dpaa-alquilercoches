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
            DataSet dsProv = vehiculos.ObtenerCategorias();
            TComboBoxCategoria.DataSource = dsProv.Tables["Categoria"];
            TComboBoxCategoria.DisplayMember = dsProv.Tables["Categoria"].Columns[0].Caption.ToString();
            limpiaFormulario();

        }

        public void setTipo(string Option)
        {
            switch (Option)
            {
                case "Editar":
                    TButtonEditar_Click(null, null);
                    break;
                case "Buscar":
                    TButtonBuscar_Click(null, null);
                    break;
                case "Insertar":
                    TButtonAnyadir_Click(null, null);
                    break;
                case "Borrar":
                    TButtonBorrar_Click(null, null);
                    break;
            }
        }

        public void limpiaFormulario()
        {
            vehiculos.ClearEnVehiculo();
            TListBoxMarcas.Items.Clear();
            TListBoxMatriculas.Items.Clear();
            TListBoxModelos.Items.Clear();
            
            TTextBoxGarantia.Text = "";
            TTextBoxKM.Text = "";
            TTextBoxMarca.Text = "";
            TTextBoxMatricula.Text = "";
            TTextBoxModelo.Text = "";
            TTextBoxPrecioCompra.Text = "";
            TTextBoxPrecioVenta.Text = "";
            TComboBoxCategoria.SelectedIndex = -1;

            TTextBoxGarantia.Enabled = true;
            TTextBoxKM.Enabled = true;
            TTextBoxMarca.Enabled = true;
            TTextBoxMatricula.Enabled = true;
            TTextBoxModelo.Enabled = true;
            TComboBoxCategoria.Enabled = true;
            TTextBoxPrecioCompra.Enabled = true;
            TTextBoxPrecioVenta.Enabled = true;
            TButtonOK.Enabled = false;
            TButtonCancelar.Enabled = false;
            TRadioButtonEstado.Checked = false;
            TRadioButtonRevision.Checked = false;
            errorProvider1.Clear();
        }

        private void GestionVehiculos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Dispose();
        }

        private void TTextBoxMatricula_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxMatricula.Text, @"^\d{4}\w{3}$"))
            {
                errorProvider1.SetError(TTextBoxMatricula, "Formato de la matricula: ddddxxx");
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
                errorProvider1.SetError(TTextBoxMarca, "Solo se adminten Marcas con letras");
            }
            else
            {
                errorProvider1.SetError(TTextBoxMarca, "");
            }

            foreach (string marca in vehiculos.ListaMarcas)
            {
                if (String.Compare(marca, TTextBoxMarca.Text, true) == 0)
                {
                    TListBoxModelos.Items.Clear();
                    TTextBoxMarca.Text = marca;
                    TListBoxMarcas.SelectedIndex = TListBoxMarcas.FindString(marca);
                    
                    TGroupBoxDatosVehiculo.Enabled = false;
                    TGroupBoxSeleccion.Enabled = true;
                    break;
                }
            }
            TListBoxMarcas_SelectedIndexChanged(null, null);
        }

        private void TTextBoxModelo_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TTextBoxModelo.Text, @"^[\w\d]+$"))
            {
                errorProvider1.SetError(TTextBoxModelo, "Solo se adminten Modelos con letras y numeros");
            }
            else
            {
                errorProvider1.SetError(TTextBoxModelo, "");
            }
            foreach (string modelo in vehiculos.ListaModelos)
            {
                if (String.Compare(modelo, TTextBoxModelo.Text, true) == 0)
                {
                    //TListBoxModelos.Items.Clear();
                    TTextBoxModelo.Text = modelo;
                    TListBoxModelos.SelectedIndex = TListBoxModelos.FindString(modelo);

                    TGroupBoxDatosVehiculo.Enabled = false;
                    TGroupBoxSeleccion.Enabled = true;
                    break;
                }
            }
            TListBoxModelos_SelectedIndexChanged(null, null);
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

        private void TButtonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar?\n Se perderan los cambios no guardados", "¿CANCELAR?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                limpiaFormulario();
                TGroupBoxAccion.Enabled = true;
                TGroupBoxDatosVehiculo.Enabled = false;
                TGroupBoxSeleccion.Enabled = false;
                TButtonCancelar.Enabled = false;
                TButtonOK.Enabled = false;
            }
        }

        private void rellenaMarcas()
        {
            TGroupBoxSeleccion.Enabled = true;
            TGroupBoxDatosVehiculo.Enabled = false;
            TGroupBoxAccion.Enabled = false;
            TButtonCancelar.Enabled = true;

            TListBoxMarcas.Items.Clear();
            TListBoxModelos.Items.Clear();
            TListBoxMatriculas.Items.Clear();
            vehiculos.ObtenerMarcas();
            TListBoxMarcas.Items.AddRange(vehiculos.ListaMarcas.ToArray());
            if (accion == "Anyadir")
            {
                TListBoxMarcas.Items.Add("[Otra Marca]");
            }
        }

        private void TListBoxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TListBoxMarcas.SelectedIndex != -1)
            {
                if (accion=="Anyadir" && TListBoxMarcas.Items.Count.CompareTo(TListBoxMarcas.SelectedIndex + 1) == 0)
                {
                    TListBoxModelos.Items.Clear();
                    TGroupBoxDatosVehiculo.Enabled = true;
                    TGroupBoxSeleccion.Enabled = false;
                    TButtonOK.Enabled = true;
                }
                else
                {

                    TListBoxModelos.Items.Clear();
                    vehiculos.Marca = TListBoxMarcas.Items[TListBoxMarcas.SelectedIndex].ToString();
                    vehiculos.ObtenerModelo();
                    TListBoxModelos.Items.AddRange(vehiculos.ListaModelos.ToArray());
                    
                    if (accion == "Anyadir")
                    {
                        TListBoxModelos.Items.Add("[Otra Modelo]");
                    }
                    else
                    {
                        TListBoxMatriculas.Items.Clear();
                        vehiculos.ObtenerMatriculas();
                        TListBoxMatriculas.Items.AddRange(vehiculos.ListaMatriculas.ToArray());
                    }
                }
            }
        }

        private void TListBoxModelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TListBoxModelos.SelectedIndex != -1)
            {
                TListBoxMatriculas.Items.Clear();
                
                if (accion == "Anyadir")
                {
                    if (TListBoxModelos.Items.Count.CompareTo(TListBoxModelos.SelectedIndex + 1) != 0)
                    {
                        TTextBoxModelo.Text= vehiculos.Modelo = TListBoxModelos.Items[TListBoxModelos.SelectedIndex].ToString();
                        TTextBoxModelo.Enabled = false;
                    }
                    
                    TTextBoxMarca.Text = TListBoxMarcas.Items[TListBoxMarcas.SelectedIndex].ToString();
                    TTextBoxMarca.Enabled = false;
                    TGroupBoxDatosVehiculo.Enabled = true;
                    TGroupBoxSeleccion.Enabled = false;
                    TButtonOK.Enabled = true;
                }
                else
                {
                    vehiculos.Modelo=TListBoxModelos.Items[TListBoxModelos.SelectedIndex].ToString();
                    vehiculos.ObtenerMatriculas();
                    TListBoxMatriculas.Items.AddRange(vehiculos.ListaMatriculas.ToArray());

                }
            }
        }

        private void TListBoxMatriculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TListBoxMatriculas.SelectedIndex != -1)
            {
                vehiculos.Matricula = TListBoxMatriculas.Items[TListBoxMatriculas.SelectedIndex].ToString();
                switch (accion)
                {
                    case "Buscar":
                        TGroupBoxDatosVehiculo.Enabled = false;
                        TButtonCancelar.Enabled = false;
                        TButtonOK.Enabled = true;
                        
                        break;
                    case "Editar":
                        TGroupBoxDatosVehiculo.Enabled = true;
                        TGroupBoxAccion.Enabled = false;
                        TButtonCancelar.Enabled = true;
                        TButtonOK.Enabled = true;
                        TTextBoxMatricula.Enabled = false;
                        TTextBoxModelo.Enabled = false;
                        TTextBoxMarca.Enabled = false;
                        break;
                    case "Borrar":
                        TGroupBoxDatosVehiculo.Enabled = false;
                        TButtonOK.Enabled = true;
                        break;
                }

                TGroupBoxSeleccion.Enabled = false;
                vehiculos.ObtenerDatosVehiculos();

                rellenaCampos();

            }
        }

        private void TButtonBuscar_Click(object sender, EventArgs e)
        {
            accion = "Buscar";
            errorProvider1.Clear();
            rellenaMarcas();
            vehiculos.Marca = "";
            vehiculos.Modelo = "";
            vehiculos.ObtenerMatriculas();
            TListBoxMatriculas.Items.AddRange(vehiculos.ListaMatriculas.ToArray());
        }

        private void TButtonAnyadir_Click(object sender, EventArgs e)
        {
            accion = "Anyadir";
            errorProvider1.Clear();
            rellenaMarcas();
        }

        private void TButtonEditar_Click(object sender, EventArgs e)
        {
            accion = "Editar";
            errorProvider1.Clear();
            rellenaMarcas();
            vehiculos.Marca = "";
            vehiculos.Modelo = "";
            vehiculos.ObtenerMatriculas();
            TListBoxMatriculas.Items.AddRange(vehiculos.ListaMatriculas.ToArray());
            
        }

        private void TButtonBorrar_Click(object sender, EventArgs e)
        {
            accion = "Borrar";
            errorProvider1.Clear();
            rellenaMarcas();
            vehiculos.Marca = "";
            vehiculos.Modelo = "";
            vehiculos.ObtenerMatriculas();
            TListBoxMatriculas.Items.AddRange(vehiculos.ListaMatriculas.ToArray());
            
        }

        private void TButtonOK_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                switch (accion)
                {
                    case "Borrar":
                        MessageBox.Show(vehiculos.Matricula);
                        vehiculos.BorrarVehiculo();
                        break;
                    case "Editar":
                        guardaCampos();
                        vehiculos.EditarVehiculo();
                        break;
                    case "Anyadir":
                        guardaCampos();
                        if (vehiculos.ComprobarDuplicados())
                        {
                            MessageBox.Show("Exite un vehiculo registrado con la misma matricula", "Error");
                        }
                        else
                        {
                            vehiculos.AnyadirVehiculo();
                        }
                        break;
                }

                TGroupBoxAccion.Enabled = true;
                TButtonOK.Enabled = false;
                errorProvider1.Clear();
                limpiaFormulario();
            }
        }

        void rellenaCampos()
        {
            TTextBoxMatricula.Text = vehiculos.Matricula;
            TTextBoxMarca.Text = vehiculos.Marca;
            TTextBoxModelo.Text = vehiculos.Modelo;
            rellenaCategorias(); 
            TTextBoxGarantia.Text = vehiculos.Garantia;
            TTextBoxKM.Text = vehiculos.KM.ToString();
            TTextBoxPrecioCompra.Text = vehiculos.PrecioCompra.ToString();
            TTextBoxPrecioVenta.Text = vehiculos.PrecioVenta.ToString();
            if (vehiculos.Estado == "Disponible") TRadioButtonEstado.Checked = true;
            else TRadioButtonRevision.Checked = true;
        }
        void guardaCampos()
        {
            vehiculos.Matricula = TTextBoxMatricula.Text;
            vehiculos.Marca = TTextBoxMarca.Text;
            vehiculos.Modelo = TTextBoxModelo.Text;
            guardaCategoria();
            vehiculos.Garantia = TTextBoxGarantia.Text;
            vehiculos.KM = TTextBoxKM.Text;
            vehiculos.PrecioCompra = TTextBoxPrecioCompra.Text;
            vehiculos.PrecioVenta = TTextBoxPrecioVenta.Text;
            vehiculos.Estado = (TRadioButtonEstado.Checked) ? "Disponible" : "Revision";
        }

        void rellenaCategorias()
        {
            
            if (accion == "Anyadir")
            {
                TComboBoxCategoria.SelectedIndex = -1;
            }
            else
            {
                switch (vehiculos.Categoria)
                {
                    case "A":
                        TComboBoxCategoria.SelectedIndex = 0;
                        break;
                    case "B":
                        TComboBoxCategoria.SelectedIndex = 1;
                        break;
                    case "C":
                        TComboBoxCategoria.SelectedIndex = 2;
                        break;
                    case "D":
                        TComboBoxCategoria.SelectedIndex = 3;
                        break;
                }
            }
        }

        void guardaCategoria()
        {
            switch (TComboBoxCategoria.SelectedIndex)
            {
                case 0:
                    vehiculos.Categoria = "A";
                    break;
                case 1:
                    vehiculos.Categoria = "B";
                    break;
                case 2:
                    vehiculos.Categoria = "C";
                    break;
                case 3:
                    vehiculos.Categoria = "D";
                    break;
            }
        }

        bool ValidarCampos()
        {
            bool error = false;
            string comprobar = "";
            comprobar += errorProvider1.GetError(TTextBoxMarca);
            comprobar += errorProvider1.GetError(TTextBoxMatricula);
            comprobar += errorProvider1.GetError(TTextBoxModelo);
            comprobar += errorProvider1.GetError(TTextBoxPrecioCompra);
            comprobar += errorProvider1.GetError(TTextBoxPrecioVenta);
            comprobar += errorProvider1.GetError(TTextBoxKM);
            comprobar += errorProvider1.GetError(TTextBoxGarantia);
            
            if(comprobar != "")
            {
                MessageBox.Show("Solucione los Errores Primero", "ERROR");
                error = true;
            }
            else if (TComboBoxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Categoria", "ERROR");
                error = true;
            }
            else if(TTextBoxMatricula.Text=="" || TTextBoxMarca.Text=="" || TTextBoxModelo.Text=="" || TTextBoxPrecioCompra.Text=="" || TTextBoxPrecioVenta.Text=="" || TTextBoxGarantia.Text=="" || TTextBoxKM.Text=="")
            {
                MessageBox.Show("Hay campos vacios", "ERROR");
                error=true;
            }

            return !error;
        }
    }
}

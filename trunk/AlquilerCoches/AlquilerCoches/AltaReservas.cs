using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace AlquilerCoches
{
    public partial class AltaReservas : Form
    {
        private ErrorProvider err1 = new ErrorProvider();
        private ErrorProvider err2 = new ErrorProvider();
        private ErrorProvider err3 = new ErrorProvider();
        private ErrorProvider err4 = new ErrorProvider();
        private string mens, provincias, ciudades;
        private EN.ENCliente enCliente = new EN.ENCliente();

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
            TComboBoxMarca.Items.Add(enVe.Marca.ToString());
            TComboBoxModelo.Items.Add(enVe.Modelo.ToString());
            TComboBoxMatricula.Items.Add(enVe.Matricula.ToString());
            TDateTimePickerFechaFin.Value = enRe.FechaFin;
            TDateTimePickerFechaInicio.Value = enRe.FechaInicio;
            TButtonReserva.Text = texto;
            
            
        }

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
            F1.StartPosition = FormStartPosition.Manual;
            F1.Location = Location;
            F1.Left += 147;
            F1.Top += 48;
            F1.ShowDialog();
            
            enCliente = F1.enClientePub;
            if (enCliente.Nombre != null)
            {
                if (enCliente.ReservaActiva())
                {
                    if (MessageBox.Show("El usuario seleccionado ya tiene una reserva activa,¿Desea continuar?", "Usuario con reserva activa", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
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

                        if (enCliente.ReservasCliente() > 0)
                        {
                            TRadioButtonFavorito.Visible = true;
                            TRadioButtonUltimoCoche.Visible = true;
                            TLabelResRapida.Visible = true;
                        }
                    }
                }
                else
                {
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

                    if (enCliente.ReservasCliente() > 0)
                    {
                        TRadioButtonFavorito.Visible = true;
                        TRadioButtonUltimoCoche.Visible = true;
                        TLabelResRapida.Visible = true;
                    }
                }
         
            }
        }


 
        private void TComboBoxCategoria_TextChanged(object sender, EventArgs e)
        {

            EN.ENVehiculo enVe = new EN.ENVehiculo();
            DataSet dsVe = new DataSet();
            dsVe = enVe.ObtenerMarcas(TComboBoxCategoria.Text.ToString());
            RellenarMarcas(dsVe);
            if (TComboBoxMarca.Text == "")
            {
                err2.SetError(TComboBoxMatricula, "Falta seleccionar vehículo");
            }
            else
            {
                err2.Clear();
            }
        }

        private void TComboBoxModelo_TextChanged(object sender, EventArgs e)
        {
            EN.ENVehiculo enVe = new EN.ENVehiculo();
            DataSet dsVe = new DataSet();
            dsVe = enVe.ObtenerMatriculas(TComboBoxMarca.Text.ToString(), TComboBoxModelo.Text.ToString());
            RellenarMatriculas(dsVe);
            if (TComboBoxModelo.Text == "")
            {
                err2.SetError(TComboBoxMatricula, "Falta seleccionar vehículo");
            }
            else
            {
                err2.Clear();
            }
        }

        private bool Comprobar_OK()
        {
            bool retorno = true;
            if (TDateTimePickerFechaFin.Value < TDateTimePickerFechaInicio.Value)
            {
                mens = "Fecha fin no puede ser superior a fecha inicio";
                retorno = false;
            }
            if (TComboBoxCategoria.Text == "Seleccione Categoria" || TComboBoxMarca.Text == "Seleccione Marca" || TComboBoxMatricula.Text == "Seleccione Matricula" || TComboBoxModelo.Text == "Seleccione Modelo")
            {
                mens = "Falta añadir vehiculo";
                retorno = false;
            }

            if (TComboBoxConductores.Text == "")
            {
                mens = "Falta añadir conductores";
                retorno = false;
                err3.SetError(TComboBoxConductores, "Falta seleccionar conductores");
            }
            else
            {
                err3.Clear();
            }

            if (TLabelDNI.Visible == false)
            {
                mens = "Falta seleccionar un cliente";
                retorno = false;
                err4.SetError(TButtonBuscarCliente, "Falta seleccionar cliente");
            }
            else
            {
                err4.Clear();
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
                enRe.Activa = true;
                enRe.AnyadirReserva();
                enVe.ObtenerDatosVehiculos();
                enVe.Estado = "Reservado";
                enVe.EditarVehiculo();
                MessageBox.Show("Reserva realizada con éxito", "Nueva Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TPrintFormReservas.Print(this,Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintOption.Scrollable);
                Close();
            }
        }
    
            private void TDateTimePickerFechaFin_ValueChanged(object sender, EventArgs e)
            {
                if (TDateTimePickerFechaInicio.Value > TDateTimePickerFechaFin.Value)
                {
                    err1.SetError(TDateTimePickerFechaFin, "Fecha fin no puede ser inferior a fecha inicio");
                }
                else
                {
                    err1.Clear();
                }
            }

        private void TDateTimePickerFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (TDateTimePickerFechaInicio.Value > TDateTimePickerFechaFin.Value)
            {
                err1.SetError(TDateTimePickerFechaFin, "Fecha fin no puede ser inferior a fecha inicio");
            }
            else
            {
                err1.Clear();
            }
        }

        private void TComboBoxMarca_TextChanged(object sender, EventArgs e)
        {
            EN.ENVehiculo enVe = new EN.ENVehiculo();
            DataSet dsVe = new DataSet();
            dsVe = enVe.ObtenerModelosVehiculos(TComboBoxCategoria.Text.ToString(), TComboBoxMarca.Text.ToString());
            RellenarModelos(dsVe);
            if (TComboBoxMarca.Text == "")
            {
                err2.SetError(TComboBoxMatricula, "Falta seleccionar vehículo");
            }
            else
            {
                err2.Clear();
            }
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TButtonEditar_Click(object sender, EventArgs e)
        {
            EN.ENCliente enCli = new EN.ENCliente();
            GestionClientes Formu = new GestionClientes(enCliente,"Guardar Cambios",provincias,ciudades);
            Formu.StartPosition = FormStartPosition.Manual;
            Formu.Location = Location;
            Formu.Left += 147;
            Formu.Top += 48;
            Formu.ShowDialog();
            enCli = Formu.enCliPub;
            if (Formu.cambios)
            {
                TLabelNombre.Text = "Nombre: " + enCli.Nombre + "Apellidos: " + enCli.Apellidos;
                TLabelDNI.Text = "DNI: " + enCli.DNI + " " + "Telf: " + enCli.Telefono;
                TLabelDirec.Text = "Direccion: " + enCli.Direccion;
            }

        }

        private void TRadioButtonUltimoCoche_CheckedChanged(object sender, EventArgs e)
        {
            if (TRadioButtonUltimoCoche.Checked == true)
            {
                MessageBox.Show(enCliente.UltimaReserva());
            }
        }

        private void TRadioButtonFavorito_CheckedChanged(object sender, EventArgs e)
        {
            if (TRadioButtonFavorito.Checked == true)
            {
                char[] separadores = { '|', ',' };
                string[] favorito = enCliente.ReservaFavorita().Split(separadores);

                TComboBoxCategoria.SelectedIndex = TComboBoxCategoria.FindStringExact(favorito[2]);
                if (TComboBoxMarca.FindStringExact(favorito[0]) == -1 && TComboBoxMatricula.Text != "")
                {
                    MessageBox.Show("No hay modelos disponibles, se ha escogido un modelo de igual categoría");
                }
                else if (TComboBoxMarca.FindStringExact(favorito[0]) > -1 && TComboBoxMatricula.Text != "")
                {
                    TComboBoxMarca.SelectedIndex = TComboBoxMarca.FindStringExact(favorito[0]);
                    if (TComboBoxModelo.FindStringExact(favorito[1]) < 0)
                    {
                        MessageBox.Show("No hay modelos disponibles, se ha escogido un modelo de igual categoría y marca");
                    }
                    else
                    {
                        TComboBoxModelo.SelectedIndex = TComboBoxModelo.FindStringExact(favorito[1]);
                        MessageBox.Show("Se ha escogido el vehiculo " + favorito[0] + " " + favorito[1] + ".");
                    }
                }
                else
                {
                    MessageBox.Show("No hay modelos disponibles de la misma categoría");
                }
            }
        }

        private void TComboBoxMatricula_TextChanged(object sender, EventArgs e)
        {
            if (TComboBoxMatricula.Text == "")
            {
                err2.SetError(TComboBoxMatricula, "Falta seleccionar vehículo");
            }
            else
            {
                err2.Clear();
            }
        }

        private void TComboBoxConductores_TextChanged(object sender, EventArgs e)
        {
            if (TComboBoxConductores.Text == "")
            {
                err3.SetError(TComboBoxConductores, "Falta seleccionar conductores");
            }
            else
            {
                err3.Clear();
            }
        }

        private void TLabelNombre_VisibleChanged(object sender, EventArgs e)
        {
            if ( TLabelNombre.Visible == false)
            {
                err4.SetError(TButtonBuscarCliente, "Falta seleccionar cliente");
            }
            else
            {
                err4.Clear();
                
            }
        }

    }
}

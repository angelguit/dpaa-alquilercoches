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
        private bool editar = false,editar2 = false;
        private EN.ENReservas aux = new EN.ENReservas();
        private EN.ENFacturacion enFa = new EN.ENFacturacion();

        public AltaReservas()
        {
            InitializeComponent();
        }
        public AltaReservas(EN.ENReservas enRe, string texto)
        {
            InitializeComponent();
            editar = editar2 = true;
            DataSet dsCli = new DataSet();
            EN.ENVehiculo enVe = new EN.ENVehiculo();
            EN.ENReservas enRes = new EN.ENReservas();
            DataSet dsRes = new DataSet();

            enCliente.DNI = enRe.Cliente;
            aux = enRe;
            dsCli = enCliente.ObtenerDatosClienteConDni(enRe.Cliente.ToString());
            enVe.Matricula = enRe.Matricula;
            enVe.ObtenerDatosVehiculos();
            
            string nombre = dsCli.Tables["Cliente"].Rows[0][1].ToString();
            string apellidos = dsCli.Tables["Cliente"].Rows[0][2].ToString();
            string dni = dsCli.Tables["Cliente"].Rows[0][0].ToString();
            string telf = dsCli.Tables["Cliente"].Rows[0][3].ToString();
            string direc = dsCli.Tables["Cliente"].Rows[0][5].ToString();
            provincias = dsCli.Tables["Cliente"].Rows[0][6].ToString();
            ciudades = dsCli.Tables["Cliente"].Rows[0][7].ToString();
            string sexo = dsCli.Tables["Cliente"].Rows[0][9].ToString();
            enCliente.Sexo = sexo;
           
 
            TLabelNombre.Text = "Nombre: " + nombre + "Apellidos: " + apellidos;
            TLabelDNI.Text = "DNI: " + dni + "Telf: " + telf;
            TLabelDirec.Text = "Direccion: " + direc;
            TButtonBuscarCliente.Visible = false;
            TLabelNombre.Visible = true;
            TLabelDirec.Visible = true;
            TLabelDNI.Visible = true;
            TRectangleShapeCliente.Visible = true;
            TButtonEditar.Visible = true;
            TButtonReserva.Text = texto;

            TComboBoxConductores.SelectedIndex = TComboBoxConductores.FindStringExact(enRe.Conductores.ToString());
            TDateTimePickerFechaFin.Value = enRe.FechaFin;
            TDateTimePickerFechaInicio.Value = enRe.FechaInicio;
            TComboBoxCategoria.Items.Add(enVe.Categoria);
            TComboBoxCategoria.SelectedIndex = 0;
            TComboBoxMarca.Items.Add(enVe.Marca);
            TComboBoxMarca.SelectedIndex = 0;
            TComboBoxModelo.Items.Add(enVe.Modelo);
            TComboBoxModelo.SelectedIndex = 0;
            TComboBoxMatricula.Items.Add(enVe.Matricula);
            TComboBoxMatricula.SelectedIndex = 0;
            
        }

        private void RellenarMarcas(DataSet dsMar)
        {
            if (!editar)
            {
                TComboBoxMarca.DataSource = dsMar.Tables["Marcas"];
                TComboBoxMarca.DisplayMember = dsMar.Tables["Marcas"].Columns[0].Caption.ToString();
            }
        }

        private void RellenarCategoria(DataSet dsCat)
        {
            TComboBoxCategoria.DataSource = dsCat.Tables["Categorias"];
            TComboBoxCategoria.DisplayMember = dsCat.Tables["Categorias"].Columns[0].Caption.ToString();
        }

        private void RellenarModelos(DataSet dsMod)
        {
            if (!editar)
            {
                TComboBoxModelo.DataSource = dsMod.Tables["Modelos"];
                TComboBoxModelo.DisplayMember = dsMod.Tables["Modelos"].Columns[0].Caption.ToString();
            }
        }

        private void RellenarMatriculas(DataSet dsMod)
        {
            if (!editar)
            {
                TComboBoxMatricula.DataSource = dsMod.Tables["Vehiculo"];
                TComboBoxMatricula.DisplayMember = dsMod.Tables["Vehiculo"].Columns[0].Caption.ToString();
            }
        }

        

        private void AltaReservas_Load(object sender, EventArgs e)
        {
            if (!editar)
            {
                TDateTimePickerFechaInicio.Value = TDateTimePickerFechaFin.Value = DateTime.Today;
                EN.ENReservas enRes = new EN.ENReservas();
                DataSet dsRes = new DataSet();
                dsRes = enRes.RellenarCategoria();
                RellenarCategoria(dsRes);
            }
        }


        private void TButtonBuscarCliente_Click(object sender, EventArgs e)
        {
            TimeSpan ts = TDateTimePickerFechaFin.Value - TDateTimePickerFechaInicio.Value;
            GestionClientesBuscar F1 = new GestionClientesBuscar(false);
            F1.StartPosition = FormStartPosition.Manual;
            F1.Location = Location;
            F1.Left += 147;
            F1.Top += 44;
            F1.ShowDialog();

            if (F1.enClientePub.Nombre != null)
            {
                enCliente = F1.enClientePub;
                if (enCliente.ReservaActiva())
                {
                    if (MessageBox.Show("El usuario seleccionado ya tiene una reserva activa,¿Desea continuar?", "Usuario con reserva activa", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        provincias = F1.provincias;
                        ciudades = F1.ciudades;
                        TLabelNombre.Text = "Nombre: " + enCliente.Nombre + "Apellidos: " + enCliente.Apellidos;
                        TLabelDNI.Text = "DNI: " + enCliente.DNI + " " + "Telf: " + enCliente.Telefono;
                        TLabelDirec.Text = "Direccion: " + enCliente.Direccion;
                        TLabelTarifa.Text = "Tarifa aplicada: " + enCliente.Tarifa;
                        if (TComboBoxConductores.Text == "")
                            enFa.Conductores = 1;
                        else
                            enFa.Conductores = Int32.Parse(TComboBoxConductores.Text.ToString());
                        enFa.Tarifa = enCliente.Tarifa;
                        enFa.Tiempo = ts.Days + 1;
                        enFa.Categoria = TComboBoxCategoria.Text;
                        enFa.ObtenerPrecio();
                        TTextBoxPrecio.Text = enFa.PrecioTotal.ToString();
                        TLabelTarifa.Visible = true;
                        TLabelPrecio.Visible = true;
                        TTextBoxPrecio.Visible = true;
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
                    TLabelTarifa.Text = "Tarifa aplicada: " + enCliente.Tarifa;
                    if (TComboBoxConductores.Text == "")
                        enFa.Conductores = 1;
                    else
                        enFa.Conductores = Int32.Parse(TComboBoxConductores.Text.ToString());
                    enFa.Tarifa = enCliente.Tarifa;
                    enFa.Tiempo = ts.Days + 1;
                    enFa.Categoria = TComboBoxCategoria.Text;
                    enFa.ObtenerPrecio();
                    TTextBoxPrecio.Text = enFa.PrecioTotal.ToString();
                    TLabelTarifa.Visible = true;
                    TLabelPrecio.Visible = true;
                    TTextBoxPrecio.Visible = true;
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
                TComboBoxMatricula.DataSource = null;
            }
            else
            {
                if (enFa.ExisteCat(TComboBoxCategoria.Text.ToString()) && enCliente.Nombre != null)
                {
                    enFa.Categoria = TComboBoxCategoria.Text.ToString();
                    enFa.ObtenerPrecio();
                    TTextBoxPrecio.Text = enFa.PrecioTotal.ToString();
                }
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
                enRe.NumRes = aux.NumRes;

                if (TButtonReserva.Text == "Realizar Reserva")
                {
                    enRe.AnyadirReserva();
                    MessageBox.Show("Reserva realizada con éxito", "Nueva Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    enRe.EditarReserva();
                    MessageBox.Show("Cambios guardados con éxito", "Editar Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                enVe.ObtenerDatosVehiculos();
                enVe.Estado = "Reservado";
                enVe.EditarVehiculo();
                ImprimirReserva FPrint = new ImprimirReserva(enCliente,enRe,enVe,enRe.NumeroUltimaReserva(),enFa.PrecioTotal,TLabelTarifa.Text.ToString());
                FPrint.Show(); 
                FPrint.Imprimir();

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
                    TimeSpan ts = TDateTimePickerFechaFin.Value - TDateTimePickerFechaInicio.Value;
                    enFa.Tiempo = ts.Days + 1;
                    if (enCliente.Nombre != null)
                    {
                        enFa.ObtenerPrecio();
                        TTextBoxPrecio.Text = enFa.PrecioTotal.ToString();
                    }
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
                TimeSpan ts = TDateTimePickerFechaFin.Value - TDateTimePickerFechaInicio.Value;
                enFa.Tiempo = ts.Days + 1;
                if (enCliente.Nombre != null)
                {
                    enFa.ObtenerPrecio();
                    TTextBoxPrecio.Text = enFa.PrecioTotal.ToString();
                }
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
            if (!editar2)
            {
                Formu.Left += 147;
                Formu.Top += 44;
            }
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
                EN.ENVehiculo enVe = new EN.ENVehiculo();

                enVe.Matricula = enCliente.UltimaReserva();
                enVe.ObtenerDatosVehiculos();

                TComboBoxCategoria.SelectedIndex = TComboBoxCategoria.FindStringExact(enVe.Categoria);
                if (TComboBoxMarca.FindStringExact(enVe.Marca) == -1 && TComboBoxMatricula.Text != "")
                {
                    MessageBox.Show("No hay modelos disponibles, se ha escogido un modelo de igual categoría", "No hay modelos disponibles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (TComboBoxMarca.FindStringExact(enVe.Marca) > -1 && TComboBoxMatricula.Text != "")
                {
                    TComboBoxMarca.SelectedIndex = TComboBoxMarca.FindStringExact(enVe.Marca);
                    if (TComboBoxModelo.FindStringExact(enVe.Modelo) < 0)
                    {
                        MessageBox.Show("No hay modelos disponibles, se ha escogido un modelo de igual categoría y marca","No hay modelos disponibles",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        TComboBoxModelo.SelectedIndex = TComboBoxModelo.FindStringExact(enVe.Modelo);
                        MessageBox.Show("Se ha escogido el vehiculo " + enVe.Marca + " " + enVe.Modelo + ".","Vehículo favorito seleccionado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No hay modelos disponibles de la misma categoría","No hay modelos disponibles",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
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
                    MessageBox.Show("No hay modelos disponibles, se ha escogido un modelo de igual categoría","No hay modelos disponibles",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else if (TComboBoxMarca.FindStringExact(favorito[0]) > -1 && TComboBoxMatricula.Text != "")
                {
                    TComboBoxMarca.SelectedIndex = TComboBoxMarca.FindStringExact(favorito[0]);
                    if (TComboBoxModelo.FindStringExact(favorito[1]) < 0)
                    {
                        MessageBox.Show("No hay modelos disponibles, se ha escogido un modelo de igual categoría y marca","No hay modelos disponibles",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        TComboBoxModelo.SelectedIndex = TComboBoxModelo.FindStringExact(favorito[1]);
                        MessageBox.Show("Se ha escogido el vehiculo " + favorito[0] + " " + favorito[1] + ".","Vehículo favorito seleccionado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No hay modelos disponibles de la misma categoría","No hay modelos disponibles",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                if (enCliente.Nombre != null)
                {
                    enFa.Conductores = Int32.Parse(TComboBoxConductores.Text.ToString());
                    enFa.ObtenerPrecio();
                    TTextBoxPrecio.Text = enFa.PrecioTotal.ToString();
                }
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

        private void TComboBoxCategoria_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                string[] texto = {TComboBoxCategoria.Text,TComboBoxMarca.Text,TComboBoxModelo.Text,TComboBoxMatricula.Text};
                EN.ENReservas enRes = new EN.ENReservas();
                DataSet dsRes = new DataSet();
                editar = false;
                dsRes = enRes.RellenarCategoria();                
                RellenarCategoria(dsRes);
                TComboBoxCategoria.SelectedIndex = TComboBoxCategoria.FindStringExact(texto[0]);
                TComboBoxMarca.SelectedIndex = TComboBoxMarca.FindStringExact(texto[1]);
                TComboBoxModelo.SelectedIndex = TComboBoxModelo.FindStringExact(texto[2]);
                TComboBoxMatricula.SelectedIndex = TComboBoxMatricula.FindStringExact(texto[3]);
            }

        }

        private void TComboBoxMarca_Click(object sender, EventArgs e)
        {
            if (editar && editar2)
            {
                string[] texto = { TComboBoxCategoria.Text, TComboBoxMarca.Text, TComboBoxModelo.Text, TComboBoxMatricula.Text };
                EN.ENReservas enRes = new EN.ENReservas();
                DataSet dsRes = new DataSet();
                dsRes = enRes.RellenarCategoria();
                editar = false;
                RellenarCategoria(dsRes);
                TComboBoxCategoria.SelectedIndex = TComboBoxCategoria.FindStringExact(texto[0]);
                TComboBoxMarca.SelectedIndex = TComboBoxMarca.FindStringExact(texto[1]);
                TComboBoxModelo.SelectedIndex = TComboBoxModelo.FindStringExact(texto[2]);
                TComboBoxMatricula.SelectedIndex = TComboBoxMatricula.FindStringExact(texto[3]);
            }
            
            
        }

        private void TComboBoxModelo_Click(object sender, EventArgs e)
        {
            if (editar && editar2)
            {
                string[] texto = { TComboBoxCategoria.Text, TComboBoxMarca.Text, TComboBoxModelo.Text, TComboBoxMatricula.Text };
                EN.ENReservas enRes = new EN.ENReservas();
                DataSet dsRes = new DataSet();
                dsRes = enRes.RellenarCategoria();
                editar = false;
                RellenarCategoria(dsRes);
                TComboBoxCategoria.SelectedIndex = TComboBoxCategoria.FindStringExact(texto[0]);
                TComboBoxMarca.SelectedIndex = TComboBoxMarca.FindStringExact(texto[1]);
                TComboBoxModelo.SelectedIndex = TComboBoxModelo.FindStringExact(texto[2]);
                TComboBoxMatricula.SelectedIndex = TComboBoxMatricula.FindStringExact(texto[3]);
            }
           
            
        }

        private void TComboBoxMatricula_Click(object sender, EventArgs e)
        {
            if (editar && editar2)
            {
                string[] texto = { TComboBoxCategoria.Text, TComboBoxMarca.Text, TComboBoxModelo.Text, TComboBoxMatricula.Text };
                EN.ENReservas enRes = new EN.ENReservas();
                DataSet dsRes = new DataSet();
                dsRes = enRes.RellenarCategoria();
                editar = false;
                RellenarCategoria(dsRes);
                TComboBoxCategoria.SelectedIndex = TComboBoxCategoria.FindStringExact(texto[0]);
                TComboBoxMarca.SelectedIndex = TComboBoxMarca.FindStringExact(texto[1]);
                TComboBoxModelo.SelectedIndex = TComboBoxModelo.FindStringExact(texto[2]);
                TComboBoxMatricula.SelectedIndex = TComboBoxMatricula.FindStringExact(texto[3]);
            }
            
            
        }


     }
}

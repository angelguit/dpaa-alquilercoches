using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace AlquilerCoches
{
    public partial class GestionFacturacionBuscar : Form
    {
        EN.ENCliente enCliente = new EN.ENCliente();
        private string eliminado = "";
        private ArrayList arraynumRes = new ArrayList();

        public GestionFacturacionBuscar()
        {
            InitializeComponent();

            DataGridViewCheckBoxColumn boton = new DataGridViewCheckBoxColumn();
            {
                boton.HeaderText = "Eliminar";//texto de la columna
                boton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //tamaño
                boton.DisplayIndex = 0; //indice que ocupara en la tabla
            }

            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            {
                buttons.HeaderText = "Duplicar"; //texto de la columna
                buttons.Text = "Duplicar"; //texto de cada boton, sale al introducir texto
                buttons.UseColumnTextForButtonValue = true;
                buttons.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                buttons.FlatStyle = FlatStyle.Standard;
                buttons.CellTemplate.Style.BackColor = Color.Honeydew;
                buttons.DisplayIndex = 0;
            }

            TDataGridBuscarFacturas.Columns.Add(boton);
            TDataGridBuscarFacturas.Columns.Add(buttons);
            
        }

        private void TButtonBuscarCliente_Click(object sender, EventArgs e)
        {

            GestionClientesBuscar F1 = new GestionClientesBuscar(false);
            F1.StartPosition = FormStartPosition.Manual;
            F1.Location = Location;
            F1.Left += 147;
            F1.Top += 44;
            F1.ShowDialog();
            
            if (F1.enClientePub.Nombre != null)
            {
                enCliente = F1.enClientePub;
                TButtonBuscarCliente.Visible = false;
                TLabelCliente.Text = "Cliente: " + enCliente.Nombre + enCliente.Apellidos;
                TLabelCliente.Visible = true;
                TButtonCambiarCliente.Visible = true;
                TButtonQuitarCliente.Visible = true;
            }
        }

        private void TButtonQuitarCliente_Click(object sender, EventArgs e)
        {
            TLabelCliente.Visible = false;
            TButtonCambiarCliente.Visible = false;
            TButtonQuitarCliente.Visible = false;
            TButtonBuscarCliente.Visible = true;
        }

        private void TButtonCambiarCliente_Click(object sender, EventArgs e)
        {
            GestionClientesBuscar F1 = new GestionClientesBuscar(false);
            F1.ShowDialog();
            enCliente = F1.enClientePub;
            TButtonBuscarCliente.Visible = false;
            TLabelCliente.Text = "Cliente: " + enCliente.Nombre + enCliente.Apellidos;
            TLabelCliente.Visible = true;
            TButtonCambiarCliente.Visible = true;
            TButtonQuitarCliente.Visible = true;
        }


        private void TButtonBuscarFechas_Click(object sender, EventArgs e)
        {
            TButtonBuscarFechas.Visible = false;
            TLabelFechaInicio.Visible = true;
            TLabelFechaFin.Visible = true;
            TDateTimePickerFechaInicio.Visible = true;
            TDateTimePickerFechaFin.Visible = true;
            TButtonOcultarFechas.Visible = true;
            TDateTimePickerFechaFin.Value = TDateTimePickerFechaInicio.Value = DateTime.Today;

        }

        private void TButtonOcultarFechas_Click(object sender, EventArgs e)
        {
            TButtonBuscarFechas.Visible = true;
            TLabelFechaInicio.Visible = false;
            TLabelFechaFin.Visible = false;
            TDateTimePickerFechaInicio.Visible = false;
            TDateTimePickerFechaFin.Visible = false;
            TButtonOcultarFechas.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TButtonBuscar_Click(object sender, EventArgs e)
        {
            EN.ENFacturacion enFacturacion = new EN.ENFacturacion();

            DataSet dsFacturacion = new DataSet();
            
            bool correcto = true;
            string sentencia = "";
           
            if (!Regex.Match(TTextBoxNumeroFactura.Text, @"^[0-9]{1,10000}$").Success && TTextBoxNumeroFactura.Text.ToString() != "")
            {
                errorProvider1.SetError(TTextBoxNumeroFactura, "Solo se admiten números (vacio para buscar todas)");
                correcto = false;
            }
            else
            {
                errorProvider1.Clear();
                if (TTextBoxNumeroFactura.Text.ToString() != "")
                {
                    sentencia += " Numero='" + TTextBoxNumeroFactura.Text.ToString() + "'";
                }
            }
            if (TDateTimePickerFechaFin.Visible == true)
            {
                if (TDateTimePickerFechaInicio.Value <= TDateTimePickerFechaFin.Value)
                {
                    errorProvider1.Clear();
                    if (sentencia == "")
                    {
                        sentencia += " DiaFacturacion BETWEEN '" + TDateTimePickerFechaInicio.Value + "' AND '" + TDateTimePickerFechaFin.Value + "'";
                        //sentencia += " and FechaFin <= '" + TDateTimePickerFechaFin.Value + "'";
                    }
                    else
                    {
                        sentencia += " and DiaFacturacion BETWEEN '" + TDateTimePickerFechaFin.Value + "' AND '" + TDateTimePickerFechaInicio.Value + "'";
                       // sentencia += " and FechaFin <= '" + Convert.ToDateTime(TDateTimePickerFechaFin.Value.ToString()) + "'";
                    }
                }
                else
                {
                    errorProvider1.SetError(TDateTimePickerFechaFin, "Fecha fin superior a fecha inicio");
                    correcto = false;
                }
            }
            if (TLabelCliente.Visible == true)
            {
                if (sentencia == "")
                {
                    sentencia += " FK_Cliente ='" + enCliente.DNI.ToString() + "'";
                }
                else
                {
                    sentencia += " and FK_Cliente ='" + enCliente.DNI.ToString() + "'";
                }
            }

   
            if (correcto)
            {
                TDataGridBuscarFacturas.Visible = true;
                TPanelReservas.Location = new Point(26, 343); ; //para desplazar el panel de busqueda hacia abajo.
                EN.ENFacturacion enFa = new EN.ENFacturacion();

                TButtonEliminar.Visible = true;
                DataSet ds = new DataSet();
                eliminado = sentencia;
                ds = enFa.ObtenerFacturas(sentencia);
                TDataGridBuscarFacturas.DataSource = ds;
                TDataGridBuscarFacturas.DataMember = "Facturas";

                for (int i = 0; i < TDataGridBuscarFacturas.Columns.Count; i++) //esto nos servira para bloquear todas las columnas para que no se puedan editar 
                {
                    if (i != 0) { TDataGridBuscarFacturas.Columns[i].ReadOnly = true; }//dejamos desbloqueada la columna de eliminar para que podamos pulsar, la columna boton no se bloquea asiq no hace falta desbloquearla
                }
            }
        }

        private void TButtonQuitarCliente_Click_1(object sender, EventArgs e)
        {
            TLabelCliente.Visible = false;
            TButtonCambiarCliente.Visible = false;
            TButtonQuitarCliente.Visible = false;
            TButtonBuscarCliente.Visible = true;
        }

        private void TButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TDataGridBuscarFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (TDataGridBuscarFacturas.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex.ToString() == "0") // la columna 0 es el checkbox de eliminiar
                {
                    string numRes = TDataGridBuscarFacturas.Rows[e.RowIndex].Cells[2].Value.ToString();

                    if (arraynumRes.Count == 0)
                    {
                        arraynumRes.Add(numRes);
                    }
                    else
                    {
                        bool esta = false;
                        for (int i = 0; i < arraynumRes.Count; i++)
                        {
                            if (arraynumRes[i].ToString() == numRes)
                            {
                                arraynumRes.RemoveAt(i);//para borrarlo de la array porque esto quiere decir que lo hemos deseleccionado
                                esta = true;
                            }
                        }
                        if (esta == false)
                            arraynumRes.Add(numRes);
                    }
                }
                else if (TDataGridBuscarFacturas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Duplicar")
                {
                    EN.ENFacturacion enFa = new EN.ENFacturacion();
                    EN.ENVehiculo enVe = new EN.ENVehiculo();
                    EN.ENCliente enCli = new EN.ENCliente();

                    enFa.Factura = Int32.Parse(TDataGridBuscarFacturas.Rows[e.RowIndex].Cells[2].Value.ToString());
                    enFa.Cliente = TDataGridBuscarFacturas.Rows[e.RowIndex].Cells[3].Value.ToString();
                    enFa.Vehiculo = TDataGridBuscarFacturas.Rows[e.RowIndex].Cells[4].Value.ToString();
                    enFa.Conductores = Int32.Parse(TDataGridBuscarFacturas.Rows[e.RowIndex].Cells[5].Value.ToString());
                    enFa.Tiempo = Int32.Parse(TDataGridBuscarFacturas.Rows[e.RowIndex].Cells[6].Value.ToString());
                    enFa.Tarifa = TDataGridBuscarFacturas.Rows[e.RowIndex].Cells[7].Value.ToString();
                    enFa.DiaFacturacion = Convert.ToDateTime(TDataGridBuscarFacturas.Rows[e.RowIndex].Cells[9].Value.ToString());

                    enVe.Matricula = enFa.Vehiculo;
                    enCli.DNI = enFa.Cliente;
                    enVe.ObtenerDatosVehiculos();
                    enCli.RellenarCliente();

                    ImprimirFacturaVenta Fp = new ImprimirFacturaVenta(enCli, enVe, enFa, enFa.Factura);
                    Fp.BackgroundImage = AlquilerCoches.Properties.Resources.es_sello_duplicado;
                    Fp.BackgroundImageLayout = ImageLayout.Stretch;
                    Fp.Show();
                    Fp.Imprimir();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no hay valores en esta fila");
            }
        }

        private void TButtonEliminar_Click(object sender, EventArgs e)
        {
            EN.ENFacturacion enFa = new EN.ENFacturacion();
            if (arraynumRes.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar '" + arraynumRes.Count.ToString() + "' registros?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    enFa.EliminarReserva(arraynumRes);
                }

                arraynumRes.Clear();
                DataSet ou = new DataSet();
                ou = enFa.ObtenerFacturas();
                TDataGridBuscarFacturas.DataSource = ou;

            }
            else
                MessageBox.Show("Debe seleccionar algún registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

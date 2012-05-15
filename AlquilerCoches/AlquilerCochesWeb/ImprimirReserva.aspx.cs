using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN;
using System.Data;

namespace AlquilerCochesWeb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TTextBoxReserva.Text = Session["numeroFactura"].ToString();
            
            //CONSULTAMOS DATOS
            ENReservas enreser = new ENReservas();
            DataSet dsreser = new DataSet();
            int numeroreserva = Int32.Parse(TTextBoxReserva.Text);
            dsreser = enreser.ObtenerReservasPorNumero(numeroreserva);

            string dni = dsreser.Tables["Reservas"].Rows[0][1].ToString();
            string matricula = dsreser.Tables["Reservas"].Rows[0][2].ToString();
            string fechaInicio = dsreser.Tables["Reservas"].Rows[0][3].ToString();

            ENVehiculo envehi = new ENVehiculo();
            DataSet dsvehi = new DataSet();
            envehi.Matricula = matricula;
            envehi.ObtenerDatosVehiculos();

            string marca = envehi.Marca;
            string modelo = envehi.Modelo;

            ENCliente encli = new ENCliente();
            DataSet dscli = new DataSet();

            dscli = encli.ObtenerDatosClienteConDni(dni);
            string nombre = dscli.Tables["Cliente"].Rows[0][1].ToString();
            string apellidos = dscli.Tables["Cliente"].Rows[0][2].ToString();
            string email = dscli.Tables["Cliente"].Rows[0][4].ToString();
            string telefono = dscli.Tables["Cliente"].Rows[0][3].ToString();


            //INTRODUCIMOS DATOS EN EL FORMULARIO
            TTextBoxDni.Text = dni;
            TTextBoxMarca.Text = marca;
            TTextBoxMatricula.Text = matricula;
            TTextBoxModelo.Text = modelo;
            TTextBoxFechaReserva.Text = fechaInicio;
            TTextBoxNombre.Text = nombre;
            TTextBoxApellidos.Text = apellidos;
            TTextBoxTelefono.Text = telefono;
            TTextBoxEmail.Text = email;

        }

        protected void BotonImprimir_Click(object sender, EventArgs e)
        {
            BotonImprimir.Visible = false;

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Prueba","window.print();", true);

            //BotonImprimir.Visible = true;
                
        }
       
    }
}
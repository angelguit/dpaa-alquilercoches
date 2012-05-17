using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN;
using System.Collections;
using System.Text.RegularExpressions;

namespace AlquilerCochesWeb
{
    public partial class Reservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (comboCategorias.Items.Count==0)
            {
                DataSet ds = new DataSet();
                EN.ENVehiculo envehiculo = new ENVehiculo();
                ds = envehiculo.ObtenerCategorias();
                for (int i = 0; i < ds.Tables["Categoria"].Rows.Count; i++)
                {
                    comboCategorias.Items.Add(ds.Tables["Categoria"].Rows[i][0].ToString());
                }

                //MARCAS
                comboMarcas.Items.Clear();
                ds = envehiculo.ObtenerMarcas(comboCategorias.Text.ToString());
                for (int i = 0; i < ds.Tables["Marcas"].Rows.Count; i++)
                {
                    comboMarcas.Items.Add(ds.Tables["Marcas"].Rows[i][0].ToString());
                }

                //VEHICULOS
                comboModelos.Items.Clear();
                ds = envehiculo.ObtenerModelosVehiculos(comboCategorias.Text.ToString(), comboMarcas.Text.ToString());
                for (int i = 0; i < ds.Tables["Modelos"].Rows.Count; i++)
                {
                    comboModelos.Items.Add(ds.Tables["Modelos"].Rows[i][0].ToString());
                }
            }
            MostrarImagen();
        }

        protected void validacionConductores(object source, ServerValidateEventArgs args)
        {
            if (!Regex.Match(conductores.Text, @"^[0-9]{1}$").Success)
            {
                //errorProvider1.SetError(TTextBoxEmail, "Email incorrectos, caracteres invalidos");
                //incorrecto = true;
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
                //incorrecto = false;
                //errorProvider1.SetError(TTextBoxEmail, "");
            }
        }

        protected void MostrarImagen()
        {
            EN.ENVehiculo vehiculo = new ENVehiculo();
            DataSet dsMatricula = new DataSet();
            dsMatricula = vehiculo.ObtenerMatriculaReserva(comboMarcas.Text, comboModelos.Text,comboCategorias.Text);

            string matricula;
            if (dsMatricula.Tables["Reserva"].Rows.Count >0)
            {
                matricula = dsMatricula.Tables["Reserva"].Rows[0][0].ToString();
                ImagenCoche.ImageUrl = "Imagenes/ImagenesReserva/fotosCoches/" + matricula + ".jpg";
            }
        }

        protected void comboCategorias_Load(object sender, EventArgs e)
        {

        }

        protected void comboCategorias_TextChanged(object sender, EventArgs e)
        {
            comboMarcas.Items.Clear();
            DataSet ds = new DataSet();
            EN.ENVehiculo envehiculo = new ENVehiculo();
            ds = envehiculo.ObtenerMarcas(comboCategorias.Text.ToString());
            for (int i = 0; i < ds.Tables["Marcas"].Rows.Count; i++)
            {
                comboMarcas.Items.Add(ds.Tables["Marcas"].Rows[i][0].ToString());
            }

            comboModelos.Items.Clear();
            ds = envehiculo.ObtenerModelosVehiculos(comboCategorias.Text.ToString(), comboMarcas.Text.ToString());
            for (int i = 0; i < ds.Tables["Modelos"].Rows.Count; i++)
            {
                comboModelos.Items.Add(ds.Tables["Modelos"].Rows[i][0].ToString());
            }
            MostrarImagen();
        }

        protected void comboMarcas_TextChanged(object sender, EventArgs e)
        {
            comboModelos.Items.Clear();
            DataSet ds = new DataSet();
            EN.ENVehiculo envehiculo = new ENVehiculo();
            ds = envehiculo.ObtenerModelosVehiculos(comboCategorias.Text.ToString(),comboMarcas.Text.ToString());
            for (int i = 0; i < ds.Tables["Modelos"].Rows.Count; i++)
            {
                comboModelos.Items.Add(ds.Tables["Modelos"].Rows[i][0].ToString());
            }
            MostrarImagen();
        }

        protected void ReservabotonConsulta_Click(object sender, EventArgs e)
        {

        }

        protected void IndexTextFechaFin_TextChanged(object sender, EventArgs e)
        {

        }

        protected bool Enviar (object sender, EventArgs e)
        {
            return false;
        }
    }
}
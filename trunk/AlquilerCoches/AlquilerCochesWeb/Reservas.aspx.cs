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
            //////////////////////LOAD NORMAL DE RESERVAS///////////////////////////////
            Posterior.ValueToCompare = System.DateTime.Today.AddDays(-1).ToString();
            if (comboCategorias.Items.Count == 0)
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

                //MODELOS
                comboModelos.Items.Clear();
                ds = envehiculo.ObtenerModelosVehiculos(comboCategorias.Text.ToString(), comboMarcas.Text.ToString());
                for (int i = 0; i < ds.Tables["Modelos"].Rows.Count; i++)
                {
                    comboModelos.Items.Add(ds.Tables["Modelos"].Rows[i][0].ToString());
                }
            }

            ///////////////////////////RESERVAS COCHES///////////////////////
            if (!Page.IsPostBack)//SOLO ENTRA SI ES LA PRIMERA VEZ QUE SE CARGA LA PAGINA
            {
                EN.ENCliente enCliente = new ENCliente();
                EN.ENVehiculo enVehi = new ENVehiculo();

                if (Session["Usuario"] != null)
                {

                    enCliente.DNI = Session["Usuario"].ToString();

                    if (Session["ReservaRapida"] == "Habitual")
                    {
                        Session["ReservaRapida"] = null;
                        string matricula = "";

                        char[] separadores = { '|', ',' };
                        string[] favorito = enCliente.ReservaFavorita().Split(separadores);

                        DataSet dsMatricula = new DataSet();
                        //Marca,Modelo,FK_Categoria
                        dsMatricula = enVehi.ObtenerMatriculaReserva(favorito[0], favorito[1], favorito[2]);
                        matricula = dsMatricula.Tables["Reserva"].Rows[0][0].ToString();
                        RellenarCocheReserva(matricula);

                    }
                    if (Session["ReservaRapida"] == "Ultima")
                    {
                        Session["ReservaRapida"] = null;
                        enCliente.DNI = Session["Usuario"].ToString();
                        RellenarCocheReserva(enCliente.UltimaReserva());
                        
                    }
                }
                else
                {
                    errorRegistrado.Visible = true;
                }


                /////////////////////////////FECHAS//////////////////////////
                if (Session["FechaInicioIndex"] != null && Session["FechaFinIndex"] != null)
                {
                    IndexTextFechaInicio.Text = Session["FechaInicioIndex"].ToString();
                    IndexTextFechaFin.Text = Session["FechaFinIndex"].ToString();
                    Session["FechaInicioIndex"] = null;
                    Session["FechaFinIndex"] = null;
                }
            }
            ////MOSTRAR IMAGENES DE COCHES//
            MostrarImagen();
        }

        protected void validacionConductores(object source, ServerValidateEventArgs args)
        {
            if (!Regex.Match(conductores.Text, @"^[0-9]{1}$").Success)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void RellenarCocheReserva(string matri)
        {
            EN.ENVehiculo enVehi = new ENVehiculo();
            DataSet dsVehi = new DataSet();
            enVehi.Matricula = matri;
            enVehi.ObtenerDatosVehiculos();

            if (enVehi.Estado == "Disponible")
            {
                //Vehiculo
                //CATEGORIA
                for (int i = 0; i < comboCategorias.Items.Count; i++)
                {
                    if (comboCategorias.Items[i].ToString() == enVehi.Categoria)
                    {
                        comboCategorias.SelectedIndex = i;
                    }
                }
                //MARCA
                CambiarComboCategorias();
                for (int i = 0; i < comboMarcas.Items.Count; i++)
                {
                    if (comboMarcas.Items[i].ToString() == enVehi.Marca)
                    {
                        comboMarcas.SelectedIndex = i;
                    }
                }
                //MODELO
                CambiarComboMarcas();
                for (int i = 0; i < comboModelos.Items.Count; i++)
                {
                    if (comboModelos.Items[i].ToString() == enVehi.Modelo)
                    {
                        comboModelos.SelectedIndex = i;
                    }
                }
            }
            else
            {
                errorReserva.Visible = true;

                for (int i = 0; i < comboCategorias.Items.Count; i++)
                {
                    if (comboCategorias.Items[i].ToString() == enVehi.Categoria)
                    {
                        comboCategorias.SelectedIndex = i;
                    }
                }
                CambiarComboCategorias();
                CambiarComboMarcas();
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
                ImagenCoche.Height = 190;
                ImagenCoche.Width = 270;
            }
        }

        protected void CambiarComboCategorias()
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

        protected void comboCategorias_TextChanged(object sender, EventArgs e)
        {
            ReservabotonConsulta.Visible = false;
            precio.Text = "";
            CambiarComboCategorias();
        }

        protected void CambiarComboMarcas()
        {
            comboModelos.Items.Clear();
            DataSet ds = new DataSet();
            EN.ENVehiculo envehiculo = new ENVehiculo();
            ds = envehiculo.ObtenerModelosVehiculos(comboCategorias.Text.ToString(), comboMarcas.Text.ToString());
            for (int i = 0; i < ds.Tables["Modelos"].Rows.Count; i++)
            {
                comboModelos.Items.Add(ds.Tables["Modelos"].Rows[i][0].ToString());
            }
            MostrarImagen();
        }

        protected void comboMarcas_TextChanged(object sender, EventArgs e)
        {
            ReservabotonConsulta.Visible = false;
            precio.Text = "";
            CambiarComboMarcas();
        }

        protected void ReservabotonPrecio_Click(object sender, EventArgs e)
        {
            errorReserva.Visible = false;
            if (IndexTextFechaFin.Text != "" && IndexTextFechaInicio.Text != "" && conductores.Text != "" && Int32.Parse(conductores.Text)<10)//algo mal
            {
                TimeSpan ts = Convert.ToDateTime(IndexTextFechaFin.Text) - Convert.ToDateTime(IndexTextFechaInicio.Text);
                EN.ENFacturacion enFa = new ENFacturacion();
                enFa.Categoria = comboCategorias.Text;
                enFa.Conductores = Int32.Parse(conductores.Text);
                enFa.Tarifa = "Normal";
                enFa.Tiempo = ts.Days + 1;
                enFa.ObtenerPrecio();
                precio.Text = enFa.PrecioTotal.ToString();

                if (Session["Usuario"] != null)
                {
                    ReservabotonConsulta.Visible = true;
                }
            }
        }

        protected void ReservabotonConsulta_Click(object sender, EventArgs e)
        {
            DataSet dsMatricula = new DataSet();
            EN.ENReservas enRe = new EN.ENReservas();
            EN.ENVehiculo enVe = new ENVehiculo();
            EN.ENCliente cli = new ENCliente();
            DataSet dscli = new DataSet();

            if (Session["Usuario"] != null)
            {
                dscli = cli.ObtenerDatosClienteConDni(Session["Usuario"].ToString());
                enRe.Cliente = dscli.Tables["Cliente"].Rows[0][0].ToString();
                if (!CompareValidatorFechas.IsValid || !CustomValidator1.IsValid || !Posterior.IsValid)//algo mal
                {

                }
                else
                {
                    dsMatricula = enVe.ObtenerMatriculaReserva(comboMarcas.Text, comboModelos.Text, comboCategorias.Text);
                    if (dsMatricula.Tables["Reserva"].Rows.Count > 0)
                    {
                        enRe.Matricula = dsMatricula.Tables["Reserva"].Rows[0][0].ToString();

                        enVe.Matricula = dsMatricula.Tables["Reserva"].Rows[0][0].ToString();
                        enVe.ObtenerDatosVehiculos();
                        enVe.Estado = "Reservado";
                        enVe.EditarVehiculo();
                    }

                    enRe.Conductores = Int32.Parse(conductores.Text);
                    enRe.FechaFin = Convert.ToDateTime(IndexTextFechaFin.Text);
                    enRe.FechaInicio = Convert.ToDateTime(IndexTextFechaInicio.Text);
                    enRe.Modelo = comboModelos.Text;
                    enRe.Activa = true;

                    enRe.AnyadirReserva();
                }
            }
        }

        protected bool Enviar (object sender, EventArgs e)
        {
            return false;
        }
    }
}
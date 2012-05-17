using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN;

namespace AlquilerCochesWeb
{
    public partial class Perfil : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            EN.ENCliente cli = new ENCliente();
            DataSet dscli = new DataSet();
            if (Session["Usuario"] != null)
            {
                dscli = cli.ObtenerDatosClienteConDni(Session["Usuario"].ToString());

                Session["nombre"] = TLabelNombre.Text = dscli.Tables["Cliente"].Rows[0][1].ToString();
                Session["apellidos"] = TLabelApellidos.Text = dscli.Tables["Cliente"].Rows[0][2].ToString();
                Session["telefono"] = TLabelTelefono.Text = dscli.Tables["Cliente"].Rows[0][3].ToString();
                Session["email"] = TLabelEmail.Text = dscli.Tables["Cliente"].Rows[0][4].ToString();
                Session["direccion"] = TLabelDireccion.Text = dscli.Tables["Cliente"].Rows[0][5].ToString();
                Session["provincia"] = TLabelProvincia.Text = dscli.Tables["Cliente"].Rows[0][6].ToString();
                Session["ciudad"] = TLabelCiudad.Text = dscli.Tables["Cliente"].Rows[0][7].ToString();

                EN.ENReservas re = new ENReservas();
                DataSet dsre = new DataSet();
                dsre = re.ObtenerReservasPorUsuario(Session["Usuario"].ToString()); //obtenemos la reserva FALTA ARREGLARLO PARA Q TE DEVUELVA La del DNI QUE QIERES

                // CREAMOS UN DATATABLE(tabla personalizada por mi) Para introducirlo en el dataset y este se introducira en el datagridview
                EN.ENVehiculo ve = new ENVehiculo();

                DataSet dsve = new DataSet();
                DataTable dtvehi = dsve.Tables.Add("DataTableMia");
                dtvehi.Columns.Add("Nº Reserva", typeof(String));
                dtvehi.Columns.Add("Matricula", typeof(String));
                dtvehi.Columns.Add("Marca", typeof(String));
                dtvehi.Columns.Add("Modelo", typeof(String));
                dtvehi.Columns.Add("Fecha Inicio", typeof(String));
                dtvehi.Columns.Add("Fecha Fin", typeof(String));
                //DATATABLE CREADO

                if (dsre.Tables["Reservas"].Rows.Count > 0)
                {
                    for (int i = 0; i < dsre.Tables["Reservas"].Rows.Count && i < 4; i++) //4 lo ponemos para limitar a 4 las reservas q se pueden mostrar
                    {
                        string numeroreserva = dsre.Tables["Reservas"].Rows[i][0].ToString();

                        string matricula = dsre.Tables["Reservas"].Rows[i][2].ToString();
                        //Substring nos sirve para recortar el string y quitarle la hora
                        string fechaini = dsre.Tables["Reservas"].Rows[i][3].ToString().Substring(0, 10);
                        //Substring nos sirve para recortar el string y quitarle la hora
                        string fechafin = dsre.Tables["Reservas"].Rows[i][4].ToString().Substring(0, 10);


                        ve.Matricula = matricula;
                        ve.ObtenerDatosVehiculos(); //obtenemos los datos del vehiculo correspondientes a la matricula anterior

                        DataRow fila;
                        fila = dtvehi.NewRow(); //para crear una nueva fila

                        fila["Nº Reserva"] = numeroreserva;
                        fila["Matricula"] = ve.Matricula;
                        fila["Marca"] = ve.Marca;
                        fila["Modelo"] = ve.Modelo;
                        fila["Fecha Inicio"] = fechaini;
                        fila["Fecha Fin"] = fechafin;
                        //fila["Marca"] = ve.Marca;
                        dtvehi.Rows.Add(fila);

                    }
                }


                TDataGridViewReservas.DataSource = dsve;
                TDataGridViewReservas.DataBind();
            }
            else
            {
                Response.Redirect("Registro.aspx");
            }
        }

        protected void TButtonFechas_Click(object sender, EventArgs e)
        {
            Session["fechaonumero"] = "fecha";//nos creamos esta variable sesion para cuando estemos en el webform PerfilFActura sepamos q venimos desde la fecha
            bool bien = true;
            if (IndexTextFechaInicio.Text == "" || IndexTextFechaFin.Text == "") // para controlar cuando se dejan vacio los textbox
            {
                CompareValidatorFechas.Visible = true;
                bien = false;
            }
            else
            {

                if (Page.IsValid)
                {
                    CompareValidatorFechas.Visible = false;
                }
                else
                {
                    CompareValidatorFechas.Visible = true;
                    bien = false;
                }
            }

            if (bien)
            {
                Session["fechaPerfilIni"] = IndexTextFechaInicio.Text;
                Session["fechaPerfilFin"] = IndexTextFechaFin.Text;
                Server.Transfer("PerfilFactura.aspx");
            }
        }


        protected void TButtonNumeroFechas_Click(object sender, EventArgs e)
        {
            if (TTextBoxNumeroFactura.Text != "")
            {
                Session["numeroFactura"] = TTextBoxNumeroFactura.Text;

                Response.Write("<script>window.open('ImprimirReserva.aspx' ,'Factura', 'menubar=yes,scrollbars=yes,height=500, width=720')</script>");
                //Response.Write("<script>window.open('ImprimirReserva.aspx' ,'Factura', 'menubar=yes,toolbar=yes,scrollbars=yes,status=yes,directories=yes, height=500, width=720')</script>");
            }





           // Server.Transfer("");
            
            /*string filepath = "/Descargas/Factura.txt";
            Response.Clear();
            Response.ContentType = "application/octet-stream";
            Response.AddHeader("Content-Disposition", "attachment;filename=factura.txt");
            Response.Flush();
            Response.WriteFile(filepath);
            Response.Write("RENT A CAR FACTURA");
            Response.Write("NºFactura: "+TTextBoxNumeroFactura.Text+"    Dni:11111111A");
            Response.End();*/
            
        
        }
    }
}
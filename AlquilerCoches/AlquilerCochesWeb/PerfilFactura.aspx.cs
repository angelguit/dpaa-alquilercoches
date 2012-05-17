using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;// utilizado para process


namespace AlquilerCochesWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                string dni = Session["Usuario"].ToString();
                string fechaIni = Session["fechaPerfilIni"].ToString();
                string fechaFin = Session["fechaPerfilFin"].ToString();

                EN.ENReservas enRe = new EN.ENReservas();
                DataSet ds = new DataSet();
                ds = enRe.ObtenerReservasPorFecha(dni,fechaIni,fechaFin); //¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡DENTRO PÔNER sentencia pero no va!!!!!!!!!!!!!!!!
              //Cambiamos el nombre a las columnas del dataset
                ds.Tables["Reservas"].Columns[1].ColumnName = "Cliente";
                ds.Tables["Reservas"].Columns[2].ColumnName = "Matricula";
            
                TDataGridViewFacturaFechas.DataSource = ds;
                TDataGridViewFacturaFechas.DataBind();  
 
        }


    }
}
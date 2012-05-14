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
            if (Session["fechaonumero"].ToString() == "fecha")
            {
                string sentencia = "";
                string fechaIni = Session["fechaPerfilIni"].ToString() + " 0:00:00";
                string fechaFin = Session["fechaPerfilFin"].ToString() + " 0:00:00";

                sentencia += " FechaInicio BETWEEN '" + fechaIni + "' AND '" + fechaFin + "'";
                sentencia += " and FechaFin <= '" + fechaFin + "'";
                sentencia += " FK_Cliente = 11111111A";

                EN.ENReservas enRe = new EN.ENReservas();
                DataSet ds = new DataSet();
                ds = enRe.ObtenerReservas(); //¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡DENTRO PÔNER sentencia pero no va!!!!!!!!!!!!!!!!

                TDataGridViewFacturaFechas.DataSource = ds;
                TDataGridViewFacturaFechas.DataBind();
            }
            else
            {
                TDataGridViewFacturaFechas.Visible = false;
                TTextBoxNumeroFactura.Text = Session["numeroFactura"].ToString();
                TTextBoxNumeroFactura.Enabled = false;

                

                
            }
 
        }


    }
}
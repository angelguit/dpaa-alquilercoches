using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections;

namespace CAD
{
    public class CADFacturacion
    {

        static private String cadenaConexion = ConfigurationManager.ConnectionStrings["AlquilerCoches"].ConnectionString; // @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "Facturas";

        public DataSet ObtenerTablaFacturas(string sentencia)
        {
            /*DataSet dsFacturas = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Facturas";
                SqlDataAdapter daCaminos = new SqlDataAdapter(consulta, conexion);
                daCaminos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCaminos.Fill(dsFacturas, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsFacturas;*/
            DataSet dsFac = new DataSet();
            SqlDataAdapter daFac;
            string consulta;
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                if (sentencia != "")
                    consulta = "Select * from Facturas where " + sentencia;
                else
                    consulta = "Select * from Facturas";
                daFac = new SqlDataAdapter(consulta, conexion);
                daFac.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daFac.Fill(dsFac, "Facturas");
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return dsFac;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CAD
{
    public class CADVentas
    {
        static private String cadenaConexion = ConfigurationManager.ConnectionStrings["AlquilerCoches"].ConnectionString; // @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "Ventas";

        public DataSet ObtenerTablaVentas()
        {
            DataSet dsVentas = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Ventas";
                SqlDataAdapter daVentas = new SqlDataAdapter(consulta, conexion);
                daVentas.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVentas.Fill(dsVentas, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVentas;
        }
    }
}

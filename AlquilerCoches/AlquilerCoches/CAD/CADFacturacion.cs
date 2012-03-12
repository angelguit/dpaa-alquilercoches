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

namespace AlquilerCoches.CAD
{
    public class CADFacturacion
    {
        static private String cadenaConexion = @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "Facturas";

        public DataSet ObtenerTablaFacturas()
        {
            DataSet dsFacturas = new DataSet();

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

            return dsFacturas;
        }
    }
}

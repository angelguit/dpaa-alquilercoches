using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AlquilerCoches.CAD
{
    public class CADVehiculo
    {
        static private String cadenaConexion = @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "Vehiculo";

        public DataSet ObtenerTablaVentas()
        {
            DataSet deVentas = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Ventas";
                SqlDataAdapter daCaminos = new SqlDataAdapter(consulta, conexion);
                daCaminos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCaminos.Fill(deVentas, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return deVentas;
        }
    }
}

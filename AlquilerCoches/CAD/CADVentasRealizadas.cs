using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CAD
{
    public class CADVentasRealizadas
    {
        static private String cadenaConexion = ConfigurationManager.ConnectionStrings["AlquilerCoches"].ConnectionString; // @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "VentasRealizadas";

        public DataSet ObtenerTablaVentasRealizadas()
        {
            DataSet dsVentasRealizadas = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * FROM VentasRealizadas";
                SqlDataAdapter daVentasRealizadas = new SqlDataAdapter(consulta, conexion);
                daVentasRealizadas.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVentasRealizadas.Fill(dsVentasRealizadas, nombreTabla); //dsVentas es ahora nuestra base de datos local

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return dsVentasRealizadas;
        }

        public DataSet ObtenerDNI()
        {
            DataSet dsVentasRealizadas = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select FK_DNI_Cliente from VentasRealizadas";
                SqlDataAdapter daVentasRealizadas = new SqlDataAdapter(consulta, conexion);
                daVentasRealizadas.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVentasRealizadas.Fill(dsVentasRealizadas, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVentasRealizadas;
        } 

        public DataSet ObtenerDatosVentas(string dni)
        {
            DataSet dsVentas = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from VentasRealizadas where FK_DNI_Cliente='" + dni + "'";
                SqlDataAdapter daVentasRealizadas = new SqlDataAdapter(consulta, conexion);
                daVentasRealizadas.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVentasRealizadas.Fill(dsVentas, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVentas;
        }

        public void AnyadirVentasRealizadas(DataSet venta)
        {
            DataSet dsVentasRealizadas = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from VentasRealizadas";
                SqlDataAdapter daVentasRealizadas = new SqlDataAdapter(consulta, conexion);
                daVentasRealizadas.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVentasRealizadas.Fill(dsVentasRealizadas, nombreTabla);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daVentasRealizadas);
                daVentasRealizadas.Update(venta, "VentasRealizadas");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void EditarFacturado(DataSet venta)
        {
            DataSet dsVentasRealizadas = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from VentasRealizadas where FK_DNI_Cliente='" + venta.Tables["VentasRealizadas"].Rows[0][1] + "'";
                SqlDataAdapter daVentasRealizas = new SqlDataAdapter(consulta, conexion);
                daVentasRealizas.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVentasRealizas.Fill(dsVentasRealizadas, nombreTabla);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daVentasRealizas);
                daVentasRealizas.Update(venta, "VentasRealizadas");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}

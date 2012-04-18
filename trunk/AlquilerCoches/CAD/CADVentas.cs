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
                String consulta = "Select * FROM Ventas";
                SqlDataAdapter daVentas = new SqlDataAdapter(consulta, conexion);
                daVentas.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVentas.Fill(dsVentas, nombreTabla); //dsVentas es ahora nuestra base de datos local
                
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return dsVentas;
        }

        public DataSet ObtenerMarcas()
        {
            DataSet dsVentas = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select Marca from Ventas";
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

        public DataSet ObtenerModelos(string marca)
        {
            DataSet dsVentas = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select Modelo from Ventas where Marca='" + marca + "'";
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

        public DataSet ObtenerMatricula(string marca, string modelo)
        {
            DataSet dsVentas = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select Matricula from Ventas where Modelo='" + modelo + "' and Marca='" + marca + "'";
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

        public DataSet ObtenerDatosVehiculo(string matricula)
        {
            DataSet dsVentas = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Ventas where Matricula='" + matricula + "'";
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

        public void BorrarVehiculoVenta(string matricula)
        {
            DataSet dsVentas = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Ventas where Matricula='" + matricula + "'";
                SqlDataAdapter daVenta = new SqlDataAdapter(consulta, conexion);
                daVenta.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVenta.Fill(dsVentas, nombreTabla);
                dsVentas.Tables["Ventas"].Rows[0].Delete();
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daVenta);
                daVenta.Update(dsVentas, "Ventas");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void EditarVehiculoVenta(DataSet venta)
        {
            DataSet dsVenta = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Ventas where Matricula='" + venta.Tables["Ventas"].Rows[0][2] + "'";
                SqlDataAdapter daVentas = new SqlDataAdapter(consulta, conexion);
                daVentas.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVentas.Fill(dsVenta, nombreTabla);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daVentas);
                daVentas.Update(dsVenta, "Ventas");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void AnyadirVenta(DataSet venta)
        {
            DataSet dsVentas = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Ventas";
                SqlDataAdapter daVentas = new SqlDataAdapter(consulta, conexion);
                daVentas.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVentas.Fill(dsVentas, nombreTabla);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daVentas);
                daVentas.Update(venta, "Ventas");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}

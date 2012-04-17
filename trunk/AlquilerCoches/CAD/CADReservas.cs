﻿﻿using System;
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
    public class CADReservas
    {
        static private String cadenaConexion = ConfigurationManager.ConnectionStrings["AlquilerCoches"].ConnectionString; // @"Data Source=|DataDirectory|\BBDD.sdf";
        static private SqlDataAdapter daRes;
        public DataSet RellenarCategoria()
        {
            DataSet dsCat = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Categoria";
                daRes = new SqlDataAdapter(consulta, conexion);
                daRes.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daRes.Fill(dsCat, "Categorias");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsCat;
        }

        public DataSet ObtenerReservas()
        {
            DataSet dsRes = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Reservas";
                daRes = new SqlDataAdapter(consulta, conexion);
                daRes.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daRes.Fill(dsRes, "Reservas");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsRes;
        }

        public bool ActualizarReservas(DataSet dsRes)
        {
            bool retorno = true;
            try
            {
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daRes);
                daRes.Update(dsRes, "Reservas");
            }
            catch (Exception ex)
            {
                retorno = false;
                throw (ex);
            }

            return retorno;
        }
        public int EjecutarSentencia(string comando)
        {
            int affectedRows = -1;
            //   SqlConnection connection = new SqlConnection(); // Creamos la conexión
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlCommand command = connection.CreateCommand(); // Creamos el objeto 'command' pasandole la conexión
            command.CommandText = comando; // Le metemos la sentencia Insert, Update o Delete
            command.Connection = connection;
            command.Prepare();
            try
            {
                connection.Open(); // Abrimos la conexión
                affectedRows = command.ExecuteNonQuery(); // Guardamos las filas afectadas
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return affectedRows;
        }

        public void AnyadirReserva(DataSet dsRes)
        {
            DataSet dsReser = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Reservas";
                SqlDataAdapter daReser = new SqlDataAdapter(consulta, conexion);
                daReser.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daReser.Fill(dsReser, "Reservas");
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daReser);
                daReser.Update(dsRes, "Reservas");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}

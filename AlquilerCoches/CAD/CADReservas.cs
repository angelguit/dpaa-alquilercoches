﻿using System;
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
        
        public DataSet RellenarCategoria()
        {
            DataSet dsCat = new DataSet();
            SqlDataAdapter daRes;
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
            SqlDataAdapter daRes;
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

        public DataSet ObtenerReservas(int numRes)
        {
            DataSet dsRes = new DataSet();
            SqlDataAdapter daRes;
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Reservas where NºReserva = '" + numRes + "'";
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

        public DataSet ObtenerReservas(string sentencia)
        {
            DataSet dsRes = new DataSet();
            SqlDataAdapter daRes;
            string consulta = "Select * from Reservas WHERE Activa = 1 "; ;
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                if (sentencia != "")
                {
                    consulta += "AND " + sentencia;
                }
                
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

        public DataSet ObtenerReservasPorUsuario(string sentencia)
        {
            DataSet dsRes = new DataSet();
            SqlDataAdapter daRes;
            
            //string insertar = "FK_Cliente ='"+sentencia+"'";
            string consulta = "Select * from Reservas WHERE Activa = 1 AND FK_Cliente in('"+sentencia+"')";
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
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

        public DataSet ObtenerTodasReservasPorDni(string sentencia)
        {
            DataSet dsRes = new DataSet();
            SqlDataAdapter daRes;

            string consulta = "Select * from Reservas WHERE FK_Cliente in('" + sentencia + "')";
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
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

        public DataSet ObtenerReservasPorFechas(string dni,string fechaini, string fechafin)
        {
            DataSet dsRes = new DataSet();
            SqlDataAdapter daRes;

            //string insertar = "FK_Cliente ='"+sentencia+"'";
            /*sentencia += " FechaInicio BETWEEN '" + fechaIni + "' AND '" + fechaFin + "'";
                sentencia += " and FechaFin <= '" + fechaFin + "'";
                sentencia += " FK_Cliente = 11111111A";*/
            string[] rayini = fechaini.Split('/');
            string[] rayfin = fechafin.Split('/');

            string fechini = rayini[2]+"/"+rayini[1]+"/"+rayini[0];
            string fechfi = rayfin[2] + "/" + rayfin[1] + "/" + rayfin[0];

            string consulta = "Select * from Reservas WHERE Activa = 1 AND FK_Cliente in('" + dni + "') AND FechaInicio BETWEEN '" +fechini+"' AND '" +fechfi+"' AND FechaFin <= '"+fechfi+"'";
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
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
                SqlDataAdapter daRes = new SqlDataAdapter(consulta, conexion);
                daRes.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daRes.Fill(dsReser, "Reservas");
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daRes);
                daRes.Update(dsRes, "Reservas");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void EliminarReserva(ArrayList numRes)
        {
            DataSet dsRes = new DataSet();
            try
            {
                string frase = "";
                for (int i = 0; i < numRes.Count; i++)
                {
                    if (i == 0) { frase += "'" + numRes[i] + "'"; }
                    else
                    {
                        frase += ",";
                        frase += "'" + numRes[i] + "'";
                    }
                }

                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Reservas where NºReserva in (" + frase + ")";
                SqlDataAdapter daPersonal = new SqlDataAdapter(consulta, conexion);
                daPersonal.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daPersonal.Fill(dsRes, "Reservas");
                for (int i = 0; i < numRes.Count; i++)//lo hacemos parar borrar las filas que corresponden con los dnis 
                {
                    dsRes.Tables["Reservas"].Rows[i].Delete();
                }
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daPersonal);
                daPersonal.Update(dsRes, "Reservas");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int NumeroUltimaReserva()
        {
            DataSet dsReser = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Reservas";
                SqlDataAdapter daRes = new SqlDataAdapter(consulta, conexion);
                daRes.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daRes.Fill(dsReser, "Reservas");
                
                

            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return Int32.Parse(dsReser.Tables["Reservas"].Rows[dsReser.Tables["Reservas"].Rows.Count - 1][0].ToString());
        }

        public void EditarReserva(DataSet dsRes)
        {
            DataSet dsRe = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Reservas where NºReserva = '" + dsRes.Tables["Reservas"].Rows[0][0] + "'";
                SqlDataAdapter daRes = new SqlDataAdapter(consulta, conexion);
                daRes.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daRes.Fill(dsRe, "Reservas");
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daRes);
                daRes.Update(dsRes, "Reservas");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}

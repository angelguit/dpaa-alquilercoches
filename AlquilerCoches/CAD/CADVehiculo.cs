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
    public class CADVehiculo
    {
        static private String cadenaConexion = ConfigurationManager.ConnectionStrings["AlquilerCoches"].ConnectionString; // @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "Vehiculo";

        public DataSet ObtenerTablaVehiculo()
        {
            DataSet dsVehiculo = new DataSet();
            
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Vehiculo";
                SqlDataAdapter daCaminos = new SqlDataAdapter(consulta, conexion);
                daCaminos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCaminos.Fill(dsVehiculo, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVehiculo;
        }

        public DataSet ObtenerMarcas()
        {
            DataSet dsVehiculo = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select Marca from Vehiculo";
                SqlDataAdapter daVehiculo = new SqlDataAdapter(consulta, conexion);
                daVehiculo.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculo.Fill(dsVehiculo, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVehiculo;
        }

        public DataSet ObtenerModelos(string marca)
        {
            DataSet dsVehiculo = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select Modelo from Vehiculo where Marca='" + marca +"'";
                SqlDataAdapter daVehiculo = new SqlDataAdapter(consulta, conexion);
                daVehiculo.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculo.Fill(dsVehiculo, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVehiculo;
        }
        public DataSet ObtenerMatricula(string marca, string modelo)
        {
            DataSet dsVehiculo = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select Matricula from Vehiculo where Modelo='" + modelo + "' and Marca='" + marca + "'";
                SqlDataAdapter daVehiculo = new SqlDataAdapter(consulta, conexion);
                daVehiculo.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculo.Fill(dsVehiculo, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVehiculo;
        }
        public DataSet ObtenerDatosVehiculo(string matricula)
        {
            DataSet dsVehiculo = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select  Matricula, Marca, Modelo, PrecioVenta, PrecioAlquiler, PrecioCompra, Garantia, KM, Estado from Vehiculo where Matricula='" + matricula + "'";
                SqlDataAdapter daVehiculo = new SqlDataAdapter(consulta, conexion);
                daVehiculo.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculo.Fill(dsVehiculo, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVehiculo;
        }
        public DataSet ObtenerModelosVehiculo(string cat)
        {
            DataSet dsVehiculo = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select Modelo from Vehiculo WHERE (FK_Categoria = '" + cat + "') AND (Estado = 'Disponible')";
                SqlDataAdapter daCaminos = new SqlDataAdapter(consulta, conexion);
                daCaminos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCaminos.Fill(dsVehiculo, "Modelos");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVehiculo;
        }

        public DataSet ObtenerMatriculasVehiculo(string mod)
        {
            DataSet dsVehiculo = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select Matricula from Vehiculo WHERE (Modelo = '" + mod + "') AND (Estado = 'Disponible')";
                SqlDataAdapter daCaminos = new SqlDataAdapter(consulta, conexion);
                daCaminos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCaminos.Fill(dsVehiculo, "Matriculas");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVehiculo;
        }
    }
}

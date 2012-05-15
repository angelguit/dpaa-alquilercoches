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
                SqlDataAdapter daVehiculos = new SqlDataAdapter(consulta, conexion);
                daVehiculos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculos.Fill(dsVehiculo, nombreTabla);
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
                String consulta = "";
                
                if (!marca.Equals("") && !modelo.Equals(""))
                {
                    consulta = "Select Matricula from Vehiculo where Modelo='" + modelo + "' and Marca='" + marca + "'";
                }
                else if (!marca.Equals(""))
                {
                    consulta = "Select Matricula from Vehiculo where Marca='" + marca + "'";
                }
                else
                {
                    consulta = "Select Matricula from Vehiculo";
                }
                
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

        public DataSet ObtenerMatricula2(string marca, string modelo)
        {
            DataSet dsVehiculo = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "";

                if (!marca.Equals("") && !modelo.Equals(""))
                {
                    consulta = "Select Matricula from Vehiculo where Estado = 'Disponible' and Modelo='" + modelo + "' and Marca='" + marca + "'";
                }
                else
                {
                    consulta = "Select Matricula from Vehiculo where 1=2";
                }
   
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
                String consulta = "Select * from Vehiculo where Matricula='" + matricula + "'";
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

        public DataSet ObtenerModelosVehiculo(string cat, string mar)
        {
            DataSet dsVehiculo = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select Modelo from Vehiculo WHERE (FK_Categoria = '" + cat + "') AND (Marca = '" + mar + "') AND (Estado = 'Disponible')";
                SqlDataAdapter daVehiculos = new SqlDataAdapter(consulta, conexion);
                daVehiculos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculos.Fill(dsVehiculo, "Modelos");
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
                SqlDataAdapter daVehiculos = new SqlDataAdapter(consulta, conexion);
                daVehiculos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculos.Fill(dsVehiculo, "Matriculas");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVehiculo; 
        }

        public DataSet ObtenerMarcas(string cat)
        {
            DataSet dsVehiculo = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select Marca from Vehiculo WHERE (FK_Categoria = '" + cat + "') AND (Estado = 'Disponible') group by Marca";
                SqlDataAdapter daVehiculos = new SqlDataAdapter(consulta, conexion);
                daVehiculos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculos.Fill(dsVehiculo, "Marcas");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVehiculo;
        }

        public DataSet ObtenerCategorias()
        {
            DataSet dsVehiculo = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select Tipo from Categoria";
                SqlDataAdapter daVehiculos = new SqlDataAdapter(consulta, conexion);
                daVehiculos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculos.Fill(dsVehiculo, "Categoria");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVehiculo;
        }

        /// nuevo
        public void BorrarVehiculo(string matricula)
        {
            DataSet dsVehiculo = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Vehiculo where Matricula='" + matricula + "'";
                SqlDataAdapter daVehiculo = new SqlDataAdapter(consulta, conexion);
                daVehiculo.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculo.Fill(dsVehiculo, nombreTabla);
                dsVehiculo.Tables["Vehiculo"].Rows[0].Delete();
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daVehiculo);
                daVehiculo.Update(dsVehiculo, "Vehiculo");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void EditarVehiculo(DataSet vehiculo)
        {
            DataSet dsVehiculo = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Vehiculo where Matricula='" + vehiculo.Tables["Vehiculo"].Rows[0][2] + "'";
                SqlDataAdapter daVehiculo = new SqlDataAdapter(consulta, conexion);
                daVehiculo.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculo.Fill(dsVehiculo, nombreTabla);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daVehiculo);
                daVehiculo.Update(vehiculo, "Vehiculo");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public void AnyadirVehiculo(DataSet vehiculo)
        {
            DataSet dsVehiculo = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Vehiculo";
                SqlDataAdapter daVehiculo = new SqlDataAdapter(consulta, conexion);
                daVehiculo.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculo.Fill(dsVehiculo, nombreTabla);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daVehiculo);
                daVehiculo.Update(vehiculo, "Vehiculo");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public DataSet ObtenerMatriculaReserva(string marca, string modelo,string categoria)
        {
            DataSet dsVehiculo = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "";
                consulta = "Select Matricula from Vehiculo where Modelo='" + modelo + "' and Marca='" + marca + "' and FK_Categoria='" + categoria + "' and Estado='Disponible'";
                SqlDataAdapter daVehiculo = new SqlDataAdapter(consulta, conexion);
                daVehiculo.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculo.Fill(dsVehiculo, "Reserva");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsVehiculo;
        }
    }
}

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
    public class CADProveedores
    {
        static private String cadenaConexion = ConfigurationManager.ConnectionStrings["AlquilerCoches"].ConnectionString; // @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "Proveedores";

        public DataSet ObtenerTablaProveedores()
        {
            DataSet dsProveedores = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Proveedores";
                SqlDataAdapter daCaminos = new SqlDataAdapter(consulta, conexion);
                daCaminos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCaminos.Fill(dsProveedores, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsProveedores;
        }

        public void BorrarProveedor(string proveedorID)
        {
            SqlConnection conn = null; 
            // Encapsula todo el acceso a datos dentro del try 
            String comando = "Delete from Cliente where id = "+ proveedorID;
            try 
            { 
                conn.Open();
                conn = new SqlConnection(cadenaConexion);
                SqlCommand cmd = new SqlCommand(comando, conn );
                 cmd.ExecuteNonQuery();
            } 
           // catch (SqlException sqlex) 
            //{ 
                // Envuelve la excepción actual en una excepción mas relevante 
                //throw new CADException ("Error borrando el cliente: " + proveedorID, sqlex ); 
            //} 
            catch (Exception ex) 
            { 
                // Captura la condición general y la reenvía. 
                throw ex; 
            } 
            finally 
            { 
              if(conn != null) conn.Close(); // Se asegura de cerrar la conexión. 
            }
        }

        public DataSet ObtenerClientesPorCiudad( String ciudad ) 
        { 
            SqlConnection conn = null; 
            DataSet dsProveedores = null; 
            // Encapsula todo el acceso a datos dentro del try 
            string comando = "Select * from Proveedores"; 
            try 
            {
                conn = new SqlConnection(cadenaConexion); 
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter (comando, conn);
                dsProveedores = new DataSet();
                sqlAdaptador.Fill(dsProveedores);
                return dsProveedores; 
            } 
            //catch (SqlException sqlex) 
            //{ 
              //  throw new CADException ("Error en la consulta de clientes por ciudad: " + clienteID, sqlex ); 
            //} 
            catch (Exception ex) 
            { 
                // Captura la condición general y la reenvía. 
                throw ex; 
            } 
            finally 
            { 
                if(conn != null) conn.Close(); // Se asegura de cerrar la conexión. 
            }
        } 

















    }
}

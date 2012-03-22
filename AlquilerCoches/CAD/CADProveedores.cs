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
    }
}

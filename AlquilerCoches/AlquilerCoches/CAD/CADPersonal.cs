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

namespace AlquilerCoches.CAD
{
    public class CADPersonal
    {
        static private String cadenaConexion = @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "Personal";

        public DataSet ObtenerTablaPersonal()
        {
            DataSet dsPersonal = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Personal";
                SqlDataAdapter daCaminos = new SqlDataAdapter(consulta, conexion);
                daCaminos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCaminos.Fill(dsPersonal, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsPersonal;
        }
    }


}


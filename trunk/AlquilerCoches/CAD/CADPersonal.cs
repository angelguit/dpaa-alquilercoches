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
    public class CADPersonal
    {
 //       static private String cadenaConexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Users\Dani\Documents\Visual Studio 2010\Projects\AlquilerCoches\AlquilerCoches\AlquilerCoches\BBDD.mdf';Integrated Security=True;User Instance=True";
        static private String cadenaConexion = ConfigurationManager.ConnectionStrings["AlquilerCoches"].ConnectionString; // @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "Personal";

        public DataSet ObtenerTablaPersonal()
        {
            DataSet dsPersonal = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Personal";
                SqlDataAdapter daPersonal = new SqlDataAdapter(consulta, conexion);
                daPersonal.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daPersonal.Fill(dsPersonal, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsPersonal;
        }
    }


}


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
      //static private String cadenaConexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Users\Dani\Documents\Visual Studio 2010\Projects\AlquilerCoches\AlquilerCoches\AlquilerCoches\BBDD.mdf';Integrated Security=True;User Instance=True";
        static private String cadenaConexion = ConfigurationManager.ConnectionStrings["AlquilerCoches"].ConnectionString; // @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "Personal";

        public DataSet ObtenerTablaPersonal(string ciu)
        {
            DataSet dsPersonal = new DataSet();
            
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * FROM Personal WHERE ciudad like '%"+ciu+"%'";
                SqlDataAdapter daPersonal = new SqlDataAdapter(consulta, conexion);
                daPersonal.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daPersonal.Fill(dsPersonal, nombreTabla); //dsPersonal es ahora nuestra base de datos local
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsPersonal;
        }

        public DataSet ConseguirProvincias()
        {
            DataSet dsProvin = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select nombre FROM Provincia";
                SqlDataAdapter daProv = new SqlDataAdapter(consulta, conexion);
                daProv.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daProv.Fill(dsProvin, "Provincia"); //dsPersonal es ahora nuestra base de datos local
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsProvin;
        }
    }


}


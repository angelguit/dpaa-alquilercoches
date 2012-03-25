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

        public bool NuevaReserva(DataSet dsRes)
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
    }
}
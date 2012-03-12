﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlquilerCoches.CAD
{
    class CADPedidos
    {
        static private String cadenaConexion = @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "Pedidos";

        public DataSet ObtenerTablaPedidos()
        {
            DataSet dsPedidos = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Pedidos";
                SqlDataAdapter daCaminos = new SqlDataAdapter(consulta, conexion);
                daCaminos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCaminos.Fill(dsPedidos, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsPedidos;
        }
    }
}

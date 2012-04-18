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
    public class CADPedidos
    {
        static private String cadenaConexion = ConfigurationManager.ConnectionStrings["AlquilerCoches"].ConnectionString; // @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "Pedidos";

        public DataSet ObtenerTablaPedidos(string todo)
        {
            DataSet dsPedidos = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                if (todo != "")
                {
                    String consulta = "Select * FROM Pedidos WHERE " + todo + "";
                    SqlDataAdapter daPersonal = new SqlDataAdapter(consulta, conexion);
                    daPersonal.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    daPersonal.Fill(dsPedidos, nombreTabla); //dsPersonal es ahora nuestra base de datos local
                }
                else
                {

                    String consulta = "Select * FROM Pedidos";
                    SqlDataAdapter daPedidos = new SqlDataAdapter(consulta, conexion);
                    daPedidos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    daPedidos.Fill(dsPedidos, nombreTabla); //dsPersonal es ahora nuestra base de datos local
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsPedidos;
        }



        public void AnyadirPedidos(DataSet pedido)
        {
            DataSet dsPedidos = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Pedidos";
                SqlDataAdapter daPedidos = new SqlDataAdapter(consulta, conexion);
                daPedidos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daPedidos.Fill(dsPedidos, nombreTabla);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daPedidos);
                daPedidos.Update(pedido, "Pedidos");
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        public void EditarPedidos(DataSet pedido)
        {
            DataSet dsPedidos = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                string consulta = "Select * from Pedidos where idtransaccion='" + pedido.Tables["Pedidos"].Rows[0][0] + "'";
                SqlDataAdapter daPedidos = new SqlDataAdapter(consulta, conexion);
                daPedidos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daPedidos.Fill(dsPedidos, nombreTabla);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daPedidos);
                daPedidos.Update(pedido, "Pedidos");
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        public DataSet ConseguirMarcas()
        {
            DataSet dsMarc = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select id_marca,marca FROM Marca";
                SqlDataAdapter daMarc = new SqlDataAdapter(consulta, conexion);
                daMarc.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daMarc.Fill(dsMarc, "Marca"); //dsPersonal es ahora nuestra base de datos local
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsMarc;
        }



        public DataSet ConseguirModelos(string marca)
        {
            DataSet dsCiu = new DataSet();

            try
            {   
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select nom_modelo FROM Modelo where num_modelo='" + marca + "'";
                SqlDataAdapter daCiu = new SqlDataAdapter(consulta, conexion);
                daCiu.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCiu.Fill(dsCiu, "Modelo"); //dsPersonal es ahora nuestra base de datos local
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsCiu;
        }
        /*
        public string ObtenerNumMarca(string marca)
        {
            DataSet dsMod = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select id_marca FROM Marca where marca='" + marca + "'";
                SqlDataAdapter daMod = new SqlDataAdapter(consulta, conexion);
                daMod.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daMod.Fill(dsMod, "Marca"); //dsPersonal es ahora nuestra base de datos local
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            string retorno = dsMod.Tables["Marca"].Rows[0][0].ToString();
            return retorno;
        }
        */
    }
}

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
                string consulta = "Select * from Pedidos where IDTransaccion='" + pedido.Tables["Pedidos"].Rows[0][0] + "'";
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

        public DataSet ConseguirID()
        {
            DataSet dsId = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select IDTransaccion FROM Pedidos";
                SqlDataAdapter daID = new SqlDataAdapter(consulta, conexion);
                daID.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daID.Fill(dsId, "Pedidos");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsId;
        }


        public void BorrarPedido(ArrayList arrayid)
        {
            DataSet dsPedidos = new DataSet();
            try
            {
                string frase = "";
                for (int i = 0; i < arrayid.Count; i++)
                {
                    if (i == 0) { frase += "'" + arrayid[i] + "'"; }
                    else
                    {
                        frase += ",";
                        frase += "'" + arrayid[i] + "'";
                    }
                }

                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Pedidos where IDTransaccion in (" + frase + ")";
                SqlDataAdapter daPedidos = new SqlDataAdapter(consulta, conexion);
                daPedidos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daPedidos.Fill(dsPedidos, nombreTabla);
                for (int i = 0; i < arrayid.Count; i++)//lo hacemos parar borrar las filas que corresponden con los dnis 
                {
                    dsPedidos.Tables["Pedidos"].Rows[i].Delete();
                }
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daPedidos);
                daPedidos.Update(dsPedidos, "Pedidos");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }



        public DataSet ObtenerDatosPedidosConId(string idtransaccion)
        {
            DataSet dsPedido = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "SELECT * FROM Pedidos WHERE IDTransaccion='" + idtransaccion + "'";
                SqlDataAdapter daPedido = new SqlDataAdapter(consulta, conexion);
                daPedido.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daPedido.Fill(dsPedido, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsPedido;
        }


    }
}

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
    public class CADCliente
    {
        static private String cadenaConexion = ConfigurationManager.ConnectionStrings["AlquilerCoches"].ConnectionString; // @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "Cliente";

        public DataSet ObtenerTablaCliente(string todo)
        {
            DataSet dsCliente = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                //String consulta = "Select * FROM Personal WHERE ciudad like '%"+ciu+"%' and apellidos='"+apell+"'";

                if (todo != "") //si cadena todo esta llena
                {
                    String consulta = "Select * FROM Cliente WHERE " + todo + "";
                    SqlDataAdapter daCliente = new SqlDataAdapter(consulta, conexion);
                    daCliente.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    daCliente.Fill(dsCliente, nombreTabla); //dsPersonal es ahora nuestra base de datos local
                }
                else //si cadena todo esta vacia
                {
                    String consulta = "Select * FROM Cliente";
                    SqlDataAdapter daCliente = new SqlDataAdapter(consulta, conexion);
                    daCliente.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    daCliente.Fill(dsCliente, nombreTabla); //dsPersonal es ahora nuestra base de datos local
                }


            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsCliente;
        }

        public DataSet ConseguirProvincias()
        {
            DataSet dsProvin = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select id_prov,nombre FROM Provincia";
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

        public DataSet ConseguirCiudades(string prov)
        {
            DataSet dsCiu = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select municipio FROM Ciudades where provincia='" + prov + "'";
                SqlDataAdapter daCiu = new SqlDataAdapter(consulta, conexion);
                daCiu.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCiu.Fill(dsCiu, "Ciudades"); //dsPersonal es ahora nuestra base de datos local
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsCiu;
        }

        public DataSet ObtenerDatosClienteConDni(string dni)
        {
            DataSet dsCliente = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "SELECT * FROM Cliente WHERE DNI='" + dni + "'";
                SqlDataAdapter daCliente = new SqlDataAdapter(consulta, conexion);
                daCliente.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCliente.Fill(dsCliente, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsCliente;
        }

        public void BorrarCliente(ArrayList arraydni)
        {
            DataSet dsCliente = new DataSet();
            try
            {
                string frase = "";
                for (int i = 0; i < arraydni.Count; i++)
                {
                    if (i == 0) { frase += "'" + arraydni[i] + "'"; }
                    else
                    {
                        frase += ",";
                        frase += "'" + arraydni[i] + "'";
                    }
                }

                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Cliente where DNI in (" + frase + ")";
                SqlDataAdapter daCliente = new SqlDataAdapter(consulta, conexion);
                daCliente.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCliente.Fill(dsCliente, nombreTabla);
                for (int i = 0; i < arraydni.Count; i++)//lo hacemos parar borrar las filas que corresponden con los dnis 
                {
                    dsCliente.Tables["Cliente"].Rows[i].Delete();
                }
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daCliente);
                daCliente.Update(dsCliente, "Cliente");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void AnyadirCliente(DataSet cliente)
        {
            DataSet dsCliente = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Cliente";
                SqlDataAdapter daCliente = new SqlDataAdapter(consulta, conexion);
                daCliente.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCliente.Fill(dsCliente, nombreTabla); //nombre de tabla esta declarado arriba del todo y sera "Personal"
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daCliente);
                daCliente.Update(cliente, "Cliente");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void EditarCliente(DataSet cliente)
        {
            DataSet dsCliente = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Cliente where DNI='" + cliente.Tables["Cliente"].Rows[0][0] + "'";
                SqlDataAdapter daCliente = new SqlDataAdapter(consulta, conexion);
                daCliente.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCliente.Fill(dsCliente, nombreTabla);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daCliente);
                daCliente.Update(cliente, "Cliente");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public DataSet SacarTarifa()
        {
            DataSet dsTarifa = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select tipo FROM Tarifas";
                SqlDataAdapter daTarifa = new SqlDataAdapter(consulta, conexion);
                daTarifa.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daTarifa.Fill(dsTarifa, "Tarifas"); //dsPersonal es ahora nuestra base de datos local
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsTarifa;

        }

        public int ReservasCliente(string dni)
        {
            DataSet dsResCliente = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * FROM Reservas where FK_Cliente = '" + dni + "'";
                SqlDataAdapter daResCliente = new SqlDataAdapter(consulta, conexion);
                daResCliente.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daResCliente.Fill(dsResCliente, "Reservas");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsResCliente.Tables["Reservas"].Rows.Count;
        }
    }
}

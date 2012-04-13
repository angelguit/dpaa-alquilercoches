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

        public DataSet ObtenerTablaPersonal(string todo)
        {
            DataSet dsPersonal = new DataSet();
            
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                //String consulta = "Select * FROM Personal WHERE ciudad like '%"+ciu+"%' and apellidos='"+apell+"'";
               
                if(todo!="") //si cadena todo esta llena
                {
                    String consulta = "Select * FROM Personal WHERE "+todo+"";
                    SqlDataAdapter daPersonal = new SqlDataAdapter(consulta, conexion);
                    daPersonal.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    daPersonal.Fill(dsPersonal, nombreTabla); //dsPersonal es ahora nuestra base de datos local
                }
                else //si cadena todo esta vacia
                {
                   String consulta = "Select * FROM Personal";
                   SqlDataAdapter daPersonal = new SqlDataAdapter(consulta, conexion);
                   daPersonal.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                   daPersonal.Fill(dsPersonal, nombreTabla); //dsPersonal es ahora nuestra base de datos local
                }

               
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
                String consulta = "Select municipio FROM Ciudades where provincia='"+prov+"'";
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

        public DataSet ObtenerDatosPersonalConDni(string dni)
        {
            DataSet dsPersona = new DataSet();
           
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "SELECT * FROM Personal WHERE DNI='" + dni + "'";
                SqlDataAdapter daVehiculo = new SqlDataAdapter(consulta, conexion);
                daVehiculo.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daVehiculo.Fill(dsPersona, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsPersona;
        }

        public void BorrarPersonal(ArrayList arraydni)
        {
            DataSet dsPersonal = new DataSet();
            try
            {
                string frase="";
                for (int i = 0; i < arraydni.Count; i++)
                {
                    if (i == 0){ frase += "'" + arraydni[i] + "'"; }
                    else
                    {
                        frase += ",";
                        frase += "'" + arraydni[i] + "'";
                    }
                }

                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Personal where DNI in ("+frase+")";
                SqlDataAdapter daPersonal = new SqlDataAdapter(consulta, conexion);
                daPersonal.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daPersonal.Fill(dsPersonal, nombreTabla);
                for (int i = 0; i < arraydni.Count; i++)//lo hacemos parar borrar las filas que corresponden con los dnis 
                {
                    dsPersonal.Tables["Personal"].Rows[i].Delete();
                }
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daPersonal);
                daPersonal.Update(dsPersonal, "Personal");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void AnyadirPersonal(DataSet persona)
        {
            DataSet dsPersonal = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Personal";
                SqlDataAdapter daPersonal = new SqlDataAdapter(consulta, conexion);
                daPersonal.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daPersonal.Fill(dsPersonal, nombreTabla); //nombre de tabla esta declarado arriba del todo y sera "Personal"
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daPersonal);
                daPersonal.Update(persona, "Personal");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void EditarPersonal(DataSet persona)
        {
            DataSet dsPersonal = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Personal where DNI='" + persona.Tables["Personal"].Rows[0][0] + "'";
                SqlDataAdapter daPersonal = new SqlDataAdapter(consulta, conexion);
                daPersonal.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daPersonal.Fill(dsPersonal, nombreTabla);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daPersonal);
                daPersonal.Update(persona, "Personal");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }


}


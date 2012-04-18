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

        public DataSet ObtenerTablaProveedores(string cadena)
        {
            DataSet dsProveedores = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);

                //String consulta = "Select * FROM Proveedores WHERE " + todo + "";
                if (cadena == "")
                {
                    String consulta = "Select * FROM Proveedores";
                    SqlDataAdapter DAproveedor = new SqlDataAdapter(consulta, conexion);
                    DAproveedor.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    DAproveedor.Fill(dsProveedores, nombreTabla); //dsProveedores es ahora nuestra base de datos local
                }
                else
                {
                    String consulta = "Select * FROM Proveedores where "+cadena+"";
                    SqlDataAdapter DAproveedor = new SqlDataAdapter(consulta, conexion);
                    DAproveedor.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    DAproveedor.Fill(dsProveedores, nombreTabla); //dsProveedores es ahora nuestra base de datos local
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsProveedores;
        }

        public void InsertarProveedorCAD(DataSet cadena)
        {
            DataSet dsProveedores = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Proveedores";
                SqlDataAdapter daProveedores = new SqlDataAdapter(consulta, conexion);
                daProveedores.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daProveedores.Fill(dsProveedores, nombreTabla); //nombre de tabla esta declarado arriba del todo y sera "Personal"
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daProveedores);
                daProveedores.Update(cadena, "Proveedores");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void BorrarProveedor(ArrayList dnis)
        {
            DataSet dsProveedores = new DataSet();
            try
            {
                string cadena = "";
                for (int i = 0; i < dnis.Count; i++)
                {
                    if (i == 0) { cadena += "'" + dnis[i] + "'"; }
                    else
                    {
                        cadena += ",";
                        cadena += "'" + dnis[i] + "'";
                    }
                }

                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Proveedores where CIF in (" + cadena + ")";
                SqlDataAdapter daProveedores= new SqlDataAdapter(consulta, conexion);
                daProveedores.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daProveedores.Fill(dsProveedores, nombreTabla);
                for (int i = 0; i < dnis.Count; i++)//lo hacemos parar borrar las filas que corresponden con los dnis 
                {
                    dsProveedores.Tables["Proveedores"].Rows[i].Delete();
                }
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daProveedores);
                daProveedores.Update(dsProveedores, "Proveedores");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
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

        public void modificarProveedorCAD(DataSet proveedor)
        {
            DataSet dsProveedores = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Proveedores where CIF='" + proveedor.Tables["Proveedores"].Rows[0][0] + "'";
                SqlDataAdapter daProveedor = new SqlDataAdapter(consulta, conexion);
                daProveedor.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daProveedor.Fill(dsProveedores, nombreTabla);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daProveedor);
                daProveedor.Update(proveedor, "Proveedores");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}

using System; 
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
    public class CADFacturacion
    {

        static private String cadenaConexion = ConfigurationManager.ConnectionStrings["AlquilerCoches"].ConnectionString; // @"Data Source=|DataDirectory|\BBDD.sdf";
        static private String nombreTabla = "Facturas";

        public DataSet ObtenerTablaFacturas(string sentencia)
        {
            /*DataSet dsFacturas = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String consulta = "Select * from Facturas";
                SqlDataAdapter daCaminos = new SqlDataAdapter(consulta, conexion);
                daCaminos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daCaminos.Fill(dsFacturas, nombreTabla);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsFacturas;*/
            DataSet dsFac = new DataSet();
            SqlDataAdapter daFac;
            string consulta;
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                if (sentencia != "")
                    consulta = "Select * from Facturas where " + sentencia;
                else
                    consulta = "Select * from Facturas";
                daFac = new SqlDataAdapter(consulta, conexion);
                daFac.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daFac.Fill(dsFac, "Facturas");
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return dsFac;
        }

        public DataSet ObtenerFacturas()
        {
            DataSet dsFac = new DataSet();
            SqlDataAdapter daFac;
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                string consulta = "Select * from Facturas";
                daFac = new SqlDataAdapter(consulta, conexion);
                daFac.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daFac.Fill(dsFac, "Facturas");
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return dsFac;
        }

        public double ObtenerPrecioCat(string cat)
        {
            DataSet dsFac = new DataSet();
            SqlDataAdapter daFac;
            try
            {
                if (cat != "")
                {
                    SqlConnection conexion = new SqlConnection(cadenaConexion);
                    string consulta = "Select Precio from Categoria where Tipo = '" + cat + "'";
                    daFac = new SqlDataAdapter(consulta, conexion);
                    daFac.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    daFac.Fill(dsFac, "Facturas");
                    return double.Parse(dsFac.Tables["Facturas"].Rows[0][0].ToString());
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public double ObtenerDescuentoTar(string tar)
        {
            DataSet dsFac = new DataSet();
            SqlDataAdapter daFac;
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                string consulta = "Select Descuento from Tarifas where Tipo = '" + tar + "'";
                daFac = new SqlDataAdapter(consulta, conexion);
                daFac.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daFac.Fill(dsFac, "Facturas");
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return double.Parse(dsFac.Tables["Facturas"].Rows[0][0].ToString());
        }

        public bool ExisteCat(string cat)
        {
            DataSet dsFac = new DataSet();
            SqlDataAdapter daFac;
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                string consulta = "Select * from Categoria where Tipo = '" + cat + "'";
                daFac = new SqlDataAdapter(consulta, conexion);
                daFac.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daFac.Fill(dsFac, "Facturas");
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            if (dsFac.Tables["Facturas"].Rows.Count > 0)
                return true;
            else
                return false;
        }
        
    }
}

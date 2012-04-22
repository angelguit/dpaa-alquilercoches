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

namespace EN
{
    public class ENVentasRealizadas
    {
        private string precioVenta;
        private string matricula;
        private string marca;
        private string modelo;
        private string dni;
        private string garantia;

        private ArrayList listaDNI = new ArrayList();

        private CAD.CADVentasRealizadas cadVentasRealizadas = new CAD.CADVentasRealizadas();

        public ArrayList ListaDNI
        {
            get { return listaDNI; }
            set { listaDNI = value; }
        }

        public string PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Garantia
        {
            get { return garantia; }
            set { garantia = value; }
        }

        public void ClearEnVentas()
        {
            matricula = marca = modelo = garantia = dni = "";
             precioVenta = "";
        }

        public DataSet ObtenerListaVentasRealizadas()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVentasRealizadas.ObtenerTablaVentasRealizadas();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return resultado;
        }

        public void ObtenerDNI()
        {
            DataSet resultado = new DataSet();
            try
            {
                listaDNI.Clear();
                resultado = cadVentasRealizadas.ObtenerDNI();
                for (int i = 0; !resultado.Tables["VentasRealizadas"].Rows.Count.Equals(i); i++)
                    if (!listaDNI.Contains(resultado.Tables["VentasRealizadas"].Rows[i].ItemArray[0])) listaDNI.Add(resultado.Tables["VentasRealizadas"].Rows[i].ItemArray[0]);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            //return resultado;
        }

        public void ObtenerDatosVehiculos()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVentasRealizadas.ObtenerDatosVehiculo(dni);

                dni = resultado.Tables["VentasRealizadas"].Rows[0][0].ToString();
                matricula = resultado.Tables["VentasRealizadas"].Rows[0][1].ToString();
                marca = resultado.Tables["VentasRealizadas"].Rows[0][2].ToString();
                modelo = resultado.Tables["VentasRealizadas"].Rows[0][3].ToString();
                garantia = resultado.Tables["VentasRealizadas"].Rows[0][4].ToString();
                precioVenta = resultado.Tables["VentasRealizadas"].Rows[0][5].ToString();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            //return resultado;
        }

        public void AnyadirVenta()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVentasRealizadas.ObtenerTablaVentasRealizadas();
                DataRow linea = resultado.Tables["VentasRealizadas"].NewRow();
                linea[0] = dni;
                linea[1] = matricula;
                linea[2] = marca;
                linea[3] = modelo;
                linea[4] = garantia;
                linea[5] = precioVenta;
                resultado.Tables["VentasRealizadas"].Rows.Add(linea);
                cadVentasRealizadas.AnyadirVentasRealizadas(resultado);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

    }
}

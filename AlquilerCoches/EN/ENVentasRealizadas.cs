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
        private string numero;
        private string precioVenta;
        private string matricula;
        private string marca;
        private string modelo;
        private string dni;
        private string garantia;
        private string fecha;

        private ArrayList listaDNI = new ArrayList();

        private CAD.CADVentasRealizadas cadVentasRealizadas = new CAD.CADVentasRealizadas();

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

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

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public void ClearEnVentas()
        {
            matricula = marca = modelo = garantia = dni = "";
             precioVenta = fecha = numero = "";
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

        public void ObtenerDatosVentas()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVentasRealizadas.ObtenerDatosVehiculo(dni);

                numero = resultado.Tables["VentasRealizadas"].Rows[0][0].ToString();
                dni = resultado.Tables["VentasRealizadas"].Rows[0][1].ToString();
                matricula = resultado.Tables["VentasRealizadas"].Rows[0][2].ToString();
                marca = resultado.Tables["VentasRealizadas"].Rows[0][3].ToString();
                modelo = resultado.Tables["VentasRealizadas"].Rows[0][4].ToString();
                garantia = resultado.Tables["VentasRealizadas"].Rows[0][5].ToString();
                precioVenta = resultado.Tables["VentasRealizadas"].Rows[0][6].ToString();
                fecha = resultado.Tables["VentasRealizadas"].Rows[0][7].ToString();
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
                linea[1] = dni;
                linea[2] = matricula;
                linea[3] = marca;
                linea[4] = modelo;
                linea[5] = garantia;
                linea[6] = precioVenta;
                linea[7] = fecha;
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

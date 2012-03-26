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
    public class ENVehiculo
    {
        private string matricula;
        private string marca;
        private string modelo;
        private int anyo;
        private int precioVenta;
        private int precioCompra;
        private int precioAlquiler;
        private int km;
        private int estado;
        private int garantia;

        private CAD.CADVehiculo cadVehiculo = new CAD.CADVehiculo();

        public DataSet ObtenerListaVehiculos()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVehiculo.ObtenerTablaVehiculo();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return resultado; 
        }

        public DataSet ObtenerMarcas()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVehiculo.ObtenerMarcas();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return resultado;
        }

        public DataSet ObtenerModelo(string marca)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVehiculo.ObtenerModelos(marca);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return resultado;
        }

        public DataSet ObtenerMatriculas(string marca, string modelo)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVehiculo.ObtenerMatricula(marca, modelo);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return resultado;
        }

        public DataSet ObtenerDatosVehiculos(string matricula)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVehiculo.ObtenerDatosVehiculo(matricula);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return resultado;
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = Matricula; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = Marca; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = Modelo; }
        }
        public int Anyo
        {
            get { return anyo; }
            set { anyo = Anyo; }
        }
        public int PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = PrecioVenta; }
        }
        public int PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = PrecioCompra; }
        }
        public int PrecioAlquiler
        {
            get { return precioAlquiler; }
            set { precioAlquiler = PrecioAlquiler; }
        }
        public int KM
        {
            get { return km; }
            set { km = KM; }
        }
        public int Estado
        {
            get { return estado; }
            set { estado = Estado; }
        }
        public int Garantia
        {
            get { return garantia; }
            set { garantia = Garantia; }
        }
    }
}

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
    public class ENFacturacion
    {
        private string categoria;
        private string vehiculo;
        private int conductores;
        private string tarifa;
        private int tiempo;
        private double precioSinIVA;
        private double iva;
        private double precioTotal;
        private int factura;
        private int idCliente;

        private CAD.CADFacturacion cadFacturacion = new CAD.CADFacturacion();

        public string Categoria
        {
            get { return categoria; }
            set { categoria = Categoria; }
        }
        public string Vehiculo
        {
            get { return vehiculo; }
            set { vehiculo = Vehiculo; }
        }
        public int Conductores
        {
            get { return conductores; }
            set { conductores = Conductores; }
        }
        public string Tarifa
        {
            get { return tarifa; }
            set { tarifa = Tarifa; }
        }
        public int Tiempo
        {
            get { return tiempo; }
            set { tiempo = Tiempo; }
        }
        public double PrecioSinIVA
        {
            get { return precioSinIVA; }
            set { precioSinIVA = PrecioSinIVA; }
        }
        public double IVA
        {
            get { return iva; }
            set { iva = IVA; }
        }
        public double PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = PrecioTotal; }
        }
        public int Factura
        {
            get { return factura; }
            set { factura = Factura; }
        }
        public int IDCliente
        {
            get { return idCliente; }
            set { idCliente = IDCliente; }
        }

        public DataSet ObtenerFacturas(string sentencia)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadFacturacion.ObtenerTablaFacturas();//todas
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return resultado;
        }
    }
}


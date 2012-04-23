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
        private string cliente;
        private DateTime diaFacturacion;

        private CAD.CADFacturacion cadFacturacion = new CAD.CADFacturacion();

        public DateTime DiaFacturacion
        {
            get { return diaFacturacion; }
            set { diaFacturacion = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string Vehiculo
        {
            get { return vehiculo; }
            set { vehiculo = value; }
        }
        public int Conductores
        {
            get { return conductores; }
            set { conductores = value; }
        }
        public string Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }
        public int Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        public double PrecioSinIVA
        {
            get { return precioSinIVA; }
            set { precioSinIVA = value; }
        }
        public double IVA
        {
            get { return iva; }
            set { iva = value; }
        }
        public double PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }
        public int Factura
        {
            get { return factura; }
            set { factura = value; }
        }
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public DataSet ObtenerFacturas(string sentencia)
        {
            DataSet resultado = new DataSet();
             try
            {
                resultado = cadFacturacion.ObtenerTablaFacturas(sentencia);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return resultado;
        }

        public DataSet ObtenerFacturas()
        {
            DataSet resultado = new DataSet();
            try
            {
                return cadFacturacion.ObtenerFacturas();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void ObtenerPrecio()
        {
            double precio = 0.0;

            precio += cadFacturacion.ObtenerPrecioCat(categoria);
            precio *= tiempo;

            if ( (tarifa == "Normal" || tarifa == "Socio" ) && conductores > 1 )
            {
                precio += (conductores - 1) * 5;
            }
            else if (tarifa == "Premium" && conductores > 3)
            {
                precio += 5;
            }

            if (tiempo > 1 && tiempo < 4)
            {
                precio -= (0.02 * tiempo) * precio;
            }
            if (tiempo > 4)
            {
                precio -= (0.15 * precio);
            }

            precio *= (1 - (0.01 * cadFacturacion.ObtenerDescuentoTar(tarifa)));

            precioTotal = precio;
            precioSinIVA = precio * 0.82;
            iva = precio * 0.18;
        }

        public bool ExisteCat(string cat)
        {
            return cadFacturacion.ExisteCat(cat);
        }

        public void AnyadirFactura()
        {
            DataSet dsFa = new DataSet();
            dsFa = cadFacturacion.ObtenerFacturas();
            DataRow linea = dsFa.Tables["Facturas"].NewRow();
            linea[1] = cliente;
            linea[2] = vehiculo;
            linea[3] = conductores;
            linea[4] = tiempo;
            linea[5] = tarifa;
            linea[6] = precioTotal;
            linea[7] = diaFacturacion;
            dsFa.Tables["Facturas"].Rows.Add(linea);
            cadFacturacion.AnyadirFactura(dsFa);
        }

        public int UltimaFactura()
        {
            return cadFacturacion.UltimaFactura();
        }

        public void EliminarReserva(ArrayList array)
        {
            cadFacturacion.EliminarFacturas(array);
        }
    }
}


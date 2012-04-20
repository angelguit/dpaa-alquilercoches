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
using CAD;


namespace EN
{
    public class ENReservas
    {
        private string cliente;
        private string categoria;
        private string modelo;
        private string matricula;
        private int conductores;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private bool activa;

        private CAD.CADReservas cadReservas = new CAD.CADReservas();

        public int NumeroUltimaReserva()
        {
            return cadReservas.NumeroUltimaReserva();
        }

        public void AnyadirReserva()
        {
            DataSet res = new DataSet();
            res = cadReservas.ObtenerReservas();
            DataRow linea = res.Tables["Reservas"].NewRow();
            linea[1] = cliente;
            linea[2] = matricula;
            linea[3] = fechaInicio;
            linea[4] = fechaFin;
            linea[5] = conductores;
            linea[6] = activa;
            res.Tables["Reservas"].Rows.Add(linea);
            cadReservas.AnyadirReserva(res);

        }

        public DataSet ObtenerReservas()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadReservas.ObtenerReservas();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return resultado;
        }

        public DataSet ObtenerReservas(string sentencia)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadReservas.ObtenerReservas(sentencia);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return resultado;
        }
        public DataSet RellenarCategoria()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadReservas.RellenarCategoria();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return resultado;
        }

        public int EjecutarSentencia(string comando)
        {
            return cadReservas.EjecutarSentencia(comando);
        }

        public void EliminarReserva(ArrayList numRes)
        {
            try
            {
                cadReservas.EliminarReserva(numRes);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public int Conductores
        {
            get { return conductores; }
            set { conductores = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public bool Activa
        {
            get { return activa; }
            set { activa = value; }
        }

            
    }
}

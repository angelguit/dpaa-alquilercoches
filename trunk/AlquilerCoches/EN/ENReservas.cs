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

        private CAD.CADReservas cadReservas = new CAD.CADReservas();

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

        public string Cliente
        {
            get { return cliente; }
            set { cliente = Cliente; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = Categoria; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = Modelo; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = Matricula; }
        }

        public int Conductores
        {
            get { return conductores; }
            set { conductores = Conductores; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = FechaInicio; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = FechaFin; }
        }
    }
}

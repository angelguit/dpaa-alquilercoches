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

namespace AlquilerCoches.EN
{
    public class ENProveedores
    {
        private string cif;
        private string marca;
        private string calle;
        private int numero;
        private int telefono;
        private string email;
        private string ciudad;
        private string provincia;
        private int codigopostal;
        private string horario;

        private CAD.CADProveedores cadProveedores= new CAD.CADProveedores();

        public DataSet ObtenerListaProveedores()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadProveedores.ObtenerTablaProveedores();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return resultado;
        }


        public string CIF
        {
            get { return cif; }
            set { cif = CIF; }
        }
        private string Marca
        {
            get { return marca; }
            set { marca = Marca; }
        }
        private string Calle
        {
            get { return calle; }
            set { calle = Calle; }
        }
        private int Numero
        {
            get { return numero; }
            set { numero = Numero; }
        }
        private int Telefono
        {
            get { return telefono; }
            set { telefono = Telefono; }
        }
        private string Email
        {
            get { return email; }
            set { email = Email; }
        }
        private string Ciudad
        {
            get { return ciudad; }
            set { ciudad = Ciudad; }
        }
        private string Provincia
        {
            get { return provincia; }
            set { provincia = Provincia; }
        }
        private int Codigopostal
        {
            get { return codigopostal; }
            set { codigopostal = Codigopostal; }
        }
        private string Horario
        {
            get { return horario; }
            set { horario = Horario; }
        }
    }
}

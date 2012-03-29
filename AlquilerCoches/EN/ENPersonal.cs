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
    public class ENPersonal
    {
        
        private string dni;
        private string nombre;
        private string apellidos;
        private int telefono;
        private string email;
        private string direccion;
        private string ciudad;
        private string provincia;
        private string puestoac;
        private string otrospuestos;


       private CAD.CADPersonal cadPersonal = new CAD.CADPersonal();

        public string DNI
        {
            get { return dni; }
            set { dni = DNI; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = Nombre; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = Apellidos; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = Telefono; }
        }
        public string Email
        {
            get { return email; }
            set { email = Email; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = Direccion; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = Ciudad; }
        }
        public string Provincia
        {
            get { return provincia; }
            set { provincia = Provincia; }
        }
        public string PuestoAc
        {
            get { return puestoac; }
            set { puestoac = PuestoAc; }
        }
        public string OtrosPuestos
        {
            get { return otrospuestos; }
            set { otrospuestos = OtrosPuestos; }
        }

        public DataSet ObtenerListaPersonal(string todo)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadPersonal.ObtenerTablaPersonal(todo);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return resultado;
        }

        public DataSet ObtenerListaProvincias()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadPersonal.ConseguirProvincias();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return resultado;
        }


    }
}


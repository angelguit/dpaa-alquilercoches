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

        public string CIF
        {
            get { return cif; }
            set { cif = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }
        public int Codigopostal
        {
            get { return codigopostal; }
            set { codigopostal = value; }
        }
        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }


        public DataSet ObtenerListaProveedores(string cadena)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadProveedores.ObtenerTablaProveedores(cadena);
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
                resultado = cadProveedores.ConseguirProvincias();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return resultado;
        }

        public DataSet ObtenerListaCiudades(string prov)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadProveedores.ConseguirCiudades(prov);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return resultado;
        }

        public void BorrarProveedorEN(ArrayList dnis)
        {
            try
            {
                cadProveedores.BorrarProveedor(dnis);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void InsertarProveedorEN()
        {
            DataSet resultado = new DataSet();
            try
            {
                string cadena = ""; //si la frase que le pasamos esta vacia nos devolvera todos los resultados
                resultado = cadProveedores.ObtenerTablaProveedores(cadena);
                DataRow linea = resultado.Tables["Proveedores"].NewRow();
                linea[0] = cif;
                linea[1] = marca;
                linea[2] = calle;
                linea[3] = numero;
                linea[4] = telefono;
                linea[5] = email;
                linea[6] = ciudad;
                linea[7] = provincia;
                linea[8] = codigopostal;
                linea[9] = horario;
                resultado.Tables["Proveedores"].Rows.Add(linea);
                cadProveedores.InsertarProveedorCAD(resultado);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void modificarProveedorEN()
        {
            try
            {
                string cadena = " CIF='" + cif + "' ";
                DataSet proveedor = cadProveedores.ObtenerTablaProveedores(cadena);
                proveedor.Tables["Proveedores"].Rows[0][1] = marca.ToString();
                proveedor.Tables["Proveedores"].Rows[0][2] = calle.ToString();
                proveedor.Tables["Proveedores"].Rows[0][3] = numero.ToString();
                proveedor.Tables["Proveedores"].Rows[0][4] = telefono.ToString();
                proveedor.Tables["Proveedores"].Rows[0][5] = email.ToString();
                proveedor.Tables["Proveedores"].Rows[0][6] = ciudad.ToString();
                proveedor.Tables["Proveedores"].Rows[0][7] = provincia.ToString();
                proveedor.Tables["Proveedores"].Rows[0][8] = codigopostal.ToString();
                proveedor.Tables["Proveedores"].Rows[0][9] = horario.ToString();

                cadProveedores.modificarProveedorCAD(proveedor);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}

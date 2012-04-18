﻿using System;
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
    public class ENCliente
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
        private string tarifa;


        private CAD.CADCliente cadCliente = new CAD.CADCliente();
      
        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
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
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
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
        public string PuestoAc
        {
            get { return puestoac; }
            set { puestoac = value; }
        }
        public string OtrosPuestos
        {
            get { return otrospuestos; }
            set { otrospuestos = value; }
        }
        public string Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }

        public DataSet ObtenerListaCliente(string todo)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadCliente.ObtenerTablaCliente(todo);
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
                resultado = cadCliente.ConseguirProvincias();
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
                resultado = cadCliente.ConseguirCiudades(prov);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return resultado;
        }
        
      

        public void EliminarCliente(ArrayList arraydni)
        {
            try
            {
                cadCliente.BorrarCliente(arraydni);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public void AnyadirCliente()
        {
            DataSet resultado = new DataSet();
            try
            {
                string frase = ""; //si la frase que le pasamos esta vacia nos devolvera todos los resultados
                resultado = cadCliente.ObtenerTablaCliente(frase);
                DataRow linea = resultado.Tables["Cliente"].NewRow();
                //linea[0] = ; para el recuadro eliminar
                //linea[1] = ; para el boton editar
                linea[0] = dni;
                linea[1] = nombre;
                linea[2] = apellidos;
                linea[3] = telefono;
                linea[4] = email;
                linea[5] = direccion;
                linea[6] = ciudad;
                linea[7] = provincia;
                linea[8] = puestoac;
                linea[9] = otrospuestos;
                resultado.Tables["Cliente"].Rows.Add(linea);
                cadCliente.AnyadirCliente(resultado);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public void EditarCliente()
        {
            try
            {
                DataSet cliente = cadCliente.ObtenerDatosClienteConDni(dni);
                cliente.Tables["Personal"].Rows[0][1] = nombre.ToString(); //el dni no se puede cambiar asique saltamos la posicion 0 que es del dni
                cliente.Tables["Personal"].Rows[0][2] = apellidos.ToString();
                cliente.Tables["Personal"].Rows[0][3] = telefono.ToString();
                cliente.Tables["Personal"].Rows[0][4] = email.ToString();
                cliente.Tables["Personal"].Rows[0][5] = direccion.ToString();
                cliente.Tables["Personal"].Rows[0][6] = ciudad.ToString();
                cliente.Tables["Personal"].Rows[0][7] = provincia.ToString();
                cliente.Tables["Personal"].Rows[0][8] = puestoac.ToString();
                cliente.Tables["Personal"].Rows[0][9] = otrospuestos.ToString();
                cadCliente.EditarCliente(cliente);

            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

    }
}

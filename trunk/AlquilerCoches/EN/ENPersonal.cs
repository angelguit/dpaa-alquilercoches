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

        public DataSet ObtenerListaCiudades(string prov)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadPersonal.ConseguirCiudades(prov);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return resultado;
        }
        
      

        public void EliminarPersonal(ArrayList arraydni)
        {
            try
            {
                cadPersonal.BorrarPersonal(arraydni);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public void AnyadirPersonal()
        {
            DataSet resultado = new DataSet();
            try
            {
                string frase = ""; //si la frase que le pasamos esta vacia nos devolvera todos los resultados
                resultado = cadPersonal.ObtenerTablaPersonal(frase);
                DataRow linea = resultado.Tables["Personal"].NewRow();
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
                resultado.Tables["Personal"].Rows.Add(linea);
                cadPersonal.AnyadirPersonal(resultado);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public void EditarPersonal()
        {
            try
            {
                DataSet persona = cadPersonal.ObtenerDatosPersonalConDni(dni);
                persona.Tables["Personal"].Rows[0][1] = nombre.ToString(); //el dni no se puede cambiar asique saltamos la posicion 0 que es del dni
                persona.Tables["Personal"].Rows[0][2] = apellidos.ToString();
                persona.Tables["Personal"].Rows[0][3] = telefono.ToString();
                persona.Tables["Personal"].Rows[0][4] = email.ToString();
                persona.Tables["Personal"].Rows[0][5] = direccion.ToString();
                persona.Tables["Personal"].Rows[0][6] = ciudad.ToString();
                persona.Tables["Personal"].Rows[0][7] = provincia.ToString();
                persona.Tables["Personal"].Rows[0][8] = puestoac.ToString();
                persona.Tables["Personal"].Rows[0][9] = otrospuestos.ToString();
                cadPersonal.EditarPersonal(persona);

            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public void ObtenerDatosPersonal()
        {
            try
            {
                DataSet persona = cadPersonal.ObtenerDatosPersonalConDni(dni);
                nombre = persona.Tables["Personal"].Rows[0][1].ToString(); //el dni no se puede cambiar asique saltamos la posicion 0 que es del dni
                apellidos = persona.Tables["Personal"].Rows[0][2].ToString();
                telefono = int.Parse(persona.Tables["Personal"].Rows[0][3].ToString());
                email = persona.Tables["Personal"].Rows[0][4].ToString();
                direccion = persona.Tables["Personal"].Rows[0][5].ToString();
                ciudad = persona.Tables["Personal"].Rows[0][6].ToString();
                provincia = persona.Tables["Personal"].Rows[0][7].ToString();
                puestoac = persona.Tables["Personal"].Rows[0][8].ToString();
                otrospuestos= persona.Tables["Personal"].Rows[0][9].ToString();

            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

    }
}


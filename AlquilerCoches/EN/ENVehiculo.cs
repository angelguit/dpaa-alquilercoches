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
        private string anyo;
        private string precioVenta;
        private string precioCompra;
        private string km;
        private string estado;
        private string garantia;
        private string categoria;

        private ArrayList listaMarcas = new ArrayList();
        private ArrayList listaModelos = new ArrayList();
        private ArrayList listaMatriculas = new ArrayList();


        private CAD.CADVehiculo cadVehiculo = new CAD.CADVehiculo();

        public void ClearEnVehiculo()
        {
            matricula = marca = modelo= categoria= garantia= estado="";
            anyo = precioCompra = precioVenta = km = "";
        }

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

        public void ObtenerMarcas()
        {
            DataSet resultado = new DataSet();
            try
            {
                listaMarcas.Clear();
                resultado = cadVehiculo.ObtenerMarcas();
                for (int i = 0; !resultado.Tables["Vehiculo"].Rows.Count.Equals(i); i++)
                    if (!listaMarcas.Contains(resultado.Tables["Vehiculo"].Rows[i].ItemArray[0])) listaMarcas.Add(resultado.Tables["Vehiculo"].Rows[i].ItemArray[0]);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            //return resultado;
        }

        public void ObtenerModelo()
        {
            DataSet resultado = new DataSet();
            try
            {
                listaModelos.Clear();
                resultado = cadVehiculo.ObtenerModelos(marca);
                for (int i = 0; !resultado.Tables["Vehiculo"].Rows.Count.Equals(i); i++)
                    if (!listaModelos.Contains(resultado.Tables["Vehiculo"].Rows[i].ItemArray[0])) listaModelos.Add(resultado.Tables["Vehiculo"].Rows[i].ItemArray[0]);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            //return resultado;
        }
        
        public void ObtenerMatriculas()
        {
            DataSet resultado = new DataSet();
            try
            {
                listaMatriculas.Clear();
                resultado = cadVehiculo.ObtenerMatricula(marca, modelo);
                for (int i = 0; !resultado.Tables["Vehiculo"].Rows.Count.Equals(i); i++)
                    if (!listaMatriculas.Contains(resultado.Tables["Vehiculo"].Rows[i].ItemArray[0])) listaMatriculas.Add(resultado.Tables["Vehiculo"].Rows[i].ItemArray[0]);
            

            }
            catch (Exception ex)
            {
                throw (ex);
            }

            //return resultado; 
        }

        public void ObtenerDatosVehiculos()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVehiculo.ObtenerDatosVehiculo(matricula);
                
                marca = resultado.Tables["Vehiculo"].Rows[0][0].ToString();
                modelo = resultado.Tables["Vehiculo"].Rows[0][1].ToString();
                matricula = resultado.Tables["Vehiculo"].Rows[0][2].ToString();
                precioVenta =  resultado.Tables["Vehiculo"].Rows[0][3].ToString();
                precioCompra =  resultado.Tables["Vehiculo"].Rows[0][4].ToString();
                garantia = resultado.Tables["Vehiculo"].Rows[0][5].ToString();
                km = resultado.Tables["Vehiculo"].Rows[0][6].ToString();
                estado = resultado.Tables["Vehiculo"].Rows[0][7].ToString();
                categoria = resultado.Tables["Vehiculo"].Rows[0][8].ToString();

            }
            catch (Exception ex)
            {
                throw (ex);
            }

            //return resultado;
        }

        public void BorrarVehiculo()
        {
            try
            {
                cadVehiculo.BorrarVehiculo(matricula);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public void EditarVehiculo()
        {
            try
            {
                DataSet vehiculo=cadVehiculo.ObtenerDatosVehiculo(matricula);
                vehiculo.Tables["Vehiculo"].Rows[0][0] = marca;
                vehiculo.Tables["Vehiculo"].Rows[0][1] = modelo;
                //vehiculo.Tables["Vehiculo"].Rows[0][2] = matricula;
                vehiculo.Tables["Vehiculo"].Rows[0][3] = Int32.Parse(precioVenta);
                vehiculo.Tables["Vehiculo"].Rows[0][4] = Int32.Parse(precioCompra);
                vehiculo.Tables["Vehiculo"].Rows[0][5] = Int32.Parse(garantia);
                vehiculo.Tables["Vehiculo"].Rows[0][6] = Int32.Parse(km);
                vehiculo.Tables["Vehiculo"].Rows[0][7] = estado;
                //vehiculo.Tables["Vehiculo"].Rows[0][8] = categoria;
                cadVehiculo.EditarVehiculo(vehiculo);

            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public void AnyadirVehiculo()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVehiculo.ObtenerTablaVehiculo();
                DataRow linea = resultado.Tables["Vehiculo"].NewRow();
                linea[0] = marca;
                linea[1] = modelo;
                linea[2] = matricula;
                linea[3] = Int32.Parse(precioVenta);
                linea[4] = Int32.Parse(precioCompra);
                linea[5] = garantia;
                linea[6] = Int32.Parse(km);
                linea[7] = estado;
                linea[8] = Int32.Parse(categoria);
                resultado.Tables["Vehiculo"].Rows.Add(linea);
                cadVehiculo.AnyadirVehiculo(resultado);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public DataSet ObtenerMarcas(string cat)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVehiculo.ObtenerMarcas(cat);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return resultado;
        }

        public DataSet ObtenerModelosVehiculos(string cat, string mar)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVehiculo.ObtenerModelosVehiculo(cat,mar);
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
                listaMatriculas.Clear();
                resultado = cadVehiculo.ObtenerMatricula(marca, modelo);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return resultado; 
        }

        public DataSet ObtenerListaMatriculasVehiculos(string mod)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVehiculo.ObtenerMatriculasVehiculo(mod);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return resultado;
        }

        public DataSet ObtenerCategorias()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVehiculo.ObtenerCategorias();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return resultado; 
        }

        public ArrayList ListaMatriculas
        {
            get { return listaMatriculas; }
            set { listaMatriculas = value; }
        }
        public ArrayList ListaModelos
        {
            get { return listaModelos; }
            set { listaMarcas = value; }
        }

        public ArrayList ListaMarcas
        {
            get { return listaMarcas; }
            set { listaMarcas = value; }
        }
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Anyo
        {
            get { return anyo; }
            set { anyo = value; }
        }
        public string PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }
        public string PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string KM
        {
            get { return km; }
            set { km = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Garantia
        {
            get { return garantia; }
            set { garantia = value; }
        }
    }
}

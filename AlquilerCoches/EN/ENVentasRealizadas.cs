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
    class ENVentasRealizadas
    {
        private string precioVenta;
        private string matricula;
        private string marca;
        private string modelo;
        private string dni;
        private string garantia;

        private ArrayList listaMarcas = new ArrayList();

        private CAD.CADVentasRealizadas cadVentasRealizadas = new CAD.CADVentasRealizadas();

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

        public string PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
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

        public string KM
        {
            get { return km; }
            set { km = value; }
        }

        public string Garantia
        {
            get { return garantia; }
            set { garantia = value; }
        }

        public void ClearEnVentas()
        {
            matricula = marca = modelo = garantia = km = "";
             precioVenta = "";
        }

        public DataSet ObtenerListaVentas()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVentasRealizadas.ObtenerTablaVentas();
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
                resultado = cadVentasRealizadas.ObtenerMarcas();
                for (int i = 0; !resultado.Tables["Ventas"].Rows.Count.Equals(i); i++)
                    if (!listaMarcas.Contains(resultado.Tables["Ventas"].Rows[i].ItemArray[0])) listaMarcas.Add(resultado.Tables["Ventas"].Rows[i].ItemArray[0]);
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
                resultado = cadVentasRealizadas.ObtenerModelos(marca);
                for (int i = 0; !resultado.Tables["Ventas"].Rows.Count.Equals(i); i++)
                    if (!listaModelos.Contains(resultado.Tables["Ventas"].Rows[i].ItemArray[0])) listaModelos.Add(resultado.Tables["Ventas"].Rows[i].ItemArray[0]);
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
                resultado = cadVentasRealizadas.ObtenerMatricula(marca, modelo);
                for (int i = 0; !resultado.Tables["Ventas"].Rows.Count.Equals(i); i++)
                    if (!listaMatriculas.Contains(resultado.Tables["Ventas"].Rows[i].ItemArray[0])) listaMatriculas.Add(resultado.Tables["Ventas"].Rows[i].ItemArray[0]);


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
                resultado = cadVentasRealizadas.ObtenerDatosVehiculo(matricula);

                matricula = resultado.Tables["Ventas"].Rows[0][0].ToString();
                marca = resultado.Tables["Ventas"].Rows[0][1].ToString();
                modelo = resultado.Tables["Ventas"].Rows[0][2].ToString();
                km = resultado.Tables["Ventas"].Rows[0][3].ToString();
                garantia = resultado.Tables["Ventas"].Rows[0][4].ToString();
                precioVenta = resultado.Tables["Ventas"].Rows[0][5].ToString();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            //return resultado;
        }

        public void BorrarVentas()
        {
            try
            {
                cadVentasRealizadas.BorrarVehiculoVenta(matricula);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public void EditarVentas()
        {
            try
            {
                DataSet venta = cadVentasRealizadas.ObtenerDatosVehiculo(matricula);

                venta.Tables["Ventas"].Rows[0][0] = matricula;
                venta.Tables["Ventas"].Rows[0][1] = marca;
                venta.Tables["Ventas"].Rows[0][2] = modelo;
                venta.Tables["Ventas"].Rows[0][3] = km;
                venta.Tables["Ventas"].Rows[0][4] = garantia;
                venta.Tables["Ventas"].Rows[0][5] = precioVenta;
                cadVentasRealizadas.EditarVehiculoVenta(venta);

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void AnyadirVenta()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVentasRealizadas.ObtenerTablaVentas();
                DataRow linea = resultado.Tables["Ventas"].NewRow();
                linea[0] = matricula;
                linea[1] = marca;
                linea[2] = modelo;
                linea[3] = km;
                linea[4] = garantia;
                linea[5] = precioVenta;
                resultado.Tables["Ventas"].Rows.Add(linea);
                cadVentasRealizadas.AnyadirVenta(resultado);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace EN
{
    public class ENVentas
    {
        private string fechaVenta;
        private string numVend;
        private string numCliente;
        private string numFactura;
        private string precioVenta;
        private string matricula;
        private string marca;
        private string modelo;
        private string km;
        private string garantia;

        private ArrayList listaMarcas = new ArrayList();
        private ArrayList listaModelos = new ArrayList();
        private ArrayList listaMatriculas = new ArrayList();

        private CAD.CADVentas cadVentas = new CAD.CADVentas();

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

        public string FechaVenta
        {
            get { return fechaVenta; }
            set { fechaVenta = FechaVenta; }
        }

        public string NumVend
        {
            get { return numVend; }
            set { numVend = NumVend; }
        }

        public string NumCliente
        {
            get { return numCliente; }
            set { numCliente = NumCliente; }
        }

        public string NumFactura
        {
            get { return numFactura; }
            set { numFactura = NumFactura; }
        }

        public string PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = PrecioVenta; }
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
            numVend = precioVenta = numCliente = numFactura = fechaVenta = "";
        }

        public DataSet ObtenerListaVentas(string todo)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVentas.ObtenerTablaVentas(todo);
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
                resultado = cadVentas.ObtenerMarcas();
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
                resultado = cadVentas.ObtenerModelos(marca);
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
                resultado = cadVentas.ObtenerMatricula(marca, modelo);
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
                resultado = cadVentas.ObtenerDatosVehiculo(matricula);

                matricula = resultado.Tables["Ventas"].Rows[0][0].ToString();
                marca = resultado.Tables["Ventas"].Rows[0][1].ToString();
                modelo = resultado.Tables["Ventas"].Rows[0][2].ToString();
                km = resultado.Tables["Ventas"].Rows[0][4].ToString();
                garantia = resultado.Tables["Ventas"].Rows[0][5].ToString();
                precioVenta = resultado.Tables["Ventas"].Rows[0][6].ToString();
                numVend = resultado.Tables["Ventas"].Rows[0][7].ToString();
                numCliente = resultado.Tables["Ventas"].Rows[0][8].ToString();
                numFactura = resultado.Tables["Ventas"].Rows[0][9].ToString();
                fechaVenta = resultado.Tables["Ventas"].Rows[0][10].ToString();
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
                cadVentas.BorrarVehiculoVenta(matricula);
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
                DataSet venta = cadVentas.ObtenerDatosVehiculo(matricula);
                venta.Tables["ventas"].Rows[0][6] = precioVenta.ToString();
                cadVentas.EditarVehiculoVenta (venta);

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void AnyadirVenta(string todo)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadVentas.ObtenerTablaVentas(todo);
                DataRow linea = resultado.Tables["Ventas"].NewRow();
                linea[0] = matricula;
                linea[1] = marca;
                linea[2] = modelo;
                linea[3] = km;
                linea[4] = garantia;
                linea[5] = precioVenta;
                linea[6] = numVend;
                linea[7] = numCliente;
                linea[8] = numFactura;
                linea[9] = fechaVenta;
                resultado.Tables["Ventas"].Rows.Add(linea);
                cadVentas.AnyadirVenta(resultado);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

    }
}

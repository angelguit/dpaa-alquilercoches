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
    public class ENPedidos
    {
        private string idtransaccion;
        private string proveedor;
        private string marca;
        private string modelo;
        private string cantidad;
        private string tipoenvio;
        private string observaciones;
        private string estadopedido;
        private string empleado;
        private string fecha;

        private CAD.CADPedidos cadPedidos = new CAD.CADPedidos();


        public string IDTransaccion
        {
            get { return idtransaccion; }
            set { idtransaccion = value; }
        }
        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
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
        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        public string EstadoPedido
        {
            get { return estadopedido; }
            set { estadopedido = value; }
        }
        public string Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string TipoEnvio
        {
            get { return tipoenvio; }
            set { tipoenvio = value; }
        }

  


        public DataSet ObtenerListaPedidos(string todo)
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadPedidos.ObtenerTablaPedidos(todo);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return resultado;
        }
        public void EliminarPedidos(ArrayList arraypedido)
        {
            try
            {
             //   cadPedidos.BorrarPedido(arraypedido);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }



  /*      public void EditarPedidos()
        {
            try
            {
                DataSet pedido =cadPedidos.ObtenerDatosPedidoIdTrans(idtransaccion);
                pedido.Tables["Pedidos"].Rows[0][1] = idtransaccion.ToString();
                pedido.Tables["Pedidos"].Rows[0][2] = proveedor.ToString()];
                pedido.Tables["Pedidos"].Rows[0][3] = marca.ToString();
                pedido.Tables["Pedidos"].Rows[0][4] = modelo.ToString();
                pedido.Tables["Pedidos"].Rows[0][5] = cantidad.ToString();
                pedido.Tables["Pedidos"].Rows[0][6] = tipoenvio.ToString();
                pedido.Tables["Pedidos"].Rows[0][7] = observaciones.ToString();
              pedido.Tables["Pedidos"].Rows[0][8] = estadopedido.ToString();
                pedido.Tables["Pedidos"].Rows[0][9] = empleado.ToString();
                pedido.Tables["Pedidos"].Rows[0][10]= fecha;
                cadPedidos.EditarPedidos(pedidos);
            }
            catch(Exception ex)
            {
                throw(ex);
            }

        } */

        public void AnyadirPedidos()
        {
            DataSet resultado = new DataSet();
            try
            {
                string frase = "";
                // si la frase esta vacia nos devolvera todos los resultados
                resultado = cadPedidos.ObtenerTablaPedidos(frase);
                DataRow linea = resultado.Tables["Pedidos"].NewRow();
                linea[0] = idtransaccion;              
                linea[1] = proveedor;
                linea[2] = marca;
                linea[3] = modelo;
                linea[4] = cantidad;
                linea[5] = observaciones;
                linea[6] = estadopedido;
                linea[7] = empleado;
                linea[8] = tipoenvio;
              //  linea[9] = fecha;
                resultado.Tables["Pedidos"].Rows.Add(linea);
                cadPedidos.AnyadirPedidos(resultado);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }






    }
}

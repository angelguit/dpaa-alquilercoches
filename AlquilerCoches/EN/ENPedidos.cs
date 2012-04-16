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
    public class ENPedidos
    {
        private string idtransaccion;
        private string proveedor;
        private string marca;
        private string modelo;
        private int cantidad;
        private string tipoenvio;
        private string observaciones;
        private string estadopedido;
        private string empleado;
        private DateTime fecha;

        private CAD.CADPedidos cadPedidos = new CAD.CADPedidos();

        public DataSet ObtenerListaPedidos()
        {
            DataSet resultado = new DataSet();
            try
            {
                resultado = cadPedidos.ObtenerTablaPedidos();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return resultado;
        }



        public string IDTransaccion
        {
            get { return idtransaccion; }
            set {  idtransaccion = value; }
        }
        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor =value; }
        }
        public string Marca
        {
            get { return marca; }
            set {  marca =value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set {  modelo = value; }
        }
        public int Cantidad
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
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string TipoEnvio
        {
            get { return tipoenvio; }
            set { tipoenvio = value; }
        }

        public void AnyadirPersonal()
        {
            DataSet resultado = new DataSet();
            try
            {
                string frase = ""; //si la frase que le pasamos esta vacia nos devolvera todos los resultados
                resultado = cadPedidos.ObtenerTablaPersonal(frase);
                DataRow linea = resultado.Tables["Pedidos"].NewRow();
                //linea[0] = ; para el recuadro eliminar
                //linea[1] = ; para el boton editar
                linea[0] = idtransaccion;
                linea[1] = proveedor;
                linea[2] = marca;
                linea[3] = modelo;
                linea[4] = cantidad;
                linea[5] = observaciones;
                linea[6] = estadopedido;
                linea[7] = fecha;
                linea[8] = tipoenvio;
                linea[9] = empleado;
                resultado.Tables["Pedidos"].Rows.Add(linea);
                cadPedidos.AnyadirPersonal(resultado);
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
                DataSet pedido = cadPedidos.ObtenerDatosPedidosConDni(dni);
                pedido.Tables["Pedidos"].Rows[0][1] = nombre.ToString(); //el dni no se puede cambiar asique saltamos la posicion 0 que es del dni
                pedido.Tables["Pedidos"].Rows[0][2] = apellidos.ToString();
                pedido.Tables["Pedidos"].Rows[0][3] = telefono.ToString();
                pedido.Tables["Pedidos"].Rows[0][4] = email.ToString();
                pedido.Tables["Pedidos"].Rows[0][5] = direccion.ToString();
                pedido.Tables["Pedidos"].Rows[0][6] = ciudad.ToString();
                pedido.Tables["Pedidos"].Rows[0][7] = provincia.ToString();
                pedido.Tables["Pedidos"].Rows[0][8] = puestoac.ToString();
                pedido.Tables["Pedidos"].Rows[0][9] = otrospuestos.ToString();
                cadPedido.EditarPedido(pedido);

            }
            catch (Exception ex)
            {
                throw (ex);
            }
    }
}

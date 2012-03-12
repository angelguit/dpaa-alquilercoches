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


        public string IDTransaccion
        {
            get { return idtransaccion; }
            set {  idtransaccion = IDTransaccion; }
        }
        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor = Proveedor; }
        }
        public string Marca
        {
            get { return marca; }
            set {  marca = Marca; }
        }
        public string Modelo
        {
            get { return modelo; }
            set {  modelo = Modelo; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = Cantidad; }
        }
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = Observaciones; }
        }
        public string EstadoPedido
        {
            get { return estadopedido }
            set { estadopedido = EstadoPedido; }
        }
        public string Empleado
        {
            get { return empleado; }
            set { empleado = Empleado; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = Fecha; }
        }
        public string TipoEnvio
        {
            get { return tipoenvio; }
            set { tipoenvio = TipoEnvio; }
        }
    }
}

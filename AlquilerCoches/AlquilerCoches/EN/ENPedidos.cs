using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlquilerCoches.EN
{
    public class ENPedidos
    {
        private string idtransaccion;
        private string proveedor;
        private string marca;
        private string modelo;
        private int cantidad;
        private string tipoEnvio;
        private string observaciones;
        private string estadoPedido;
        private string empleado;
        private DateTime fecha;
    }

    public string IDTransaccion
    {
           get { return idtransaccion; }
           set { return idtransaccion=IDTransaccion; }
    }
    public string Proveedor
    {
           get { return proveedor; }
           set { return proveedor=Proveedor; }
    }
    public string Marca
    {
           get { return marca; }
           set { return marca=Marca; }
    }
    public string Modelo
    {
           get { return modelo; }
           set { return modelo=Modelo; }
    }
    public int Cantidad
    {
           get { return cantidad; }
           set { return cantidad=Cantidad; }
    }
    public string Observaciones
    {
           get { return observaciones; }
           set { return observaciones=observaciones; }
    }
    public string EstadoPedido
    {
           get { return estadopedido }
           set { return estadopedido=EstadoPedido; }
    }
    public string Empleado
    {
           get { return empleado; }
           set { return empleado=Empleado; }
    }
    public DateTime Fecha
    {
           get { return fecha; }
           set { return fecha=Fecha; }
    }
    public string TipoEnvio
    {
           get { return tipoenvio; }
           set { return tipoenvio=TipoEnvio; }
    }

}

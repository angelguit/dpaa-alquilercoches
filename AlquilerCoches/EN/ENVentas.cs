using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlquilerCoches.EN
{
    public class ENVentas
    {
        private DateTime fechaVenta;
        private string numVend;
        private string numCliente;
        private string numFactura;
        private int precioVenta;

        public DateTime FechaVenta
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

        public int PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = PrecioVenta; }
        }
    }
}

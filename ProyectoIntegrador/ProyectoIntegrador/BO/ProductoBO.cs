using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.BO
{
    class ProductoBO
    {
        private int idProducto;
        private string nombreProducto;
        private double precioCompra;
        private double precioVenta;
        private double stockProducto;
        private string ubicacion;

        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

        public string NombreProducto
        {
            get
            {
                return nombreProducto;
            }

            set
            {
                nombreProducto = value;
            }
        }

        public double PrecioCompra
        {
            get
            {
                return precioCompra;
            }

            set
            {
                precioCompra = value;
            }
        }

        public double PrecioVenta
        {
            get
            {
                return precioVenta;
            }

            set
            {
                precioVenta = value;
            }
        }

        public double StockProducto
        {
            get
            {
                return stockProducto;
            }

            set
            {
                stockProducto = value;
            }
        }

        public string Ubicacion
        {
            get
            {
                return ubicacion;
            }

            set
            {
                ubicacion = value;
            }
        }
    }
}

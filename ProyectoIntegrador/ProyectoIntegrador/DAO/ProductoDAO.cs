using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.BO;
using System.Data;

namespace ProyectoIntegrador.DAO
{
    class ProductoDAO : ConexionDAO
    {

        public int GuardarDatos(ProductoBO Producto)
        {
            instruccion = "Insert into producto(nomb_prod, precio_vent, precio_comp, stock_prod, ubicacion) values('" + Producto.NombreProducto + "','" + Producto.PrecioCompra + "','" + Producto.PrecioVenta + "','" + Producto.StockProducto + "','" + Producto.Ubicacion + "')";
            return EjecutarInstruccion();
        }

        public int ActualizarDatos(ProductoBO Producto)
        {
            instruccion = "Update producto set nomb_prod='" + Producto.NombreProducto +"', precio_vent='"+ Producto.PrecioVenta +"', precio_comp='"+ Producto.PrecioCompra +"', stock_prod='" + Producto.StockProducto + "', ubicacion='"+ Producto.Ubicacion + "' where id_prod='" + Producto.IdProducto + "'";
            return EjecutarInstruccion();
        }
        
        public int EliminarDatos(ProductoBO Producto)
        {
            instruccion = "Delete from producto where id_prod = '" + Producto.IdProducto + "'";
            return EjecutarInstruccion();
        }

        public DataTable VistaProducto()
        {
            instruccion = "select * from producto";
            DataTable TablaProducto = EjecutarVista();
            TablaProducto.Columns[0].ColumnName = "Id";
            TablaProducto.Columns[1].ColumnName = "Nombre";
            TablaProducto.Columns[2].ColumnName = "Precio Venta";
            TablaProducto.Columns[3].ColumnName = "Precio compra";
            TablaProducto.Columns[4].ColumnName = "stock";
            TablaProducto.Columns[5].ColumnName = "Ubicacion";
            return TablaProducto;
        }

    }
}

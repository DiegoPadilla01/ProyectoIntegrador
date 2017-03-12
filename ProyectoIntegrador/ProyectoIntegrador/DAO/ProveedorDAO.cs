using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using ProyectoIntegrador.BO;

namespace ProyectoIntegrador.DAO
{
    class ProveedorDAO:ConexionDAO
    {
        ConexionDAO conexion = new ConexionDAO();
        MySqlCommand ejecutar = new MySqlCommand();

        string instruccion;

        public int BuscarProveedor(ProveedorBO Proveedor)
        {
            ProveedorBO dato = (ProveedorBO)Proveedor;
            ejecutar.Connection = ConectarDB();
            AbrirConexion();
  //          ejecutar.CommandText = "SELECT count(*) from usuarios where nombre_usuario='" + dato.NombreUsuario + "' and pass_usuario ='" + dato.ContraseñaUsuario + "'";
            int acuse = int.Parse(ejecutar.ExecuteScalar().ToString());
            CerrarConexion();
            return acuse;
        }

        public int GuardarDatos(ProveedorBO Proveedor)
        {
            ProveedorBO dato = (ProveedorBO)Proveedor;
            instruccion = "insert into proveedores(id_prov, rfc_prov, nombre_prov, telefono_prov, calle_dir, num_dir, cruzamientos_dir, colonia_dir, cp_dir) values('" + dato.IdProveedor + "', '" + dato.RfcProveedor + "','" + dato.NombreProveedor + "','" + dato.TelefonoProveedor +"','"+dato.CalleDireccionProveedor + "','" + dato.NumeroDireccionProveedor + "','" + dato.CruzamientosDirecccionProveedor+"','" + dato.ColoniaDireccionProveedor +"','"+ dato.CpDireccionProveedor + "')";
            return EjecutarInstruccion();
        }

        public int ActualizarDatos(ProveedorBO Proveedor)
        {
            ProveedorBO dato = Proveedor;
            instruccion = "update proveedores set nombre_prov ='" + dato.NombreProveedor + "', rfc_prov='" + dato.RfcProveedor + "', telefono_prov ='"+  dato.TelefonoProveedor  + "', calle_dir='"+ dato.CalleDireccionProveedor +"', num_dir='"+ dato.NumeroDireccionProveedor + "', cruzamientos_dir='" + dato.CruzamientosDirecccionProveedor +"', colonia_dir='"+ dato.ColoniaDireccionProveedor+ "', cp_dir ='" + dato.CpDireccionProveedor + "' where id_prov='" + dato.IdProveedor + "'";
            return EjecutarInstruccion();
        }

        public int EliminarDatos(ProveedorBO Proveedor)
        {
            ProveedorBO dato = Proveedor;
            instruccion = "Delete from proveedores where id_prov='" + dato.IdProveedor + "'";
            return EjecutarInstruccion();
        }


        public DataTable Vista()
        {
            instruccion = "Select * from proveedores";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, ConectarDB());
            DataTable TablaConsulta = new DataTable();
            adp.Fill(TablaConsulta);
            TablaConsulta.Columns[0].ColumnName = "Id provedor";
            TablaConsulta.Columns[1].ColumnName = "RFC";
            TablaConsulta.Columns[2].ColumnName = "Nombre";
            TablaConsulta.Columns[3].ColumnName = "Telefono";
            TablaConsulta.Columns[4].ColumnName = "Calle";
            TablaConsulta.Columns[5].ColumnName = "Numero";
            TablaConsulta.Columns[6].ColumnName = "Cruzamientos";
            TablaConsulta.Columns[7].ColumnName = "Colonia";
            TablaConsulta.Columns[8].ColumnName = "CP";

            return TablaConsulta;
        }
    }
}

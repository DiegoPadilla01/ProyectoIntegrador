using MySql.Data.MySqlClient;
using ProyectoIntegrador.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.DAO
{
    class CiudadDAO
    {
        ConexionDAO conexion = new ConexionDAO();
        MySqlCommand ejecutar = new MySqlCommand();

        string instruccion;

        public int GuardarDatos(CiudadBO Ciudad)
        {
            CiudadBO dato = (CiudadBO)Ciudad;
            instruccion = "insertar into ciudad (id_ciudad,nombre_ciudad,id_estado)values ('" + dato.Id_ciudad + "','" + dato.Nombre_ciudad + "','" + dato.Id_estado + "')";
            return EjecutarInstruccion();
        }
        public int ActualizarDatos(CiudadBO Ciudad)
        {
            CiudadBO dato = (CiudadBO)Ciudad;
            instruccion = "update ciudad set nombre_ciudad ='" + dato.Nombre_ciudad + "',id_estado= '" + dato.Id_estado + "'";
            return EjecutarInstruccion();
        }
        public int EliminarDatos(CiudadBO Ciudad)
        {
            CiudadBO dato = (CiudadBO)Ciudad;
            instruccion = "Delete from ciudad where id_ciudad = '" + dato.Id_ciudad + "'";
            return EjecutarInstruccion();
        }
        public DataTable Vista()
        {
            instruccion = "Select from * ciudad";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion.ConectarDB());
            DataTable TablaConsulta = new DataTable();
            adp.Fill(TablaConsulta);
            TablaConsulta.Columns[0].ColumnName = "Clave";
            TablaConsulta.Columns[1].ColumnName = "Ciudad";
            TablaConsulta.Columns[2].ColumnName = "Estado";
            return TablaConsulta;
        }
        public int EjecutarInstruccion()
        {
            ejecutar.Connection = conexion.ConectarDB();
            conexion.AbrirConexion();
            ejecutar.CommandText = instruccion;
            int acuse = ejecutar.ExecuteNonQuery();
            conexion.CerrarConexion();
            if (acuse <= 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}

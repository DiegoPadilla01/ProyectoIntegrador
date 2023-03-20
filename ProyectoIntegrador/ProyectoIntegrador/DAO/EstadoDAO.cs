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
    class EstadoDAO
    {
        ConexionDAO conexion = new ConexionDAO();
        MySqlCommand ejecutar = new MySqlCommand();

        string instruccion;

        public int GuardarDatos(EstadoBO Estado)
        {
            EstadoBO dato = (EstadoBO)Estado;
            instruccion = "insert into  estado(id_estado,nombre_estado,id_pais)values('" + dato.Id_estado + "','" + dato.Nombre_estado + "','" + dato.Id_pais + "') ";
            return EjecutarInstruccion();
        }
        public int ModificarDatos(EstadoBO Estado)
        {
            EstadoBO dato = (EstadoBO)Estado;
            instruccion = "update estado set nombre_estado ='" + dato.Nombre_estado + "',id_pais = '" + dato.Id_pais + "'";
            return EjecutarInstruccion();
        }
        public int EliminarDatos(EstadoBO Estado)
        {
            EstadoBO dato = (EstadoBO)Estado;
            instruccion = "Delete from estado where id_estado = '" + dato.Id_estado + "' ";
            return EjecutarInstruccion();
        }
        public DataTable Vista()
        {
            instruccion = "select from * estado";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion.ConectarDB());
            DataTable TablaConsulta = new DataTable();
            adp.Fill(TablaConsulta);
            TablaConsulta.Columns[0].ColumnName = "Clave";
            TablaConsulta.Columns[1].ColumnName = "Estado";
            TablaConsulta.Columns[2].ColumnName = "País";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProyectoIntegrador.DAO;
using ProyectoIntegrador.BO;
using System.Data;

namespace ProyectoIntegrador.DAO
{
    class UsuariosDAO:ConexionDAO
    {
        ConexionDAO conexion = new ConexionDAO();
        MySqlCommand ejecutar = new MySqlCommand();


        public int BuscarUsuario(UsuarioBO Usuario)
        {
            UsuarioBO dato = (UsuarioBO)Usuario;
            ejecutar.Connection = conexion.ConectarDB();
            conexion.AbrirConexion();
            ejecutar.CommandText = "SELECT count(*) from usuarios where nombre_usuario='" + dato.NombreUsuario + "' and pass_usuario ='" + dato.ContraseñaUsuario + "'";
            int acuse = int.Parse(ejecutar.ExecuteScalar().ToString());
            conexion.CerrarConexion();
            return acuse;
        }

        public int GuardarDatos(UsuarioBO Usuario)
        {
            UsuarioBO dato = (UsuarioBO)Usuario;
            instruccion = "insert into usuarios(nombre_usuario, pass_usuario, permisos_usuario) values('"+ dato.NombreUsuario +"', '"+dato.ContraseñaUsuario+"','" + dato.PermisoUsuario + "')";
            return EjecutarInstruccion();
        }

        public int ActualizarDatos(UsuarioBO Usuario)
        {
            UsuarioBO dato = Usuario;
            instruccion = "update usuarios set pass_usuario ='" + dato.ContraseñaUsuario + "', permisos_usuario='" +dato.PermisoUsuario+"' where nombre_usuario='"+ dato.NombreUsuario+"'";
            return EjecutarInstruccion();
        }

        public int EliminarDatos(UsuarioBO Usuario)
        {
            UsuarioBO dato = Usuario;
            instruccion = "Delete from usuarios where nombre_usuario='"+ dato.NombreUsuario +"'";
            return EjecutarInstruccion();
        }


        public DataTable Vista()
        {
            instruccion = "Select * from usuarios";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion.ConectarDB());
            DataTable TablaConsulta = new DataTable();
            adp.Fill(TablaConsulta);
            TablaConsulta.Columns[0].ColumnName = "Nombre de usuario";
            TablaConsulta.Columns[1].ColumnName = "Contraseña";
            TablaConsulta.Columns[2].ColumnName = "Permisos";
            return TablaConsulta;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.DAO;

namespace ProyectoIntegrador.BO
{
    class UsuarioBO
    {
        CuentaDAO ConexUsuarios = new CuentaDAO();

        private string nombreUsuario;
        private string contraseñaUsuario;
        private string permisoUsuario;

        private int usuarioExistente;

        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }

        public string ContraseñaUsuario
        {
            get
            {
                return contraseñaUsuario;
            }

            set
            {
                contraseñaUsuario = value;
            }
        }

        public string PermisoUsuario
        {
            get
            {
                return permisoUsuario;
            }

            set
            {
                permisoUsuario = value;
            }
        }

        public bool Login()
        {
            usuarioExistente = ConexUsuarios.BuscarUsuario(this);

            if (usuarioExistente == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

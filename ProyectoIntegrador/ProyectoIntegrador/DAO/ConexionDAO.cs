using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrador.DAO
{
    class ConexionDAO
    {
        MySqlConnection conex;
        string cad_conexion;

        public MySqlConnection ConectarDB()
        {
            cad_conexion = "server=localhost; database=abarrotesprueba; uid=root; pwd=1234;";
            conex = new MySqlConnection(cad_conexion);
            return conex;
        }

        public void AbrirConexion()
        {
            conex.Open();
        }

        public void CerrarConexion()
        {
            conex.Close();
        }
    }
}

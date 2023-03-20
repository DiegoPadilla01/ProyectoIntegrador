using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace ProyectoIntegrador.DAO
{
   public class ConexionDAO
    {
        MySqlConnection conex;
        MySqlCommand cmd = new MySqlCommand();

        string cad_conexion;
        protected string instruccion;

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

        public int EjecutarInstruccion()
        {
            cmd.Connection = ConectarDB();
            AbrirConexion();
            cmd.CommandText = instruccion;
            int acuse = cmd.ExecuteNonQuery();
            CerrarConexion();
            if (acuse <= 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        protected DataTable EjecutarVista()
        {
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, ConectarDB());
            DataTable TablaConsulta = new DataTable();
            adp.Fill(TablaConsulta);
            return TablaConsulta;
        }
    }
}

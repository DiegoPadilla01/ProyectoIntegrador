using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace ProyectoIntegrador.DAO
{
    class ConexionDAO
    {
        MySqlConnection conex;
        MySqlCommand cmd = new MySqlCommand();

        string cad_conexion;
        protected string instruccion;

        protected MySqlConnection ConectarDB()
        {
            cad_conexion = "server=104.198.222.114; database=tiendaAbarrotes; uid=root; pwd=12345;";
            conex = new MySqlConnection(cad_conexion);
            return conex;
        }

        protected void AbrirConexion()
        {
            conex.Open();
        }

        protected void CerrarConexion()
        {
            conex.Close();
        }

        protected int EjecutarInstruccion()
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

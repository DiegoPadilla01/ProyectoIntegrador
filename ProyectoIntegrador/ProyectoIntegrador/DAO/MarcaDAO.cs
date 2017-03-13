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
    class MarcaDAO
    {
        ConexionDAO conexion = new ConexionDAO();
        MySqlCommand ejecutar = new MySqlCommand();

        string instruccion;

        public int GuardarDatos(MarcaBO Marca)
        {
            MarcaBO dato = (MarcaBO)Marca;
            instruccion = "insert into marca (id_mar,nomb_mar)values ('" + dato.Id_mar + "','" + dato.Nomb_mar + "')";
            return EjecutarInstruccion();
        }
        public int ModificarDatos(MarcaBO Marca)
        {
            MarcaBO dato = (MarcaBO)Marca;
            instruccion = " update marca set nomb_mar = '" + dato.Nomb_mar + "'";
            return EjecutarInstruccion();
        }
        public int EliminarDatos(MarcaBO Marca)
        {
            MarcaBO dato = (MarcaBO)Marca;
            instruccion = "Delete from  marca where id_mar = '" + dato.Id_mar + "'";
            return EjecutarInstruccion();
        }
        public DataTable Vista()
        {
            instruccion = "select from * marca";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion,conexion.ConectarDB());
            DataTable TablaConsulta = new DataTable();
            adp.Fill(TablaConsulta);
            TablaConsulta.Columns[0].ColumnName = "Clave";
            TablaConsulta.Columns[1].ColumnName = "Marca";
            return TablaConsulta;
        }
        public int EjecutarInstruccion()
        {
            ejecutar.Connection = conexion.ConectarDB();
            conexion.AbrirConexion();
            ejecutar.CommandText = instruccion;
            int acuse = ejecutar.ExecuteNonQuery();
            conexion.CerrarConexion();
            if(acuse <=0)
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

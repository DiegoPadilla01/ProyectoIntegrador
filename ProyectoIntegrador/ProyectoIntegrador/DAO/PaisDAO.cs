using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.BO;
using System.Data;

namespace ProyectoIntegrador.DAO
{
    class PaisDAO:ConexionDAO
    {
        public int GuardarDatos(PaisBO Pais)
        {
            instruccion = "Insert into pais(nombre_pais) values('"+ Pais.NombrePais +"')";
            return EjecutarInstruccion();
        }

        public int EliminarDatos(PaisBO Pais)
        {
            instruccion = "Delete from pais where id_pais='" + Pais.IdPais +"'";
            return EjecutarInstruccion();
        }

        public int ActualizarDatos(PaisBO Pais)
        {
            instruccion = "Update pais set nombre_pais='" + Pais.NombrePais + "' where id_pais='" + Pais.IdPais + "'";
            return EjecutarInstruccion();
        }
        public DataTable VistaPais()
        {
            instruccion = "Select * from pais";
            return EjecutarVista();
        }
    }
}

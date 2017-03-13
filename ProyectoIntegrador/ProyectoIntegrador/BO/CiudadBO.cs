using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.BO
{
    class CiudadBO
    {
        private int id_ciudad;
        private string nombre_ciudad;
        private int id_estado;

        public int Id_ciudad
        {
            get
            {
                return id_ciudad;
            }

            set
            {
                id_ciudad = value;
            }
        }

        public string Nombre_ciudad
        {
            get
            {
                return nombre_ciudad;
            }

            set
            {
                nombre_ciudad = value;
            }
        }

        public int Id_estado
        {
            get
            {
                return id_estado;
            }

            set
            {
                id_estado = value;
            }
        }
    }
}

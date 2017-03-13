using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.BO
{
    class EstadoBO
    {
        private int id_estado;
        private string nombre_estado;
        private int id_pais;

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

        public string Nombre_estado
        {
            get
            {
                return nombre_estado;
            }

            set
            {
                nombre_estado = value;
            }
        }

        public int Id_pais
        {
            get
            {
                return id_pais;
            }

            set
            {
                id_pais = value;
            }
        }
    }
}

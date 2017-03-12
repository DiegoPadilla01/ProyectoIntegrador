using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.BO
{
    class PaisBO
    {
        private int idPais;
        private string nombrePais;

        public int IdPais
        {
            get
            {
                return idPais;
            }

            set
            {
                idPais = value;
            }
        }

        public string NombrePais
        {
            get
            {
                return nombrePais;
            }

            set
            {
                nombrePais = value;
            }
        }
    }
}

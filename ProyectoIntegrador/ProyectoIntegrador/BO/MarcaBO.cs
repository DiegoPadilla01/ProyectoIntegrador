using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.BO
{
    class MarcaBO
    {
        private int id_mar;
        private string nomb_mar;

        public int Id_mar
        {
            get
            {
                return id_mar;
            }

            set
            {
                id_mar = value;
            }
        }

        public string Nomb_mar
        {
            get
            {
                return nomb_mar;
            }

            set
            {
                nomb_mar = value;
            }
        }
    }
}

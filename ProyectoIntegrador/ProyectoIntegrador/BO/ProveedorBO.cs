using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.BO
{
    class ProveedorBO
    {
        private int idProveedor;
        private string rfcProveedor;
        private string nombreProveedor;
        private string telefonoProveedor;
        private string calleDireccionProveedor;
        private string numeroDireccionProveedor;
        private string cruzamientosDirecccionProveedor;
        private string coloniaDireccionProveedor;
        private string cpDireccionProveedor;

        public int IdProveedor
        {
            get
            {
                return idProveedor;
            }

            set
            {
                idProveedor = value;
            }
        }

        public string RfcProveedor
        {
            get
            {
                return rfcProveedor;
            }

            set
            {
                rfcProveedor = value;
            }
        }

        public string NombreProveedor
        {
            get
            {
                return nombreProveedor;
            }

            set
            {
                nombreProveedor = value;
            }
        }

        public string TelefonoProveedor
        {
            get
            {
                return telefonoProveedor;
            }

            set
            {
                telefonoProveedor = value;
            }
        }

        public string CalleDireccionProveedor
        {
            get
            {
                return calleDireccionProveedor;
            }

            set
            {
                calleDireccionProveedor = value;
            }
        }

        public string NumeroDireccionProveedor
        {
            get
            {
                return numeroDireccionProveedor;
            }

            set
            {
                numeroDireccionProveedor = value;
            }
        }

        public string CruzamientosDirecccionProveedor
        {
            get
            {
                return cruzamientosDirecccionProveedor;
            }

            set
            {
                cruzamientosDirecccionProveedor = value;
            }
        }

        public string ColoniaDireccionProveedor
        {
            get
            {
                return coloniaDireccionProveedor;
            }

            set
            {
                coloniaDireccionProveedor = value;
            }
        }

        public string CpDireccionProveedor
        {
            get
            {
                return cpDireccionProveedor;
            }

            set
            {
                cpDireccionProveedor = value;
            }
        }
    }
}

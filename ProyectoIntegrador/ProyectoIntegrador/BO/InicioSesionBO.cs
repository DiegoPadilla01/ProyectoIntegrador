
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.BO
{
    class InicioSesionBO
    {
        private string userName;
        private string password;

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public bool Login()
        {
            if(userName == "Pat" && password =="123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

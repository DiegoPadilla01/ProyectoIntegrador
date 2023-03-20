using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.GUI
{
    public class HerramientasGUI
    {
        private Form formAct;
        private Form formHijo;

        public Form FormAct
        {
            get
            {
                return formAct;
            }

            set
            {
                formAct = value;
            }
        }

        public Form FormHijo
        {
            get
            {
                return formHijo;
            }

            set
            {
                formHijo = value;
            }
        }

        public void CerrarForm()
        {
            if (MessageBox.Show("¿Desea cerrar la ventana?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                formAct.Hide();
            }
        }
        public void CerrarSistema()
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                formAct.Close();
            }
        }

    }
}

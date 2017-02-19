using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.GUI
{
    public partial class frm_MarcasGUI : Form
    {
        public bool activo = false;

        HerramientasGUI herramientas = new HerramientasGUI();

        public frm_MarcasGUI()
        {
            InitializeComponent();
        }

        private void frm_Marcas_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            herramientas.FormAct = this;
            activo = false;
            herramientas.CerrarForm();
        }
    }
}

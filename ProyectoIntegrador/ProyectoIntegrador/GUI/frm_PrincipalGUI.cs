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
    public partial class frm_PrincipalGUI : Form
    {
        private Color colorBase = Color.FromArgb(0, 150, 136);
        private bool mouseFuera;
        frm_ClienteGUI formClientes = new frm_ClienteGUI();

        public frm_PrincipalGUI()
        {
            InitializeComponent();
        }

        private void puntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void puntoDeVentaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
           // puntoDe   = Color.FromArgb(77, 182, 172);
        } 

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!formClientes.activo == true)
            {
                formClientes.MdiParent = this;
                formClientes.activo = true;
                formClientes.Show();
            }
        }

        private void frm_PrincipalGUI_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height;
        }
    }
}

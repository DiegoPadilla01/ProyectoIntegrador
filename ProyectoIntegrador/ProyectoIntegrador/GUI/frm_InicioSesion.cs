using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class frm_InicioSecionGUI : Form
    {
        private int px, py;
        private bool mover;
         
        public frm_InicioSecionGUI()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
             this.Close();
            }
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
        }

        private void pic_Titulo_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void pic_Titulo_MouseMove(object sender, MouseEventArgs e)
        {
            Mover();
        }

        private void pic_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            px = e.X;
            py = e.Y;
            mover = true;
        }

        private void lbl_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;

        }

        private void lbl_Titulo_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void lbl_Titulo_MouseMove(object sender, MouseEventArgs e)
        {
            Mover();
        }

        public void Mover()
        {
            if (mover)
            {
                this.Location = this.PointToScreen(new Point(MousePosition.X - this.Location.X - px, MousePosition.Y - this.Location.Y - py));
            }
        }

    }
}

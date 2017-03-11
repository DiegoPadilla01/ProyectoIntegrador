using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.GUI;
using ProyectoIntegrador.BO;

namespace ProyectoIntegrador
{
    public partial class frm_InicioSecionGUI : Form
    {
        HerramientasGUI Herramientas = new HerramientasGUI();
        UsuarioBO Login = new UsuarioBO(); 

        public frm_InicioSecionGUI()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Herramientas.FormAct = this;
            Herramientas.CerrarForm();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            Login.NombreUsuario = txt_Usuario.Text;
            Login.ContraseñaUsuario = txt_Contraseña.Text;
            if (Login.Login() == true)
            {
                MessageBox.Show("Bienvenido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }


        }


    }
}

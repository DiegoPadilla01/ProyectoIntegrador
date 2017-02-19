using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.Properties;

namespace ProyectoIntegrador.GUI
{
    public partial class frm_PrincipalGUI : Form
    {
        private bool menuActivo = false;
        HerramientasGUI herramientas = new HerramientasGUI();
        frm_ClienteGUI formClientes = new frm_ClienteGUI();


        public frm_PrincipalGUI()
        {
            frm_InicioSecionGUI login = new frm_InicioSecionGUI();
            login.ShowDialog();
            InitializeComponent();
        }

        private void frm_PrincipalGUI_Load(object sender, EventArgs e)
        {
            //login.MdiParent = this;

            pnl_Principal.Height = this.Height;
            pnl_Catalogos.Height = this.Height;
            btn_AbrirPunto.Cursor = Cursors.Default;
            btn_Catalogo.Cursor = Cursors.Default;
        }

        private void btn_AbrirPunto_MouseEnter(object sender, EventArgs e)
        {
            btn_AbrirPunto.Image = Resources.ic_shopping_cart_white_36dp;
        }

        private void btn_AbrirPunto_MouseLeave(object sender, EventArgs e)
        {
            btn_AbrirPunto.Image = Resources.ic_shopping_cart_black_48dp;
        }

        private void btn_Catalogo_MouseLeave(object sender, EventArgs e)
        {
            btn_Catalogo.Image = Resources.ic_library_books_black_36dp;
        }

        private void btn_Catalogo_MouseEnter(object sender, EventArgs e)
        {
            btn_Catalogo.Image = Resources.ic_library_books_white_36dp;
        }

        private void btn_Catalogo_Click(object sender, EventArgs e)
        {
            if (menuActivo == false)
            {
                pnl_Catalogos.Visible = true;
                menuActivo = true;
            }
            else
            {
                pnl_Catalogos.Visible = false;
                menuActivo = false;
            }
        }

        private void btn_CatalogoClientes_Click(object sender, EventArgs e)
        {
            if (!formClientes.activo == true)
            {
                formClientes.MdiParent = this;
                formClientes.activo = true;
                pnl_Catalogos.Visible = false;
                menuActivo = false;
                formClientes.Show();
                
            }
        }

        private void frm_PrincipalGUI_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void frm_PrincipalGUI_Click(object sender, EventArgs e)
        {
            if (menuActivo == false)
            {
                pnl_Catalogos.Visible = true;
                menuActivo = true;
            }
            else
            {
                pnl_Catalogos.Visible = false;
                menuActivo = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            herramientas.FormAct = this;
            herramientas.CerrarSistema();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            pnl_Catalogos.Visible = false;
            menuActivo = false;
        }
    }
}

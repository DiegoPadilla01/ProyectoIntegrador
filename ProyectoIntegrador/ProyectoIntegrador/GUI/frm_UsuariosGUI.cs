using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.BO;
using ProyectoIntegrador.DAO;

namespace ProyectoIntegrador.GUI
{
    public partial class frm_UsuariosGUI : Form
    {
        public bool activo = false;
        HerramientasGUI Herramientas = new HerramientasGUI();

        UsuarioBO objUser = new UsuarioBO();
        CuentaDAO DB = new CuentaDAO();

        public frm_UsuariosGUI()
        {
            InitializeComponent();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            objUser.NombreUsuario = txt_NomUsuario.Text;
            objUser.ContraseñaUsuario = txt_Contraseña.Text;
            objUser.PermisoUsuario = cmb_Permiso.Text;

            if (DB.ActualizarDatos(objUser) == 1)
            {
                MessageBox.Show("Datos actualizados correctamente");
                ActualizarDataGrid();

            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Herramientas.FormAct = this;
            activo = false;
            Herramientas.CerrarForm();
        }

        private void grb_DatosPersonales_Enter(object sender, EventArgs e)
        {

        }

        private void frm_UsuariosGUI_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            SeleccionarFila();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_Contraseña.Clear();
            txt_Contraseña.Enabled = true;
            txt_NomUsuario.Enabled = true;
            txt_NomUsuario.Clear();
            cmb_Permiso.Text = "Seleccione...";
            cmb_Permiso.Enabled = true;
            btn_Nuevo.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Modificar.Enabled = false;
            btn_Eliminar.Enabled = false;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            
            objUser.NombreUsuario = txt_NomUsuario.Text;
            objUser.ContraseñaUsuario = txt_Contraseña.Text;
            objUser.PermisoUsuario = cmb_Permiso.Text;

            if(cmb_Permiso.Text == "Seleccione...")
            {
                MessageBox.Show("Seleccione una opcion");
            }
            else
            {
                if(DB.BuscarUsuario(objUser) == 1)
                {
                    MessageBox.Show("Nombre de usuario ya registrado escriba otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(DB.GuardarDatos(objUser) == 1)
                {
                    MessageBox.Show("Datos guardados en la base de datos");

                    txt_Contraseña.Enabled = true;
                    txt_NomUsuario.Enabled = false;
                    btn_Nuevo.Enabled = true;
                    btn_Guardar.Enabled = false;
                    btn_Modificar.Enabled = true;
                    btn_Eliminar.Enabled = true;
                    ActualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        public void ActualizarDataGrid()
        {
            dgt_Usuarios.DataSource = DB.Vista();
            SeleccionarFila();
        }
        public void SeleccionarFila()
        {
            if(dgt_Usuarios.RowCount > 0  && dgt_Usuarios.CurrentRow != null)
            {
                txt_Contraseña.Text = dgt_Usuarios.CurrentRow.Cells[1].Value.ToString();
                txt_NomUsuario.Text = dgt_Usuarios.CurrentRow.Cells[0].Value.ToString();
                cmb_Permiso.Text = dgt_Usuarios.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                btn_Eliminar.Enabled = false;
            }

        }
        private void dgt_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarFila();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            objUser.NombreUsuario = txt_NomUsuario.Text;

            if(MessageBox.Show("¿Seguro que desea eliminar al usuario:" + txt_NomUsuario.Text + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(DB.EliminarDatos(objUser) == 1)
                {
                    MessageBox.Show("Usuario Eliminado");
                    ActualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
        }
    }
}

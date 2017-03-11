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
    public partial class frm_ProveedoresGUI : Form
    {
        public bool activo = false;
        HerramientasGUI Herramientas = new HerramientasGUI();

        ProveedorBO objProveedor = new ProveedorBO();
        ProveedoresDAO DB = new ProveedoresDAO();

        public frm_ProveedoresGUI()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Herramientas.FormAct = this;
            activo = false;
            Herramientas.CerrarForm();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            btn_Nuevo.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Modificar.Enabled = false;
            btn_Eliminar.Enabled = false;
            txt_ID.Enabled = true;
            txt_Calle.Clear();
            txt_Colonia.Clear();
            txt_Cruzamientos.Clear();
            txt_ID.Clear();
            txt_Nombre.Clear();
            txt_Num.Clear();
            txt_RFC.Clear();
            msk_Telefono.Clear();
            txt_CodPostal.Clear();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            AsignarValores();

            if (txt_ID.Text != "" && txt_RFC.Text != "" && txt_Nombre.Text != "")
            {
                if (DB.GuardarDatos(objProveedor) == 1)
                {
                    MessageBox.Show("Datos Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    btn_Nuevo.Enabled = true;
                    btn_Guardar.Enabled = false;
                    btn_Modificar.Enabled = true;
                    btn_Eliminar.Enabled = true;
                    txt_ID.Enabled = false;

                    ActualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
        }

        private void frm_ProveedoresGUI_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dtg_Proveedores.DataSource = DB.Vista();
            SeleccionarFila();
        }

        public void SeleccionarFila()
        {
            if (dtg_Proveedores.RowCount > 0 && dtg_Proveedores.CurrentRow != null)
            {
                txt_ID.Text = dtg_Proveedores.CurrentRow.Cells[0].Value.ToString();
                txt_RFC.Text = dtg_Proveedores.CurrentRow.Cells[1].Value.ToString();
                txt_Nombre.Text = dtg_Proveedores.CurrentRow.Cells[2].Value.ToString();
                msk_Telefono.Text = dtg_Proveedores.CurrentRow.Cells[3].Value.ToString();
                txt_Calle.Text = dtg_Proveedores.CurrentRow.Cells[4].Value.ToString();
                txt_Num.Text = dtg_Proveedores.CurrentRow.Cells[5].Value.ToString();
                txt_Cruzamientos.Text = dtg_Proveedores.CurrentRow.Cells[6].Value.ToString();
                txt_Colonia.Text = dtg_Proveedores.CurrentRow.Cells[7].Value.ToString();
                txt_CodPostal.Text = dtg_Proveedores.CurrentRow.Cells[8].Value.ToString();

            }
            else
            {
                btn_Eliminar.Enabled = false;
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            AsignarValores();
            if(DB.ActualizarDatos(objProveedor) == 1)
            {
                MessageBox.Show("Datos actualizdos","Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AsignarValores()
        {
            objProveedor.IdProveedor = int.Parse(txt_ID.Text);
            objProveedor.NombreProveedor = txt_Nombre.Text;
            objProveedor.RfcProveedor = txt_RFC.Text;
            objProveedor.TelefonoProveedor = msk_Telefono.Text;
            objProveedor.CalleDireccionProveedor = txt_Calle.Text;
            objProveedor.NumeroDireccionProveedor = txt_Num.Text;
            objProveedor.CruzamientosDirecccionProveedor = txt_Cruzamientos.Text;
            objProveedor.ColoniaDireccionProveedor = txt_Colonia.Text;
            objProveedor.CpDireccionProveedor = txt_CodPostal.Text;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            objProveedor.IdProveedor = int.Parse(txt_ID.Text);
            if (DB.EliminarDatos(objProveedor) == 1)
            {
                MessageBox.Show("Datos eliminados");
                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
        }
    }
}

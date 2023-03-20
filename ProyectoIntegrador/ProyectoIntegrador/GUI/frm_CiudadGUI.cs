using ProyectoIntegrador.BO;
using ProyectoIntegrador.DAO;
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
    public partial class frm_CiudadGUI : Form
    {
        public bool activo = false;

        HerramientasGUI herramientas = new HerramientasGUI();

        CiudadBO ObjCiudad = new CiudadBO();
        CiudadDAO BD = new CiudadDAO();
        public frm_CiudadGUI()
        {
            InitializeComponent();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            herramientas.FormAct = this;
            activo = false;
            herramientas.CerrarForm();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            btn_Agregar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = true;
            txt_IdCiud.Enabled = true;
            txt_IdCiud.Clear();
            txt_NomCiud.Clear();
            txt_IdEstado.Clear();
        }
        private void ActualizarDataGrid()
        {
            dgt_Ciudad.DataSource = BD.Vista();
            SeleccionarFila();
        }
        public void SeleccionarFila()
        {
            if (dgt_Ciudad.RowCount > 0 && dgt_Ciudad.CurrentRow != null)
            {
                txt_IdCiud.Text = dgt_Ciudad.CurrentRow.Cells[0].Value.ToString();
                txt_NomCiud.Text = dgt_Ciudad.CurrentRow.Cells[1].Value.ToString();
                txt_IdEstado.Text = dgt_Ciudad.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                btn_Eliminar.Enabled = false;
            }
        }
        public void AsignarValores()
        {
            ObjCiudad.Id_ciudad = int.Parse(txt_IdCiud.Text);
            ObjCiudad.Nombre_ciudad = txt_NomCiud.Text;
            ObjCiudad.Id_estado = int.Parse(txt_IdEstado.Text);
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            AsignarValores();
            if (BD.ActualizarDatos(ObjCiudad) == 1)
            {
                MessageBox.Show("Datos actualizdos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            ObjCiudad.Id_ciudad = int.Parse(txt_IdCiud.Text);
            if (BD.EliminarDatos(ObjCiudad) == 1)
            {
                MessageBox.Show("Datos eliminados");
                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Error al eliminar los Datos");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            AsignarValores();

            if (txt_IdCiud.Text != "" && txt_NomCiud.Text != "" && txt_IdEstado.Text != "")
            {
                if (BD.GuardarDatos(ObjCiudad) == 1)
                {
                    MessageBox.Show("Datos Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    btn_Agregar.Enabled = true;
                    btn_Guardar.Enabled = false;
                    btn_Modificar.Enabled = true;
                    btn_Eliminar.Enabled = true;
                    txt_IdCiud.Enabled = false;

                    ActualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

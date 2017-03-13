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
    public partial class frm_EstadoGUI : Form
    {
        public bool activo = false;

        HerramientasGUI herramientas = new HerramientasGUI();

        EstadoBO ObjEstado = new EstadoBO();
        EstadoDAO BD = new EstadoDAO();

        public frm_EstadoGUI()
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
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_Guardar.Enabled = true;
            txt_IdEstado.Enabled = true;
            txt_IdEstado.Clear();
            txt_Nomestado.Clear();
            txt_IdPais.Clear();
        }
        private void ActualizarDataGrid()
        {
            dgt_Estado.DataSource = BD.Vista();
            SeleccionarFila();
        }
        public void SeleccionarFila()
        {
            if (dgt_Estado.RowCount > 0 && dgt_Estado.CurrentRow != null)
            {
                txt_IdEstado.Text = dgt_Estado.CurrentRow.Cells[0].Value.ToString();
               
            }
            else
            {
                btn_Eliminar.Enabled = false;
            }
        }
        public void AsignarValores()
        {
            ObjEstado.Id_estado = int.Parse(txt_IdEstado.Text);
            ObjEstado.Nombre_estado = txt_Nomestado.Text;
            ObjEstado.Id_pais = int.Parse(txt_IdPais.Text);
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            AsignarValores();
            if (BD.ModificarDatos(ObjEstado) == 1)
            {
                MessageBox.Show("Datos actualizdos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            AsignarValores();

            if (txt_IdEstado.Text != "" && txt_Nomestado.Text != "" && txt_IdPais.Text != "")
            {
                if (BD.GuardarDatos(ObjEstado) == 1)
                {
                    MessageBox.Show("Datos Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    btn_Agregar.Enabled = true;
                    btn_Guardar.Enabled = false;
                    btn_Modificar.Enabled = true;
                    btn_Eliminar.Enabled = true;
                    txt_IdEstado.Enabled = false;

                    ActualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            ObjEstado.Id_estado = int.Parse(txt_IdEstado.Text);
            if (BD.EliminarDatos(ObjEstado) == 1)
            {
                MessageBox.Show("Datos eliminados");
                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Error al eliminar los Datos");
            }
        }
    }
}

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
    public partial class frm_MarcasGUI : Form
    {
        public bool activo = false;

        HerramientasGUI herramientas = new HerramientasGUI();
        MarcaBO Obj_Marca = new MarcaBO();
        MarcaDAO BD = new MarcaDAO();

        public frm_MarcasGUI()
        {
            InitializeComponent();
        }

        private void frm_Marcas_Load(object sender, EventArgs e)
        {
            ActualizarDataGrip();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            herramientas.FormAct = this;
            activo = false;
            herramientas.CerrarForm();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            btn_Agregar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_Guardar.Enabled = true;
            txt_IdMarca.Enabled = true;
            txt_NombreMarca.Clear();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            AsignarValores();
            if (txt_IdMarca.Text != "" && txt_NombreMarca.Text != "")
            {
                if(BD.GuardarDatos(Obj_Marca)==1)
                {
                    MessageBox.Show("Datos Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btn_Agregar.Enabled = true;
                    btn_Eliminar.Enabled = true;
                    btn_Modificar.Enabled = true;
                    btn_Guardar.Enabled = false;
                    txt_IdMarca.Enabled = false;

                    ActualizarDataGrip();
                }
                else
                {
                    MessageBox.Show("Error al  guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public void ActualizarDataGrip()
        {
            dgt_Marcas.DataSource = BD.Vista();
            SeleccionarFila();
        }
        public void SeleccionarFila()
        {
            if (dgt_Marcas.RowCount > 0 && dgt_Marcas.CurrentRow != null)
            {
                txt_IdMarca.Text = dgt_Marcas.CurrentRow.Cells[0].Value.ToString();
                txt_NombreMarca.Text = dgt_Marcas.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                btn_Eliminar.Enabled = false;
            }
        }
        public void AsignarValores()
        {
            Obj_Marca.Id_mar = int.Parse(txt_IdMarca.Text);
            Obj_Marca.Nomb_mar = txt_NombreMarca.Text;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            AsignarValores();
            if(BD.ModificarDatos(Obj_Marca)==1)
            {
                MessageBox.Show("Datos Actualizados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ActualizarDataGrip();
            }
            else
            {
                MessageBox.Show("Error al Actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Obj_Marca.Id_mar = int.Parse(txt_IdMarca.Text);
            if(BD.EliminarDatos(Obj_Marca)==1)
            {
                MessageBox.Show("Datos Eliminados");
                ActualizarDataGrip();
            }
            else
            {
                MessageBox.Show("Error al Eliminar Datos");
            }
        }
    }

}

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
    public partial class frm_PaisGUI : Form
    {
        PaisBO DatosPais = new PaisBO();
        PaisDAO BD = new PaisDAO();

        public frm_PaisGUI()
        {
            InitializeComponent();
        }

        private void frm_PaisGUI_Load(object sender, EventArgs e)
        {
            RefrescarVista();
            
        }

        private void RefrescarVista()
        {
            dgt_Vista.DataSource = BD.VistaPais();
            dgt_Vista.Font = new Font("Microsoft Sans Serif", 15);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_NombrePais.Text != "")
            {
                DatosPais.NombrePais = txt_NombrePais.Text;
                if (BD.GuardarDatos(DatosPais) == 1)
                {
                    MessageBox.Show("Datos Guardados");
                    RefrescarVista();
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos antes de continuar");
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (txt_IdPais.Text != "" && txt_NombrePais.Text != "")
            {
                DatosPais.IdPais = int.Parse(txt_IdPais.Text);
                DatosPais.NombrePais = txt_NombrePais.Text;
                if(BD.ActualizarDatos(DatosPais) == 1 )
                {
                    MessageBox.Show("Datos Actualizados");
                    RefrescarVista();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(txt_IdPais.Text != "")
            {
                DatosPais.IdPais = int.Parse(txt_IdPais.Text);
                if(BD.EliminarDatos(DatosPais) == 1)
                {
                    MessageBox.Show("Datos eliminados");
                    RefrescarVista();
                }
                else
                {
                    MessageBox.Show("Error eliminados");
                }
            }
        }

        private void dgt_Vista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IdPais.Text = dgt_Vista.CurrentRow.Cells[0].Value.ToString();
            txt_NombrePais.Text = dgt_Vista.CurrentRow.Cells[1].Value.ToString();
            

        }
    }
}

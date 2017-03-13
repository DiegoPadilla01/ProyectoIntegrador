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
    public partial class frm_ProductosGUI : Form
    {
        ProductoBO DatosProducto = new ProductoBO();
        ProductoDAO BD = new ProductoDAO();

        public bool activo = false;

        HerramientasGUI herramientas = new HerramientasGUI();

        public frm_ProductosGUI()
        {
            InitializeComponent();
        }

        private void frm_ProductosGUI_Load(object sender, EventArgs e)
        {
            RefrescarVista();
        }

        private void RefrescarVista()
        {
            dtg_Productos.DataSource = BD.VistaProducto();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            herramientas.FormAct = this;
            activo = false;
            herramientas.CerrarForm();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if(txt_Nombre.Text == "" && txt_PreCompra.Text == "" && txt_PreVenta.Text == "" && txt_Stock.Text=="" && txt_Ubicacion.Text =="")
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                DatosProducto.NombreProducto = txt_Nombre.Text;
                DatosProducto.PrecioCompra = double.Parse(txt_PreCompra.Text);
                DatosProducto.PrecioVenta = double.Parse(txt_PreVenta.Text);
                DatosProducto.StockProducto = double.Parse(txt_Stock.Text);
                DatosProducto.Ubicacion = txt_Ubicacion.Text;

                if(BD.GuardarDatos(DatosProducto) == 1)
                {
                    MessageBox.Show("Datos Guardados");
                    RefrescarVista();
                    txt_Nombre.Clear();
                    txt_Id.Clear();
                    txt_PreCompra.Clear();
                    txt_PreVenta.Clear();
                    txt_Stock.Clear();
                    txt_Ubicacion.Clear();
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void dtg_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dtg_Productos.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre.Text = dtg_Productos.CurrentRow.Cells[1].Value.ToString();
            txt_PreCompra.Text = dtg_Productos.CurrentRow.Cells[3].Value.ToString();
            txt_PreVenta.Text = dtg_Productos.CurrentRow.Cells[2].Value.ToString();
            txt_Stock.Text = dtg_Productos.CurrentRow.Cells[4].Value.ToString();
            txt_Ubicacion.Text = dtg_Productos.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(txt_Id.Text != "")
            {
                DatosProducto.IdProducto = int.Parse(txt_Id.Text);
                if(BD.EliminarDatos(DatosProducto) == 1)
                {
                    MessageBox.Show("Datos eliminados");
                    RefrescarVista();
                    txt_Nombre.Clear();
                    txt_Id.Clear();
                    txt_PreCompra.Clear();
                    txt_PreVenta.Clear();
                    txt_Stock.Clear();
                    txt_Ubicacion.Clear();
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
            else
            {
                MessageBox.Show("Seleccione el id del producto");
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "" && txt_PreCompra.Text == "" && txt_PreVenta.Text == "" && txt_Stock.Text == "" && txt_Ubicacion.Text == "")
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                DatosProducto.IdProducto = int.Parse(txt_Id.Text);
                DatosProducto.NombreProducto = txt_Nombre.Text;
                DatosProducto.PrecioCompra = double.Parse(txt_PreCompra.Text);
                DatosProducto.PrecioVenta = double.Parse(txt_PreVenta.Text);
                DatosProducto.StockProducto = double.Parse(txt_Stock.Text);
                DatosProducto.Ubicacion = txt_Ubicacion.Text;

                if (BD.ActualizarDatos(DatosProducto) == 1)
                {
                    MessageBox.Show("Datos actualizados");
                    RefrescarVista();
                    txt_Nombre.Clear();
                    txt_Id.Clear();
                    txt_PreCompra.Clear();
                    txt_PreVenta.Clear();
                    txt_Stock.Clear();
                    txt_Ubicacion.Clear();
                }
                else
                {
                    MessageBox.Show("Error al actulizar");
                }
            }
        }

        private void txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            DataTable Tabla = new DataTable();
            Tabla = BD.VistaProducto();
            string nombre = string.Concat("[", Tabla.Columns[1].ColumnName, "]");
            Tabla.DefaultView.Sort = nombre;
            DataView Vista = Tabla.DefaultView;
            Vista.RowFilter = string.Empty;
            if (txt_Filtro.Text != string.Empty)
            {
                Vista.RowFilter = nombre + "Like '%" + txt_Filtro.Text + "%'";
                dtg_Productos.DataSource = Vista;
            }
            else
            {
                dtg_Productos.DataSource = Tabla;
            }
        }
    }
}

namespace ProyectoIntegrador.GUI
{
    partial class frm_ProductosGUI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_Datos = new System.Windows.Forms.GroupBox();
            this.txt_Ubicacion = new System.Windows.Forms.TextBox();
            this.txt_PreVenta = new System.Windows.Forms.TextBox();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.txt_PreCompra = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Ubicacion = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Venta = new System.Windows.Forms.Label();
            this.lbl_Compra = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.dtg_Productos = new System.Windows.Forms.DataGridView();
            this.grb_Acciones = new System.Windows.Forms.GroupBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pic_Titulo = new System.Windows.Forms.PictureBox();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.grb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).BeginInit();
            this.grb_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Datos
            // 
            this.grb_Datos.Controls.Add(this.txt_Ubicacion);
            this.grb_Datos.Controls.Add(this.txt_PreVenta);
            this.grb_Datos.Controls.Add(this.txt_Stock);
            this.grb_Datos.Controls.Add(this.txt_PreCompra);
            this.grb_Datos.Controls.Add(this.txt_Nombre);
            this.grb_Datos.Controls.Add(this.txt_Id);
            this.grb_Datos.Controls.Add(this.lbl_Ubicacion);
            this.grb_Datos.Controls.Add(this.lbl_Stock);
            this.grb_Datos.Controls.Add(this.lbl_Venta);
            this.grb_Datos.Controls.Add(this.lbl_Compra);
            this.grb_Datos.Controls.Add(this.lbl_Nombre);
            this.grb_Datos.Controls.Add(this.lbl_Id);
            this.grb_Datos.Location = new System.Drawing.Point(12, 45);
            this.grb_Datos.Name = "grb_Datos";
            this.grb_Datos.Size = new System.Drawing.Size(399, 214);
            this.grb_Datos.TabIndex = 0;
            this.grb_Datos.TabStop = false;
            this.grb_Datos.Text = "Datos";
            // 
            // txt_Ubicacion
            // 
            this.txt_Ubicacion.Location = new System.Drawing.Point(154, 91);
            this.txt_Ubicacion.Name = "txt_Ubicacion";
            this.txt_Ubicacion.Size = new System.Drawing.Size(142, 20);
            this.txt_Ubicacion.TabIndex = 4;
            // 
            // txt_PreVenta
            // 
            this.txt_PreVenta.Location = new System.Drawing.Point(154, 139);
            this.txt_PreVenta.Name = "txt_PreVenta";
            this.txt_PreVenta.Size = new System.Drawing.Size(142, 20);
            this.txt_PreVenta.TabIndex = 6;
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(24, 88);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(100, 20);
            this.txt_Stock.TabIndex = 3;
            // 
            // txt_PreCompra
            // 
            this.txt_PreCompra.Location = new System.Drawing.Point(24, 136);
            this.txt_PreCompra.Name = "txt_PreCompra";
            this.txt_PreCompra.Size = new System.Drawing.Size(100, 20);
            this.txt_PreCompra.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(154, 39);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(142, 20);
            this.txt_Nombre.TabIndex = 2;
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(24, 39);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 1;
            // 
            // lbl_Ubicacion
            // 
            this.lbl_Ubicacion.AutoSize = true;
            this.lbl_Ubicacion.Location = new System.Drawing.Point(151, 72);
            this.lbl_Ubicacion.Name = "lbl_Ubicacion";
            this.lbl_Ubicacion.Size = new System.Drawing.Size(55, 13);
            this.lbl_Ubicacion.TabIndex = 5;
            this.lbl_Ubicacion.Text = "Ubicación";
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Location = new System.Drawing.Point(21, 72);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(35, 13);
            this.lbl_Stock.TabIndex = 4;
            this.lbl_Stock.Text = "Stock";
            // 
            // lbl_Venta
            // 
            this.lbl_Venta.AutoSize = true;
            this.lbl_Venta.Location = new System.Drawing.Point(151, 120);
            this.lbl_Venta.Name = "lbl_Venta";
            this.lbl_Venta.Size = new System.Drawing.Size(68, 13);
            this.lbl_Venta.TabIndex = 3;
            this.lbl_Venta.Text = "Precio Venta";
            // 
            // lbl_Compra
            // 
            this.lbl_Compra.AutoSize = true;
            this.lbl_Compra.Location = new System.Drawing.Point(21, 120);
            this.lbl_Compra.Name = "lbl_Compra";
            this.lbl_Compra.Size = new System.Drawing.Size(76, 13);
            this.lbl_Compra.TabIndex = 2;
            this.lbl_Compra.Text = "Precio Compra";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(151, 20);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(21, 20);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(18, 13);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "ID";
            // 
            // dtg_Productos
            // 
            this.dtg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Productos.Location = new System.Drawing.Point(12, 302);
            this.dtg_Productos.Name = "dtg_Productos";
            this.dtg_Productos.Size = new System.Drawing.Size(548, 127);
            this.dtg_Productos.TabIndex = 1;
            this.dtg_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Productos_CellClick);
            // 
            // grb_Acciones
            // 
            this.grb_Acciones.Controls.Add(this.btn_Eliminar);
            this.grb_Acciones.Controls.Add(this.btn_Modificar);
            this.grb_Acciones.Controls.Add(this.btn_Agregar);
            this.grb_Acciones.Location = new System.Drawing.Point(417, 45);
            this.grb_Acciones.Name = "grb_Acciones";
            this.grb_Acciones.Size = new System.Drawing.Size(155, 214);
            this.grb_Acciones.TabIndex = 2;
            this.grb_Acciones.TabStop = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(18, 114);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(119, 39);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(18, 69);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(119, 39);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(18, 24);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(119, 39);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(19, 9);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(172, 21);
            this.lbl_Titulo.TabIndex = 21;
            this.lbl_Titulo.Text = "Catalogo de Productos";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = global::ProyectoIntegrador.Properties.Resources.ic_clear_black_36dp;
            this.btn_Salir.Location = new System.Drawing.Point(516, 3);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(58, 30);
            this.btn_Salir.TabIndex = 22;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pic_Titulo
            // 
            this.pic_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pic_Titulo.Location = new System.Drawing.Point(-7, 0);
            this.pic_Titulo.Name = "pic_Titulo";
            this.pic_Titulo.Size = new System.Drawing.Size(597, 39);
            this.pic_Titulo.TabIndex = 20;
            this.pic_Titulo.TabStop = false;
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filtro.Location = new System.Drawing.Point(32, 266);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(37, 16);
            this.lbl_Filtro.TabIndex = 23;
            this.lbl_Filtro.Text = "Filtro";
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(76, 266);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(194, 20);
            this.txt_Filtro.TabIndex = 24;
            this.txt_Filtro.TextChanged += new System.EventHandler(this.txt_Filtro_TextChanged);
            // 
            // frm_ProductosGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(584, 458);
            this.Controls.Add(this.txt_Filtro);
            this.Controls.Add(this.lbl_Filtro);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pic_Titulo);
            this.Controls.Add(this.grb_Acciones);
            this.Controls.Add(this.dtg_Productos);
            this.Controls.Add(this.grb_Datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ProductosGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_ProductosGUI_Load);
            this.grb_Datos.ResumeLayout(false);
            this.grb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).EndInit();
            this.grb_Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Datos;
        private System.Windows.Forms.TextBox txt_Ubicacion;
        private System.Windows.Forms.TextBox txt_PreVenta;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.TextBox txt_PreCompra;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Ubicacion;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Label lbl_Venta;
        private System.Windows.Forms.Label lbl_Compra;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.DataGridView dtg_Productos;
        private System.Windows.Forms.GroupBox grb_Acciones;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pic_Titulo;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.TextBox txt_Filtro;
    }
}


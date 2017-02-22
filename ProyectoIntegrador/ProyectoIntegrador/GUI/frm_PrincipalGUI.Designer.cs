namespace ProyectoIntegrador.GUI
{
    partial class frm_PrincipalGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Catalogos = new System.Windows.Forms.Panel();
            this.btn_Proveedores = new System.Windows.Forms.Button();
            this.btn_Marcas = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_CatalogoClientes = new System.Windows.Forms.Button();
            this.pnl_Principal = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Catalogo = new System.Windows.Forms.Button();
            this.btn_AbrirPunto = new System.Windows.Forms.Button();
            this.pnl_Catalogos.SuspendLayout();
            this.pnl_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Catalogos
            // 
            this.pnl_Catalogos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.pnl_Catalogos.Controls.Add(this.btn_Proveedores);
            this.pnl_Catalogos.Controls.Add(this.btn_Marcas);
            this.pnl_Catalogos.Controls.Add(this.btn_Cerrar);
            this.pnl_Catalogos.Controls.Add(this.btn_Usuarios);
            this.pnl_Catalogos.Controls.Add(this.btn_Productos);
            this.pnl_Catalogos.Controls.Add(this.btn_CatalogoClientes);
            this.pnl_Catalogos.Location = new System.Drawing.Point(152, 0);
            this.pnl_Catalogos.Name = "pnl_Catalogos";
            this.pnl_Catalogos.Size = new System.Drawing.Size(157, 729);
            this.pnl_Catalogos.TabIndex = 26;
            this.pnl_Catalogos.Visible = false;
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_normalMenuPrin;
            this.btn_Proveedores.FlatAppearance.BorderSize = 0;
            this.btn_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Proveedores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Proveedores.Image = global::ProyectoIntegrador.Properties.Resources.camion_de_carga;
            this.btn_Proveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Proveedores.Location = new System.Drawing.Point(20, 460);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Size = new System.Drawing.Size(117, 91);
            this.btn_Proveedores.TabIndex = 36;
            this.btn_Proveedores.Text = "\r\nProveedores";
            this.btn_Proveedores.UseVisualStyleBackColor = true;
            this.btn_Proveedores.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Marcas
            // 
            this.btn_Marcas.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_normalMenuPrin;
            this.btn_Marcas.FlatAppearance.BorderSize = 0;
            this.btn_Marcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Marcas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Marcas.Image = global::ProyectoIntegrador.Properties.Resources.interfaz;
            this.btn_Marcas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Marcas.Location = new System.Drawing.Point(20, 357);
            this.btn_Marcas.Name = "btn_Marcas";
            this.btn_Marcas.Size = new System.Drawing.Size(117, 91);
            this.btn_Marcas.TabIndex = 35;
            this.btn_Marcas.Text = "\r\nMarcas";
            this.btn_Marcas.UseVisualStyleBackColor = true;
            this.btn_Marcas.Click += new System.EventHandler(this.btn_Marcas_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Image = global::ProyectoIntegrador.Properties.Resources.ic_clear_black_36dp;
            this.btn_Cerrar.Location = new System.Drawing.Point(113, 3);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(41, 30);
            this.btn_Cerrar.TabIndex = 34;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_normalMenuPrin;
            this.btn_Usuarios.FlatAppearance.BorderSize = 0;
            this.btn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Usuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Usuarios.Image = global::ProyectoIntegrador.Properties.Resources.ic_account_box_white_36dp;
            this.btn_Usuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Usuarios.Location = new System.Drawing.Point(20, 251);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(117, 91);
            this.btn_Usuarios.TabIndex = 2;
            this.btn_Usuarios.Text = " \r\nUsuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click);
            // 
            // btn_Productos
            // 
            this.btn_Productos.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_normalMenuPrin;
            this.btn_Productos.FlatAppearance.BorderSize = 0;
            this.btn_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Productos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Productos.Image = global::ProyectoIntegrador.Properties.Resources.negocios_blck__1_;
            this.btn_Productos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Productos.Location = new System.Drawing.Point(20, 145);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(117, 91);
            this.btn_Productos.TabIndex = 1;
            this.btn_Productos.Text = "\r\nProductos";
            this.btn_Productos.UseVisualStyleBackColor = true;
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click);
            // 
            // btn_CatalogoClientes
            // 
            this.btn_CatalogoClientes.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_normalMenuPrin;
            this.btn_CatalogoClientes.FlatAppearance.BorderSize = 0;
            this.btn_CatalogoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CatalogoClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_CatalogoClientes.Image = global::ProyectoIntegrador.Properties.Resources.ic_account_box_white_36dp;
            this.btn_CatalogoClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CatalogoClientes.Location = new System.Drawing.Point(20, 39);
            this.btn_CatalogoClientes.Name = "btn_CatalogoClientes";
            this.btn_CatalogoClientes.Size = new System.Drawing.Size(117, 91);
            this.btn_CatalogoClientes.TabIndex = 0;
            this.btn_CatalogoClientes.Text = " \r\nClientes";
            this.btn_CatalogoClientes.UseVisualStyleBackColor = true;
            this.btn_CatalogoClientes.Click += new System.EventHandler(this.btn_CatalogoClientes_Click);
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnl_Principal.Controls.Add(this.btn_Salir);
            this.pnl_Principal.Controls.Add(this.btn_Catalogo);
            this.pnl_Principal.Controls.Add(this.btn_AbrirPunto);
            this.pnl_Principal.Location = new System.Drawing.Point(0, -1);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(157, 747);
            this.pnl_Principal.TabIndex = 30;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Salir.Image = global::ProyectoIntegrador.Properties.Resources.ic_power_settings_new_black_36dp;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Salir.Location = new System.Drawing.Point(40, 643);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(78, 76);
            this.btn_Salir.TabIndex = 33;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Catalogo
            // 
            this.btn_Catalogo.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_normalMenuPrin;
            this.btn_Catalogo.FlatAppearance.BorderSize = 0;
            this.btn_Catalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Catalogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Catalogo.Image = global::ProyectoIntegrador.Properties.Resources.ic_library_books_white_36dp;
            this.btn_Catalogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Catalogo.Location = new System.Drawing.Point(20, 147);
            this.btn_Catalogo.Name = "btn_Catalogo";
            this.btn_Catalogo.Size = new System.Drawing.Size(117, 91);
            this.btn_Catalogo.TabIndex = 31;
            this.btn_Catalogo.Text = "\r\nCatalogos";
            this.btn_Catalogo.UseVisualStyleBackColor = true;
            this.btn_Catalogo.Click += new System.EventHandler(this.btn_Catalogo_Click);
            this.btn_Catalogo.MouseEnter += new System.EventHandler(this.btn_Catalogo_MouseEnter);
            this.btn_Catalogo.MouseLeave += new System.EventHandler(this.btn_Catalogo_MouseLeave);
            // 
            // btn_AbrirPunto
            // 
            this.btn_AbrirPunto.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_normalMenuPrin;
            this.btn_AbrirPunto.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.btn_AbrirPunto.FlatAppearance.BorderSize = 0;
            this.btn_AbrirPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AbrirPunto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_AbrirPunto.Image = global::ProyectoIntegrador.Properties.Resources.ic_shopping_cart_white_36dp;
            this.btn_AbrirPunto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_AbrirPunto.Location = new System.Drawing.Point(20, 41);
            this.btn_AbrirPunto.Name = "btn_AbrirPunto";
            this.btn_AbrirPunto.Size = new System.Drawing.Size(117, 91);
            this.btn_AbrirPunto.TabIndex = 30;
            this.btn_AbrirPunto.Text = "Punto de venta";
            this.btn_AbrirPunto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AbrirPunto.UseVisualStyleBackColor = true;
            this.btn_AbrirPunto.Click += new System.EventHandler(this.btn_AbrirPunto_Click);
            this.btn_AbrirPunto.MouseEnter += new System.EventHandler(this.btn_AbrirPunto_MouseEnter);
            this.btn_AbrirPunto.MouseLeave += new System.EventHandler(this.btn_AbrirPunto_MouseLeave);
            // 
            // frm_PrincipalGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.pnl_Principal);
            this.Controls.Add(this.pnl_Catalogos);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_PrincipalGUI";
            this.Text = "Sistema: Tiendad de abarrotes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_PrincipalGUI_Load);
            this.Click += new System.EventHandler(this.frm_PrincipalGUI_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frm_PrincipalGUI_MouseClick);
            this.pnl_Catalogos.ResumeLayout(false);
            this.pnl_Principal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Catalogos;
        private System.Windows.Forms.Button btn_CatalogoClientes;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Panel pnl_Principal;
        private System.Windows.Forms.Button btn_Catalogo;
        private System.Windows.Forms.Button btn_AbrirPunto;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Usuarios;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Marcas;
        private System.Windows.Forms.Button btn_Proveedores;
    }
}
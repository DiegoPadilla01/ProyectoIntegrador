namespace ProyectoIntegrador.GUI
{
    partial class frm_UsuariosGUI
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
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.grb_DatosUsuarios = new System.Windows.Forms.GroupBox();
            this.cmb_Permiso = new System.Windows.Forms.ComboBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_NomUsuario = new System.Windows.Forms.TextBox();
            this.lbl_Permiso = new System.Windows.Forms.Label();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.dgt_Usuarios = new System.Windows.Forms.DataGridView();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pic_Titulo = new System.Windows.Forms.PictureBox();
            this.grb_DatosUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(12, 31);
            this.lbl_NombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(126, 16);
            this.lbl_NombreUsuario.TabIndex = 4;
            this.lbl_NombreUsuario.Text = "Nombre de Usuario";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(12, 91);
            this.lbl_Contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(77, 16);
            this.lbl_Contraseña.TabIndex = 5;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // grb_DatosUsuarios
            // 
            this.grb_DatosUsuarios.CausesValidation = false;
            this.grb_DatosUsuarios.Controls.Add(this.cmb_Permiso);
            this.grb_DatosUsuarios.Controls.Add(this.txt_Contraseña);
            this.grb_DatosUsuarios.Controls.Add(this.txt_NomUsuario);
            this.grb_DatosUsuarios.Controls.Add(this.lbl_Permiso);
            this.grb_DatosUsuarios.Controls.Add(this.lbl_Contraseña);
            this.grb_DatosUsuarios.Controls.Add(this.lbl_NombreUsuario);
            this.grb_DatosUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grb_DatosUsuarios.Location = new System.Drawing.Point(24, 58);
            this.grb_DatosUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.grb_DatosUsuarios.Name = "grb_DatosUsuarios";
            this.grb_DatosUsuarios.Padding = new System.Windows.Forms.Padding(4);
            this.grb_DatosUsuarios.Size = new System.Drawing.Size(284, 224);
            this.grb_DatosUsuarios.TabIndex = 8;
            this.grb_DatosUsuarios.TabStop = false;
            this.grb_DatosUsuarios.Text = "Datos  de Usuario";
            // 
            // cmb_Permiso
            // 
            this.cmb_Permiso.FormattingEnabled = true;
            this.cmb_Permiso.Items.AddRange(new object[] {
            "Cajero",
            "Administrador"});
            this.cmb_Permiso.Location = new System.Drawing.Point(15, 179);
            this.cmb_Permiso.Name = "cmb_Permiso";
            this.cmb_Permiso.Size = new System.Drawing.Size(217, 24);
            this.cmb_Permiso.TabIndex = 9;
            this.cmb_Permiso.Text = "Seleccione...";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(15, 111);
            this.txt_Contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(214, 22);
            this.txt_Contraseña.TabIndex = 8;
            // 
            // txt_NomUsuario
            // 
            this.txt_NomUsuario.Enabled = false;
            this.txt_NomUsuario.Location = new System.Drawing.Point(15, 51);
            this.txt_NomUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NomUsuario.Name = "txt_NomUsuario";
            this.txt_NomUsuario.Size = new System.Drawing.Size(214, 22);
            this.txt_NomUsuario.TabIndex = 7;
            // 
            // lbl_Permiso
            // 
            this.lbl_Permiso.AutoSize = true;
            this.lbl_Permiso.Location = new System.Drawing.Point(12, 149);
            this.lbl_Permiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Permiso.Name = "lbl_Permiso";
            this.lbl_Permiso.Size = new System.Drawing.Size(65, 16);
            this.lbl_Permiso.TabIndex = 6;
            this.lbl_Permiso.Text = "Permisos";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(24, 303);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(138, 34);
            this.btn_Nuevo.TabIndex = 3;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(170, 346);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(138, 32);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(170, 304);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(138, 33);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "Actualizar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Location = new System.Drawing.Point(24, 346);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(138, 32);
            this.btn_Guardar.TabIndex = 0;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // dgt_Usuarios
            // 
            this.dgt_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_Usuarios.Location = new System.Drawing.Point(13, 396);
            this.dgt_Usuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgt_Usuarios.Name = "dgt_Usuarios";
            this.dgt_Usuarios.Size = new System.Drawing.Size(304, 185);
            this.dgt_Usuarios.TabIndex = 10;
            this.dgt_Usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgt_Usuarios_CellContentClick);
            this.dgt_Usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgt_Usuarios_CellContentClick);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = global::ProyectoIntegrador.Properties.Resources.ic_clear_black_36dp;
            this.btn_Salir.Location = new System.Drawing.Point(267, 3);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(87, 42);
            this.btn_Salir.TabIndex = 25;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(29, 12);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(163, 21);
            this.lbl_Titulo.TabIndex = 24;
            this.lbl_Titulo.Text = "Catalogo de Usuarios";
            // 
            // pic_Titulo
            // 
            this.pic_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pic_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pic_Titulo.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Titulo.Name = "pic_Titulo";
            this.pic_Titulo.Size = new System.Drawing.Size(354, 50);
            this.pic_Titulo.TabIndex = 23;
            this.pic_Titulo.TabStop = false;
            // 
            // frm_UsuariosGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(330, 603);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pic_Titulo);
            this.Controls.Add(this.dgt_Usuarios);
            this.Controls.Add(this.grb_DatosUsuarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UsuariosGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_UsuariosGUI_Load);
            this.grb_DatosUsuarios.ResumeLayout(false);
            this.grb_DatosUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_NombreUsuario;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.GroupBox grb_DatosUsuarios;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_NomUsuario;
        private System.Windows.Forms.Label lbl_Permiso;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView dgt_Usuarios;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pic_Titulo;
        private System.Windows.Forms.ComboBox cmb_Permiso;
    }
}
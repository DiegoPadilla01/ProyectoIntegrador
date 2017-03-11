namespace ProyectoIntegrador.GUI
{
    partial class frm_ProveedoresGUI
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
            this.grb_Datos = new System.Windows.Forms.GroupBox();
            this.grb_Dieccion = new System.Windows.Forms.GroupBox();
            this.txt_CodPostal = new System.Windows.Forms.TextBox();
            this.txt_Colonia = new System.Windows.Forms.TextBox();
            this.lbl_CodPostal = new System.Windows.Forms.Label();
            this.lbl_Colonia = new System.Windows.Forms.Label();
            this.txt_Cruzamientos = new System.Windows.Forms.TextBox();
            this.lbl_Cruzamientos = new System.Windows.Forms.Label();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.lbl_Num = new System.Windows.Forms.Label();
            this.txt_Calle = new System.Windows.Forms.TextBox();
            this.lbl_Calle = new System.Windows.Forms.Label();
            this.msk_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_RFC = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_RFC = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.dtg_Proveedores = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pic_Titulo = new System.Windows.Forms.PictureBox();
            this.grb_Datos.SuspendLayout();
            this.grb_Dieccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Proveedores)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Datos
            // 
            this.grb_Datos.Controls.Add(this.grb_Dieccion);
            this.grb_Datos.Controls.Add(this.msk_Telefono);
            this.grb_Datos.Controls.Add(this.txt_Nombre);
            this.grb_Datos.Controls.Add(this.txt_RFC);
            this.grb_Datos.Controls.Add(this.txt_ID);
            this.grb_Datos.Controls.Add(this.lbl_Telefono);
            this.grb_Datos.Controls.Add(this.lbl_Nombre);
            this.grb_Datos.Controls.Add(this.lbl_RFC);
            this.grb_Datos.Controls.Add(this.lbl_Id);
            this.grb_Datos.Location = new System.Drawing.Point(12, 58);
            this.grb_Datos.Name = "grb_Datos";
            this.grb_Datos.Size = new System.Drawing.Size(433, 294);
            this.grb_Datos.TabIndex = 0;
            this.grb_Datos.TabStop = false;
            this.grb_Datos.Text = "Datos";
            // 
            // grb_Dieccion
            // 
            this.grb_Dieccion.Controls.Add(this.txt_CodPostal);
            this.grb_Dieccion.Controls.Add(this.txt_Colonia);
            this.grb_Dieccion.Controls.Add(this.lbl_CodPostal);
            this.grb_Dieccion.Controls.Add(this.lbl_Colonia);
            this.grb_Dieccion.Controls.Add(this.txt_Cruzamientos);
            this.grb_Dieccion.Controls.Add(this.lbl_Cruzamientos);
            this.grb_Dieccion.Controls.Add(this.txt_Num);
            this.grb_Dieccion.Controls.Add(this.lbl_Num);
            this.grb_Dieccion.Controls.Add(this.txt_Calle);
            this.grb_Dieccion.Controls.Add(this.lbl_Calle);
            this.grb_Dieccion.Location = new System.Drawing.Point(6, 156);
            this.grb_Dieccion.Name = "grb_Dieccion";
            this.grb_Dieccion.Size = new System.Drawing.Size(412, 114);
            this.grb_Dieccion.TabIndex = 1;
            this.grb_Dieccion.TabStop = false;
            this.grb_Dieccion.Text = "Dirección";
            // 
            // txt_CodPostal
            // 
            this.txt_CodPostal.Location = new System.Drawing.Point(212, 83);
            this.txt_CodPostal.Name = "txt_CodPostal";
            this.txt_CodPostal.Size = new System.Drawing.Size(87, 20);
            this.txt_CodPostal.TabIndex = 11;
            // 
            // txt_Colonia
            // 
            this.txt_Colonia.Location = new System.Drawing.Point(17, 83);
            this.txt_Colonia.Name = "txt_Colonia";
            this.txt_Colonia.Size = new System.Drawing.Size(189, 20);
            this.txt_Colonia.TabIndex = 10;
            // 
            // lbl_CodPostal
            // 
            this.lbl_CodPostal.AutoSize = true;
            this.lbl_CodPostal.Location = new System.Drawing.Point(209, 67);
            this.lbl_CodPostal.Name = "lbl_CodPostal";
            this.lbl_CodPostal.Size = new System.Drawing.Size(61, 13);
            this.lbl_CodPostal.TabIndex = 9;
            this.lbl_CodPostal.Text = "Cod. Postal";
            // 
            // lbl_Colonia
            // 
            this.lbl_Colonia.AutoSize = true;
            this.lbl_Colonia.Location = new System.Drawing.Point(14, 67);
            this.lbl_Colonia.Name = "lbl_Colonia";
            this.lbl_Colonia.Size = new System.Drawing.Size(42, 13);
            this.lbl_Colonia.TabIndex = 8;
            this.lbl_Colonia.Text = "Colonia";
            // 
            // txt_Cruzamientos
            // 
            this.txt_Cruzamientos.Location = new System.Drawing.Point(184, 36);
            this.txt_Cruzamientos.Name = "txt_Cruzamientos";
            this.txt_Cruzamientos.Size = new System.Drawing.Size(115, 20);
            this.txt_Cruzamientos.TabIndex = 7;
            // 
            // lbl_Cruzamientos
            // 
            this.lbl_Cruzamientos.AutoSize = true;
            this.lbl_Cruzamientos.Location = new System.Drawing.Point(181, 20);
            this.lbl_Cruzamientos.Name = "lbl_Cruzamientos";
            this.lbl_Cruzamientos.Size = new System.Drawing.Size(70, 13);
            this.lbl_Cruzamientos.TabIndex = 4;
            this.lbl_Cruzamientos.Text = "Cruzamientos";
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(107, 34);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(71, 20);
            this.txt_Num.TabIndex = 3;
            // 
            // lbl_Num
            // 
            this.lbl_Num.AutoSize = true;
            this.lbl_Num.Location = new System.Drawing.Point(104, 16);
            this.lbl_Num.Name = "lbl_Num";
            this.lbl_Num.Size = new System.Drawing.Size(19, 13);
            this.lbl_Num.TabIndex = 2;
            this.lbl_Num.Text = "N°";
            // 
            // txt_Calle
            // 
            this.txt_Calle.Location = new System.Drawing.Point(23, 34);
            this.txt_Calle.Name = "txt_Calle";
            this.txt_Calle.Size = new System.Drawing.Size(78, 20);
            this.txt_Calle.TabIndex = 1;
            // 
            // lbl_Calle
            // 
            this.lbl_Calle.AutoSize = true;
            this.lbl_Calle.Location = new System.Drawing.Point(18, 16);
            this.lbl_Calle.Name = "lbl_Calle";
            this.lbl_Calle.Size = new System.Drawing.Size(30, 13);
            this.lbl_Calle.TabIndex = 0;
            this.lbl_Calle.Text = "Calle";
            // 
            // msk_Telefono
            // 
            this.msk_Telefono.Location = new System.Drawing.Point(29, 121);
            this.msk_Telefono.Mask = "(999)000-0000";
            this.msk_Telefono.Name = "msk_Telefono";
            this.msk_Telefono.Size = new System.Drawing.Size(100, 20);
            this.msk_Telefono.TabIndex = 8;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(29, 82);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(228, 20);
            this.txt_Nombre.TabIndex = 7;
            // 
            // txt_RFC
            // 
            this.txt_RFC.Location = new System.Drawing.Point(157, 40);
            this.txt_RFC.Name = "txt_RFC";
            this.txt_RFC.Size = new System.Drawing.Size(100, 20);
            this.txt_RFC.TabIndex = 6;
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(27, 40);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 5;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(26, 105);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefono.TabIndex = 4;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(26, 63);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_RFC
            // 
            this.lbl_RFC.AutoSize = true;
            this.lbl_RFC.Location = new System.Drawing.Point(154, 23);
            this.lbl_RFC.Name = "lbl_RFC";
            this.lbl_RFC.Size = new System.Drawing.Size(28, 13);
            this.lbl_RFC.TabIndex = 1;
            this.lbl_RFC.Text = "RFC";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(26, 23);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(18, 13);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "ID";
            // 
            // dtg_Proveedores
            // 
            this.dtg_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Proveedores.Location = new System.Drawing.Point(12, 358);
            this.dtg_Proveedores.Name = "dtg_Proveedores";
            this.dtg_Proveedores.Size = new System.Drawing.Size(547, 109);
            this.dtg_Proveedores.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Eliminar);
            this.groupBox3.Controls.Add(this.btn_Guardar);
            this.groupBox3.Controls.Add(this.btn_Modificar);
            this.groupBox3.Controls.Add(this.btn_Nuevo);
            this.groupBox3.Controls.Add(this.btn_Buscar);
            this.groupBox3.Location = new System.Drawing.Point(460, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 294);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(6, 212);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(107, 41);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(7, 118);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(107, 41);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(7, 165);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(107, 41);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Actualizar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(6, 71);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(107, 41);
            this.btn_Nuevo.TabIndex = 1;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(6, 23);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(107, 41);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = global::ProyectoIntegrador.Properties.Resources.ic_clear_black_36dp;
            this.btn_Salir.Location = new System.Drawing.Point(515, 4);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(59, 42);
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
            this.lbl_Titulo.Location = new System.Drawing.Point(29, 14);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(191, 21);
            this.lbl_Titulo.TabIndex = 24;
            this.lbl_Titulo.Text = "Catalogo de Proveedores";
            // 
            // pic_Titulo
            // 
            this.pic_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pic_Titulo.Location = new System.Drawing.Point(-7, -3);
            this.pic_Titulo.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Titulo.Name = "pic_Titulo";
            this.pic_Titulo.Size = new System.Drawing.Size(599, 54);
            this.pic_Titulo.TabIndex = 23;
            this.pic_Titulo.TabStop = false;
            // 
            // frm_ProveedoresGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(591, 503);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pic_Titulo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtg_Proveedores);
            this.Controls.Add(this.grb_Datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ProveedoresGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_ProveedoresGUI_Load);
            this.grb_Datos.ResumeLayout(false);
            this.grb_Datos.PerformLayout();
            this.grb_Dieccion.ResumeLayout(false);
            this.grb_Dieccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Proveedores)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Datos;
        private System.Windows.Forms.GroupBox grb_Dieccion;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.Label lbl_Num;
        private System.Windows.Forms.TextBox txt_Calle;
        private System.Windows.Forms.Label lbl_Calle;
        private System.Windows.Forms.MaskedTextBox msk_Telefono;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_RFC;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_RFC;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_CodPostal;
        private System.Windows.Forms.Label lbl_Colonia;
        private System.Windows.Forms.TextBox txt_Cruzamientos;
        private System.Windows.Forms.Label lbl_Cruzamientos;
        private System.Windows.Forms.TextBox txt_CodPostal;
        private System.Windows.Forms.TextBox txt_Colonia;
        private System.Windows.Forms.DataGridView dtg_Proveedores;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pic_Titulo;
    }
}
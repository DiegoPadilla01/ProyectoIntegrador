namespace ProyectoIntegrador.GUI
{
    partial class frm_MarcasGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.grb_AltasMarca = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreMarca = new System.Windows.Forms.TextBox();
            this.txt_IdMarca = new System.Windows.Forms.TextBox();
            this.grb_Acciones = new System.Windows.Forms.GroupBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pic_Titulo = new System.Windows.Forms.PictureBox();
            this.dgt_Marcas = new System.Windows.Forms.DataGridView();
            this.IDMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_AltasMarca.SuspendLayout();
            this.grb_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Marca";
            // 
            // grb_AltasMarca
            // 
            this.grb_AltasMarca.Controls.Add(this.label2);
            this.grb_AltasMarca.Controls.Add(this.txt_NombreMarca);
            this.grb_AltasMarca.Controls.Add(this.txt_IdMarca);
            this.grb_AltasMarca.Controls.Add(this.label1);
            this.grb_AltasMarca.Location = new System.Drawing.Point(18, 69);
            this.grb_AltasMarca.Margin = new System.Windows.Forms.Padding(4);
            this.grb_AltasMarca.Name = "grb_AltasMarca";
            this.grb_AltasMarca.Padding = new System.Windows.Forms.Padding(4);
            this.grb_AltasMarca.Size = new System.Drawing.Size(316, 262);
            this.grb_AltasMarca.TabIndex = 1;
            this.grb_AltasMarca.TabStop = false;
            this.grb_AltasMarca.Text = "Datos de Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de la Marca";
            // 
            // txt_NombreMarca
            // 
            this.txt_NombreMarca.Location = new System.Drawing.Point(14, 126);
            this.txt_NombreMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreMarca.Name = "txt_NombreMarca";
            this.txt_NombreMarca.Size = new System.Drawing.Size(253, 24);
            this.txt_NombreMarca.TabIndex = 3;
            // 
            // txt_IdMarca
            // 
            this.txt_IdMarca.Location = new System.Drawing.Point(14, 58);
            this.txt_IdMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdMarca.Name = "txt_IdMarca";
            this.txt_IdMarca.Size = new System.Drawing.Size(253, 24);
            this.txt_IdMarca.TabIndex = 2;
            // 
            // grb_Acciones
            // 
            this.grb_Acciones.Controls.Add(this.btn_Eliminar);
            this.grb_Acciones.Controls.Add(this.btn_Modificar);
            this.grb_Acciones.Controls.Add(this.btn_Agregar);
            this.grb_Acciones.Controls.Add(this.btn_Buscar);
            this.grb_Acciones.Location = new System.Drawing.Point(366, 69);
            this.grb_Acciones.Margin = new System.Windows.Forms.Padding(4);
            this.grb_Acciones.Name = "grb_Acciones";
            this.grb_Acciones.Padding = new System.Windows.Forms.Padding(4);
            this.grb_Acciones.Size = new System.Drawing.Size(196, 262);
            this.grb_Acciones.TabIndex = 2;
            this.grb_Acciones.TabStop = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(9, 198);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(176, 46);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(9, 144);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(176, 46);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(12, 90);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(176, 46);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(12, 36);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(176, 46);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = global::ProyectoIntegrador.Properties.Resources.ic_clear_black_36dp;
            this.btn_Salir.Location = new System.Drawing.Point(478, 2);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(87, 42);
            this.btn_Salir.TabIndex = 22;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(26, 12);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(152, 21);
            this.lbl_Titulo.TabIndex = 21;
            this.lbl_Titulo.Text = "Catalogo de Marcas";
            // 
            // pic_Titulo
            // 
            this.pic_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pic_Titulo.Location = new System.Drawing.Point(-3, -1);
            this.pic_Titulo.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Titulo.Name = "pic_Titulo";
            this.pic_Titulo.Size = new System.Drawing.Size(586, 54);
            this.pic_Titulo.TabIndex = 20;
            this.pic_Titulo.TabStop = false;
            // 
            // dgt_Marcas
            // 
            this.dgt_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_Marcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMarca,
            this.NombreMarca});
            this.dgt_Marcas.Location = new System.Drawing.Point(18, 341);
            this.dgt_Marcas.Margin = new System.Windows.Forms.Padding(4);
            this.dgt_Marcas.Name = "dgt_Marcas";
            this.dgt_Marcas.Size = new System.Drawing.Size(532, 145);
            this.dgt_Marcas.TabIndex = 23;
            // 
            // IDMarca
            // 
            this.IDMarca.HeaderText = "ID";
            this.IDMarca.Name = "IDMarca";
            // 
            // NombreMarca
            // 
            this.NombreMarca.HeaderText = "Nombre";
            this.NombreMarca.Name = "NombreMarca";
            // 
            // frm_MarcasGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(578, 503);
            this.Controls.Add(this.dgt_Marcas);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pic_Titulo);
            this.Controls.Add(this.grb_Acciones);
            this.Controls.Add(this.grb_AltasMarca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MarcasGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Marcas_Load);
            this.grb_AltasMarca.ResumeLayout(false);
            this.grb_AltasMarca.PerformLayout();
            this.grb_Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Marcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_AltasMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreMarca;
        private System.Windows.Forms.TextBox txt_IdMarca;
        private System.Windows.Forms.GroupBox grb_Acciones;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pic_Titulo;
        private System.Windows.Forms.DataGridView dgt_Marcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMarca;
    }
}


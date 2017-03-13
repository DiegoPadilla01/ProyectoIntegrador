namespace ProyectoIntegrador.GUI
{
    partial class frm_EstadoGUI
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
            this.grb_AltasEstado = new System.Windows.Forms.GroupBox();
            this.txt_IdPais = new System.Windows.Forms.TextBox();
            this.lbl_IdPais = new System.Windows.Forms.Label();
            this.lbl_NomEsta = new System.Windows.Forms.Label();
            this.lbl_IdEstado = new System.Windows.Forms.Label();
            this.txt_Nomestado = new System.Windows.Forms.TextBox();
            this.txt_IdEstado = new System.Windows.Forms.TextBox();
            this.grb_Acciones = new System.Windows.Forms.GroupBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.dgt_Estado = new System.Windows.Forms.DataGridView();
            this.Id_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Paias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_FiltroEst = new System.Windows.Forms.Label();
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.pic_Titulo = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_CatEst = new System.Windows.Forms.Label();
            this.grb_AltasEstado.SuspendLayout();
            this.grb_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_AltasEstado
            // 
            this.grb_AltasEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.grb_AltasEstado.Controls.Add(this.txt_IdPais);
            this.grb_AltasEstado.Controls.Add(this.lbl_IdPais);
            this.grb_AltasEstado.Controls.Add(this.lbl_NomEsta);
            this.grb_AltasEstado.Controls.Add(this.lbl_IdEstado);
            this.grb_AltasEstado.Controls.Add(this.txt_Nomestado);
            this.grb_AltasEstado.Controls.Add(this.txt_IdEstado);
            this.grb_AltasEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_AltasEstado.Location = new System.Drawing.Point(8, 75);
            this.grb_AltasEstado.Name = "grb_AltasEstado";
            this.grb_AltasEstado.Size = new System.Drawing.Size(320, 225);
            this.grb_AltasEstado.TabIndex = 0;
            this.grb_AltasEstado.TabStop = false;
            this.grb_AltasEstado.Text = "Datos de Estado";
            // 
            // txt_IdPais
            // 
            this.txt_IdPais.Location = new System.Drawing.Point(9, 190);
            this.txt_IdPais.Multiline = true;
            this.txt_IdPais.Name = "txt_IdPais";
            this.txt_IdPais.Size = new System.Drawing.Size(290, 24);
            this.txt_IdPais.TabIndex = 10;
            // 
            // lbl_IdPais
            // 
            this.lbl_IdPais.AutoSize = true;
            this.lbl_IdPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdPais.Location = new System.Drawing.Point(6, 169);
            this.lbl_IdPais.Name = "lbl_IdPais";
            this.lbl_IdPais.Size = new System.Drawing.Size(55, 18);
            this.lbl_IdPais.TabIndex = 9;
            this.lbl_IdPais.Text = "ID País";
            // 
            // lbl_NomEsta
            // 
            this.lbl_NomEsta.AutoSize = true;
            this.lbl_NomEsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomEsta.Location = new System.Drawing.Point(6, 104);
            this.lbl_NomEsta.Name = "lbl_NomEsta";
            this.lbl_NomEsta.Size = new System.Drawing.Size(113, 18);
            this.lbl_NomEsta.TabIndex = 8;
            this.lbl_NomEsta.Text = "Nombre Estado";
            // 
            // lbl_IdEstado
            // 
            this.lbl_IdEstado.AutoSize = true;
            this.lbl_IdEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdEstado.Location = new System.Drawing.Point(6, 39);
            this.lbl_IdEstado.Name = "lbl_IdEstado";
            this.lbl_IdEstado.Size = new System.Drawing.Size(73, 18);
            this.lbl_IdEstado.TabIndex = 7;
            this.lbl_IdEstado.Text = "ID Estado";
            // 
            // txt_Nomestado
            // 
            this.txt_Nomestado.Location = new System.Drawing.Point(6, 128);
            this.txt_Nomestado.Multiline = true;
            this.txt_Nomestado.Name = "txt_Nomestado";
            this.txt_Nomestado.Size = new System.Drawing.Size(290, 24);
            this.txt_Nomestado.TabIndex = 6;
            // 
            // txt_IdEstado
            // 
            this.txt_IdEstado.Location = new System.Drawing.Point(6, 58);
            this.txt_IdEstado.Multiline = true;
            this.txt_IdEstado.Name = "txt_IdEstado";
            this.txt_IdEstado.Size = new System.Drawing.Size(290, 24);
            this.txt_IdEstado.TabIndex = 5;
            // 
            // grb_Acciones
            // 
            this.grb_Acciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.grb_Acciones.Controls.Add(this.btn_Guardar);
            this.grb_Acciones.Controls.Add(this.btn_Eliminar);
            this.grb_Acciones.Controls.Add(this.btn_Modificar);
            this.grb_Acciones.Controls.Add(this.btn_Agregar);
            this.grb_Acciones.Location = new System.Drawing.Point(365, 75);
            this.grb_Acciones.Name = "grb_Acciones";
            this.grb_Acciones.Size = new System.Drawing.Size(203, 225);
            this.grb_Acciones.TabIndex = 1;
            this.grb_Acciones.TabStop = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(17, 118);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(169, 45);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(17, 169);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(169, 45);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(17, 68);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(169, 45);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(17, 19);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(169, 43);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dgt_Estado
            // 
            this.dgt_Estado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_Estado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Estado,
            this.Nom_Estado,
            this.Id_Paias});
            this.dgt_Estado.Location = new System.Drawing.Point(12, 364);
            this.dgt_Estado.Name = "dgt_Estado";
            this.dgt_Estado.Size = new System.Drawing.Size(556, 134);
            this.dgt_Estado.TabIndex = 2;
            // 
            // Id_Estado
            // 
            this.Id_Estado.HeaderText = "ID";
            this.Id_Estado.Name = "Id_Estado";
            // 
            // Nom_Estado
            // 
            this.Nom_Estado.HeaderText = "Nombre";
            this.Nom_Estado.Name = "Nom_Estado";
            // 
            // Id_Paias
            // 
            this.Id_Paias.HeaderText = "ID País";
            this.Id_Paias.Name = "Id_Paias";
            // 
            // lbl_FiltroEst
            // 
            this.lbl_FiltroEst.AutoSize = true;
            this.lbl_FiltroEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FiltroEst.Location = new System.Drawing.Point(12, 303);
            this.lbl_FiltroEst.Name = "lbl_FiltroEst";
            this.lbl_FiltroEst.Size = new System.Drawing.Size(41, 18);
            this.lbl_FiltroEst.TabIndex = 3;
            this.lbl_FiltroEst.Text = "Filtro";
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(12, 324);
            this.txt_Filtro.Multiline = true;
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(316, 25);
            this.txt_Filtro.TabIndex = 4;
            // 
            // pic_Titulo
            // 
            this.pic_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pic_Titulo.Location = new System.Drawing.Point(-1, 0);
            this.pic_Titulo.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Titulo.Name = "pic_Titulo";
            this.pic_Titulo.Size = new System.Drawing.Size(586, 54);
            this.pic_Titulo.TabIndex = 21;
            this.pic_Titulo.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = global::ProyectoIntegrador.Properties.Resources.ic_clear_black_36dp;
            this.btn_Salir.Location = new System.Drawing.Point(481, 0);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(87, 42);
            this.btn_Salir.TabIndex = 23;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_CatEst
            // 
            this.lbl_CatEst.AutoSize = true;
            this.lbl_CatEst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbl_CatEst.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbl_CatEst.ForeColor = System.Drawing.Color.White;
            this.lbl_CatEst.Location = new System.Drawing.Point(29, 15);
            this.lbl_CatEst.Name = "lbl_CatEst";
            this.lbl_CatEst.Size = new System.Drawing.Size(158, 21);
            this.lbl_CatEst.TabIndex = 24;
            this.lbl_CatEst.Text = "Catálogo de Estados";
            // 
            // frm_EstadoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(581, 510);
            this.Controls.Add(this.lbl_CatEst);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.pic_Titulo);
            this.Controls.Add(this.txt_Filtro);
            this.Controls.Add(this.lbl_FiltroEst);
            this.Controls.Add(this.dgt_Estado);
            this.Controls.Add(this.grb_Acciones);
            this.Controls.Add(this.grb_AltasEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_EstadoGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.grb_AltasEstado.ResumeLayout(false);
            this.grb_AltasEstado.PerformLayout();
            this.grb_Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_AltasEstado;
        private System.Windows.Forms.GroupBox grb_Acciones;
        private System.Windows.Forms.DataGridView dgt_Estado;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label lbl_FiltroEst;
        private System.Windows.Forms.TextBox txt_Filtro;
        private System.Windows.Forms.TextBox txt_IdEstado;
        private System.Windows.Forms.TextBox txt_Nomestado;
        private System.Windows.Forms.Label lbl_NomEsta;
        private System.Windows.Forms.Label lbl_IdEstado;
        private System.Windows.Forms.PictureBox pic_Titulo;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Paias;
        private System.Windows.Forms.Label lbl_CatEst;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_IdPais;
        private System.Windows.Forms.Label lbl_IdPais;
    }
}
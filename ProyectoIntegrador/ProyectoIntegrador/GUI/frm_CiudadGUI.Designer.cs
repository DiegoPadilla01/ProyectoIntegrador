
namespace ProyectoIntegrador.GUI
{
    partial class frm_CiudadGUI
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
            /*this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "frm_CiudadGUI";*/
            this.grb_AltasCiud = new System.Windows.Forms.GroupBox();
            this.txt_IdEstado = new System.Windows.Forms.TextBox();
            this.lbl_IdEstado = new System.Windows.Forms.Label();
            this.txt_NomCiud = new System.Windows.Forms.TextBox();
            this.txt_IdCiud = new System.Windows.Forms.TextBox();
            this.lbl_NomCiud = new System.Windows.Forms.Label();
            this.lbl_IdCiud = new System.Windows.Forms.Label();
            this.grb_Acciones = new System.Windows.Forms.GroupBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.dgt_Ciudad = new System.Windows.Forms.DataGridView();
            this.Id_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.pic_Titulo = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_CatCiud = new System.Windows.Forms.Label();
            this.grb_AltasCiud.SuspendLayout();
            this.grb_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Ciudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_AltasCiud
            // 
            this.grb_AltasCiud.Controls.Add(this.txt_IdEstado);
            this.grb_AltasCiud.Controls.Add(this.lbl_IdEstado);
            this.grb_AltasCiud.Controls.Add(this.txt_NomCiud);
            this.grb_AltasCiud.Controls.Add(this.txt_IdCiud);
            this.grb_AltasCiud.Controls.Add(this.lbl_NomCiud);
            this.grb_AltasCiud.Controls.Add(this.lbl_IdCiud);
            this.grb_AltasCiud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_AltasCiud.Location = new System.Drawing.Point(12, 62);
            this.grb_AltasCiud.Name = "grb_AltasCiud";
            this.grb_AltasCiud.Size = new System.Drawing.Size(321, 232);
            this.grb_AltasCiud.TabIndex = 0;
            this.grb_AltasCiud.TabStop = false;
            this.grb_AltasCiud.Text = "Datos de la ciudad";
            // 
            // txt_IdEstado
            // 
            this.txt_IdEstado.Location = new System.Drawing.Point(6, 188);
            this.txt_IdEstado.Multiline = true;
            this.txt_IdEstado.Name = "txt_IdEstado";
            this.txt_IdEstado.Size = new System.Drawing.Size(294, 27);
            this.txt_IdEstado.TabIndex = 5;
            // 
            // lbl_IdEstado
            // 
            this.lbl_IdEstado.AutoSize = true;
            this.lbl_IdEstado.Location = new System.Drawing.Point(10, 167);
            this.lbl_IdEstado.Name = "lbl_IdEstado";
            this.lbl_IdEstado.Size = new System.Drawing.Size(73, 18);
            this.lbl_IdEstado.TabIndex = 4;
            this.lbl_IdEstado.Text = "ID Estado";
            // 
            // txt_NomCiud
            // 
            this.txt_NomCiud.Location = new System.Drawing.Point(6, 129);
            this.txt_NomCiud.Multiline = true;
            this.txt_NomCiud.Name = "txt_NomCiud";
            this.txt_NomCiud.Size = new System.Drawing.Size(294, 27);
            this.txt_NomCiud.TabIndex = 3;
            // 
            // txt_IdCiud
            // 
            this.txt_IdCiud.Location = new System.Drawing.Point(6, 57);
            this.txt_IdCiud.Multiline = true;
            this.txt_IdCiud.Name = "txt_IdCiud";
            this.txt_IdCiud.Size = new System.Drawing.Size(294, 24);
            this.txt_IdCiud.TabIndex = 2;
            // 
            // lbl_NomCiud
            // 
            this.lbl_NomCiud.AutoSize = true;
            this.lbl_NomCiud.Location = new System.Drawing.Point(10, 108);
            this.lbl_NomCiud.Name = "lbl_NomCiud";
            this.lbl_NomCiud.Size = new System.Drawing.Size(112, 18);
            this.lbl_NomCiud.TabIndex = 1;
            this.lbl_NomCiud.Text = "Nombre Ciudad";
            // 
            // lbl_IdCiud
            // 
            this.lbl_IdCiud.AutoSize = true;
            this.lbl_IdCiud.Location = new System.Drawing.Point(7, 36);
            this.lbl_IdCiud.Name = "lbl_IdCiud";
            this.lbl_IdCiud.Size = new System.Drawing.Size(72, 18);
            this.lbl_IdCiud.TabIndex = 0;
            this.lbl_IdCiud.Text = "ID Ciudad";
            // 
            // grb_Acciones
            // 
            this.grb_Acciones.Controls.Add(this.btn_Guardar);
            this.grb_Acciones.Controls.Add(this.btn_Eliminar);
            this.grb_Acciones.Controls.Add(this.btn_Modificar);
            this.grb_Acciones.Controls.Add(this.btn_Agregar);
            this.grb_Acciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Acciones.Location = new System.Drawing.Point(366, 62);
            this.grb_Acciones.Name = "grb_Acciones";
            this.grb_Acciones.Size = new System.Drawing.Size(204, 232);
            this.grb_Acciones.TabIndex = 1;
            this.grb_Acciones.TabStop = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(20, 121);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(167, 40);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(20, 167);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(167, 40);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(20, 71);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(167, 40);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(20, 25);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(167, 40);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dgt_Ciudad
            // 
            this.dgt_Ciudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_Ciudad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Ciudad,
            this.Nombre_Ciudad,
            this.Id_Estado});
            this.dgt_Ciudad.Location = new System.Drawing.Point(12, 364);
            this.dgt_Ciudad.Name = "dgt_Ciudad";
            this.dgt_Ciudad.Size = new System.Drawing.Size(557, 130);
            this.dgt_Ciudad.TabIndex = 2;
            // 
            // Id_Ciudad
            // 
            this.Id_Ciudad.HeaderText = "ID";
            this.Id_Ciudad.Name = "Id_Ciudad";
            // 
            // Nombre_Ciudad
            // 
            this.Nombre_Ciudad.HeaderText = "Nombre";
            this.Nombre_Ciudad.Name = "Nombre_Ciudad";
            // 
            // Id_Estado
            // 
            this.Id_Estado.HeaderText = "ID Estado";
            this.Id_Estado.Name = "Id_Estado";
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filtro.Location = new System.Drawing.Point(12, 297);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(41, 18);
            this.lbl_Filtro.TabIndex = 3;
            this.lbl_Filtro.Text = "Filtro";
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(12, 327);
            this.txt_Filtro.Multiline = true;
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(321, 21);
            this.txt_Filtro.TabIndex = 4;
            // 
            // pic_Titulo
            // 
            this.pic_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pic_Titulo.Location = new System.Drawing.Point(-1, 1);
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
            this.btn_Salir.Location = new System.Drawing.Point(482, 1);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(87, 42);
            this.btn_Salir.TabIndex = 24;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_CatCiud
            // 
            this.lbl_CatCiud.AutoSize = true;
            this.lbl_CatCiud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbl_CatCiud.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbl_CatCiud.ForeColor = System.Drawing.Color.White;
            this.lbl_CatCiud.Location = new System.Drawing.Point(15, 13);
            this.lbl_CatCiud.Name = "lbl_CatCiud";
            this.lbl_CatCiud.Size = new System.Drawing.Size(168, 21);
            this.lbl_CatCiud.TabIndex = 25;
            this.lbl_CatCiud.Text = "Catálogo de Ciudades";
            // 
            // frm_CiudadGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(582, 506);
            this.Controls.Add(this.lbl_CatCiud);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.pic_Titulo);
            this.Controls.Add(this.txt_Filtro);
            this.Controls.Add(this.lbl_Filtro);
            this.Controls.Add(this.dgt_Ciudad);
            this.Controls.Add(this.grb_Acciones);
            this.Controls.Add(this.grb_AltasCiud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CiudadGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grb_AltasCiud.ResumeLayout(false);
            this.grb_AltasCiud.PerformLayout();
            this.grb_Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Ciudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grb_AltasCiud;
        private System.Windows.Forms.GroupBox grb_Acciones;
        private System.Windows.Forms.DataGridView dgt_Ciudad;
        private System.Windows.Forms.TextBox txt_NomCiud;
        private System.Windows.Forms.TextBox txt_IdCiud;
        private System.Windows.Forms.Label lbl_NomCiud;
        private System.Windows.Forms.Label lbl_IdCiud;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.TextBox txt_Filtro;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.PictureBox pic_Titulo;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Estado;
        private System.Windows.Forms.Label lbl_CatCiud;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_IdEstado;
        private System.Windows.Forms.Label lbl_IdEstado;
    }
}
namespace ProyectoIntegrador.GUI
{
    partial class frm_PaisGUI
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
            this.grb_Pais = new System.Windows.Forms.GroupBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_NombrePais = new System.Windows.Forms.TextBox();
            this.txt_IdPais = new System.Windows.Forms.TextBox();
            this.lbl_IdPais = new System.Windows.Forms.Label();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dgt_Vista = new System.Windows.Forms.DataGridView();
            this.grb_Pais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Vista)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Pais
            // 
            this.grb_Pais.Controls.Add(this.lbl_Nombre);
            this.grb_Pais.Controls.Add(this.txt_NombrePais);
            this.grb_Pais.Controls.Add(this.txt_IdPais);
            this.grb_Pais.Controls.Add(this.lbl_IdPais);
            this.grb_Pais.Location = new System.Drawing.Point(20, 18);
            this.grb_Pais.Margin = new System.Windows.Forms.Padding(4);
            this.grb_Pais.Name = "grb_Pais";
            this.grb_Pais.Padding = new System.Windows.Forms.Padding(4);
            this.grb_Pais.Size = new System.Drawing.Size(306, 132);
            this.grb_Pais.TabIndex = 0;
            this.grb_Pais.TabStop = false;
            this.grb_Pais.Text = "Datos Pais";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(9, 75);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(95, 18);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre Pais";
            // 
            // txt_NombrePais
            // 
            this.txt_NombrePais.Location = new System.Drawing.Point(118, 75);
            this.txt_NombrePais.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombrePais.Name = "txt_NombrePais";
            this.txt_NombrePais.Size = new System.Drawing.Size(148, 24);
            this.txt_NombrePais.TabIndex = 2;
            // 
            // txt_IdPais
            // 
            this.txt_IdPais.Enabled = false;
            this.txt_IdPais.Location = new System.Drawing.Point(118, 33);
            this.txt_IdPais.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdPais.Name = "txt_IdPais";
            this.txt_IdPais.Size = new System.Drawing.Size(148, 24);
            this.txt_IdPais.TabIndex = 1;
            // 
            // lbl_IdPais
            // 
            this.lbl_IdPais.AutoSize = true;
            this.lbl_IdPais.Location = new System.Drawing.Point(69, 37);
            this.lbl_IdPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdPais.Name = "lbl_IdPais";
            this.lbl_IdPais.Size = new System.Drawing.Size(19, 18);
            this.lbl_IdPais.TabIndex = 0;
            this.lbl_IdPais.Text = "Id";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(48, 163);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(105, 38);
            this.btn_Nuevo.TabIndex = 1;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(181, 163);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(105, 38);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(48, 207);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(105, 38);
            this.btn_Actualizar.TabIndex = 3;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(181, 208);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(105, 37);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // dgt_Vista
            // 
            this.dgt_Vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_Vista.Location = new System.Drawing.Point(12, 261);
            this.dgt_Vista.Name = "dgt_Vista";
            this.dgt_Vista.Size = new System.Drawing.Size(314, 156);
            this.dgt_Vista.TabIndex = 5;
            this.dgt_Vista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgt_Vista_CellClick);
            // 
            // frm_PaisGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 429);
            this.Controls.Add(this.dgt_Vista);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.grb_Pais);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_PaisGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PaisGUI";
            this.Load += new System.EventHandler(this.frm_PaisGUI_Load);
            this.grb_Pais.ResumeLayout(false);
            this.grb_Pais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Vista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Pais;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_NombrePais;
        private System.Windows.Forms.TextBox txt_IdPais;
        private System.Windows.Forms.Label lbl_IdPais;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DataGridView dgt_Vista;
    }
}
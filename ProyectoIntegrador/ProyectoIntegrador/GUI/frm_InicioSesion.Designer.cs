namespace ProyectoIntegrador
{
    partial class frm_InicioSecionGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InicioSecionGUI));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_Titulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(109, 20);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Inicio de sesion";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_Usuario.Location = new System.Drawing.Point(112, 67);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(60, 20);
            this.lbl_Usuario.TabIndex = 3;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(110, 90);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(146, 20);
            this.txt_Usuario.TabIndex = 4;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(110, 141);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(146, 20);
            this.txt_Contraseña.TabIndex = 5;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contraseña.ForeColor = System.Drawing.Color.Black;
            this.lbl_Contraseña.Location = new System.Drawing.Point(112, 120);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(85, 20);
            this.lbl_Contraseña.TabIndex = 6;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_normalMenuPrin;
            this.btn_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Iniciar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar.ForeColor = System.Drawing.Color.Black;
            this.btn_Iniciar.Location = new System.Drawing.Point(121, 174);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(113, 33);
            this.btn_Iniciar.TabIndex = 7;
            this.btn_Iniciar.Text = "Iniciar Sesion";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = global::ProyectoIntegrador.Properties.Resources.ic_clear_black_36dp;
            this.btn_Salir.Location = new System.Drawing.Point(223, 5);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(58, 30);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pic_Titulo
            // 
            this.pic_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pic_Titulo.Location = new System.Drawing.Point(-1, 0);
            this.pic_Titulo.Name = "pic_Titulo";
            this.pic_Titulo.Size = new System.Drawing.Size(286, 39);
            this.pic_Titulo.TabIndex = 0;
            this.pic_Titulo.TabStop = false;
            // 
            // frm_InicioSecionGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(285, 222);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pic_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_InicioSecionGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Titulo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Button btn_Salir;
    }
}


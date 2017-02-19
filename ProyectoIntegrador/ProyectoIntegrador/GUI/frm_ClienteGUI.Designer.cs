namespace ProyectoIntegrador.GUI
{
    partial class frm_ClienteGUI
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
            this.lbl_IDCliente = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_RFC = new System.Windows.Forms.Label();
            this.txt_IDCliente = new System.Windows.Forms.TextBox();
            this.txt_RFC = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.grb_Datos = new System.Windows.Forms.GroupBox();
            this.grb_DatosDireccion = new System.Windows.Forms.GroupBox();
            this.txt_CodPost = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Cancelar = new System.Windows.Forms.Label();
            this.txt_Colonia = new System.Windows.Forms.TextBox();
            this.txt_Cruzamientos = new System.Windows.Forms.TextBox();
            this.lbl_Colonia = new System.Windows.Forms.Label();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_Cruzamientos = new System.Windows.Forms.Label();
            this.txt_Calle = new System.Windows.Forms.TextBox();
            this.lbl_Calle = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.dgt_Clientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.grb_Acciones = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pic_Titulo = new System.Windows.Forms.PictureBox();
            this.grb_Datos.SuspendLayout();
            this.grb_DatosDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Clientes)).BeginInit();
            this.grb_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_IDCliente
            // 
            this.lbl_IDCliente.AutoSize = true;
            this.lbl_IDCliente.Location = new System.Drawing.Point(51, 28);
            this.lbl_IDCliente.Name = "lbl_IDCliente";
            this.lbl_IDCliente.Size = new System.Drawing.Size(18, 13);
            this.lbl_IDCliente.TabIndex = 0;
            this.lbl_IDCliente.Text = "ID";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(51, 67);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(212, 67);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido.TabIndex = 3;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_RFC
            // 
            this.lbl_RFC.AutoSize = true;
            this.lbl_RFC.Location = new System.Drawing.Point(212, 28);
            this.lbl_RFC.Name = "lbl_RFC";
            this.lbl_RFC.Size = new System.Drawing.Size(28, 13);
            this.lbl_RFC.TabIndex = 4;
            this.lbl_RFC.Text = "RFC";
            // 
            // txt_IDCliente
            // 
            this.txt_IDCliente.Location = new System.Drawing.Point(54, 44);
            this.txt_IDCliente.Name = "txt_IDCliente";
            this.txt_IDCliente.Size = new System.Drawing.Size(135, 20);
            this.txt_IDCliente.TabIndex = 6;
            this.txt_IDCliente.Text = " ";
            // 
            // txt_RFC
            // 
            this.txt_RFC.Location = new System.Drawing.Point(215, 44);
            this.txt_RFC.Name = "txt_RFC";
            this.txt_RFC.Size = new System.Drawing.Size(135, 20);
            this.txt_RFC.TabIndex = 7;
            this.txt_RFC.Text = " ";
            this.txt_RFC.TextChanged += new System.EventHandler(this.txt_RFC_TextChanged);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(54, 83);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(135, 20);
            this.txt_Nombre.TabIndex = 8;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(215, 83);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(135, 20);
            this.txt_Apellido.TabIndex = 11;
            // 
            // grb_Datos
            // 
            this.grb_Datos.Controls.Add(this.txt_IDCliente);
            this.grb_Datos.Controls.Add(this.grb_DatosDireccion);
            this.grb_Datos.Controls.Add(this.txt_Telefono);
            this.grb_Datos.Controls.Add(this.txt_Apellido);
            this.grb_Datos.Controls.Add(this.lbl_Telefono);
            this.grb_Datos.Controls.Add(this.lbl_IDCliente);
            this.grb_Datos.Controls.Add(this.lbl_RFC);
            this.grb_Datos.Controls.Add(this.txt_Nombre);
            this.grb_Datos.Controls.Add(this.txt_RFC);
            this.grb_Datos.Controls.Add(this.lbl_Apellido);
            this.grb_Datos.Controls.Add(this.lbl_Nombre);
            this.grb_Datos.Location = new System.Drawing.Point(21, 45);
            this.grb_Datos.Name = "grb_Datos";
            this.grb_Datos.Size = new System.Drawing.Size(415, 269);
            this.grb_Datos.TabIndex = 12;
            this.grb_Datos.TabStop = false;
            this.grb_Datos.Text = "Datos";
            // 
            // grb_DatosDireccion
            // 
            this.grb_DatosDireccion.Controls.Add(this.txt_CodPost);
            this.grb_DatosDireccion.Controls.Add(this.lbl_Cancelar);
            this.grb_DatosDireccion.Controls.Add(this.txt_Colonia);
            this.grb_DatosDireccion.Controls.Add(this.txt_Cruzamientos);
            this.grb_DatosDireccion.Controls.Add(this.lbl_Colonia);
            this.grb_DatosDireccion.Controls.Add(this.txt_Num);
            this.grb_DatosDireccion.Controls.Add(this.lbl_Numero);
            this.grb_DatosDireccion.Controls.Add(this.lbl_Cruzamientos);
            this.grb_DatosDireccion.Controls.Add(this.txt_Calle);
            this.grb_DatosDireccion.Controls.Add(this.lbl_Calle);
            this.grb_DatosDireccion.Location = new System.Drawing.Point(17, 157);
            this.grb_DatosDireccion.Name = "grb_DatosDireccion";
            this.grb_DatosDireccion.Size = new System.Drawing.Size(390, 112);
            this.grb_DatosDireccion.TabIndex = 13;
            this.grb_DatosDireccion.TabStop = false;
            this.grb_DatosDireccion.Text = "Dirección";
            // 
            // txt_CodPost
            // 
            this.txt_CodPost.Location = new System.Drawing.Point(273, 82);
            this.txt_CodPost.Mask = "99999";
            this.txt_CodPost.Name = "txt_CodPost";
            this.txt_CodPost.Size = new System.Drawing.Size(83, 20);
            this.txt_CodPost.TabIndex = 20;
            this.txt_CodPost.ValidatingType = typeof(int);
            // 
            // lbl_Cancelar
            // 
            this.lbl_Cancelar.AutoSize = true;
            this.lbl_Cancelar.Location = new System.Drawing.Point(270, 66);
            this.lbl_Cancelar.Name = "lbl_Cancelar";
            this.lbl_Cancelar.Size = new System.Drawing.Size(61, 13);
            this.lbl_Cancelar.TabIndex = 16;
            this.lbl_Cancelar.Text = "Cod. Postal";
            // 
            // txt_Colonia
            // 
            this.txt_Colonia.Location = new System.Drawing.Point(25, 82);
            this.txt_Colonia.Name = "txt_Colonia";
            this.txt_Colonia.Size = new System.Drawing.Size(232, 20);
            this.txt_Colonia.TabIndex = 19;
            // 
            // txt_Cruzamientos
            // 
            this.txt_Cruzamientos.Location = new System.Drawing.Point(198, 43);
            this.txt_Cruzamientos.Name = "txt_Cruzamientos";
            this.txt_Cruzamientos.Size = new System.Drawing.Size(158, 20);
            this.txt_Cruzamientos.TabIndex = 18;
            // 
            // lbl_Colonia
            // 
            this.lbl_Colonia.AutoSize = true;
            this.lbl_Colonia.Location = new System.Drawing.Point(22, 66);
            this.lbl_Colonia.Name = "lbl_Colonia";
            this.lbl_Colonia.Size = new System.Drawing.Size(42, 13);
            this.lbl_Colonia.TabIndex = 15;
            this.lbl_Colonia.Text = "Colonia";
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(125, 43);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(62, 20);
            this.txt_Num.TabIndex = 17;
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(122, 27);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(19, 13);
            this.lbl_Numero.TabIndex = 3;
            this.lbl_Numero.Text = "N°";
            // 
            // lbl_Cruzamientos
            // 
            this.lbl_Cruzamientos.AutoSize = true;
            this.lbl_Cruzamientos.Location = new System.Drawing.Point(195, 27);
            this.lbl_Cruzamientos.Name = "lbl_Cruzamientos";
            this.lbl_Cruzamientos.Size = new System.Drawing.Size(70, 13);
            this.lbl_Cruzamientos.TabIndex = 14;
            this.lbl_Cruzamientos.Text = "Cruzamientos";
            // 
            // txt_Calle
            // 
            this.txt_Calle.Location = new System.Drawing.Point(25, 43);
            this.txt_Calle.Name = "txt_Calle";
            this.txt_Calle.Size = new System.Drawing.Size(79, 20);
            this.txt_Calle.TabIndex = 2;
            // 
            // lbl_Calle
            // 
            this.lbl_Calle.AutoSize = true;
            this.lbl_Calle.Location = new System.Drawing.Point(22, 27);
            this.lbl_Calle.Name = "lbl_Calle";
            this.lbl_Calle.Size = new System.Drawing.Size(30, 13);
            this.lbl_Calle.TabIndex = 0;
            this.lbl_Calle.Text = "Calle";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(54, 122);
            this.txt_Telefono.Mask = "(999)000-0000";
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(135, 20);
            this.txt_Telefono.TabIndex = 10;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(51, 106);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefono.TabIndex = 2;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // dgt_Clientes
            // 
            this.dgt_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellidos,
            this.Telefono,
            this.Direccion});
            this.dgt_Clientes.Location = new System.Drawing.Point(12, 320);
            this.dgt_Clientes.Name = "dgt_Clientes";
            this.dgt_Clientes.Size = new System.Drawing.Size(556, 132);
            this.dgt_Clientes.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellido";
            this.Apellidos.Name = "Apellidos";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(17, 9);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(157, 21);
            this.lbl_Titulo.TabIndex = 16;
            this.lbl_Titulo.Text = "Catalogo de Clientes";
            // 
            // grb_Acciones
            // 
            this.grb_Acciones.Controls.Add(this.btn_Buscar);
            this.grb_Acciones.Controls.Add(this.btn_Eliminar);
            this.grb_Acciones.Controls.Add(this.btn_Modificar);
            this.grb_Acciones.Controls.Add(this.btn_Agregar);
            this.grb_Acciones.Location = new System.Drawing.Point(443, 46);
            this.grb_Acciones.Name = "grb_Acciones";
            this.grb_Acciones.Size = new System.Drawing.Size(125, 268);
            this.grb_Acciones.TabIndex = 17;
            this.grb_Acciones.TabStop = false;
            this.grb_Acciones.Text = "Acciones";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(6, 19);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(112, 36);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(6, 160);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(112, 36);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(7, 112);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(112, 36);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(7, 66);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(112, 36);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = " Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = global::ProyectoIntegrador.Properties.Resources.ic_clear_black_36dp;
            this.btn_Salir.Location = new System.Drawing.Point(514, 3);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(58, 30);
            this.btn_Salir.TabIndex = 19;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pic_Titulo
            // 
            this.pic_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pic_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pic_Titulo.Name = "pic_Titulo";
            this.pic_Titulo.Size = new System.Drawing.Size(580, 39);
            this.pic_Titulo.TabIndex = 15;
            this.pic_Titulo.TabStop = false;
            // 
            // frm_ClienteGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(580, 464);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.grb_Acciones);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pic_Titulo);
            this.Controls.Add(this.dgt_Clientes);
            this.Controls.Add(this.grb_Datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ClienteGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.grb_Datos.ResumeLayout(false);
            this.grb_Datos.PerformLayout();
            this.grb_DatosDireccion.ResumeLayout(false);
            this.grb_DatosDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Clientes)).EndInit();
            this.grb_Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IDCliente;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_RFC;
        private System.Windows.Forms.TextBox txt_IDCliente;
        private System.Windows.Forms.TextBox txt_RFC;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.GroupBox grb_Datos;
        private System.Windows.Forms.MaskedTextBox txt_Telefono;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.DataGridView dgt_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.GroupBox grb_DatosDireccion;
        private System.Windows.Forms.MaskedTextBox txt_CodPost;
        private System.Windows.Forms.Label lbl_Cancelar;
        private System.Windows.Forms.TextBox txt_Colonia;
        private System.Windows.Forms.TextBox txt_Cruzamientos;
        private System.Windows.Forms.Label lbl_Colonia;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label lbl_Cruzamientos;
        private System.Windows.Forms.TextBox txt_Calle;
        private System.Windows.Forms.Label lbl_Calle;
        private System.Windows.Forms.PictureBox pic_Titulo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.GroupBox grb_Acciones;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Salir;
    }
}
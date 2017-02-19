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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_Curp = new System.Windows.Forms.Label();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.grb_DatosPersonales = new System.Windows.Forms.GroupBox();
            this.txt_Curp = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.grb_Direccion = new System.Windows.Forms.GroupBox();
            this.txt_CodigoP = new System.Windows.Forms.TextBox();
            this.txt_Colonia = new System.Windows.Forms.TextBox();
            this.txt_NumExterior = new System.Windows.Forms.TextBox();
            this.txt_Cruzamientos = new System.Windows.Forms.TextBox();
            this.txt_Calle = new System.Windows.Forms.TextBox();
            this.lbl_Colonia = new System.Windows.Forms.Label();
            this.lbl_CodigoPostal = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_Cruzamientos = new System.Windows.Forms.Label();
            this.lbl_Calle = new System.Windows.Forms.Label();
            this.grb_DatosEmpleado = new System.Windows.Forms.GroupBox();
            this.txt_Puesto = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_NomUsuario = new System.Windows.Forms.TextBox();
            this.lbl_Puesto = new System.Windows.Forms.Label();
            this.grb_Acciones = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.dgt_Usuarios = new System.Windows.Forms.DataGridView();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pic_Titulo = new System.Windows.Forms.PictureBox();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurpUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_DatosPersonales.SuspendLayout();
            this.grb_Direccion.SuspendLayout();
            this.grb_DatosEmpleado.SuspendLayout();
            this.grb_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(8, 35);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(57, 16);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(280, 35);
            this.lbl_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(58, 16);
            this.lbl_Apellido.TabIndex = 1;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(8, 93);
            this.lbl_telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(62, 16);
            this.lbl_telefono.TabIndex = 2;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // lbl_Curp
            // 
            this.lbl_Curp.AutoSize = true;
            this.lbl_Curp.Location = new System.Drawing.Point(300, 87);
            this.lbl_Curp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Curp.Name = "lbl_Curp";
            this.lbl_Curp.Size = new System.Drawing.Size(36, 16);
            this.lbl_Curp.TabIndex = 3;
            this.lbl_Curp.Text = "Curp";
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(9, 31);
            this.lbl_NombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(126, 16);
            this.lbl_NombreUsuario.TabIndex = 4;
            this.lbl_NombreUsuario.Text = "Nombre de Usuario";
            // 
            // grb_DatosPersonales
            // 
            this.grb_DatosPersonales.Controls.Add(this.txt_Curp);
            this.grb_DatosPersonales.Controls.Add(this.txt_telefono);
            this.grb_DatosPersonales.Controls.Add(this.txt_Apellido);
            this.grb_DatosPersonales.Controls.Add(this.txt_Nombre);
            this.grb_DatosPersonales.Controls.Add(this.lbl_telefono);
            this.grb_DatosPersonales.Controls.Add(this.lbl_Apellido);
            this.grb_DatosPersonales.Controls.Add(this.lbl_Curp);
            this.grb_DatosPersonales.Controls.Add(this.lbl_Nombre);
            this.grb_DatosPersonales.Location = new System.Drawing.Point(24, 171);
            this.grb_DatosPersonales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_DatosPersonales.Name = "grb_DatosPersonales";
            this.grb_DatosPersonales.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_DatosPersonales.Size = new System.Drawing.Size(680, 149);
            this.grb_DatosPersonales.TabIndex = 5;
            this.grb_DatosPersonales.TabStop = false;
            this.grb_DatosPersonales.Text = "Datos Personales";
            // 
            // txt_Curp
            // 
            this.txt_Curp.Location = new System.Drawing.Point(284, 115);
            this.txt_Curp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Curp.Name = "txt_Curp";
            this.txt_Curp.Size = new System.Drawing.Size(214, 22);
            this.txt_Curp.TabIndex = 7;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(12, 115);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(244, 22);
            this.txt_telefono.TabIndex = 6;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(284, 55);
            this.txt_Apellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(214, 22);
            this.txt_Apellido.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(12, 55);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(244, 22);
            this.txt_Nombre.TabIndex = 4;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(328, 31);
            this.lbl_Contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(77, 16);
            this.lbl_Contraseña.TabIndex = 5;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // grb_Direccion
            // 
            this.grb_Direccion.Controls.Add(this.txt_CodigoP);
            this.grb_Direccion.Controls.Add(this.txt_Colonia);
            this.grb_Direccion.Controls.Add(this.txt_NumExterior);
            this.grb_Direccion.Controls.Add(this.txt_Cruzamientos);
            this.grb_Direccion.Controls.Add(this.txt_Calle);
            this.grb_Direccion.Controls.Add(this.lbl_Colonia);
            this.grb_Direccion.Controls.Add(this.lbl_CodigoPostal);
            this.grb_Direccion.Controls.Add(this.lbl_Numero);
            this.grb_Direccion.Controls.Add(this.lbl_Cruzamientos);
            this.grb_Direccion.Controls.Add(this.lbl_Calle);
            this.grb_Direccion.Location = new System.Drawing.Point(24, 342);
            this.grb_Direccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_Direccion.Name = "grb_Direccion";
            this.grb_Direccion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_Direccion.Size = new System.Drawing.Size(680, 151);
            this.grb_Direccion.TabIndex = 7;
            this.grb_Direccion.TabStop = false;
            this.grb_Direccion.Text = "Dirección";
            // 
            // txt_CodigoP
            // 
            this.txt_CodigoP.Location = new System.Drawing.Point(332, 108);
            this.txt_CodigoP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CodigoP.Name = "txt_CodigoP";
            this.txt_CodigoP.Size = new System.Drawing.Size(146, 22);
            this.txt_CodigoP.TabIndex = 14;
            // 
            // txt_Colonia
            // 
            this.txt_Colonia.Location = new System.Drawing.Point(14, 108);
            this.txt_Colonia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Colonia.Name = "txt_Colonia";
            this.txt_Colonia.Size = new System.Drawing.Size(284, 22);
            this.txt_Colonia.TabIndex = 13;
            // 
            // txt_NumExterior
            // 
            this.txt_NumExterior.Location = new System.Drawing.Point(130, 57);
            this.txt_NumExterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NumExterior.Name = "txt_NumExterior";
            this.txt_NumExterior.Size = new System.Drawing.Size(127, 22);
            this.txt_NumExterior.TabIndex = 12;
            // 
            // txt_Cruzamientos
            // 
            this.txt_Cruzamientos.Location = new System.Drawing.Point(265, 57);
            this.txt_Cruzamientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Cruzamientos.Name = "txt_Cruzamientos";
            this.txt_Cruzamientos.Size = new System.Drawing.Size(214, 22);
            this.txt_Cruzamientos.TabIndex = 11;
            // 
            // txt_Calle
            // 
            this.txt_Calle.Location = new System.Drawing.Point(12, 57);
            this.txt_Calle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Calle.Name = "txt_Calle";
            this.txt_Calle.Size = new System.Drawing.Size(104, 22);
            this.txt_Calle.TabIndex = 10;
            // 
            // lbl_Colonia
            // 
            this.lbl_Colonia.AutoSize = true;
            this.lbl_Colonia.Location = new System.Drawing.Point(11, 85);
            this.lbl_Colonia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Colonia.Name = "lbl_Colonia";
            this.lbl_Colonia.Size = new System.Drawing.Size(54, 16);
            this.lbl_Colonia.TabIndex = 9;
            this.lbl_Colonia.Text = "Colonia";
            // 
            // lbl_CodigoPostal
            // 
            this.lbl_CodigoPostal.AutoSize = true;
            this.lbl_CodigoPostal.Location = new System.Drawing.Point(328, 85);
            this.lbl_CodigoPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CodigoPostal.Name = "lbl_CodigoPostal";
            this.lbl_CodigoPostal.Size = new System.Drawing.Size(93, 16);
            this.lbl_CodigoPostal.TabIndex = 8;
            this.lbl_CodigoPostal.Text = "Código Postal";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(125, 29);
            this.lbl_Numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(104, 16);
            this.lbl_Numero.TabIndex = 7;
            this.lbl_Numero.Text = "Número Exterior";
            // 
            // lbl_Cruzamientos
            // 
            this.lbl_Cruzamientos.AutoSize = true;
            this.lbl_Cruzamientos.Location = new System.Drawing.Point(261, 33);
            this.lbl_Cruzamientos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cruzamientos.Name = "lbl_Cruzamientos";
            this.lbl_Cruzamientos.Size = new System.Drawing.Size(89, 16);
            this.lbl_Cruzamientos.TabIndex = 6;
            this.lbl_Cruzamientos.Text = "Cruzamientos";
            // 
            // lbl_Calle
            // 
            this.lbl_Calle.AutoSize = true;
            this.lbl_Calle.Location = new System.Drawing.Point(8, 33);
            this.lbl_Calle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Calle.Name = "lbl_Calle";
            this.lbl_Calle.Size = new System.Drawing.Size(39, 16);
            this.lbl_Calle.TabIndex = 5;
            this.lbl_Calle.Text = "Calle";
            // 
            // grb_DatosEmpleado
            // 
            this.grb_DatosEmpleado.Controls.Add(this.txt_Puesto);
            this.grb_DatosEmpleado.Controls.Add(this.txt_Contraseña);
            this.grb_DatosEmpleado.Controls.Add(this.txt_NomUsuario);
            this.grb_DatosEmpleado.Controls.Add(this.lbl_Puesto);
            this.grb_DatosEmpleado.Controls.Add(this.lbl_Contraseña);
            this.grb_DatosEmpleado.Controls.Add(this.lbl_NombreUsuario);
            this.grb_DatosEmpleado.Location = new System.Drawing.Point(24, 58);
            this.grb_DatosEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_DatosEmpleado.Name = "grb_DatosEmpleado";
            this.grb_DatosEmpleado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_DatosEmpleado.Size = new System.Drawing.Size(888, 106);
            this.grb_DatosEmpleado.TabIndex = 8;
            this.grb_DatosEmpleado.TabStop = false;
            this.grb_DatosEmpleado.Text = "Datos  de Empleado";
            // 
            // txt_Puesto
            // 
            this.txt_Puesto.Location = new System.Drawing.Point(605, 51);
            this.txt_Puesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Puesto.Name = "txt_Puesto";
            this.txt_Puesto.Size = new System.Drawing.Size(241, 22);
            this.txt_Puesto.TabIndex = 9;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(332, 51);
            this.txt_Contraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(214, 22);
            this.txt_Contraseña.TabIndex = 8;
            // 
            // txt_NomUsuario
            // 
            this.txt_NomUsuario.Location = new System.Drawing.Point(8, 51);
            this.txt_NomUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NomUsuario.Name = "txt_NomUsuario";
            this.txt_NomUsuario.Size = new System.Drawing.Size(241, 22);
            this.txt_NomUsuario.TabIndex = 7;
            // 
            // lbl_Puesto
            // 
            this.lbl_Puesto.AutoSize = true;
            this.lbl_Puesto.Location = new System.Drawing.Point(613, 31);
            this.lbl_Puesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Puesto.Name = "lbl_Puesto";
            this.lbl_Puesto.Size = new System.Drawing.Size(50, 16);
            this.lbl_Puesto.TabIndex = 6;
            this.lbl_Puesto.Text = "Puesto";
            // 
            // grb_Acciones
            // 
            this.grb_Acciones.Controls.Add(this.btn_Buscar);
            this.grb_Acciones.Controls.Add(this.btn_Eliminar);
            this.grb_Acciones.Controls.Add(this.btn_Modificar);
            this.grb_Acciones.Controls.Add(this.btn_Guardar);
            this.grb_Acciones.Location = new System.Drawing.Point(712, 171);
            this.grb_Acciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_Acciones.Name = "grb_Acciones";
            this.grb_Acciones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_Acciones.Size = new System.Drawing.Size(200, 321);
            this.grb_Acciones.TabIndex = 9;
            this.grb_Acciones.TabStop = false;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(30, 23);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(146, 64);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(30, 241);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(146, 64);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(30, 100);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(146, 64);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(30, 171);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(146, 63);
            this.btn_Guardar.TabIndex = 0;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // dgt_Usuarios
            // 
            this.dgt_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreUsuario,
            this.NombreEmpleado,
            this.ApellidoUsuario,
            this.TelefonoUsuario,
            this.CurpUsuario,
            this.DireccionUsuario});
            this.dgt_Usuarios.Location = new System.Drawing.Point(32, 502);
            this.dgt_Usuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgt_Usuarios.Name = "dgt_Usuarios";
            this.dgt_Usuarios.Size = new System.Drawing.Size(880, 185);
            this.dgt_Usuarios.TabIndex = 10;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = global::ProyectoIntegrador.Properties.Resources.ic_clear_black_36dp;
            this.btn_Salir.Location = new System.Drawing.Point(874, 3);
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
            this.pic_Titulo.Size = new System.Drawing.Size(967, 50);
            this.pic_Titulo.TabIndex = 23;
            this.pic_Titulo.TabStop = false;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "NombreUsuario";
            this.NombreUsuario.Name = "NombreUsuario";
            // 
            // NombreEmpleado
            // 
            this.NombreEmpleado.HeaderText = "Nombre";
            this.NombreEmpleado.Name = "NombreEmpleado";
            // 
            // ApellidoUsuario
            // 
            this.ApellidoUsuario.HeaderText = "Apellido";
            this.ApellidoUsuario.Name = "ApellidoUsuario";
            // 
            // TelefonoUsuario
            // 
            this.TelefonoUsuario.HeaderText = "Telefono";
            this.TelefonoUsuario.Name = "TelefonoUsuario";
            // 
            // CurpUsuario
            // 
            this.CurpUsuario.HeaderText = "CURP";
            this.CurpUsuario.Name = "CurpUsuario";
            // 
            // DireccionUsuario
            // 
            this.DireccionUsuario.HeaderText = "Direccion";
            this.DireccionUsuario.Name = "DireccionUsuario";
            // 
            // frm_UsuariosGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(963, 707);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pic_Titulo);
            this.Controls.Add(this.dgt_Usuarios);
            this.Controls.Add(this.grb_Acciones);
            this.Controls.Add(this.grb_DatosEmpleado);
            this.Controls.Add(this.grb_Direccion);
            this.Controls.Add(this.grb_DatosPersonales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UsuariosGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grb_DatosPersonales.ResumeLayout(false);
            this.grb_DatosPersonales.PerformLayout();
            this.grb_Direccion.ResumeLayout(false);
            this.grb_Direccion.PerformLayout();
            this.grb_DatosEmpleado.ResumeLayout(false);
            this.grb_DatosEmpleado.PerformLayout();
            this.grb_Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_Curp;
        private System.Windows.Forms.Label lbl_NombreUsuario;
        private System.Windows.Forms.GroupBox grb_DatosPersonales;
        private System.Windows.Forms.TextBox txt_Curp;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.GroupBox grb_Direccion;
        private System.Windows.Forms.TextBox txt_CodigoP;
        private System.Windows.Forms.TextBox txt_Colonia;
        private System.Windows.Forms.TextBox txt_NumExterior;
        private System.Windows.Forms.TextBox txt_Cruzamientos;
        private System.Windows.Forms.TextBox txt_Calle;
        private System.Windows.Forms.Label lbl_Colonia;
        private System.Windows.Forms.Label lbl_CodigoPostal;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label lbl_Cruzamientos;
        private System.Windows.Forms.Label lbl_Calle;
        private System.Windows.Forms.GroupBox grb_DatosEmpleado;
        private System.Windows.Forms.TextBox txt_Puesto;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_NomUsuario;
        private System.Windows.Forms.Label lbl_Puesto;
        private System.Windows.Forms.GroupBox grb_Acciones;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView dgt_Usuarios;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pic_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurpUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionUsuario;
    }
}
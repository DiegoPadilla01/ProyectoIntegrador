namespace ProyectoIntegrador.GUI
{
    partial class frm_PuntodeVentaGUI
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pic_Titulo = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.txt_IVA = new System.Windows.Forms.TextBox();
            this.lbl_IVA = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.btn_Cobrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.TotalProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(33, 9);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(117, 21);
            this.lbl_Titulo.TabIndex = 21;
            this.lbl_Titulo.Text = "Punto de venta";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = global::ProyectoIntegrador.Properties.Resources.ic_clear_black_36dp;
            this.btn_Salir.Location = new System.Drawing.Point(480, 6);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(58, 30);
            this.btn_Salir.TabIndex = 22;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pic_Titulo
            // 
            this.pic_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pic_Titulo.Location = new System.Drawing.Point(-3, 0);
            this.pic_Titulo.Name = "pic_Titulo";
            this.pic_Titulo.Size = new System.Drawing.Size(795, 39);
            this.pic_Titulo.TabIndex = 20;
            this.pic_Titulo.TabStop = false;
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::ProyectoIntegrador.Properties.Resources._16819174_1018212081656487_2274408091286444770_o;
            this.pic_logo.Location = new System.Drawing.Point(37, 63);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(119, 93);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 23;
            this.pic_logo.TabStop = false;
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(179, 63);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(100, 13);
            this.lbl_Codigo.TabIndex = 24;
            this.lbl_Codigo.Text = "Codigo de producto";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(182, 80);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo.TabIndex = 25;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(182, 119);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(198, 20);
            this.txt_Nombre.TabIndex = 27;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(182, 103);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 26;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(397, 119);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(92, 20);
            this.txt_Precio.TabIndex = 29;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(397, 103);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(37, 13);
            this.lbl_Precio.TabIndex = 28;
            this.lbl_Precio.Text = "Precio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProd,
            this.NombreProd,
            this.PrecioProd,
            this.CantProd,
            this.TotalProd});
            this.dataGridView1.Location = new System.Drawing.Point(37, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // CodProd
            // 
            this.CodProd.HeaderText = "Codigo";
            this.CodProd.Name = "CodProd";
            // 
            // NombreProd
            // 
            this.NombreProd.HeaderText = "Nombre";
            this.NombreProd.Name = "NombreProd";
            // 
            // PrecioProd
            // 
            this.PrecioProd.HeaderText = "Precio";
            this.PrecioProd.Name = "PrecioProd";
            // 
            // CantProd
            // 
            this.CantProd.HeaderText = "Cantidad";
            this.CantProd.Name = "CantProd";
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.Location = new System.Drawing.Point(423, 334);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.Size = new System.Drawing.Size(92, 20);
            this.txt_Subtotal.TabIndex = 32;
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Location = new System.Drawing.Point(377, 337);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(46, 13);
            this.lbl_Subtotal.TabIndex = 31;
            this.lbl_Subtotal.Text = "Subtotal";
            // 
            // txt_IVA
            // 
            this.txt_IVA.Location = new System.Drawing.Point(423, 360);
            this.txt_IVA.Name = "txt_IVA";
            this.txt_IVA.Size = new System.Drawing.Size(92, 20);
            this.txt_IVA.TabIndex = 34;
            // 
            // lbl_IVA
            // 
            this.lbl_IVA.AutoSize = true;
            this.lbl_IVA.Location = new System.Drawing.Point(377, 363);
            this.lbl_IVA.Name = "lbl_IVA";
            this.lbl_IVA.Size = new System.Drawing.Size(24, 13);
            this.lbl_IVA.TabIndex = 33;
            this.lbl_IVA.Text = "IVA";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(423, 386);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(92, 20);
            this.txt_Total.TabIndex = 36;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(377, 389);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 35;
            this.Total.Text = "Total";
            // 
            // btn_Cobrar
            // 
            this.btn_Cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cobrar.Location = new System.Drawing.Point(150, 353);
            this.btn_Cobrar.Name = "btn_Cobrar";
            this.btn_Cobrar.Size = new System.Drawing.Size(85, 38);
            this.btn_Cobrar.TabIndex = 37;
            this.btn_Cobrar.Text = "Cobrar";
            this.btn_Cobrar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(238, 353);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(85, 38);
            this.btn_Cancelar.TabIndex = 38;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // TotalProd
            // 
            this.TotalProd.HeaderText = "Total";
            this.TotalProd.Name = "TotalProd";
            // 
            // frm_PuntodeVentaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(555, 454);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cobrar);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.txt_IVA);
            this.Controls.Add(this.lbl_IVA);
            this.Controls.Add(this.txt_Subtotal);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pic_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PuntodeVentaGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PuntodeVentaGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Titulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pic_Titulo;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantProd;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.TextBox txt_IVA;
        private System.Windows.Forms.Label lbl_IVA;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button btn_Cobrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProd;
    }
}
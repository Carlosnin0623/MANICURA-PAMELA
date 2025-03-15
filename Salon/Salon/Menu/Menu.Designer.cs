namespace Salon
{
    partial class Menu
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
            this.Contenedormenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnNomina = new System.Windows.Forms.Button();
            this.Minmenu = new System.Windows.Forms.PictureBox();
            this.Maxmenu = new System.Windows.Forms.PictureBox();
            this.btnGastosFijos = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Closemenu = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnfacturacion = new System.Windows.Forms.Button();
            this.btnRol = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Minmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maxmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closemenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 710);
            this.label1.TabIndex = 0;
            // 
            // Contenedormenu
            // 
            this.Contenedormenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contenedormenu.Location = new System.Drawing.Point(177, 12);
            this.Contenedormenu.Name = "Contenedormenu";
            this.Contenedormenu.Size = new System.Drawing.Size(1046, 698);
            this.Contenedormenu.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 145;
            this.label4.Text = "Admin";
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = global::Salon.Properties.Resources.producto;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(1, 239);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(176, 37);
            this.btnProductos.TabIndex = 151;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::Salon.Properties.Resources.icons8_clientes_23;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(1, 454);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(176, 37);
            this.btnUsuarios.TabIndex = 150;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnNomina
            // 
            this.btnNomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnNomina.FlatAppearance.BorderSize = 0;
            this.btnNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNomina.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNomina.ForeColor = System.Drawing.Color.White;
            this.btnNomina.Image = global::Salon.Properties.Resources.icons8_bolsa_de_dinero_22;
            this.btnNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNomina.Location = new System.Drawing.Point(1, 411);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Size = new System.Drawing.Size(176, 37);
            this.btnNomina.TabIndex = 149;
            this.btnNomina.Text = "Nomina";
            this.btnNomina.UseVisualStyleBackColor = false;
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click);
            // 
            // Minmenu
            // 
            this.Minmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minmenu.BackColor = System.Drawing.SystemColors.Control;
            this.Minmenu.Image = global::Salon.Properties.Resources.icons8_minimizar_23;
            this.Minmenu.Location = new System.Drawing.Point(1118, 6);
            this.Minmenu.Name = "Minmenu";
            this.Minmenu.Size = new System.Drawing.Size(28, 24);
            this.Minmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Minmenu.TabIndex = 145;
            this.Minmenu.TabStop = false;
            this.Minmenu.Click += new System.EventHandler(this.Minmenu_Click);
            // 
            // Maxmenu
            // 
            this.Maxmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maxmenu.BackColor = System.Drawing.SystemColors.Control;
            this.Maxmenu.Image = global::Salon.Properties.Resources.icons8_cuadrado_23;
            this.Maxmenu.Location = new System.Drawing.Point(1152, 6);
            this.Maxmenu.Name = "Maxmenu";
            this.Maxmenu.Size = new System.Drawing.Size(28, 24);
            this.Maxmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Maxmenu.TabIndex = 146;
            this.Maxmenu.TabStop = false;
            this.Maxmenu.Click += new System.EventHandler(this.Maxmenu_Click);
            // 
            // btnGastosFijos
            // 
            this.btnGastosFijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnGastosFijos.FlatAppearance.BorderSize = 0;
            this.btnGastosFijos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastosFijos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastosFijos.ForeColor = System.Drawing.Color.White;
            this.btnGastosFijos.Image = global::Salon.Properties.Resources.gastoFijos;
            this.btnGastosFijos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastosFijos.Location = new System.Drawing.Point(1, 368);
            this.btnGastosFijos.Name = "btnGastosFijos";
            this.btnGastosFijos.Size = new System.Drawing.Size(176, 37);
            this.btnGastosFijos.TabIndex = 148;
            this.btnGastosFijos.Text = "Gastos Fijos";
            this.btnGastosFijos.UseVisualStyleBackColor = false;
            this.btnGastosFijos.Click += new System.EventHandler(this.btnGastosFijos_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.Color.White;
            this.btnServicios.Image = global::Salon.Properties.Resources.icons8_trabajo_22;
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Location = new System.Drawing.Point(1, 196);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(176, 37);
            this.btnServicios.TabIndex = 147;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.pictureBox1.Image = global::Salon.Properties.Resources.icons8_usuario_masculino_en_círculo_26;
            this.pictureBox1.Location = new System.Drawing.Point(9, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 146;
            this.pictureBox1.TabStop = false;
            // 
            // Closemenu
            // 
            this.Closemenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closemenu.BackColor = System.Drawing.SystemColors.Control;
            this.Closemenu.Image = global::Salon.Properties.Resources.icons8_multiplicar_23;
            this.Closemenu.Location = new System.Drawing.Point(1186, 6);
            this.Closemenu.Name = "Closemenu";
            this.Closemenu.Size = new System.Drawing.Size(28, 24);
            this.Closemenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Closemenu.TabIndex = 144;
            this.Closemenu.TabStop = false;
            this.Closemenu.Click += new System.EventHandler(this.Closemenu_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Salon.Properties.Resources.icons8_tablero_23;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(1, 112);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(176, 37);
            this.btnDashboard.TabIndex = 11;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnfacturacion
            // 
            this.btnfacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnfacturacion.FlatAppearance.BorderSize = 0;
            this.btnfacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfacturacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacturacion.ForeColor = System.Drawing.Color.White;
            this.btnfacturacion.Image = global::Salon.Properties.Resources.icons8_receipt_dollar_24;
            this.btnfacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfacturacion.Location = new System.Drawing.Point(1, 282);
            this.btnfacturacion.Name = "btnfacturacion";
            this.btnfacturacion.Size = new System.Drawing.Size(176, 37);
            this.btnfacturacion.TabIndex = 8;
            this.btnfacturacion.Text = "Facturación";
            this.btnfacturacion.UseVisualStyleBackColor = false;
            this.btnfacturacion.Click += new System.EventHandler(this.btnfacturacion_Click);
            // 
            // btnRol
            // 
            this.btnRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnRol.FlatAppearance.BorderSize = 0;
            this.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRol.ForeColor = System.Drawing.Color.White;
            this.btnRol.Image = global::Salon.Properties.Resources.icons8_llave_22;
            this.btnRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRol.Location = new System.Drawing.Point(1, 325);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(176, 37);
            this.btnRol.TabIndex = 7;
            this.btnRol.Text = "Rol";
            this.btnRol.UseVisualStyleBackColor = false;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.Image = global::Salon.Properties.Resources.icons8_empleados_23;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(1, 155);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(176, 37);
            this.btnEmpleado.TabIndex = 6;
            this.btnEmpleado.Text = "Empleados";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1222, 710);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnNomina);
            this.Controls.Add(this.Minmenu);
            this.Controls.Add(this.Maxmenu);
            this.Controls.Add(this.btnGastosFijos);
            this.Controls.Add(this.btnServicios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Closemenu);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.Contenedormenu);
            this.Controls.Add(this.btnfacturacion);
            this.Controls.Add(this.btnRol);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Minmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maxmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closemenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Button btnfacturacion;
        private System.Windows.Forms.Panel Contenedormenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox Closemenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnGastosFijos;
        private System.Windows.Forms.Button btnNomina;
        private System.Windows.Forms.PictureBox Minmenu;
        private System.Windows.Forms.PictureBox Maxmenu;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnProductos;
    }
}


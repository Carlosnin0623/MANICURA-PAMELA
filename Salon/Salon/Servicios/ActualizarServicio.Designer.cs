namespace Salon.Servicios
{
    partial class ActualizarServicio
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Closeactserv = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidserv = new System.Windows.Forms.TextBox();
            this.txtnumestado = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbEstadoServ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioServicio = new DrakeUI.Framework.DrakeUITextBox();
            this.txtNombreServicio = new DrakeUI.Framework.DrakeUITextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnActualizarServicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Closeactserv)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(393, 43);
            this.label8.TabIndex = 232;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 233;
            this.label9.Text = "Actualizar servicios";
            // 
            // Closeactserv
            // 
            this.Closeactserv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closeactserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Closeactserv.Image = global::Salon.Properties.Resources.icons8_multiplicar_23__2_;
            this.Closeactserv.Location = new System.Drawing.Point(353, 12);
            this.Closeactserv.Name = "Closeactserv";
            this.Closeactserv.Size = new System.Drawing.Size(28, 24);
            this.Closeactserv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Closeactserv.TabIndex = 234;
            this.Closeactserv.TabStop = false;
            this.Closeactserv.Click += new System.EventHandler(this.Closeactserv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 235;
            this.label2.Text = "Nombre(*)";
            // 
            // txtidserv
            // 
            this.txtidserv.Location = new System.Drawing.Point(95, 66);
            this.txtidserv.Name = "txtidserv";
            this.txtidserv.Size = new System.Drawing.Size(45, 20);
            this.txtidserv.TabIndex = 270;
            this.txtidserv.Visible = false;
            // 
            // txtnumestado
            // 
            this.txtnumestado.Location = new System.Drawing.Point(75, 198);
            this.txtnumestado.Name = "txtnumestado";
            this.txtnumestado.Size = new System.Drawing.Size(45, 20);
            this.txtnumestado.TabIndex = 278;
            this.txtnumestado.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(24, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 17);
            this.label16.TabIndex = 277;
            this.label16.Text = "Estado";
            // 
            // cbEstadoServ
            // 
            this.cbEstadoServ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoServ.FormattingEnabled = true;
            this.cbEstadoServ.Items.AddRange(new object[] {
            "Activo",
            "No activo"});
            this.cbEstadoServ.Location = new System.Drawing.Point(27, 224);
            this.cbEstadoServ.Name = "cbEstadoServ";
            this.cbEstadoServ.Size = new System.Drawing.Size(271, 29);
            this.cbEstadoServ.TabIndex = 276;
            this.cbEstadoServ.SelectedIndexChanged += new System.EventHandler(this.cbEstadoServ_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 275;
            this.label1.Text = "Precio(*)";
            // 
            // txtPrecioServicio
            // 
            this.txtPrecioServicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioServicio.FillColor = System.Drawing.Color.White;
            this.txtPrecioServicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioServicio.Location = new System.Drawing.Point(27, 158);
            this.txtPrecioServicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioServicio.Maximum = 2147483647D;
            this.txtPrecioServicio.Minimum = -2147483648D;
            this.txtPrecioServicio.Name = "txtPrecioServicio";
            this.txtPrecioServicio.Padding = new System.Windows.Forms.Padding(5);
            this.txtPrecioServicio.RectColor = System.Drawing.Color.Silver;
            this.txtPrecioServicio.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtPrecioServicio.Size = new System.Drawing.Size(273, 29);
            this.txtPrecioServicio.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtPrecioServicio.TabIndex = 272;
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreServicio.FillColor = System.Drawing.Color.White;
            this.txtNombreServicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreServicio.Location = new System.Drawing.Point(27, 95);
            this.txtNombreServicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreServicio.Maximum = 2147483647D;
            this.txtNombreServicio.Minimum = -2147483648D;
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Padding = new System.Windows.Forms.Padding(5);
            this.txtNombreServicio.RectColor = System.Drawing.Color.Silver;
            this.txtNombreServicio.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtNombreServicio.Size = new System.Drawing.Size(273, 29);
            this.txtNombreServicio.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtNombreServicio.TabIndex = 271;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(-4, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(397, 1);
            this.label7.TabIndex = 279;
            // 
            // btnActualizarServicio
            // 
            this.btnActualizarServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.btnActualizarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarServicio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarServicio.ForeColor = System.Drawing.Color.White;
            this.btnActualizarServicio.Image = global::Salon.Properties.Resources.icons8_guardar_24;
            this.btnActualizarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarServicio.Location = new System.Drawing.Point(290, 308);
            this.btnActualizarServicio.Name = "btnActualizarServicio";
            this.btnActualizarServicio.Size = new System.Drawing.Size(91, 32);
            this.btnActualizarServicio.TabIndex = 280;
            this.btnActualizarServicio.Text = "      Guardar";
            this.btnActualizarServicio.UseVisualStyleBackColor = false;
            this.btnActualizarServicio.Click += new System.EventHandler(this.btnActualizarServicio_Click);
            // 
            // ActualizarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 352);
            this.Controls.Add(this.btnActualizarServicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnumestado);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbEstadoServ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecioServicio);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(this.txtidserv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Closeactserv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizarServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarServicio";
            ((System.ComponentModel.ISupportInitialize)(this.Closeactserv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Closeactserv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidserv;
        private System.Windows.Forms.TextBox txtnumestado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbEstadoServ;
        private System.Windows.Forms.Label label1;
        private DrakeUI.Framework.DrakeUITextBox txtPrecioServicio;
        private DrakeUI.Framework.DrakeUITextBox txtNombreServicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnActualizarServicio;
    }
}
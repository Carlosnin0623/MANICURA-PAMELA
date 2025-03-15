namespace Salon.Servicios
{
    partial class AñadirServicio
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
            this.Closeagreservicio = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreServ = new DrakeUI.Framework.DrakeUITextBox();
            this.txtPrecioServ = new DrakeUI.Framework.DrakeUITextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarServ = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Closeagreservicio)).BeginInit();
            this.SuspendLayout();
            // 
            // Closeagreservicio
            // 
            this.Closeagreservicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closeagreservicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Closeagreservicio.Image = global::Salon.Properties.Resources.icons8_multiplicar_23__2_;
            this.Closeagreservicio.Location = new System.Drawing.Point(338, 9);
            this.Closeagreservicio.Name = "Closeagreservicio";
            this.Closeagreservicio.Size = new System.Drawing.Size(28, 24);
            this.Closeagreservicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Closeagreservicio.TabIndex = 226;
            this.Closeagreservicio.TabStop = false;
            this.Closeagreservicio.Click += new System.EventHandler(this.Closeagreservicio_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 17);
            this.label13.TabIndex = 225;
            this.label13.Text = "Nuevo servicio";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(378, 43);
            this.label12.TabIndex = 224;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 228;
            this.label2.Text = "Nombre";
            // 
            // txtNombreServ
            // 
            this.txtNombreServ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreServ.FillColor = System.Drawing.Color.White;
            this.txtNombreServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreServ.Location = new System.Drawing.Point(26, 111);
            this.txtNombreServ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreServ.Maximum = 2147483647D;
            this.txtNombreServ.Minimum = -2147483648D;
            this.txtNombreServ.Name = "txtNombreServ";
            this.txtNombreServ.Padding = new System.Windows.Forms.Padding(5);
            this.txtNombreServ.Radius = 1;
            this.txtNombreServ.RectColor = System.Drawing.Color.Silver;
            this.txtNombreServ.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtNombreServ.Size = new System.Drawing.Size(301, 29);
            this.txtNombreServ.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtNombreServ.TabIndex = 227;
            // 
            // txtPrecioServ
            // 
            this.txtPrecioServ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioServ.FillColor = System.Drawing.Color.White;
            this.txtPrecioServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioServ.Location = new System.Drawing.Point(26, 177);
            this.txtPrecioServ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioServ.Maximum = 2147483647D;
            this.txtPrecioServ.Minimum = -2147483648D;
            this.txtPrecioServ.Name = "txtPrecioServ";
            this.txtPrecioServ.Padding = new System.Windows.Forms.Padding(5);
            this.txtPrecioServ.Radius = 1;
            this.txtPrecioServ.RectColor = System.Drawing.Color.Silver;
            this.txtPrecioServ.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtPrecioServ.Size = new System.Drawing.Size(301, 29);
            this.txtPrecioServ.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtPrecioServ.TabIndex = 230;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(25, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 229;
            this.label8.Text = "Precio";
            // 
            // btnAgregarServ
            // 
            this.btnAgregarServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.btnAgregarServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServ.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServ.ForeColor = System.Drawing.Color.White;
            this.btnAgregarServ.Image = global::Salon.Properties.Resources.icons8_guardar_24;
            this.btnAgregarServ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarServ.Location = new System.Drawing.Point(275, 301);
            this.btnAgregarServ.Name = "btnAgregarServ";
            this.btnAgregarServ.Size = new System.Drawing.Size(91, 32);
            this.btnAgregarServ.TabIndex = 233;
            this.btnAgregarServ.Text = "      Guardar";
            this.btnAgregarServ.UseVisualStyleBackColor = false;
            this.btnAgregarServ.Click += new System.EventHandler(this.btnAgregarServ_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(-1, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(381, 1);
            this.label11.TabIndex = 234;
            // 
            // AñadirServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 345);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAgregarServ);
            this.Controls.Add(this.txtPrecioServ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreServ);
            this.Controls.Add(this.Closeagreservicio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AñadirServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AñadirServicio";
            this.Load += new System.EventHandler(this.AñadirServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Closeagreservicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Closeagreservicio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private DrakeUI.Framework.DrakeUITextBox txtNombreServ;
        private DrakeUI.Framework.DrakeUITextBox txtPrecioServ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarServ;
        private System.Windows.Forms.Label label11;
    }
}
namespace Salon.GastosFijos
{
    partial class GenerarPeriodosGastosfijos
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
            this.CloseGenerarGastoFijo = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dateFinac = new System.Windows.Forms.DateTimePicker();
            this.dateInicioac = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseGenerarGastoFijo)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseGenerarGastoFijo
            // 
            this.CloseGenerarGastoFijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseGenerarGastoFijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CloseGenerarGastoFijo.Image = global::Salon.Properties.Resources.icons8_multiplicar_23__2_;
            this.CloseGenerarGastoFijo.Location = new System.Drawing.Point(533, 10);
            this.CloseGenerarGastoFijo.Name = "CloseGenerarGastoFijo";
            this.CloseGenerarGastoFijo.Size = new System.Drawing.Size(28, 24);
            this.CloseGenerarGastoFijo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseGenerarGastoFijo.TabIndex = 247;
            this.CloseGenerarGastoFijo.TabStop = false;
            this.CloseGenerarGastoFijo.Click += new System.EventHandler(this.CloseGenerarGastoFijo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 17);
            this.label13.TabIndex = 246;
            this.label13.Text = "Generar períodos de gastos fijos";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(573, 43);
            this.label12.TabIndex = 245;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Salon.Properties.Resources.icons8_guardar_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(470, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 249;
            this.button1.Text = "      Generar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(1, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(572, 1);
            this.label11.TabIndex = 248;
            // 
            // dateFinac
            // 
            this.dateFinac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFinac.CustomFormat = "yyyy-MM-dd";
            this.dateFinac.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFinac.Location = new System.Drawing.Point(299, 131);
            this.dateFinac.Name = "dateFinac";
            this.dateFinac.Size = new System.Drawing.Size(251, 27);
            this.dateFinac.TabIndex = 253;
            this.dateFinac.Value = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // dateInicioac
            // 
            this.dateInicioac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateInicioac.CustomFormat = "yyyy-MM-dd";
            this.dateInicioac.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInicioac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInicioac.Location = new System.Drawing.Point(23, 131);
            this.dateInicioac.Name = "dateInicioac";
            this.dateInicioac.Size = new System.Drawing.Size(251, 27);
            this.dateInicioac.TabIndex = 252;
            this.dateInicioac.Value = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(296, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 251;
            this.label4.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 250;
            this.label3.Text = "Desde";
            // 
            // GenerarPeriodosGastosfijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 337);
            this.Controls.Add(this.dateFinac);
            this.Controls.Add(this.dateInicioac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CloseGenerarGastoFijo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerarPeriodosGastosfijos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerarPeriodosGastosfijos";
            ((System.ComponentModel.ISupportInitialize)(this.CloseGenerarGastoFijo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseGenerarGastoFijo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateFinac;
        private System.Windows.Forms.DateTimePicker dateInicioac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
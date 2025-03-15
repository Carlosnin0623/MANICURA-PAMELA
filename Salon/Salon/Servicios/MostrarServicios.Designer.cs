namespace Salon.Facturación
{
    partial class MostrarServicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvDatosServiciosMostrar = new DrakeUI.Framework.DrakeUIDataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.drakeUIGradientPanel1 = new DrakeUI.Framework.DrakeUIGradientPanel();
            this.txtBusquedaServMostrar = new DrakeUI.Framework.DrakeUITextBox();
            this.Closemenu = new System.Windows.Forms.PictureBox();
            this.Closeservicio = new System.Windows.Forms.PictureBox();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosServiciosMostrar)).BeginInit();
            this.drakeUIGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closemenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closeservicio)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDatosServiciosMostrar
            // 
            this.DgvDatosServiciosMostrar.AllowUserToAddRows = false;
            this.DgvDatosServiciosMostrar.AllowUserToDeleteRows = false;
            this.DgvDatosServiciosMostrar.AllowUserToResizeColumns = false;
            this.DgvDatosServiciosMostrar.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.DgvDatosServiciosMostrar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvDatosServiciosMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDatosServiciosMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvDatosServiciosMostrar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvDatosServiciosMostrar.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvDatosServiciosMostrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDatosServiciosMostrar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvDatosServiciosMostrar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosServiciosMostrar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvDatosServiciosMostrar.ColumnHeadersHeight = 32;
            this.DgvDatosServiciosMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDatosServiciosMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Empleado,
            this.NombreServicio,
            this.Precio});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatosServiciosMostrar.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvDatosServiciosMostrar.EnableHeadersVisualStyles = false;
            this.DgvDatosServiciosMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DgvDatosServiciosMostrar.GridColor = System.Drawing.Color.DarkGray;
            this.DgvDatosServiciosMostrar.Location = new System.Drawing.Point(17, 138);
            this.DgvDatosServiciosMostrar.Name = "DgvDatosServiciosMostrar";
            this.DgvDatosServiciosMostrar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvDatosServiciosMostrar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosServiciosMostrar.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvDatosServiciosMostrar.RowHeadersVisible = false;
            this.DgvDatosServiciosMostrar.RowHeadersWidth = 25;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDatosServiciosMostrar.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvDatosServiciosMostrar.RowTemplate.Height = 29;
            this.DgvDatosServiciosMostrar.SelectedIndex = -1;
            this.DgvDatosServiciosMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatosServiciosMostrar.ShowRect = false;
            this.DgvDatosServiciosMostrar.Size = new System.Drawing.Size(833, 309);
            this.DgvDatosServiciosMostrar.StripeOddColor = System.Drawing.Color.White;
            this.DgvDatosServiciosMostrar.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DgvDatosServiciosMostrar.StyleCustomMode = true;
            this.DgvDatosServiciosMostrar.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 231;
            this.label9.Text = "Servicios";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(870, 43);
            this.label8.TabIndex = 230;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drakeUIGradientPanel1
            // 
            this.drakeUIGradientPanel1.Controls.Add(this.txtBusquedaServMostrar);
            this.drakeUIGradientPanel1.Controls.Add(this.Closemenu);
            this.drakeUIGradientPanel1.FillColor = System.Drawing.Color.White;
            this.drakeUIGradientPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIGradientPanel1.Location = new System.Drawing.Point(17, 85);
            this.drakeUIGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUIGradientPanel1.Name = "drakeUIGradientPanel1";
            this.drakeUIGradientPanel1.RectColor = System.Drawing.Color.Silver;
            this.drakeUIGradientPanel1.RectDisableColor = System.Drawing.Color.White;
            this.drakeUIGradientPanel1.Size = new System.Drawing.Size(275, 32);
            this.drakeUIGradientPanel1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIGradientPanel1.TabIndex = 234;
            this.drakeUIGradientPanel1.Text = null;
            // 
            // txtBusquedaServMostrar
            // 
            this.txtBusquedaServMostrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusquedaServMostrar.FillColor = System.Drawing.Color.White;
            this.txtBusquedaServMostrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaServMostrar.Location = new System.Drawing.Point(46, 3);
            this.txtBusquedaServMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusquedaServMostrar.Maximum = 2147483647D;
            this.txtBusquedaServMostrar.Minimum = -2147483648D;
            this.txtBusquedaServMostrar.Name = "txtBusquedaServMostrar";
            this.txtBusquedaServMostrar.Padding = new System.Windows.Forms.Padding(5);
            this.txtBusquedaServMostrar.RectColor = System.Drawing.Color.White;
            this.txtBusquedaServMostrar.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtBusquedaServMostrar.Size = new System.Drawing.Size(225, 27);
            this.txtBusquedaServMostrar.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtBusquedaServMostrar.TabIndex = 0;
            // 
            // Closemenu
            // 
            this.Closemenu.BackColor = System.Drawing.Color.White;
            this.Closemenu.Image = global::Salon.Properties.Resources.icons8_búsqueda_22;
            this.Closemenu.Location = new System.Drawing.Point(17, 1);
            this.Closemenu.Name = "Closemenu";
            this.Closemenu.Size = new System.Drawing.Size(26, 30);
            this.Closemenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Closemenu.TabIndex = 225;
            this.Closemenu.TabStop = false;
            // 
            // Closeservicio
            // 
            this.Closeservicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closeservicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Closeservicio.Image = global::Salon.Properties.Resources.icons8_multiplicar_23__2_;
            this.Closeservicio.Location = new System.Drawing.Point(830, 10);
            this.Closeservicio.Name = "Closeservicio";
            this.Closeservicio.Size = new System.Drawing.Size(28, 24);
            this.Closeservicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Closeservicio.TabIndex = 232;
            this.Closeservicio.TabStop = false;
            this.Closeservicio.Click += new System.EventHandler(this.Closeclient_Click);
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Empleado.DataPropertyName = "ID_Empleado";
            this.ID_Empleado.HeaderText = "ID";
            this.ID_Empleado.Name = "ID_Empleado";
            this.ID_Empleado.Visible = false;
            // 
            // NombreServicio
            // 
            this.NombreServicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreServicio.DataPropertyName = "NombreServicio";
            this.NombreServicio.HeaderText = "Nombre";
            this.NombreServicio.Name = "NombreServicio";
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // MostrarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 490);
            this.Controls.Add(this.drakeUIGradientPanel1);
            this.Controls.Add(this.Closeservicio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DgvDatosServiciosMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServicioFa";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosServiciosMostrar)).EndInit();
            this.drakeUIGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Closemenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closeservicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DrakeUI.Framework.DrakeUIDataGridView DgvDatosServiciosMostrar;
        private System.Windows.Forms.PictureBox Closeservicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private DrakeUI.Framework.DrakeUIGradientPanel drakeUIGradientPanel1;
        private DrakeUI.Framework.DrakeUITextBox txtBusquedaServMostrar;
        private System.Windows.Forms.PictureBox Closemenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}
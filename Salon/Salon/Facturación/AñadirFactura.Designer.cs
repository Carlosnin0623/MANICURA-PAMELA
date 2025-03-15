namespace Salon.Facturación
{
    partial class AñadirFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvDatosFacturar = new DrakeUI.Framework.DrakeUIDataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProducto = new DrakeUI.Framework.DrakeUITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalneto = new DrakeUI.Framework.DrakeUITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVendedor = new DrakeUI.Framework.DrakeUITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServicio = new DrakeUI.Framework.DrakeUITextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechafact = new DrakeUI.Framework.DrakeUITextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCliente = new DrakeUI.Framework.DrakeUITextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioServicio = new DrakeUI.Framework.DrakeUITextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new DrakeUI.Framework.DrakeUITextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnServicio = new System.Windows.Forms.Button();
            this.Closeagregfactu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosFacturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closeagregfactu)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDatosFacturar
            // 
            this.DgvDatosFacturar.AllowUserToAddRows = false;
            this.DgvDatosFacturar.AllowUserToDeleteRows = false;
            this.DgvDatosFacturar.AllowUserToResizeColumns = false;
            this.DgvDatosFacturar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvDatosFacturar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDatosFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDatosFacturar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvDatosFacturar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvDatosFacturar.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvDatosFacturar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDatosFacturar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvDatosFacturar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosFacturar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDatosFacturar.ColumnHeadersHeight = 32;
            this.DgvDatosFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDatosFacturar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.borrar,
            this.ID_Empleado,
            this.Nombre,
            this.Apellido,
            this.ProductoId,
            this.Producto,
            this.Cantidad,
            this.PreUni,
            this.Cliente,
            this.Usuario,
            this.FechaFactura,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatosFacturar.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDatosFacturar.EnableHeadersVisualStyles = false;
            this.DgvDatosFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DgvDatosFacturar.GridColor = System.Drawing.Color.DarkGray;
            this.DgvDatosFacturar.Location = new System.Drawing.Point(32, 277);
            this.DgvDatosFacturar.Name = "DgvDatosFacturar";
            this.DgvDatosFacturar.RectColor = System.Drawing.Color.DarkGray;
            this.DgvDatosFacturar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosFacturar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDatosFacturar.RowHeadersVisible = false;
            this.DgvDatosFacturar.RowHeadersWidth = 25;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDatosFacturar.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvDatosFacturar.RowTemplate.Height = 29;
            this.DgvDatosFacturar.SelectedIndex = -1;
            this.DgvDatosFacturar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatosFacturar.ShowRect = false;
            this.DgvDatosFacturar.Size = new System.Drawing.Size(1099, 301);
            this.DgvDatosFacturar.StripeOddColor = System.Drawing.Color.White;
            this.DgvDatosFacturar.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DgvDatosFacturar.StyleCustomMode = true;
            this.DgvDatosFacturar.TabIndex = 59;
            this.DgvDatosFacturar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatosFacturar_CellClick);
            this.DgvDatosFacturar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatosFacturar_CellContentClick);
            this.DgvDatosFacturar.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvDatosFacturar_CellPainting);
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.Width = 30;
            // 
            // borrar
            // 
            this.borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.borrar.HeaderText = "";
            this.borrar.Name = "borrar";
            this.borrar.Width = 90;
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_Empleado.DataPropertyName = "ID_Empleado";
            this.ID_Empleado.HeaderText = "ID";
            this.ID_Empleado.Name = "ID_Empleado";
            this.ID_Empleado.Visible = false;
            this.ID_Empleado.Width = 95;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.HeaderText = "Servicio";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 274;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Precio Servicio";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 130;
            // 
            // ProductoId
            // 
            this.ProductoId.DataPropertyName = "ProductoId";
            this.ProductoId.HeaderText = "ProductoId";
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.Visible = false;
            this.ProductoId.Width = 93;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 240;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 79;
            // 
            // PreUni
            // 
            this.PreUni.HeaderText = "Precio Producto";
            this.PreUni.Name = "PreUni";
            this.PreUni.Width = 120;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NombreCliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = false;
            this.Cliente.Width = 70;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.Visible = false;
            this.Usuario.Width = 73;
            // 
            // FechaFactura
            // 
            this.FechaFactura.HeaderText = "Fecha";
            this.FechaFactura.Name = "FechaFactura";
            this.FechaFactura.Visible = false;
            this.FechaFactura.Width = 63;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(295, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProducto.FillColor = System.Drawing.Color.White;
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(296, 104);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProducto.Maximum = 2147483647D;
            this.txtProducto.Minimum = -2147483648D;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Padding = new System.Windows.Forms.Padding(5);
            this.txtProducto.Radius = 0;
            this.txtProducto.RectColor = System.Drawing.Color.Silver;
            this.txtProducto.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtProducto.Size = new System.Drawing.Size(246, 29);
            this.txtProducto.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtProducto.TabIndex = 60;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(856, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Total neto";
            // 
            // txtTotalneto
            // 
            this.txtTotalneto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalneto.FillColor = System.Drawing.Color.White;
            this.txtTotalneto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalneto.Location = new System.Drawing.Point(939, 586);
            this.txtTotalneto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalneto.Maximum = 2147483647D;
            this.txtTotalneto.Minimum = -2147483648D;
            this.txtTotalneto.Name = "txtTotalneto";
            this.txtTotalneto.Padding = new System.Windows.Forms.Padding(5);
            this.txtTotalneto.RectColor = System.Drawing.Color.Silver;
            this.txtTotalneto.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtTotalneto.Size = new System.Drawing.Size(180, 29);
            this.txtTotalneto.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtTotalneto.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendedor.FillColor = System.Drawing.Color.White;
            this.txtVendedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.Location = new System.Drawing.Point(34, 104);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVendedor.Maximum = 2147483647D;
            this.txtVendedor.Minimum = -2147483648D;
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Padding = new System.Windows.Forms.Padding(5);
            this.txtVendedor.Radius = 0;
            this.txtVendedor.RectColor = System.Drawing.Color.Silver;
            this.txtVendedor.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtVendedor.Size = new System.Drawing.Size(244, 29);
            this.txtVendedor.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtVendedor.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 234;
            this.label4.Text = "Servicio";
            // 
            // txtServicio
            // 
            this.txtServicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServicio.FillColor = System.Drawing.Color.White;
            this.txtServicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(32, 170);
            this.txtServicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServicio.Maximum = 2147483647D;
            this.txtServicio.Minimum = -2147483648D;
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Padding = new System.Windows.Forms.Padding(5);
            this.txtServicio.RectColor = System.Drawing.Color.Silver;
            this.txtServicio.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtServicio.Size = new System.Drawing.Size(246, 29);
            this.txtServicio.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtServicio.TabIndex = 233;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 237;
            this.label13.Text = "Nueva factura";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1161, 43);
            this.label12.TabIndex = 236;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(818, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 241;
            this.label6.Tag = "f";
            this.label6.Text = "Fecha de emisión";
            // 
            // txtFechafact
            // 
            this.txtFechafact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFechafact.FillColor = System.Drawing.Color.White;
            this.txtFechafact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechafact.Location = new System.Drawing.Point(820, 170);
            this.txtFechafact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFechafact.Maximum = 2147483647D;
            this.txtFechafact.Minimum = -2147483648D;
            this.txtFechafact.Name = "txtFechafact";
            this.txtFechafact.Padding = new System.Windows.Forms.Padding(5);
            this.txtFechafact.RectColor = System.Drawing.Color.Silver;
            this.txtFechafact.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtFechafact.Size = new System.Drawing.Size(245, 29);
            this.txtFechafact.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtFechafact.TabIndex = 240;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(557, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 243;
            this.label7.Text = "Cliente(*)";
            // 
            // txtCliente
            // 
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCliente.FillColor = System.Drawing.Color.White;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(558, 170);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCliente.Maximum = 2147483647D;
            this.txtCliente.Minimum = -2147483648D;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Padding = new System.Windows.Forms.Padding(5);
            this.txtCliente.Radius = 0;
            this.txtCliente.RectColor = System.Drawing.Color.Silver;
            this.txtCliente.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtCliente.Size = new System.Drawing.Size(246, 29);
            this.txtCliente.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtCliente.TabIndex = 242;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(821, 104);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(244, 29);
            this.numericUpDown1.TabIndex = 247;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(818, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 248;
            this.label5.Tag = "f";
            this.label5.Text = "Cantidad producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(295, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 251;
            this.label8.Text = "Precio Servicio";
            // 
            // txtPrecioServicio
            // 
            this.txtPrecioServicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioServicio.FillColor = System.Drawing.Color.White;
            this.txtPrecioServicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioServicio.Location = new System.Drawing.Point(295, 170);
            this.txtPrecioServicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioServicio.Maximum = 2147483647D;
            this.txtPrecioServicio.Minimum = -2147483648D;
            this.txtPrecioServicio.Name = "txtPrecioServicio";
            this.txtPrecioServicio.Padding = new System.Windows.Forms.Padding(5);
            this.txtPrecioServicio.Radius = 0;
            this.txtPrecioServicio.RectColor = System.Drawing.Color.Silver;
            this.txtPrecioServicio.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtPrecioServicio.Size = new System.Drawing.Size(246, 29);
            this.txtPrecioServicio.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtPrecioServicio.TabIndex = 250;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(557, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 253;
            this.label9.Text = "Precio Producto";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioProducto.FillColor = System.Drawing.Color.White;
            this.txtPrecioProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProducto.Location = new System.Drawing.Point(558, 104);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioProducto.Maximum = 2147483647D;
            this.txtPrecioProducto.Minimum = -2147483648D;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Padding = new System.Windows.Forms.Padding(5);
            this.txtPrecioProducto.Radius = 0;
            this.txtPrecioProducto.RectColor = System.Drawing.Color.Silver;
            this.txtPrecioProducto.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtPrecioProducto.Size = new System.Drawing.Size(246, 29);
            this.txtPrecioProducto.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtPrecioProducto.TabIndex = 252;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(47, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 256;
            this.label10.Text = "Operación";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::Salon.Properties.Resources.icons8_escoba_17;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(678, 230);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 32);
            this.btnLimpiar.TabIndex = 257;
            this.btnLimpiar.Text = "       Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Image = global::Salon.Properties.Resources.icons8_más_2_matemáticas_19;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(961, 230);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(79, 32);
            this.btnInsertar.TabIndex = 255;
            this.btnInsertar.Text = "      Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Image = global::Salon.Properties.Resources.icons8_factura_19;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(1046, 230);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(83, 32);
            this.btnFacturar.TabIndex = 254;
            this.btnFacturar.Text = "       Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click_1);
            // 
            // btnProducto
            // 
            this.btnProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Image = global::Salon.Properties.Resources.productoboton;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(766, 230);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(98, 32);
            this.btnProducto.TabIndex = 246;
            this.btnProducto.Text = "       Productos";
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnServicio
            // 
            this.btnServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(182)))));
            this.btnServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicio.ForeColor = System.Drawing.Color.White;
            this.btnServicio.Image = global::Salon.Properties.Resources.icons8_maletín_19;
            this.btnServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicio.Location = new System.Drawing.Point(870, 230);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(85, 32);
            this.btnServicio.TabIndex = 244;
            this.btnServicio.Text = "       Servicios";
            this.btnServicio.UseVisualStyleBackColor = false;
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
            // 
            // Closeagregfactu
            // 
            this.Closeagregfactu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closeagregfactu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Closeagregfactu.Image = global::Salon.Properties.Resources.icons8_multiplicar_23__2_;
            this.Closeagregfactu.Location = new System.Drawing.Point(1126, 9);
            this.Closeagregfactu.Name = "Closeagregfactu";
            this.Closeagregfactu.Size = new System.Drawing.Size(28, 24);
            this.Closeagregfactu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Closeagregfactu.TabIndex = 238;
            this.Closeagregfactu.TabStop = false;
            this.Closeagregfactu.Click += new System.EventHandler(this.Closeagregfactu_Click);
            // 
            // AñadirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 649);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrecioServicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnServicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFechafact);
            this.Controls.Add(this.Closeagregfactu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalneto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.DgvDatosFacturar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AñadirFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AñadirFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosFacturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closeagregfactu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DrakeUI.Framework.DrakeUIDataGridView DgvDatosFacturar;
        private System.Windows.Forms.Label label2;
        private DrakeUI.Framework.DrakeUITextBox txtProducto;
        private System.Windows.Forms.Label label1;
        private DrakeUI.Framework.DrakeUITextBox txtTotalneto;
        private System.Windows.Forms.Label label3;
        private DrakeUI.Framework.DrakeUITextBox txtVendedor;
        private System.Windows.Forms.Label label4;
        private DrakeUI.Framework.DrakeUITextBox txtServicio;
        private System.Windows.Forms.PictureBox Closeagregfactu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private DrakeUI.Framework.DrakeUITextBox txtFechafact;
        private System.Windows.Forms.Label label7;
        private DrakeUI.Framework.DrakeUITextBox txtCliente;
        private System.Windows.Forms.Button btnServicio;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private DrakeUI.Framework.DrakeUITextBox txtPrecioServicio;
        private System.Windows.Forms.Label label9;
        private DrakeUI.Framework.DrakeUITextBox txtPrecioProducto;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
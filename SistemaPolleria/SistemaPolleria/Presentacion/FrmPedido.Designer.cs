namespace SistemaPolleria.Presentacion
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.DgvPedidosMesa = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtTotalLiteral = new System.Windows.Forms.TextBox();
            this.TxtTotalNumerico = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnQuitarCarrito = new System.Windows.Forms.Button();
            this.BtnAgregarCarrito = new System.Windows.Forms.Button();
            this.TxtCantidadCompra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtStockProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.BtnBuscarProducto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigoPedido = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.CmbCodigoMesa = new System.Windows.Forms.ComboBox();
            this.DtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbTipoPedido = new System.Windows.Forms.ComboBox();
            this.GpbDatosDelivery = new System.Windows.Forms.GroupBox();
            this.TxtFamiliaDelivery = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtDireccionDelivery = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtReferenciaDelivery = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.CmbEstadoPedido = new System.Windows.Forms.ComboBox();
            this.GpbDatosMesa = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbNumeroPiso = new System.Windows.Forms.ComboBox();
            this.BtnNuevoCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosMesa)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GpbDatosDelivery.SuspendLayout();
            this.GpbDatosMesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvPedidosMesa
            // 
            this.DgvPedidosMesa.AllowUserToAddRows = false;
            this.DgvPedidosMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidosMesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCTO,
            this.PRODUCTO,
            this.CANTIDAD,
            this.PRECIO,
            this.SUBTOTAL});
            this.DgvPedidosMesa.Location = new System.Drawing.Point(12, 409);
            this.DgvPedidosMesa.Name = "DgvPedidosMesa";
            this.DgvPedidosMesa.ReadOnly = true;
            this.DgvPedidosMesa.Size = new System.Drawing.Size(844, 169);
            this.DgvPedidosMesa.TabIndex = 290;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(9, 591);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 17);
            this.label13.TabIndex = 286;
            this.label13.Text = "Monto a Pagar";
            // 
            // TxtTotalLiteral
            // 
            this.TxtTotalLiteral.BackColor = System.Drawing.Color.White;
            this.TxtTotalLiteral.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtTotalLiteral.ForeColor = System.Drawing.Color.Black;
            this.TxtTotalLiteral.Location = new System.Drawing.Point(116, 587);
            this.TxtTotalLiteral.Name = "TxtTotalLiteral";
            this.TxtTotalLiteral.Size = new System.Drawing.Size(440, 26);
            this.TxtTotalLiteral.TabIndex = 288;
            // 
            // TxtTotalNumerico
            // 
            this.TxtTotalNumerico.BackColor = System.Drawing.Color.White;
            this.TxtTotalNumerico.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtTotalNumerico.ForeColor = System.Drawing.Color.Black;
            this.TxtTotalNumerico.Location = new System.Drawing.Point(750, 587);
            this.TxtTotalNumerico.Name = "TxtTotalNumerico";
            this.TxtTotalNumerico.Size = new System.Drawing.Size(106, 26);
            this.TxtTotalNumerico.TabIndex = 287;
            this.TxtTotalNumerico.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnQuitarCarrito);
            this.groupBox4.Controls.Add(this.BtnAgregarCarrito);
            this.groupBox4.Controls.Add(this.TxtCantidadCompra);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox4.ForeColor = System.Drawing.Color.Gray;
            this.groupBox4.Location = new System.Drawing.Point(12, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(844, 85);
            this.groupBox4.TabIndex = 285;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del Detalle de Pedido";
            // 
            // BtnQuitarCarrito
            // 
            this.BtnQuitarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnQuitarCarrito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnQuitarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitarCarrito.ForeColor = System.Drawing.Color.White;
            this.BtnQuitarCarrito.Location = new System.Drawing.Point(609, 25);
            this.BtnQuitarCarrito.Name = "BtnQuitarCarrito";
            this.BtnQuitarCarrito.Size = new System.Drawing.Size(205, 48);
            this.BtnQuitarCarrito.TabIndex = 275;
            this.BtnQuitarCarrito.Text = "Quitar del Pedido";
            this.BtnQuitarCarrito.UseVisualStyleBackColor = false;
            this.BtnQuitarCarrito.Click += new System.EventHandler(this.BtnQuitarCarrito_Click);
            // 
            // BtnAgregarCarrito
            // 
            this.BtnAgregarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnAgregarCarrito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCarrito.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarCarrito.Location = new System.Drawing.Point(377, 25);
            this.BtnAgregarCarrito.Name = "BtnAgregarCarrito";
            this.BtnAgregarCarrito.Size = new System.Drawing.Size(208, 48);
            this.BtnAgregarCarrito.TabIndex = 274;
            this.BtnAgregarCarrito.Text = "Agregar al Pedido";
            this.BtnAgregarCarrito.UseVisualStyleBackColor = false;
            this.BtnAgregarCarrito.Click += new System.EventHandler(this.BtnAgregarCarrito_Click);
            // 
            // TxtCantidadCompra
            // 
            this.TxtCantidadCompra.BackColor = System.Drawing.Color.White;
            this.TxtCantidadCompra.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtCantidadCompra.ForeColor = System.Drawing.Color.Black;
            this.TxtCantidadCompra.Location = new System.Drawing.Point(20, 49);
            this.TxtCantidadCompra.Name = "TxtCantidadCompra";
            this.TxtCantidadCompra.Size = new System.Drawing.Size(171, 26);
            this.TxtCantidadCompra.TabIndex = 265;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(18, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 17);
            this.label14.TabIndex = 266;
            this.label14.Text = "Cantidad a comprar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtStockProducto);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtPrecioUnitario);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtCodigoProducto);
            this.groupBox3.Controls.Add(this.BtnBuscarProducto);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TxtNombreProducto);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox3.ForeColor = System.Drawing.Color.Gray;
            this.groupBox3.Location = new System.Drawing.Point(12, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 76);
            this.groupBox3.TabIndex = 284;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Producto";
            // 
            // TxtStockProducto
            // 
            this.TxtStockProducto.BackColor = System.Drawing.Color.White;
            this.TxtStockProducto.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtStockProducto.ForeColor = System.Drawing.Color.Black;
            this.TxtStockProducto.Location = new System.Drawing.Point(513, 41);
            this.TxtStockProducto.Name = "TxtStockProducto";
            this.TxtStockProducto.Size = new System.Drawing.Size(84, 26);
            this.TxtStockProducto.TabIndex = 267;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(511, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 268;
            this.label9.Text = "Stock";
            // 
            // TxtPrecioUnitario
            // 
            this.TxtPrecioUnitario.BackColor = System.Drawing.Color.White;
            this.TxtPrecioUnitario.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtPrecioUnitario.ForeColor = System.Drawing.Color.Black;
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(406, 41);
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(99, 26);
            this.TxtPrecioUnitario.TabIndex = 265;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(18, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 261;
            this.label8.Text = "Codigo del Producto";
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.BackColor = System.Drawing.Color.White;
            this.TxtCodigoProducto.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtCodigoProducto.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigoProducto.Location = new System.Drawing.Point(21, 41);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(100, 26);
            this.TxtCodigoProducto.TabIndex = 260;
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnBuscarProducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.BtnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarProducto.Image")));
            this.BtnBuscarProducto.Location = new System.Drawing.Point(120, 41);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(39, 26);
            this.BtnBuscarProducto.TabIndex = 262;
            this.BtnBuscarProducto.UseVisualStyleBackColor = false;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(404, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 266;
            this.label10.Text = "Precio Unitario";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.BackColor = System.Drawing.Color.White;
            this.TxtNombreProducto.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.TxtNombreProducto.Location = new System.Drawing.Point(165, 41);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(230, 26);
            this.TxtNombreProducto.TabIndex = 263;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(162, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 17);
            this.label11.TabIndex = 264;
            this.label11.Text = "Nombre del Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnNuevoCliente);
            this.groupBox2.Controls.Add(this.TxtTelefono);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtDocumentoCliente);
            this.groupBox2.Controls.Add(this.BtnBuscarCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtRazonSocial);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 76);
            this.groupBox2.TabIndex = 283;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BackColor = System.Drawing.Color.White;
            this.TxtTelefono.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtTelefono.ForeColor = System.Drawing.Color.Black;
            this.TxtTelefono.Location = new System.Drawing.Point(480, 40);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(117, 26);
            this.TxtTelefono.TabIndex = 265;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 261;
            this.label4.Text = "Documento";
            // 
            // TxtDocumentoCliente
            // 
            this.TxtDocumentoCliente.BackColor = System.Drawing.Color.White;
            this.TxtDocumentoCliente.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtDocumentoCliente.ForeColor = System.Drawing.Color.Black;
            this.TxtDocumentoCliente.Location = new System.Drawing.Point(21, 40);
            this.TxtDocumentoCliente.Name = "TxtDocumentoCliente";
            this.TxtDocumentoCliente.Size = new System.Drawing.Size(100, 26);
            this.TxtDocumentoCliente.TabIndex = 260;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnBuscarCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.BtnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarCliente.Image")));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(120, 40);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(39, 26);
            this.BtnBuscarCliente.TabIndex = 262;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(477, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 266;
            this.label5.Text = "Telefono";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.BackColor = System.Drawing.Color.White;
            this.TxtRazonSocial.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.TxtRazonSocial.Location = new System.Drawing.Point(217, 40);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(257, 26);
            this.TxtRazonSocial.TabIndex = 263;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(214, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 264;
            this.label1.Text = "Razon Social";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.CmbEstadoPedido);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CmbTipoPedido);
            this.groupBox1.Controls.Add(this.TxtCodigoPedido);
            this.groupBox1.Controls.Add(this.Codigo);
            this.groupBox1.Controls.Add(this.DtpFechaPedido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 87);
            this.groupBox1.TabIndex = 282;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 254;
            this.label2.Text = "Numero de Piso";
            // 
            // TxtCodigoPedido
            // 
            this.TxtCodigoPedido.BackColor = System.Drawing.Color.White;
            this.TxtCodigoPedido.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtCodigoPedido.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigoPedido.Location = new System.Drawing.Point(21, 44);
            this.TxtCodigoPedido.Name = "TxtCodigoPedido";
            this.TxtCodigoPedido.Size = new System.Drawing.Size(117, 26);
            this.TxtCodigoPedido.TabIndex = 248;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Codigo.ForeColor = System.Drawing.Color.Gray;
            this.Codigo.Location = new System.Drawing.Point(18, 24);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(52, 17);
            this.Codigo.TabIndex = 249;
            this.Codigo.Text = "Codigo";
            // 
            // CmbCodigoMesa
            // 
            this.CmbCodigoMesa.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.CmbCodigoMesa.ForeColor = System.Drawing.Color.Gray;
            this.CmbCodigoMesa.FormattingEnabled = true;
            this.CmbCodigoMesa.Location = new System.Drawing.Point(13, 120);
            this.CmbCodigoMesa.Name = "CmbCodigoMesa";
            this.CmbCodigoMesa.Size = new System.Drawing.Size(156, 27);
            this.CmbCodigoMesa.TabIndex = 255;
            // 
            // DtpFechaPedido
            // 
            this.DtpFechaPedido.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.DtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaPedido.Location = new System.Drawing.Point(301, 44);
            this.DtpFechaPedido.Name = "DtpFechaPedido";
            this.DtpFechaPedido.Size = new System.Drawing.Size(121, 26);
            this.DtpFechaPedido.TabIndex = 256;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(298, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 257;
            this.label3.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(7, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 28);
            this.label6.TabIndex = 281;
            this.label6.Text = "Formulario Nuevo Pedido";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Roboto", 10F);
            this.BtnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnNuevo.Location = new System.Drawing.Point(729, 619);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(127, 32);
            this.BtnNuevo.TabIndex = 280;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Roboto", 10F);
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGuardar.Location = new System.Drawing.Point(596, 619);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(127, 32);
            this.BtnGuardar.TabIndex = 279;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(162, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 291;
            this.label7.Text = "Tipo";
            // 
            // CmbTipoPedido
            // 
            this.CmbTipoPedido.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.CmbTipoPedido.ForeColor = System.Drawing.Color.Gray;
            this.CmbTipoPedido.FormattingEnabled = true;
            this.CmbTipoPedido.Location = new System.Drawing.Point(165, 43);
            this.CmbTipoPedido.Name = "CmbTipoPedido";
            this.CmbTipoPedido.Size = new System.Drawing.Size(123, 27);
            this.CmbTipoPedido.TabIndex = 292;
            // 
            // GpbDatosDelivery
            // 
            this.GpbDatosDelivery.Controls.Add(this.GpbDatosMesa);
            this.GpbDatosDelivery.Controls.Add(this.TxtFamiliaDelivery);
            this.GpbDatosDelivery.Controls.Add(this.label15);
            this.GpbDatosDelivery.Controls.Add(this.TxtDireccionDelivery);
            this.GpbDatosDelivery.Controls.Add(this.label16);
            this.GpbDatosDelivery.Controls.Add(this.TxtReferenciaDelivery);
            this.GpbDatosDelivery.Controls.Add(this.label17);
            this.GpbDatosDelivery.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.GpbDatosDelivery.ForeColor = System.Drawing.Color.Gray;
            this.GpbDatosDelivery.Location = new System.Drawing.Point(621, 52);
            this.GpbDatosDelivery.Name = "GpbDatosDelivery";
            this.GpbDatosDelivery.Size = new System.Drawing.Size(237, 250);
            this.GpbDatosDelivery.TabIndex = 284;
            this.GpbDatosDelivery.TabStop = false;
            this.GpbDatosDelivery.Text = "Datos del Delivery";
            // 
            // TxtFamiliaDelivery
            // 
            this.TxtFamiliaDelivery.BackColor = System.Drawing.Color.White;
            this.TxtFamiliaDelivery.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtFamiliaDelivery.ForeColor = System.Drawing.Color.Black;
            this.TxtFamiliaDelivery.Location = new System.Drawing.Point(21, 194);
            this.TxtFamiliaDelivery.Name = "TxtFamiliaDelivery";
            this.TxtFamiliaDelivery.Size = new System.Drawing.Size(192, 26);
            this.TxtFamiliaDelivery.TabIndex = 265;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(18, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 17);
            this.label15.TabIndex = 261;
            this.label15.Text = "Direccion";
            // 
            // TxtDireccionDelivery
            // 
            this.TxtDireccionDelivery.BackColor = System.Drawing.Color.White;
            this.TxtDireccionDelivery.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtDireccionDelivery.ForeColor = System.Drawing.Color.Black;
            this.TxtDireccionDelivery.Location = new System.Drawing.Point(21, 40);
            this.TxtDireccionDelivery.Name = "TxtDireccionDelivery";
            this.TxtDireccionDelivery.Size = new System.Drawing.Size(192, 26);
            this.TxtDireccionDelivery.TabIndex = 260;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(18, 174);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 266;
            this.label16.Text = "Familia";
            // 
            // TxtReferenciaDelivery
            // 
            this.TxtReferenciaDelivery.BackColor = System.Drawing.Color.White;
            this.TxtReferenciaDelivery.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtReferenciaDelivery.ForeColor = System.Drawing.Color.Black;
            this.TxtReferenciaDelivery.Location = new System.Drawing.Point(21, 89);
            this.TxtReferenciaDelivery.Multiline = true;
            this.TxtReferenciaDelivery.Name = "TxtReferenciaDelivery";
            this.TxtReferenciaDelivery.Size = new System.Drawing.Size(192, 79);
            this.TxtReferenciaDelivery.TabIndex = 263;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(18, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 17);
            this.label17.TabIndex = 264;
            this.label17.Text = "Referencia";
            // 
            // IDPRODUCTO
            // 
            this.IDPRODUCTO.HeaderText = "IDPRODUCTO";
            this.IDPRODUCTO.Name = "IDPRODUCTO";
            this.IDPRODUCTO.ReadOnly = true;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.HeaderText = "PRODUCTO";
            this.PRODUCTO.Name = "PRODUCTO";
            this.PRODUCTO.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.HeaderText = "SUBTOTAL";
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.ReadOnly = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(439, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 17);
            this.label18.TabIndex = 293;
            this.label18.Text = "Estado";
            // 
            // CmbEstadoPedido
            // 
            this.CmbEstadoPedido.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.CmbEstadoPedido.ForeColor = System.Drawing.Color.Gray;
            this.CmbEstadoPedido.FormattingEnabled = true;
            this.CmbEstadoPedido.Items.AddRange(new object[] {
            "Atendido",
            "En espera",
            "Cancelado"});
            this.CmbEstadoPedido.Location = new System.Drawing.Point(442, 43);
            this.CmbEstadoPedido.Name = "CmbEstadoPedido";
            this.CmbEstadoPedido.Size = new System.Drawing.Size(123, 27);
            this.CmbEstadoPedido.TabIndex = 294;
            // 
            // GpbDatosMesa
            // 
            this.GpbDatosMesa.Controls.Add(this.label12);
            this.GpbDatosMesa.Controls.Add(this.CmbNumeroPiso);
            this.GpbDatosMesa.Controls.Add(this.label2);
            this.GpbDatosMesa.Controls.Add(this.CmbCodigoMesa);
            this.GpbDatosMesa.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.GpbDatosMesa.ForeColor = System.Drawing.Color.Gray;
            this.GpbDatosMesa.Location = new System.Drawing.Point(0, 0);
            this.GpbDatosMesa.Name = "GpbDatosMesa";
            this.GpbDatosMesa.Size = new System.Drawing.Size(237, 251);
            this.GpbDatosMesa.TabIndex = 285;
            this.GpbDatosMesa.TabStop = false;
            this.GpbDatosMesa.Text = "Datos de la Mesa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(10, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 256;
            this.label12.Text = "Codigo de Mesa";
            // 
            // CmbNumeroPiso
            // 
            this.CmbNumeroPiso.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.CmbNumeroPiso.ForeColor = System.Drawing.Color.Gray;
            this.CmbNumeroPiso.FormattingEnabled = true;
            this.CmbNumeroPiso.Location = new System.Drawing.Point(13, 49);
            this.CmbNumeroPiso.Name = "CmbNumeroPiso";
            this.CmbNumeroPiso.Size = new System.Drawing.Size(156, 27);
            this.CmbNumeroPiso.TabIndex = 257;
            // 
            // BtnNuevoCliente
            // 
            this.BtnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.BtnNuevoCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.BtnNuevoCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.BtnNuevoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoCliente.ForeColor = System.Drawing.Color.Black;
            this.BtnNuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevoCliente.Image")));
            this.BtnNuevoCliente.Location = new System.Drawing.Point(159, 40);
            this.BtnNuevoCliente.Name = "BtnNuevoCliente";
            this.BtnNuevoCliente.Size = new System.Drawing.Size(39, 26);
            this.BtnNuevoCliente.TabIndex = 267;
            this.BtnNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 722);
            this.Controls.Add(this.GpbDatosDelivery);
            this.Controls.Add(this.DgvPedidosMesa);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtTotalLiteral);
            this.Controls.Add(this.TxtTotalNumerico);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosMesa)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GpbDatosDelivery.ResumeLayout(false);
            this.GpbDatosDelivery.PerformLayout();
            this.GpbDatosMesa.ResumeLayout(false);
            this.GpbDatosMesa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPedidosMesa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtTotalLiteral;
        private System.Windows.Forms.TextBox TxtTotalNumerico;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnQuitarCarrito;
        private System.Windows.Forms.Button BtnAgregarCarrito;
        private System.Windows.Forms.TextBox TxtCantidadCompra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtStockProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPrecioUnitario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.Button BtnBuscarProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDocumentoCliente;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigoPedido;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.ComboBox CmbCodigoMesa;
        private System.Windows.Forms.DateTimePicker DtpFechaPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbTipoPedido;
        private System.Windows.Forms.GroupBox GpbDatosDelivery;
        private System.Windows.Forms.TextBox TxtFamiliaDelivery;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtDireccionDelivery;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtReferenciaDelivery;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox CmbEstadoPedido;
        private System.Windows.Forms.GroupBox GpbDatosMesa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbNumeroPiso;
        private System.Windows.Forms.Button BtnNuevoCliente;
    }
}
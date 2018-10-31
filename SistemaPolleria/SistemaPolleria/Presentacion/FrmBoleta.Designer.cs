namespace SistemaPolleria.Presentacion
{
    partial class FrmBoleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBoleta));
            this.DgvPedidosMesa = new System.Windows.Forms.DataGridView();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtNumeroBoleta = new System.Windows.Forms.TextBox();
            this.TxtSerieBoleta = new System.Windows.Forms.TextBox();
            this.TxtRucBoleta = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtTotalLiteral = new System.Windows.Forms.TextBox();
            this.TxtTotalNumerico = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnQuitarCarrito = new System.Windows.Forms.Button();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.BtnAgregarCarrito = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
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
            this.GpbEstado = new System.Windows.Forms.GroupBox();
            this.RdnEstadoCancelado = new System.Windows.Forms.RadioButton();
            this.RdnEstadoEspera = new System.Windows.Forms.RadioButton();
            this.RdnEstadoAtendido = new System.Windows.Forms.RadioButton();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.CmbCodigoMesa = new System.Windows.Forms.ComboBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosMesa)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GpbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvPedidosMesa
            // 
            this.DgvPedidosMesa.AllowUserToAddRows = false;
            this.DgvPedidosMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidosMesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCTO,
            this.CANTIDAD,
            this.PRECIO,
            this.IMPORTE});
            this.DgvPedidosMesa.Location = new System.Drawing.Point(21, 426);
            this.DgvPedidosMesa.Name = "DgvPedidosMesa";
            this.DgvPedidosMesa.ReadOnly = true;
            this.DgvPedidosMesa.Size = new System.Drawing.Size(752, 204);
            this.DgvPedidosMesa.TabIndex = 290;
            // 
            // IDPRODUCTO
            // 
            this.IDPRODUCTO.HeaderText = "IDPRODUCTO";
            this.IDPRODUCTO.Name = "IDPRODUCTO";
            this.IDPRODUCTO.ReadOnly = true;
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
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            this.IMPORTE.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TxtNumeroBoleta);
            this.groupBox5.Controls.Add(this.TxtSerieBoleta);
            this.groupBox5.Controls.Add(this.TxtRucBoleta);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox5.ForeColor = System.Drawing.Color.Gray;
            this.groupBox5.Location = new System.Drawing.Point(290, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(483, 48);
            this.groupBox5.TabIndex = 289;
            this.groupBox5.TabStop = false;
            // 
            // TxtNumeroBoleta
            // 
            this.TxtNumeroBoleta.BackColor = System.Drawing.Color.Silver;
            this.TxtNumeroBoleta.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.TxtNumeroBoleta.ForeColor = System.Drawing.Color.Black;
            this.TxtNumeroBoleta.Location = new System.Drawing.Point(398, 16);
            this.TxtNumeroBoleta.Name = "TxtNumeroBoleta";
            this.TxtNumeroBoleta.Size = new System.Drawing.Size(79, 22);
            this.TxtNumeroBoleta.TabIndex = 193;
            // 
            // TxtSerieBoleta
            // 
            this.TxtSerieBoleta.BackColor = System.Drawing.Color.Silver;
            this.TxtSerieBoleta.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.TxtSerieBoleta.ForeColor = System.Drawing.Color.Black;
            this.TxtSerieBoleta.Location = new System.Drawing.Point(247, 14);
            this.TxtSerieBoleta.Name = "TxtSerieBoleta";
            this.TxtSerieBoleta.Size = new System.Drawing.Size(79, 22);
            this.TxtSerieBoleta.TabIndex = 192;
            this.TxtSerieBoleta.Text = "B001";
            // 
            // TxtRucBoleta
            // 
            this.TxtRucBoleta.BackColor = System.Drawing.Color.Silver;
            this.TxtRucBoleta.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.TxtRucBoleta.ForeColor = System.Drawing.Color.Black;
            this.TxtRucBoleta.Location = new System.Drawing.Point(65, 15);
            this.TxtRucBoleta.Name = "TxtRucBoleta";
            this.TxtRucBoleta.Size = new System.Drawing.Size(104, 22);
            this.TxtRucBoleta.TabIndex = 191;
            this.TxtRucBoleta.Text = "10726555937";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Roboto", 9.25F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label18.Location = new System.Drawing.Point(333, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 18);
            this.label18.TabIndex = 181;
            this.label18.Text = "NUMERO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 9.25F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label16.Location = new System.Drawing.Point(193, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 18);
            this.label16.TabIndex = 180;
            this.label16.Text = "SERIE";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto", 9.25F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 18);
            this.label17.TabIndex = 179;
            this.label17.Text = "RUC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(23, 640);
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
            this.TxtTotalLiteral.Location = new System.Drawing.Point(130, 636);
            this.TxtTotalLiteral.Name = "TxtTotalLiteral";
            this.TxtTotalLiteral.Size = new System.Drawing.Size(440, 26);
            this.TxtTotalLiteral.TabIndex = 288;
            // 
            // TxtTotalNumerico
            // 
            this.TxtTotalNumerico.BackColor = System.Drawing.Color.White;
            this.TxtTotalNumerico.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtTotalNumerico.ForeColor = System.Drawing.Color.Black;
            this.TxtTotalNumerico.Location = new System.Drawing.Point(667, 636);
            this.TxtTotalNumerico.Name = "TxtTotalNumerico";
            this.TxtTotalNumerico.Size = new System.Drawing.Size(106, 26);
            this.TxtTotalNumerico.TabIndex = 287;
            this.TxtTotalNumerico.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnQuitarCarrito);
            this.groupBox4.Controls.Add(this.TxtSubtotal);
            this.groupBox4.Controls.Add(this.BtnAgregarCarrito);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.TxtCantidadCompra);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox4.ForeColor = System.Drawing.Color.Gray;
            this.groupBox4.Location = new System.Drawing.Point(21, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(752, 85);
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
            this.BtnQuitarCarrito.Location = new System.Drawing.Point(551, 25);
            this.BtnQuitarCarrito.Name = "BtnQuitarCarrito";
            this.BtnQuitarCarrito.Size = new System.Drawing.Size(168, 48);
            this.BtnQuitarCarrito.TabIndex = 275;
            this.BtnQuitarCarrito.Text = "Quitar del Pedido";
            this.BtnQuitarCarrito.UseVisualStyleBackColor = false;
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.BackColor = System.Drawing.Color.White;
            this.TxtSubtotal.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtSubtotal.ForeColor = System.Drawing.Color.Black;
            this.TxtSubtotal.Location = new System.Drawing.Point(209, 49);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(117, 26);
            this.TxtSubtotal.TabIndex = 267;
            // 
            // BtnAgregarCarrito
            // 
            this.BtnAgregarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnAgregarCarrito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCarrito.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarCarrito.Location = new System.Drawing.Point(352, 25);
            this.BtnAgregarCarrito.Name = "BtnAgregarCarrito";
            this.BtnAgregarCarrito.Size = new System.Drawing.Size(173, 48);
            this.BtnAgregarCarrito.TabIndex = 274;
            this.BtnAgregarCarrito.Text = "Agregar al Pedido";
            this.BtnAgregarCarrito.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(207, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 268;
            this.label12.Text = "Subtotal";
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
            this.groupBox3.Location = new System.Drawing.Point(21, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 76);
            this.groupBox3.TabIndex = 284;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Producto";
            // 
            // TxtStockProducto
            // 
            this.TxtStockProducto.BackColor = System.Drawing.Color.White;
            this.TxtStockProducto.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtStockProducto.ForeColor = System.Drawing.Color.Black;
            this.TxtStockProducto.Location = new System.Drawing.Point(588, 41);
            this.TxtStockProducto.Name = "TxtStockProducto";
            this.TxtStockProducto.Size = new System.Drawing.Size(117, 26);
            this.TxtStockProducto.TabIndex = 267;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(586, 21);
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
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(450, 41);
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(117, 26);
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
            this.TxtCodigoProducto.Size = new System.Drawing.Size(132, 26);
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
            this.BtnBuscarProducto.Location = new System.Drawing.Point(152, 41);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(39, 26);
            this.BtnBuscarProducto.TabIndex = 262;
            this.BtnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(448, 21);
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
            this.TxtNombreProducto.Location = new System.Drawing.Point(209, 41);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(204, 26);
            this.TxtNombreProducto.TabIndex = 263;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(206, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 17);
            this.label11.TabIndex = 264;
            this.label11.Text = "Nombre del Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtTelefono);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtDocumentoCliente);
            this.groupBox2.Controls.Add(this.BtnBuscarCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtRazonSocial);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(21, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 76);
            this.groupBox2.TabIndex = 283;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BackColor = System.Drawing.Color.White;
            this.TxtTelefono.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtTelefono.ForeColor = System.Drawing.Color.Black;
            this.TxtTelefono.Location = new System.Drawing.Point(352, 40);
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
            this.TxtDocumentoCliente.Size = new System.Drawing.Size(132, 26);
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
            this.BtnBuscarCliente.Location = new System.Drawing.Point(152, 40);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(39, 26);
            this.BtnBuscarCliente.TabIndex = 262;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(349, 20);
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
            this.TxtRazonSocial.Location = new System.Drawing.Point(209, 40);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(117, 26);
            this.TxtRazonSocial.TabIndex = 263;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(206, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 264;
            this.label1.Text = "Razon Social";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GpbEstado);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.Codigo);
            this.groupBox1.Controls.Add(this.CmbCodigoMesa);
            this.groupBox1.Controls.Add(this.DtpFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(21, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 86);
            this.groupBox1.TabIndex = 282;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(159, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 254;
            this.label2.Text = "Codigo de Mesa";
            // 
            // GpbEstado
            // 
            this.GpbEstado.Controls.Add(this.RdnEstadoCancelado);
            this.GpbEstado.Controls.Add(this.RdnEstadoEspera);
            this.GpbEstado.Controls.Add(this.RdnEstadoAtendido);
            this.GpbEstado.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.GpbEstado.ForeColor = System.Drawing.Color.Gray;
            this.GpbEstado.Location = new System.Drawing.Point(465, 16);
            this.GpbEstado.Name = "GpbEstado";
            this.GpbEstado.Size = new System.Drawing.Size(281, 54);
            this.GpbEstado.TabIndex = 269;
            this.GpbEstado.TabStop = false;
            this.GpbEstado.Text = "Estado";
            // 
            // RdnEstadoCancelado
            // 
            this.RdnEstadoCancelado.AutoSize = true;
            this.RdnEstadoCancelado.Location = new System.Drawing.Point(181, 20);
            this.RdnEstadoCancelado.Name = "RdnEstadoCancelado";
            this.RdnEstadoCancelado.Size = new System.Drawing.Size(94, 23);
            this.RdnEstadoCancelado.TabIndex = 2;
            this.RdnEstadoCancelado.TabStop = true;
            this.RdnEstadoCancelado.Text = "Cancelado";
            this.RdnEstadoCancelado.UseVisualStyleBackColor = true;
            // 
            // RdnEstadoEspera
            // 
            this.RdnEstadoEspera.AutoSize = true;
            this.RdnEstadoEspera.Location = new System.Drawing.Point(105, 20);
            this.RdnEstadoEspera.Name = "RdnEstadoEspera";
            this.RdnEstadoEspera.Size = new System.Drawing.Size(70, 23);
            this.RdnEstadoEspera.TabIndex = 1;
            this.RdnEstadoEspera.TabStop = true;
            this.RdnEstadoEspera.Text = "Espera";
            this.RdnEstadoEspera.UseVisualStyleBackColor = true;
            // 
            // RdnEstadoAtendido
            // 
            this.RdnEstadoAtendido.AutoSize = true;
            this.RdnEstadoAtendido.Location = new System.Drawing.Point(15, 20);
            this.RdnEstadoAtendido.Name = "RdnEstadoAtendido";
            this.RdnEstadoAtendido.Size = new System.Drawing.Size(84, 23);
            this.RdnEstadoAtendido.TabIndex = 0;
            this.RdnEstadoAtendido.TabStop = true;
            this.RdnEstadoAtendido.Text = "Atendido";
            this.RdnEstadoAtendido.UseVisualStyleBackColor = true;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.White;
            this.TxtCodigo.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtCodigo.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigo.Location = new System.Drawing.Point(21, 44);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(117, 26);
            this.TxtCodigo.TabIndex = 248;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Codigo.ForeColor = System.Drawing.Color.Gray;
            this.Codigo.Location = new System.Drawing.Point(18, 24);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(120, 17);
            this.Codigo.TabIndex = 249;
            this.Codigo.Text = "Codigo de Pedido";
            // 
            // CmbCodigoMesa
            // 
            this.CmbCodigoMesa.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.CmbCodigoMesa.ForeColor = System.Drawing.Color.Gray;
            this.CmbCodigoMesa.FormattingEnabled = true;
            this.CmbCodigoMesa.Location = new System.Drawing.Point(162, 43);
            this.CmbCodigoMesa.Name = "CmbCodigoMesa";
            this.CmbCodigoMesa.Size = new System.Drawing.Size(109, 27);
            this.CmbCodigoMesa.TabIndex = 255;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(300, 44);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(153, 26);
            this.DtpFecha.TabIndex = 256;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(297, 23);
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
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 28);
            this.label6.TabIndex = 281;
            this.label6.Text = "Formulario Pedidos Mesa";
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
            this.BtnNuevo.Location = new System.Drawing.Point(646, 668);
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
            this.BtnGuardar.Location = new System.Drawing.Point(513, 668);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(127, 32);
            this.BtnGuardar.TabIndex = 279;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // FrmBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 710);
            this.Controls.Add(this.DgvPedidosMesa);
            this.Controls.Add(this.groupBox5);
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
            this.Name = "FrmBoleta";
            this.Text = "FrmBoleta";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosMesa)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GpbEstado.ResumeLayout(false);
            this.GpbEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPedidosMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxtNumeroBoleta;
        private System.Windows.Forms.TextBox TxtSerieBoleta;
        private System.Windows.Forms.TextBox TxtRucBoleta;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtTotalLiteral;
        private System.Windows.Forms.TextBox TxtTotalNumerico;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnQuitarCarrito;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.Button BtnAgregarCarrito;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.GroupBox GpbEstado;
        private System.Windows.Forms.RadioButton RdnEstadoCancelado;
        private System.Windows.Forms.RadioButton RdnEstadoEspera;
        private System.Windows.Forms.RadioButton RdnEstadoAtendido;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.ComboBox CmbCodigoMesa;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnGuardar;
    }
}
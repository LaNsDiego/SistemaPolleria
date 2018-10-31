namespace SistemaPolleria.Presentacion
{
    partial class FrmPedidoMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoMesa));
            this.CmbCodigoMesa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.TxtCodigoPedido = new System.Windows.Forms.TextBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.GpbEstado = new System.Windows.Forms.GroupBox();
            this.RdnEstadoCancelado = new System.Windows.Forms.RadioButton();
            this.RdnEstadoEspera = new System.Windows.Forms.RadioButton();
            this.RdnEstadoAtendido = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnQuitarCarrito = new System.Windows.Forms.Button();
            this.BtnAgregarCarrito = new System.Windows.Forms.Button();
            this.TxtCantidadCompra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtTotalLiteral = new System.Windows.Forms.TextBox();
            this.TxtTotalNumerico = new System.Windows.Forms.TextBox();
            this.DgvPedidosMesa = new System.Windows.Forms.DataGridView();
            this.BtnRealizarPago = new System.Windows.Forms.Button();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbNumeroPiso = new System.Windows.Forms.ComboBox();
            this.GpbEstado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbCodigoMesa
            // 
            this.CmbCodigoMesa.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.CmbCodigoMesa.ForeColor = System.Drawing.Color.Gray;
            this.CmbCodigoMesa.FormattingEnabled = true;
            this.CmbCodigoMesa.Location = new System.Drawing.Point(253, 43);
            this.CmbCodigoMesa.Name = "CmbCodigoMesa";
            this.CmbCodigoMesa.Size = new System.Drawing.Size(109, 27);
            this.CmbCodigoMesa.TabIndex = 255;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(250, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 254;
            this.label2.Text = "Codigo de Mesa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(23, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 28);
            this.label6.TabIndex = 251;
            this.label6.Text = "Formulario Pedidos Mesa";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Codigo.ForeColor = System.Drawing.Color.Gray;
            this.Codigo.Location = new System.Drawing.Point(4, 24);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(120, 17);
            this.Codigo.TabIndex = 249;
            this.Codigo.Text = "Codigo de Pedido";
            // 
            // TxtCodigoPedido
            // 
            this.TxtCodigoPedido.BackColor = System.Drawing.Color.White;
            this.TxtCodigoPedido.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtCodigoPedido.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigoPedido.Location = new System.Drawing.Point(7, 44);
            this.TxtCodigoPedido.Name = "TxtCodigoPedido";
            this.TxtCodigoPedido.Size = new System.Drawing.Size(117, 26);
            this.TxtCodigoPedido.TabIndex = 248;
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
            this.BtnNuevo.Location = new System.Drawing.Point(675, 575);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(127, 32);
            this.BtnNuevo.TabIndex = 247;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
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
            this.BtnGuardar.Location = new System.Drawing.Point(542, 575);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(127, 32);
            this.BtnGuardar.TabIndex = 245;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DtpFechaPedido
            // 
            this.DtpFechaPedido.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.DtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaPedido.Location = new System.Drawing.Point(368, 44);
            this.DtpFechaPedido.Name = "DtpFechaPedido";
            this.DtpFechaPedido.Size = new System.Drawing.Size(113, 26);
            this.DtpFechaPedido.TabIndex = 256;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(365, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 257;
            this.label3.Text = "Fecha";
            // 
            // GpbEstado
            // 
            this.GpbEstado.Controls.Add(this.RdnEstadoCancelado);
            this.GpbEstado.Controls.Add(this.RdnEstadoEspera);
            this.GpbEstado.Controls.Add(this.RdnEstadoAtendido);
            this.GpbEstado.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.GpbEstado.ForeColor = System.Drawing.Color.Gray;
            this.GpbEstado.Location = new System.Drawing.Point(487, 16);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CmbNumeroPiso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GpbEstado);
            this.groupBox1.Controls.Add(this.TxtCodigoPedido);
            this.groupBox1.Controls.Add(this.Codigo);
            this.groupBox1.Controls.Add(this.CmbCodigoMesa);
            this.groupBox1.Controls.Add(this.DtpFechaPedido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 86);
            this.groupBox1.TabIndex = 270;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Pedido";
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
            this.groupBox3.Location = new System.Drawing.Point(12, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(790, 76);
            this.groupBox3.TabIndex = 272;
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
            this.label8.Location = new System.Drawing.Point(4, 21);
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
            this.TxtCodigoProducto.Location = new System.Drawing.Point(7, 41);
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
            this.BtnBuscarProducto.Location = new System.Drawing.Point(138, 41);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnQuitarCarrito);
            this.groupBox4.Controls.Add(this.BtnAgregarCarrito);
            this.groupBox4.Controls.Add(this.TxtCantidadCompra);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox4.ForeColor = System.Drawing.Color.Gray;
            this.groupBox4.Location = new System.Drawing.Point(12, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(790, 85);
            this.groupBox4.TabIndex = 273;
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
            this.BtnAgregarCarrito.Click += new System.EventHandler(this.BtnAgregarCarrito_Click);
            // 
            // TxtCantidadCompra
            // 
            this.TxtCantidadCompra.BackColor = System.Drawing.Color.White;
            this.TxtCantidadCompra.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtCantidadCompra.ForeColor = System.Drawing.Color.Black;
            this.TxtCantidadCompra.Location = new System.Drawing.Point(6, 49);
            this.TxtCantidadCompra.Name = "TxtCantidadCompra";
            this.TxtCantidadCompra.Size = new System.Drawing.Size(171, 26);
            this.TxtCantidadCompra.TabIndex = 265;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(4, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 17);
            this.label14.TabIndex = 266;
            this.label14.Text = "Cantidad a comprar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(30, 547);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 17);
            this.label13.TabIndex = 274;
            this.label13.Text = "Monto a Pagar";
            // 
            // TxtTotalLiteral
            // 
            this.TxtTotalLiteral.BackColor = System.Drawing.Color.White;
            this.TxtTotalLiteral.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtTotalLiteral.ForeColor = System.Drawing.Color.Black;
            this.TxtTotalLiteral.Location = new System.Drawing.Point(137, 543);
            this.TxtTotalLiteral.Name = "TxtTotalLiteral";
            this.TxtTotalLiteral.Size = new System.Drawing.Size(440, 26);
            this.TxtTotalLiteral.TabIndex = 276;
            // 
            // TxtTotalNumerico
            // 
            this.TxtTotalNumerico.BackColor = System.Drawing.Color.White;
            this.TxtTotalNumerico.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtTotalNumerico.ForeColor = System.Drawing.Color.Black;
            this.TxtTotalNumerico.Location = new System.Drawing.Point(696, 543);
            this.TxtTotalNumerico.Name = "TxtTotalNumerico";
            this.TxtTotalNumerico.Size = new System.Drawing.Size(106, 26);
            this.TxtTotalNumerico.TabIndex = 275;
            this.TxtTotalNumerico.Text = "0";
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
            this.IMPORTE});
            this.DgvPedidosMesa.Location = new System.Drawing.Point(12, 324);
            this.DgvPedidosMesa.Name = "DgvPedidosMesa";
            this.DgvPedidosMesa.ReadOnly = true;
            this.DgvPedidosMesa.Size = new System.Drawing.Size(790, 204);
            this.DgvPedidosMesa.TabIndex = 278;
            // 
            // BtnRealizarPago
            // 
            this.BtnRealizarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnRealizarPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnRealizarPago.FlatAppearance.BorderSize = 0;
            this.BtnRealizarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnRealizarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRealizarPago.Font = new System.Drawing.Font("Roboto", 10F);
            this.BtnRealizarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRealizarPago.Location = new System.Drawing.Point(409, 575);
            this.BtnRealizarPago.Name = "BtnRealizarPago";
            this.BtnRealizarPago.Size = new System.Drawing.Size(127, 32);
            this.BtnRealizarPago.TabIndex = 279;
            this.BtnRealizarPago.Text = "Realizar Pago";
            this.BtnRealizarPago.UseVisualStyleBackColor = false;
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
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            this.IMPORTE.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(650, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 280;
            this.label1.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(135, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 270;
            this.label4.Text = "Numero de Piso";
            // 
            // CmbNumeroPiso
            // 
            this.CmbNumeroPiso.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.CmbNumeroPiso.ForeColor = System.Drawing.Color.Gray;
            this.CmbNumeroPiso.FormattingEnabled = true;
            this.CmbNumeroPiso.Location = new System.Drawing.Point(138, 44);
            this.CmbNumeroPiso.Name = "CmbNumeroPiso";
            this.CmbNumeroPiso.Size = new System.Drawing.Size(109, 27);
            this.CmbNumeroPiso.TabIndex = 271;
            // 
            // FrmPedidoMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(814, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRealizarPago);
            this.Controls.Add(this.DgvPedidosMesa);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtTotalLiteral);
            this.Controls.Add(this.TxtTotalNumerico);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPedidoMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPedido";
            this.Load += new System.EventHandler(this.FrmPedidoMesa_Load);
            this.GpbEstado.ResumeLayout(false);
            this.GpbEstado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbCodigoMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.TextBox TxtCodigoPedido;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DateTimePicker DtpFechaPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GpbEstado;
        private System.Windows.Forms.RadioButton RdnEstadoEspera;
        private System.Windows.Forms.RadioButton RdnEstadoAtendido;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtCantidadCompra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnQuitarCarrito;
        private System.Windows.Forms.Button BtnAgregarCarrito;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtTotalLiteral;
        private System.Windows.Forms.TextBox TxtTotalNumerico;
        private System.Windows.Forms.RadioButton RdnEstadoCancelado;
        private System.Windows.Forms.DataGridView DgvPedidosMesa;
        private System.Windows.Forms.Button BtnRealizarPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbNumeroPiso;
    }
}
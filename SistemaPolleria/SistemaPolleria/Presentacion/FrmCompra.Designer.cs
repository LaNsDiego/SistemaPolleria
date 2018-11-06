namespace SistemaPolleria.Presentacion
{
    partial class FrmCompra
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtTotalLiteral = new System.Windows.Forms.TextBox();
            this.TxtTotalNumerico = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtNombreInsumo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCostoUnitario = new System.Windows.Forms.TextBox();
            this.TxtIdInsumo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCantidadCompra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtRuc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodigoProveedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtRazonSocialProveedor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtRazonSocialEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtObservacion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.IdInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtValorIgv = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TxtNumero);
            this.groupBox5.Controls.Add(this.TxtSerie);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox5.ForeColor = System.Drawing.Color.Gray;
            this.groupBox5.Location = new System.Drawing.Point(473, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(305, 48);
            this.groupBox5.TabIndex = 289;
            this.groupBox5.TabStop = false;
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.Color.Silver;
            this.TxtNumero.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.TxtNumero.ForeColor = System.Drawing.Color.Black;
            this.TxtNumero.Location = new System.Drawing.Point(210, 20);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(79, 22);
            this.TxtNumero.TabIndex = 193;
            this.TxtNumero.Text = "000";
            // 
            // TxtSerie
            // 
            this.TxtSerie.BackColor = System.Drawing.Color.Silver;
            this.TxtSerie.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.TxtSerie.ForeColor = System.Drawing.Color.Black;
            this.TxtSerie.Location = new System.Drawing.Point(59, 18);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(79, 22);
            this.TxtSerie.TabIndex = 192;
            this.TxtSerie.Text = "F001";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Roboto", 9.25F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label18.Location = new System.Drawing.Point(145, 20);
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
            this.label16.Location = new System.Drawing.Point(5, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 18);
            this.label16.TabIndex = 180;
            this.label16.Text = "SERIE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(30, 667);
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
            this.TxtTotalLiteral.Location = new System.Drawing.Point(137, 663);
            this.TxtTotalLiteral.Name = "TxtTotalLiteral";
            this.TxtTotalLiteral.Size = new System.Drawing.Size(271, 26);
            this.TxtTotalLiteral.TabIndex = 288;
            // 
            // TxtTotalNumerico
            // 
            this.TxtTotalNumerico.BackColor = System.Drawing.Color.White;
            this.TxtTotalNumerico.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtTotalNumerico.ForeColor = System.Drawing.Color.Black;
            this.TxtTotalNumerico.Location = new System.Drawing.Point(683, 663);
            this.TxtTotalNumerico.Name = "TxtTotalNumerico";
            this.TxtTotalNumerico.Size = new System.Drawing.Size(97, 26);
            this.TxtTotalNumerico.TabIndex = 287;
            this.TxtTotalNumerico.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtNombreInsumo);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.TxtCostoUnitario);
            this.groupBox4.Controls.Add(this.TxtIdInsumo);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.TxtCantidadCompra);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox4.ForeColor = System.Drawing.Color.Gray;
            this.groupBox4.Location = new System.Drawing.Point(26, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(752, 85);
            this.groupBox4.TabIndex = 285;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del Detalle de la Compra";
            // 
            // TxtNombreInsumo
            // 
            this.TxtNombreInsumo.BackColor = System.Drawing.Color.White;
            this.TxtNombreInsumo.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtNombreInsumo.ForeColor = System.Drawing.Color.Black;
            this.TxtNombreInsumo.Location = new System.Drawing.Point(197, 49);
            this.TxtNombreInsumo.Name = "TxtNombreInsumo";
            this.TxtNombreInsumo.Size = new System.Drawing.Size(164, 26);
            this.TxtNombreInsumo.TabIndex = 271;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(195, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 17);
            this.label9.TabIndex = 272;
            this.label9.Text = "Nombre del Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(18, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 268;
            this.label7.Text = "Codigo del Insumo";
            // 
            // TxtCostoUnitario
            // 
            this.TxtCostoUnitario.BackColor = System.Drawing.Color.White;
            this.TxtCostoUnitario.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtCostoUnitario.ForeColor = System.Drawing.Color.Black;
            this.TxtCostoUnitario.Location = new System.Drawing.Point(503, 50);
            this.TxtCostoUnitario.Name = "TxtCostoUnitario";
            this.TxtCostoUnitario.Size = new System.Drawing.Size(92, 26);
            this.TxtCostoUnitario.TabIndex = 269;
            // 
            // TxtIdInsumo
            // 
            this.TxtIdInsumo.BackColor = System.Drawing.Color.White;
            this.TxtIdInsumo.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtIdInsumo.ForeColor = System.Drawing.Color.Black;
            this.TxtIdInsumo.Location = new System.Drawing.Point(21, 49);
            this.TxtIdInsumo.Name = "TxtIdInsumo";
            this.TxtIdInsumo.Size = new System.Drawing.Size(132, 26);
            this.TxtIdInsumo.TabIndex = 267;
            this.TxtIdInsumo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIdProducto_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(501, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 270;
            this.label5.Text = "Costo Unitario";
            // 
            // TxtCantidadCompra
            // 
            this.TxtCantidadCompra.BackColor = System.Drawing.Color.White;
            this.TxtCantidadCompra.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtCantidadCompra.ForeColor = System.Drawing.Color.Black;
            this.TxtCantidadCompra.Location = new System.Drawing.Point(367, 50);
            this.TxtCantidadCompra.Name = "TxtCantidadCompra";
            this.TxtCantidadCompra.Size = new System.Drawing.Size(130, 26);
            this.TxtCantidadCompra.TabIndex = 265;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(365, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 17);
            this.label14.TabIndex = 266;
            this.label14.Text = "Cantidad compra";
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitar.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.BtnQuitar.ForeColor = System.Drawing.Color.White;
            this.BtnQuitar.Location = new System.Drawing.Point(602, 422);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(178, 48);
            this.BtnQuitar.TabIndex = 275;
            this.BtnQuitar.Text = "Quitar del Pedido";
            this.BtnQuitar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(404, 422);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(172, 48);
            this.BtnAgregar.TabIndex = 274;
            this.BtnAgregar.Text = "Agregar al Pedido";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtRuc);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtCodigoProveedor);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TxtRazonSocialProveedor);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox3.ForeColor = System.Drawing.Color.Gray;
            this.groupBox3.Location = new System.Drawing.Point(26, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 76);
            this.groupBox3.TabIndex = 284;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Proveedor";
            // 
            // TxtRuc
            // 
            this.TxtRuc.BackColor = System.Drawing.Color.White;
            this.TxtRuc.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtRuc.ForeColor = System.Drawing.Color.Black;
            this.TxtRuc.Location = new System.Drawing.Point(516, 42);
            this.TxtRuc.Name = "TxtRuc";
            this.TxtRuc.Size = new System.Drawing.Size(117, 26);
            this.TxtRuc.TabIndex = 265;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(18, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 17);
            this.label8.TabIndex = 261;
            this.label8.Text = "Codigo del Proveedor";
            // 
            // TxtCodigoProveedor
            // 
            this.TxtCodigoProveedor.BackColor = System.Drawing.Color.White;
            this.TxtCodigoProveedor.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtCodigoProveedor.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigoProveedor.Location = new System.Drawing.Point(21, 41);
            this.TxtCodigoProveedor.Name = "TxtCodigoProveedor";
            this.TxtCodigoProveedor.Size = new System.Drawing.Size(132, 26);
            this.TxtCodigoProveedor.TabIndex = 260;
            this.TxtCodigoProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoProveedor_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(514, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 266;
            this.label10.Text = "RUC";
            // 
            // TxtRazonSocialProveedor
            // 
            this.TxtRazonSocialProveedor.BackColor = System.Drawing.Color.White;
            this.TxtRazonSocialProveedor.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtRazonSocialProveedor.ForeColor = System.Drawing.Color.Black;
            this.TxtRazonSocialProveedor.Location = new System.Drawing.Point(209, 41);
            this.TxtRazonSocialProveedor.Name = "TxtRazonSocialProveedor";
            this.TxtRazonSocialProveedor.Size = new System.Drawing.Size(298, 26);
            this.TxtRazonSocialProveedor.TabIndex = 263;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(206, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 264;
            this.label11.Text = "Razon Social";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtDocumento);
            this.groupBox2.Controls.Add(this.TxtRazonSocialEmpleado);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(26, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 76);
            this.groupBox2.TabIndex = 283;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 261;
            this.label4.Text = "Codigo del Empleado";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.BackColor = System.Drawing.Color.White;
            this.TxtDocumento.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtDocumento.ForeColor = System.Drawing.Color.Black;
            this.TxtDocumento.Location = new System.Drawing.Point(21, 40);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(132, 26);
            this.TxtDocumento.TabIndex = 260;
            // 
            // TxtRazonSocialEmpleado
            // 
            this.TxtRazonSocialEmpleado.BackColor = System.Drawing.Color.White;
            this.TxtRazonSocialEmpleado.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtRazonSocialEmpleado.ForeColor = System.Drawing.Color.Black;
            this.TxtRazonSocialEmpleado.Location = new System.Drawing.Point(209, 40);
            this.TxtRazonSocialEmpleado.Name = "TxtRazonSocialEmpleado";
            this.TxtRazonSocialEmpleado.Size = new System.Drawing.Size(496, 26);
            this.TxtRazonSocialEmpleado.TabIndex = 263;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(206, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 264;
            this.label1.Text = "Nombre completo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtObservacion);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbTipoComprobante);
            this.groupBox1.Controls.Add(this.DtpFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(26, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 86);
            this.groupBox1.TabIndex = 282;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Compra";
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.BackColor = System.Drawing.Color.White;
            this.TxtObservacion.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtObservacion.ForeColor = System.Drawing.Color.Black;
            this.TxtObservacion.Location = new System.Drawing.Point(179, 43);
            this.TxtObservacion.Name = "TxtObservacion";
            this.TxtObservacion.Size = new System.Drawing.Size(308, 26);
            this.TxtObservacion.TabIndex = 258;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(176, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 17);
            this.label15.TabIndex = 259;
            this.label15.Text = "Observacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 254;
            this.label2.Text = "Tipo de Comprobante";
            // 
            // CmbTipoComprobante
            // 
            this.CmbTipoComprobante.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.CmbTipoComprobante.ForeColor = System.Drawing.Color.Gray;
            this.CmbTipoComprobante.FormattingEnabled = true;
            this.CmbTipoComprobante.Location = new System.Drawing.Point(17, 43);
            this.CmbTipoComprobante.Name = "CmbTipoComprobante";
            this.CmbTipoComprobante.Size = new System.Drawing.Size(142, 27);
            this.CmbTipoComprobante.TabIndex = 255;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(506, 43);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(116, 26);
            this.DtpFecha.TabIndex = 256;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(503, 22);
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
            this.label6.Location = new System.Drawing.Point(21, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 28);
            this.label6.TabIndex = 281;
            this.label6.Text = "Formulario Compra";
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
            this.BtnNuevo.Location = new System.Drawing.Point(653, 695);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(127, 32);
            this.BtnNuevo.TabIndex = 280;
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
            this.BtnGuardar.Location = new System.Drawing.Point(520, 695);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(127, 32);
            this.BtnGuardar.TabIndex = 279;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DgvDetalleCompra
            // 
            this.DgvDetalleCompra.AllowUserToAddRows = false;
            this.DgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInsumo,
            this.Insumo,
            this.Cantidad,
            this.CostoUnitario,
            this.Subtotal});
            this.DgvDetalleCompra.Location = new System.Drawing.Point(26, 478);
            this.DgvDetalleCompra.Name = "DgvDetalleCompra";
            this.DgvDetalleCompra.ReadOnly = true;
            this.DgvDetalleCompra.Size = new System.Drawing.Size(752, 179);
            this.DgvDetalleCompra.TabIndex = 278;
            // 
            // IdInsumo
            // 
            this.IdInsumo.HeaderText = "IdInsumo";
            this.IdInsumo.Name = "IdInsumo";
            this.IdInsumo.ReadOnly = true;
            // 
            // Insumo
            // 
            this.Insumo.HeaderText = "Insumo";
            this.Insumo.Name = "Insumo";
            this.Insumo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // CostoUnitario
            // 
            this.CostoUnitario.HeaderText = "CostoUnitario";
            this.CostoUnitario.Name = "CostoUnitario";
            this.CostoUnitario.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(633, 667);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 17);
            this.label17.TabIndex = 273;
            this.label17.Text = "Total";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label19.ForeColor = System.Drawing.Color.Gray;
            this.label19.Location = new System.Drawing.Point(409, 667);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 17);
            this.label19.TabIndex = 290;
            this.label19.Text = "Valor IGV(18%)";
            // 
            // TxtValorIgv
            // 
            this.TxtValorIgv.BackColor = System.Drawing.Color.White;
            this.TxtValorIgv.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtValorIgv.ForeColor = System.Drawing.Color.Black;
            this.TxtValorIgv.Location = new System.Drawing.Point(521, 663);
            this.TxtValorIgv.Name = "TxtValorIgv";
            this.TxtValorIgv.Size = new System.Drawing.Size(106, 26);
            this.TxtValorIgv.TabIndex = 291;
            this.TxtValorIgv.Text = "0";
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 739);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TxtValorIgv);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.BtnAgregar);
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
            this.Controls.Add(this.DgvDetalleCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompra";
            this.Text = "FrmCompra";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtTotalLiteral;
        private System.Windows.Forms.TextBox TxtTotalNumerico;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtCantidadCompra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtRuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCodigoProveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtRazonSocialProveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxtRazonSocialEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbTipoComprobante;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DgvDetalleCompra;
        private System.Windows.Forms.TextBox TxtNombreInsumo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCostoUnitario;
        private System.Windows.Forms.TextBox TxtIdInsumo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtObservacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtValorIgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}
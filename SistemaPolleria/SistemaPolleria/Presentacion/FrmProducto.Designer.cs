﻿namespace SistemaPolleria.Presentacion
{
    partial class FrmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvDetalleProducto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarInsumo = new System.Windows.Forms.Button();
            this.TxtIdInsumo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.TxtNombreInsumo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtCantidadUso = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnQuitarCarrito = new System.Windows.Forms.Button();
            this.BtnAgregarCarrito = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 223;
            this.label3.Text = "Precio";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BackColor = System.Drawing.Color.White;
            this.TxtPrecio.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtPrecio.ForeColor = System.Drawing.Color.Black;
            this.TxtPrecio.Location = new System.Drawing.Point(18, 102);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(109, 26);
            this.TxtPrecio.TabIndex = 222;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(316, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 221;
            this.label1.Text = "Cantidad";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.BackColor = System.Drawing.Color.White;
            this.TxtCantidad.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtCantidad.ForeColor = System.Drawing.Color.Black;
            this.TxtCantidad.Location = new System.Drawing.Point(319, 45);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(111, 26);
            this.TxtCantidad.TabIndex = 220;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(103, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 219;
            this.label4.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtNombre.Location = new System.Drawing.Point(106, 45);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(207, 26);
            this.TxtNombre.TabIndex = 218;
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
            this.BtnNuevo.Location = new System.Drawing.Point(308, 203);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(127, 32);
            this.BtnNuevo.TabIndex = 217;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Roboto", 10F);
            this.BtnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnModificar.Location = new System.Drawing.Point(175, 203);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(127, 32);
            this.BtnModificar.TabIndex = 216;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
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
            this.BtnGuardar.Location = new System.Drawing.Point(42, 203);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(127, 32);
            this.BtnGuardar.TabIndex = 215;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(234, -27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 28);
            this.label2.TabIndex = 214;
            this.label2.Text = "Formulario Producto";
            // 
            // DgvDetalleProducto
            // 
            this.DgvDetalleProducto.AllowUserToAddRows = false;
            this.DgvDetalleProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Insumo,
            this.IdInsumo,
            this.Cantidad});
            this.DgvDetalleProducto.Location = new System.Drawing.Point(610, 241);
            this.DgvDetalleProducto.Name = "DgvDetalleProducto";
            this.DgvDetalleProducto.ReadOnly = true;
            this.DgvDetalleProducto.Size = new System.Drawing.Size(446, 190);
            this.DgvDetalleProducto.TabIndex = 211;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Insumo
            // 
            this.Insumo.HeaderText = "Insumo";
            this.Insumo.Name = "Insumo";
            this.Insumo.ReadOnly = true;
            // 
            // IdInsumo
            // 
            this.IdInsumo.HeaderText = "IdInsumo";
            this.IdInsumo.Name = "IdInsumo";
            this.IdInsumo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(189, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 28);
            this.label6.TabIndex = 227;
            this.label6.Text = "Formulario Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(127, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 229;
            this.label5.Text = "Valor Total";
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.BackColor = System.Drawing.Color.White;
            this.TxtValorTotal.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtValorTotal.ForeColor = System.Drawing.Color.Black;
            this.TxtValorTotal.Location = new System.Drawing.Point(130, 101);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(111, 26);
            this.TxtValorTotal.TabIndex = 228;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(244, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 272;
            this.label7.Text = "Tipo de Producto";
            // 
            // CmbTipoProducto
            // 
            this.CmbTipoProducto.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.CmbTipoProducto.ForeColor = System.Drawing.Color.Gray;
            this.CmbTipoProducto.FormattingEnabled = true;
            this.CmbTipoProducto.Location = new System.Drawing.Point(247, 100);
            this.CmbTipoProducto.Name = "CmbTipoProducto";
            this.CmbTipoProducto.Size = new System.Drawing.Size(217, 27);
            this.CmbTipoProducto.TabIndex = 273;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtIdProducto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbTipoProducto);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtValorTotal);
            this.groupBox1.Controls.Add(this.TxtCantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtPrecio);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(42, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 146);
            this.groupBox1.TabIndex = 284;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto";
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.BackColor = System.Drawing.Color.White;
            this.TxtIdProducto.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtIdProducto.ForeColor = System.Drawing.Color.Black;
            this.TxtIdProducto.Location = new System.Drawing.Point(16, 45);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(84, 26);
            this.TxtIdProducto.TabIndex = 274;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(13, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 275;
            this.label8.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBuscarInsumo);
            this.groupBox2.Controls.Add(this.TxtIdInsumo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CmbUnidadMedida);
            this.groupBox2.Controls.Add(this.TxtNombreInsumo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.TxtCantidadUso);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(610, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 143);
            this.groupBox2.TabIndex = 285;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Insumo ( INGREDIENTE )";
            // 
            // BtnBuscarInsumo
            // 
            this.BtnBuscarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnBuscarInsumo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnBuscarInsumo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.BtnBuscarInsumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBuscarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarInsumo.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscarInsumo.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarInsumo.Image")));
            this.BtnBuscarInsumo.Location = new System.Drawing.Point(126, 45);
            this.BtnBuscarInsumo.Name = "BtnBuscarInsumo";
            this.BtnBuscarInsumo.Size = new System.Drawing.Size(39, 26);
            this.BtnBuscarInsumo.TabIndex = 276;
            this.BtnBuscarInsumo.UseVisualStyleBackColor = false;
            // 
            // TxtIdInsumo
            // 
            this.TxtIdInsumo.BackColor = System.Drawing.Color.White;
            this.TxtIdInsumo.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtIdInsumo.ForeColor = System.Drawing.Color.Black;
            this.TxtIdInsumo.Location = new System.Drawing.Point(16, 45);
            this.TxtIdInsumo.Name = "TxtIdInsumo";
            this.TxtIdInsumo.Size = new System.Drawing.Size(111, 26);
            this.TxtIdInsumo.TabIndex = 274;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(13, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 275;
            this.label10.Text = "Codigo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(143, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 272;
            this.label11.Text = "Unidad de Medida";
            // 
            // CmbUnidadMedida
            // 
            this.CmbUnidadMedida.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.CmbUnidadMedida.ForeColor = System.Drawing.Color.Gray;
            this.CmbUnidadMedida.FormattingEnabled = true;
            this.CmbUnidadMedida.Location = new System.Drawing.Point(143, 99);
            this.CmbUnidadMedida.Name = "CmbUnidadMedida";
            this.CmbUnidadMedida.Size = new System.Drawing.Size(137, 27);
            this.CmbUnidadMedida.TabIndex = 273;
            // 
            // TxtNombreInsumo
            // 
            this.TxtNombreInsumo.BackColor = System.Drawing.Color.White;
            this.TxtNombreInsumo.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtNombreInsumo.ForeColor = System.Drawing.Color.Black;
            this.TxtNombreInsumo.Location = new System.Drawing.Point(174, 44);
            this.TxtNombreInsumo.Name = "TxtNombreInsumo";
            this.TxtNombreInsumo.Size = new System.Drawing.Size(227, 26);
            this.TxtNombreInsumo.TabIndex = 218;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(171, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 219;
            this.label14.Text = "Nombre";
            // 
            // TxtCantidadUso
            // 
            this.TxtCantidadUso.BackColor = System.Drawing.Color.White;
            this.TxtCantidadUso.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtCantidadUso.ForeColor = System.Drawing.Color.Black;
            this.TxtCantidadUso.Location = new System.Drawing.Point(15, 99);
            this.TxtCantidadUso.Name = "TxtCantidadUso";
            this.TxtCantidadUso.Size = new System.Drawing.Size(122, 26);
            this.TxtCantidadUso.TabIndex = 220;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(12, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 17);
            this.label15.TabIndex = 221;
            this.label15.Text = "Cantidad a usar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 190);
            this.dataGridView1.TabIndex = 286;
            // 
            // BtnQuitarCarrito
            // 
            this.BtnQuitarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnQuitarCarrito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnQuitarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitarCarrito.Font = new System.Drawing.Font("Roboto", 10F);
            this.BtnQuitarCarrito.ForeColor = System.Drawing.Color.White;
            this.BtnQuitarCarrito.Location = new System.Drawing.Point(749, 203);
            this.BtnQuitarCarrito.Name = "BtnQuitarCarrito";
            this.BtnQuitarCarrito.Size = new System.Drawing.Size(127, 32);
            this.BtnQuitarCarrito.TabIndex = 288;
            this.BtnQuitarCarrito.Text = "Quitar";
            this.BtnQuitarCarrito.UseVisualStyleBackColor = false;
            // 
            // BtnAgregarCarrito
            // 
            this.BtnAgregarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnAgregarCarrito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCarrito.Font = new System.Drawing.Font("Roboto", 10F);
            this.BtnAgregarCarrito.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarCarrito.Location = new System.Drawing.Point(610, 203);
            this.BtnAgregarCarrito.Name = "BtnAgregarCarrito";
            this.BtnAgregarCarrito.Size = new System.Drawing.Size(127, 32);
            this.BtnAgregarCarrito.TabIndex = 287;
            this.BtnAgregarCarrito.Text = "Agregar";
            this.BtnAgregarCarrito.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(271, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 291;
            this.label9.Text = "Buscar por codigo";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.TxtBuscar.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtBuscar.ForeColor = System.Drawing.Color.Black;
            this.TxtBuscar.Location = new System.Drawing.Point(408, 437);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(177, 26);
            this.TxtBuscar.TabIndex = 290;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Roboto", 10F);
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnBuscar.Location = new System.Drawing.Point(42, 437);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(127, 32);
            this.BtnBuscar.TabIndex = 289;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 539);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnQuitarCarrito);
            this.Controls.Add(this.BtnAgregarCarrito);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvDetalleProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvDetalleProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbTipoProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtIdInsumo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbUnidadMedida;
        private System.Windows.Forms.TextBox TxtNombreInsumo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtCantidadUso;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button BtnBuscarInsumo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnQuitarCarrito;
        private System.Windows.Forms.Button BtnAgregarCarrito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnBuscar;
    }
}
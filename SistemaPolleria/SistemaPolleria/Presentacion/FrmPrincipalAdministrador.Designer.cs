namespace SistemaPolleria.Presentacion
{
    partial class FrmPrincipalAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalAdministrador));
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnKardexSalida = new System.Windows.Forms.Button();
            this.BtnReporteKardexEntrada = new System.Windows.Forms.Button();
            this.BtnListaPedido = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblApellidoUsuario = new System.Windows.Forms.Label();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.LblCargoUsuario = new System.Windows.Forms.Label();
            this.PtbFoto = new System.Windows.Forms.PictureBox();
            this.BtnCompra = new System.Windows.Forms.Button();
            this.BtnPedidoDelivery = new System.Windows.Forms.Button();
            this.BtnSalirSistema = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.BtnKardex = new System.Windows.Forms.Button();
            this.BtnInsumo = new System.Windows.Forms.Button();
            this.PanelPadre = new System.Windows.Forms.Panel();
            this.BtnPlanilla = new System.Windows.Forms.Button();
            this.BtnAsistencia = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.BtnInventario);
            this.panel3.Controls.Add(this.BtnAsistencia);
            this.panel3.Controls.Add(this.BtnPlanilla);
            this.panel3.Controls.Add(this.BtnKardexSalida);
            this.panel3.Controls.Add(this.BtnReporteKardexEntrada);
            this.panel3.Controls.Add(this.BtnListaPedido);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.BtnCompra);
            this.panel3.Controls.Add(this.BtnPedidoDelivery);
            this.panel3.Controls.Add(this.BtnSalirSistema);
            this.panel3.Controls.Add(this.BtnProducto);
            this.panel3.Controls.Add(this.BtnKardex);
            this.panel3.Controls.Add(this.BtnInsumo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 700);
            this.panel3.TabIndex = 4;
            // 
            // BtnKardexSalida
            // 
            this.BtnKardexSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnKardexSalida.FlatAppearance.BorderSize = 0;
            this.BtnKardexSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKardexSalida.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKardexSalida.ForeColor = System.Drawing.Color.White;
            this.BtnKardexSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKardexSalida.Location = new System.Drawing.Point(0, 621);
            this.BtnKardexSalida.Name = "BtnKardexSalida";
            this.BtnKardexSalida.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnKardexSalida.Size = new System.Drawing.Size(200, 43);
            this.BtnKardexSalida.TabIndex = 9;
            this.BtnKardexSalida.Text = "Reporte Kardex Salida";
            this.BtnKardexSalida.UseVisualStyleBackColor = false;
            this.BtnKardexSalida.Click += new System.EventHandler(this.BtnKardexSalida_Click);
            // 
            // BtnReporteKardexEntrada
            // 
            this.BtnReporteKardexEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnReporteKardexEntrada.FlatAppearance.BorderSize = 0;
            this.BtnReporteKardexEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporteKardexEntrada.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporteKardexEntrada.ForeColor = System.Drawing.Color.White;
            this.BtnReporteKardexEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReporteKardexEntrada.Location = new System.Drawing.Point(0, 572);
            this.BtnReporteKardexEntrada.Name = "BtnReporteKardexEntrada";
            this.BtnReporteKardexEntrada.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnReporteKardexEntrada.Size = new System.Drawing.Size(200, 43);
            this.BtnReporteKardexEntrada.TabIndex = 8;
            this.BtnReporteKardexEntrada.Text = "Reporte Kardex Entrada";
            this.BtnReporteKardexEntrada.UseVisualStyleBackColor = false;
            this.BtnReporteKardexEntrada.Click += new System.EventHandler(this.BtnReporteKardexEntrada_Click);
            // 
            // BtnListaPedido
            // 
            this.BtnListaPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnListaPedido.FlatAppearance.BorderSize = 0;
            this.BtnListaPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListaPedido.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListaPedido.ForeColor = System.Drawing.Color.White;
            this.BtnListaPedido.Image = ((System.Drawing.Image)(resources.GetObject("BtnListaPedido.Image")));
            this.BtnListaPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListaPedido.Location = new System.Drawing.Point(0, 371);
            this.BtnListaPedido.Name = "BtnListaPedido";
            this.BtnListaPedido.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnListaPedido.Size = new System.Drawing.Size(200, 43);
            this.BtnListaPedido.TabIndex = 7;
            this.BtnListaPedido.Text = "Lista Pedidos";
            this.BtnListaPedido.UseVisualStyleBackColor = false;
            this.BtnListaPedido.Click += new System.EventHandler(this.BtnListaPedido_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.LblApellidoUsuario);
            this.panel2.Controls.Add(this.LblNombreUsuario);
            this.panel2.Controls.Add(this.LblCargoUsuario);
            this.panel2.Controls.Add(this.PtbFoto);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 120);
            this.panel2.TabIndex = 6;
            // 
            // LblApellidoUsuario
            // 
            this.LblApellidoUsuario.AutoSize = true;
            this.LblApellidoUsuario.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.LblApellidoUsuario.ForeColor = System.Drawing.Color.White;
            this.LblApellidoUsuario.Location = new System.Drawing.Point(83, 61);
            this.LblApellidoUsuario.Name = "LblApellidoUsuario";
            this.LblApellidoUsuario.Size = new System.Drawing.Size(111, 15);
            this.LblApellidoUsuario.TabIndex = 1;
            this.LblApellidoUsuario.Text = "Apellidos y Nombres";
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.LblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.LblNombreUsuario.Location = new System.Drawing.Point(82, 40);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(111, 15);
            this.LblNombreUsuario.TabIndex = 1;
            this.LblNombreUsuario.Text = "Apellidos y Nombres";
            // 
            // LblCargoUsuario
            // 
            this.LblCargoUsuario.AutoSize = true;
            this.LblCargoUsuario.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.LblCargoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.LblCargoUsuario.Location = new System.Drawing.Point(82, 12);
            this.LblCargoUsuario.Name = "LblCargoUsuario";
            this.LblCargoUsuario.Size = new System.Drawing.Size(100, 19);
            this.LblCargoUsuario.TabIndex = 0;
            this.LblCargoUsuario.Text = "Administrador";
            // 
            // PtbFoto
            // 
            this.PtbFoto.Image = ((System.Drawing.Image)(resources.GetObject("PtbFoto.Image")));
            this.PtbFoto.Location = new System.Drawing.Point(12, 12);
            this.PtbFoto.Name = "PtbFoto";
            this.PtbFoto.Size = new System.Drawing.Size(64, 64);
            this.PtbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbFoto.TabIndex = 0;
            this.PtbFoto.TabStop = false;
            // 
            // BtnCompra
            // 
            this.BtnCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnCompra.FlatAppearance.BorderSize = 0;
            this.BtnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompra.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompra.ForeColor = System.Drawing.Color.White;
            this.BtnCompra.Image = ((System.Drawing.Image)(resources.GetObject("BtnCompra.Image")));
            this.BtnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompra.Location = new System.Drawing.Point(0, 224);
            this.BtnCompra.Name = "BtnCompra";
            this.BtnCompra.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCompra.Size = new System.Drawing.Size(200, 43);
            this.BtnCompra.TabIndex = 5;
            this.BtnCompra.Text = "Compras";
            this.BtnCompra.UseVisualStyleBackColor = false;
            this.BtnCompra.Click += new System.EventHandler(this.BtnCompra_Click);
            // 
            // BtnPedidoDelivery
            // 
            this.BtnPedidoDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnPedidoDelivery.FlatAppearance.BorderSize = 0;
            this.BtnPedidoDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPedidoDelivery.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedidoDelivery.ForeColor = System.Drawing.Color.White;
            this.BtnPedidoDelivery.Image = ((System.Drawing.Image)(resources.GetObject("BtnPedidoDelivery.Image")));
            this.BtnPedidoDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPedidoDelivery.Location = new System.Drawing.Point(0, 126);
            this.BtnPedidoDelivery.Name = "BtnPedidoDelivery";
            this.BtnPedidoDelivery.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnPedidoDelivery.Size = new System.Drawing.Size(200, 43);
            this.BtnPedidoDelivery.TabIndex = 4;
            this.BtnPedidoDelivery.Text = "Pedido Delivery";
            this.BtnPedidoDelivery.UseVisualStyleBackColor = false;
            this.BtnPedidoDelivery.Click += new System.EventHandler(this.BtnPedidoDelivery_Click);
            // 
            // BtnSalirSistema
            // 
            this.BtnSalirSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnSalirSistema.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalirSistema.FlatAppearance.BorderSize = 0;
            this.BtnSalirSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirSistema.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSalirSistema.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalirSistema.Image")));
            this.BtnSalirSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalirSistema.Location = new System.Drawing.Point(0, 652);
            this.BtnSalirSistema.Name = "BtnSalirSistema";
            this.BtnSalirSistema.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.BtnSalirSistema.Size = new System.Drawing.Size(200, 48);
            this.BtnSalirSistema.TabIndex = 0;
            this.BtnSalirSistema.Text = "Salir";
            this.BtnSalirSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalirSistema.UseVisualStyleBackColor = false;
            this.BtnSalirSistema.Click += new System.EventHandler(this.BtnSalirSistema_Click);
            // 
            // BtnProducto
            // 
            this.BtnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnProducto.FlatAppearance.BorderSize = 0;
            this.BtnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducto.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducto.ForeColor = System.Drawing.Color.White;
            this.BtnProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnProducto.Image")));
            this.BtnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducto.Location = new System.Drawing.Point(0, 322);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnProducto.Size = new System.Drawing.Size(200, 43);
            this.BtnProducto.TabIndex = 3;
            this.BtnProducto.Text = "Producto";
            this.BtnProducto.UseVisualStyleBackColor = false;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // BtnKardex
            // 
            this.BtnKardex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnKardex.FlatAppearance.BorderSize = 0;
            this.BtnKardex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKardex.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKardex.ForeColor = System.Drawing.Color.White;
            this.BtnKardex.Image = ((System.Drawing.Image)(resources.GetObject("BtnKardex.Image")));
            this.BtnKardex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKardex.Location = new System.Drawing.Point(0, 273);
            this.BtnKardex.Name = "BtnKardex";
            this.BtnKardex.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnKardex.Size = new System.Drawing.Size(200, 43);
            this.BtnKardex.TabIndex = 2;
            this.BtnKardex.Text = "Kardex";
            this.BtnKardex.UseVisualStyleBackColor = false;
            this.BtnKardex.Click += new System.EventHandler(this.BtnKardex_Click);
            // 
            // BtnInsumo
            // 
            this.BtnInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnInsumo.FlatAppearance.BorderSize = 0;
            this.BtnInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsumo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsumo.ForeColor = System.Drawing.Color.White;
            this.BtnInsumo.Image = ((System.Drawing.Image)(resources.GetObject("BtnInsumo.Image")));
            this.BtnInsumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInsumo.Location = new System.Drawing.Point(0, 175);
            this.BtnInsumo.Name = "BtnInsumo";
            this.BtnInsumo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnInsumo.Size = new System.Drawing.Size(200, 43);
            this.BtnInsumo.TabIndex = 1;
            this.BtnInsumo.Text = "Insumo";
            this.BtnInsumo.UseVisualStyleBackColor = false;
            this.BtnInsumo.Click += new System.EventHandler(this.BtnInsumo_Click);
            // 
            // PanelPadre
            // 
            this.PanelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPadre.Location = new System.Drawing.Point(200, 0);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.Size = new System.Drawing.Size(735, 700);
            this.PanelPadre.TabIndex = 5;
            // 
            // BtnPlanilla
            // 
            this.BtnPlanilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnPlanilla.FlatAppearance.BorderSize = 0;
            this.BtnPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlanilla.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlanilla.ForeColor = System.Drawing.Color.White;
            this.BtnPlanilla.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlanilla.Image")));
            this.BtnPlanilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPlanilla.Location = new System.Drawing.Point(0, 420);
            this.BtnPlanilla.Name = "BtnPlanilla";
            this.BtnPlanilla.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnPlanilla.Size = new System.Drawing.Size(200, 43);
            this.BtnPlanilla.TabIndex = 10;
            this.BtnPlanilla.Text = "Planilla";
            this.BtnPlanilla.UseVisualStyleBackColor = false;
            this.BtnPlanilla.Click += new System.EventHandler(this.BtnPlanilla_Click);
            // 
            // BtnAsistencia
            // 
            this.BtnAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnAsistencia.FlatAppearance.BorderSize = 0;
            this.BtnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsistencia.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsistencia.ForeColor = System.Drawing.Color.White;
            this.BtnAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("BtnAsistencia.Image")));
            this.BtnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAsistencia.Location = new System.Drawing.Point(-3, 469);
            this.BtnAsistencia.Name = "BtnAsistencia";
            this.BtnAsistencia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAsistencia.Size = new System.Drawing.Size(200, 43);
            this.BtnAsistencia.TabIndex = 11;
            this.BtnAsistencia.Text = "Asistencia";
            this.BtnAsistencia.UseVisualStyleBackColor = false;
            this.BtnAsistencia.Click += new System.EventHandler(this.BtnAsistencia_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.Color.White;
            this.BtnInventario.Image = ((System.Drawing.Image)(resources.GetObject("BtnInventario.Image")));
            this.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.Location = new System.Drawing.Point(0, 518);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnInventario.Size = new System.Drawing.Size(200, 43);
            this.BtnInventario.TabIndex = 12;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = false;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // FrmPrincipalAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 700);
            this.Controls.Add(this.PanelPadre);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipalAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipalAdministrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipalAdministrador_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.Label LblCargoUsuario;
        private System.Windows.Forms.PictureBox PtbFoto;
        private System.Windows.Forms.Button BtnCompra;
        private System.Windows.Forms.Button BtnPedidoDelivery;
        private System.Windows.Forms.Button BtnSalirSistema;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnKardex;
        private System.Windows.Forms.Button BtnInsumo;
        private System.Windows.Forms.Panel PanelPadre;
        private System.Windows.Forms.Label LblApellidoUsuario;
        private System.Windows.Forms.Button BtnListaPedido;
        private System.Windows.Forms.Button BtnReporteKardexEntrada;
        private System.Windows.Forms.Button BtnKardexSalida;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnAsistencia;
        private System.Windows.Forms.Button BtnPlanilla;
    }
}
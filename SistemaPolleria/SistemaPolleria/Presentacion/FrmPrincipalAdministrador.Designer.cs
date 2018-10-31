﻿namespace SistemaPolleria.Presentacion
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNivelUsuario = new System.Windows.Forms.Label();
            this.PtbFoto = new System.Windows.Forms.PictureBox();
            this.BtnListaBoleta = new System.Windows.Forms.Button();
            this.BtnAlumno = new System.Windows.Forms.Button();
            this.BtnSalirSistema = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.BtnEmpleado = new System.Windows.Forms.Button();
            this.BtnInsumo = new System.Windows.Forms.Button();
            this.BtnPedidoMesa = new System.Windows.Forms.Button();
            this.PanelPadre = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.BtnListaBoleta);
            this.panel3.Controls.Add(this.BtnAlumno);
            this.panel3.Controls.Add(this.BtnSalirSistema);
            this.panel3.Controls.Add(this.BtnProducto);
            this.panel3.Controls.Add(this.BtnEmpleado);
            this.panel3.Controls.Add(this.BtnInsumo);
            this.panel3.Controls.Add(this.BtnPedidoMesa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 700);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LblNivelUsuario);
            this.panel2.Controls.Add(this.PtbFoto);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 120);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellidos y Nombres";
            // 
            // LblNivelUsuario
            // 
            this.LblNivelUsuario.AutoSize = true;
            this.LblNivelUsuario.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.LblNivelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.LblNivelUsuario.Location = new System.Drawing.Point(82, 12);
            this.LblNivelUsuario.Name = "LblNivelUsuario";
            this.LblNivelUsuario.Size = new System.Drawing.Size(100, 19);
            this.LblNivelUsuario.TabIndex = 0;
            this.LblNivelUsuario.Text = "Administrador";
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
            // BtnListaBoleta
            // 
            this.BtnListaBoleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnListaBoleta.FlatAppearance.BorderSize = 0;
            this.BtnListaBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListaBoleta.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListaBoleta.ForeColor = System.Drawing.Color.White;
            this.BtnListaBoleta.Image = ((System.Drawing.Image)(resources.GetObject("BtnListaBoleta.Image")));
            this.BtnListaBoleta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListaBoleta.Location = new System.Drawing.Point(0, 224);
            this.BtnListaBoleta.Name = "BtnListaBoleta";
            this.BtnListaBoleta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnListaBoleta.Size = new System.Drawing.Size(200, 43);
            this.BtnListaBoleta.TabIndex = 5;
            this.BtnListaBoleta.Text = "Lista de Boletas";
            this.BtnListaBoleta.UseVisualStyleBackColor = false;
            // 
            // BtnAlumno
            // 
            this.BtnAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnAlumno.FlatAppearance.BorderSize = 0;
            this.BtnAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlumno.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlumno.ForeColor = System.Drawing.Color.White;
            this.BtnAlumno.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlumno.Image")));
            this.BtnAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlumno.Location = new System.Drawing.Point(0, 371);
            this.BtnAlumno.Name = "BtnAlumno";
            this.BtnAlumno.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAlumno.Size = new System.Drawing.Size(200, 43);
            this.BtnAlumno.TabIndex = 4;
            this.BtnAlumno.Text = "Alumno";
            this.BtnAlumno.UseVisualStyleBackColor = false;
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
            // BtnEmpleado
            // 
            this.BtnEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleado.ForeColor = System.Drawing.Color.White;
            this.BtnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmpleado.Image")));
            this.BtnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleado.Location = new System.Drawing.Point(0, 273);
            this.BtnEmpleado.Name = "BtnEmpleado";
            this.BtnEmpleado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEmpleado.Size = new System.Drawing.Size(200, 43);
            this.BtnEmpleado.TabIndex = 2;
            this.BtnEmpleado.Text = "Empleado";
            this.BtnEmpleado.UseVisualStyleBackColor = false;
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
            // BtnPedidoMesa
            // 
            this.BtnPedidoMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtnPedidoMesa.FlatAppearance.BorderSize = 0;
            this.BtnPedidoMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPedidoMesa.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedidoMesa.ForeColor = System.Drawing.Color.White;
            this.BtnPedidoMesa.Image = ((System.Drawing.Image)(resources.GetObject("BtnPedidoMesa.Image")));
            this.BtnPedidoMesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPedidoMesa.Location = new System.Drawing.Point(0, 126);
            this.BtnPedidoMesa.Name = "BtnPedidoMesa";
            this.BtnPedidoMesa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnPedidoMesa.Size = new System.Drawing.Size(200, 43);
            this.BtnPedidoMesa.TabIndex = 0;
            this.BtnPedidoMesa.Text = "Pedido a la Mesa";
            this.BtnPedidoMesa.UseVisualStyleBackColor = false;
            this.BtnPedidoMesa.Click += new System.EventHandler(this.BtnPedidoMesa_Click);
            // 
            // PanelPadre
            // 
            this.PanelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPadre.Location = new System.Drawing.Point(200, 0);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.Size = new System.Drawing.Size(735, 700);
            this.PanelPadre.TabIndex = 5;
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
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNivelUsuario;
        private System.Windows.Forms.PictureBox PtbFoto;
        private System.Windows.Forms.Button BtnListaBoleta;
        private System.Windows.Forms.Button BtnAlumno;
        private System.Windows.Forms.Button BtnSalirSistema;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnEmpleado;
        private System.Windows.Forms.Button BtnInsumo;
        private System.Windows.Forms.Button BtnPedidoMesa;
        private System.Windows.Forms.Panel PanelPadre;
    }
}
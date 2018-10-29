namespace SistemaPolleria
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PtbLogo = new System.Windows.Forms.PictureBox();
            this.PtbCerrarVentana = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnIniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(14, 347);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.BtnIniciarSesion.Size = new System.Drawing.Size(196, 48);
            this.BtnIniciarSesion.TabIndex = 1;
            this.BtnIniciarSesion.Text = "INICIAR SESION";
            this.BtnIniciarSesion.UseVisualStyleBackColor = false;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TxtClave);
            this.panel1.Controls.Add(this.TxtCodigoEmpleado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PtbLogo);
            this.panel1.Controls.Add(this.BtnIniciarSesion);
            this.panel1.Location = new System.Drawing.Point(150, 47);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(222, 418);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 208;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.TabIndex = 207;
            this.pictureBox1.TabStop = false;
            // 
            // TxtClave
            // 
            this.TxtClave.BackColor = System.Drawing.Color.White;
            this.TxtClave.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtClave.ForeColor = System.Drawing.Color.Black;
            this.TxtClave.Location = new System.Drawing.Point(44, 298);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '•';
            this.TxtClave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtClave.Size = new System.Drawing.Size(162, 26);
            this.TxtClave.TabIndex = 206;
            // 
            // TxtCodigoEmpleado
            // 
            this.TxtCodigoEmpleado.BackColor = System.Drawing.Color.White;
            this.TxtCodigoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoEmpleado.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtCodigoEmpleado.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigoEmpleado.Location = new System.Drawing.Point(42, 226);
            this.TxtCodigoEmpleado.Name = "TxtCodigoEmpleado";
            this.TxtCodigoEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCodigoEmpleado.Size = new System.Drawing.Size(162, 26);
            this.TxtCodigoEmpleado.TabIndex = 205;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 24.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(34, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 44);
            this.label2.TabIndex = 204;
            this.label2.Text = "SISTEMA";
            // 
            // PtbLogo
            // 
            this.PtbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PtbLogo.Image")));
            this.PtbLogo.Location = new System.Drawing.Point(85, 124);
            this.PtbLogo.Name = "PtbLogo";
            this.PtbLogo.Size = new System.Drawing.Size(64, 64);
            this.PtbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PtbLogo.TabIndex = 202;
            this.PtbLogo.TabStop = false;
            // 
            // PtbCerrarVentana
            // 
            this.PtbCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("PtbCerrarVentana.Image")));
            this.PtbCerrarVentana.Location = new System.Drawing.Point(521, 12);
            this.PtbCerrarVentana.Name = "PtbCerrarVentana";
            this.PtbCerrarVentana.Size = new System.Drawing.Size(24, 24);
            this.PtbCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PtbCerrarVentana.TabIndex = 201;
            this.PtbCerrarVentana.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(557, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PtbCerrarVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarVentana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtCodigoEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PtbLogo;
        private System.Windows.Forms.PictureBox PtbCerrarVentana;
    }
}


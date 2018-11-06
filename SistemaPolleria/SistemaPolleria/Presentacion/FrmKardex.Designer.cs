namespace SistemaPolleria.Presentacion
{
    partial class FrmKardex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKardex));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtIdInsumo = new System.Windows.Forms.TextBox();
            this.BtnListaInsumo = new System.Windows.Forms.Button();
            this.TxtNombreInsumo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbEstablecimiento = new System.Windows.Forms.ComboBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdKardex = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.CmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvKardex = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKardex)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtIdInsumo);
            this.groupBox1.Controls.Add(this.BtnListaInsumo);
            this.groupBox1.Controls.Add(this.TxtNombreInsumo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CmbEstablecimiento);
            this.groupBox1.Controls.Add(this.TxtRazonSocial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtRuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtIdKardex);
            this.groupBox1.Controls.Add(this.Codigo);
            this.groupBox1.Controls.Add(this.CmbPeriodo);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(17, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 145);
            this.groupBox1.TabIndex = 272;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Kardex";
            // 
            // TxtIdInsumo
            // 
            this.TxtIdInsumo.BackColor = System.Drawing.Color.White;
            this.TxtIdInsumo.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtIdInsumo.ForeColor = System.Drawing.Color.Black;
            this.TxtIdInsumo.Location = new System.Drawing.Point(293, 108);
            this.TxtIdInsumo.Name = "TxtIdInsumo";
            this.TxtIdInsumo.Size = new System.Drawing.Size(132, 26);
            this.TxtIdInsumo.TabIndex = 272;
            this.TxtIdInsumo.Text = "I00";
            this.TxtIdInsumo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIdInsumo_KeyDown);
            // 
            // BtnListaInsumo
            // 
            this.BtnListaInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnListaInsumo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnListaInsumo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.BtnListaInsumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnListaInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListaInsumo.ForeColor = System.Drawing.Color.Black;
            this.BtnListaInsumo.Image = ((System.Drawing.Image)(resources.GetObject("BtnListaInsumo.Image")));
            this.BtnListaInsumo.Location = new System.Drawing.Point(424, 108);
            this.BtnListaInsumo.Name = "BtnListaInsumo";
            this.BtnListaInsumo.Size = new System.Drawing.Size(39, 26);
            this.BtnListaInsumo.TabIndex = 273;
            this.BtnListaInsumo.UseVisualStyleBackColor = false;
            // 
            // TxtNombreInsumo
            // 
            this.TxtNombreInsumo.BackColor = System.Drawing.Color.White;
            this.TxtNombreInsumo.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtNombreInsumo.ForeColor = System.Drawing.Color.Black;
            this.TxtNombreInsumo.Location = new System.Drawing.Point(490, 108);
            this.TxtNombreInsumo.Name = "TxtNombreInsumo";
            this.TxtNombreInsumo.Size = new System.Drawing.Size(233, 26);
            this.TxtNombreInsumo.TabIndex = 279;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(487, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 280;
            this.label7.Text = "Nombre de Insumo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(288, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 277;
            this.label5.Text = "Codigo Insumo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(160, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 275;
            this.label4.Text = "Establecimiento";
            // 
            // CmbEstablecimiento
            // 
            this.CmbEstablecimiento.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.CmbEstablecimiento.ForeColor = System.Drawing.Color.Gray;
            this.CmbEstablecimiento.FormattingEnabled = true;
            this.CmbEstablecimiento.Location = new System.Drawing.Point(163, 107);
            this.CmbEstablecimiento.Name = "CmbEstablecimiento";
            this.CmbEstablecimiento.Size = new System.Drawing.Size(109, 27);
            this.CmbEstablecimiento.TabIndex = 276;
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.BackColor = System.Drawing.Color.White;
            this.TxtRazonSocial.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.TxtRazonSocial.Location = new System.Drawing.Point(291, 44);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(362, 26);
            this.TxtRazonSocial.TabIndex = 273;
            this.TxtRazonSocial.Text = "POLLERIA MACHU PICCHU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(288, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 274;
            this.label3.Text = "Razon Social";
            // 
            // TxtRuc
            // 
            this.TxtRuc.BackColor = System.Drawing.Color.White;
            this.TxtRuc.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtRuc.ForeColor = System.Drawing.Color.Black;
            this.TxtRuc.Location = new System.Drawing.Point(21, 108);
            this.TxtRuc.Name = "TxtRuc";
            this.TxtRuc.Size = new System.Drawing.Size(117, 26);
            this.TxtRuc.TabIndex = 256;
            this.TxtRuc.Text = "10746488397";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 257;
            this.label1.Text = "Ruc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(159, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 254;
            this.label2.Text = "Periodo";
            // 
            // TxtIdKardex
            // 
            this.TxtIdKardex.BackColor = System.Drawing.Color.White;
            this.TxtIdKardex.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.TxtIdKardex.ForeColor = System.Drawing.Color.Black;
            this.TxtIdKardex.Location = new System.Drawing.Point(21, 44);
            this.TxtIdKardex.Name = "TxtIdKardex";
            this.TxtIdKardex.Size = new System.Drawing.Size(117, 26);
            this.TxtIdKardex.TabIndex = 248;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Codigo.ForeColor = System.Drawing.Color.Gray;
            this.Codigo.Location = new System.Drawing.Point(18, 24);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(56, 17);
            this.Codigo.TabIndex = 249;
            this.Codigo.Text = "Codigo ";
            // 
            // CmbPeriodo
            // 
            this.CmbPeriodo.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.CmbPeriodo.ForeColor = System.Drawing.Color.Gray;
            this.CmbPeriodo.FormattingEnabled = true;
            this.CmbPeriodo.Location = new System.Drawing.Point(162, 43);
            this.CmbPeriodo.Name = "CmbPeriodo";
            this.CmbPeriodo.Size = new System.Drawing.Size(109, 27);
            this.CmbPeriodo.TabIndex = 255;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 28);
            this.label6.TabIndex = 271;
            this.label6.Text = "Formulario Kardex";
            // 
            // DgvKardex
            // 
            this.DgvKardex.AllowUserToAddRows = false;
            this.DgvKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKardex.Location = new System.Drawing.Point(17, 239);
            this.DgvKardex.Name = "DgvKardex";
            this.DgvKardex.ReadOnly = true;
            this.DgvKardex.Size = new System.Drawing.Size(781, 261);
            this.DgvKardex.TabIndex = 273;
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
            this.BtnNuevo.Location = new System.Drawing.Point(671, 201);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(127, 32);
            this.BtnNuevo.TabIndex = 274;
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
            this.BtnModificar.Location = new System.Drawing.Point(538, 201);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(127, 32);
            this.BtnModificar.TabIndex = 273;
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
            this.BtnGuardar.Location = new System.Drawing.Point(405, 201);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(127, 32);
            this.BtnGuardar.TabIndex = 272;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 527);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.DgvKardex);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKardex";
            this.Text = "FrmKardex";
            this.Load += new System.EventHandler(this.FrmKardex_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKardex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNombreInsumo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbEstablecimiento;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdKardex;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.ComboBox CmbPeriodo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvKardex;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtIdInsumo;
        private System.Windows.Forms.Button BtnListaInsumo;
    }
}
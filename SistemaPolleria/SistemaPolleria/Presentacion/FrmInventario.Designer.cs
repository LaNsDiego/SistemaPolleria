namespace SistemaPolleria.Presentacion
{
    partial class FrmInventario
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
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_IdDelInventario = new System.Windows.Forms.TextBox();
            this.Cmb_IdProducto = new System.Windows.Forms.ComboBox();
            this.TxtObservacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Grb_Estado = new System.Windows.Forms.GroupBox();
            this.Rdb_Bueno = new System.Windows.Forms.RadioButton();
            this.rdb_malo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Grb_Estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnNuevo.Location = new System.Drawing.Point(441, 339);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(127, 32);
            this.BtnNuevo.TabIndex = 249;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_IdDelInventario);
            this.groupBox1.Controls.Add(this.Cmb_IdProducto);
            this.groupBox1.Controls.Add(this.TxtObservacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Grb_Estado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(99, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 198);
            this.groupBox1.TabIndex = 246;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro Inventario";
            // 
            // Txt_IdDelInventario
            // 
            this.Txt_IdDelInventario.Location = new System.Drawing.Point(104, 54);
            this.Txt_IdDelInventario.Name = "Txt_IdDelInventario";
            this.Txt_IdDelInventario.Size = new System.Drawing.Size(100, 20);
            this.Txt_IdDelInventario.TabIndex = 243;
            // 
            // Cmb_IdProducto
            // 
            this.Cmb_IdProducto.FormattingEnabled = true;
            this.Cmb_IdProducto.Location = new System.Drawing.Point(385, 54);
            this.Cmb_IdProducto.Name = "Cmb_IdProducto";
            this.Cmb_IdProducto.Size = new System.Drawing.Size(121, 21);
            this.Cmb_IdProducto.TabIndex = 242;
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.Location = new System.Drawing.Point(276, 103);
            this.TxtObservacion.Multiline = true;
            this.TxtObservacion.Name = "TxtObservacion";
            this.TxtObservacion.Size = new System.Drawing.Size(233, 84);
            this.TxtObservacion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 229;
            this.label3.Text = "Observacion (es) :";
            // 
            // Grb_Estado
            // 
            this.Grb_Estado.Controls.Add(this.Rdb_Bueno);
            this.Grb_Estado.Controls.Add(this.rdb_malo);
            this.Grb_Estado.Location = new System.Drawing.Point(18, 110);
            this.Grb_Estado.Name = "Grb_Estado";
            this.Grb_Estado.Size = new System.Drawing.Size(164, 77);
            this.Grb_Estado.TabIndex = 227;
            this.Grb_Estado.TabStop = false;
            this.Grb_Estado.Text = "Estado";
            // 
            // Rdb_Bueno
            // 
            this.Rdb_Bueno.AutoSize = true;
            this.Rdb_Bueno.Location = new System.Drawing.Point(6, 17);
            this.Rdb_Bueno.Name = "Rdb_Bueno";
            this.Rdb_Bueno.Size = new System.Drawing.Size(56, 17);
            this.Rdb_Bueno.TabIndex = 4;
            this.Rdb_Bueno.TabStop = true;
            this.Rdb_Bueno.Text = "Bueno";
            this.Rdb_Bueno.UseVisualStyleBackColor = true;
            // 
            // rdb_malo
            // 
            this.rdb_malo.AutoSize = true;
            this.rdb_malo.Location = new System.Drawing.Point(8, 49);
            this.rdb_malo.Name = "rdb_malo";
            this.rdb_malo.Size = new System.Drawing.Size(48, 17);
            this.rdb_malo.TabIndex = 5;
            this.rdb_malo.TabStop = true;
            this.rdb_malo.Text = "Malo";
            this.rdb_malo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id del Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id del Inventario";
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnModificar.Location = new System.Drawing.Point(308, 339);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(127, 32);
            this.BtnModificar.TabIndex = 248;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGuardar.Location = new System.Drawing.Point(175, 339);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(127, 32);
            this.BtnGuardar.TabIndex = 247;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 548);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Grb_Estado.ResumeLayout(false);
            this.Grb_Estado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_IdDelInventario;
        private System.Windows.Forms.ComboBox Cmb_IdProducto;
        private System.Windows.Forms.TextBox TxtObservacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Grb_Estado;
        private System.Windows.Forms.RadioButton Rdb_Bueno;
        private System.Windows.Forms.RadioButton rdb_malo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}
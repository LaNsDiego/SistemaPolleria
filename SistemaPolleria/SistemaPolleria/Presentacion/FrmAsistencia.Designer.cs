namespace SistemaPolleria.Presentacion
{
    partial class FrmAsistencia
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
            this.label3 = new System.Windows.Forms.Label();
            this.Grb_Estado = new System.Windows.Forms.GroupBox();
            this.Rdb_Falta = new System.Windows.Forms.RadioButton();
            this.Rdb_Asiste = new System.Windows.Forms.RadioButton();
            this.rdb_Tarde = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.Cmb_IdCargo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Grb_Estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 237;
            this.label3.Text = "Fecha / Hora";
            // 
            // Grb_Estado
            // 
            this.Grb_Estado.Controls.Add(this.Rdb_Falta);
            this.Grb_Estado.Controls.Add(this.Rdb_Asiste);
            this.Grb_Estado.Controls.Add(this.rdb_Tarde);
            this.Grb_Estado.Location = new System.Drawing.Point(140, 418);
            this.Grb_Estado.Name = "Grb_Estado";
            this.Grb_Estado.Size = new System.Drawing.Size(164, 100);
            this.Grb_Estado.TabIndex = 236;
            this.Grb_Estado.TabStop = false;
            this.Grb_Estado.Text = "Estado";
            // 
            // Rdb_Falta
            // 
            this.Rdb_Falta.AutoSize = true;
            this.Rdb_Falta.Location = new System.Drawing.Point(102, 63);
            this.Rdb_Falta.Name = "Rdb_Falta";
            this.Rdb_Falta.Size = new System.Drawing.Size(48, 17);
            this.Rdb_Falta.TabIndex = 6;
            this.Rdb_Falta.TabStop = true;
            this.Rdb_Falta.Text = "Falta";
            this.Rdb_Falta.UseVisualStyleBackColor = true;
            // 
            // Rdb_Asiste
            // 
            this.Rdb_Asiste.AutoSize = true;
            this.Rdb_Asiste.Location = new System.Drawing.Point(6, 17);
            this.Rdb_Asiste.Name = "Rdb_Asiste";
            this.Rdb_Asiste.Size = new System.Drawing.Size(55, 17);
            this.Rdb_Asiste.TabIndex = 4;
            this.Rdb_Asiste.TabStop = true;
            this.Rdb_Asiste.Text = "Asistio";
            this.Rdb_Asiste.UseVisualStyleBackColor = true;
            // 
            // rdb_Tarde
            // 
            this.rdb_Tarde.AutoSize = true;
            this.rdb_Tarde.Location = new System.Drawing.Point(56, 40);
            this.rdb_Tarde.Name = "rdb_Tarde";
            this.rdb_Tarde.Size = new System.Drawing.Size(53, 17);
            this.rdb_Tarde.TabIndex = 5;
            this.rdb_Tarde.TabStop = true;
            this.rdb_Tarde.Text = "Tarde";
            this.rdb_Tarde.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(98, 234);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 235;
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
            this.BtnNuevo.Location = new System.Drawing.Point(291, 524);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(127, 32);
            this.BtnNuevo.TabIndex = 234;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
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
            this.BtnModificar.Location = new System.Drawing.Point(158, 524);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(127, 32);
            this.BtnModificar.TabIndex = 233;
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
            this.BtnGuardar.Location = new System.Drawing.Point(25, 524);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(127, 32);
            this.BtnGuardar.TabIndex = 232;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // Cmb_IdCargo
            // 
            this.Cmb_IdCargo.FormattingEnabled = true;
            this.Cmb_IdCargo.Location = new System.Drawing.Point(169, 154);
            this.Cmb_IdCargo.Name = "Cmb_IdCargo";
            this.Cmb_IdCargo.Size = new System.Drawing.Size(121, 21);
            this.Cmb_IdCargo.TabIndex = 231;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 230;
            this.label2.Text = "Id Cargo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 229;
            this.label1.Text = "Id Empleado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 228;
            // 
            // FrmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 579);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Grb_Estado);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.Cmb_IdCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmAsistencia";
            this.Text = "FrmAsistencia";
            this.Grb_Estado.ResumeLayout(false);
            this.Grb_Estado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Grb_Estado;
        private System.Windows.Forms.RadioButton Rdb_Falta;
        private System.Windows.Forms.RadioButton Rdb_Asiste;
        private System.Windows.Forms.RadioButton rdb_Tarde;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox Cmb_IdCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
namespace SistemaPolleria.Presentacion
{
    partial class FrmReporteKardexSalida
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TotalSalidasAgrupadoPorInsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOLLERIADataSet = new SistemaPolleria.POLLERIADataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pOLLERIADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnBuscarPorFechas = new System.Windows.Forms.Button();
            this.DtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TotalSalidasAgrupadoPorInsumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLLERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLLERIADataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalSalidasAgrupadoPorInsumoBindingSource
            // 
            this.TotalSalidasAgrupadoPorInsumoBindingSource.DataMember = "TotalSalidasAgrupadoPorInsumo";
            this.TotalSalidasAgrupadoPorInsumoBindingSource.DataSource = this.pOLLERIADataSet;
            // 
            // pOLLERIADataSet
            // 
            this.pOLLERIADataSet.DataSetName = "POLLERIADataSet";
            this.pOLLERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetSalidasPorInsumo";
            reportDataSource1.Value = this.TotalSalidasAgrupadoPorInsumoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaPolleria.Reportes.ReporteSalidas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(48, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(643, 406);
            this.reportViewer1.TabIndex = 0;
            // 
            // pOLLERIADataSetBindingSource
            // 
            this.pOLLERIADataSetBindingSource.DataSource = this.pOLLERIADataSet;
            this.pOLLERIADataSetBindingSource.Position = 0;
            // 
            // BtnBuscarPorFechas
            // 
            this.BtnBuscarPorFechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnBuscarPorFechas.FlatAppearance.BorderSize = 0;
            this.BtnBuscarPorFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarPorFechas.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.BtnBuscarPorFechas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnBuscarPorFechas.Location = new System.Drawing.Point(509, 33);
            this.BtnBuscarPorFechas.Name = "BtnBuscarPorFechas";
            this.BtnBuscarPorFechas.Size = new System.Drawing.Size(182, 44);
            this.BtnBuscarPorFechas.TabIndex = 5;
            this.BtnBuscarPorFechas.Text = "BUSCAR";
            this.BtnBuscarPorFechas.UseVisualStyleBackColor = false;
            this.BtnBuscarPorFechas.Click += new System.EventHandler(this.BtnBuscarPorFechas_Click);
            // 
            // DtpFechaFinal
            // 
            this.DtpFechaFinal.Location = new System.Drawing.Point(264, 44);
            this.DtpFechaFinal.Name = "DtpFechaFinal";
            this.DtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaFinal.TabIndex = 4;
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Location = new System.Drawing.Point(48, 44);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaInicio.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(44, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 252;
            this.label6.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(260, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 253;
            this.label1.Text = "Hasta";
            // 
            // FrmReporteKardexSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnBuscarPorFechas);
            this.Controls.Add(this.DtpFechaFinal);
            this.Controls.Add(this.DtpFechaInicio);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteKardexSalida";
            this.Text = "FrmReporteKardexSalida";
            this.Load += new System.EventHandler(this.FrmReporteKardexSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalSalidasAgrupadoPorInsumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLLERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLLERIADataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TotalSalidasAgrupadoPorInsumoBindingSource;
        private POLLERIADataSet pOLLERIADataSet;
        private System.Windows.Forms.BindingSource pOLLERIADataSetBindingSource;
        private System.Windows.Forms.Button BtnBuscarPorFechas;
        private System.Windows.Forms.DateTimePicker DtpFechaFinal;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}
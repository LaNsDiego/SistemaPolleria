namespace SistemaPolleria.Presentacion
{
    partial class FrmReportVenta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporteVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOLLERIADataSet = new SistemaPolleria.POLLERIADataSet();
            this.totalVentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBuscarPorFechas = new System.Windows.Forms.Button();
            this.DtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.pOLLERIADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteVentasTableAdapter = new SistemaPolleria.POLLERIADataSetTableAdapters.ReporteVentasTableAdapter();
            this.TotalSalidasAgrupadoPorInsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TotalVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalVentaTableAdapter = new SistemaPolleria.POLLERIADataSetTableAdapters.TotalVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLLERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalVentaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLLERIADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalSalidasAgrupadoPorInsumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteVentasBindingSource
            // 
            this.reporteVentasBindingSource.DataMember = "ReporteVentas";
            this.reporteVentasBindingSource.DataSource = this.pOLLERIADataSet;
            // 
            // pOLLERIADataSet
            // 
            this.pOLLERIADataSet.DataSetName = "POLLERIADataSet";
            this.pOLLERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalVentaBindingSource1
            // 
            this.totalVentaBindingSource1.DataMember = "TotalVenta";
            this.totalVentaBindingSource1.DataSource = this.pOLLERIADataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetVentas";
            reportDataSource1.Value = this.reporteVentasBindingSource;
            reportDataSource2.Name = "DataSetVentaGrafico";
            reportDataSource2.Value = this.totalVentaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaPolleria.Reportes.ReporteVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 79);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 466);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(238, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 258;
            this.label1.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(22, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 257;
            this.label6.Text = "Desde";
            // 
            // BtnBuscarPorFechas
            // 
            this.BtnBuscarPorFechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnBuscarPorFechas.FlatAppearance.BorderSize = 0;
            this.BtnBuscarPorFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarPorFechas.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.BtnBuscarPorFechas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnBuscarPorFechas.Location = new System.Drawing.Point(487, 29);
            this.BtnBuscarPorFechas.Name = "BtnBuscarPorFechas";
            this.BtnBuscarPorFechas.Size = new System.Drawing.Size(182, 44);
            this.BtnBuscarPorFechas.TabIndex = 256;
            this.BtnBuscarPorFechas.Text = "BUSCAR";
            this.BtnBuscarPorFechas.UseVisualStyleBackColor = false;
            this.BtnBuscarPorFechas.Click += new System.EventHandler(this.BtnBuscarPorFechas_Click);
            // 
            // DtpFechaFinal
            // 
            this.DtpFechaFinal.Location = new System.Drawing.Point(242, 40);
            this.DtpFechaFinal.Name = "DtpFechaFinal";
            this.DtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaFinal.TabIndex = 255;
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Location = new System.Drawing.Point(26, 40);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaInicio.TabIndex = 254;
            // 
            // pOLLERIADataSetBindingSource
            // 
            this.pOLLERIADataSetBindingSource.DataSource = this.pOLLERIADataSet;
            this.pOLLERIADataSetBindingSource.Position = 0;
            // 
            // reporteVentasTableAdapter
            // 
            this.reporteVentasTableAdapter.ClearBeforeFill = true;
            // 
            // TotalSalidasAgrupadoPorInsumoBindingSource
            // 
            this.TotalSalidasAgrupadoPorInsumoBindingSource.DataMember = "TotalSalidasAgrupadoPorInsumo";
            this.TotalSalidasAgrupadoPorInsumoBindingSource.DataSource = this.pOLLERIADataSet;
            // 
            // TotalVentaBindingSource
            // 
            this.TotalVentaBindingSource.DataMember = "TotalVenta";
            this.TotalVentaBindingSource.DataSource = this.pOLLERIADataSet;
            // 
            // totalVentaTableAdapter
            // 
            this.totalVentaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnBuscarPorFechas);
            this.Controls.Add(this.DtpFechaFinal);
            this.Controls.Add(this.DtpFechaInicio);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportVenta";
            this.Text = "FrmReportVenta";
            this.Load += new System.EventHandler(this.FrmReportVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLLERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalVentaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLLERIADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalSalidasAgrupadoPorInsumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalVentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteVentasBindingSource;
        private POLLERIADataSet pOLLERIADataSet;
        private System.Windows.Forms.BindingSource pOLLERIADataSetBindingSource;
        private POLLERIADataSetTableAdapters.ReporteVentasTableAdapter reporteVentasTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnBuscarPorFechas;
        private System.Windows.Forms.DateTimePicker DtpFechaFinal;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.BindingSource TotalSalidasAgrupadoPorInsumoBindingSource;
        private System.Windows.Forms.BindingSource TotalVentaBindingSource;
        private System.Windows.Forms.BindingSource totalVentaBindingSource1;
        private POLLERIADataSetTableAdapters.TotalVentaTableAdapter totalVentaTableAdapter;
    }
}
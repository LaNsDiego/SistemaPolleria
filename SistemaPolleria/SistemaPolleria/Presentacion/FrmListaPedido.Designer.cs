namespace SistemaPolleria.Presentacion
{
    partial class FrmListaPedido
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
            this.DgvListaPedidos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaPedidos
            // 
            this.DgvListaPedidos.AllowUserToAddRows = false;
            this.DgvListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaPedidos.Location = new System.Drawing.Point(48, 68);
            this.DgvListaPedidos.Name = "DgvListaPedidos";
            this.DgvListaPedidos.ReadOnly = true;
            this.DgvListaPedidos.Size = new System.Drawing.Size(840, 391);
            this.DgvListaPedidos.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(43, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 28);
            this.label6.TabIndex = 272;
            this.label6.Text = "Formulario Lista Pedidos de HOY";
            // 
            // FrmListaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 533);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DgvListaPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaPedido";
            this.Text = "FrmListaVenta";
            this.Load += new System.EventHandler(this.FrmListaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaPedidos;
        private System.Windows.Forms.Label label6;
    }
}
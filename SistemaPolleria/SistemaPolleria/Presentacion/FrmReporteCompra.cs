using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.Presentacion
{
    public partial class FrmReporteCompra : Form
    {
        private POLLERIADataSet.ReporteComprasDataTable dtcompras = new POLLERIADataSet.ReporteComprasDataTable();
        public FrmReporteCompra()
        {
            InitializeComponent();
        }

        private void FrmReporteCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pOLLERIADataSet.ReporteCompras' Puede moverla o quitarla según sea necesario.
            

        }

        private void BtnBuscarPorFechas_Click(object sender, EventArgs e)
        {

            this.reporteComprasTableAdapter.Fill(this.pOLLERIADataSet.ReporteCompras,
                Convert.ToDateTime(DtpFechaInicio.Text),
                    Convert.ToDateTime(DtpFechaFinal.Text));

            //POLLERIADataSetTableAdapters.ReporteComprasTableAdapter AdaptadorCompras = new POLLERIADataSetTableAdapters.ReporteComprasTableAdapter();
            //AdaptadorCompras.Fill(
            //    pOLLERIADataSet.ReporteCompras,
            //    Convert.ToDateTime(DtpFechaInicio.Text),
            //        Convert.ToDateTime(DtpFechaFinal.Text)
            //        );

            this.reportViewer1.RefreshReport();
        }

    }
}

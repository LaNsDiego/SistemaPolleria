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
    public partial class FrmReportVenta : Form
    {
        public FrmReportVenta()
        {
            InitializeComponent();
        }

        private void FrmReportVenta_Load(object sender, EventArgs e)
        {

            
        }

        private void BtnBuscarPorFechas_Click(object sender, EventArgs e)
        {
            reporteVentasTableAdapter.Fill(
                pOLLERIADataSet.ReporteVentas,
                Convert.ToDateTime(DtpFechaInicio.Text),
                Convert.ToDateTime(DtpFechaFinal.Text)
                );


            totalVentaTableAdapter.Fill(
                pOLLERIADataSet.TotalVenta,
                Convert.ToDateTime(DtpFechaInicio.Text),
                Convert.ToDateTime(DtpFechaFinal.Text)
                );

            this.reportViewer1.RefreshReport();
        }
    }
}

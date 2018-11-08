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
    public partial class FrmReporteKardexSalida : Form
    {
        public FrmReporteKardexSalida()
        {
            InitializeComponent();
        }

        private void FrmReporteKardexSalida_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscarPorFechas_Click(object sender, EventArgs e)
        {
            DateTime FechaInicio = Convert.ToDateTime(DtpFechaInicio.Text.ToString());
            DateTime FechaFinal = Convert.ToDateTime(DtpFechaFinal.Text.ToString());
            POLLERIADataSetTableAdapters.TotalSalidasAgrupadoPorInsumoTableAdapter Adaptador = new POLLERIADataSetTableAdapters.TotalSalidasAgrupadoPorInsumoTableAdapter();
            Adaptador.Fill(pOLLERIADataSet.TotalSalidasAgrupadoPorInsumo, FechaInicio, FechaFinal);
            this.reportViewer1.RefreshReport();
        }
    }
}

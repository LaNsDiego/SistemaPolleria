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
    public partial class FrmReporteKardexEntrada : Form
    {
        public FrmReporteKardexEntrada()
        {
            InitializeComponent();
        }

        private void FrmReporteKardexEntrada_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pOLLERIADataSet.TotalEntradasAgrupadoPorInsumo' Puede moverla o quitarla según sea necesario.
            //this.totalEntradasAgrupadoPorInsumoTableAdapter.Fill(this.pOLLERIADataSet.TotalEntradasAgrupadoPorInsumo);

        }


        private void BtnBuscarPorFechas_Click_1(object sender, EventArgs e)
        {
            DateTime FechaInicio = Convert.ToDateTime(DtpFechaInicio.Text.ToString());
            DateTime FechaFinal = Convert.ToDateTime(DtpFechaFinal.Text.ToString());
            POLLERIADataSetTableAdapters.TotalEntradasAgrupadoPorInsumoTableAdapter Adaptador = new POLLERIADataSetTableAdapters.TotalEntradasAgrupadoPorInsumoTableAdapter();
            Adaptador.Fill(pOLLERIADataSet.TotalEntradasAgrupadoPorInsumo, FechaInicio, FechaFinal);
            this.reportViewer1.RefreshReport();
        }
    }
}

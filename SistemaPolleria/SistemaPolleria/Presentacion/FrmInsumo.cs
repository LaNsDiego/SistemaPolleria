using SistemaPolleria.Ayuda;
using SistemaPolleria.Entidad;
using SistemaPolleria.Negocio;
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
    public partial class FrmInsumo : Form
    {
        bool EsNuevoInsumo;
        public FrmInsumo()
        {
            InitializeComponent();
        }
        public string InsumoId { get; private set; }
        private List<int> InsumosId = new List<int>();
        private void GenerarId()
        {
            TxtCodigo.Text = ClsNInsumo.GenerarId();
        }

        private void LimpiarControles()
        {
            List<Control> Lista = new List<Control>
            {
                TxtCodigo,
                TxtNombre,
                CmbUnidadMedida
            };
            ClsNUI.LimpiarControles(Lista);
        }

        private void AjustarEstadoControles(bool disponibilidad)
        {
            List<Control> Lista = new List<Control>
            {
                TxtCodigo,
                TxtNombre,
                TxtCantidad,
                TxtCostoUnitario,
                TxtCostoTotal,
                BtnGuardar
            };
            ClsNUI.AjustarEstadoControles(Lista, disponibilidad);
        }

        private void AjustarEstadoControlesParaNuevo(/*bool disponibilidad*/)
        {
            List<Control> Lista = new List<Control>
            {
                TxtNombre,
                CmbUnidadMedida,
                BtnGuardar
            };
            ClsNUI.AjustarEstadoControles(Lista, true);
        }



        private void ListarInsumo()
        {
            DgvInsumo.DataSource = ClsNInsumo.Listar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClsInsumo Insumo = new ClsInsumo(
                TxtCodigo.Text,
                TxtNombre.Text,
                Convert.ToDouble(TxtCantidad.Text),
                Convert.ToDouble(TxtCostoUnitario.Text),
                Convert.ToDouble(TxtCostoTotal.Text),
                InsumosId[CmbUnidadMedida.SelectedIndex]
            );

            ClsNInsumo.Guardar(Insumo,EsNuevoInsumo);
            AjustarEstadoControles(false);
            LimpiarControles();
            ListarInsumo();
        }

        private void FrmInsumo_Load(object sender, EventArgs e)
        {
            AjustarEstadoControles(false);
            ListarInsumo();

            DataTable lista = ClsNUnidadMedida.Listar();
            foreach (DataRow fila in lista.Rows)
            {
                InsumosId.Add(Convert.ToInt32(fila["Id"]));
                CmbUnidadMedida.Items.Add(fila["Abreviatura"]);
            }
            CmbUnidadMedida.SelectedIndex = 0;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            EsNuevoInsumo = true;
            AjustarEstadoControlesParaNuevo();
            LimpiarControles();
            TxtCantidad.Text = "0";
            TxtCostoUnitario.Text = "0";
            TxtCostoTotal.Text = "0";
            GenerarId();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            CmbUnidadMedida.Enabled = true;
            TxtNombre.Enabled = true;
            BtnGuardar.Enabled = true;
            
        }

        private void DgvInsumo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigo.Text = DgvInsumo.CurrentRow.Cells["Id"].Value.ToString();
            TxtNombre.Text = DgvInsumo.CurrentRow.Cells["Nombre"].Value.ToString();
            TxtCostoUnitario.Text = DgvInsumo.CurrentRow.Cells["CostoUnitario"].Value.ToString();
            TxtCostoTotal.Text = DgvInsumo.CurrentRow.Cells["CostoTotal"].Value.ToString();
            TxtCantidad.Text = DgvInsumo.CurrentRow.Cells["Cantidad"].Value.ToString();
        }
    }
}

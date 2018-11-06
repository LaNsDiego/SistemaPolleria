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
    public partial class FrmKardex : Form
    {
        bool EsNuevo;
        public FrmKardex()
        {
            InitializeComponent();
        }

        private List<int> EstablescimientosId = new List<int>();

        private void AjustarControles(bool disponibilidad)
        {
            List<Control> Lista = new List<Control>
            {
                TxtIdKardex,
                CmbPeriodo,
                TxtRazonSocial,
                TxtRuc,
                CmbEstablecimiento,
                TxtIdInsumo,
                TxtNombreInsumo,
                TxtRuc,
                BtnGuardar

            };
            ClsNUI.AjustarEstadoControles(Lista, disponibilidad);
        }
        
        private void LimpiarControles()
        {
            List<Control> Lista = new List<Control>
            {
                TxtIdKardex,
                CmbPeriodo,
                CmbEstablecimiento,
                TxtIdInsumo,
                TxtNombreInsumo
            };
            ClsNUI.LimpiarControles(Lista);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClsKardex Kardex = new ClsKardex(
                TxtIdKardex.Text,
                CmbPeriodo.SelectedItem.ToString(),
                TxtRuc.Text,
                TxtRazonSocial.Text,
                EstablescimientosId[CmbEstablecimiento.SelectedIndex],
                TxtIdInsumo.Text
                );
            ClsNKardex.Guardar(Kardex,EsNuevo);
            DgvKardex.DataSource = ClsNKardex.Listar();
            AjustarControles(false);
            LimpiarControles();
        }

        private void TxtIdInsumo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ClsNRequerido.AlphaNumerico(TxtIdInsumo.Text, 4))
                {
                    DataTable TablaInsumo = ClsNInsumo.Obtener(TxtIdInsumo.Text);
                    if (TablaInsumo.Rows.Count > 0)
                    {
                        TxtNombreInsumo.Text = TablaInsumo.Rows[0]["Nombre"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro ningun insumo");
                    }
                }
                else
                {
                    MessageBox.Show("El Identificador de insumo debe tener 4 caracteres");
                }
            }
        }

        private void FrmKardex_Load(object sender, EventArgs e)
        {
            EstablescimientosId.Add(1);
            EstablescimientosId.Add(2);
            CmbEstablecimiento.Items.Add("ALMACEN GENERAL");
            CmbEstablecimiento.Items.Add("ALMACEN COCINA");
            CmbPeriodo.Items.Add("Octubre 2018");
            CmbPeriodo.SelectedIndex = 0;
            AjustarControles(false);
            DgvKardex.DataSource = ClsNKardex.Listar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            EsNuevo = true;
            TxtIdKardex.Text = ClsNKardex.GenerarId();
            List<Control> Lista = new List<Control>
            {
                CmbPeriodo,
                CmbEstablecimiento,
                TxtIdInsumo,
                BtnGuardar

            };
            ClsNUI.AjustarEstadoControles(Lista, true);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            EsNuevo = false;
            List<Control> Lista = new List<Control>
            {
                CmbPeriodo,
                CmbEstablecimiento,
                TxtIdInsumo,
                BtnGuardar

            };
            ClsNUI.AjustarEstadoControles(Lista, true);
        }
    }
}

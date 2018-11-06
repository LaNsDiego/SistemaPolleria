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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        public List<int> TiposProducto = new List<int>();

        private void AjustarControles(bool disponibilidad)
        {
            List<Control> Lista = new List<Control>
            {
               TxtIdProducto,
               TxtNombreProducto,
               TxtCantidadProducto,
               TxtPrecioProducto,
               TxtValorTotalProducto,
               CmbTipoProducto,
               TxtIdInsumo,
               TxtNombreInsumo,
               TxtCantidadUso,
               TxtUnidadMedida,
               BtnAgregarInsumo,
               BtnQuitarInsumo,
               BtnGuardar
            };
            ClsNUI.AjustarEstadoControles(Lista, disponibilidad);
        }

        private void LimpiarControles()
        {
            List<Control> Lista = new List<Control>
            {
               TxtIdProducto,
               TxtNombreProducto,
               TxtNombreInsumo,
               TxtCantidadProducto,
               TxtPrecioProducto,
               TxtValorTotalProducto,
               CmbTipoProducto,
               TxtIdInsumo,
               TxtNombreInsumo,
               TxtCantidadUso,
               TxtUnidadMedida
            };
            ClsNUI.LimpiarControles(Lista);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            double PU = Convert.ToDouble(TxtPrecioProducto.Text);
            int Cantidad = Convert.ToInt32(TxtCantidadProducto.Text);
            ClsProducto Producto = new ClsProducto(
                                       TxtIdProducto.Text,
                                       TxtNombreProducto.Text,
                                       PU,
                                       Convert.ToDouble(PU * Cantidad),
                                       Cantidad,
                                       Convert.ToInt32(TiposProducto[CmbTipoProducto.SelectedIndex])
            );
            ClsNProducto.Guardar(Producto,true);
            foreach (DataGridViewRow Fila in DgvDetalleProducto.Rows)
            {
                ClsDetalleProducto DetalleProducto = new ClsDetalleProducto(
                    Fila.Cells["IdInsumo"].Value.ToString(),
                    TxtIdProducto.Text,
                    Convert.ToDouble(Fila.Cells["Cantidad"].Value)
                    );
                ClsNDetalleProducto.Guardar(DetalleProducto);
            }
            DgvProducto.DataSource = ClsNProducto.Listar();
            LimpiarControles();
            AjustarControles(false);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            List<Control> Lista = new List<Control>
            {
               TxtNombreProducto,
               TxtCantidadProducto,
               TxtPrecioProducto,
               CmbTipoProducto,
               TxtIdInsumo,
               TxtCantidadUso,
               BtnAgregarInsumo,
               BtnQuitarInsumo,
               BtnGuardar
            };
            ClsNUI.AjustarEstadoControles(Lista, true);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

            List<Control> Lista = new List<Control>
            {
                TxtNombreProducto,
               TxtCantidadProducto,
               TxtPrecioProducto,
               CmbTipoProducto,
               TxtIdInsumo,
               TxtCantidadUso,
               BtnAgregarInsumo,
               BtnQuitarInsumo,
               BtnGuardar
            };
            ClsNUI.AjustarEstadoControles(Lista, true);
            TxtIdProducto.Text = ClsNProducto.GenerarId();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            AjustarControles(false);
            DataTable Filas = ClsNTipoProducto.Listar();
            foreach (DataRow Fila in Filas.Rows)
            {
                TiposProducto.Add(Convert.ToInt32(Fila["Id"]));
                CmbTipoProducto.Items.Add(Fila["Nombre"]);
            }

            
            DgvProducto.DataSource = ClsNProducto.Listar();
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
                        DataTable TablaUnidadMedida =  ClsNUnidadMedida.Obtener(Convert.ToInt32(TablaInsumo.Rows[0]["IdUnidadMedida"]));
                        TxtUnidadMedida.Text = TablaUnidadMedida.Rows[0]["Nombre"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro ningun proveedor");
                    }
                }
                else
                {
                    MessageBox.Show("El Codigo de proveedor debe tener 4 caracteres");
                }
            }
        }

        private void BtnAgregarInsumo_Click(object sender, EventArgs e)
        {

            DgvDetalleProducto.Rows.Add(TxtNombreInsumo.Text,TxtIdInsumo.Text,TxtCantidadUso.Text,TxtUnidadMedida.Text);
        }
    }
}

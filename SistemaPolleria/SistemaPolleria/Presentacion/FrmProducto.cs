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
               
            };
            ClsNUI.AjustarEstadoControles(Lista, disponibilidad);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClsProducto Producto = new ClsProducto(
                                       TxtIdProducto.Text,
                                       TxtNombre.Text,
                                       Convert.ToDouble(TxtPrecio.Text),
                                       Convert.ToDouble(TxtValorTotal.Text),
                                       Convert.ToInt32(TxtCantidad.Text),
                                       Convert.ToInt32(CmbTipoProducto.SelectedItem.ToString())
            );
            ClsNProducto.Guardar(Producto,false);
            foreach (DataGridViewRow Fila in DgvDetalleProducto.Rows)
            {
                ClsDetalleProducto DetalleProducto = new ClsDetalleProducto(
                    Fila.Cells["IdInsumo"].Value.ToString(),
                    TxtIdProducto.Text,
                    Convert.ToDouble(Fila.Cells["Cantidad"].Value)
                    );
                ClsNDetalleProducto.Guardar(DetalleProducto);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            DataTable Filas = ClsNTipoProducto.Listar();
            foreach (DataRow Fila in Filas.Rows)
            {
                TiposProducto.Add(Convert.ToInt32(Fila["Id"]));
                CmbTipoProducto.Items.Add(Fila["Nombre"]);
            }
        }
    }
}

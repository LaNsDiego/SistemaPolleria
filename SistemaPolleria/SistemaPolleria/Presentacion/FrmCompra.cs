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
    public partial class FrmCompra : Form
    {
        private string EmpleadoId;
        private string ProveedorId;
        List<string> TiposComprobanteId = new List<string>();
        private double SumaSubtotal = 0;
        public FrmCompra()
        {
            InitializeComponent();
        }

        private void AjustarControles(bool disponibilidad)
        {
            List<Control> Lista = new List<Control>
            {
                CmbTipoComprobante,
                TxtObservacion,
                TxtSerie,
                TxtNumero,
                DtpFecha,
                TxtDocumento,
                TxtRazonSocialEmpleado,
                TxtCodigoProveedor,
                TxtRazonSocialProveedor,
                TxtRuc,
                TxtIdInsumo,
                TxtNombreInsumo,
                TxtCantidadCompra,
                TxtCostoUnitario,
                TxtTotalNumerico,
                TxtTotalLiteral,
                TxtValorIgv,
                BtnAgregar,
                BtnQuitar,
                BtnGuardar

            };
            ClsNUI.AjustarEstadoControles(Lista, disponibilidad);
        }
        private void LimpiarControles()
        {
            List<Control> Lista = new List<Control>
            {
                CmbTipoComprobante,
                TxtObservacion,
                DtpFecha,
                TxtCodigoProveedor,
                TxtRazonSocialProveedor,
                TxtRuc,
                TxtIdInsumo,
                TxtNombreInsumo,
                TxtCantidadCompra,
                TxtCostoUnitario,
                TxtTotalNumerico,
                TxtTotalLiteral,
                TxtValorIgv


            };
            ClsNUI.LimpiarControles(Lista);
        }

        private void CalcularTotal()
        {
            double ValorIGV = SumaSubtotal * 0.18;
            double Total = SumaSubtotal + ValorIGV;
            TxtValorIgv.Text = ValorIGV.ToString();
            TxtTotalNumerico.Text = Total.ToString();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            AjustarControles(false);
            EmpleadoId = FrmPrincipalAdministrador.Empleado.Id;
            TxtDocumento.Text = FrmPrincipalAdministrador.Empleado.Dni;
            TxtRazonSocialEmpleado.Text = FrmPrincipalAdministrador.Empleado.Apellidos + " " + FrmPrincipalAdministrador.Empleado.Nombre;
            DataTable TiposComprobante = ClsNTipoComprobante.Listar();
            foreach (DataRow Fila in TiposComprobante.Rows)
            {
                TiposComprobanteId.Add(Fila["Id"].ToString());
                CmbTipoComprobante.Items.Add(Fila["Nombre"]);
            }
            CmbTipoComprobante.SelectedIndex = 1;
        }

        private void TxtCodigoProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (ClsNRequerido.AlphaNumerico(TxtCodigoProveedor.Text, 4))
                {
                    DataTable Fila = ClsNProveedor.Obtener(TxtCodigoProveedor.Text);
                    if (Fila.Rows.Count > 0)
                    {
                        ProveedorId = Fila.Rows[0]["Id"].ToString();
                        TxtRazonSocialProveedor.Text = Fila.Rows[0]["RazonSocial"].ToString();
                        TxtRuc.Text = Fila.Rows[0]["Ruc"].ToString();
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            double CostoUnitario = Convert.ToDouble(TxtCostoUnitario.Text);
            double Cantidad = Convert.ToDouble(TxtCantidadCompra.Text);
            double Subtotal = CostoUnitario * Cantidad;
            SumaSubtotal += Subtotal;
            DgvDetalleCompra.Rows.Add(
                TxtIdInsumo.Text,
                TxtNombreInsumo.Text,
                TxtCantidadCompra.Text,
                TxtCostoUnitario.Text,
                Subtotal.ToString()
            );
            CalcularTotal();

        }

        private void TxtIdProducto_KeyDown(object sender, KeyEventArgs e)
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
                        MessageBox.Show("No se encontro ningun proveedor");
                    }
                }
                else
                {
                    MessageBox.Show("El Codigo de proveedor debe tener 4 caracteres");
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DateTime Fecha = Convert.ToDateTime(DtpFecha.Text);
            ClsCompra Compra = new ClsCompra(
                TiposComprobanteId[CmbTipoComprobante.SelectedIndex],
                EmpleadoId,
                ProveedorId,
                TxtSerie.Text,
                TxtNumero.Text,
                Fecha,
                Convert.ToDouble(TxtTotalNumerico.Text),
                TxtObservacion.Text,
                true
                );
            int CompraId = ClsNCompra.Guardar(Compra);
            
            
            foreach (DataGridViewRow Fila in DgvDetalleCompra.Rows)
            {
                ClsDetalleCompra DetalleCompra = new ClsDetalleCompra(
                                CompraId,
                                Fila.Cells["IdInsumo"].Value.ToString(),
                                Convert.ToDouble(Fila.Cells["CostoUnitario"].Value),
                                Convert.ToDouble(Fila.Cells["Cantidad"].Value),
                                Convert.ToDouble(Fila.Cells["Subtotal"].Value)
                );
                
                string KardexId = ClsNKardex.ObtenerKardexDeUnInsumo(Fila.Cells["IdInsumo"].Value.ToString());
                ClsDetalleKardex DetalleKardex = new ClsDetalleKardex(
                    KardexId,
                    Fecha,
                    "01",
                    TiposComprobanteId[CmbTipoComprobante.SelectedIndex],
                    TxtSerie.Text,
                    TxtNumero.Text,
                    DetalleCompra.Cantidad,
                    DetalleCompra.CostoUnitario,
                    DetalleCompra.Subtotal
                    );
                ClsNDetalleCompra.Guardar(DetalleCompra);
                ClsNDetalleKardex.Guardar(DetalleKardex);
                ClsNInsumo.Entrada(DetalleCompra);
            }

            LimpiarControles();
            AjustarControles(false);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            List<Control> Lista = new List<Control>
            {
                CmbTipoComprobante,
                TxtObservacion,
                TxtSerie,
                TxtNumero,
                TxtCodigoProveedor,
                TxtIdInsumo,
                TxtCantidadCompra,
                TxtCostoUnitario,
                BtnAgregar,
                BtnQuitar,
                BtnGuardar

            };
            ClsNUI.AjustarEstadoControles(Lista, true);
        }
    }
}

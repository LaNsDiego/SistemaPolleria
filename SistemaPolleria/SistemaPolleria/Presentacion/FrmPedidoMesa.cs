﻿using SistemaPolleria.Ayuda;
using SistemaPolleria.Entidad;
using SistemaPolleria.Negocio;
using System;
using System.Collections;
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
    public partial class FrmPedidoMesa : Form
    {
        private List<string> TiposComprobanteId = new List<string>();
        public string EmpleadoId { get; private set; } = FrmPrincipalMoso.Empleado.Id;
        public string ProductoId { get; private set; }
        public string MesaId { get; private set; }
        public string ClienteId { get; private set; } = "CL000001";
        //ArrayList Mesas = new ArrayList();

        public FrmPedidoMesa()
        {
            InitializeComponent();
        }

        private void LimpiarControles()
        {
            DgvPedidosMesa.Rows.Clear();
            List<Control> Lista = new List<Control>
            {
                TxtIdPedido,
                CmbTipoComprobante,
                DtpFechaPedido,
                TxtCodigoProducto,
                TxtNombreProducto,
                TxtPrecioUnitario,
                TxtCantidadCompra,
                TxtStockProducto
            };
            ClsNUI.LimpiarControles(Lista);
        }


        public void MostarMesas()
        {
            DataTable TablaMesasPorNivel = ClsNMesa.Listar();

            foreach (DataRow Mesa in TablaMesasPorNivel.Rows)
            {
                if (Convert.ToInt32(Mesa["Piso"]) == Convert.ToInt32(CmbNumeroPiso.SelectedItem.ToString()) )
                {
                    //Console.WriteLine(Mesa["Id"] +" =>"+Mesa["Piso"] + "==" + CmbNumeroPiso.SelectedItem.ToString());
                    CmbCodigoMesa.Items.Add(Mesa["Id"]);
                }
            }
        }

        private void AjustarControles(bool disponibilidad)
        {
            List<Control> Lista = new List<Control>
            {
                TxtIdPedido,
                CmbCodigoMesa,
                CmbNumeroPiso,
                GpbEstado,
                BtnBuscarProducto,
                TxtCodigoProducto,
                TxtNombreProducto,
                TxtPrecioUnitario,
                TxtNombreProducto,
                TxtStockProducto,
                TxtCantidadCompra,
                BtnAgregarCarrito,
                BtnQuitarCarrito,
                TxtTotalNumerico,
                BtnGuardar
            };
            ClsNUI.AjustarEstadoControles(Lista, disponibilidad);
        }

        private void BuscarProducto()
        {
            if (ClsNRequerido.AlphaNumerico(TxtCodigoProducto.Text, 6))
            {
                DataTable Fila = ClsNProducto.Obtener(TxtCodigoProducto.Text);
                if (Fila.Rows.Count > 0)
                {
                    ProductoId = Fila.Rows[0]["Id"].ToString();
                    TxtNombreProducto.Text = Fila.Rows[0]["Nombre"].ToString();
                    TxtPrecioUnitario.Text = Fila.Rows[0]["PrecioUnitario"].ToString();
                    TxtStockProducto.Text = Fila.Rows[0]["Cantidad"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontro ningun cliente con un documento similar");
                }
            }
            else
            {
                MessageBox.Show("El Id del producto debe tener 6 caracteres");
            }

        }
        


        //private void BtnBuscarCliente_Click(object sender, EventArgs e)
        //{
        //    if (ClsNRequerido.EnteroValido(TxtDocumentoCliente.Text, 8) || ClsNRequerido.EnteroValido(TxtDocumentoCliente.Text, 11))
        //    {
        //        DataTable Fila = ClsNCliente.BuscarPorDocumento(TxtDocumentoCliente.Text);
        //        if (Fila.Rows.Count > 0)
        //        {
        //            EmpleadoId = Fila.Rows[0]["Id"].ToString();
        //            TxtRazonSocial.Text = Fila.Rows[0]["RazonSocial"].ToString();
        //            TxtTelefono.Text = Fila.Rows[0]["Telefono"].ToString();
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se encontro ningun cliente con un documento similar");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("El documento debe contener 8 u 11 caracteres numericos");
        //    }
        //}

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void BtnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (ClsNRequerido.EnteroValido(TxtCantidadCompra.Text) && TxtCantidadCompra.Text != null)
            {
                bool ProductoComprado = false;
                string IdProducto = TxtCodigoProducto.Text;
                double Precio = Convert.ToDouble(TxtPrecioUnitario.Text);
                int CantidadCompra = Convert.ToInt32(TxtCantidadCompra.Text);
                double CantidadAlmacen = Convert.ToDouble(TxtStockProducto.Text);
                if (CantidadAlmacen - CantidadCompra > -1)
                {
                    double Subtotal = Precio * CantidadCompra;
                    double Total = Convert.ToDouble(TxtTotalNumerico.Text);
                    TxtTotalNumerico.Text = (Total + Subtotal).ToString();
                    //ClsNProducto.RestarProducto(IdProducto, CantidadCompra);
                    BuscarProducto();
                    ClsNConvertidor convertidor = new ClsNConvertidor();//creamos un objeto de la clase que convierte numero a literal
                    convertidor.SeparadorDecimalSalida = " Soles con";//separa la parte entera y la parte decimal de una conversion literal
                    TxtTotalLiteral.Text = convertidor.ToCustomCardinal((Total + Subtotal));//convertimos el total en literal
                    foreach (DataGridViewRow Fila in DgvPedidosMesa.Rows)
                    {
                        ProductoComprado = false;
                        if (Fila.Cells[0].Value.ToString() == IdProducto.ToString())
                        {
                            ProductoComprado = true;
                        }

                    }


                    if (ProductoComprado)
                    {
                        //Aqui es cuando el producto ya existe en el detalle
                        foreach (DataGridViewRow Fila in DgvPedidosMesa.Rows)
                        {
                            if (Fila.Cells[0].Value.ToString() == IdProducto.ToString())
                            {
                                int cantidad = Convert.ToInt32(Fila.Cells[2].Value);
                                double SubtotalAntiguo = Convert.ToDouble(Fila.Cells[4].Value);
                                Fila.Cells[2].Value = cantidad + CantidadCompra;
                                Fila.Cells[4].Value = SubtotalAntiguo + Subtotal;
                            }
                        }
                    }
                    else
                    {
                        DgvPedidosMesa.Rows.Add(IdProducto,TxtNombreProducto.Text ,CantidadCompra, Precio, Subtotal);
                    }



                }
                else
                {
                    MessageBox.Show("Esta excediendo la cantidad del producto.");
                }
            }
        }

        private void FrmPedidoMesa_Load(object sender, EventArgs e)
        {
            DataTable TiposComprobante = ClsNTipoComprobante.Listar();
            foreach (DataRow Fila in TiposComprobante.Rows)
            {
                TiposComprobanteId.Add(Fila["Id"].ToString());
                CmbTipoComprobante.Items.Add(Fila["Nombre"]);
            }
            CmbTipoComprobante.SelectedIndex = 0;


            DataTable Series = ClsNSerie.Listar();
            foreach (DataRow Fila in Series.Rows)
            {
                CmbSerie.Items.Add(Fila["Serie"]);
            }

            CmbNumeroPiso.Items.Add("1");
            CmbNumeroPiso.Items.Add("2");
            CmbNumeroPiso.SelectedIndex = 0;

            AjustarControles(false);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            List<Control> Lista = new List<Control>
            {
                CmbCodigoMesa,
                CmbNumeroPiso,
                GpbEstado,
                TxtCodigoProducto,
                BtnBuscarProducto,
                TxtCantidadCompra,
                BtnAgregarCarrito,
                BtnQuitarCarrito,
                BtnGuardar
            };
            ClsNUI.AjustarEstadoControles(Lista, true);
            TxtIdPedido.Text = ClsNPedido.GenerarId();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            if (MesaId != null && ClienteId != null && DgvPedidosMesa.Rows.Count > 0 && TxtNumero.Text != null && CmbSerie.SelectedIndex > -1)
            {
                int Estado = RdnEstadoAtendido.Checked ? 1 : RdnEstadoEspera.Checked ? 2 : 3;
                ClsPedido Pedido = new ClsPedido
                (
                    TxtIdPedido.Text,
                    ClienteId,
                    EmpleadoId,
                    false,// FALSE indica pedido mesa
                    Convert.ToDateTime(DtpFechaPedido.Text),
                    Convert.ToDouble(TxtTotalNumerico.Text),
                    Estado
                );
                ClsNPedido.Guardar(Pedido,true);

                foreach (DataGridViewRow Fila in DgvPedidosMesa.Rows)
                {
                    ClsDetallePedido Detalle = new ClsDetallePedido
                        (
                            TxtIdPedido.Text,
                            Fila.Cells[0].Value.ToString(),
                            Convert.ToDouble(Fila.Cells[3].Value),
                            Convert.ToInt32(Fila.Cells[2].Value),
                            Convert.ToDouble(Fila.Cells[4].Value)
                        );
                    ClsNDetallePedido.Guardar(Detalle);

                    DataTable TablaDetalleProducto = ClsNDetalleProducto.ObtenerPorProducto(Detalle.IdProducto);
                    if (CmbTipoComprobante.SelectedIndex == 0)
                    {
                        ClsBoleta Boleta = new ClsBoleta(
                            CmbSerie.SelectedItem.ToString(),
                            TxtNumero.Text,
                            Convert.ToDateTime(DtpFechaPedido.Text),
                            TxtIdPedido.Text
                            );
                        ClsNInsumo.CrearBoleta(Boleta);
                    }
                    else
                    {
                        ClsFactura Factura = new ClsFactura(
                            CmbSerie.SelectedItem.ToString(),
                            TxtNumero.Text,
                            Convert.ToDateTime(DtpFechaPedido.Text),
                            ("GR" + TxtNumero.Text),
                            TxtIdPedido.Text
                            );
                        ClsNInsumo.CrearFactura(Factura);
                    }
                    foreach (DataRow FilaDetalleProducto in TablaDetalleProducto.Rows)
                    {
                        ClsDetalleProducto DetalleProducto = new ClsDetalleProducto(
                            FilaDetalleProducto["IdInsumo"].ToString(),
                            FilaDetalleProducto["IdProducto"].ToString(),
                            Convert.ToDouble(FilaDetalleProducto["Cantidad"])
                            );


                        if (CmbTipoComprobante.SelectedIndex == 0) {
                            ClsNInsumo.SalidaBoleta(DetalleProducto,CmbSerie.SelectedItem.ToString(),TxtNumero.Text);
                        }
                        else
                        {
                            ClsNInsumo.SalidaFactura(DetalleProducto, CmbSerie.SelectedItem.ToString(), TxtNumero.Text);
                        }

                            
                            

                    }
                    
                }
                LimpiarControles();
                AjustarControles(false);
                TxtTotalLiteral.Text = string.Empty;
                TxtTotalNumerico.Text = 0.ToString();

            }
            else
            {
                MessageBox.Show("Llene la Pedido correctamente");
            }
        }

        private void CmbNumeroPiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostarMesas();
        }

        private void CmbCodigoMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            MesaId = CmbCodigoMesa.SelectedItem.ToString();
        }
    }
}

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
    public partial class FrmListaPedido : Form
    {
        public FrmListaPedido()
        {
            InitializeComponent();
        }

        private void FrmListaPedido_Load(object sender, EventArgs e)
        {
            DgvListaPedidos.DataSource = ClsNPedido.Listar();
        }

        public void AbrirFormHijo(object frmHijo)
        {
            Form frm = frmHijo as Form;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            //frm.TopLevel = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Visible = true;
            frm.Show();
        }


        private void BtnRealizarPago_Click(object sender, EventArgs e)
        {
            //DataRow FilaCliente = ClsNCliente.BuscarPorDocumento("88888888").Rows[0];
            //ClsCliente Cliente = new ClsCliente(
            //    FilaCliente["Id"].ToString(),
            //    FilaCliente["RazonSocial"].ToString(),
            //    FilaCliente["Documento"].ToString(),
            //    FilaCliente["Telefono"].ToString(),
            //    FilaCliente["IdTipoCliente"].ToString()
            //    );
            //DataRow FilaPedido = ClsNPedido.Obtener(DgvListaPedidos.CurrentRow.Cells["Id"].Value.ToString()).Rows[0];
            //ClsPedido Pedido = new ClsPedido(
            //    FilaPedido["Id"].ToString(),
            //    FilaPedido["IdCliente"].ToString(),
            //    FilaPedido["IdEmpleado"].ToString(),
            //    Convert.ToBoolean(FilaPedido["TipoPedido"].ToString()),
            //    Convert.ToDateTime(FilaPedido["FechaPedido"].ToString()),
            //    Convert.ToDouble(FilaPedido["Total"].ToString()),
            //    Convert.ToInt32(FilaPedido["Estado"].ToString())
            //    );
            //FrmVenta frm = new FrmVenta(Cliente, Pedido);
            //AbrirFormHijo(frm);
        }
    }
}

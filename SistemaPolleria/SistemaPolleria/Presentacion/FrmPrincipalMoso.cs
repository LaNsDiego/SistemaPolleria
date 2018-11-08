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
    public partial class FrmPrincipalMoso : Form
    {
        public static ClsEmpleado Empleado = null;
        public FrmPrincipalMoso(ClsEmpleado empleado)
        {
            Empleado = empleado;
            InitializeComponent();
        }

        private void AbrirFormHijo(object frmHijo)
        {
            PanelPadre.Controls.Clear();
            Form frm = frmHijo as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.StartPosition = FormStartPosition.CenterParent;
            if (PanelPadre.Controls.Count > 0) { PanelPadre.Controls.RemoveAt(0); }
            PanelPadre.Controls.Add(frm);
            frm.Show();
        }

        private void BtnPedidoMesa_Click(object sender, EventArgs e)
        {
            FrmPedidoMesa frm = new FrmPedidoMesa();
            AbrirFormHijo(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

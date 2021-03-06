﻿using SistemaPolleria.Negocio;
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
    public partial class FrmPrincipalAdministrador : Form
    {
        public static ClsEmpleado Empleado = null;
        public FrmPrincipalAdministrador(ClsEmpleado empleado)
        {
            Empleado = empleado;
            InitializeComponent();
        }

        public void AbrirFormHijo(object frmHijo)
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


        private void BtnSalirSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnInsumo_Click(object sender, EventArgs e)
        {
            FrmInsumo frm = new FrmInsumo();
            AbrirFormHijo(frm);
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            AbrirFormHijo(frm);
        }

        private void FrmPrincipalAdministrador_Load(object sender, EventArgs e)
        {
            LblCargoUsuario.Text = Empleado.IdCargo.ToString();
            LblApellidoUsuario.Text = Empleado.Apellidos;
            LblNombreUsuario.Text = Empleado.Nombre;

        }

        private void BtnCompra_Click(object sender, EventArgs e)
        {
            FrmCompra frm = new FrmCompra();
            AbrirFormHijo(frm);
        }

        private void BtnKardex_Click(object sender, EventArgs e)
        {
            FrmKardex frm = new FrmKardex();
            AbrirFormHijo(frm);
        }

        private void BtnPedidoDelivery_Click(object sender, EventArgs e)
        {
            //FrmPedidoDelivery frm = new FrmPedidoDelivery();
            //AbrirFormHijo(frm);
        }

        private void BtnListaPedido_Click(object sender, EventArgs e)
        {
            FrmListaPedido frm = new FrmListaPedido();
            AbrirFormHijo(frm);
        }

        private void BtnKardexSalida_Click(object sender, EventArgs e)
        {
            FrmReporteKardexSalida frm = new FrmReporteKardexSalida();
            AbrirFormHijo(frm);
        }

        private void BtnReporteKardexEntrada_Click(object sender, EventArgs e)
        {
            FrmReporteKardexEntrada frm = new FrmReporteKardexEntrada();
            AbrirFormHijo(frm);
        }

        private void BtnPlanilla_Click(object sender, EventArgs e)
        {
            FrmPlanilla frm = new FrmPlanilla();
            AbrirFormHijo(frm);
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            FrmAsistencia frm = new FrmAsistencia();
            AbrirFormHijo(frm);
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario frm = new FrmInventario();
            AbrirFormHijo(frm);
        }

        private void BtnReporteVentas_Click(object sender, EventArgs e)
        {
            FrmReportVenta frm = new FrmReportVenta();
            AbrirFormHijo(frm);
        }

        private void BtnReporteCompra_Click(object sender, EventArgs e)
        {
            FrmReporteCompra frm = new FrmReporteCompra();
            AbrirFormHijo(frm);
        }
    }
}

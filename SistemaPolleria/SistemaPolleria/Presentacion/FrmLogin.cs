using SistemaPolleria.Entidad;
using SistemaPolleria.Negocio;
using SistemaPolleria.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            
            ClsUsuario Usuario = new ClsUsuario(TxtCodigoEmpleado.Text, TxtClave.Text);
            DataTable Consulta = ClsNUsuario.IniciarSesion(Usuario);
            if (Consulta.Rows.Count > 0)
            {
                DataTable Empleado = ClsNEmpleado.Obtener(Consulta.Rows[0]["IdEmpleado"].ToString());
                int IdCargo = Convert.ToInt32(Empleado.Rows[0]["IdCargo"]);
                this.Hide();
                if (IdCargo == 1)
                {
                    FrmPrincipalMoso frm = new FrmPrincipalMoso();
                    frm.Show();
                }
                else if (IdCargo == 2)
                {
                    FrmPrincipalAdministrador frm = new FrmPrincipalAdministrador();
                    frm.Show();
                }



            }
            else
            {
                MessageBox.Show("El usuario y/o clave no son correctos.");
            }
        }
    }
}

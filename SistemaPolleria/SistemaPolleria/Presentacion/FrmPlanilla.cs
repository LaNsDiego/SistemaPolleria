using SistemaPolleria.Ayuda;
using SistemaPolleria.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.Presentacion
{
    public partial class FrmPlanilla : Form
    {

        int estado = 0;

        public FrmPlanilla()
        {
            InitializeComponent();
            llenatxtplanilla();
            llenacboempleado();
            llenacbopagomensual();
        }


        public void llenatxtplanilla()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            //conexion.ConnectionString = @"Data Source=.;Initial Catalog=POLLERIA;User ID=sa;Password=upt";
            conexion.ConnectionString = ClsNConexion.conex;
            //codigo para llenar el comboBox
            DataSet ds = new DataSet();
            //endicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT Nombre FROM Planilla", conexion);
            //se indica el nombre de la tabla
            // no lo sheee  da.Fill(ds, "Planilla");
            //Txt_IdDelInventario.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            //Txt_IdDelInventario.ValueMember = "Nombre";
        }
        public void llenacboempleado()
        {
            DataTable TablaMesasPorNivel = ClsNProducto.Listar();

            foreach (DataRow Mesa in TablaMesasPorNivel.Rows)
            {
                Cmb_IdEmpleado.Items.Add(Mesa["Id"]);
            }
        }

        public void llenacbopagomensual()
        {
            DataTable TablaMesasPorNivel = ClsNProducto.Listar();

            foreach (DataRow Mesa in TablaMesasPorNivel.Rows)
            {
                Cmb_IdEmpleado.Items.Add(Mesa["Id"]);
            }
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[8];
            MessageBox.Show(txt_IdPlanilla.Text);
            parametros[0] = new ClsNSQLParametro(txt_IdPlanilla.Text, "@Id", SqlDbType.VarChar);
            parametros[1] = new ClsNSQLParametro(Cmb_IdEmpleado.Text, "@IdEmpleado", SqlDbType.VarChar);
            parametros[2] = new ClsNSQLParametro(txt_DiasLaborados.Text, "@DiasLaborados", SqlDbType.Int);
            parametros[3] = new ClsNSQLParametro(Cmb_PagoMensual.Text, "@HorasExtras", SqlDbType.Int);
            parametros[4] = new ClsNSQLParametro(numericUpDown1.Text, "@Descuento", SqlDbType.Decimal);
            parametros[5] = new ClsNSQLParametro(Txt_PagoMDevengado.Text, "@PagoMensualOrdinario", SqlDbType.Decimal);
            parametros[6] = new ClsNSQLParametro(txt_Descuento.Text, "@PagoMensualDevengado", SqlDbType.Decimal);
            parametros[7] = new ClsNSQLParametro(Txt_PagoMensualLiquido.Text, "@PagoMensualLiquido", SqlDbType.Decimal);
            ClsNConexion.EjecutarProcedimiento("CrearPlanilla", parametros);
        }

        private void FrmPlanilla_Load_1(object sender, EventArgs e)
        {
            txt_IdPlanilla.Text = ClsNConexion.EjecutarProcedimiento("GenerarIdInventario").Tables[0].Rows[0]["Id"].ToString();
        }
    }
}

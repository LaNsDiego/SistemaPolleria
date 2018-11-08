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
    public partial class FrmInventario : Form
    {
        int estado = 0;

        public FrmInventario()
        {
            InitializeComponent();
            llenacboinventario();
            llenacboproducto();
        }

        public void llenacboinventario()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            conexion.ConnectionString = ClsNConexion.conex;
            //codigo para llenar el comboBox
            DataSet ds = new DataSet();
            //endicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT Nombre FROM Inventario", conexion);
            //se indica el nombre de la tabla
            //da.Fill(ds, "Inventario");
            //Txt_IdDelInventario.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            //Txt_IdDelInventario.ValueMember = "Nombre";
        }
        public void llenacboproducto()
        {
            DataTable TablaMesasPorNivel = ClsNProducto.Listar();

            foreach (DataRow Mesa in TablaMesasPorNivel.Rows)
            {
                Cmb_IdProducto.Items.Add(Mesa["Id"]);
            }
        }


        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (Rdb_Bueno.Checked == true)
            {
                estado = 1;
            }
            if (rdb_malo.Checked == true)
            {
                estado = 2;
            }

            ClsNSQLParametro[] parametros = new ClsNSQLParametro[4];
            MessageBox.Show(Txt_IdDelInventario.Text);
            parametros[0] = new ClsNSQLParametro(Txt_IdDelInventario.Text, "@Id", SqlDbType.VarChar);
            parametros[1] = new ClsNSQLParametro(Cmb_IdProducto.Text, "@IdProducto", SqlDbType.VarChar);
            parametros[2] = new ClsNSQLParametro(estado, "@Estado", SqlDbType.Int);
            parametros[3] = new ClsNSQLParametro(TxtObservacion.Text, "@Observacion", SqlDbType.VarChar);
            ClsNConexion.EjecutarProcedimiento("CrearInventario", parametros);
        }

        private void FrmInventario_Load_1(object sender, EventArgs e)
        {
            Txt_IdDelInventario.Text = ClsNConexion.EjecutarProcedimiento("GenerarIdInventario").Tables[0].Rows[0]["Id"].ToString();
        }
    }
}

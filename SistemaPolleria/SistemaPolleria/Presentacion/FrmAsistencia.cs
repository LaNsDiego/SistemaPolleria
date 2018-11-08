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


    public partial class FrmAsistencia : Form
    {

        int estado = 0, id = 1;

        public FrmAsistencia()
        {
            InitializeComponent();
            llenacbocargo();
            llenacboempleado();
        }

        private void FrmAsistencia_Load(object sender, EventArgs e)
        {

        }

        public void llenacbocargo()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            conexion.ConnectionString = ClsNConexion.conex;
            //codigo para llenar el comboBox
            DataSet ds = new DataSet();
            //endicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT Nombre FROM Cargo", conexion);
            //se indica el nombre de la tabla
            da.Fill(ds, "Cargo");
            Cmb_IdCargo.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            Cmb_IdCargo.ValueMember = "Nombre";
        }
        public void llenacboempleado()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            conexion.ConnectionString = ClsNConexion.conex;
            //codigo para llenar el comboBox
            DataSet ds = new DataSet();
            //endicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id FROM Empleado", conexion);
            //se indica el nombre de la tabla
            da.Fill(ds, "Empleado");
            comboBox1.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            comboBox1.ValueMember = "Id";
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (Rdb_Asiste.Checked == true)
            {
                estado = 1;
            }
            if (rdb_Tarde.Checked == true)
            {
                estado = 2;
            }
            if (Rdb_Falta.Checked == true)
            {
                estado = 3;
            }

            ClsNSQLParametro[] parametros = new ClsNSQLParametro[3];
            MessageBox.Show(comboBox1.Text);
            parametros[0] = new ClsNSQLParametro(comboBox1.Text, "@IdEmpleado", SqlDbType.VarChar);
            parametros[1] = new ClsNSQLParametro(Convert.ToDateTime(dateTimePicker1.Text), "@Fecha", SqlDbType.Date);
            parametros[2] = new ClsNSQLParametro(estado, "@Estado", SqlDbType.Int);
            ClsNConexion.EjecutarProcedimiento("CrearAsistencia", parametros);
        }

    }
}

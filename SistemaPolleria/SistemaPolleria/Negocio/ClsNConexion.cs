using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaPolleria.Ayuda;
using System.Data.OleDb;

namespace SistemaPolleria.Negocio
{
    public abstract class ClsNConexion
    {
        //private static readonly string conex = "Server=AEPIS28;Database=POLLERIA;Integrated Security=true";
        private static readonly string conex = "Server=.\\SQLEXPRESS2017;Database=POLLERIA;Integrated Security=true";
        private static SqlConnection conexion = new SqlConnection(conex);
        private ClsNConexion()
        {

        }

        public static SqlConnection GetConexion()
        {
            return ClsNConexion.conexion;
        }
        public static void Conectar()
        {
            if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

        }


        private static void Desconectar()
        {
            conexion.Close();
        }

        public static DataSet EjecutarProcedimiento(string procedimiento, ClsNSQLParametro[] parametros = null)
        {

            DataSet ds = new DataSet();
            SqlDataAdapter data = new SqlDataAdapter();
            SqlCommand cmd = ClsNConexion.GetConexion().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procedimiento;
            if (parametros != null)
            {
                for (int i = 0; i < parametros.Length; i++)
                {
                    cmd.Parameters.Add(parametros[i].Nombre, parametros[i].Tipo).Value = parametros[i].Valor;
                }
            }

            data.SelectCommand = cmd;
            ClsNConexion.Conectar();
            data.Fill(ds);
            ClsNConexion.Desconectar();
            return ds;

        }

    }
}

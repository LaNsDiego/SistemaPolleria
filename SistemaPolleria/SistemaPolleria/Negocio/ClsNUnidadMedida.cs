using SistemaPolleria.Ayuda;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Negocio
{
    class ClsNUnidadMedida
    {
        //public static string Guardar(ClsUnidadMedida UnidadMedida)
        //{
        //    string Procedimiento = string.Empty;
        //    ClsNSQLParametro[] parametros;

        //    if (UnidadMedida.Id != string.Empty)
        //    {
        //        Procedimiento = "ActualizarUnidadMedida";
        //        parametros = new ClsNSQLParametro[7];
        //        parametros[0] = new ClsNSQLParametro(UnidadMedida.Id, "@Id", SqlDbType.VarChar);
        //        parametros[1] = new ClsNSQLParametro(UnidadMedida.IdCliente, "@IdCliente", SqlDbType.VarChar);
        //        parametros[2] = new ClsNSQLParametro(UnidadMedida.IdEmpleado, "@IdEmpleado", SqlDbType.VarChar);
        //        parametros[3] = new ClsNSQLParametro(UnidadMedida.TipoUnidadMedida, "@TipoUnidadMedida", SqlDbType.Bit);
        //        parametros[4] = new ClsNSQLParametro(UnidadMedida.FechaUnidadMedida, "@FechaUnidadMedida", SqlDbType.Date);
        //        parametros[5] = new ClsNSQLParametro(UnidadMedida.Total, "@Total", SqlDbType.Decimal);
        //        parametros[6] = new ClsNSQLParametro(UnidadMedida.Estado, "@Estado", SqlDbType.Int);
        //    }
        //    else
        //    {
        //        Procedimiento = "CrearUnidadMedida";
        //        parametros = new ClsNSQLParametro[7];
        //        parametros[0] = new ClsNSQLParametro(UnidadMedida.Id, "@Id", SqlDbType.VarChar);
        //        parametros[1] = new ClsNSQLParametro(UnidadMedida.IdCliente, "@IdCliente", SqlDbType.VarChar);
        //        parametros[2] = new ClsNSQLParametro(UnidadMedida.IdEmpleado, "@IdEmpleado", SqlDbType.VarChar);
        //        parametros[3] = new ClsNSQLParametro(UnidadMedida.TipoUnidadMedida, "@TipoUnidadMedida", SqlDbType.Bit);
        //        parametros[4] = new ClsNSQLParametro(UnidadMedida.FechaUnidadMedida, "@FechaUnidadMedida", SqlDbType.Date);
        //        parametros[5] = new ClsNSQLParametro(UnidadMedida.Total, "@Total", SqlDbType.Decimal);
        //        parametros[6] = new ClsNSQLParametro(UnidadMedida.Estado, "@Estado", SqlDbType.Int);
        //    }
        //    return ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros).Tables[0].Rows[0]["IdUnidadMedida"].ToString();
        //}

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarUnidadMedida").Tables[0];
        }

        public static DataTable Obtener(int Id)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[1];
            parametros[0] = new ClsNSQLParametro(Id,"@Id",SqlDbType.Int);
            return ClsNConexion.EjecutarProcedimiento("ObtenerUnidadMedida",parametros).Tables[0];
        }

        //public static string GenerarId()
        //{
        //    return ClsNConexion.EjecutarProcedimiento("GenerarIdUnidadMedida").Tables[0].Rows[0]["Id"].ToString();
        //}
    }
}

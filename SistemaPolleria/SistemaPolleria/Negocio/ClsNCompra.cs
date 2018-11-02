using SistemaPolleria.Ayuda;
using SistemaPolleria.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Negocio
{
    class ClsNCompra
    {
        public static int Guardar(ClsCompra Compra)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (Compra.Id != 0)
            {
                Procedimiento = "ActualizarCompra";
                parametros = new ClsNSQLParametro[10];
                parametros[0] = new ClsNSQLParametro(Compra.Id, "@Id", SqlDbType.Int);
                parametros[1] = new ClsNSQLParametro(Compra.IdTipoComprobante, "@IdTipoComprobante", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Compra.IdEmpleado, "@IdEmpleado", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(Compra.IdProveedor, "@IdProveedor", SqlDbType.VarChar);
                parametros[4] = new ClsNSQLParametro(Compra.Serie, "@Serie", SqlDbType.VarChar);
                parametros[5] = new ClsNSQLParametro(Compra.Numero, "@Numero", SqlDbType.VarChar);
                parametros[6] = new ClsNSQLParametro(Compra.Fecha, "@Fecha", SqlDbType.Date);
                parametros[7] = new ClsNSQLParametro(Compra.Total, "@Total", SqlDbType.Decimal);
                parametros[8] = new ClsNSQLParametro(Compra.Observacion, "@Observacion", SqlDbType.VarChar);
                parametros[9] = new ClsNSQLParametro(Compra.Estado, "@Estado", SqlDbType.Bit);
            }
            else
            {
                Procedimiento = "CrearCompra";
                parametros = new ClsNSQLParametro[9];
                parametros[0] = new ClsNSQLParametro(Compra.IdTipoComprobante, "@IdTipoComprobante", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Compra.IdEmpleado, "@IdEmpleado", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Compra.IdProveedor, "@IdProveedor", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(Compra.Serie, "@Serie", SqlDbType.VarChar);
                parametros[4] = new ClsNSQLParametro(Compra.Numero, "@Numero", SqlDbType.VarChar);
                parametros[5] = new ClsNSQLParametro(Compra.Fecha, "@Fecha", SqlDbType.Date);
                parametros[6] = new ClsNSQLParametro(Compra.Total, "@Total", SqlDbType.Decimal);
                parametros[7] = new ClsNSQLParametro(Compra.Observacion, "@Observacion", SqlDbType.VarChar);
                parametros[8] = new ClsNSQLParametro(Compra.Estado, "@Estado", SqlDbType.Bit);
            }
            return Convert.ToInt32(ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros).Tables[0].Rows[0]["IdCompra"].ToString());
        }

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarCompra").Tables[0];
        }

    }
}

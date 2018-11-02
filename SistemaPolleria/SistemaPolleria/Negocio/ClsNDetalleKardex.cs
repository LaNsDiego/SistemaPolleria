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
    class ClsNDetalleKardex
    {
        public static bool Guardar(ClsDetalleKardex DetalleKardex)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (DetalleKardex.Id != 0)
            {
                Procedimiento = "ActualizarDetalleKardex";
                parametros = new ClsNSQLParametro[10];
                parametros[0] = new ClsNSQLParametro(DetalleKardex.Id, "@Id", SqlDbType.Int);
                parametros[1] = new ClsNSQLParametro(DetalleKardex.IdKardex, "@IdKardex", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(DetalleKardex.Fecha, "@Fecha", SqlDbType.Date);
                parametros[3] = new ClsNSQLParametro(DetalleKardex.IdTipoOperacion, "@IdTipoOperacion", SqlDbType.VarChar);
                parametros[4] = new ClsNSQLParametro(DetalleKardex.IdTipoComprobante, "@IdTipoComprobante", SqlDbType.VarChar);
                parametros[5] = new ClsNSQLParametro(DetalleKardex.Serie, "@Serie", SqlDbType.VarChar);
                parametros[6] = new ClsNSQLParametro(DetalleKardex.Numero, "@Numero", SqlDbType.VarChar);
                parametros[7] = new ClsNSQLParametro(DetalleKardex.Cantidad, "@Cantidad", SqlDbType.Decimal);
                parametros[8] = new ClsNSQLParametro(DetalleKardex.CostoUnitario, "@CostoUnitario", SqlDbType.Decimal);
                parametros[9] = new ClsNSQLParametro(DetalleKardex.CostoTotal, "@CostoTotal", SqlDbType.Decimal);
            }
            else
            {
                Procedimiento = "CrearDetalleKardex";
                parametros = new ClsNSQLParametro[9];
                parametros[0] = new ClsNSQLParametro(DetalleKardex.IdKardex, "@IdKardex", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(DetalleKardex.Fecha, "@Fecha", SqlDbType.Date);
                parametros[2] = new ClsNSQLParametro(DetalleKardex.IdTipoOperacion, "@IdTipoOperacion", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(DetalleKardex.IdTipoComprobante, "@IdTipoComprobante", SqlDbType.VarChar);
                parametros[4] = new ClsNSQLParametro(DetalleKardex.Serie, "@Serie", SqlDbType.VarChar);
                parametros[5] = new ClsNSQLParametro(DetalleKardex.Numero, "@Numero", SqlDbType.VarChar);
                parametros[6] = new ClsNSQLParametro(DetalleKardex.Cantidad, "@Cantidad", SqlDbType.Decimal);
                parametros[7] = new ClsNSQLParametro(DetalleKardex.CostoUnitario, "@CostoUnitario", SqlDbType.Decimal);
                parametros[8] = new ClsNSQLParametro(DetalleKardex.CostoTotal, "@CostoTotal", SqlDbType.Decimal);
            }
            return ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros) != null;
        }

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarDetalleKardex").Tables[0];
        }
    }
}

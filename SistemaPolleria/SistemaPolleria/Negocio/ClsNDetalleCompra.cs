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
    class ClsNDetalleCompra
    {
        public static bool Guardar(ClsDetalleCompra DetalleCompra)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (DetalleCompra.Id != 0)
            {
                Procedimiento = "ActualizarDetalleCompra";
                parametros = new ClsNSQLParametro[6];
                parametros[0] = new ClsNSQLParametro(DetalleCompra.Id, "@Id", SqlDbType.Int);
                parametros[1] = new ClsNSQLParametro(DetalleCompra.IdCompra, "@IdCompra", SqlDbType.Int);
                parametros[2] = new ClsNSQLParametro(DetalleCompra.IdInsumo, "@IdInsumo", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(DetalleCompra.CostoUnitario, "@CostoUnitario", SqlDbType.Decimal);
                parametros[4] = new ClsNSQLParametro(DetalleCompra.Cantidad, "@Cantidad", SqlDbType.Decimal);
                parametros[5] = new ClsNSQLParametro(DetalleCompra.Subtotal, "@Subtotal", SqlDbType.Decimal);
            }
            else
            {
                Procedimiento = "CrearDetalleCompra";
                parametros = new ClsNSQLParametro[5];
                parametros[0] = new ClsNSQLParametro(DetalleCompra.IdCompra, "@IdCompra", SqlDbType.Int);
                parametros[1] = new ClsNSQLParametro(DetalleCompra.IdInsumo, "@IdInsumo", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(DetalleCompra.CostoUnitario, "@CostoUnitario", SqlDbType.Decimal);
                parametros[3] = new ClsNSQLParametro(DetalleCompra.Cantidad, "@Cantidad", SqlDbType.Decimal);
                parametros[4] = new ClsNSQLParametro(DetalleCompra.Subtotal, "@Subtotal", SqlDbType.Decimal);
            }
            return ClsNConexion.EjecutarProcedimiento(Procedimiento,parametros) != null;
        }
    }
}

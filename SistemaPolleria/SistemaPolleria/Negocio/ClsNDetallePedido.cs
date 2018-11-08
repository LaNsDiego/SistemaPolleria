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
    class ClsNDetallePedido
    {
        public static bool Guardar(ClsDetallePedido DetallePedido)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (DetallePedido.Id != 0)
            {
                Procedimiento = "ActualizarDetallePedido";
                parametros = new ClsNSQLParametro[6];
                parametros[0] = new ClsNSQLParametro(DetallePedido.Id, "@Id", SqlDbType.Int);
                parametros[1] = new ClsNSQLParametro(DetallePedido.IdPedido, "@IdPedido", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(DetallePedido.IdProducto, "@IdProducto", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(DetallePedido.PrecioUnitario, "@PrecioUnitario", SqlDbType.Decimal);
                parametros[4] = new ClsNSQLParametro(DetallePedido.Cantidad, "@Cantidad", SqlDbType.Int);
                parametros[5] = new ClsNSQLParametro(DetallePedido.Subtotal, "@Subtotal", SqlDbType.Decimal);
            }
            else
            {
                Procedimiento = "CrearDetallePedido";
                parametros = new ClsNSQLParametro[5];
                parametros[0] = new ClsNSQLParametro(DetallePedido.IdPedido, "@IdPedido", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(DetallePedido.IdProducto, "@IdProducto", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(DetallePedido.PrecioUnitario, "@PrecioUnitario", SqlDbType.Decimal);
                parametros[3] = new ClsNSQLParametro(DetallePedido.Cantidad, "@Cantidad", SqlDbType.Int);
                parametros[4] = new ClsNSQLParametro(DetallePedido.Subtotal, "@Subtotal", SqlDbType.Decimal);
            }
            return ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros) != null;
        }

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarDetallePedido").Tables[0];
        }

        public static DataTable ObtenerDetallesPedidoPorPedido(string PedidoId)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[1];
            parametros[0] = new ClsNSQLParametro(PedidoId, "@IdPedido", SqlDbType.VarChar);
            return ClsNConexion.EjecutarProcedimiento("ListarDetallePedido",parametros).Tables[0];
        }

        
    }
}

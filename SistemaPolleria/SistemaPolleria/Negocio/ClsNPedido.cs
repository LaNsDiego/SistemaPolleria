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
    class ClsNPedido
    {
        public static string Guardar(ClsPedido Pedido)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (Pedido.Id != string.Empty)
            {
                Procedimiento = "ActualizarPedido";
                parametros = new ClsNSQLParametro[7];
                parametros[0] = new ClsNSQLParametro(Pedido.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Pedido.IdCliente, "@IdCliente", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Pedido.IdEmpleado, "@IdEmpleado", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(Pedido.TipoPedido, "@TipoPedido", SqlDbType.Bit);
                parametros[4] = new ClsNSQLParametro(Pedido.FechaPedido, "@FechaPedido", SqlDbType.Date);
                parametros[5] = new ClsNSQLParametro(Pedido.Total, "@Total", SqlDbType.Decimal);
                parametros[6] = new ClsNSQLParametro(Pedido.Estado, "@Estado", SqlDbType.Int);
            }
            else
            {
                Procedimiento = "CrearPedido";
                parametros = new ClsNSQLParametro[7];
                parametros[0] = new ClsNSQLParametro(Pedido.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Pedido.IdCliente, "@IdCliente", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Pedido.IdEmpleado, "@IdEmpleado", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(Pedido.TipoPedido, "@TipoPedido", SqlDbType.Bit);
                parametros[4] = new ClsNSQLParametro(Pedido.FechaPedido, "@FechaPedido", SqlDbType.Date);
                parametros[5] = new ClsNSQLParametro(Pedido.Total, "@Total", SqlDbType.Decimal);
                parametros[6] = new ClsNSQLParametro(Pedido.Estado, "@Estado", SqlDbType.Int);
            }
            return ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros).Tables[0].Rows[0]["IdPedido"].ToString();
        }

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarPedido").Tables[0];
        }

        public static string GenerarId()
        {
            return ClsNConexion.EjecutarProcedimiento("GenerarIdPedido").Tables[0].Rows[0]["Id"].ToString();
        }

        //public static bool AnularBoleta(int Id)
        //{
        //    ClsNSQLParametro[] parametros = new ClsNSQLParametro[2];
        //    parametros[0] = new ClsNSQLParametro(Id,"@id" , SqlDbType.Int);
        //    parametros[1] = new ClsNSQLParametro(0, "@estado", SqlDbType.Bit);
        //    return ClsNConexion.EjecutarProcedimiento("SP_ANULAR_PEDIDO", parametros) != null;
        //}


        //public static DataTable BuscarEntreDosFechas(DateTime FechaInicio , DateTime FechaFinal)
        //{
        //    ClsNSQLParametro[] parametros = new ClsNSQLParametro[2];
        //    parametros[0] = new ClsNSQLParametro(FechaInicio, "@fechaInicio", SqlDbType.Date);
        //    parametros[1] = new ClsNSQLParametro(FechaFinal, "@fechaFinal", SqlDbType.Date);
        //    return ClsNConexion.EjecutarProcedimiento("SP_REPORTE_VENTAS_ENTRE_DOS_FECHAS", parametros).Tables[0];
        //}
    }
}

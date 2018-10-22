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
        public static int Guardar(ClsPedido Pedido)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (Pedido.Id != 0)
            {
                Procedimiento = "SP_EDITAR_PEDIDO";
                parametros = new ClsNSQLParametro[5];
                parametros[0] = new ClsNSQLParametro(Pedido.Id, "@id", SqlDbType.Int);
                parametros[1] = new ClsNSQLParametro(Pedido.MesaId, "@MesaId", SqlDbType.Int);
                parametros[2] = new ClsNSQLParametro(Pedido.EmpleadoId, "@EmpleadoId", SqlDbType.Int);
                parametros[3] = new ClsNSQLParametro(Pedido.Fecha, "@Fecha", SqlDbType.DateTime);
                parametros[4] = new ClsNSQLParametro(Pedido.Total, "@Total", SqlDbType.Decimal);
            }
            else
            {
                Procedimiento = "SP_CREAR_PEDIDO";
                parametros = new ClsNSQLParametro[4];
                parametros[0] = new ClsNSQLParametro(Pedido.MesaId, "@MesaId", SqlDbType.Int);
                parametros[1] = new ClsNSQLParametro(Pedido.EmpleadoId, "@EmpleadoId", SqlDbType.Int);
                parametros[2] = new ClsNSQLParametro(Pedido.Fecha, "@Fecha", SqlDbType.DateTime);
                parametros[3] = new ClsNSQLParametro(Pedido.Total, "@Total", SqlDbType.Decimal);
            }
            return Convert.ToInt32(ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros).Tables[0].Rows[0]["IDPEDIDO"].ToString());
        }

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("SP_LISTAR_PEDIDOS").Tables[0];
        }

        public static string NumeroBoleta()
        {
            return ClsNConexion.EjecutarProcedimiento("SP_GENERAR_NUMERO_PEDIDO").Tables[0].Rows[0]["NUMERO"].ToString();
        }

        public static bool AnularBoleta(int Id)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[2];
            parametros[0] = new ClsNSQLParametro(Id,"@id" , SqlDbType.Int);
            parametros[1] = new ClsNSQLParametro(0, "@estado", SqlDbType.Bit);
            return ClsNConexion.EjecutarProcedimiento("SP_ANULAR_PEDIDO", parametros) != null;
        }


        //public static DataTable BuscarEntreDosFechas(DateTime FechaInicio , DateTime FechaFinal)
        //{
        //    ClsNSQLParametro[] parametros = new ClsNSQLParametro[2];
        //    parametros[0] = new ClsNSQLParametro(FechaInicio, "@fechaInicio", SqlDbType.Date);
        //    parametros[1] = new ClsNSQLParametro(FechaFinal, "@fechaFinal", SqlDbType.Date);
        //    return ClsNConexion.EjecutarProcedimiento("SP_REPORTE_VENTAS_ENTRE_DOS_FECHAS", parametros).Tables[0];
        //}
    }
}

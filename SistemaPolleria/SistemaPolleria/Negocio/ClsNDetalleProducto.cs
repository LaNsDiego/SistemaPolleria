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
    class ClsNDetalleProducto
    {
        public static bool Guardar(ClsDetalleProducto DetalleProducto)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (DetalleProducto.Id != 0)
            {
                Procedimiento = "ActualizarDetalleProducto";
                parametros = new ClsNSQLParametro[4];
                parametros[0] = new ClsNSQLParametro(DetalleProducto.Id, "@Id", SqlDbType.Int);
                parametros[1] = new ClsNSQLParametro(DetalleProducto.IdInsumo, "@IdInsumo", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(DetalleProducto.IdProducto, "@IdProducto", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(DetalleProducto.Cantidad, "@Cantidad", SqlDbType.Decimal);
            }
            else
            {
                Procedimiento = "CrearDetalleProducto";
                parametros = new ClsNSQLParametro[3];
                parametros[0] = new ClsNSQLParametro(DetalleProducto.IdInsumo, "@IdInsumo", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(DetalleProducto.IdProducto, "@IdProducto", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(DetalleProducto.Cantidad, "@Cantidad", SqlDbType.Decimal);
            }
            return ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros) != null;
        }

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarDetalleProductos").Tables[0];
        }

        //public static DataTable BuscarPorDocumento(string Id)
        //{
        //    ClsNSQLParametro[] parametros = new ClsNSQLParametro[1];
        //    parametros[0] = new ClsNSQLParametro(Id, "@Documento", SqlDbType.VarChar);
        //    return ClsNConexion.EjecutarProcedimiento("BuscarDetalleProducto", parametros).Tables[0];
        //}

        public static DataTable ObtenerPorProducto(string ProductoId)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[1];
            parametros[0] = new ClsNSQLParametro(ProductoId, "@IdProducto", SqlDbType.VarChar);       
            return ClsNConexion.EjecutarProcedimiento("ObtenerDetallesProducto", parametros).Tables[0];
        }
    }
}

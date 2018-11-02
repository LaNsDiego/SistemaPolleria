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
    class ClsNProveedor
    {
        //public static bool Guardar(ClsProveedor Proveedor, bool EsNuevo)
        //{
        //    string Procedimiento = string.Empty;
        //    ClsNSQLParametro[] parametros;

        //    if (!EsNuevo)
        //    {
        //        Procedimiento = "ActualizarProveedor";
        //        parametros = new ClsNSQLParametro[6];
        //        parametros[0] = new ClsNSQLParametro(Proveedor.Id, "@Id", SqlDbType.VarChar);
        //        parametros[1] = new ClsNSQLParametro(Proveedor.Nombre, "@Nombre", SqlDbType.VarChar);
        //        parametros[2] = new ClsNSQLParametro(Proveedor.PrecioUnitario, "@PrecioUnitario", SqlDbType.Decimal);
        //        parametros[3] = new ClsNSQLParametro(Proveedor.ValorTotal, "@ValorTotal", SqlDbType.Decimal);
        //        parametros[4] = new ClsNSQLParametro(Proveedor.Cantidad, "@Cantidad", SqlDbType.Decimal);
        //        parametros[5] = new ClsNSQLParametro(Proveedor.IdTipoProveedor, "@IdTipoProveedor", SqlDbType.Int);
        //    }
        //    else
        //    {
        //        Procedimiento = "CrearProveedor";
        //        parametros = new ClsNSQLParametro[6];
        //        parametros[0] = new ClsNSQLParametro(Proveedor.Id, "@Id", SqlDbType.VarChar);
        //        parametros[1] = new ClsNSQLParametro(Proveedor.Nombre, "@Nombre", SqlDbType.VarChar);
        //        parametros[2] = new ClsNSQLParametro(Proveedor.PrecioUnitario, "@PrecioUnitario", SqlDbType.Decimal);
        //        parametros[3] = new ClsNSQLParametro(Proveedor.ValorTotal, "@ValorTotal", SqlDbType.Decimal);
        //        parametros[4] = new ClsNSQLParametro(Proveedor.Cantidad, "@Cantidad", SqlDbType.Decimal);
        //        parametros[5] = new ClsNSQLParametro(Proveedor.IdTipoProveedor, "@IdTipoProveedor", SqlDbType.Int);
        //    }
        //    return ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros) != null;
        //}

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarProveedor").Tables[0];
        }

        public static DataTable Obtener(string Id)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[1];
            parametros[0] = new ClsNSQLParametro(Id, "@Id", SqlDbType.VarChar);
            return ClsNConexion.EjecutarProcedimiento("ObtenerProveedor", parametros).Tables[0];
        }
    }
}

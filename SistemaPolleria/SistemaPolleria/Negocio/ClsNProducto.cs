using SistemaPolleria.Ayuda;
using SistemaPolleria.Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Negocio
{
    class ClsNProducto
    {
        public static bool Guardar(ClsProducto Producto,bool EsNuevo)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (!EsNuevo)
            {
                Procedimiento = "ActualizarProducto";
                parametros = new ClsNSQLParametro[6];
                parametros[0] = new ClsNSQLParametro(Producto.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Producto.Nombre, "@Nombre", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Producto.PrecioUnitario, "@PrecioUnitario", SqlDbType.Decimal);
                parametros[3] = new ClsNSQLParametro(Producto.ValorTotal, "@ValorTotal", SqlDbType.Decimal);
                parametros[4] = new ClsNSQLParametro(Producto.Cantidad, "@Cantidad", SqlDbType.Decimal);
                parametros[5] = new ClsNSQLParametro(Producto.IdTipoProducto, "@IdTipoProducto", SqlDbType.Int);
            }
            else
            {
                Procedimiento = "CrearProducto";
                parametros = new ClsNSQLParametro[6];
                parametros[0] = new ClsNSQLParametro(Producto.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Producto.Nombre, "@Nombre", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Producto.PrecioUnitario, "@PrecioUnitario", SqlDbType.Decimal);
                parametros[3] = new ClsNSQLParametro(Producto.ValorTotal, "@ValorTotal", SqlDbType.Decimal);
                parametros[4] = new ClsNSQLParametro(Producto.Cantidad, "@Cantidad", SqlDbType.Decimal);
                parametros[5] = new ClsNSQLParametro(Producto.IdTipoProducto, "@IdTipoProducto", SqlDbType.Int);
            }
            return ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros) != null;
        }

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarProducto").Tables[0];
        }

        public static string GenerarId()
        {
            return ClsNConexion.EjecutarProcedimiento("GenerarIdProducto").Tables[0].Rows[0]["Id"].ToString();
        }

        public static DataTable Obtener(string Id)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[1];
            parametros[0] = new ClsNSQLParametro(Id, "@Id", SqlDbType.VarChar);
            return ClsNConexion.EjecutarProcedimiento("ObtenerProducto", parametros).Tables[0];
        }

        

    }
}

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
    class ClsNInsumo
    {
        public static bool Guardar(ClsInsumo Insumo , bool EsNuevo)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (!EsNuevo)
            {
                Procedimiento = "ActualizarInsumo";
                parametros = new ClsNSQLParametro[6];
                parametros[0] = new ClsNSQLParametro(Insumo.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Insumo.Nombre, "@Nombre", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Insumo.Cantidad, "@Cantidad", SqlDbType.Decimal);
                parametros[3] = new ClsNSQLParametro(Insumo.CostoUnitario, "@CostoUnitario", SqlDbType.Decimal);
                parametros[4] = new ClsNSQLParametro(Insumo.CostoTotal, "@CostoTotal", SqlDbType.Decimal);
                parametros[5] = new ClsNSQLParametro(Insumo.IdUnidadMedida, "@IdUnidadMedida", SqlDbType.Int);
            }
            else
            {
                Procedimiento = "CrearInsumo";
                parametros = new ClsNSQLParametro[6];
                parametros[0] = new ClsNSQLParametro(Insumo.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Insumo.Nombre, "@Nombre", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Insumo.Cantidad, "@Cantidad", SqlDbType.Decimal);
                parametros[3] = new ClsNSQLParametro(Insumo.CostoUnitario, "@CostoUnitario", SqlDbType.Decimal);
                parametros[4] = new ClsNSQLParametro(Insumo.CostoTotal, "@CostoTotal", SqlDbType.Decimal);
                parametros[5] = new ClsNSQLParametro(Insumo.IdUnidadMedida, "@IdUnidadMedida", SqlDbType.Int);
            }
            return ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros) != null;
        }

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarInsumo").Tables[0];
        }

        public static bool Entrada(ClsDetalleCompra DetalleCompra)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[3];
            parametros[0] = new ClsNSQLParametro(DetalleCompra.IdInsumo, "@IdInsumo", SqlDbType.VarChar);
            parametros[1] = new ClsNSQLParametro(DetalleCompra.Cantidad, "@CantidadCompra", SqlDbType.Decimal);
            parametros[2] = new ClsNSQLParametro(DetalleCompra.Subtotal, "@CostoTotalCompra", SqlDbType.Decimal);
            return ClsNConexion.EjecutarProcedimiento("EntradaInsumo", parametros) != null;
        }

        public static bool SalidaBoleta(ClsDetalleProducto DetalleProducto,string serie , string numero)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[5];
            parametros[0] = new ClsNSQLParametro(DetalleProducto.IdInsumo, "@IdInsumo", SqlDbType.VarChar);
            parametros[1] = new ClsNSQLParametro(DetalleProducto.Cantidad, "@CantidadVenta", SqlDbType.Decimal);
            parametros[2] = new ClsNSQLParametro("03", "@IdTipoComprobante", SqlDbType.VarChar);
            parametros[3] = new ClsNSQLParametro(serie, "@Serie", SqlDbType.VarChar);
            parametros[4] = new ClsNSQLParametro(numero, "@Numero", SqlDbType.VarChar);




            return Convert.ToInt32(ClsNConexion.EjecutarProcedimiento("SalidaInsumo", parametros).Tables[0].Rows[0]["ESTADO"]) == 1 ? true : false;


        }

        public static void CrearBoleta(ClsBoleta Boleta)
        {
            ClsNSQLParametro[] parametrosBoleta = new ClsNSQLParametro[4];
            parametrosBoleta[0] = new ClsNSQLParametro(Boleta.IdPedido, "@IdPedido", SqlDbType.VarChar);
            parametrosBoleta[1] = new ClsNSQLParametro(Boleta.Serie, "@Serie", SqlDbType.VarChar);
            parametrosBoleta[2] = new ClsNSQLParametro(Boleta.Numero, "@Numero", SqlDbType.VarChar);
            parametrosBoleta[3] = new ClsNSQLParametro(Boleta.Fecha, "@Fecha", SqlDbType.Date);
            ClsNConexion.EjecutarProcedimiento("CrearBoleta", parametrosBoleta);
        }

        public static void CrearFactura(ClsFactura Factura)
        {
            ClsNSQLParametro[] parametrosFactura = new ClsNSQLParametro[5];
            parametrosFactura[0] = new ClsNSQLParametro(Factura.IdPedido, "@IdPedido", SqlDbType.VarChar);
            parametrosFactura[1] = new ClsNSQLParametro(Factura.Serie, "@Serie", SqlDbType.VarChar);
            parametrosFactura[2] = new ClsNSQLParametro(Factura.Numero, "@Numero", SqlDbType.VarChar);
            parametrosFactura[3] = new ClsNSQLParametro(Factura.Fecha, "@Fecha", SqlDbType.Date);
            parametrosFactura[4] = new ClsNSQLParametro(Factura.IdGuiaRemision, "@IdGuiaRemision", SqlDbType.VarChar);
            ClsNConexion.EjecutarProcedimiento("CrearFactura", parametrosFactura);
        }

        public static bool SalidaFactura(ClsDetalleProducto DetalleProducto, string serie, string numero)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[5];
            parametros[0] = new ClsNSQLParametro(DetalleProducto.IdInsumo, "@IdInsumo", SqlDbType.VarChar);
            parametros[1] = new ClsNSQLParametro(DetalleProducto.Cantidad, "@CantidadVenta", SqlDbType.Decimal);
            parametros[2] = new ClsNSQLParametro("01", "@IdTipoComprobante", SqlDbType.VarChar);
            parametros[3] = new ClsNSQLParametro(serie, "@Serie", SqlDbType.VarChar);
            parametros[4] = new ClsNSQLParametro(numero, "@Numero", SqlDbType.VarChar);

            return Convert.ToInt32(ClsNConexion.EjecutarProcedimiento("SalidaInsumo", parametros).Tables[0].Rows[0]["ESTADO"]) == 1 ? true : false;
        }




        public static DataTable Obtener(string Id)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[1];
            parametros[0] = new ClsNSQLParametro(Id, "@Id", SqlDbType.VarChar);
            return ClsNConexion.EjecutarProcedimiento("ObtenerInsumo",parametros).Tables[0];
        }

        public static string GenerarId()
        {
            return ClsNConexion.EjecutarProcedimiento("GenerarIdInsumo").Tables[0].Rows[0]["Id"].ToString();
        }
    }
}

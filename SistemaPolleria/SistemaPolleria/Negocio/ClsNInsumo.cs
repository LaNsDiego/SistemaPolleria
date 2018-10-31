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
                Console.WriteLine("ACTUALIZADO");
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
                Console.WriteLine("CREADO");
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

        public static string GenerarId()
        {
            return ClsNConexion.EjecutarProcedimiento("GenerarIdInsumo").Tables[0].Rows[0]["Id"].ToString();
        }
    }
}

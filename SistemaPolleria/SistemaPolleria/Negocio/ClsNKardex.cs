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
    class ClsNKardex
    {
        public static bool Guardar(ClsKardex Kardex, bool EsNuevo)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (!EsNuevo)
            {
                Procedimiento = "ActualizarKardex";
                parametros = new ClsNSQLParametro[6];
                parametros[0] = new ClsNSQLParametro(Kardex.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Kardex.Periodo, "@Periodo", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Kardex.Ruc, "@Ruc", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(Kardex.RazonSocial, "@RazonSocial", SqlDbType.VarChar);
                parametros[4] = new ClsNSQLParametro(Kardex.IdEstablecimiento, "@IdEstablecimiento", SqlDbType.Int);
                parametros[5] = new ClsNSQLParametro(Kardex.IdInsumo, "@IdInsumo", SqlDbType.VarChar);
            }
            else
            {
                Procedimiento = "CrearKardex";
                parametros = new ClsNSQLParametro[6];
                parametros[0] = new ClsNSQLParametro(Kardex.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Kardex.Periodo, "@Periodo", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Kardex.Ruc, "@Ruc", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(Kardex.RazonSocial, "@RazonSocial", SqlDbType.VarChar);
                parametros[4] = new ClsNSQLParametro(Kardex.IdEstablecimiento, "@IdEstablecimiento", SqlDbType.Int);
                parametros[5] = new ClsNSQLParametro(Kardex.IdInsumo, "@IdInsumo", SqlDbType.VarChar);
            }
            return ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros) != null;
        }

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarKardex").Tables[0];
        }

        public static string GenerarId()
        {
            return ClsNConexion.EjecutarProcedimiento("GenerarIdKardex").Tables[0].Rows[0]["Id"].ToString();
        }

        public static string ObtenerKardexDeUnInsumo(string IdInsumo)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[1];
            parametros[0] = new ClsNSQLParametro(IdInsumo, "@IdInsumo", SqlDbType.VarChar);
            return ClsNConexion.EjecutarProcedimiento("ObtenerIdKardexInsumo",parametros).Tables[0].Rows[0]["Id"].ToString();
        }

        
    }
}

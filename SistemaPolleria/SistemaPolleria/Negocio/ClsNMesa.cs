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
    class ClsNMesa
    {
        public static int Guardar(ClsMesa Mesa , bool EsNuevo)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (!EsNuevo)
            {
                Procedimiento = "ActualizarMesa";
                parametros = new ClsNSQLParametro[3];
                parametros[0] = new ClsNSQLParametro(Mesa.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Mesa.Sillas, "@Sillas", SqlDbType.Int);
                parametros[2] = new ClsNSQLParametro(Mesa.Piso, "@Piso", SqlDbType.Int);
            }
            else
            {
                Procedimiento = "CrearMesa";
                parametros = new ClsNSQLParametro[3];
                parametros[0] = new ClsNSQLParametro(Mesa.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Mesa.Sillas, "@Sillas", SqlDbType.Int);
                parametros[2] = new ClsNSQLParametro(Mesa.Piso, "@Piso", SqlDbType.Int);
            }
            return Convert.ToInt32(ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros).Tables[0].Rows[0]["IdMesa"].ToString());
        }

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarMesa").Tables[0];
        }
    }
}

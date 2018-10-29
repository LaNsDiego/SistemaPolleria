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
    class ClsNUsuario
    {
        public static bool Guardar(ClsUsuario Usuario)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (Usuario.Id != 0)
            {
                Procedimiento = "EditarUsuario";
                parametros = new ClsNSQLParametro[4];
                parametros[0] = new ClsNSQLParametro(Usuario.IdEmpleado, "@IdEmpleado", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Usuario.Clave, "@Clave", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Usuario.FechaCreacion, "@FechaCreacion", SqlDbType.Date);
                parametros[3] = new ClsNSQLParametro(Usuario.Estado, "@Estado", SqlDbType.Bit);
            }
            else
            {
                Procedimiento = "CrearUsuario";
                parametros = new ClsNSQLParametro[5];
                parametros[0] = new ClsNSQLParametro(Usuario.Id, "@Id", SqlDbType.Int);
                parametros[1] = new ClsNSQLParametro(Usuario.IdEmpleado, "@IdEmpleado", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Usuario.Clave, "@Clave", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(Usuario.FechaCreacion, "@FechaCreacion", SqlDbType.Date);
                parametros[4] = new ClsNSQLParametro(Usuario.Estado, "@Estado", SqlDbType.Bit);
            }
            return ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros) != null;
        }

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarUsuarios").Tables[0];
        }

        public static DataTable IniciarSesion(ClsUsuario Usuario)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[2];
            parametros[0] = new ClsNSQLParametro(Usuario.IdEmpleado, "@IdEmpleado", SqlDbType.VarChar);
            parametros[1] = new ClsNSQLParametro(Usuario.Clave, "@Clave", SqlDbType.VarChar);
            return ClsNConexion.EjecutarProcedimiento("IniciarSesion", parametros).Tables[0];

        }

    }
}

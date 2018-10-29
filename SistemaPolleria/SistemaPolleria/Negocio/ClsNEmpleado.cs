using SistemaPolleria.Ayuda;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Negocio
{
    class ClsNEmpleado
    {
        public static bool Guardar(ClsEmpleado Empleado)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (Empleado.Id != string.Empty)
            {
                Procedimiento = "EditarEmpleado";
                parametros = new ClsNSQLParametro[4];
                parametros[0] = new ClsNSQLParametro(Empleado.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Empleado.IdCargo, "@IdCargo", SqlDbType.Int);
                parametros[2] = new ClsNSQLParametro(Empleado.Dni, "@Dni", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(Empleado.Nombre, "@Nombre", SqlDbType.VarChar);
                parametros[4] = new ClsNSQLParametro(Empleado.Apellidos, "@Apellidos", SqlDbType.VarChar);
            }
            else
            {
                Procedimiento = "CrearEmpleado";
                parametros = new ClsNSQLParametro[4];
                parametros[0] = new ClsNSQLParametro(Empleado.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Empleado.IdCargo, "@IdCargo", SqlDbType.Int);
                parametros[2] = new ClsNSQLParametro(Empleado.Dni, "@Dni", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(Empleado.Nombre, "@Nombre", SqlDbType.VarChar);
                parametros[4] = new ClsNSQLParametro(Empleado.Apellidos, "@Apellidos", SqlDbType.VarChar);
            }
            return ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros) != null;
        }

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarEmpleados").Tables[0];
        }

        public static DataTable Obtener(string Id)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[1];
            parametros[0] = new ClsNSQLParametro(Id, "@Id", SqlDbType.VarChar);
            return ClsNConexion.EjecutarProcedimiento("ObtenerEmpleado", parametros).Tables[0];
        }
    }
}

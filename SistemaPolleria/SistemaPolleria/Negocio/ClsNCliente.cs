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
    class ClsNCliente
    {
        public static bool Guardar(ClsCliente Cliente)
        {
            string Procedimiento = string.Empty;
            ClsNSQLParametro[] parametros;

            if (Cliente.Id != string.Empty)
            {
                Procedimiento = "ActualizarCliente";
                parametros = new ClsNSQLParametro[4];
                parametros[0] = new ClsNSQLParametro(Cliente.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Cliente.RazonSocial, "@RazonSocial", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Cliente.Documento, "@Documento", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(Cliente.Telefono, "@Telefono", SqlDbType.VarChar);
                parametros[4] = new ClsNSQLParametro(Cliente.IdTipoCliente, "@IdTipoCliente", SqlDbType.VarChar);
            }
            else
            {
                Procedimiento = "CrearCliente";
                parametros = new ClsNSQLParametro[4];
                parametros[0] = new ClsNSQLParametro(Cliente.Id, "@Id", SqlDbType.VarChar);
                parametros[1] = new ClsNSQLParametro(Cliente.RazonSocial, "@RazonSocial", SqlDbType.VarChar);
                parametros[2] = new ClsNSQLParametro(Cliente.Documento, "@Documento", SqlDbType.VarChar);
                parametros[3] = new ClsNSQLParametro(Cliente.Telefono, "@Telefono", SqlDbType.VarChar);
                parametros[4] = new ClsNSQLParametro(Cliente.IdTipoCliente, "@IdTipoCliente", SqlDbType.VarChar);
            }
            return ClsNConexion.EjecutarProcedimiento(Procedimiento, parametros) != null;
        }

        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarClientes").Tables[0];
        }

        public static DataTable BuscarPorDocumento(string Id)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[1];
            parametros[0] = new ClsNSQLParametro(Id, "@Documento", SqlDbType.VarChar);
            return ClsNConexion.EjecutarProcedimiento("BuscarClientePorDocumento", parametros).Tables[0];
        }
    }
}

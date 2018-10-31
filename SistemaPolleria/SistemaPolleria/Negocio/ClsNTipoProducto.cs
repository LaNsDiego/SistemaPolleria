using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Negocio
{
    class ClsNTipoProducto
    {
        public static DataTable Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("ListarTipoProducto").Tables[0];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsCompra
    {
        public int Id { get; private set; }
        public int ProveedorId { get; private set; }
        public int EmpleadoId { get; private set; }
        public DateTime Fecha { get; private set; }
        public int Total { get; private set; }
    }
}

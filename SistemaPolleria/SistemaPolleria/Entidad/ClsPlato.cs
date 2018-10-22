using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    public class ClsPlato
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public int Cantidad { get; private set; }
        public int PrecioUnitario { get; private set; }

    }
}

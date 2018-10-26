using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsKardex
    {
        public int Id { get; private set; }
        public string NombreCompleto { get; private set; }
        public int ProductoId { get; private set; }
        public int TipoOperacionId { get; private set; }
        public int Cantidad { get; private set; }
        public double CostoUnitario { get; private set; }
        public double CostoTotal { get; private set; }
    }
}

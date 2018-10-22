using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsDetalleCompra
    {
        public int Id { get; private set; }
        public int CompraId { get; private set; }
        public int IngredienteId { get; private set; }
        public double PrecioUnitario { get; private set; }
        public int Cantidad { get; private set; }
        public int Subtotal { get; private set; }
    }
}

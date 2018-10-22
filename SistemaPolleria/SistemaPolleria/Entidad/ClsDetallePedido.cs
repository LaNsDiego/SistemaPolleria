using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    public class ClsDetallePedido
    {
        public int Id { get; private set; }
        public int PedidoId { get; private set; }
        public int PlatoId { get; private set; }
        public double PrecioUnitario { get; private set; }
        public int CantidadCompra { get; private set; }
        public int Subtotal { get; private set; }
    }
}

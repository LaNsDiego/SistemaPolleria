using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsDetallePlato
    {
        public int Id { get; private set; }
        public int PlatoId { get; private set; }
        public int IngredienteId { get; private set; }
        public int Cantidad { get; private set; }
    }
}

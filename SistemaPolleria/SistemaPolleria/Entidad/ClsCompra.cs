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
        public DateTime FechaRegistro { get; private set; }
        public int FechaEmision;
        public int TipoComprobante;
        public int Serie;
        public int Numero;
        public int Estado;
        public int Observacion;
        public int Total { get; private set; }
    }
}

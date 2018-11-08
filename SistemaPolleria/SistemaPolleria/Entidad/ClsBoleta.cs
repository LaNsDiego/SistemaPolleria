using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsBoleta
    {
        public ClsBoleta(string serie, string numero, DateTime fecha, string idPedido)
        {
            Serie = serie;
            Numero = numero;
            Fecha = fecha;
            IdPedido = idPedido;
        }
        public int Id { get; private set; }
        public string Serie { get; private set; }
        public string Numero { get; private set; }
        public DateTime Fecha { get; private set; }
        public string IdPedido { get; private set; }
    }
}

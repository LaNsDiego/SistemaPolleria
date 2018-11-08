using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    public class ClsCliente
    {
        public string Id { get; private set; }
        public string RazonSocial { get; private set; }
        public string Documento { get; private set; }
        public string Telefono { get; private set; }
        public string IdTipoCliente { get; private set; }

        public ClsCliente(string id, string razonSocial, string documento, string telefono, string idTipoCliente)
        {
            Id = id;
            RazonSocial = razonSocial;
            Documento = documento;
            Telefono = telefono;
            IdTipoCliente = idTipoCliente;
        }
    }
}

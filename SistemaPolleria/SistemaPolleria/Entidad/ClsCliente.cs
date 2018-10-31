using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsCliente
    {
        //Id VARCHAR(8) PRIMARY KEY,
        //RazonSocial VARCHAR(100) NULL,
        //Documento VARCHAR(11) NULL,
        //Telefono VARCHAR(50) NULL,
        //IdTipoCliente VARCHAR(4) NOT NULL
        public string Id { get; private set; }
        public string RazonSocial { get; private set; }
        public string Documento { get; private set; }
        public string Telefono { get; private set; }
        public string IdTipoCliente { get; private set; }
    }
}

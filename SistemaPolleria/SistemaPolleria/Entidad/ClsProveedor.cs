using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsProveedor
    {
        public int Id { get; private set; }
        public string Ruc { get; private set; }
        public string NombreEmpresa { get; private set; }
        public int NombreEncargado { get; private set; }
        public int Telefono { get; private set; }
    }
}

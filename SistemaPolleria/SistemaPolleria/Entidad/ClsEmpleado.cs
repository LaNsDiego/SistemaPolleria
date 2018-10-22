using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaPolleria
{
    public class ClsEmpleado
    {
        public int Id { get; private set; }
        public int Dni { get; private set; }
        public string Nombres { get; private set; }
        public string Apellidos { get; private set; }
        public int CargoId { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
    }
}
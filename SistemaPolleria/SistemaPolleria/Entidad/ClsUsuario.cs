using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsUsuario
    {
        // @Id INT = NULL
        // ,@IdEmpleado VARCHAR(6) = NULL
        // ,@Clave VARCHAR(50) = NULL
        // ,@FechaCreacion DATE = NULL
        // , @Estado BIT = NULL
        public int Id { get; private set; }
        public string IdEmpleado { get; private set; }
        public string Clave { get; private set; }
        public DateTime FechaCreacion { get; private set; }
        public bool Estado { get; private set; }


        public ClsUsuario(string IdEmpleado, string Clave)
        {
            this.IdEmpleado = IdEmpleado;
            this.Clave = Clave;
        }
    }
}

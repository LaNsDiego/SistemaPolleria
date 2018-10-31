using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsPedido //Es el Tabla Union entre Mesa y Plato
    {
        //Id VARCHAR(8) PRIMARY KEY,
        //FechaPedido DATE NOT NULL,
        //IdCliente VARCHAR(8) NULL,
        //Total DECIMAL(8,2) NOT NULL,
        //TipoPedido BIT NOT NULL,
        //Estado INT NOT NULL
        public string Id { get; private set; }
        public string IdCliente { get; private set; }
        public string IdEmpleado { get; private set; }
        public bool TipoPedido { get; private set; }
        public DateTime FechaPedido { get; private set; }
        public double Total { get; private set; }
        public int Estado { get; private set; }

        public ClsPedido(string id, string idCliente, string idEmpleado, bool tipoPedido,
                        DateTime fechaPedido, double total, int estado)
        {
            Id = id;
            IdCliente = idCliente;
            IdEmpleado = idEmpleado;
            TipoPedido = tipoPedido;
            FechaPedido = fechaPedido;
            Total = total;
            Estado = estado;
        }
    }
}

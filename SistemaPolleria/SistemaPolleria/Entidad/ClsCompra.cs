using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsCompra
    {
        //Id INT PRIMARY KEY IDENTITY,
        //IdTipoComprobante VARCHAR(2) NOT NULL,
        //IdEmpleado VARCHAR(6) NOT NULL,
        //IdProveedor VARCHAR(4) NULL,
        //Serie VARCHAR(4) NOT NULL,
        //Numero VARCHAR(4) NOT NULL,
        //Fecha DATE NOT NULL,
        //Total DECIMAL(8,2),
        //Observacion VARCHAR(255) NOT NULL,
        //Estado BIT NOT NULL
        public int Id { get; private set; }
        public string IdTipoComprobante { get; private set; }
        public string IdEmpleado { get; private set; }
        public string IdProveedor { get; private set; }
        public string Serie { get; private set; }
        public string Numero { get; private set; }
        public DateTime Fecha { get; private set; }
        public double Total { get; private set; }
        public string Observacion { get; private set; }
        public bool Estado { get; private set; }

        public ClsCompra(string idTipoComprobante, string idEmpleado,
                        string idProveedor, string serie, string numero, 
                        DateTime fecha ,double total, string observacion, 
                        bool estado)
        {
            IdTipoComprobante = idTipoComprobante;
            IdEmpleado = idEmpleado;
            IdProveedor = idProveedor;
            Serie = serie;
            Numero = numero;
            Fecha = fecha;
            Total = total;
            Observacion = observacion;
            Estado = estado;
        }
    }
}

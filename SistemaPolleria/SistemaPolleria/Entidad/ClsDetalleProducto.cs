using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsDetalleProducto
    {
        //Id INT PRIMARY KEY IDENTITY,
        //IdInsumo VARCHAR(4) NULL,
        //IdProducto VARCHAR(6) NULL,
        //Cantidad DECIMAL(6,3) NOT NULL
        public int Id { get; private set; }
        public string IdInsumo { get; private set; }
        public string IdProducto { get; private set; }
        public double Cantidad { get; private set; }

        public ClsDetalleProducto(string idInsumo , string idProducto, double cantidad)
        {
            IdInsumo = idInsumo;
            IdProducto = idProducto;
            Cantidad = cantidad;
        }
    }
}

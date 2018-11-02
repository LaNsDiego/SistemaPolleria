using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsDetalleCompra
    {
        //Id INT PRIMARY KEY IDENTITY,
        //IdCompra INT NOT NULL,
        //IdInsumo VARCHAR(4) NOT NULL,
        //CostoUnitario DECIMAL(6,2) NOT NULL,
        //Cantidad DECIMAL(6,2) NOT NULL,
        //Subtotal DECIMAL(8,2) NOT NULL
        public int Id { get; private set; }
        public int IdCompra { get; private set; }
        public string IdInsumo { get; private set; }
        public double CostoUnitario { get; private set; }
        public double Cantidad { get; private set; }
        public double Subtotal { get; private set; }

        public ClsDetalleCompra(int idCompra, string idInsumo, double costoUnitario, double cantidad, double subtotal)
        {
            IdCompra = idCompra;
            IdInsumo = idInsumo;
            CostoUnitario = costoUnitario;
            Cantidad = cantidad;
            Subtotal = subtotal;
        }
    }
}

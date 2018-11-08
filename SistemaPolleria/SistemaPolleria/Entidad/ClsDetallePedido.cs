using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    public class ClsDetallePedido
    {
        //Id INT PRIMARY KEY IDENTITY,
        //IdPedido VARCHAR(8) NOT NULL,
        //IdProducto VARCHAR(6) NULL,
        //PrecioUnitario DECIMAL(6,2) NOT NULL,
        //Cantidad INT NOT NULL,
        //Subtotal DECIMAL(6,2) NOT NULL
        public int Id { get; private set; }
        public string IdPedido { get; private set; }
        public string IdProducto { get; private set; }
        public double PrecioUnitario { get; private set; }
        public int Cantidad { get; private set; }
        public double Subtotal { get; private set; }

        public ClsDetallePedido(string idPedido, string idProducto, double precioUnitario, int cantidad, double subtotal)
        {
            IdPedido = idPedido;
            IdProducto = idProducto;
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
            Subtotal = subtotal;
        }

        public ClsDetallePedido(int id, string idPedido, string idProducto, double precioUnitario, int cantidad, double subtotal)
        {
            Id = id;
            IdPedido = idPedido;
            IdProducto = idProducto;
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
            Subtotal = subtotal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    public class ClsProducto
    {
        //@Id VARCHAR(6) = NULL
        //,@Nombre VARCHAR(50) = NULL
        //,@PrecioUnitario DECIMAL(6, 2) = NULL
        //,@ValorTotal DECIMAL(6, 2) = NULL
        //,@Cantidad DECIMAL(6, 3) = NULL
        //,@IdTipoProducto INT = NULL
        public string Id { get; private set; }
        public string Nombre { get; private set; }
        public double PrecioUnitario { get; private set; }
        public double ValorTotal { get; private set; }
        public double Cantidad { get; private set; }
        public int IdTipoProducto { get; private set; }

        public ClsProducto(string id, string nombre, double precioUnitario, double valorTotal, double cantidad, int idTipoProducto)
        {
            Id = id;
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            ValorTotal = valorTotal;
            Cantidad = cantidad;
            IdTipoProducto = idTipoProducto;
        }
    }
}

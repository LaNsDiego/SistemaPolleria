using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsInsumo
    {
        //Id VARCHAR(4) PRIMARY KEY,
        //Nombre VARCHAR(50) NOT NULL,
        //Cantidad DECIMAL(6,3) NOT NULL,
        //CostoUnitario DECIMAL(6,2) NOT NULL,
        //CostoTotal DECIMAL(8,2) NOT NULL,
        //IdUnidadMedida INT NOT NULL

        public string Id { get; private set; }
        public string Nombre { get; private set; }
        public double Cantidad { get; private set; }
        public double CostoUnitario { get; private set; }
        public double CostoTotal { get; private set; }
        public int IdUnidadMedida { get; private set; }

        public ClsInsumo(string id, string nombre, double cantidad, double costoUnitario, double costoTotal, int idUnidadMedida)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
            CostoUnitario = costoUnitario;
            CostoTotal = costoTotal;
            IdUnidadMedida = idUnidadMedida;
        }

    }
}

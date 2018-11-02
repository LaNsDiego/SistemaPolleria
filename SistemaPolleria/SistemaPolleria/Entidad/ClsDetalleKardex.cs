using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsDetalleKardex
    {
        public ClsDetalleKardex(string idKardex, DateTime fecha,string idTipoOperacion, 
            string idTipoComprobante, string serie,string numero, double cantidad,
            double costoUnitario, double costoTotal)
        {
            IdKardex = idKardex;
            Fecha = fecha;
            IdTipoOperacion = idTipoOperacion;
            IdTipoComprobante = idTipoComprobante;
            Serie = serie;
            Numero = numero;
            Cantidad = cantidad;
            CostoUnitario = costoUnitario;
            CostoTotal = costoTotal;
        }

        //Id INT  PRIMARY KEY IDENTITY,
        //IdKardex VARCHAR(8) NOT NULL,
        //Fecha DATE NOT NULL,
        //IdTipoOperacion VARCHAR(2) NOT NULL,
        //IdTipoComprobante VARCHAR(2) NOT NULL,
        //Serie  VARCHAR(4) NOT NULL,
        //Numero VARCHAR(4) NOT NULL,
        //Cantidad DECIMAL(6,2) NOT NULL,
        //CostoUnitario DECIMAL(6,2) NOT NULL,
        //CostoTotal DECIMAL(8,2) NOT NULL

        public int Id { get; private set; }
        public string IdKardex { get; private set; }
        public DateTime Fecha { get; private set; }
        public string IdTipoOperacion { get; private set; }
        public string IdTipoComprobante { get; private set; }
        public string Serie { get; private set; }
        public string Numero { get; private set; }
        public double Cantidad { get; private set; }
        public double CostoUnitario { get; private set; }
        public double CostoTotal { get; private set; }
    }
}

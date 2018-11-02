using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Entidad
{
    class ClsKardex
    {


        //Id VARCHAR(8) PRIMARY KEY,
        //Periodo VARCHAR(25) NOT NULL,
        //Ruc DECIMAL(6,2) NULL,
        //RazonSocial DECIMAL(6,2) NOT NULL,
        //IdEstablecimiento VARCHAR(4) NOT NULL,
        //IdInsumo VARCHAR(4) NOT NULL

        public string Id { get; private set; }
        public string Periodo { get; private set; }
        public string Ruc { get; private set; }
        public string RazonSocial { get; private set; }
        public int IdEstablecimiento { get; private set; }
        public string IdInsumo { get; private set; }

        public ClsKardex(string id, string periodo, string ruc, string razonSocial, int idEstablecimiento, string idInsumo)
        {
            Id = id;
            Periodo = periodo;
            Ruc = ruc;
            RazonSocial = razonSocial;
            IdEstablecimiento = idEstablecimiento;
            IdInsumo = idInsumo;
        }
    }
}

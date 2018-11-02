using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaPolleria
{
    public class ClsEmpleado
    {
        public ClsEmpleado(string id, int idCargo, string dni, string nombre, string apellidos)
        {
            Id = id;
            IdCargo = idCargo;
            Dni = dni;
            Nombre = nombre;
            Apellidos = apellidos;
        }

        //Id VARCHAR(6) PRIMARY KEY,
        //IdCargo INT NULL,
        //Dni VARCHAR(8) UNIQUE NOT NULL ,
        //Nombre VARCHAR(50) NULL,
        //Apellidos VARCHAR(50) NULL
        public string Id { get; private set; }
        public int IdCargo { get; private set; }
        public string Dni { get; private set; }
        public string Nombre { get; private set; }
        public string Apellidos { get; private set; }
        //public DateTime FechaNacimiento { get; private set; }
    }
}
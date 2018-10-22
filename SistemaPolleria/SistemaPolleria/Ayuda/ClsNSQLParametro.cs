using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.Ayuda
{
    //esta clase no se usara hasta cuando se haga base de datos :)
    public class ClsNSQLParametro
    {
        public object Valor;
        public string Nombre;
        public SqlDbType Tipo;
        public ClsNSQLParametro(object valor , string nombreColumna, SqlDbType tipo)
        {
            this.Tipo = tipo;
            this.Valor = valor;
            this.Nombre = nombreColumna;
        }
    }
}

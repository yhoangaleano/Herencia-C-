using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Raza
    {
        public Raza(string _pnacionalidad, string _ptipo)
        {
            this._nacionalidad = _pnacionalidad;
            this._tipo = _ptipo;
        }

        public string _nacionalidad { get; set; }

        protected string _tipo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Hombre: Persona
    {
        public Hombre(string _pnacionalidad, string _ptipo)
            : base(_pnacionalidad, _ptipo)
        {

        }



        public bool _barba { get; set; }

        public void mostrarCantidadHermanos()
        {
            this._barba = true;
            base.tipo = "Blanco";
            Console.WriteLine(this._cantidadHermanos);
        }
    }
}

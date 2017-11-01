using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Persona: Raza
    {
        public Persona(string _pnacionalidad, string _ptipo)
            : base(_pnacionalidad, _ptipo)
        {

        }

        public string _nombre { get; set; }
        public string _apellido { get; set; }
        public string _numeroDocumento { get; set; }
        public DateTime _fechaNacimiento { get; set; }
        public double _altura { get; set; }
        public double _peso { get; set; }
        private int _cantidadHijos { get; set; }

        protected int _cantidadHermanos { get; set; }

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public void Saludar()
        {
            Console.WriteLine("Saludando");
        }
    }
}

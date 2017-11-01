using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Mujer: Persona
    {

        public Mujer(string _pnacionalidad, string _ptipo)
            : base(_pnacionalidad, _ptipo)
        {

        }


        public bool _unasPintadas { get; set; }
        

       


        public void PonerseBonitas()
        {
            Console.WriteLine("Me estoy poniendo bonita");
        }
    }
}

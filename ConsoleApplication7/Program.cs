 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hombre yhoan = new Hombre("Colombiano", "Blanco");
            yhoan._barba = true;
            yhoan._nombre = "Yhoan Andres";
            yhoan.mostrarCantidadHermanos();
            yhoan.Saludar();
            yhoan.tipo = "Blanco";

            yhoan._nacionalidad = "Colombia";
            Mujer sofia = new Mujer("Colombiano", "Blanco");
            sofia._unasPintadas = true;
            sofia.PonerseBonitas();
            sofia._nombre = "Luisa Sofia";
            sofia.Saludar();
            sofia.tipo = "Afro";


            Console.ReadLine();
        }

    }
}

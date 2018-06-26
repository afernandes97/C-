using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Fracao f;
            f.numerador = 1;
            f.denominador = 2;

            Console.WriteLine("{0}/{1}", f.numerador, f.denominador);

            Console.ReadKey();
        }
    }

    struct Fracao
    {
        internal int numerador; //field
        internal int denominador;
    }
}

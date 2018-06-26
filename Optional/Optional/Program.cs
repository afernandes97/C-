using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcularRaiz(9,2));
            Console.WriteLine(CalcularRaiz(81,4));
            Console.WriteLine(CalcularRaiz(27,3));
            Console.WriteLine(CalcularRaiz(1024,10));
            Console.WriteLine(CalcularRaiz(9));

            Console.ReadKey();
        }

        static double CalcularRaiz(int x, int y = 2)
        {
            return Math.Pow(x, 1.0 / y);
        }

    }
}

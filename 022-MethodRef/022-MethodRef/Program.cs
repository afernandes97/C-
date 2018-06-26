using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_MethodRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Dobrar(ref x);
            Console.WriteLine(x);

            //F10 - STEP OUT

            Console.ReadKey();
        }

        static void Dobrar(ref int x)
        {
            x *= 2;
        }
    }
}

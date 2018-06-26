using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_MethodDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Elevar(3, 3));
            Console.WriteLine(Elevar(3));
            Console.WriteLine(Elevar(y: 4));

            Console.ReadKey();
        }

        static double Elevar(int x = 2, int y = 1)
        {
            return Math.Pow(x, y);
        }
    }
}

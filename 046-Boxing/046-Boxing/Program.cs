using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Object o = x;

            Alterar(o);

            Console.WriteLine(o);

            Console.ReadKey();
        }

        static void Alterar(Object obj)
        {
            obj = (int)obj + 20;

            Console.WriteLine(obj);
        }
    }
}

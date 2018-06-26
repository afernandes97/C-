using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_MethodOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            int c, d;

            Calcular(a, b, out c, out d);

            Console.WriteLine("{0} {1} {2} {3}", a, b, c, d);

            Console.ReadKey();
        }

        static void Calcular(int x, int y, out int soma, out int produto)
        {
            soma = x + y;
            produto = x * y;
        }
    }
}

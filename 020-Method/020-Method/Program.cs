using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir();
            Imprimir();
            Imprimir();

            Console.WriteLine(Somar(3, 2));
            Console.WriteLine(Somar(30, 20, 40));
            Console.WriteLine(Somar(10.2, 13));

            Console.ReadKey();
        }

        static int Somar(int x, int y)
        {
            return x + y;
        }

        static double Somar(double x, double y)
        {
            return x + y;
        }

        static int Somar(int x, int y, int z)
        {
            return x + y + z;
        }

        static void Imprimir()
        {
            Console.WriteLine("********************");
            Console.WriteLine("   Hello World!!!");
            Console.WriteLine("********************");
        }
    }
}

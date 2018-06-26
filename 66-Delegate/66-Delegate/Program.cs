using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Calculadora();

            var dc = new DelegateCalculadora(c.Somar);

            Console.WriteLine(dc(10,20));

            Console.ReadKey();
        }
    }

    class Calculadora
    {
        internal int Somar(int x, int y) { return x + y; }
        internal int Subtrair(int x, int y) { return x - y; }
        internal static int Multiplicar(int x, int y) { return x * y; }
        internal static double Dividir(int x, int y) { return (double)x / +y; }
    }

    delegate int DelegateCalculadora(int x, int y);
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Calculadora();
            c.x = 10;
            c.y = 23478;

            Console.WriteLine(c.Somar());
            Console.WriteLine(c.Subtrair());

            Console.WriteLine(Calculadora.Multiplicar(10, 320));
            Console.WriteLine(Calculadora.Dividir(2349, 237));

            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Sqrt(81));

            Console.ReadKey();
        }
    }

    class Calculadora 
    {
        internal int x;
        internal int y;

        internal int Somar() { return x + y; }
        internal int Subtrair() { return x - y; }
        
        //static indica que o membro é acessado a partir da classe

        internal static int Multiplicar(int x, int y) { return x * y; }
        internal static int Dividir(int x, int y) { return x / y; }
    }
}

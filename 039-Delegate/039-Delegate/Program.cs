using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Somadora s = new Somadora();

            //Console.WriteLine(s.Somar(10, 1224));

            Delegate d;

            Console.Write("Quer [1] Somar ou [2] Subtrair? ");

            var opcao = Console.ReadLine();

            if (opcao.Equals("1"))
                d = new Delegate(s.Somar);
            else
                if (opcao.Equals("2"))
                    d = new Delegate(s.Subtrair);
                else
                    d = null;

            if (d != null)
            {
                Console.WriteLine(d.Invoke(100, 2143));
                Console.WriteLine(d(10, 200));
            }

            Console.ReadKey();
        }
    }

    class Somadora
    {
        internal int Somar(int x, int y) { return x + y; }
        internal int Subtrair(int x, int y) { return x - y; }
    }

    delegate int Delegate(int x, int y);
}

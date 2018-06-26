using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");

            int x = Int32.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("{0} é par", x);
            }
            else
            {
                Console.WriteLine("{0} é ímpar", x);
            }

            Console.ReadKey();
        }
    }
}

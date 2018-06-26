using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            do
            {
                Console.WriteLine("primeiro do: {0}", x++);
            } while (x <= 5);

            do
            {
                Console.WriteLine("segundo do: {0}", x++);
            } while (x <= 5);

            Console.ReadKey();
        }
    }
}

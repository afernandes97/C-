using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while (x <= 5)
            {
                Console.WriteLine("primeiro while: {0}", x++);
            }

            while (x <= 5)
            {
                Console.WriteLine("segundo while: {0}", x++);
            }

            Console.ReadKey();
        }
    }
}

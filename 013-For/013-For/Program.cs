using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("primeiro for: {0}", i);
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("segundo for: {0}", i);
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "batatinha";
            var b = "batatinha";

            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));

            Console.ReadKey();
        }
    }
}

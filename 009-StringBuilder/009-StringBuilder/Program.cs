using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            sb.Append("oi, ");
            sb.Append("Agnaldo!!!");
            
            Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }
    }
}

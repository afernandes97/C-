using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _072_ClienteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var p = new ProxySomadora.SomadoraClient())
            {
                Console.WriteLine(p.Somar(10,20));
            }

            Console.ReadKey();
        }
    }
}

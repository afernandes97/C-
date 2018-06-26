using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome = "agnaldo";

            foreach (var item in nome)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

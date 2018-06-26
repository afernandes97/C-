using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<String> nomes = new HashSet<String>
            {
                "AGNALDO", 
                "BRUNO", 
                "ANTONIO", 
                "PEDRO"
            };

            nomes.Add("AGNALDO");

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

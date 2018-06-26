using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> nomes = new List<String>
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

            Console.WriteLine();

            ArrayList lista = new ArrayList
            {
                "um", 
                2, 
                DateTime.Now
            };

            lista.Add(23.34);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine(nomes[3]);

            Console.ReadKey();
        }
    }
}

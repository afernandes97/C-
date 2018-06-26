using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Hoje é 04/abril/2018";

            foreach (var item in nome)
            {
                Console.Write("{0} ", item);
            }

            var digitos = from item in nome
                          //where "0123456789".Contains(item)  
                          where Char.IsDigit(item)
                          orderby item descending
                          select item; //comandos

            var naoDigitos = nome
                .Where(item => !Char.IsDigit(item))
                .OrderBy(item => item); //métodos de extensão

            Console.WriteLine("\n\n\n");

            foreach (var item in digitos)
            {
                Console.Write("{0} ", item);
            } 
            
            Console.WriteLine("\n\n\n");

            foreach (var item in naoDigitos)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}

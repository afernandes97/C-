using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_MethodArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 234, 54, 45, 12, 5, 23 };
            Imprimir(numeros);
            
            Console.WriteLine(Somar(numeros));

            Console.WriteLine(Somar(1,2,3,4,5,6,7,344,13,45,23));

            Console.ReadKey();
        }

        private static int Somar(params int[] numeros)
        {
            var retorno = 0;

            foreach (var item in numeros)
            {
                retorno += item; //retorno = retorno + item;
            }

            return retorno;
        }

        static void Imprimir(int[] x)
        {
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}

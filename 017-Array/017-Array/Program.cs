using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros = { 0, 0, 0, 0, 0};

            //var numeros = new int[] { 0, 0, 0, 0, 0 };

            int[] numeros;
            numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = (int)Math.Pow(2, i);    
            }

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

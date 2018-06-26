using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_ArrayMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[,] 
            { 
                {0,0}, {0,1}, {1,0}, 
                {1,1}, {2,0}, {2,1}
            };

            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write("{0} ", x[i,j]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

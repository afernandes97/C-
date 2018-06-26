using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_ArrayJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            //F9 - BREAKPOINT ON/OFF
            //F11 - NEXT LINE

            int[] x = { 1, 2 };
            int[] y = { 10, 20, 30 };
            int[] z = { 100, 200, 300, 400, 500, 600 };

            int[][] a = { x, y, z };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write("{0} ", a[i][j]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

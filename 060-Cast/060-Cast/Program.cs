using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _060_Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10.90;
            var b = (int)a; //unsafe cast

            Console.WriteLine(b);

            Object o = null;

            if (new Random().Next(1, 3) == 1)
                o = "oaoaoaoao";
            else
                o = new Random();

            //var r = (Random)o; //unsafe cast

            var r = o as Random; //safe cast
            
            Console.WriteLine(r);

            Console.ReadKey();
        }
    }
}

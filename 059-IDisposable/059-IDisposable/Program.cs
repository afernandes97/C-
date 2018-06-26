using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059_IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    new Object();

            //    Console.WriteLine(Process.GetCurrentProcess().WorkingSet64);
            //}

            while (true)
            {
                //var o = new Objeto();
                ////GC.Collect(); //existe item para descarte
                //o.Dispose();

                using (new Objeto())
                {
                    Console.WriteLine("dentro do using");
                } 
            }  
        }
    }

    class Objeto : IDisposable
    {
        public Objeto()
        {
            Console.WriteLine("ctor");
        }

        //~Objeto() 
        //{
        //    Console.WriteLine("~Objeto");
        //}

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }
}

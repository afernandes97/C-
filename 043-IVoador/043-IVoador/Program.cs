using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_IVoador
{
    class Program
    {
        static void Main(string[] args)
        {
            Aviao a = new Aviao();
            a.Voar();

            new Passarinho().Voar();
            
            Console.ReadKey();
        }
    }

    interface IVoador
    {
        void Voar();
    }

    class Passarinho : IVoador
    {
        public void Voar()
        {
            Console.WriteLine("o passarinho voou");
        }
    }

    class Aviao : IVoador
    {
        public void Voar()
        {
            Console.WriteLine("o avião voou");
        }
    }
}

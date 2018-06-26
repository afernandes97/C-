using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048_Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
            Morcego m = new Morcego();

            m.Acordar();
            m.Comer();
            m.Voar();
            m.Mamar();
            m.Dormir();

            Console.ReadKey();
        }
    }

    class Animal 
    {
        public void Acordar() { Console.WriteLine("o animal acordou"); }
        public void Comer() { Console.WriteLine("o animal comeu"); }
        public void Dormir() { Console.WriteLine("o animal dormiu"); }
    }

    class Mamifero : Animal
    {
        public void Mamar() { Console.WriteLine("o mamífero mamou"); }
    }

    //sealed indica que a classe não pode ser herdada
    sealed class Morcego : Mamifero 
    {
        public void Voar() { Console.WriteLine("o morcego voou"); }
    }

    //class Batman : Morcego { }

    //class MyString : String { }
}

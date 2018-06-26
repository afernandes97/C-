using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Morcego m = new Morcego();
            Animal m = new Morcego();

            m.Acordar();
            m.Comer();
            //((Morcego)m).Voar();
            //((Mamifero)m).Mamar();
            //((Morcego)m).Mamar();
            m.Dormir();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public void Acordar() { Console.WriteLine("o animal acordou"); }
        public void Comer() { Console.WriteLine("o animal comeu"); }
        
        //virtual indica que o método PODE ser sobreposto
        public virtual void Dormir() { Console.WriteLine("o animal dormiu"); }
    }

    class Mamifero : Animal
    {
        public void Mamar() { Console.WriteLine("o mamífero mamou"); }
    }

    class Morcego : Mamifero
    {
        public void Voar() { Console.WriteLine("o morcego voou"); }
        
        //sealed impede a sobreposição (override) nas classes derivadas
        //override indica que o método é uma sobreposição 
        public sealed override void Dormir() { Console.WriteLine("o morcego dormiu"); }

        //new indica a vontade do programador em ocultar o método de mesmo nome da classe base (método que não seria sobreposto)
        public new void Mamar() { Console.WriteLine("o morcego mamou"); }
        
        public new void Acordar() { Console.WriteLine("o morcego acordou"); }
    }
}

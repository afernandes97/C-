using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            ITomada t;

            Console.Write("Qual o modelo da tomada, [A] ou [B]? ");
            String tomada = Console.ReadLine().ToUpper();

            if(tomada.Equals("A"))
               t = new TomadaA();
            else if(tomada.Equals("B"))
               t = new TomadaB();
            else 
                return;

            t.Ligar();
            t.Desligar();

            Console.ReadKey();
        }
    }

    interface ITomada
    {
        void Ligar();
        void Desligar();
    }

    class TomadaA : ITomada
    {
        public void Ligar()
        {
            Console.WriteLine("a tomada modelo A ligou");
        }

        public void Desligar()
        {
            Console.WriteLine("a tomada modelo A desligou");
        }
    }
    
    class TomadaB : ITomada
    {
        public void Ligar()
        {
            Console.WriteLine("a tomada modelo B ligou");
        }

        public void Desligar()
        {
            Console.WriteLine("a tomada modelo B desligou");
        }
    }
}

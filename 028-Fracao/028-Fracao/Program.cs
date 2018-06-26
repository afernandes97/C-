using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_Fracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Fracao f;
            f = new Fracao();
            f.Numerador = 1;
            f.Denominador = 2;

            Console.WriteLine("{0}/{1}", f.Numerador, f.Denominador);

            Console.ReadKey();
        }
    }

    struct Fracao
    {
        int numerador; //backing field
        int denominador;

        internal int Numerador //property
        {
            get { return numerador; }
            set { numerador = value; }
        }

        internal int Denominador 
        {
            get { return denominador; }
            set 
            {
                if (value == 0)
                    throw new ArgumentException("o valor deve ser diferente de zero");

                denominador = value; 
            }
        }
    }
}

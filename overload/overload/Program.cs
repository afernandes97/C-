using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload
{
    class Program
    {
        static void Main(string[] args)
        {   // SOBRECARGA DE METODO
            
            var objetoSomador = new Somadora();
            
            //Console.WriteLine(objetoSomador.Somar(2,2));
            //Console.WriteLine(objetoSomador.Somar(1,2,3));


            //declarar array
            int[] x;
            //instanciar array
            x = new int[3];

            //atribuicao de valor
            x[1] = 10;

            Console.WriteLine(x[0]);// lendo array
            Console.WriteLine(x[1]);
            Console.WriteLine(x[2]);


            //foreach (var item in x) //foreach é so para leitura (read-only)
            //{
            //    Console.WriteLine("usando for each: {0}", item);
            //}

            for (int i = 0; i < x.Length; i++)//percorrer (read-write) for para alteracao de valor
            {   //length pega a quantidade de item do array
                x[i] = (int)Math.Pow(2, x[i]);
                Console.WriteLine("usando for: {0}", x[i]);
            }

            Console.WriteLine(objetoSomador.Somar(x));

            var y = new int [] {1,2,3,4,5,6,7,8};

            Console.WriteLine(objetoSomador.Somar(y));
            Console.ReadKey();

        }
    }

    // F11 - STEP IN
    // F10 - STEP OVER

    class Somadora
    {
        //internal int Somar(int x, int y)
        //{
        //    return x + y;
        //}

        internal double Somar(double x, double y)
        {
            return x + y;
        }

        internal int Somar(params int[] x)
        {
            var retorno = 0;

            foreach (var item in x)
            {
                retorno += item;
            }
            return retorno;
        }
    }

}

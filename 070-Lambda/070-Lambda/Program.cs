using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _070_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "ORDEM E PROGRESSO";       

            Console.WriteLine();

            //lambda
            Console.WriteLine("lambda Soma: {0}", Sum(10, 40));

            Console.WriteLine();

            //lambda
            var vogais = texto.ToLower()
                .Where(c => "aeiou".Contains(c));

            foreach (var item in vogais)
            {
                Console.WriteLine("{0} ", item);
            }//fimlambda

            Console.WriteLine();

            //filtrar sem lambda
            var naoVogais = texto.ToLower()
                .Where(new Func<char,bool>(Filtrar));

            foreach (var item in naoVogais)
            {
                Console.WriteLine("{0} ",item);
            }//sem lambda

            Console.WriteLine();

            Console.ReadKey();


        }
        //filtrar sem lambda
        static bool Filtrar(char c) { return !"aeiou".Contains(c); }

        //lambda
        static Func<int,int,int> Sum = (x,y) => x+y;
        //fimlambda
    }
}

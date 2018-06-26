using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack q = new Stack(); 

            Stack<String> pessoas = new Stack<String>();

            pessoas.Push("ADAO");
            pessoas.Push("EVA");
            pessoas.Push("CAIM");
            pessoas.Push("ABEL");

            foreach (var item in pessoas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("{0} está no topo da pilha", pessoas.Peek());

            String pessoa = pessoas.Pop();

            Console.WriteLine("removi o(a) {0}", pessoa);

            Console.WriteLine(pessoas.Count);

            Console.ReadKey();
        }
    }
}

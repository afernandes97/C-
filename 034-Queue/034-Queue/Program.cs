using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue q = new Queue(); 

            Queue<String> pessoas = new Queue<String>();

            pessoas.Enqueue("ADAO");
            pessoas.Enqueue("EVA");
            pessoas.Enqueue("CAIM");
            pessoas.Enqueue("ABEL");

            foreach (var item in pessoas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("{0} está no inicio da fila", pessoas.Peek());

            String pessoa = pessoas.Dequeue();

            Console.WriteLine("removi o(a) {0}", pessoa);

            Console.WriteLine(pessoas.Count);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _069_Anonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa { Codigo = 1, Nome = "ze" };

            var q = new { Id=2, Nome="Eva" };

            Console.WriteLine(p);
            Console.WriteLine(q);

            Console.WriteLine(p.GetType());
            Console.WriteLine(q.GetType());

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20, soma = 0, produto = 0;

            CalcularSomaProduto(x, y, out soma, out produto);

            Console.WriteLine(soma);
            Console.WriteLine(produto);

            Console.ReadKey();

            Console.WriteLine();
        }

        static void CalcularSomaProduto(int x, int y, out int soma, out int produto)
        {
            soma = x + y;
            produto = x * y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um número: ");

                double x = Double.Parse(Console.ReadLine());

                if (x == 0)
                    throw new DivideByZeroException("erro de divisão por zero");

                Console.WriteLine(1000 / x);

            }
            catch (Exception e)
            {
                Console.WriteLine("Deu erro!!!");
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

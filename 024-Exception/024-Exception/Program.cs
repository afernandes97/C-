using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            //CTRL+K, CTRL+X - INSERT SNIPPET
            //CTRL+K, CTRL+S - SURROUND WITH

            try
            {
                Console.Write("Digite um número inteiro: ");

                int x = Int32.Parse(Console.ReadLine());

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

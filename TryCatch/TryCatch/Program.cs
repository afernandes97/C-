using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        { //TRYCATCH
            try
            {
                Console.Write("Digite um numero inteiro: ");
                var x = Int32.Parse(Console.ReadLine());

                Console.WriteLine(1000 / x);


            }
            catch ()
            {

            }
            catch (Exception ex)
            {
                //ex.GetType().FullName = traz o tipo do erro
                Console.WriteLine(ex.GetType().FullName);
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);

                //throw;
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

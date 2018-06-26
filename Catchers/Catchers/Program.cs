using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catchers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um numero inteiro: ");
                var x = Int32.Parse(Console.ReadLine());

                Console.WriteLine(1000 / x);


            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Digite um valor diferente de zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite um numero inteiro");
            }
            catch (OverflowException)
            {
                Console.WriteLine("digite um valor entre {0:n0} e {1:n0}", int.MinValue, int.MaxValue);
            }
            catch (Exception ex)
            {
                //ex.GetType().FullName = traz o tipo do erro
                Console.WriteLine(ex.GetType().FullName);
            }
            finally
            {

            }
            Console.ReadKey();
        }
    }
}

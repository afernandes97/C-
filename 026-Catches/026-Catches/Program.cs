using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_Catches
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um número: ");

                int x = Int32.Parse(Console.ReadLine());

                Console.WriteLine(1000 / x);

            }

            catch (OverflowException)
            {
                Console.WriteLine("digite um número inteiro entre {0} e {1}", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("digite um número inteiro diferente de zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("digite um número inteiro");
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

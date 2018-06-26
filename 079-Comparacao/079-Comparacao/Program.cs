using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _079_Comparacao
{
    delegate void DelegateMetodo();
    class Program
    {
        
        static void Main(string[] args)
        {         
            
            Executar(MostrarInstance);
            Executar(MostrarInvoke);
            Executar(MostrarDynamic);

            Console.ReadKey();
        }

        private static void Executar(DelegateMetodo m)
        {
            var s = new Stopwatch();

            s.Start();

            for (int i = 0; i < 100; i++)
            {
                m();              
            }
            Console.WriteLine("     ->{0}", s.ElapsedMilliseconds);
            s.Stop();
        }

        ///////////////////////////////////////


        private static void MostrarDynamic()
        {
            var a = Assembly.GetExecutingAssembly();

            var t = a.GetType("Somadora");

            dynamic sd = Activator.CreateInstance(t, null);
            dynamic x = sd.Somar(1, 2);

            Console.Write(x);
        }

        //reflection
        private static void MostrarInvoke()
        {
            var a = Assembly.GetExecutingAssembly();

            var t = a.GetType("Somadora");

            var cr = Activator.CreateInstance(t, null);

            var mi = t.GetMethod("Somar");

            var x = mi.Invoke(cr, new Object[] { 1, 2 });

            Console.WriteLine(Convert.ToInt32(x));
        }

        //instance
        private static void MostrarInstance()
        {
            var si = new Somadora();
            var x = si.Somar(1, 2);

            Console.WriteLine(x);
        }
    }    
}
class Somadora
{
    public int Somar(int x, int y) { return x + y; }
}
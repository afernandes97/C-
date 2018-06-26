using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Object obj;

            Console.WriteLine("Que tipo de objeto voce quer criar? [S]String, [I]Int, [R]Random");
            var qual = Console.ReadLine().ToUpper()[0];

            switch (qual)
            {
                case 'S': obj = "Andre"; break;
                case 'I': obj = 10 ; break;
                case 'R': obj = new Random(); break;
                default: return;                
            }

            var t = obj.GetType();

            Console.WriteLine(t);
            //type
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.IsValueType);

            Console.WriteLine("Field");

            foreach (var item in t.GetFields())
            {
                Console.WriteLine("{0} => {1}", item, item.GetValue(obj));
            }
            Console.ReadKey();
        }
    }
}

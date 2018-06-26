using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<int, String>();
           
            //dictionary entry

            dic.Add(1, "agnaldo");
            dic.Add(2, "bruno");
            dic.Add(3, "antonio");
            dic.Add(4, "pedro");

            foreach (var item in dic)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in dic.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in dic.Keys)
            {
                Console.WriteLine("{0} -> {1}", item, dic[item]);
            }
      
            Console.ReadKey();
        }
    }
}

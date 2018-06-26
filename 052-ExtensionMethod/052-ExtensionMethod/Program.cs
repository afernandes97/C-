using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringExtension.ContarVogais("AGNALDO"));
            Console.WriteLine("AGNALDO".ContarVogais());
            Console.WriteLine(new String(new char[]{'A','G','N','A','L','D','O'}).ContarVogais());
            
            Console.ReadKey();
        }
    }

    //class MyString : String { }

    static class StringExtension
    {
        public static int ContarVogais(this String s)
        {
            int retorno = 0;

            foreach (var item in s)
            {
                if ("aeiouAEIOU".Contains(item))
                    retorno++;
            }

            return retorno;
        }
    }
}

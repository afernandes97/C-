using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_YieldReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Get())
            {
                Console.WriteLine("no foreach: {0}", item);
            }

            Console.ReadKey();
        }

        //static List<String> Get()
        //{ 
        //    var retorno = new List<String>();

        //    retorno.Add("ADAO");
        //    Console.WriteLine("criei ADAO");
        //    retorno.Add("EVA");
        //    Console.WriteLine("criei EVA");
        //    retorno.Add("CAIM");
        //    Console.WriteLine("criei CAIM");
        //    retorno.Add("ABEL");
        //    Console.WriteLine("criei ABEL");

        //    return retorno;
        //}

        static IEnumerable<String> Get()
        {
            Console.WriteLine("retornei ADAO");
            yield return "ADAO";
            Console.WriteLine("retornei EVA");
            yield return "EVA";
            Console.WriteLine("retornei CAIM");
            yield return "CAIM";
            Console.WriteLine("retornei ABEL");
            yield return "ABEL";
        }
    }
}

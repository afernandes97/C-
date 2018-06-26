using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073_ClienteConsole
{
    //OrderBy
    //OrderByDescending
    //ThenBy
    //ThenByDescending

    class Program
    {
        static void Main(string[] args)
        {
            using (var p = new ProxyPessoaService.PessoaServiceClient())
            {
                foreach (var item in p.Get())
                {
                    Console.WriteLine("{0,3} {1,-50} {2,-10}", item.Id, item.Nome, item.Fumante);
                }
            }

            Console.ReadKey();
        }
    }
}
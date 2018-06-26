using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _071_TesteResultConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<String> task = new Task<String>
            (
                () =>
                {
                    return DateTime.Now.DayOfWeek.ToString();
                }
            );
            
            task.Start();

            Console.WriteLine(task.Result);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //CTRL+K, CTRL+D - reformat

            int dia = 3;

            if (dia == 1)
                Console.WriteLine("dom");
            else if (dia == 2)
                Console.WriteLine("seg");
            else if (dia == 3)
                Console.WriteLine("ter");
            else if (dia == 4)
                Console.WriteLine("qua");
            else if (dia == 5)
                Console.WriteLine("qui");
            else if (dia == 6)
                Console.WriteLine("sex");
            else if (dia == 7)
                Console.WriteLine("sab");
            else
                Console.WriteLine("erro");

            switch (dia)
            {
                case 1: Console.WriteLine("dom"); break;
                case 2: Console.WriteLine("seg"); break;
                case 3: Console.WriteLine("ter"); break;
                case 4: Console.WriteLine("qua"); break;
                case 5: Console.WriteLine("qui"); break;
                case 6: Console.WriteLine("sex"); break;
                case 7: Console.WriteLine("sab"); break;
                default: Console.WriteLine("ops"); break;
            }

            if(dia >=2 && dia <=6)
                Console.WriteLine("dia útil");
            else if(dia == 1 || dia == 7)
                Console.WriteLine("fim de semana");
            else
                Console.WriteLine("ops");

            switch (dia)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6: Console.WriteLine("dia util"); break;
                case 1:
                case 7: Console.WriteLine("fim de semana"); break;
                default: Console.WriteLine("ops"); break;
            }

            Console.ReadKey();
        }
    }
}

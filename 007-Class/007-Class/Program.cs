using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Class
{
    class Program
    {
        static void Main(String[] args)
        {
            //CTRL+SHIFT+N - NEW PROJECT
            //SHIFT+ALT+ENTER - FULL SCREEN

            Pessoa p;
            
            p = new Pessoa();
            
            p.codigo = 1;
            p.nome = "ADAO";
            p.sexo = 'M';

            var q = new Pessoa() 
            {
                codigo = 2,
                nome = "EVA",
                sexo = 'F'
            };

            Console.WriteLine("{0} - {1} - {2}", p.codigo, p.nome, p.sexo);
            Console.WriteLine("{0} - {1} - {2}", q.codigo, q.nome, q.sexo);

            Console.WriteLine(p == q);

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        internal int codigo;
        internal String nome;
        internal char sexo;
    }
}

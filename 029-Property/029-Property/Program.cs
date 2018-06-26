using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa() 
            {
                Codigo = 1, 
                Nome = "ADAO", 
                Idade = 23,
                Sexo = 'M', 
                Salario = 12908
            };

            Console.WriteLine(p.Codigo);
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Idade);
            Console.WriteLine(p.Sexo);
            //Console.WriteLine(p.Salario);
            Console.WriteLine("{0:c}", p.LerSalario());

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public int Codigo { get; set; } //autoimplemented property
        public String Nome { get; set; }
        public char Sexo { get; set; }

        private int idade;

        public int Idade
        {
            get { return idade; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("a idade deve ser positiva");

                idade = value; 
            }
        }

        public double Salario { private get; set; }

        public double LerSalario() { return Salario; }
    }
}

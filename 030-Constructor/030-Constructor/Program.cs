using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa(1, "adao");

            p.Escrever();

            Pessoa q = new Pessoa();

            q.Escrever();

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        int codigo;
        String nome;

        public Pessoa(int codigo = 0, String nome = "não informado")
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public void Escrever()
        {
            Console.WriteLine("{0} - {1}", codigo, nome);
        }
    }
}

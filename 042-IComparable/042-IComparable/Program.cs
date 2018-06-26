using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarStrings();
            
            Console.WriteLine();

            MostrarPessoas();

            Console.ReadKey();
        }

        private static void MostrarPessoas()
        {
            Pessoa[] pessoas = 
            {
                new Pessoa{Codigo = 1, Nome = "ADAO"}, 
                new Pessoa{Codigo = 2, Nome = "EVA"}, 
                new Pessoa{Codigo = 3, Nome = "CAIM"}, 
                new Pessoa{Codigo = 4, Nome = "ABEL"}, 
                new Pessoa{Codigo = 5, Nome = "SETH"}
            };

            Array.Sort(pessoas);

            foreach (var item in pessoas)
            {
                Console.WriteLine("{0} -> {1}", item.Codigo, item.Nome);
            }
        }

        private static void MostrarStrings()
        {
            String[] nomes = 
            {
                "AGNALDO", 
                "BRUNO", 
                "ANTONIO", 
                "PEDRO"
            };

            Array.Sort(nomes);

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
        }
    }

    //class Pessoa : IComparable
    //{
    //    public int Codigo { get; set; }
    //    public String Nome { get; set; }

    //    public int CompareTo(object obj)
    //    {
    //        Pessoa outra = (Pessoa)obj;

    //        return this.Nome.CompareTo(outra.Nome);
    //    }
    //}

    class Pessoa : IComparable<Pessoa>
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }

        public int CompareTo(Pessoa outra)
        {
            return this.Nome.CompareTo(outra.Nome);
        }
    }
}
